Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim starArray(9, 19) As Integer
        Dim row, column As Integer
        Dim columnStart As Integer = 1
        Dim columnEnd As Integer = 19

        For row = 0 To starArray.GetUpperBound(0)
            For column = columnStart To columnEnd
                starArray(row, column) = 1
            Next
            columnStart += 1
            columnEnd -= 1
        Next

        For row = 0 To starArray.GetUpperBound(0)
            For column = 0 To starArray.GetUpperBound(1)
                If starArray(row, column) = 1 Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module
