Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim intArray(5) As Integer ' An integer array with six elements
        Dim choice As Integer ' to take the user choice from the menu
        Dim filled As Boolean = False ' The intial status of the array is unfilled.
        Dim quit As Boolean = False ' Will become true if user choose to quit.
        Do
            Console.WriteLine("----------------------------------------------------------")
            Console.WriteLine("Please select a choice:")
            Console.WriteLine("1 ----------- Fill the array")
            Console.WriteLine("2 ----------- Print out all the numbers of the array")
            Console.WriteLine("3 ----------- Find the Maximal number is the array")
            Console.WriteLine("4 ----------- Find the Minimal number in the array")
            Console.WriteLine("5 ----------- Print out all the odd numbers in the array")
            Console.WriteLine("6 ----------- Find the average of the array")
            Console.WriteLine("7 ----------- Print out all the prime numbers in the array")
            Console.WriteLine("0 ----------- quit")
            Console.WriteLine("----------------------------------------------------------")
            choice = CInt(Console.ReadLine())
            Select Case choice
                Case 1
                    FillArray(intArray)
                    filled = True ' after calling FillArray(), the array should have been filled now.
                Case 2
                    If (filled) Then
                        PrintArray(intArray)
                    Else
                        Console.WriteLine("The array has not been filled yet, please choose choice 1 first.")
                    End If
                Case 3
                    If (filled) Then
                        Console.WriteLine("The maximal number in the array is " & FindMax(intArray))
                    Else
                        Console.WriteLine("The array has not been filled yet, please choose choice 1 first.")
                    End If
                Case 4
                    If (filled) Then
                        Console.WriteLine("The minimal number in the array is " & FindMin(intArray))
                    Else
                        Console.WriteLine("The array has not been filled yet, please choose choice 1 first.")
                    End If
                Case 5
                    If (filled) Then
                        PrintOdds(intArray)
                    Else
                        Console.WriteLine("The array has not been filled yet, please choose choice 1 first.")
                    End If
                Case 6
                    If (filled) Then
                        FindAverage(intArray)
                    Else
                        Console.WriteLine("The array has not been filled yet, please choose choice 1 first.")
                    End If
                Case 7
                    If (filled) Then
                        PrintPrimes(intArray)
                    Else
                        Console.WriteLine("The array has not been filled yet, please choose choice 1 first.")
                    End If
                Case Else
                    quit = True
            End Select
        Loop While (Not quit)
        Console.WriteLine("Thanks for using the program. Bye bye!") ' Try to be friendly
        Console.ReadLine() ' Just to pause the program
    End Sub
    Private Sub FillArray(ByRef numberArray() As Integer)
        Dim index As Integer

        Console.WriteLine("Please enter 6 natural numbers.")

        For index = 0 To 5
            numberArray(index) = CInt(Console.ReadLine)
        Next index
    End Sub
    Private Sub PrintArray(ByVal numberArray() As Integer)
        Dim index As Integer

        For index = 0 To numberArray.GetUpperBound(0)
            Console.WriteLine("Number {0} is: {1}", index, numberArray(index))
        Next
    End Sub
    Private Function FindMax(ByVal numberArray() As Integer) As Integer
        Dim index, highest As Integer

        For index = 0 To numberArray.GetUpperBound(0)
            If numberArray(index) > highest Then
                highest = numberArray(index)
            Else
                highest = highest
            End If
        Next
        Return highest
    End Function
    Private Function FindMin(ByVal numberArray() As Integer) As Integer
        Dim index As Integer
        Dim lowest As Integer = numberArray(0)

        For index = 1 To numberArray.GetUpperBound(0)
            If numberArray(index) < lowest Then
                lowest = numberArray(index)
            Else
                lowest = lowest
            End If
        Next
        Return lowest
    End Function
    Private Sub PrintOdds(ByVal numberArray() As Integer)
        Dim index As Integer
        Dim isOdd As Boolean

        For index = 0 To numberArray.GetUpperBound(0)
            If numberArray(index) Mod 2 = 1 Then
                isOdd = True
            Else
                isOdd = False
            End If
            If isOdd = True Then
                Console.WriteLine("Number {0}: {1} is odd.", index, numberArray(index))
            Else
                Continue For
            End If

        Next
    End Sub
    Private Sub FindAverage(ByVal numberArray() As Integer)
        Dim average As Double
        Dim sum, index As Integer

        For index = 0 To numberArray.GetUpperBound(0)
            sum += numberArray(index)
        Next
        average = sum / (numberArray.GetUpperBound(0) + 1)
        Console.WriteLine(String.Format("The average of the array is {0:#.00}", average))
    End Sub
    Private Sub PrintPrimes(ByVal numberArray() As Integer)
        Dim isPrime As Boolean
        Dim index As Integer
        Dim number As Integer

        For index = 0 To numberArray.GetUpperBound(0)
            For number = 2 To (numberArray(index) \ 2)
                If numberArray(index) Mod number = 0 Then
                    isPrime = False
                Else
                    isPrime = True
                End If
            Next
            If isPrime = True Then
                Console.WriteLine("Number {0}: {1} is prime", index, numberArray(index))
            Else
                Continue For
            End If
        Next
       
    End Sub
End Module
