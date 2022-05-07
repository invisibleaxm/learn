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


#This is a test
