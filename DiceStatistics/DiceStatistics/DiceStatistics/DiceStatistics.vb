' This program allows you repeatedly roll 12 dice 
' while showing the statistics of each face.
Option Strict On
Option Explicit On

Public Class DiceStatistics

    Dim ones As Integer = 0 ' count of die face 1
    Dim twos As Integer = 0 ' count of die face 2
    Dim threes As Integer = 0 ' count of die face 3
    Dim fours As Integer = 0 ' count of die face 4
    Dim fives As Integer = 0 ' count of die face 5
    Dim sixes As Integer = 0 ' count of die face 6

    Private Sub DiceStatistics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Randomize()     ' Seed the random number generator when the main form is loaded

    End Sub

   ' display result of twelve rolls
    Private Sub rollButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rollButton.Click

        ' display 12 randomly selected die faces
        DisplayDie(die1PictureBox)
        DisplayDie(die2PictureBox)
        DisplayDie(die3PictureBox)
        DisplayDie(die4PictureBox)
        DisplayDie(die5PictureBox)
        DisplayDie(die6PictureBox)
        DisplayDie(die7PictureBox)
        DisplayDie(die8PictureBox)
        DisplayDie(die9PictureBox)
        DisplayDie(die10PictureBox)
        DisplayDie(die11PictureBox)
        DisplayDie(die12PictureBox)

        Dim total As Integer = ones + twos + threes + fours + fives + sixes

        ' display frequencies of faces
        displayTextBox.Text = _
           "Face" & vbTab & "Frequency" & vbTab & "Percent" & vbCrLf & _
           "1" & vbTab & ones & vbTab & vbTab & _
           String.Format("{0:P2}", ones / total) & vbCrLf & _
           "2" & vbTab & twos & vbTab & vbTab & _
           String.Format("{0:P2}", twos / total) & vbCrLf & _
           "3" & vbTab & threes & vbTab & vbTab & _
           String.Format("{0:P2}", threes / total) & vbCrLf & _
           "4" & vbTab & fours & vbTab & vbTab & _
           String.Format("{0:P2}", fours / total) & vbCrLf & _
           "5" & vbTab & fives & vbTab & vbTab & _
           String.Format("{0:P2}", fives / total) & vbCrLf & _
           "6" & vbTab & sixes & vbTab & vbTab & _
          String.Format("{0:P2}", sixes / total)
    End Sub ' rollButton_Click

   ' display a single die image
   Sub DisplayDie(ByVal diePictureBox As PictureBox)
        Dim face As Integer = Rand(1, 6)

      ' retrieve specific die image from resources
      Dim pictureResource = My.Resources.ResourceManager.GetObject(String.Format("die{0}", face))

      ' convert pictureResource to image type and load into PictureBox
      diePictureBox.Image = CType(pictureResource, Image)

      ' maintain count of die faces
      Select Case face
         Case 1 ' die face 1
            ones += 1
         Case 2 ' die face 2
            twos += 1
         Case 3 ' die face 3
            threes += 1
         Case 4 ' die face 4
            fours += 1
         Case 5 ' die face 5
            fives += 1
         Case 6 ' die face 6
            sixes += 1
      End Select
    End Sub ' DisplayDie

    ' returns a random integer in the range of [lowestValue, highestValue]
    Private Function Rand(ByVal LowestValue As Integer, ByVal highestValue As Integer) As Integer

        Return CInt(Math.Floor((highestValue - LowestValue + 1) * Rnd()) + LowestValue)

    End Function

End Class ' DiceStatistics
