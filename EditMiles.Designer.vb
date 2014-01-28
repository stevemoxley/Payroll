<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditMiles
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
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.Hours = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.MileageTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.MILEAGETableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPANIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 39)
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
        Me.cboEmployee.Location = New System.Drawing.Point(75, 39)
        Me.cboEmployee.Name = "cboEmployee"
        Me.cboEmployee.Size = New System.Drawing.Size(186, 21)
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
        Me.Label2.Location = New System.Drawing.Point(7, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Company"
        '
        'cboCompany
        '
        Me.cboCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCompany.DataSource = Me.COMPANIESBindingSource
        Me.cboCompany.DisplayMember = "COMPANY"
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Location = New System.Drawing.Point(75, 67)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Size = New System.Drawing.Size(186, 21)
        Me.cboCompany.TabIndex = 5
        Me.cboCompany.ValueMember = "ID"
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
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(75, 95)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(186, 20)
        Me.txtTo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "To"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(75, 122)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(186, 20)
        Me.txtFrom.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "From"
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(75, 149)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtMiles.TabIndex = 10
        '
        'Hours
        '
        Me.Hours.AutoSize = True
        Me.Hours.Location = New System.Drawing.Point(24, 149)
        Me.Hours.Name = "Hours"
        Me.Hours.Size = New System.Drawing.Size(31, 13)
        Me.Hours.TabIndex = 11
        Me.Hours.Text = "Miles"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(186, 149)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MileageTableAdapter
        '
        Me.MileageTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(75, 7)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(186, 20)
        Me.dtpDate.TabIndex = 14
        '
        'EditMiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 186)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Hours)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboEmployee)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EditMiles"
        Me.Text = "Edit Miles"
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
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMiles As System.Windows.Forms.TextBox
    Friend WithEvents Hours As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents MileageTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.MILEAGETableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
End Class
