<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditLaborHours
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
        Me.timePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tboxNotes = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.cboAddress = New System.Windows.Forms.ComboBox()
        Me.PROPERTIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LABORHOURSDataSet = New LABORHOURS.LABORHOURSDataSet()
        Me.cboWorker = New System.Windows.Forms.ComboBox()
        Me.WORKERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WORKERSTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter()
        Me.PROPERTIESTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter()
        Me.LaborhoursTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.LABORHOURSTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.WORKTYPESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboOTDT = New System.Windows.Forms.ComboBox()
        Me.WORKTYPESTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.WORKTYPESTableAdapter()
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORKTYPESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timePicker
        '
        Me.timePicker.Location = New System.Drawing.Point(63, 28)
        Me.timePicker.Name = "timePicker"
        Me.timePicker.Size = New System.Drawing.Size(207, 20)
        Me.timePicker.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Notes"
        '
        'tboxNotes
        '
        Me.tboxNotes.Location = New System.Drawing.Point(63, 161)
        Me.tboxNotes.Multiline = True
        Me.tboxNotes.Name = "tboxNotes"
        Me.tboxNotes.Size = New System.Drawing.Size(387, 62)
        Me.tboxNotes.TabIndex = 18
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(375, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Hours"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Employee"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(63, 135)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 15
        '
        'cboAddress
        '
        Me.cboAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAddress.DataSource = Me.PROPERTIESBindingSource
        Me.cboAddress.DisplayMember = "ADDRESS"
        Me.cboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddress.FormattingEnabled = True
        Me.cboAddress.Location = New System.Drawing.Point(63, 81)
        Me.cboAddress.Name = "cboAddress"
        Me.cboAddress.Size = New System.Drawing.Size(207, 21)
        Me.cboAddress.TabIndex = 14
        Me.cboAddress.ValueMember = "ID"
        '
        'PROPERTIESBindingSource
        '
        Me.PROPERTIESBindingSource.DataMember = "PROPERTIES"
        Me.PROPERTIESBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'LABORHOURSDataSet
        '
        Me.LABORHOURSDataSet.DataSetName = "LABORHOURSDataSet"
        Me.LABORHOURSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboWorker
        '
        Me.cboWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWorker.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboWorker.FormattingEnabled = True
        Me.cboWorker.Location = New System.Drawing.Point(63, 54)
        Me.cboWorker.Name = "cboWorker"
        Me.cboWorker.Size = New System.Drawing.Size(207, 21)
        Me.cboWorker.TabIndex = 13
        '
        'WORKERSBindingSource
        '
        Me.WORKERSBindingSource.DataMember = "WORKERS"
        Me.WORKERSBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'WORKERSTableAdapter
        '
        Me.WORKERSTableAdapter.ClearBeforeFill = True
        '
        'PROPERTIESTableAdapter
        '
        Me.PROPERTIESTableAdapter.ClearBeforeFill = True
        '
        'LaborhoursTableAdapter
        '
        Me.LaborhoursTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Type"
        '
        'cboType
        '
        Me.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboType.DataSource = Me.WORKTYPESBindingSource
        Me.cboType.DisplayMember = "WORKTYPE"
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(63, 108)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(100, 21)
        Me.cboType.TabIndex = 23
        Me.cboType.TabStop = False
        Me.cboType.ValueMember = "ID"
        '
        'WORKTYPESBindingSource
        '
        Me.WORKTYPESBindingSource.DataMember = "WORKTYPES"
        Me.WORKTYPESBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(173, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Overtime"
        '
        'cboOTDT
        '
        Me.cboOTDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboOTDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOTDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOTDT.FormattingEnabled = True
        Me.cboOTDT.Location = New System.Drawing.Point(228, 134)
        Me.cboOTDT.Name = "cboOTDT"
        Me.cboOTDT.Size = New System.Drawing.Size(121, 21)
        Me.cboOTDT.TabIndex = 25
        '
        'WORKTYPESTableAdapter
        '
        Me.WORKTYPESTableAdapter.ClearBeforeFill = True
        '
        'EditLaborHours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 233)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboOTDT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.timePicker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tboxNotes)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.cboAddress)
        Me.Controls.Add(Me.cboWorker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "EditLaborHours"
        Me.Text = "Edit Hours"
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORKTYPESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tboxNotes As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents cboAddress As System.Windows.Forms.ComboBox
    Friend WithEvents cboWorker As System.Windows.Forms.ComboBox
    Friend WithEvents LABORHOURSDataSet As LABORHOURS.LABORHOURSDataSet
    Friend WithEvents WORKERSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKERSTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter
    Friend WithEvents PROPERTIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROPERTIESTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter
    Friend WithEvents LaborhoursTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.LABORHOURSTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboOTDT As System.Windows.Forms.ComboBox
    Friend WithEvents WORKTYPESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKTYPESTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.WORKTYPESTableAdapter
End Class
