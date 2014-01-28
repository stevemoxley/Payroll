Imports System.Data.OleDb

Public Class EnterLaborHours

    Dim dr, dr2 As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim typeselection As String

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblDate.Text = Now.ToShortDateString

        '==============================BEGIN Employee Combo Box FIll in =============================================
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM WORKERS", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim firstname As String = dr.GetString(1)
            Dim lastname As String = dr.GetString(2)
            Dim emp As Employee = New Employee(id, firstname, lastname, 0)
            cboWorker.Items.Add(emp)
        Loop
        cboWorker.DisplayMember = "fullname"
        cboWorker.ValueMember = "empID"
        cboWorker.SelectedIndex = 0
        dr.Close()
        conn.Close()
        '===============================END Employee Combo Box Fill in ===============================================

        cboOTDT.Items.Add("None")
        cboOTDT.Items.Add("Overtime")
        cboOTDT.Items.Add("Double Time")
        cboOTDT.SelectedIndex = 0

        'TODO: This line of code loads data into the 'LABORHOURSDataSet.WORKTYPES' table. You can move, or remove it, as needed.
        Me.WORKTYPESTableAdapter.Fill(Me.LABORHOURSDataSet.WORKTYPES)
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.PROPERTIES' table. You can move, or remove it, as needed.
        Me.PROPERTIESTableAdapter.Fill(Me.LABORHOURSDataSet.PROPERTIES)
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.PROPERTIES' table. You can move, or remove it, as needed.
        Me.PROPERTIESTableAdapter.Fill(Me.LABORHOURSDataSet.PROPERTIES)
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.WORKERS' table. You can move, or remove it, as needed.
        Me.WORKERSTableAdapter.Fill(Me.LABORHOURSDataSet.WORKERS)
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.PROPERTIES' table. You can move, or remove it, as needed.
        Me.PROPERTIESTableAdapter.Fill(Me.LABORHOURSDataSet.PROPERTIES)
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.WORKERS' table. You can move, or remove it, as needed.
        Me.WORKERSTableAdapter.Fill(Me.LABORHOURSDataSet.WORKERS)

        Dim compID As Integer = GetCompanyIDFromPropertyID(cboAddress.SelectedValue)
        lblCompany.Text = GetCompanyNameFromCompanyID(compID)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim selEmp As Employee = CType(cboWorker.SelectedItem, Employee)

        If (txtHours.Text = "") Then
            MsgBox("Hours must not be empty")
            Return
        End If

        Dim OTDT As String = cboOTDT.SelectedItem

        If (OTDT.Equals("None")) Then
            OTDT = ""
        End If

        Dim rate As Double
        Dim empID As Integer = selEmp.empID
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT ID,RATE FROM WORKERS WHERE ID=@ID", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", empID))
        conn.Open()

        dr = cmd.ExecuteReader()

        Do While dr.Read()
            rate = dr.GetDouble(1)
        Loop

        dr.Close()
        conn.Close()


        Try
            Dim hours As Double = Double.Parse(txtHours.Text)
            Dim companyID As Integer = GetCompanyIDFromPropertyID(cboAddress.SelectedValue)
            Dim companyLaborRate As Decimal = GetCompanyLaborRateFromCompanyID(companyID)
            Dim companySupervisorRate As Decimal = GetCompanySupervisorRateFromCompanyID(companyID)

            If (cboAddress.SelectedValue <> 368) Then 'This is for scattered sites allocations (mainly jenn right now)
                'Check if the company has a different labor rate
                If (companyLaborRate > 0) Then
                    Me.LaborhoursTableAdapter.InsertLaborHours(cboAddress.SelectedValue, selEmp.empID, hours, timePicker.Value.ToShortDateString, tboxNotes.Text, cboType.Text, OTDT, companyLaborRate)
                    'Check if the company has a supervisor rate.
                    If (companySupervisorRate > 0) Then
                        'If it does then add half of the labor at the supervisor rate
                        'I'll need to figure out how to add this and not have it add additional hours to the employee
                        'Me.LaborhoursTableAdapter.InsertLaborHours(cboAddress.SelectedValue, selEmp.empID, hours / 2, timePicker.Value.ToShortDateString, tboxNotes.Text, "Supervisor", OTDT, companySupervisorRate)
                    End If
                Else
                    'If it doesnt just use the regular employee rate
                    Me.LaborhoursTableAdapter.InsertLaborHours(cboAddress.SelectedValue, selEmp.empID, hours, timePicker.Value.ToShortDateString, tboxNotes.Text, cboType.Text, OTDT, rate)
                End If
            Else
                'Do scattered sites allocation
                EnterScatteredSitesAllocation(LaborhoursTableAdapter, empID, hours, timePicker, cboType.Text, OTDT, rate)
            End If

            CheckIfAboveMaxJobHours(cboAddress.SelectedValue) 'This will check if the hours have exceeded maximum allowed number of hours on this job

            txtHours.Clear()
            tboxNotes.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        DBEdit.RefreshDataGrid()

    End Sub

    Private Sub btnReporting_Click(sender As System.Object, e As System.EventArgs)
        Reporting.Visible = True
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs)
        DBEdit.Visible = True
    End Sub

    Private Sub btnAddProperty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddRemoveProperty.Visible = True
    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        If (cboType.Text.Equals("Sick") Or cboType.Text.Equals("Vacation") Or cboType.Text.Equals("Holiday")) Then
            cboOTDT.Enabled = False
            typeselection = cboType.Text
            cboAddress.Text = "Sick/Vacation/Holiday"
            cboOTDT.Text = "None"
        Else
            cboOTDT.Enabled = True
        End If

    End Sub

    Private Sub cboAddress_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAddress.SelectedIndexChanged
        If (cboAddress.Text.Equals("Sick/Vacation/Holiday")) Then
            cboType.DataSource = Nothing
            cboType.Items.Clear()
            cboType.Items.Add("Sick")
            cboType.Items.Add("Vacation")
            cboType.Items.Add("Holiday")
            cboType.Text = typeselection
        Else
            cboType.DataSource = Nothing
            cboType.Items.Clear()
            cboType.DataSource = Me.WORKTYPESBindingSource
            cboType.DisplayMember = "WORKTYPE"
        End If

        'Update the company label
        Dim propID As Integer = cboAddress.SelectedValue
        Dim companyID As Integer = GetCompanyIDFromPropertyID(propID)
        lblCompany.Text = GetCompanyNameFromCompanyID(companyID)

    End Sub

    Private Sub cboWorker_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboWorker.SelectedIndexChanged
        'Change work type
        Dim selEmp As Employee = CType(cboWorker.SelectedItem, Employee)
        Dim workType As Integer = GetWorkTypeFromWorkerID(selEmp.empID)
        cboType.SelectedValue = workType

        'Change property
        Dim prop As Integer = GetPropertyFromWorkerID(selEmp.empID)
        If (prop <> Nothing) Then
            cboAddress.SelectedValue = prop
        End If
    End Sub
End Class
