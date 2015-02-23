Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim wage, hours, income As Double
        Dim runAgain As String

        Do
            Console.Write("Please enter the wage per hour: ")
            wage = CDbl(Console.ReadLine)
            Console.Write("Please enter the hours worked (must not be greater than 160): ")
            hours = CDbl(Console.ReadLine)
            Do
                If hours >= 160 Then
                    Console.Write("Please enter the hours worked (must not be greater than 160): ")
                    hours = CDbl(Console.ReadLine)
                End If
            Loop Until hours < 160
            income = calculateWage(wage, hours)
            Console.WriteLine(String.Format("The total earnings is {0:C}", income))
            Console.WriteLine(vbCrLf & ("Would you like to do another calculation (y/n)?"))
            runAgain = Console.ReadLine
        Loop While runAgain = "y"
        Console.WriteLine("Thanks for using this program, bye bye!")
        Console.ReadLine()
    End Sub
    Private Function calculateWage(ByVal hourlyWage As Double, ByVal hoursWorked As Double) As Double
        Dim overtimeWage, totalIncome, overtimeHours, overtimeIncome As Double

        If hoursWorked <= 40 Then
            totalIncome = hourlyWage * hoursWorked
        Else
            overtimeHours = hoursWorked - 40
            overtimeWage = hourlyWage * 1.5
            overtimeIncome = overtimeHours * overtimeWage
            totalIncome = (hourlyWage * 40) + overtimeIncome
        End If

        Return totalIncome
    End Function


End Module
