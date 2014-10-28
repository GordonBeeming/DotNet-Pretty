$ScriptDir = Split-Path $MyInvocation.MyCommand.Path -Parent
[System.Diagnostics.Process]::Start("http://bing.com/?q=$ScriptDir")