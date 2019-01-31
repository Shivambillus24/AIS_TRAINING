function divide(){                             #function to divide two numbers
try {
    $c = $num1/$num2
    Write-Host ('The answer is :')       
    $c                                       
}
catch [DivideByZeroException]{
    Write-Host ('There is a divide by zero exception')  #divide by zero exception will occur
}
}
try {
Write-Host ('Enter the first numbers:')
[INT]$num1 = Read-Host                      #input 1st number
Write-Host ('Enter the second numbers:')
[INT]$num2 = Read-Host                      #input 2nd number
divide $num1, $num2                         #function call to divide two numbers
}
catch {
    Write-Host ('Error has occured')      #general catch all if any other error occurres
    Write-Host $_.Exception.Message
    }