<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewaddedstudentsdetail
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
        Me.components = New System.ComponentModel.Container()
        Me.back = New System.Windows.Forms.Button()
        Me._student_information_systemDataSet = New student_information_system._student_information_systemDataSet()
        Me.Student_detailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_detailsTableAdapter = New student_information_system._student_information_systemDataSetTableAdapters.student_detailsTableAdapter()
        Me.TableAdapterManager = New student_information_system._student_information_systemDataSetTableAdapters.TableAdapterManager()
        Me.Student_detailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me._student_information_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_detailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_detailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(416, 388)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 34)
        Me.back.TabIndex = 0
        Me.back.Text = "back"
        Me.back.UseVisualStyleBackColor = True
        '
        '_student_information_systemDataSet
        '
        Me._student_information_systemDataSet.DataSetName = "_student_information_systemDataSet"
        Me._student_information_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_detailsBindingSource
        '
        Me.Student_detailsBindingSource.DataMember = "student_details"
        Me.Student_detailsBindingSource.DataSource = Me._student_information_systemDataSet
        '
        'Student_detailsTableAdapter
        '
        Me.Student_detailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.student_detailsTableAdapter = Me.Student_detailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = student_information_system._student_information_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Student_detailsDataGridView
        '
        Me.Student_detailsDataGridView.AutoGenerateColumns = False
        Me.Student_detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Student_detailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Student_detailsDataGridView.DataSource = Me.Student_detailsBindingSource
        Me.Student_detailsDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.Student_detailsDataGridView.Name = "Student_detailsDataGridView"
        Me.Student_detailsDataGridView.Size = New System.Drawing.Size(945, 339)
        Me.Student_detailsDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "student_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "student_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "f_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "f_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "l_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "l_name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "program"
        Me.DataGridViewTextBoxColumn5.HeaderText = "program"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "semester"
        Me.DataGridViewTextBoxColumn6.HeaderText = "semester"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "date_of_birth"
        Me.DataGridViewTextBoxColumn7.HeaderText = "date_of_birth"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "contact_no"
        Me.DataGridViewTextBoxColumn8.HeaderText = "contact_no"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn9.HeaderText = "address"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(965, 25)
        Me.FillByToolStrip.TabIndex = 3
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'viewaddedstudentsdetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 442)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Student_detailsDataGridView)
        Me.Controls.Add(Me.back)
        Me.Name = "viewaddedstudentsdetail"
        Me.Text = "viewaddedstudentsdetail"
        CType(Me._student_information_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_detailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_detailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents _student_information_systemDataSet As student_information_system._student_information_systemDataSet
    Friend WithEvents Student_detailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Student_detailsTableAdapter As student_information_system._student_information_systemDataSetTableAdapters.student_detailsTableAdapter
    Friend WithEvents TableAdapterManager As student_information_system._student_information_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Student_detailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
End Class
