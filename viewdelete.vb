Public Class viewdelete

    Private Sub Student_detailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Student_detailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._student_information_systemDataSet)

    End Sub

    Private Sub viewdelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_student_information_systemDataSet.student_details' table. You can move, or remove it, as needed.
        Me.Student_detailsTableAdapter.Fill(Me._student_information_systemDataSet.student_details)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        delete.Show()
        Me.Visible = False
    End Sub
End Class