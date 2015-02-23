Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim number As Integer
        Dim isPrime As Boolean

        Do
            Console.Write("Please enter a natural number: ")
            number = CInt(Console.ReadLine)
        Loop While number < 1

        If number = 1 Then
            Console.WriteLine("{0} is not a prime number.", number)
        End If

        If number = 2 Then
            Console.WriteLine("{0} is a prime number.", number)
        End If

        If number > 2 Then
            isPrime = True
            For factor = 2 To number \ 2
                If number Mod factor = 0 Then
                    isPrime = False
                End If
            Next
            If (isPrime) Then
                Console.WriteLine("{0} is a prime number.", number)
            Else
                Console.WriteLine("{0} is not a prime number.", number)
            End If
        End If

        Console.ReadLine()
    End Sub

End Module
