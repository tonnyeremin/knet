Write-Host "Kubernets C# API automation build script"

Write-Host "***************************************************************************"
Write-Host "MIT License 2.0

Copyright (c) 2017 Anton Eremin

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ""Software""), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software."

Write-Host "***************************************************************************"


$csharp_directory = Join-Path  -Path $PSScriptRoot  -ChildPath 'CSharp_Kubernetes'
$swaggerfile = Join-Path  -Path $PSScriptRoot -ChildPath 'swagger.json'
$dllfile = Join-Path  -Path $PSScriptRoot -ChildPath 'KuberentesService.dll'

Install-Package -Name Microsoft.Net.Compilers -Source https://www.nuget.org/api/v2 -Scope CurrentUser

$package = Get-Package -Name Microsoft.Net.Compilers
$env:path += ";$(Split-Path $package.Source -Parent)\tools"
$csc = Get-Command -Name CSC.exe


Write-Host 'Building .Net library...'
.$csc /target:library /out:$dllfile /recurse:$csharp_directory\*.cs 


Read-Host






