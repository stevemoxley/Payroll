<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommissionEdit
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
        Me.txtInvoice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
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
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtInvoice
        '
        Me.txtInvoice.Location = New System.Drawing.Point(88, 118)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(95, 20)
        Me.txtInvoice.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Invoice Amount"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(88, 12)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(273, 20)
        Me.dtpDate.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Date"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(286, 115)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Commission"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(88, 92)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(95, 20)
        Me.txtAmount.TabIndex = 15
        '
        'cboAddress
        '
        Me.cboAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAddress.DataSource = Me.PROPERTIESBindingSource
        Me.cboAddress.DisplayMember = "ADDRESS"
        Me.cboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddress.FormattingEnabled = True
        Me.cboAddress.Location = New System.Drawing.Point(88, 65)
        Me.cboAddress.Name = "cboAddress"
        Me.cboAddress.Size = New System.Drawing.Size(273, 21)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 65)
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
        Me.cboAgent.Location = New System.Drawing.Point(88, 38)
        Me.cboAgent.Name = "cboAgent"
        Me.cboAgent.Size = New System.Drawing.Size(273, 21)
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
        Me.Label1.Location = New System.Drawing.Point(47, 38)
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
        'CommissionEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 149)
        Me.Controls.Add(Me.txtInvoice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.cboAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboAgent)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "CommissionEdit"
        Me.Text = "Edit Commission"
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInvoice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
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
End Class
