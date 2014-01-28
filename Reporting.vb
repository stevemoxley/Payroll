Imports Microsoft.Office.Interop
Imports System.Data.OleDb



Public Class Reporting

    Dim dr As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand

    Private Sub Reporting_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub Reporting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '==============================BEGIN LABOR HOURS Employee Combo Box FIll in =============================================
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM WORKERS", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        cboEmployee.Items.Add("- ALL -")

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim firstname As String = dr.GetString(1)
            Dim lastname As String = dr.GetString(2)
            Dim emp As New Employee(id, firstname, lastname, 0)
            cboEmployee.Items.Add(emp)
        Loop
        cboEmployee.SelectedIndex = 0
        cboEmployee.DisplayMember = "fullname"
        cboEmployee.ValueMember = "ID"
        dr.Close()
        conn.Close()
        '===============================END LABOR HOURS Employee Combo Box Fill in ===============================================

        'laborhours reprt type combo box
        cboReportType.Items.Add("Rate and Hour (Simple)")
        cboReportType.Items.Add("Employee and Company")
        cboReportType.Items.Add("Employee and Company (Properties Group)")
        cboReportType.Items.Add("Employee and Company  (Hours Only)")
        cboReportType.Items.Add("Employee and Company  (Hours Only By Date)")
        cboReportType.Items.Add("Employee and Company  (Hours Only No Company)")
        cboReportType.Items.Add("Employee and Company  (No Company)")
        cboReportType.Items.Add("Totals By Type")
        cboReportType.Items.Add("Dollar Value")
        cboReportType.Items.Add("Hours")
        cboReportType.Items.Add("By Company")
        cboReportType.Items.Add("By Property")
        cboReportType.Items.Add("Company and Cost by Month")
        cboReportType.SelectedIndex = 0

        'Mileage report type combo box
        cboMilesReport.Items.Add("By Employee")
        cboMilesReport.Items.Add("By Company")
        cboMilesReport.SelectedIndex = 0

        'Commission report tyoe combo box
        cboCommReport.Items.Add("By Employee")
        cboCommReport.Items.Add("By Company")
        cboCommReport.SelectedIndex = 0

        'Laborhours Type Combo box
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM WORKTYPES", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        cboType.Items.Add("- ALL -")

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim name As String = dr.GetString(1)
            cboType.Items.Add(name)
        Loop
        cboType.SelectedIndex = 0
        dr.Close()
        conn.Close()

        'labor hours overtime combo box
        cboOTDT.Items.Add("- ALL -")
        cboOTDT.Items.Add("None")
        cboOTDT.Items.Add("Overtime")
        cboOTDT.Items.Add("Double Time")
        cboOTDT.SelectedIndex = 0




        '==============================BEGIN LABOR HOURS Address Combo Box FIll in =============================================
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM PROPERTIES", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        cboAddress.Items.Add("- ALL -")

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim name As String = dr.GetString(1)
            cboAddress.Items.Add(name)
        Loop
        cboAddress.SelectedIndex = 0
        dr.Close()
        conn.Close()
        '===============================END LABOR HOURS Address  Combo Box Fill in ===============================================

        '==============================BEGIN LABOR HOURS Company Combo Box FIll in =============================================
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM COMPANIES", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        cboCompany.Items.Add("- ALL -")

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim name As String = dr.GetString(1)
            cboCompany.Items.Add(name)
        Loop
        cboCompany.SelectedIndex = 0
        dr.Close()
        conn.Close()
        '===============================END LABOR HOURS Company Combo Box Fill in ===============================================

        '==============================BEGIN MILEAGE Company Combo Box FIll in =============================================
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM COMPANIES", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        cboCompanyMiles.Items.Add("- ALL -")

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim name As String = dr.GetString(1)
            cboCompanyMiles.Items.Add(name)
        Loop
        cboCompanyMiles.SelectedIndex = 0
        dr.Close()
        conn.Close()
        '===============================END MILEAGE Company Combo Box Fill in ===============================================


        '==============================BEGIN MILEAGE Employee Combo Box FIll in =============================================
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM WORKERS", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        cboEmployeeMiles.Items.Add("- ALL -")

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim firstname As String = dr.GetString(1)
            Dim lastname As String = dr.GetString(2)
            Dim emp As New Employee(id, firstname, lastname, 0)
            cboEmployeeMiles.Items.Add(emp)
        Loop
        cboEmployeeMiles.SelectedIndex = 0
        cboEmployeeMiles.DisplayMember = "fullname"
        cboEmployeeMiles.ValueMember = "ID"
        dr.Close()
        conn.Close()
        '===============================END MILEAGE Employee Combo Box Fill in ===============================================


        '==============================BEGIN commission Company Combo Box FIll in =============================================
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM COMPANIES", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        cboCommCompany.Items.Add("- ALL -")

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim name As String = dr.GetString(1)
            cboCommCompany.Items.Add(name)
        Loop
        cboCommCompany.SelectedIndex = 0
        dr.Close()
        conn.Close()
        '===============================END commission Company Combo Box Fill in ===============================================


        '==============================BEGIN commission Employee Combo Box FIll in =============================================
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM WORKERS", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        cboCommEmp.Items.Add("- ALL -")

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim firstname As String = dr.GetString(1)
            Dim lastname As String = dr.GetString(2)
            Dim emp As New Employee(id, firstname, lastname, 0)
            cboCommEmp.Items.Add(emp)
        Loop
        cboCommEmp.SelectedIndex = 0
        cboCommEmp.DisplayMember = "fullname"
        cboCommEmp.ValueMember = "ID"
        dr.Close()
        conn.Close()
        '===============================END commission Employee Combo Box Fill in ===============================================

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim args As String = Nothing 'this is our search string

        'search by date
        Dim datesearch As String = "[WORKDATE] Between #" & dtpFrom.Value.ToShortDateString & "# And #" & dtpTo.Value.ToShortDateString & "#"
        args = args & datesearch 'add it to args
        'end date search

        If (datesearch <> Nothing And cboCompany.SelectedItem <> "- ALL -") Then
            args = args & " And "
        End If

        'search by company
        If (cboCompany.SelectedItem <> "- ALL -") Then
            Dim companysearch As String = "[COMPANIES.COMPANY] ='" & cboCompany.SelectedItem & "'"
            args = args & companysearch
        End If
        'end company search

        If (datesearch <> Nothing And cboEmployee.SelectedItem.ToString() <> "- ALL -") Then
            args = args & " And "
        End If

        'search by employee
        If (cboEmployee.SelectedItem.ToString() <> "- ALL -") Then
            Dim emp As Employee = CType(cboEmployee.SelectedItem, Employee)
            Dim employeesearch As String = "[WORKERS.ID] =" & emp.empID
            args = args & employeesearch
        End If
        'end employee search

        If (datesearch <> Nothing And cboAddress.SelectedItem <> "- ALL -") Then
            args = args & " And "
        End If

        'search by address
        If (cboAddress.SelectedItem <> "- ALL -") Then
            Dim addresssearch As String = "[PROPERTIES.ADDRESS] ='" & cboAddress.SelectedItem & "'"
            args = args & addresssearch
        End If
        'end address search

        If (datesearch <> Nothing And Not cboType.Text.Equals("- ALL -")) Then
            args = args & " And "
        End If

        'search by type
        If (Not cboType.Text.Equals("- ALL -")) Then
            Dim typesearch As String = "[LABORHOURS.TYPE] ='" & cboType.Text & "'"
            args = args & typesearch
        End If
        'end search by type

        If (datesearch <> Nothing And Not cboOTDT.SelectedItem.Equals("- ALL -")) Then
            args = args & " And "
        End If

        'search by OTDT
        If (Not cboOTDT.SelectedItem.Equals("- ALL -")) Then
            If (Not cboOTDT.SelectedItem.Equals("None")) Then
                Dim OTDTsearch As String = "[LABORHOURS.OTDT] ='" & cboOTDT.SelectedItem & "'"
                args = args & OTDTsearch
            End If
        End If
        'end search by OTDT

        If (datesearch <> Nothing And chkSickVac.CheckState = CheckState.Unchecked) Then
            args = args & " And "
        End If

        'include sick/vacation
        If (chkSickVac.CheckState = CheckState.Unchecked) Then
            Dim sickvacsearch As String = "[LABORHOURS.TYPE] <>'Sick' And [LABORHOURS.TYPE] <> 'Vacation'"
            args = args & sickvacsearch
        End If
        'end sick/vacation

        'Last 
        'Pick which report to display
        If (cboReportType.SelectedItem.Equals("Dollar Value")) Then
            GenerateReport("LaborHoursDollars", args) 'Generate the dollar report
        ElseIf (cboReportType.SelectedItem.Equals("Hours")) Then
            GenerateReport("LaborHoursHours", args) 'Generate the hours report
        ElseIf (cboReportType.SelectedItem.Equals("Rate and Hour (Simple)")) Then
            GenerateReport("LaborHoursRateHoursSimple", args) 'Generate the rate hours report
        ElseIf (cboReportType.SelectedItem.Equals("Employee and Company")) Then
            GenerateReport("LaborHoursByWorkerType", args) 'Generate the rate hours report
        ElseIf (cboReportType.SelectedItem.Equals("Employee and Company  (Hours Only)")) Then
            GenerateReport("LaborHoursByEmployeeHoursOnly", args) 'Generate the hours report
        ElseIf (cboReportType.SelectedItem.Equals("Employee and Company  (Hours Only Company Summary)")) Then
            GenerateReport("LaborHoursByWorkerTypeCompanySummary", args) 'Generate the hours report
        ElseIf (cboReportType.SelectedItem.Equals("Employee and Company  (No Company)")) Then
            GenerateReport("LaborHoursByWorkerTypeNoCompany", args) 'Generate the hours report
        ElseIf (cboReportType.SelectedItem.Equals("Employee and Company (Properties Group)")) Then
            GenerateReport("LaborHoursRateHoursSimplePropertyGroup", args) 'Generate the hours report
        ElseIf (cboReportType.SelectedItem.Equals("Employee and Company  (Hours Only By Date)")) Then
            GenerateReport("LaborHoursByEmployeeHoursOnlyDate", args) 'Generate the hours report
        ElseIf (cboReportType.SelectedItem.Equals("Employee and Company  (Hours Only No Company)")) Then
            GenerateReport("LaborHoursByEmployeeHoursOnlyNoCompany", args) 'Generate the hours report
        ElseIf (cboReportType.SelectedItem.Equals("Totals By Type")) Then
            GenerateReport("LaborHoursTotal", args) 'Generate the hours report
        ElseIf (cboReportType.SelectedItem.Equals("By Company")) Then
            GenerateReport("LaborHoursByCompany", args) 'Generate the hours report
        ElseIf (cboReportType.SelectedItem.Equals("By Property")) Then
            GenerateReport("LaborHoursByProperty", args) 'Generate the hours report
        ElseIf (cboReportType.SelectedItem.Equals("Company and Cost by Month")) Then
            GenerateReport("LaborHoursByEmployeeHoursOnlyDateMonthCompany", args) 'Generate the hours report

        End If
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Dim con = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT * FROM (LABORHOURS RIGHT JOIN PROPERTIES ON PROPERTIES.ID=LABORHOURS.ADDRESS) LEFT JOIN COMPANIES ON PROPERTIES.COMPANY=COMPANIES.ID;")
        con.Open()
        Dim OleDataAdapter As New OleDbDataAdapter(cmd)
        Dim builder As New OleDbCommandBuilder(OleDataAdapter)
        Dim DS As New DataSet()
        OleDataAdapter.SelectCommand.Connection = con
        OleDataAdapter.Fill(DS, "LABORHOURS")
        con.Close()
        con = Nothing



        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub cboAddress_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cboAddress.SelectedItem <> "- ALL -") Then
            cboCompany.SelectedIndex = 0
            cboCompany.Enabled = False
        Else
            cboCompany.Enabled = True
        End If
    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        If (cboType.SelectedItem.Equals("Sick") Or cboType.SelectedItem.Equals("Vacation")) Then
            chkSickVac.CheckState = CheckState.Checked
            chkSickVac.Enabled = False
        Else
            chkSickVac.Enabled = True
        End If

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub btnGenerateMileage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateMileage.Click
        Dim args As String = Nothing 'this is our search string

        'search by date
        Dim datesearch As String = "[MILEDATE] Between #" & dtpMilesFrom.Value.ToShortDateString & "# And #" & dtpMilesTo.Value.ToShortDateString & "#"
        args = args & datesearch 'add it to args
        'end date search



        'search by company

        If (datesearch <> Nothing And cboCompanyMiles.SelectedItem <> "- ALL -") Then
            args = args & " And "
        End If

        If (cboCompanyMiles.SelectedItem <> "- ALL -") Then
            Dim companysearch As String = "[COMPANIES.COMPANY] ='" & cboCompanyMiles.SelectedItem & "'"
            args = args & companysearch
        End If
        'end company search

        'search by employee
        If (datesearch <> Nothing And cboEmployeeMiles.SelectedItem.ToString() <> "- ALL -") Then
            args = args & " And "
        End If

        If (cboEmployeeMiles.SelectedItem.ToString() <> "- ALL -") Then
            Dim emp As Employee = CType(cboEmployeeMiles.SelectedItem, Employee)
            Dim employeesearch As String = "[WORKERS.ID] =" & emp.empID & ""
            args = args & employeesearch
        End If
        'end employee search

        'generate the report. always last
        If (cboMilesReport.SelectedItem.Equals("By Employee")) Then
            GenerateReport("MileageByWorker", args) 'Generate the mileage by worker report
        ElseIf (cboMilesReport.SelectedItem.Equals("By Company")) Then
            GenerateReport("MileageByCompany", args) 'Generate the mileage by worker report
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim args As String = Nothing 'this is our search string

        'search by date
        Dim datesearch As String = "[WORKDATE] Between #" & dtpInvoiceFrom.Value.ToShortDateString & "# And #" & dtpInvoiceTo.Value.ToShortDateString & "#"
        args = args & datesearch 'add it to args
        'end date search

        GenerateReport("SummaryInvoiceByCompany", args) 'Generate the mileage by worker report
    End Sub

    Private Sub btnCommGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommGenerate.Click
        Dim args As String = Nothing 'this is our search string

        'search by date
        Dim datesearch As String = "[EARNEDDATE] Between #" & dtpCommFrom.Value.ToShortDateString & "# And #" & dtpCommTo.Value.ToShortDateString & "#"
        args = args & datesearch 'add it to args
        'end date search



        'search by company

        If (datesearch <> Nothing And cboCommCompany.SelectedItem <> "- ALL -") Then
            args = args & " And "
        End If

        If (cboCommCompany.SelectedItem <> "- ALL -") Then
            Dim companysearch As String = "[COMPANIES.COMPANY] ='" & cboCommCompany.SelectedItem & "'"
            args = args & companysearch
        End If
        'end company search

        'search by employee
        If (datesearch <> Nothing And cboCommEmp.SelectedItem.ToString() <> "- ALL -") Then
            args = args & " And "
        End If

        If (cboCommEmp.SelectedItem.ToString() <> "- ALL -") Then
            Dim emp As Employee = CType(cboCommEmp.SelectedItem, Employee)
            Dim employeesearch As String = "[WORKERS.ID] =" & emp.empID
            args = args & employeesearch
        End If
        'end employee search

        'generate the report. always last
        If (cboCommReport.SelectedItem.Equals("By Employee")) Then
            GenerateReport("CommissionByEmployee", args) 'Generate the commission by worker report
        ElseIf (cboCommReport.SelectedItem.Equals("By Company")) Then
            GenerateReport("CommissionByCompany", args) 'Generate the commission by worker report
        End If
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cboMilesReport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMilesReport.SelectedIndexChanged

    End Sub
End Class