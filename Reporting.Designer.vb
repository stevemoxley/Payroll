<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporting
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
        Me.LABORHOURSDataSet = New LABORHOURS.LABORHOURSDataSet()
        Me.WORKERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WORKERSTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cboReportType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkSickVac = New System.Windows.Forms.CheckBox()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.cboOTDT = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboEmployee = New System.Windows.Forms.ComboBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboAddress = New System.Windows.Forms.ComboBox()
        Me.cboCompany = New System.Windows.Forms.ComboBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnGenerateMileage = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpMilesFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpMilesTo = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboEmployeeMiles = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboCompanyMiles = New System.Windows.Forms.ComboBox()
        Me.cboMilesReport = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnCommGenerate = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpCommFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpCommTo = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboCommEmp = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboCommCompany = New System.Windows.Forms.ComboBox()
        Me.cboCommReport = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dtpInvoiceFrom = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpInvoiceTo = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.WORKERSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMPANIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMPANIESTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.COMPANIESTableAdapter()
        Me.WORKERSBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMPANIESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROPERTIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROPERTIESTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter()
        Me.COMPANIESBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.WORKERSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPANIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORKERSBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPANIESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPANIESBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'WORKERSTableAdapter
        '
        Me.WORKERSTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(399, 286)
        Me.TabControl1.TabIndex = 24
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cboReportType)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnGenerate)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(391, 260)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Labor Hours"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cboReportType
        '
        Me.cboReportType.FormattingEnabled = True
        Me.cboReportType.Location = New System.Drawing.Point(81, 3)
        Me.cboReportType.Name = "cboReportType"
        Me.cboReportType.Size = New System.Drawing.Size(292, 21)
        Me.cboReportType.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Report Type:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSickVac)
        Me.GroupBox1.Controls.Add(Me.dtpFrom)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpTo)
        Me.GroupBox1.Controls.Add(Me.cboOTDT)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboEmployee)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboType)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboAddress)
        Me.GroupBox1.Controls.Add(Me.cboCompany)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 192)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'chkSickVac
        '
        Me.chkSickVac.AutoSize = True
        Me.chkSickVac.Checked = True
        Me.chkSickVac.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSickVac.Location = New System.Drawing.Point(210, 153)
        Me.chkSickVac.Name = "chkSickVac"
        Me.chkSickVac.Size = New System.Drawing.Size(132, 17)
        Me.chkSickVac.TabIndex = 21
        Me.chkSickVac.Text = "Include Sick/Vacation"
        Me.chkSickVac.UseVisualStyleBackColor = True
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(69, 19)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(121, 20)
        Me.dtpFrom.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Overtime:"
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(202, 19)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(148, 20)
        Me.dtpTo.TabIndex = 3
        '
        'cboOTDT
        '
        Me.cboOTDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboOTDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOTDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOTDT.FormattingEnabled = True
        Me.cboOTDT.Location = New System.Drawing.Point(69, 153)
        Me.cboOTDT.Name = "cboOTDT"
        Me.cboOTDT.Size = New System.Drawing.Size(121, 21)
        Me.cboOTDT.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Type:"
        '
        'cboEmployee
        '
        Me.cboEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmployee.FormattingEnabled = True
        Me.cboEmployee.Location = New System.Drawing.Point(69, 45)
        Me.cboEmployee.Name = "cboEmployee"
        Me.cboEmployee.Size = New System.Drawing.Size(121, 21)
        Me.cboEmployee.TabIndex = 5
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(15, 72)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 11
        Me.lblAddress.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Employee:"
        '
        'cboType
        '
        Me.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(69, 126)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 21)
        Me.cboType.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Company:"
        '
        'cboAddress
        '
        Me.cboAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddress.FormattingEnabled = True
        Me.cboAddress.Location = New System.Drawing.Point(69, 72)
        Me.cboAddress.Name = "cboAddress"
        Me.cboAddress.Size = New System.Drawing.Size(121, 21)
        Me.cboAddress.TabIndex = 9
        '
        'cboCompany
        '
        Me.cboCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Location = New System.Drawing.Point(69, 99)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Size = New System.Drawing.Size(121, 21)
        Me.cboCompany.TabIndex = 8
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(222, 228)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(151, 23)
        Me.btnGenerate.TabIndex = 24
        Me.btnGenerate.Text = "Generate Report"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnGenerateMileage)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.cboMilesReport)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(391, 260)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mileage"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnGenerateMileage
        '
        Me.btnGenerateMileage.Location = New System.Drawing.Point(222, 228)
        Me.btnGenerateMileage.Name = "btnGenerateMileage"
        Me.btnGenerateMileage.Size = New System.Drawing.Size(151, 23)
        Me.btnGenerateMileage.TabIndex = 25
        Me.btnGenerateMileage.Text = "Generate Report"
        Me.btnGenerateMileage.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpMilesFrom)
        Me.GroupBox2.Controls.Add(Me.dtpMilesTo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cboEmployeeMiles)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cboCompanyMiles)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 192)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'dtpMilesFrom
        '
        Me.dtpMilesFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMilesFrom.Location = New System.Drawing.Point(69, 19)
        Me.dtpMilesFrom.Name = "dtpMilesFrom"
        Me.dtpMilesFrom.Size = New System.Drawing.Size(121, 20)
        Me.dtpMilesFrom.TabIndex = 2
        '
        'dtpMilesTo
        '
        Me.dtpMilesTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMilesTo.Location = New System.Drawing.Point(202, 19)
        Me.dtpMilesTo.Name = "dtpMilesTo"
        Me.dtpMilesTo.Size = New System.Drawing.Size(148, 20)
        Me.dtpMilesTo.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Date:"
        '
        'cboEmployeeMiles
        '
        Me.cboEmployeeMiles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboEmployeeMiles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEmployeeMiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmployeeMiles.FormattingEnabled = True
        Me.cboEmployeeMiles.Location = New System.Drawing.Point(69, 45)
        Me.cboEmployeeMiles.Name = "cboEmployeeMiles"
        Me.cboEmployeeMiles.Size = New System.Drawing.Size(121, 21)
        Me.cboEmployeeMiles.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Employee:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Company:"
        '
        'cboCompanyMiles
        '
        Me.cboCompanyMiles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCompanyMiles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCompanyMiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompanyMiles.FormattingEnabled = True
        Me.cboCompanyMiles.Location = New System.Drawing.Point(69, 72)
        Me.cboCompanyMiles.Name = "cboCompanyMiles"
        Me.cboCompanyMiles.Size = New System.Drawing.Size(121, 21)
        Me.cboCompanyMiles.TabIndex = 8
        '
        'cboMilesReport
        '
        Me.cboMilesReport.FormattingEnabled = True
        Me.cboMilesReport.Location = New System.Drawing.Point(81, 3)
        Me.cboMilesReport.Name = "cboMilesReport"
        Me.cboMilesReport.Size = New System.Drawing.Size(292, 21)
        Me.cboMilesReport.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Report Type"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnCommGenerate)
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.cboCommReport)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(391, 260)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Commission"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnCommGenerate
        '
        Me.btnCommGenerate.Location = New System.Drawing.Point(222, 228)
        Me.btnCommGenerate.Name = "btnCommGenerate"
        Me.btnCommGenerate.Size = New System.Drawing.Size(151, 23)
        Me.btnCommGenerate.TabIndex = 31
        Me.btnCommGenerate.Text = "Generate Report"
        Me.btnCommGenerate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dtpCommFrom)
        Me.GroupBox3.Controls.Add(Me.dtpCommTo)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.cboCommEmp)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.cboCommCompany)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(361, 192)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter"
        '
        'dtpCommFrom
        '
        Me.dtpCommFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCommFrom.Location = New System.Drawing.Point(69, 19)
        Me.dtpCommFrom.Name = "dtpCommFrom"
        Me.dtpCommFrom.Size = New System.Drawing.Size(121, 20)
        Me.dtpCommFrom.TabIndex = 2
        '
        'dtpCommTo
        '
        Me.dtpCommTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCommTo.Location = New System.Drawing.Point(202, 19)
        Me.dtpCommTo.Name = "dtpCommTo"
        Me.dtpCommTo.Size = New System.Drawing.Size(148, 20)
        Me.dtpCommTo.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Date:"
        '
        'cboCommEmp
        '
        Me.cboCommEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCommEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCommEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCommEmp.FormattingEnabled = True
        Me.cboCommEmp.Location = New System.Drawing.Point(69, 45)
        Me.cboCommEmp.Name = "cboCommEmp"
        Me.cboCommEmp.Size = New System.Drawing.Size(121, 21)
        Me.cboCommEmp.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 46)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Employee:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Company:"
        '
        'cboCommCompany
        '
        Me.cboCommCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCommCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCommCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCommCompany.FormattingEnabled = True
        Me.cboCommCompany.Location = New System.Drawing.Point(69, 72)
        Me.cboCommCompany.Name = "cboCommCompany"
        Me.cboCommCompany.Size = New System.Drawing.Size(121, 21)
        Me.cboCommCompany.TabIndex = 8
        '
        'cboCommReport
        '
        Me.cboCommReport.FormattingEnabled = True
        Me.cboCommReport.Location = New System.Drawing.Point(81, 3)
        Me.cboCommReport.Name = "cboCommReport"
        Me.cboCommReport.Size = New System.Drawing.Size(292, 21)
        Me.cboCommReport.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Report Type:"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dtpInvoiceFrom)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.dtpInvoiceTo)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(391, 260)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Invoices"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dtpInvoiceFrom
        '
        Me.dtpInvoiceFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvoiceFrom.Location = New System.Drawing.Point(63, 14)
        Me.dtpInvoiceFrom.Name = "dtpInvoiceFrom"
        Me.dtpInvoiceFrom.Size = New System.Drawing.Size(121, 20)
        Me.dtpInvoiceFrom.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(216, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Generate Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpInvoiceTo
        '
        Me.dtpInvoiceTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInvoiceTo.Location = New System.Drawing.Point(196, 14)
        Me.dtpInvoiceTo.Name = "dtpInvoiceTo"
        Me.dtpInvoiceTo.Size = New System.Drawing.Size(148, 20)
        Me.dtpInvoiceTo.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Date:"
        '
        'WORKERSBindingSource1
        '
        Me.WORKERSBindingSource1.DataMember = "WORKERS"
        Me.WORKERSBindingSource1.DataSource = Me.LABORHOURSDataSet
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
        'WORKERSBindingSource2
        '
        Me.WORKERSBindingSource2.DataMember = "WORKERS"
        Me.WORKERSBindingSource2.DataSource = Me.LABORHOURSDataSet
        '
        'COMPANIESBindingSource1
        '
        Me.COMPANIESBindingSource1.DataMember = "COMPANIES"
        Me.COMPANIESBindingSource1.DataSource = Me.LABORHOURSDataSet
        '
        'PROPERTIESBindingSource
        '
        Me.PROPERTIESBindingSource.DataMember = "PROPERTIES"
        Me.PROPERTIESBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'PROPERTIESTableAdapter
        '
        Me.PROPERTIESTableAdapter.ClearBeforeFill = True
        '
        'COMPANIESBindingSource2
        '
        Me.COMPANIESBindingSource2.DataMember = "COMPANIES"
        Me.COMPANIESBindingSource2.DataSource = Me.LABORHOURSDataSet
        '
        'Reporting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 310)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Reporting"
        Me.Text = "Reporting"
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.WORKERSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPANIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORKERSBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPANIESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPANIESBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LABORHOURSDataSet As LABORHOURS.LABORHOURSDataSet
    Friend WithEvents WORKERSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKERSTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cboReportType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboOTDT As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboEmployee As System.Windows.Forms.ComboBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboAddress As System.Windows.Forms.ComboBox
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents chkSickVac As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboMilesReport As System.Windows.Forms.ComboBox
    Friend WithEvents btnGenerateMileage As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpMilesFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMilesTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboEmployeeMiles As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboCompanyMiles As System.Windows.Forms.ComboBox
    Friend WithEvents WORKERSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents COMPANIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMPANIESTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.COMPANIESTableAdapter
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dtpInvoiceFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtpInvoiceTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents cboCommReport As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpCommFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCommTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboCommEmp As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboCommCompany As System.Windows.Forms.ComboBox
    Friend WithEvents btnCommGenerate As System.Windows.Forms.Button
    Friend WithEvents WORKERSBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents COMPANIESBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PROPERTIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROPERTIESTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter
    Friend WithEvents COMPANIESBindingSource2 As System.Windows.Forms.BindingSource
End Class
