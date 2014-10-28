[string]$copyTo = "$([System.Environment]::GetFolderPath("mydocuments"))\Visual Studio 2013\Visualizers"
[string]$mainAssemblyPath = "..\..\lib\net45\*.*"
[string]$binDependenciesAssemblyPath = "..\binDependencies\*.*"
if (!(Test-Path -LiteralPath $copyTo))
{
    New-Item -Path $copyTo -ItemType directory
}
xcopy "$mainAssemblyPath" "$copyTo" /Y
xcopy "$binDependenciesAssemblyPath" "$copyTo" /Y