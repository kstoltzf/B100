' This progrma is demo the use of random number gnerator
' Author: Liqiang Zhang

Option Strict On
Option Explicit On

Module RandomDemo

    Sub Main()

        Console.WriteLine("Generating 5 psuedo-random numbers in the range of [0, 1):")
        For i As Integer = 1 To 5
            Console.WriteLine(Rnd())
        Next

        Console.ReadLine()      ' Just to pause the program

        Console.WriteLine(vbCrLf & "Generating 5 psuedo-random integers in the range of [1, 100]: ")
        For i As Integer = 1 To 5
            Console.WriteLine(CInt(Math.Floor((100 * Rnd()) + 1)))
        Next

        Console.ReadLine()      ' Just to pause the program

        Console.WriteLine(vbCrLf & "Now, we randomize the random generator.")
        Randomize()
        Console.WriteLine("Generating 5 psuedo-random integers in the range of [1, 100]: ")
        For i As Integer = 1 To 5
            Console.WriteLine(MyRand(1, 100))
        Next

        Console.ReadLine()      ' Just to pause the program

    End Sub
    ' returns a random integer in the range of [lowestValue, highestValue]
    Private Function MyRand(ByVal LowestValue As Integer, ByVal highestValue As Integer) As Integer

        Return CInt(Math.Floor((highestValue - LowestValue + 1) * Rnd()) + LowestValue)

    End Function

End Module
