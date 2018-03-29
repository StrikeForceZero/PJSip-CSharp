#!/usr/bin/env bash
make symbol
node convert.js
cd csharp
cmd /C swigmake.cmd
cp src/* ../../../../pjsua2_net/Classes
cp pjsua2_wrap.* ../../../../pjsua2
echo "done"
