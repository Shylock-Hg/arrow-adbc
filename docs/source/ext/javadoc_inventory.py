# Licensed to the Apache Software Foundation (ASF) under one
# or more contributor license agreements.  See the NOTICE file
# distributed with this work for additional information
# regarding copyright ownership.  The ASF licenses this file
# to you under the Apache License, Version 2.0 (the
# "License"); you may not use this file except in compliance
# with the License.  You may obtain a copy of the License at
#
#   http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing,
# software distributed under the License is distributed on an
# "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
# KIND, either express or implied.  See the License for the
# specific language governing permissions and limitations
# under the License.

"""Generate a Sphinx inventory for a Javadoc site."""

from __future__ import annotations

import argparse
import json
import urllib.parse
from pathlib import Path

import sphinx.util.inventory
from fake_inventory import (
    FakeBuildEnvironment,
    FakeBuilder,
    FakeDomain,
    FakeEnv,
    FakeObject,
)


def extract_index(data: str, prelude: str) -> list:
    epilogue = ";updateSearchResults();"
    if not data.startswith(prelude):
        raise ValueError(
            f"Cannot parse search index; expected {prelude!r} but found {data[:50]!r}"
        )
    if data.endswith(epilogue):
        data = data[len(prelude) : -len(epilogue)]
    else:
        # Some JDK versions appear to generate without the epilogue
        data = data[len(prelude) :]
    return json.loads(data)


def make_fake_domains(root: Path, base_url: str) -> dict[str, FakeDomain]:
    if not base_url.endswith("/"):
        base_url += "/"

    # Scrape the search index generated by Javadoc
    # https://github.com/openjdk/jdk17/blob/4afbcaf55383ec2f5da53282a1547bac3d099e9d/src/jdk.javadoc/share/classes/jdk/javadoc/internal/doclets/toolkit/util/IndexItem.java#L515
    # "p" is containing package
    # "m" is containing module
    # "c" is containing class
    # "l" is label
    # "u" is the URL anchor

    with open(root / "type-search-index.js") as f:
        data = extract_index(f.read(), "typeSearchIndex = ")
    with open(root / "member-search-index.js") as f:
        data.extend(extract_index(f.read(), "memberSearchIndex = "))
    with open(root / "package-search-index.js") as f:
        data.extend(extract_index(f.read(), "packageSearchIndex = "))

    domains = {
        "std": FakeDomain(objects=[]),
    }

    for item in data:
        if "p" not in item:
            # Non-code item (package, or index)
            if "All " in item["l"]:
                # Ignore indices ("All Packages")
                continue
            # This is a package
            name = item["l"]
            url = f"{item['l'].replace('.', '/')}/package-summary.html"
            anchor = ""
            typ = "javapackage"
            domain = "std"
        elif "c" in item:
            # This is a class member
            name = f"{item['p']}.{item['c']}#{item['l']}"
            url = f"{item['p'].replace('.', '/')}/{item['c']}.html"
            anchor = item["u"] if "u" in item else item["l"]
            typ = "javamember"
            domain = "std"
        else:
            # This is a class/interface
            name = f"{item['p']}.{item['l']}"
            url = f"{item['p'].replace('.', '/')}/{item['l']}.html"
            anchor = ""
            typ = "javatype"
            domain = "std"

        url = urllib.parse.urljoin(base_url, url)
        domains[domain].objects.append(
            FakeObject(
                name=name,
                dispname=name,
                typ=typ,
                docname=url,
                anchor=anchor,
                prio=1,
            )
        )

    return domains


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("project", help="Project name.")
    parser.add_argument("version", help="Project version.")
    parser.add_argument("path", type=Path, help="Path to the generated Javadocs.")
    parser.add_argument("url", help="Eventual base URL of the Javadocs.")

    args = parser.parse_args()

    domains = make_fake_domains(args.path, args.url)
    config = FakeEnv(project=args.project, version=args.version)
    env = FakeBuildEnvironment(config=config, domains=domains)

    output = args.path / "objects.inv"
    sphinx.util.inventory.InventoryFile.dump(
        str(output),
        env,
        FakeBuilder(),
    )
    print("Wrote", output)


if __name__ == "__main__":
    main()
