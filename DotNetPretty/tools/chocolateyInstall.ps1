[System.Diagnostics.Process]::Start("http://bing.com/?q=$pwd")
Write-Content "N:\temp\info.txt" $pwd