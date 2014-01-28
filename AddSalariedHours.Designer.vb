<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSalariedHours
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
        Me.lboxSalaried = New System.Windows.Forms.ListBox()
        Me.LABORHOURSDataSet = New LABORHOURS.LABORHOURSDataSet()
        Me.SALARIEDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALARIEDTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.SALARIEDTableAdapter()
        Me.btnAddSalaried = New System.Windows.Forms.Button()
        Me.btnRemoveSalaried = New System.Windows.Forms.Button()
        Me.btnEnterHours = New System.Windows.Forms.Button()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.LaborhoursTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.LABORHOURSTableAdapter()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALARIEDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lboxSalaried
        '
        Me.lboxSalaried.FormattingEnabled = True
        Me.lboxSalaried.Location = New System.Drawing.Point(13, 13)
        Me.lboxSalaried.Name = "lboxSalaried"
        Me.lboxSalaried.Size = New System.Drawing.Size(169, 238)
        Me.lboxSalaried.TabIndex = 0
        '
        'LABORHOURSDataSet
        '
        Me.LABORHOURSDataSet.DataSetName = "LABORHOURSDataSet"
        Me.LABORHOURSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SALARIEDBindingSource
        '
        Me.SALARIEDBindingSource.DataMember = "SALARIED"
        Me.SALARIEDBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'SALARIEDTableAdapter
        '
        Me.SALARIEDTableAdapter.ClearBeforeFill = True
        '
        'btnAddSalaried
        '
        Me.btnAddSalaried.Location = New System.Drawing.Point(188, 13)
        Me.btnAddSalaried.Name = "btnAddSalaried"
        Me.btnAddSalaried.Size = New System.Drawing.Size(151, 35)
        Me.btnAddSalaried.TabIndex = 1
        Me.btnAddSalaried.Text = "Add Salaried Employee"
        Me.btnAddSalaried.UseVisualStyleBackColor = True
        '
        'btnRemoveSalaried
        '
        Me.btnRemoveSalaried.Location = New System.Drawing.Point(188, 54)
        Me.btnRemoveSalaried.Name = "btnRemoveSalaried"
        Me.btnRemoveSalaried.Size = New System.Drawing.Size(152, 35)
        Me.btnRemoveSalaried.TabIndex = 2
        Me.btnRemoveSalaried.Text = "Remove Salaried Employee"
        Me.btnRemoveSalaried.UseVisualStyleBackColor = True
        '
        'btnEnterHours
        '
        Me.btnEnterHours.Location = New System.Drawing.Point(13, 290)
        Me.btnEnterHours.Name = "btnEnterHours"
        Me.btnEnterHours.Size = New System.Drawing.Size(327, 35)
        Me.btnEnterHours.TabIndex = 3
        Me.btnEnterHours.Text = "Enter Hours"
        Me.btnEnterHours.UseVisualStyleBackColor = True
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(13, 257)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(169, 20)
        Me.dtpFrom.TabIndex = 4
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(188, 257)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(151, 20)
        Me.dtpTo.TabIndex = 5
        '
        'LaborhoursTableAdapter
        '
        Me.LaborhoursTableAdapter.ClearBeforeFill = True
        '
        'AddSalariedHours
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 337)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.btnEnterHours)
        Me.Controls.Add(Me.btnRemoveSalaried)
        Me.Controls.Add(Me.btnAddSalaried)
        Me.Controls.Add(Me.lboxSalaried)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AddSalariedHours"
        Me.Text = "Add Salaried Hours"
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALARIEDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lboxSalaried As System.Windows.Forms.ListBox
    Friend WithEvents LABORHOURSDataSet As LABORHOURS.LABORHOURSDataSet
    Friend WithEvents SALARIEDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SALARIEDTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.SALARIEDTableAdapter
    Friend WithEvents btnAddSalaried As System.Windows.Forms.Button
    Friend WithEvents btnRemoveSalaried As System.Windows.Forms.Button
    Friend WithEvents btnEnterHours As System.Windows.Forms.Button
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents LaborhoursTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.LABORHOURSTableAdapter
End Class
