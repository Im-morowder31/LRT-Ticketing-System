Public Class Form1

    Private WithEvents form2 As Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblPercentProg.Text = pbLoading1.Value & "%"

        pbLoading1.Value += 1

        If pbLoading1.Value = 100 Then
            form2 = New Form2()
            form2.Show()
            Me.Hide()
            Timer1.Dispose()

        End If
    End Sub
End Class
