[string]$ScriptDir = Split-Path $MyInvocation.MyCommand.Path -Parent
[string]$copyTo = "$([System.Environment]::GetFolderPath("mydocuments"))\Visual Studio 2013\Visualizers"
[string]$mainAssemblyPath = "$ScriptDir\..\..\lib\net45\*.*"
[string]$binDependenciesAssemblyPath = "$ScriptDir\..\binDependencies\*.*"
if (!(Test-Path -LiteralPath $copyTo))
{
    New-Item -Path $copyTo -ItemType directory
}
Copy-Item -Path "$mainAssemblyPath" -Destination "$copyTo" -Force
Copy-Item -Path "$binDependenciesAssemblyPath" -Destination "$copyTo" -Force