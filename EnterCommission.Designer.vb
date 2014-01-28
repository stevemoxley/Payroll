<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterCommission
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
        Me.cboAgent = New System.Windows.Forms.ComboBox()
        Me.WORKERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LABORHOURSDataSet = New LABORHOURS.LABORHOURSDataSet()
        Me.WORKERSTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAddress = New System.Windows.Forms.ComboBox()
        Me.PROPERTIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.CommissionTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.COMMISSIONTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtInvoice = New System.Windows.Forms.TextBox()
        Me.PROPERTIESTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agent"
        '
        'cboAgent
        '
        Me.cboAgent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAgent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAgent.FormattingEnabled = True
        Me.cboAgent.Location = New System.Drawing.Point(90, 38)
        Me.cboAgent.Name = "cboAgent"
        Me.cboAgent.Size = New System.Drawing.Size(273, 21)
        Me.cboAgent.TabIndex = 2
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
        Me.Label2.Location = New System.Drawing.Point(39, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address"
        '
        'cboAddress
        '
        Me.cboAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAddress.DataSource = Me.PROPERTIESBindingSource
        Me.cboAddress.DisplayMember = "ADDRESS"
        Me.cboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddress.FormattingEnabled = True
        Me.cboAddress.Location = New System.Drawing.Point(90, 65)
        Me.cboAddress.Name = "cboAddress"
        Me.cboAddress.Size = New System.Drawing.Size(273, 21)
        Me.cboAddress.TabIndex = 3
        Me.cboAddress.ValueMember = "ID"
        '
        'PROPERTIESBindingSource
        '
        Me.PROPERTIESBindingSource.DataMember = "PROPERTIES"
        Me.PROPERTIESBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(90, 92)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(95, 20)
        Me.txtAmount.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Commission"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(288, 115)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(90, 12)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(273, 20)
        Me.dtpDate.TabIndex = 1
        '
        'CommissionTableAdapter
        '
        Me.CommissionTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Invoice Amount"
        '
        'txtInvoice
        '
        Me.txtInvoice.Location = New System.Drawing.Point(90, 118)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(95, 20)
        Me.txtInvoice.TabIndex = 5
        '
        'PROPERTIESTableAdapter
        '
        Me.PROPERTIESTableAdapter.ClearBeforeFill = True
        '
        'EnterCommission
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
        Me.Name = "EnterCommission"
        Me.Text = "Enter Commission"
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboAgent As System.Windows.Forms.ComboBox
    Friend WithEvents LABORHOURSDataSet As LABORHOURS.LABORHOURSDataSet
    Friend WithEvents WORKERSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKERSTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboAddress As System.Windows.Forms.ComboBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CommissionTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.COMMISSIONTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtInvoice As System.Windows.Forms.TextBox
    Friend WithEvents PROPERTIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROPERTIESTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter
End Class
