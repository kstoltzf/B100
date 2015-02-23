Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim numberArray(9, 9) As Integer
        Dim row, column As Integer
        Dim count As Integer = 9

        For column = numberArray.GetUpperBound(0) To 0 Step -1
            For row = 0 To numberArray.GetUpperBound(1)
                numberArray(column, row) = 1

                If numberArray(row, column) = 1 Then
                    Console.Write("{0}", count)
                Else
                    Console.Write(" ")
                End If
            Next

            Console.WriteLine()
            count -= 1  'update count
        Next

        Console.ReadLine()
    End Sub

End Module
