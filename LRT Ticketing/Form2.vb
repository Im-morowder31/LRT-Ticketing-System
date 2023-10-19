Imports System.Runtime.CompilerServices

Public Class Form2
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Close()
    End Sub

    Private Sub btnReset_MouseDown(sender As Object, e As MouseEventArgs) Handles btnReset.MouseDown
        btnReset.Image = My.Resources.ResetDown
    End Sub
    Private Sub btnReset_MouseUp(sender As Object, e As MouseEventArgs) Handles btnReset.MouseUp
        btnReset.Image = My.Resources.ResetUp
    End Sub

    Private Sub btnProcess_MouseDown(sender As Object, e As MouseEventArgs) Handles btnProcess.MouseDown
        btnProcess.Image = My.Resources.ProcessDown
    End Sub
    Private Sub btnProcess_MouseUp(sender As Object, e As MouseEventArgs) Handles btnProcess.MouseUp
        btnProcess.Image = My.Resources.ProcessUp
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cbFrom.SelectedIndex = -1
        cbTo.SelectedIndex = -1
        cbDiscount.SelectedIndex = -1
    End Sub



    Dim dis As Integer
    Dim FinalAns As Double
    Dim ans As Integer
    Dim mul As Integer
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        If cbDiscount.SelectedIndex = -1 Or cbFrom.SelectedIndex = -1 Or cbTo.SelectedIndex = -1 Then
            MessageBox.Show("Please complete all the requirements!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf cbFrom.SelectedIndex = cbTo.SelectedIndex Then
            MessageBox.Show("Please choose unlike destination!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            Dim form3 As New Form3
            If cbFrom.SelectedIndex > cbTo.SelectedIndex Then


                ans = cbFrom.SelectedIndex - cbTo.SelectedIndex
                mul = ans * 20
                If cbDiscount.SelectedIndex = 0 Then
                    FinalAns = mul
                ElseIf cbDiscount.SelectedIndex = 1 Or cbDiscount.SelectedIndex = 2 Then
                    dis = mul - (mul * 0.1)
                    FinalAns = dis
                ElseIf cbDiscount.SelectedIndex = 3 Then
                    dis = mul - (mul * 0.2)
                    FinalAns = dis
                ElseIf cbDiscount.SelectedIndex = 4 Then
                    dis = mul - (mul * 0.5)
                    FinalAns = dis
                End If

            ElseIf cbTo.SelectedIndex > cbFrom.SelectedIndex Then


                ans = cbTo.SelectedIndex - cbFrom.SelectedIndex
                mul = ans * 20
                If cbDiscount.SelectedIndex = 0 Then
                    FinalAns = mul
                ElseIf cbDiscount.SelectedIndex = 1 Or cbDiscount.SelectedIndex = 2 Then
                    dis = mul - (mul * 0.1)
                    FinalAns = dis
                ElseIf cbDiscount.SelectedIndex = 3 Then
                    dis = mul - (mul * 0.2)
                    FinalAns = dis
                ElseIf cbDiscount.SelectedIndex = 4 Then
                    dis = mul - (mul * 0.5)
                    FinalAns = dis
                End If
            End If
            form3.Origintxt = cbFrom.SelectedItem
            form3.Destinationtxt = cbTo.SelectedItem
            form3.Discounttxt = cbDiscount.SelectedItem

            form3.gross = mul
            form3.net = FinalAns


            form3.Show()
            Me.Hide()

            cbDiscount.SelectedIndex = -1
            cbFrom.SelectedIndex = -1
            cbTo.SelectedIndex = -1
        End If
    End Sub

End Class