#!/usr/local/bin/pwsh
function HelloWorld {
  param(
    [parameter(Mandatory)]
    [string]$Greeting
  )
  Write-Output "$Greeting World!"
}


#Calling function HelloWorld


HelloWorld -Greeting "Hello"

$subscriptionId = (New-Guid)
Write-Output "Your new guid is : $subscriptionId"

Write-Output "This is a test"
Write-Output -InputObject "Test"
