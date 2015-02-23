'***************************************************************************
' This is a practice to help students get started with subroutines
' Author: Liqiang Zhang
' **************************************************************************
Option Strict On
Option Explicit On

Module ShapePrinter

    Sub Main()


        Console.WriteLine("First, we will draw a rectangle.")
        Console.Write("Please enter the length of the rectangle: ")
        Dim length As Integer = CInt(Console.ReadLine())
        Console.Write("Please enter the width of the rectangle: ")
        Dim width As Integer = CInt(Console.ReadLine())

        PrintRectangle(length, width)
        Console.WriteLine()         ' insert an empty line

        Console.WriteLine("Next, we will draw an isosceles right triangle.")
        Console.Write("Please enter the length of the legs: ")
        Dim leg As Integer = CInt(Console.ReadLine())
        PrintTriangle(leg)

        Console.ReadLine()          'Just to pause the program

    End Sub

    Private Sub PrintRectangle(ByVal length As Integer, ByVal Width As Integer)
        Dim i, j As Integer

        For i = 1 To Width
            For j = 1 To length
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub

    Private Sub PrintTriangle(ByVal legSize As Integer)
        Dim i, j As Integer

        For i = 1 To legSize
            For j = 1 To i
                Console.Write("*")
            Next
            Console.WriteLine()
        Next

    End Sub

End Module
