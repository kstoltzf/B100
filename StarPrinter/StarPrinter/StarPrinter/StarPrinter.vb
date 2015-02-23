'***************************************************************************
' This is a practice to help students get familar with nested loops
' Author: Liqiang Zhang
' **************************************************************************
Option Strict On
Option Explicit On

Module StarPrinter

    Sub Main()
        Dim i, j As Integer

        For i = 1 To 10
            For j = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next

        ' Loops - Group Activity - Problem#1 - "Print Stars"
        '          *
        '         **
        '        ***
        '       ****
        '      *****
        '     ******
        '    *******
        '   ********
        '  *********
        ' ********** 

        Console.WriteLine()

        For i = 1 To 10
            For j = 1 To 10 - i
                Console.Write(" ")
            Next
            For j = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next

        Console.ReadLine()      ' Just to pause the program

    End Sub

End Module
