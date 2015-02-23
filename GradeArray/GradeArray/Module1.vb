Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim scores(5), average, highest, lowest As Double
        Dim index As Integer

        Console.WriteLine("Please enter the grades for six students.")
       
        For index = 0 To scores.GetUpperBound(0)
            Do
                Console.WriteLine("Grade must be in the range of [0, 100]. Please enter grade {0}:", index +1)
                scores(index) = CDbl(Console.ReadLine)
            Loop While scores(index) > 100 Or scores(index) < 0
        Next index

        highest = scores(0)
        For index = 0 To scores.GetUpperBound(0)
            If scores(index) > highest Then
                highest = scores(index)
            End If
        Next index

        lowest = scores(0)
        For index = 0 To scores.GetUpperBound(0)
            If scores(index) < lowest Then
                lowest = scores(index)
            End If
        Next

        average = (scores(0) + scores(1) + scores(2) + scores(3) + scores(4) + scores(5)) / 6

        Console.WriteLine("You have entered the following grades: ")
        Console.WriteLine("  {0}  {1}  {2}  {3}  {4}  {5}", scores(0), scores(1), scores(2), scores(3), scores(4), scores(5))
        Console.WriteLine("The average of the class is: {0, 4:.##}", average)
        Console.WriteLine("The highest grade is: " & highest)
        Console.WriteLine("The lowest grade is: " & lowest)

        Dim value As Double
        Dim continueLoop As String

        Do 'make sure all variables reset to zero before starting a new search
            Dim equal As Integer = 0
            Dim higher As Integer = 0
            Dim lower As Integer = 0

            Console.Write(vbCrLf & ("Please enter the grade to search for: "))
            value = CDbl(Console.ReadLine())

            For index = 0 To scores.GetUpperBound(0) 'search array for grades
                If scores(index) = value Then  'find number of grades that equal the search value
                    equal += 1
                ElseIf scores(index) > value Then 'find number of grades that are higher than the search value
                    higher += 1
                Else                          'find the number of grades that are lower than the search value
                    lower += 1
                End If
            Next index

            Console.WriteLine("{0, -5} grade(s) match(es) the grade you entered.", equal)
            Console.WriteLine("{0, -5} grade(s) in the class are higher than you entered.", higher)
            Console.WriteLine("{0, -5} grade(s) in the class are lower than you entered.", lower)
            Console.Write(vbCrLf & "Would you like to do another search?  (y/n): ")
            continueLoop = Console.ReadLine()
        Loop While continueLoop = "y"
        'continue loop until users enters "n"

        Console.WriteLine("Bye bye!")
        Console.ReadLine()
    End Sub

End Module
