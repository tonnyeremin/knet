Write-Host "Kubernets C# API automation build script"

Write-Host "****************************************"
Write-Host "MIT License 2.0

Copyright (c) 2017 Anton Eremin

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ""Software""), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software."

Write-Host "****************************************"


$csharp_directory = Join-Path  -Path $PSScriptRoot  -ChildPath 'CSharp_Kubernetes'
$swaggerfile = Join-Path  -Path $PSScriptRoot -ChildPath 'swagger.json'
$dllfile = Join-Path  -Path $PSScriptRoot -ChildPath 'KuberentesService.dll'

Remove-Item $csharp_directory  -Recurse -ErrorAction Ignore
Remove-Item $swaggerfile -ErrorAction Ignore
Remove-Item $dllfile -ErrorAction Ignore

New-Item -ItemType directory -Path $csharp_directory

Write-Host 'Dowloading Kubernetes api description from: https://github.com/kubernetes/kubernetes'
(New-Object Net.WebClient).DownloadFile('https://raw.githubusercontent.com/kubernetes/kubernetes/master/api/openapi-spec/swagger.json', 'swagger.json')

Write-Host 'Ensure autorest utility is installed: https://github.com/Azure/autorest'

$env:path += ";$env:APPDATA\npm"
$autoRest = Get-Command -Name AutoRest


Write-Host 'Generating C# api:' + $csharp_directory

.$autoRest --input-file=swagger.json --csharp --output-folder=CSharp_Kubernetes --namespace=KuberentesService
Write-Host "KB: Fix paramеters namming issue at constructor Iok8sapiextensionsApiserverpkgapisapiextensionsv1beta1JSONSchemaProps.cs line 35. 
(ex: Change ref to _ref). Then press any key."

Read-Host

Install-Package -Name Microsoft.Net.Compilers -Source https://www.nuget.org/api/v2 -Scope CurrentUser

$package = Get-Package -Name Microsoft.Net.Compilers
$env:path += ";$(Split-Path $package.Source -Parent)\tools"
$csc = Get-Command -Name CSC.exe


Write-Host 'Building .Net library...'
.$csc /target:library /out:$dllfile /recurse:$csharp_directory\*.cs 

Read-Host






