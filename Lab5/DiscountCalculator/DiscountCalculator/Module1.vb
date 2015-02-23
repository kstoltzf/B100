Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim customerType As String
        Dim subtotal, discountPercent, discountAmount, total As Double

        Console.WriteLine("Enter 'New' for new customer, 'VIP' for VIP customer, or 'Other' for all others ")
        customerType = Console.ReadLine
        Console.WriteLine("Enter subtotal ")
        subtotal = CDbl(Console.ReadLine)

        If customerType = "New" Then  'New customer
            Select Case subtotal
                Case Is > 250
                    discountPercent = 25
                Case Is >= 100
                    discountPercent = 15
                Case Else
                    discountPercent = 10
            End Select

        ElseIf customerType = "VIP" Then  'VIP customer
            Select Case subtotal
                Case Is < 250
                    discountPercent = 20
                Case Else
                    discountPercent = 30
            End Select
        Else
            discountPercent = 5
        End If

        discountAmount = subtotal * (discountPercent / 100)
        total = subtotal - discountAmount

        Console.WriteLine("Customer type is " & customerType)
        Console.WriteLine("Subtotal is " & subtotal)
        Console.WriteLine("Discount percentage is " & discountPercent)
        Console.WriteLine("Discount amount is " & discountAmount)
        Console.WriteLine("Total is " & total)

        Console.ReadLine()

    End Sub

End Module
