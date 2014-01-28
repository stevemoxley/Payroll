<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnEnterHours = New System.Windows.Forms.Button()
        Me.btnEnterMiles = New System.Windows.Forms.Button()
        Me.btnCreateReports = New System.Windows.Forms.Button()
        Me.btnViewMiles = New System.Windows.Forms.Button()
        Me.btnViewHours = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalary = New System.Windows.Forms.Button()
        Me.btnCommission = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnCompany = New System.Windows.Forms.Button()
        Me.btnProperty = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnViewCommission = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnterHours
        '
        Me.btnEnterHours.Location = New System.Drawing.Point(7, 19)
        Me.btnEnterHours.Name = "btnEnterHours"
        Me.btnEnterHours.Size = New System.Drawing.Size(172, 33)
        Me.btnEnterHours.TabIndex = 0
        Me.btnEnterHours.Text = "Enter Labor Hours"
        Me.btnEnterHours.UseVisualStyleBackColor = True
        '
        'btnEnterMiles
        '
        Me.btnEnterMiles.Location = New System.Drawing.Point(7, 19)
        Me.btnEnterMiles.Name = "btnEnterMiles"
        Me.btnEnterMiles.Size = New System.Drawing.Size(172, 33)
        Me.btnEnterMiles.TabIndex = 1
        Me.btnEnterMiles.Text = "Enter Mileage"
        Me.btnEnterMiles.UseVisualStyleBackColor = True
        '
        'btnCreateReports
        '
        Me.btnCreateReports.Location = New System.Drawing.Point(3, 19)
        Me.btnCreateReports.Name = "btnCreateReports"
        Me.btnCreateReports.Size = New System.Drawing.Size(172, 33)
        Me.btnCreateReports.TabIndex = 2
        Me.btnCreateReports.Text = "Create Reports"
        Me.btnCreateReports.UseVisualStyleBackColor = True
        '
        'btnViewMiles
        '
        Me.btnViewMiles.Location = New System.Drawing.Point(7, 58)
        Me.btnViewMiles.Name = "btnViewMiles"
        Me.btnViewMiles.Size = New System.Drawing.Size(172, 33)
        Me.btnViewMiles.TabIndex = 4
        Me.btnViewMiles.Text = "View Mileage"
        Me.btnViewMiles.UseVisualStyleBackColor = True
        '
        'btnViewHours
        '
        Me.btnViewHours.Location = New System.Drawing.Point(7, 97)
        Me.btnViewHours.Name = "btnViewHours"
        Me.btnViewHours.Size = New System.Drawing.Size(172, 33)
        Me.btnViewHours.TabIndex = 3
        Me.btnViewHours.Text = "View Labor Hours"
        Me.btnViewHours.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSalary)
        Me.GroupBox1.Controls.Add(Me.btnEnterHours)
        Me.GroupBox1.Controls.Add(Me.btnViewHours)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 139)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Labor"
        '
        'btnSalary
        '
        Me.btnSalary.Location = New System.Drawing.Point(7, 58)
        Me.btnSalary.Name = "btnSalary"
        Me.btnSalary.Size = New System.Drawing.Size(172, 33)
        Me.btnSalary.TabIndex = 4
        Me.btnSalary.Text = "Enter Salaried Employees"
        Me.btnSalary.UseVisualStyleBackColor = True
        '
        'btnCommission
        '
        Me.btnCommission.Location = New System.Drawing.Point(3, 19)
        Me.btnCommission.Name = "btnCommission"
        Me.btnCommission.Size = New System.Drawing.Size(172, 33)
        Me.btnCommission.TabIndex = 5
        Me.btnCommission.Text = "Enter Commission"
        Me.btnCommission.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEnterMiles)
        Me.GroupBox2.Controls.Add(Me.btnViewMiles)
        Me.GroupBox2.Location = New System.Drawing.Point(219, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(185, 103)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mileage"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCreateReports)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 265)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(185, 62)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reporting"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnEmployee)
        Me.GroupBox4.Controls.Add(Me.btnCompany)
        Me.GroupBox4.Controls.Add(Me.btnProperty)
        Me.GroupBox4.Location = New System.Drawing.Point(219, 122)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(185, 137)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Database Functions"
        '
        'btnEmployee
        '
        Me.btnEmployee.Location = New System.Drawing.Point(6, 97)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(172, 33)
        Me.btnEmployee.TabIndex = 5
        Me.btnEmployee.Text = "Employee"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnCompany
        '
        Me.btnCompany.Location = New System.Drawing.Point(6, 58)
        Me.btnCompany.Name = "btnCompany"
        Me.btnCompany.Size = New System.Drawing.Size(172, 33)
        Me.btnCompany.TabIndex = 4
        Me.btnCompany.Text = "Company"
        Me.btnCompany.UseVisualStyleBackColor = True
        '
        'btnProperty
        '
        Me.btnProperty.Location = New System.Drawing.Point(7, 19)
        Me.btnProperty.Name = "btnProperty"
        Me.btnProperty.Size = New System.Drawing.Size(172, 33)
        Me.btnProperty.TabIndex = 3
        Me.btnProperty.Text = "Property/Job"
        Me.btnProperty.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnViewCommission)
        Me.GroupBox5.Controls.Add(Me.btnCommission)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(185, 102)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Commission"
        '
        'btnViewCommission
        '
        Me.btnViewCommission.Location = New System.Drawing.Point(3, 58)
        Me.btnViewCommission.Name = "btnViewCommission"
        Me.btnViewCommission.Size = New System.Drawing.Size(172, 33)
        Me.btnViewCommission.TabIndex = 6
        Me.btnViewCommission.Text = "View Commission"
        Me.btnViewCommission.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(222, 273)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 341)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.Text = "Cypress Management"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnterHours As System.Windows.Forms.Button
    Friend WithEvents btnEnterMiles As System.Windows.Forms.Button
    Friend WithEvents btnCreateReports As System.Windows.Forms.Button
    Friend WithEvents btnViewMiles As System.Windows.Forms.Button
    Friend WithEvents btnViewHours As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalary As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProperty As System.Windows.Forms.Button
    Friend WithEvents btnCompany As System.Windows.Forms.Button
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnCommission As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnViewCommission As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
