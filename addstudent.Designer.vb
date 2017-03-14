<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addstudent
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
        Me.taddress = New System.Windows.Forms.TextBox()
        Me.Lbladdress = New System.Windows.Forms.Label()
        Me.Cmbgender = New System.Windows.Forms.ComboBox()
        Me.cmbsem = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbprogram = New System.Windows.Forms.ComboBox()
        Me.dateofbirthdatetimepicker = New System.Windows.Forms.DateTimePicker()
        Me.tcontact = New System.Windows.Forms.TextBox()
        Me.tfname = New System.Windows.Forms.TextBox()
        Me.tlname = New System.Windows.Forms.TextBox()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'taddress
        '
        Me.taddress.Location = New System.Drawing.Point(249, 390)
        Me.taddress.Multiline = True
        Me.taddress.Name = "taddress"
        Me.taddress.Size = New System.Drawing.Size(176, 22)
        Me.taddress.TabIndex = 61
        '
        'Lbladdress
        '
        Me.Lbladdress.AutoSize = True
        Me.Lbladdress.BackColor = System.Drawing.Color.White
        Me.Lbladdress.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbladdress.ForeColor = System.Drawing.Color.Black
        Me.Lbladdress.Location = New System.Drawing.Point(111, 390)
        Me.Lbladdress.Name = "Lbladdress"
        Me.Lbladdress.Size = New System.Drawing.Size(71, 22)
        Me.Lbladdress.TabIndex = 60
        Me.Lbladdress.Text = "address"
        '
        'Cmbgender
        '
        Me.Cmbgender.FormattingEnabled = True
        Me.Cmbgender.Items.AddRange(New Object() {"male", "female"})
        Me.Cmbgender.Location = New System.Drawing.Point(249, 151)
        Me.Cmbgender.Name = "Cmbgender"
        Me.Cmbgender.Size = New System.Drawing.Size(176, 21)
        Me.Cmbgender.TabIndex = 59
        '
        'cmbsem
        '
        Me.cmbsem.FormattingEnabled = True
        Me.cmbsem.Items.AddRange(New Object() {"first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth"})
        Me.cmbsem.Location = New System.Drawing.Point(249, 242)
        Me.cmbsem.Name = "cmbsem"
        Me.cmbsem.Size = New System.Drawing.Size(176, 21)
        Me.cmbsem.TabIndex = 58
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(110, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 22)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "semester"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(115, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 22)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "program"
        '
        'cmbprogram
        '
        Me.cmbprogram.FormattingEnabled = True
        Me.cmbprogram.Items.AddRange(New Object() {"bca", "bba", "bcis"})
        Me.cmbprogram.Location = New System.Drawing.Point(249, 200)
        Me.cmbprogram.Name = "cmbprogram"
        Me.cmbprogram.Size = New System.Drawing.Size(176, 21)
        Me.cmbprogram.TabIndex = 55
        '
        'dateofbirthdatetimepicker
        '
        Me.dateofbirthdatetimepicker.Location = New System.Drawing.Point(249, 295)
        Me.dateofbirthdatetimepicker.Name = "dateofbirthdatetimepicker"
        Me.dateofbirthdatetimepicker.Size = New System.Drawing.Size(176, 20)
        Me.dateofbirthdatetimepicker.TabIndex = 54
        '
        'tcontact
        '
        Me.tcontact.Location = New System.Drawing.Point(249, 346)
        Me.tcontact.Multiline = True
        Me.tcontact.Name = "tcontact"
        Me.tcontact.Size = New System.Drawing.Size(176, 22)
        Me.tcontact.TabIndex = 53
        '
        'tfname
        '
        Me.tfname.Location = New System.Drawing.Point(249, 106)
        Me.tfname.Multiline = True
        Me.tfname.Name = "tfname"
        Me.tfname.Size = New System.Drawing.Size(176, 25)
        Me.tfname.TabIndex = 52
        '
        'tlname
        '
        Me.tlname.Location = New System.Drawing.Point(596, 106)
        Me.tlname.Multiline = True
        Me.tlname.Name = "tlname"
        Me.tlname.Size = New System.Drawing.Size(176, 25)
        Me.tlname.TabIndex = 51
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(249, 62)
        Me.tid.Multiline = True
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(176, 25)
        Me.tid.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(110, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 22)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "contact_no"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(110, 295)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 22)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Date_of_birth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(111, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 22)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(504, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 22)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "L_name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(110, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "F_name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(110, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 22)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Student_ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(337, -6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(463, 54)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Student's Information"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(59, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 36)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(735, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 36)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'addstudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 524)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.taddress)
        Me.Controls.Add(Me.Lbladdress)
        Me.Controls.Add(Me.Cmbgender)
        Me.Controls.Add(Me.cmbsem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbprogram)
        Me.Controls.Add(Me.dateofbirthdatetimepicker)
        Me.Controls.Add(Me.tcontact)
        Me.Controls.Add(Me.tfname)
        Me.Controls.Add(Me.tlname)
        Me.Controls.Add(Me.tid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addstudent"
        Me.Text = "addstudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents taddress As System.Windows.Forms.TextBox
    Friend WithEvents Lbladdress As System.Windows.Forms.Label
    Friend WithEvents Cmbgender As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsem As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbprogram As System.Windows.Forms.ComboBox
    Friend WithEvents dateofbirthdatetimepicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents tcontact As System.Windows.Forms.TextBox
    Friend WithEvents tfname As System.Windows.Forms.TextBox
    Friend WithEvents tlname As System.Windows.Forms.TextBox
    Friend WithEvents tid As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
