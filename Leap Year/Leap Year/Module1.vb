Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim year As Integer
        Dim y, n As String
        Dim answer As String

        Console.Write("Enter year ")
        year = CInt(Console.ReadLine())
        y = "Yes - "
        n = "No - "

        If year Mod 4 = 0 Then
            answer = y
        Else : answer = n
        End If

        If year Mod 100 = 0 Then
            answer = n
        End If

        If year Mod 400 = 0 Then
            answer = y
        End If

        If answer = y Then
            Console.WriteLine(y & year)
        Else : Console.WriteLine(n & year)
        End If

        Console.ReadLine()

    End Sub

End Module
