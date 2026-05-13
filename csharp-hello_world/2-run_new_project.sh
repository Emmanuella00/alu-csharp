#!/usr/bin/env bash
dotnet new console -o 2-run_new_project
dotnet build 2-run_new_project/
dotnet run --project 2-run_new_project/