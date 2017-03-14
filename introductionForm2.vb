Public Class introductionForm2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        studentform3.Show()
        Me.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Visible = False
    End Sub
End Class