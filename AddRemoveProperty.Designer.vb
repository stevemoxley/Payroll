<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRemoveProperty
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
        Me.PropertiesTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Add = New System.Windows.Forms.TabPage()
        Me.pnlMaxHours = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaxHours = New System.Windows.Forms.TextBox()
        Me.chkIsJob = New System.Windows.Forms.CheckBox()
        Me.cboCompany = New System.Windows.Forms.ComboBox()
        Me.COMPANIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Remove = New System.Windows.Forms.TabPage()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.cboRemoveAddress = New System.Windows.Forms.ComboBox()
        Me.PROPERTIESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LABORHOURSDataSet1 = New LABORHOURS.LABORHOURSDataSet()
        Me.Edit = New System.Windows.Forms.TabPage()
        Me.PROPERTIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMPANIESTableAdapter = New LABORHOURS.LABORHOURSDataSetTableAdapters.COMPANIESTableAdapter()
        Me.OldpropertiesTableAdapter1 = New LABORHOURS.LABORHOURSDataSetTableAdapters.OLDPROPERTIESTableAdapter()
        Me.LABORHOURSDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobsTableAdapter1 = New LABORHOURS.LABORHOURSDataSetTableAdapters.JOBSTableAdapter()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Add.SuspendLayout()
        Me.pnlMaxHours.SuspendLayout()
        CType(Me.COMPANIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Remove.SuspendLayout()
        CType(Me.PROPERTIESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORHOURSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORHOURSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LABORHOURSDataSet
        '
        Me.LABORHOURSDataSet.DataSetName = "LABORHOURSDataSet"
        Me.LABORHOURSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PropertiesTableAdapter
        '
        Me.PropertiesTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Add)
        Me.TabControl1.Controls.Add(Me.Remove)
        Me.TabControl1.Controls.Add(Me.Edit)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 134)
        Me.TabControl1.TabIndex = 7
        '
        'Add
        '
        Me.Add.Controls.Add(Me.pnlMaxHours)
        Me.Add.Controls.Add(Me.chkIsJob)
        Me.Add.Controls.Add(Me.cboCompany)
        Me.Add.Controls.Add(Me.Label2)
        Me.Add.Controls.Add(Me.Label1)
        Me.Add.Controls.Add(Me.btnAdd)
        Me.Add.Controls.Add(Me.txtAddress)
        Me.Add.Location = New System.Drawing.Point(4, 22)
        Me.Add.Name = "Add"
        Me.Add.Padding = New System.Windows.Forms.Padding(3)
        Me.Add.Size = New System.Drawing.Size(332, 108)
        Me.Add.TabIndex = 0
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'pnlMaxHours
        '
        Me.pnlMaxHours.Controls.Add(Me.Label3)
        Me.pnlMaxHours.Controls.Add(Me.txtMaxHours)
        Me.pnlMaxHours.Location = New System.Drawing.Point(78, 57)
        Me.pnlMaxHours.Name = "pnlMaxHours"
        Me.pnlMaxHours.Size = New System.Drawing.Size(167, 44)
        Me.pnlMaxHours.TabIndex = 16
        Me.pnlMaxHours.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Max Hours"
        '
        'txtMaxHours
        '
        Me.txtMaxHours.Location = New System.Drawing.Point(64, 13)
        Me.txtMaxHours.Name = "txtMaxHours"
        Me.txtMaxHours.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxHours.TabIndex = 16
        Me.txtMaxHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkIsJob
        '
        Me.chkIsJob.AutoSize = True
        Me.chkIsJob.Location = New System.Drawing.Point(9, 69)
        Me.chkIsJob.Name = "chkIsJob"
        Me.chkIsJob.Size = New System.Drawing.Size(63, 17)
        Me.chkIsJob.TabIndex = 13
        Me.chkIsJob.Text = "Is a Job"
        Me.chkIsJob.UseVisualStyleBackColor = True
        '
        'cboCompany
        '
        Me.cboCompany.DataSource = Me.COMPANIESBindingSource
        Me.cboCompany.DisplayMember = "COMPANY"
        Me.cboCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Location = New System.Drawing.Point(70, 30)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Size = New System.Drawing.Size(256, 21)
        Me.cboCompany.TabIndex = 12
        Me.cboCompany.ValueMember = "ID"
        '
        'COMPANIESBindingSource
        '
        Me.COMPANIESBindingSource.DataMember = "COMPANIES"
        Me.COMPANIESBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Ownership"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Address"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(251, 67)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(69, 3)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(257, 20)
        Me.txtAddress.TabIndex = 7
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Remove
        '
        Me.Remove.Controls.Add(Me.lblAddress)
        Me.Remove.Controls.Add(Me.btnRemove)
        Me.Remove.Controls.Add(Me.cboRemoveAddress)
        Me.Remove.Location = New System.Drawing.Point(4, 22)
        Me.Remove.Name = "Remove"
        Me.Remove.Padding = New System.Windows.Forms.Padding(3)
        Me.Remove.Size = New System.Drawing.Size(332, 108)
        Me.Remove.TabIndex = 1
        Me.Remove.Text = "Remove"
        Me.Remove.UseVisualStyleBackColor = True
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(6, 3)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(251, 30)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'cboRemoveAddress
        '
        Me.cboRemoveAddress.DataSource = Me.PROPERTIESBindingSource1
        Me.cboRemoveAddress.DisplayMember = "ADDRESS"
        Me.cboRemoveAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRemoveAddress.FormattingEnabled = True
        Me.cboRemoveAddress.Location = New System.Drawing.Point(69, 3)
        Me.cboRemoveAddress.Name = "cboRemoveAddress"
        Me.cboRemoveAddress.Size = New System.Drawing.Size(257, 21)
        Me.cboRemoveAddress.TabIndex = 1
        Me.cboRemoveAddress.ValueMember = "ID"
        '
        'PROPERTIESBindingSource1
        '
        Me.PROPERTIESBindingSource1.DataMember = "PROPERTIES"
        Me.PROPERTIESBindingSource1.DataSource = Me.LABORHOURSDataSet1
        '
        'LABORHOURSDataSet1
        '
        Me.LABORHOURSDataSet1.DataSetName = "LABORHOURSDataSet"
        Me.LABORHOURSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Edit
        '
        Me.Edit.Location = New System.Drawing.Point(4, 22)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(332, 136)
        Me.Edit.TabIndex = 2
        Me.Edit.Text = "Edit"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'PROPERTIESBindingSource
        '
        Me.PROPERTIESBindingSource.DataMember = "PROPERTIES"
        Me.PROPERTIESBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'COMPANIESTableAdapter
        '
        Me.COMPANIESTableAdapter.ClearBeforeFill = True
        '
        'OldpropertiesTableAdapter1
        '
        Me.OldpropertiesTableAdapter1.ClearBeforeFill = True
        '
        'LABORHOURSDataSet1BindingSource
        '
        Me.LABORHOURSDataSet1BindingSource.DataSource = Me.LABORHOURSDataSet1
        Me.LABORHOURSDataSet1BindingSource.Position = 0
        '
        'JobsTableAdapter1
        '
        Me.JobsTableAdapter1.ClearBeforeFill = True
        '
        'AddRemoveProperty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 158)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AddRemoveProperty"
        Me.Text = "Add/Remove Property/Job"
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Add.ResumeLayout(False)
        Me.Add.PerformLayout()
        Me.pnlMaxHours.ResumeLayout(False)
        Me.pnlMaxHours.PerformLayout()
        CType(Me.COMPANIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Remove.ResumeLayout(False)
        Me.Remove.PerformLayout()
        CType(Me.PROPERTIESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LABORHOURSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROPERTIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LABORHOURSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LABORHOURSDataSet As LABORHOURS.LABORHOURSDataSet
    Friend WithEvents COMPANIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMPANIESTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.COMPANIESTableAdapter
    Friend WithEvents PropertiesTableAdapter As LABORHOURS.LABORHOURSDataSetTableAdapters.PROPERTIESTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Add As System.Windows.Forms.TabPage
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Edit As System.Windows.Forms.TabPage
    Friend WithEvents PROPERTIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OldpropertiesTableAdapter1 As LABORHOURS.LABORHOURSDataSetTableAdapters.OLDPROPERTIESTableAdapter
    Friend WithEvents Remove As System.Windows.Forms.TabPage
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents cboRemoveAddress As System.Windows.Forms.ComboBox
    Friend WithEvents LABORHOURSDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LABORHOURSDataSet1 As LABORHOURS.LABORHOURSDataSet
    Friend WithEvents PROPERTIESBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents chkIsJob As System.Windows.Forms.CheckBox
    Friend WithEvents pnlMaxHours As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMaxHours As System.Windows.Forms.TextBox
    Friend WithEvents JobsTableAdapter1 As LABORHOURS.LABORHOURSDataSetTableAdapters.JOBSTableAdapter
End Class
