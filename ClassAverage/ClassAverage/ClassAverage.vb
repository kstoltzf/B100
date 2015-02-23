' Counter-controlled repetition: Class-average problem.
Public Class ClassAverage
   ' variables declared in the class, but not inside the class's methods
   ' can be used in all of the class's methods
   Dim aCount As Integer ' count of A grades             
   Dim bCount As Integer ' count of B grades             
   Dim cCount As Integer ' count of C grades             
   Dim dCount As Integer ' count of D grades             
   Dim fCount As Integer ' count of F grades
   Dim perfectScoreCount As Integer ' count of perfect scores

   ' places a grade in the gradesListBox
    Private Sub submitGradeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitGradeButton.Click

        Dim grade As Double = Val(gradeTextBox.Text) ' get grade

        ' add the grade to the end of the gradesListBox
        gradesListBox.Items.Add(grade)
        gradeTextBox.Clear() ' clear the gradeTextBox

        ' add 1 to appropriate counter for specified grade
        Select Case grade ' determine which grade was entered
            Case 100 ' perfect score
                perfectScoreCount += 1 ' increment perfectScoreCount
                aCount += 1 ' increment aCount
            Case Is >= 90   ' grade was in the range of [90, 100)
                aCount += 1 ' increment aCount
            Case Is >= 80   ' grade was in the range of [80, 90)
                bCount += 1 ' increment bCount
            Case Is >= 70   ' grade was in the range of [70, 80)
                cCount += 1 ' increment cCount
            Case Is >= 60   ' grade was in the range of [60, 70)
                dCount += 1 ' increment dCount
            Case Else ' grade was less than 60
                fCount += 1 ' increment fCount
        End Select

        gradeTextBox.Focus() ' gives the focus to the gradeTextBox
    End Sub ' submitGradeButton_Click

   ' calculates the class average based on the grades in gradesListBox
   Private Sub calculateAverageButton_Click(ByVal sender As System.Object,ByVal e As System.EventArgs) Handles calculateAverageButton.Click

        Dim total As Double ' sum of grades entered by user
        Dim gradeCounter As Integer ' counter for grades 
        Dim grade As Double ' grade input by user
        Dim average As Double ' average of grades
        Dim subtractAverage As Double
        Dim subtractAverageTotal As Double
        Dim deviation As Double  'standard deviation

        ' initialization phase
        total = 0 ' set total to zero before adding grades to it
        gradeCounter = 0 ' prepare to loop

        ' processing phase
        Do While gradeCounter < gradesListBox.Items.Count
            grade = gradesListBox.Items(gradeCounter)   ' get next grade
            total += grade      ' add grade to total
            gradeCounter += 1   ' add 1 to gradeCounter
        Loop

        ' termination phase
        If gradeCounter <> 0 Then
            average = total / gradeCounter ' calculate average

            gradeCounter = 0  'prepare to loop
            Do While gradeCounter < gradesListBox.Items.Count
                grade = gradesListBox.Items(gradeCounter)  'get next grade
                subtractAverage = (grade - average) ^ 2  'subtract average from grade and square the answer
                subtractAverageTotal += subtractAverage  'add subtractAverage to subtractAverageTotal
                gradeCounter += 1
            Loop
            gradeCounter = gradesListBox.Items.Count  'reset gradeCounter to number of items in the gradesListBox
            deviation = (subtractAverageTotal / gradeCounter) ^ 0.5 'calculate standard deviation

            ' display total and average (with two digits of precision)
            classAverageLabel.Text = "Total of the " & gradeCounter & " grade(s) is " & total & vbCrLf & "Class average is " & String.Format("{0:F}", average) & vbCrLf & vbCrLf

           'diplay standard deviation (with two digits of precision)
            classAverageLabel.Text &= "The standard deviation of the class is " & String.Format("{0:F}", deviation) & vbCrLf & vbCrLf

            ' display summary of letter grades
         classAverageLabel.Text &= "Letter grade summary:" & vbCrLf & "A: " & aCount & vbCrLf & "B: " & bCount & vbCrLf & "C: " & cCount & vbCrLf & "D: " & dCount & vbCrLf & "F: " & fCount &vbCrLf & "Perfect scores: " & perfectScoreCount
        Else
            classAverageLabel.Text = "No grades were entered"
        End If
    End Sub ' calculateAverageButton_Click

   ' clears grades from gradeListBox and results from classAverageLabel
    Private Sub clearGradesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearGradesButton.Click

        gradesListBox.Items.Clear() ' removes all items from gradesListBox
        classAverageLabel.Text = String.Empty ' clears classAverageLabel
    End Sub ' clearGradesButton_Click
End Class ' ClassAverage


