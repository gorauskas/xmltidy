#!/bin/sh

# Build XMLTidy on Linux using Mono
# if the mcs/gmcs binary is not recognized, you may need to install it

if [ -d "./bin" ]; then
    echo "Build output directory already exists."
else
    echo "Create build output directory."
    mkdir ./bin
fi

echo "Start program build"

cp ./mono/Mono.Options.dll ./bin/Mono.Options.dll
cp ./mono/Mono.Options.dll.mdb ./bin/Mono.Options.dll.mdb
gmcs -pkg:dotnet /r:System.Xml.Linq.dll /r:./bin/Mono.Options.dll /nologo /out:./bin/xmltidy.exe AssemblyInfo.cs Program.cs

echo "DONE! Run mono ./bin/xmltidy.exe --help for usage"
echo "."


