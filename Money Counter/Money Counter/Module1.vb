Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim totalCents, dollar, quarter, dime, nickel, penny As Integer

        Console.Write("Enter Cents ")
        totalCents = CInt(Console.ReadLine())
        dollar = totalCents \ 100
        quarter = (totalCents Mod 100) \ 25
        dime = (totalCents Mod 25) \ 10
        nickel = ((totalCents Mod 25) Mod 10) \ 5
        penny = totalCents Mod 5

        Console.WriteLine("Dollars - " & dollar)
        Console.WriteLine("Quarters - " & quarter)
        Console.WriteLine("Dimes - " & dime)
        Console.WriteLine("Nickels - " & nickel)
        Console.WriteLine("Pennies - " & penny)

        Console.ReadLine()

    End Sub

End Module
