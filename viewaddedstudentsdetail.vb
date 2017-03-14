Public Class viewaddedstudentsdetail

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles back.Click
        studentform3.Show()
        Me.Visible = False
    End Sub

    Private Sub Student_detailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Student_detailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._student_information_systemDataSet)

    End Sub

    Private Sub viewaddedstudentsdetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_student_information_systemDataSet.student_details' table. You can move, or remove it, as needed.
        Me.Student_detailsTableAdapter.Fill(Me._student_information_systemDataSet.student_details)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.Student_detailsTableAdapter.FillBy(Me._student_information_systemDataSet.student_details)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class