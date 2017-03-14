<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentform3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BbaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BcisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CahngePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Blue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentInformationToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.SearchToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(985, 45)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentInformationToolStripMenuItem
        '
        Me.StudentInformationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.StudentInformationToolStripMenuItem.Name = "StudentInformationToolStripMenuItem"
        Me.StudentInformationToolStripMenuItem.Size = New System.Drawing.Size(264, 41)
        Me.StudentInformationToolStripMenuItem.Text = "student information"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.BackColor = System.Drawing.Color.Blue
        Me.AddStudentToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(236, 42)
        Me.AddStudentToolStripMenuItem.Text = "add student"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.BackColor = System.Drawing.Color.Blue
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BcaToolStripMenuItem, Me.BbaToolStripMenuItem, Me.BcisToolStripMenuItem, Me.AllToolStripMenuItem})
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(236, 42)
        Me.ViewToolStripMenuItem.Text = "view"
        '
        'BcaToolStripMenuItem
        '
        Me.BcaToolStripMenuItem.BackColor = System.Drawing.Color.Blue
        Me.BcaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BcaToolStripMenuItem.Name = "BcaToolStripMenuItem"
        Me.BcaToolStripMenuItem.Size = New System.Drawing.Size(152, 42)
        Me.BcaToolStripMenuItem.Text = "bca"
        '
        'BbaToolStripMenuItem
        '
        Me.BbaToolStripMenuItem.BackColor = System.Drawing.Color.Blue
        Me.BbaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BbaToolStripMenuItem.Name = "BbaToolStripMenuItem"
        Me.BbaToolStripMenuItem.Size = New System.Drawing.Size(152, 42)
        Me.BbaToolStripMenuItem.Text = "bba"
        '
        'BcisToolStripMenuItem
        '
        Me.BcisToolStripMenuItem.BackColor = System.Drawing.Color.Blue
        Me.BcisToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BcisToolStripMenuItem.Name = "BcisToolStripMenuItem"
        Me.BcisToolStripMenuItem.Size = New System.Drawing.Size(152, 42)
        Me.BcisToolStripMenuItem.Text = "bcis"
        '
        'AllToolStripMenuItem
        '
        Me.AllToolStripMenuItem.BackColor = System.Drawing.Color.Blue
        Me.AllToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
        Me.AllToolStripMenuItem.Size = New System.Drawing.Size(152, 42)
        Me.AllToolStripMenuItem.Text = "all"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(113, 41)
        Me.UpdateToolStripMenuItem.Text = "update"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(104, 41)
        Me.SearchToolStripMenuItem.Text = "search"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(103, 41)
        Me.DeleteToolStripMenuItem.Text = "delete"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CahngePasswordToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(110, 41)
        Me.SettingToolStripMenuItem.Text = "setting"
        '
        'CahngePasswordToolStripMenuItem
        '
        Me.CahngePasswordToolStripMenuItem.BackColor = System.Drawing.Color.Blue
        Me.CahngePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CahngePasswordToolStripMenuItem.Name = "CahngePasswordToolStripMenuItem"
        Me.CahngePasswordToolStripMenuItem.Size = New System.Drawing.Size(300, 42)
        Me.CahngePasswordToolStripMenuItem.Text = "change password"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(719, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'studentform3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "studentform3"
        Me.Text = "studentform3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StudentInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BcaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BbaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BcisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CahngePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
