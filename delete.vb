Public Class delete

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        studentform3.Show()
        Me.Visible = False
    End Sub

    Private Sub delbutton_Click(sender As Object, e As EventArgs) Handles delbutton.Click
        viewdelete.Show()
        Me.Visible = False

    End Sub
End Class