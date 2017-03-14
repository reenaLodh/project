Public Class updateform

    Private Sub upbutton_Click(sender As Object, e As EventArgs) Handles upbutton.Click
        viewupdates.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        studentform3.Show()
        Me.Visible = False
    End Sub
End Class