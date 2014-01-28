<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommissionFilter
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
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.cboAddress = New System.Windows.Forms.ComboBox()
        Me.PROPERTIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LABORHOURSDataSet = New LABORHOURS.LABORHOURSDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAgent = New System.Windows.Forms.ComboBox()
        Me.WORKERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WORKERSTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter()
        Me.PROPERTIESTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter()
        Me.CommissionTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.COMMISSIONTableAdapter()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cboCompany = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFromDate
        '
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(61, 14)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(103, 20)
        Me.dtpFromDate.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Date"
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(227, 118)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 23)
        Me.btnFilter.TabIndex = 18
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'cboAddress
        '
        Me.cboAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddress.FormattingEnabled = True
        Me.cboAddress.Location = New System.Drawing.Point(61, 91)
        Me.cboAddress.Name = "cboAddress"
        Me.cboAddress.Size = New System.Drawing.Size(241, 21)
        Me.cboAddress.TabIndex = 14
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Address"
        '
        'cboAgent
        '
        Me.cboAgent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAgent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAgent.FormattingEnabled = True
        Me.cboAgent.Location = New System.Drawing.Point(61, 37)
        Me.cboAgent.Name = "cboAgent"
        Me.cboAgent.Size = New System.Drawing.Size(241, 21)
        Me.cboAgent.TabIndex = 13
        '
        'WORKERSBindingSource
        '
        Me.WORKERSBindingSource.DataMember = "WORKERS"
        Me.WORKERSBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Agent"
        '
        'WORKERSTableAdapter
        '
        Me.WORKERSTableAdapter.ClearBeforeFill = True
        '
        'PROPERTIESTableAdapter
        '
        Me.PROPERTIESTableAdapter.ClearBeforeFill = True
        '
        'CommissionTableAdapter
        '
        Me.CommissionTableAdapter.ClearBeforeFill = True
        '
        'dtpToDate
        '
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(197, 14)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(103, 20)
        Me.dtpToDate.TabIndex = 20
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(61, 118)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 21
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'cboCompany
        '
        Me.cboCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Location = New System.Drawing.Point(61, 64)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Size = New System.Drawing.Size(241, 21)
        Me.cboCompany.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Company"
        '
        'CommissionFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 153)
        Me.Controls.Add(Me.cboCompany)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.dtpToDate)
        Me.Controls.Add(Me.dtpFromDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cboAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboAgent)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CommissionFilter"
        Me.Text = "Commission Filter"
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents cboAddress As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboAgent As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LABORHOURSDataSet As LABORHOURS.LABORHOURSDataSet
    Friend WithEvents WORKERSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKERSTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter
    Friend WithEvents PROPERTIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROPERTIESTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter
    Friend WithEvents CommissionTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.COMMISSIONTableAdapter
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
