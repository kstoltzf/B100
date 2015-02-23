Module Module1

    Sub Main()
        Dim starArray(9, 19) As Integer
        Dim row, column As Integer
        Dim columnEnd As Integer = 19

        For row = 0 To starArray.GetUpperBound(0)
            For column = 1 To columnEnd
                starArray(row, column) = 1

                If starArray(row, column) = 1 Then
                    Console.Write("*")
                Else
                    Console.Write(" ")
                End If
            Next
            Console.WriteLine()
            columnEnd -= 1
        Next
        Console.ReadLine()
    End Sub

End Module
