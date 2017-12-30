#!/usr/bin/env bash
mono .paket/paket.exe restore
mono packages/build-deps/FAKE/tools/FAKE.exe build.fsx Publish
