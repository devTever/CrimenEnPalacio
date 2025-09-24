# Script: publish.ps1
# Publica el proyecto .NET como self-contained y genera un ZIP

# 1. Limpiamos y publicamos el proyecto
dotnet publish CrimenEnPalacio.csproj `
    -c Release `
    -r win-x64 `
    --self-contained true `
    /p:PublishSingleFile=true `
    /p:IncludeAllContentForSelfExtract=true `
    -o ./publish/win-x64

# 2. Creamos un archivo ZIP con la salida
$zipPath = "./CrimenEnPalacio-v1.2-win-x64.zip"
if (Test-Path $zipPath) { Remove-Item $zipPath }
Compress-Archive -Path ./publish/win-x64/* -DestinationPath $zipPath

Write-Host "✅ Publicación completada. Archivo generado en $zipPath"
