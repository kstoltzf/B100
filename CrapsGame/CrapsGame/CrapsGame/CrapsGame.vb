' Craps game using random number generator.
' Author: Kyle Stoltzfus

Option Strict On
Option Explicit On

Public Class CrapsGame

    Dim myPoint As Integer ' total point if not 2, 3, 12, 7 or 11
    Dim myDie1 As Integer ' die1 face
    Dim myDie2 As Integer ' die2 face

    Private Sub CrapsGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Randomize()     ' Seed the random number generator when the main form is loaded 

    End Sub

    ' begins new game and determines point
    Private Sub playButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles playButton.Click

        ' initialize for new game
        myPoint = 0
        pointGroupBox.Text = "Point"
        statusLabel.Text = String.Empty

        ' remove point-die images
        pointDie1PictureBox.Image = Nothing
        pointDie2PictureBox.Image = Nothing

        ' roll dice and get the sum
        Dim sum As Integer = RollDice()


        ' check the sum and determine the status of the game
        ' the buttons should be correctly enabled or disabled.
        '***add code here***

        If sum = 7 Or sum = 11 Then
            statusLabel.Text = "You Win!!!"
        ElseIf sum = 2 Or sum = 3 Or sum = 12 Then
            statusLabel.Text = "Sorry. You Lose."
        Else
            myPoint = sum
            statusLabel.Text = "Roll Again!"
            pointGroupBox.Text = ("Point is " & myPoint)
            playButton.Enabled = False
            rollButton.Enabled = True
            DisplayDie(pointDie1PictureBox, myDie1)
            DisplayDie(pointDie2PictureBox, myDie2)
        End If


    End Sub ' playButton_Click

    ' determines outcome of next roll
    ' the buttons should be correctly enabled or disabled 
    Private Sub rollButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rollButton.Click

        ' roll dice and get sum
        '***add code here***

        Dim sum As Integer = RollDice()

        ' check the sum and determine the status of the game
        ' the buttons should be correctly enabled or disabled 
        '***add code here***

        If sum = myPoint Then
            statusLabel.Text = "You Win!!!"
            playButton.Enabled = True
            rollButton.Enabled = False
        ElseIf sum = 7 Then
            statusLabel.Text = "Sorry. You Lose."
            playButton.Enabled = True
            rollButton.Enabled = False
        End If


    End Sub ' rollButton_Click

    ' display a die image in a pictureBox
    Sub DisplayDie(ByVal diePictureBox As PictureBox, ByVal face As Integer)

        ' retrieve specific die image from resources
        Dim pictureResource = My.Resources.ResourceManager.GetObject(String.Format("die{0}", face))

        ' convert pictureResource to image type and load into PictureBox
        diePictureBox.Image = CType(pictureResource, Image)
    End Sub ' DisplayDie


    ' Roll two dies, display their images, and then return the sum of the two faces 
    Function RollDice() As Integer
        ' roll the two dice
        '***add code here***
        myDie1 = Rand(1, 6)
        myDie2 = Rand(1, 6)

        ' display rolls
        '***add code here***
        DisplayDie(die1PictureBox, myDie1)
        DisplayDie(die2PictureBox, myDie2)

        ' return sum
        Return myDie1 + myDie2
    End Function ' RollDice

    ' returns a random integer in the range of [lowestValue, highestValue]
    Private Function Rand(ByVal LowestValue As Integer, ByVal highestValue As Integer) As Integer

        Return CInt(Math.Floor((highestValue - LowestValue + 1) * Rnd()) + LowestValue)

    End Function

End Class ' Craps

