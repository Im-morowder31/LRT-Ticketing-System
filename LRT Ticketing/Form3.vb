Imports System.Runtime.CompilerServices
Public Class Form3
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form2.Close()
    End Sub
    Public Property Origintxt As String
    Public Property Destinationtxt As String
    Public Property Discounttxt As String

    Public Property gross As Integer
    Public Property net As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentDateTime As DateTime = DateTime.Now

        Dim currentDate As Date = currentDateTime.Date
        Dim currentTime As TimeSpan = currentDateTime.TimeOfDay
        lblDate.Text = currentDate.ToString("MM-dd-yyyy")

        Dim amPm As String
        Dim hours As Integer = currentTime.Hours
        If hours >= 12 Then
            amPm = "PM"
            If hours > 12 Then
                hours -= 12
            End If
        Else
            amPm = "AM"
            If hours = 0 Then
                hours = 12
            End If
        End If
        lblTime.Text = hours.ToString("00") & ":" & currentTime.Minutes.ToString("00") & " " & amPm

        txtOrigin.Text = Origintxt
        txtDestination.Text = Destinationtxt
        txtDiscount.Text = Discounttxt

        txtGross.Text = Format(gross, "₱#,##.00")
        txtNet.Text = Format(net, "₱#,##.00")




        If Discounttxt = "GOVERNMENT EMPLOYEE (10%)" Then
            txtDiscount.Text = "GOV. EMP. (10%)"
        ElseIf Discounttxt = "SENIOR CITIZEN (20%)" Then
            txtDiscount.Text = "SR. CITIZEN (20%)"
        End If

    End Sub

    Private Sub btnClear_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClear.MouseDown
        btnClear.Image = My.Resources.ClearDown
    End Sub
    Private Sub btnClear_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClear.MouseUp
        btnClear.Image = My.Resources.ClearUp
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class