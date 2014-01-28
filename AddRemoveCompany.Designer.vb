<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRemoveCompany
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
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.txtLaborRate = New System.Windows.Forms.TextBox()
        Me.txtSupervisorRate = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cboCompanies = New System.Windows.Forms.ComboBox()
        Me.COMPANIESBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LABORHOURSDataSet1 = New LABORHOURS.LABORHOURSDataSet()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.COMPANIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LABORHOURSDataSet = New LABORHOURS.LABORHOURSDataSet()
        Me.CompaniesTableAdapter1 = New LABORHOURS.LABORHOURSDataSetTableAdapters.COMPANIESTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.COMPANIESBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORHOURSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPANIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(53, 6)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(225, 20)
        Me.txtCompany.TabIndex = 1
        '
        'txtLaborRate
        '
        Me.txtLaborRate.Location = New System.Drawing.Point(108, 30)
        Me.txtLaborRate.Name = "txtLaborRate"
        Me.txtLaborRate.Size = New System.Drawing.Size(170, 20)
        Me.txtLaborRate.TabIndex = 3
        '
        'txtSupervisorRate
        '
        Me.txtSupervisorRate.Location = New System.Drawing.Point(108, 55)
        Me.txtSupervisorRate.Name = "txtSupervisorRate"
        Me.txtSupervisorRate.Size = New System.Drawing.Size(170, 20)
        Me.txtSupervisorRate.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(292, 140)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.txtCompany)
        Me.TabPage1.Controls.Add(Me.txtSupervisorRate)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtLaborRate)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(284, 114)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Supervisor Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Maintenance Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Name"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(191, 81)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.cboCompanies)
        Me.TabPage2.Controls.Add(Me.btnRemove)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(284, 114)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Remove"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cboCompanies
        '
        Me.cboCompanies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCompanies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCompanies.DataSource = Me.COMPANIESBindingSource1
        Me.cboCompanies.DisplayMember = "COMPANY"
        Me.cboCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCompanies.FormattingEnabled = True
        Me.cboCompanies.Location = New System.Drawing.Point(59, 6)
        Me.cboCompanies.Name = "cboCompanies"
        Me.cboCompanies.Size = New System.Drawing.Size(219, 21)
        Me.cboCompanies.TabIndex = 6
        Me.cboCompanies.TabStop = False
        Me.cboCompanies.ValueMember = "ID"
        '
        'COMPANIESBindingSource1
        '
        Me.COMPANIESBindingSource1.DataMember = "COMPANIES"
        Me.COMPANIESBindingSource1.DataSource = Me.LABORHOURSDataSet1
        '
        'LABORHOURSDataSet1
        '
        Me.LABORHOURSDataSet1.DataSetName = "LABORHOURSDataSet"
        Me.LABORHOURSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(203, 85)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(284, 114)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Edit"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'COMPANIESBindingSource
        '
        Me.COMPANIESBindingSource.DataMember = "COMPANIES"
        Me.COMPANIESBindingSource.DataSource = Me.LABORHOURSDataSet
        '
        'LABORHOURSDataSet
        '
        Me.LABORHOURSDataSet.DataSetName = "LABORHOURSDataSet"
        Me.LABORHOURSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompaniesTableAdapter1
        '
        Me.CompaniesTableAdapter1.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Company"
        '
        'AddRemoveCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 160)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AddRemoveCompany"
        Me.Text = "Add/Remove Company"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.COMPANIESBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LABORHOURSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPANIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LABORHOURSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents CompaniesTableAdapter1 As LABORHOURS.LABORHOURSDataSetTableAdapters.COMPANIESTableAdapter
    Friend WithEvents txtLaborRate As System.Windows.Forms.TextBox
    Friend WithEvents txtSupervisorRate As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents COMPANIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LABORHOURSDataSet As LABORHOURS.LABORHOURSDataSet
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents cboCompanies As System.Windows.Forms.ComboBox
    Friend WithEvents LABORHOURSDataSet1 As LABORHOURS.LABORHOURSDataSet
    Friend WithEvents COMPANIESBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
