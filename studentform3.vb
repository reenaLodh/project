Public Class studentform3

    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click
        addstudent.Show()
        Me.Visible = False


    End Sub

    Private Sub StudentInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentInformationToolStripMenuItem.Click

    End Sub

    Private Sub BcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BcaToolStripMenuItem.Click
        viewbca.Show()
        Me.Visible = False

    End Sub

    Private Sub BbaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BbaToolStripMenuItem.Click
        viewbba.Show()
        Me.Visible = False
    End Sub

    Private Sub BcisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BcisToolStripMenuItem.Click
        viewbcis.Show()
        Me.Visible = False
    End Sub

    Private Sub AllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllToolStripMenuItem.Click
        viewall.Show()
        Me.Visible = False

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        updateform.Show()
        Me.Visible = False
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        searchform.Show()
        Me.Visible = False

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        delete.Show()
        Me.Visible = False

    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        changepassword.Show()
        Me.Visible = False
    End Sub

    Private Sub CahngePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CahngePasswordToolStripMenuItem.Click

    End Sub
End Class