Module Module1

    Sub Main()
        Dim starArray(9, 19) As Integer
        Dim row, column As Integer

        For row = 0 To 0
            For column = 1 To 19
                starArray(row, column) = 1
            Next
        Next

        For row = 1 To 1
            For column = 2 To 18
                starArray(row, column) = 1
            Next
        Next

        For row = 2 To 2
            For column = 3 To 17
                starArray(row, column) = 1
            Next
        Next
        For row = 3 To 3
            For column = 4 To 16
                starArray(row, column) = 1
            Next
        Next
        For row = 4 To 4
            For column = 5 To 15
                starArray(row, column) = 1
            Next
        Next
        For row = 5 To 5
            For column = 6 To 14
                starArray(row, column) = 1
            Next
        Next

        For row = 6 To 6
            For column = 7 To 13
                starArray(row, column) = 1
            Next
        Next
        For row = 7 To 7
            For column = 8 To 12
                starArray(row, column) = 1
            Next
        Next
        For row = 8 To 8
            For column = 9 To 11
                starArray(row, column) = 1
            Next
        Next

        For row = 9 To 9
            For column = 10 To 10
                starArray(row, column) = 1
            Next
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
