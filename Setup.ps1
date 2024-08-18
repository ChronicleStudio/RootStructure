
$vaild = $false
do {
	$answer = read-host "Is Vintage Story installed to default directory? Yes or no? "
    if ($answer -eq 'yes') { 
        $vaild = $true
        [Environment]::SetEnvironmentVariable("VINTAGE_STORY", ($pwd.path), "User") 
        break
    } elseif ($answer -eq 'no') {
        $vaild = $true
        $vaild2 = $false
        do {
	        $path = read-host "Enter Install path for Vintage Story: "
	        if (-not (Test-Path $path)) {
		        write "Directory does not exist, Try Again"
	        } else {
		        $vaild2 = $true
		        [Environment]::SetEnvironmentVariable("VINTAGE_STORY", $path, "User") 
                break
	        }
            write $valid2
        } until ($vaild2 -eq $true)
        break
    } else {
	    write "Invalid Answer, Try Again"
    }
    write $vaild
} until ($valid -eq $true)

dotnet --list-sdks

$vaild = $false
do {
	$answer = read-host "Is .NET 7.0 SDK Installed? Reference list above. Yes or no? "
    if ($answer -eq 'yes') { 
        $vaild = $true
        break
    } elseif ($answer -eq 'no') { 
        $vaild = $true
        .\dotnet-install.ps1 -Version 7.0.102
        break
    } else {
	    write "Invalid Answer, Try Again"
    }
    write $vaild
} until ($valid -eq $true)
dotnet new install VintageStory.Mod.BasicTemplate