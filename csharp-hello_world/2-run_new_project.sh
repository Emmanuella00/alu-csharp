#!/usr/bin/env bash
rm -rf 2-new_project
dotnet new console -o 2-new_project
sed -i 's/Hello, World!/Hello World!/g' 2-new_project/Program.cs
dotnet build 2-new_project/
dotnet run --project 2-new_project/