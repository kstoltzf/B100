'***************************************************************************
' This is a practice to help students get familar with Arrays
' Author: Liqiang Zhang
' **************************************************************************

Module GradeArray

    Sub Main()

        Dim grade(5) As Double
        Dim index As Integer = 0

        Console.WriteLine("Please enter the grades for 6 students.")

        For index = 0 To grade.GetUpperBound(0)
            Do
                Console.WriteLine("Grade must be in the range of [0, 100]. Enter grade {0}: ", index + 1)
                grade(index) = CDbl(Console.ReadLine())
            Loop While (grade(index) < 0 Or grade(index) > 100)
        Next

        Console.WriteLine()
        Console.WriteLine("You have entered the following grades:")
        For index = 0 To grade.GetUpperBound(0)
            Console.Write("{0,4}", grade(index))
        Next

        Dim sum, average As Double
        Dim highest, lowest As Double
        sum = grade(0)
        highest = grade(0)
        lowest = grade(0)

        For index = 1 To grade.GetUpperBound(0)
            sum += grade(index)
            If grade(index) > highest Then
                highest = grade(index)
            End If
            If grade(index) < lowest Then
                lowest = grade(index)
            End If
        Next
        average = sum / grade.Length

        Console.WriteLine()
        Console.WriteLine("The average of the class is: {0, 4:.##}", average)
        Console.WriteLine("The highest grade is: {0, 4}", highest)
        Console.WriteLine("The lowest grade is: {0, 4}", lowest)

        Console.ReadLine()      ' Pause the program

    End Sub

End Module
