Option Strict On
Option Explicit On

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WageCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.WagePerHour = New System.Windows.Forms.Label()
        Me.HoursWorked = New System.Windows.Forms.Label()
        Me.Earnings = New System.Windows.Forms.Label()
        Me.LblTotalEarnings = New System.Windows.Forms.Label()
        Me.TxtBoxHourlyWage = New System.Windows.Forms.TextBox()
        Me.TxtBoxHoursWorked = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(239, 15)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculate.TabIndex = 0
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'WagePerHour
        '
        Me.WagePerHour.AutoSize = True
        Me.WagePerHour.Location = New System.Drawing.Point(21, 18)
        Me.WagePerHour.Name = "WagePerHour"
        Me.WagePerHour.Size = New System.Drawing.Size(83, 13)
        Me.WagePerHour.TabIndex = 1
        Me.WagePerHour.Text = "Wage per Hour:"
        '
        'HoursWorked
        '
        Me.HoursWorked.AutoSize = True
        Me.HoursWorked.Location = New System.Drawing.Point(21, 65)
        Me.HoursWorked.Name = "HoursWorked"
        Me.HoursWorked.Size = New System.Drawing.Size(79, 13)
        Me.HoursWorked.TabIndex = 2
        Me.HoursWorked.Text = "Hours Worked:"
        '
        'Earnings
        '
        Me.Earnings.AutoSize = True
        Me.Earnings.Location = New System.Drawing.Point(21, 107)
        Me.Earnings.Name = "Earnings"
        Me.Earnings.Size = New System.Drawing.Size(51, 13)
        Me.Earnings.TabIndex = 3
        Me.Earnings.Text = "Earnings:"
        '
        'LblTotalEarnings
        '
        Me.LblTotalEarnings.AutoSize = True
        Me.LblTotalEarnings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalEarnings.Location = New System.Drawing.Point(139, 105)
        Me.LblTotalEarnings.Name = "LblTotalEarnings"
        Me.LblTotalEarnings.Size = New System.Drawing.Size(69, 15)
        Me.LblTotalEarnings.TabIndex = 4
        Me.LblTotalEarnings.Text = "                    "
        '
        'TxtBoxHourlyWage
        '
        Me.TxtBoxHourlyWage.Location = New System.Drawing.Point(138, 18)
        Me.TxtBoxHourlyWage.Name = "TxtBoxHourlyWage"
        Me.TxtBoxHourlyWage.Size = New System.Drawing.Size(66, 20)
        Me.TxtBoxHourlyWage.TabIndex = 5
        '
        'TxtBoxHoursWorked
        '
        Me.TxtBoxHoursWorked.Location = New System.Drawing.Point(138, 65)
        Me.TxtBoxHoursWorked.Name = "TxtBoxHoursWorked"
        Me.TxtBoxHoursWorked.Size = New System.Drawing.Size(66, 20)
        Me.TxtBoxHoursWorked.TabIndex = 6
        '
        'WageCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 144)
        Me.Controls.Add(Me.TxtBoxHoursWorked)
        Me.Controls.Add(Me.TxtBoxHourlyWage)
        Me.Controls.Add(Me.LblTotalEarnings)
        Me.Controls.Add(Me.Earnings)
        Me.Controls.Add(Me.HoursWorked)
        Me.Controls.Add(Me.WagePerHour)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Name = "WageCalculator"
        Me.Text = "Wage Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCalculate As System.Windows.Forms.Button
    Friend WithEvents WagePerHour As System.Windows.Forms.Label
    Friend WithEvents HoursWorked As System.Windows.Forms.Label
    Friend WithEvents Earnings As System.Windows.Forms.Label
    Friend WithEvents LblTotalEarnings As System.Windows.Forms.Label
    Friend WithEvents TxtBoxHourlyWage As System.Windows.Forms.TextBox
    Friend WithEvents TxtBoxHoursWorked As System.Windows.Forms.TextBox

    Private Sub BtnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles BtnCalculate.Click
        Dim hours, wage As Double
        hours = CDbl(TxtBoxHoursWorked.Text)
        wage = CDbl(TxtBoxHourlyWage.Text)

        CalculateIncome(hours, wage)

    End Sub

    Private Sub CalculateIncome(ByVal hoursWorked As Double, ByVal hourlyWage As Double)
        Dim overtimeWage, totalIncome, overtimeHours, overtimeIncome As Double

        If hoursWorked >= 168 Then
            MessageBox.Show("Hours worked must be less than or equal to 168", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If hoursWorked <= 40 Then
                totalIncome = hourlyWage * hoursWorked
            Else
                overtimeHours = hoursWorked - 40
                overtimeWage = hourlyWage * 1.5
                overtimeIncome = overtimeHours * overtimeWage
                totalIncome = (hourlyWage * 40) + overtimeIncome
            End If
        End If
        LblTotalEarnings.Text = String.Format("{0:C}", totalIncome)
    End Sub
End Class
