<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterLaborHours
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
        Me.cboWorker = New System.Windows.Forms.ComboBox()
        Me.WORKERSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LABORHOURSDataSet = New LABORHOURS.LABORHOURSDataSet()
        Me.WORKERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboAddress = New System.Windows.Forms.ComboBox()
        Me.PROPERTIESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROPERTIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tboxNotes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.timePicker = New System.Windows.Forms.DateTimePicker()
        Me.WORKERSTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter()
        Me.TableAdapterManager = New LABORHOURS.LABORHOURSDataSetTableAdapters.TableAdapterManager()
        Me.PROPERTIESTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter()
        Me.LaborhoursTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.LABORHOURSTableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.WORKTYPESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboOTDT = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WORKTYPESTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.WORKTYPESTableAdapter()
        Me.lblCompany = New System.Windows.Forms.Label()
        CType(Me.WORKERSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROPERTIESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORKTYPESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboWorker
        '
        Me.cboWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWorker.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboWorker.FormattingEnabled = True
        Me.cboWorker.Location = New System.Drawing.Point(55, 65)
        Me.cboWorker.Name = "cboWorker"
        Me.cboWorker.Size = New System.Drawing.Size(207, 21)
        Me.cboWorker.TabIndex = 1
        Me.cboWorker.TabStop = False
        '
        'WORKERSBindingSource1
        '
        Me.WORKERSBindingSource1.DataMember = "WORKERS"
        Me.WORKERSBindingSource1.DataSource = Me.LABORHOURSDataSet
        '
        'LABORHOURSDataSet
        '
        Me.LABORHOURSDataSet.DataSetName = "LABORHOURSDataSet"
        Me.LABORHOURSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WORKERSBindingSource
        '
        Me.WORKERSBindingSource.DataMember = "WORKERS"
        Me.WORKERSBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'cboAddress
        '
        Me.cboAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAddress.DataSource = Me.PROPERTIESBindingSource1
        Me.cboAddress.DisplayMember = "ADDRESS"
        Me.cboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddress.FormattingEnabled = True
        Me.cboAddress.Location = New System.Drawing.Point(55, 92)
        Me.cboAddress.Name = "cboAddress"
        Me.cboAddress.Size = New System.Drawing.Size(207, 21)
        Me.cboAddress.TabIndex = 2
        Me.cboAddress.TabStop = False
        Me.cboAddress.ValueMember = "ID"
        '
        'PROPERTIESBindingSource1
        '
        Me.PROPERTIESBindingSource1.DataMember = "PROPERTIES"
        Me.PROPERTIESBindingSource1.DataSource = Me.LABORHOURSDataSet
        '
        'PROPERTIESBindingSource
        '
        Me.PROPERTIESBindingSource.DataMember = "PROPERTIES"
        Me.PROPERTIESBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(55, 146)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hours"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(16, 11)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(36, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "{date}"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(367, 146)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-1, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Employee"
        '
        'tboxNotes
        '
        Me.tboxNotes.Location = New System.Drawing.Point(55, 172)
        Me.tboxNotes.Multiline = True
        Me.tboxNotes.Name = "tboxNotes"
        Me.tboxNotes.Size = New System.Drawing.Size(387, 62)
        Me.tboxNotes.TabIndex = 1
        Me.tboxNotes.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Notes"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Date"
        '
        'timePicker
        '
        Me.timePicker.Location = New System.Drawing.Point(55, 39)
        Me.timePicker.Name = "timePicker"
        Me.timePicker.Size = New System.Drawing.Size(207, 20)
        Me.timePicker.TabIndex = 0
        Me.timePicker.TabStop = False
        '
        'WORKERSTableAdapter
        '
        Me.WORKERSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.COMMISSIONTableAdapter = Nothing
        Me.TableAdapterManager.COMPANIESTableAdapter = Nothing
        Me.TableAdapterManager.JOBSTableAdapter = Nothing
        Me.TableAdapterManager.LABORHOURSTableAdapter = Nothing
        Me.TableAdapterManager.MILEAGETableAdapter = Nothing
        Me.TableAdapterManager.OLDCOMPANYTableAdapter = Nothing
        Me.TableAdapterManager.OLDEMPLOYEETableAdapter = Nothing
        Me.TableAdapterManager.OLDPROPERTIESTableAdapter = Nothing
        Me.TableAdapterManager.PROPERTIESTableAdapter = Nothing
        Me.TableAdapterManager.SALARIEDTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LABORHOURS.LABORHOURSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WORKERSTableAdapter = Me.WORKERSTableAdapter
        Me.TableAdapterManager.WORKTYPESTableAdapter = Nothing
        '
        'PROPERTIESTableAdapter
        '
        Me.PROPERTIESTableAdapter.ClearBeforeFill = True
        '
        'LaborhoursTableAdapter
        '
        Me.LaborhoursTableAdapter.ClearBeforeFill = True
        '
        'cboType
        '
        Me.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboType.DataSource = Me.WORKTYPESBindingSource
        Me.cboType.DisplayMember = "WORKTYPE"
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(55, 119)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(100, 21)
        Me.cboType.TabIndex = 1
        Me.cboType.TabStop = False
        Me.cboType.ValueMember = "ID"
        '
        'WORKTYPESBindingSource
        '
        Me.WORKTYPESBindingSource.DataMember = "WORKTYPES"
        Me.WORKTYPESBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Type"
        '
        'cboOTDT
        '
        Me.cboOTDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboOTDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOTDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOTDT.FormattingEnabled = True
        Me.cboOTDT.Location = New System.Drawing.Point(216, 145)
        Me.cboOTDT.Name = "cboOTDT"
        Me.cboOTDT.Size = New System.Drawing.Size(121, 21)
        Me.cboOTDT.TabIndex = 17
        Me.cboOTDT.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(161, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Overtime"
        '
        'WORKTYPESTableAdapter
        '
        Me.WORKTYPESTableAdapter.ClearBeforeFill = True
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Location = New System.Drawing.Point(161, 119)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(152, 13)
        Me.lblCompany.TabIndex = 19
        Me.lblCompany.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        '
        'EnterLaborHours
        '
        Me.ClientSize = New System.Drawing.Size(455, 246)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboOTDT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.timePicker)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tboxNotes)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.cboAddress)
        Me.Controls.Add(Me.cboWorker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "EnterLaborHours"
        Me.Text = "Enter Labor Hours"
        CType(Me.WORKERSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROPERTIESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORKTYPESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboWorker As System.Windows.Forms.ComboBox
    Friend WithEvents cboAddress As System.Windows.Forms.ComboBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tboxNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents timePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents LABORHOURSDataSet As LABORHOURS.LABORHOURSDataSet
    Friend WithEvents WORKERSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKERSTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter
    Friend WithEvents TableAdapterManager As LABORHOURS.LABORHOURSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PROPERTIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROPERTIESTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter
    Friend WithEvents LaborhoursTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.LABORHOURSTableAdapter
    Friend WithEvents WORKERSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PROPERTIESBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboOTDT As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents WORKTYPESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKTYPESTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.WORKTYPESTableAdapter
    Friend WithEvents lblCompany As System.Windows.Forms.Label

End Class
