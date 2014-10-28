[string]$copyTo = "$([System.Environment]::GetFolderPath("mydocuments"))\Visual Studio 2013\Visualizers"
if (!(Test-Path -LiteralPath $copyTo))
{
    New-Item -Path $copyTo -ItemType directory
}
xcopy ..\..\lib\net45\*.* "$copyTo" /Y
xcopy ..\binDependencies\*.* "$copyTo" /Y