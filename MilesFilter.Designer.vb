<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MilesFilter
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboEmployee = New System.Windows.Forms.ComboBox()
        Me.WORKERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LABORHOURSDataSet = New LABORHOURS.LABORHOURSDataSet()
        Me.WORKERSTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboCompany = New System.Windows.Forms.ComboBox()
        Me.COMPANIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMPANIESTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.COMPANIESTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.MileageTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.MILEAGETableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPANIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee"
        '
        'cboEmployee
        '
        Me.cboEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmployee.FormattingEnabled = True
        Me.cboEmployee.Location = New System.Drawing.Point(65, 34)
        Me.cboEmployee.Name = "cboEmployee"
        Me.cboEmployee.Size = New System.Drawing.Size(200, 21)
        Me.cboEmployee.TabIndex = 1
        '
        'WORKERSBindingSource
        '
        Me.WORKERSBindingSource.DataMember = "WORKERS"
        Me.WORKERSBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'LABORHOURSDataSet
        '
        Me.LABORHOURSDataSet.DataSetName = "LABORHOURSDataSet"
        Me.LABORHOURSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WORKERSTableAdapter
        '
        Me.WORKERSTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Company"
        '
        'cboCompany
        '
        Me.cboCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Location = New System.Drawing.Point(65, 62)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Size = New System.Drawing.Size(200, 21)
        Me.cboCompany.TabIndex = 5
        '
        'COMPANIESBindingSource
        '
        Me.COMPANIESBindingSource.DataMember = "COMPANIES"
        Me.COMPANIESBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'COMPANIESTableAdapter
        '
        Me.COMPANIESTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(190, 89)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Filter"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MileageTableAdapter
        '
        Me.MileageTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Date"
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(65, 8)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(97, 20)
        Me.dtpFromDate.TabIndex = 14
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(65, 89)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'dtpToDate
        '
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(168, 7)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(97, 20)
        Me.dtpToDate.TabIndex = 17
        '
        'MilesFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 121)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboEmployee)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MilesFilter"
        Me.Text = "Miles Filter"
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPANIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboEmployee As System.Windows.Forms.ComboBox
    Friend WithEvents LABORHOURSDataSet As LABORHOURS.LABORHOURSDataSet
    Friend WithEvents WORKERSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKERSTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents COMPANIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMPANIESTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.COMPANIESTableAdapter
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents MileageTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.MILEAGETableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
End Class
