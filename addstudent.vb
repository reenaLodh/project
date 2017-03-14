Imports System.Data.SqlClient


Public Class addstudent
    Dim sqlcon As SqlConnection
    Dim sqlconstring As String
    Dim sqlcmd As SqlCommand
    Dim sqlrdr As SqlDataReader
    Dim sqlstmt As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        studentform3.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlconstring = "Data Source=user;Initial Catalog=student.information.system;Integrated Security=True"
        sqlcon = New SqlConnection(sqlconstring)
        sqlcon.Open()
        Try
            sqlstmt = "insert into studentsinfo values("
            sqlstmt = sqlstmt & "'" & tid.Text & "',"
            sqlstmt = sqlstmt & "'" & tfname.Text & "',"
            sqlstmt = sqlstmt & "'" & tlname.Text & "',"
            sqlstmt = sqlstmt & "'" & Cmbgender.Text & "',"
            sqlstmt = sqlstmt & "'" & cmbprogram.Text & "',"
            sqlstmt = sqlstmt & "'" & cmbsem.Text & "',"
            sqlstmt = sqlstmt & "'" & dateofbirthdatetimepicker.Value & "',"
            sqlstmt = sqlstmt & "'" & tcontact.Text & "',"
            sqlstmt = sqlstmt & "'" & taddress.Text & "')"

            sqlcmd = New SqlCommand(sqlstmt, sqlcon)

            sqlrdr = sqlcmd.ExecuteReader()
            MsgBox("Added Successfully...")
            showstudentdetails.show()
            Me.Visible = False

        Catch ex As Exception
            MsgBox("There was an error...")

        End Try
        sqlrdr.Close()
        sqlcmd.Dispose()




      
    End Sub
End Class