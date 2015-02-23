Module Module1

    Sub Main()

        Dim radius, area, circumference As Double
        Const PI = 3.14159

        Console.Write("Please enter the radius of the circle? ")
        radius = Console.ReadLine()                 'read input for radius
        area = PI * radius * radius                 'calculate area
        circumference = 2 * PI * radius              'calculate circumference
        'print out area and circumference
        Console.WriteLine("Area = " & area)
        Console.WriteLine("Circumference = " & circumference)

        Console.ReadLine()       'just to pause the program.

    End Sub

End Module
