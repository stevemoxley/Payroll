Imports System.Data.OleDb

Public Class CommissionFilter

    Dim args As String = Nothing
    Dim dr As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand

    Private Sub CommissionFilter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '==============================BEGIN LABOR HOURS Employee Combo Box FIll in =============================================
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM WORKERS", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        cboAgent.Items.Add("- ALL -")

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim firstname As String = dr.GetString(1)
            Dim lastname As String = dr.GetString(2)
            Dim emp As New Employee(id, firstname, lastname, 0)
            cboAgent.Items.Add(emp)
        Loop
        cboAgent.SelectedIndex = 0
        cboAgent.DisplayMember = "fullname"
        cboAgent.ValueMember = "ID"
        dr.Close()
        conn.Close()
        '===============================END LABOR HOURS Employee Combo Box Fill in ===============================================

        '==============================BEGIN commission Address Combo Box FIll in =============================================
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
        '===============================END commission Address Combo Box Fill in ===============================================

        '==============================BEGIN commission Company Combo Box FIll in =============================================
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
        '===============================END commission Company Combo Box Fill in ===============================================
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        EditCommission.RefreshDataGrid(Nothing)
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click
        args = Nothing
        'add dates
        Dim datesearch As String = "WHERE [EARNEDDATE] Between #" & dtpFromDate.Value.ToShortDateString & "# And #" & dtpToDate.Value.ToShortDateString & "#"

        args = args & datesearch

        If (datesearch <> Nothing And cboAgent.SelectedItem.ToString() <> "- ALL -") Then
            args = args & " And "
        End If

        'search by employee
        If (cboAgent.SelectedItem.ToString() <> "- ALL -") Then
            Dim emp As Employee = CType(cboAgent.SelectedItem, Employee)
            Dim employeesearch As String = "[WORKERS.ID] =" & emp.empID & ""
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

        If (datesearch <> Nothing And cboCompany.SelectedItem <> "- ALL -") Then
            args = args & " And "
        End If

        'search by company
        If (cboCompany.SelectedItem <> "- ALL -") Then
            Dim companysearch As String = "[COMPANIES.COMPANY] ='" & cboCompany.SelectedItem & "'"
            args = args & companysearch
        End If
        'end company search


        'Always last
        EditCommission.RefreshDataGrid(args)
    End Sub

End Class