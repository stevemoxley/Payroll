<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewSalariedWorker
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
        Me.WORKERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LABORHOURSDataSet = New LABORHOURS.LABORHOURSDataSet()
        Me.WORKERSTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter()
        Me.btnMakeSalaried = New System.Windows.Forms.Button()
        Me.SalariedTableAdapter1 = New LABORHOURS.LABORHOURSDataSetTableAdapters.SALARIEDTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.PROPERTIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROPERTIESTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.WORKTYPESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WORKTYPESTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.WORKTYPESTableAdapter()
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORKTYPESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboWorker
        '
        Me.cboWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboWorker.FormattingEnabled = True
        Me.cboWorker.Location = New System.Drawing.Point(65, 12)
        Me.cboWorker.Name = "cboWorker"
        Me.cboWorker.Size = New System.Drawing.Size(259, 21)
        Me.cboWorker.TabIndex = 0
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
        'btnMakeSalaried
        '
        Me.btnMakeSalaried.Location = New System.Drawing.Point(185, 66)
        Me.btnMakeSalaried.Name = "btnMakeSalaried"
        Me.btnMakeSalaried.Size = New System.Drawing.Size(140, 23)
        Me.btnMakeSalaried.TabIndex = 1
        Me.btnMakeSalaried.Text = "Make Salaried"
        Me.btnMakeSalaried.UseVisualStyleBackColor = True
        '
        'SalariedTableAdapter1
        '
        Me.SalariedTableAdapter1.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Location"
        '
        'cboLocation
        '
        Me.cboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLocation.DataSource = Me.PROPERTIESBindingSource
        Me.cboLocation.DisplayMember = "ADDRESS"
        Me.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Location = New System.Drawing.Point(65, 39)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(259, 21)
        Me.cboLocation.TabIndex = 4
        Me.cboLocation.ValueMember = "ID"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Type"
        '
        'cboType
        '
        Me.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(65, 66)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(113, 21)
        Me.cboType.TabIndex = 6
        '
        'WORKTYPESBindingSource
        '
        Me.WORKTYPESBindingSource.DataMember = "WORKTYPES"
        Me.WORKTYPESBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'WORKTYPESTableAdapter
        '
        Me.WORKTYPESTableAdapter.ClearBeforeFill = True
        '
        'AddNewSalariedWorker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 100)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMakeSalaried)
        Me.Controls.Add(Me.cboWorker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AddNewSalariedWorker"
        Me.Text = "Add New Salaried Worker"
        CType(Me.WORKERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORKTYPESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboWorker As System.Windows.Forms.ComboBox
    Friend WithEvents LABORHOURSDataSet As LABORHOURS.LABORHOURSDataSet
    Friend WithEvents WORKERSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKERSTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.WORKERSTableAdapter
    Friend WithEvents btnMakeSalaried As System.Windows.Forms.Button
    Friend WithEvents SalariedTableAdapter1 As LABORHOURS.LABORHOURSDataSetTableAdapters.SALARIEDTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboLocation As System.Windows.Forms.ComboBox
    Friend WithEvents PROPERTIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROPERTIESTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents WORKTYPESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKTYPESTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.WORKTYPESTableAdapter
End Class
