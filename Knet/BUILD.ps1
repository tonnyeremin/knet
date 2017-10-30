
Write-Host 'Dowloading Kubernetes api description from: https://github.com/kubernetes/kubernetes'
(New-Object Net.WebClient).DownloadFile('https://github.com/kubernetes/kubernetes/blob/master/api/openapi-spec/swagger.json', 'swagger.json')




