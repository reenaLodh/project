<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changepassword
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
        Me.confirmname = New System.Windows.Forms.TextBox()
        Me.newname = New System.Windows.Forms.TextBox()
        Me.oldpass = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'confirmname
        '
        Me.confirmname.Location = New System.Drawing.Point(324, 203)
        Me.confirmname.Multiline = True
        Me.confirmname.Name = "confirmname"
        Me.confirmname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmname.Size = New System.Drawing.Size(221, 24)
        Me.confirmname.TabIndex = 27
        '
        'newname
        '
        Me.newname.Location = New System.Drawing.Point(324, 122)
        Me.newname.Multiline = True
        Me.newname.Name = "newname"
        Me.newname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newname.Size = New System.Drawing.Size(214, 25)
        Me.newname.TabIndex = 26
        '
        'oldpass
        '
        Me.oldpass.Location = New System.Drawing.Point(324, 52)
        Me.oldpass.Multiline = True
        Me.oldpass.Name = "oldpass"
        Me.oldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldpass.Size = New System.Drawing.Size(214, 27)
        Me.oldpass.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(116, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 37)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "ok"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 25)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "confirm-password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "new-password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "old-password"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(507, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 37)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'changepassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 379)
        Me.Controls.Add(Me.confirmname)
        Me.Controls.Add(Me.newname)
        Me.Controls.Add(Me.oldpass)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "changepassword"
        Me.Text = "changepassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents confirmname As System.Windows.Forms.TextBox
    Friend WithEvents newname As System.Windows.Forms.TextBox
    Friend WithEvents oldpass As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
