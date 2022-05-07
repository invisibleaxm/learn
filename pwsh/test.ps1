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

Write-Output "Hello World"
$subscriptionId = (New-Guid)
Write-Output "Your new guid is : $subscriptionId"
Write-Output -InputObject "Hello World"

#This is a test
