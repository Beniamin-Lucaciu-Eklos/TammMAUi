Get-ChildItem .\ -include 'bin', 'obj', '.vs' -Recurse | foreach ($_) {
	Write-Host "Deleting: $($_.fullname)"
	remove-item $_.fullname -Force -Recurse 
}