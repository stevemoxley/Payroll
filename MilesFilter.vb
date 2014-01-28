Imports System.Data.OleDb

Public Class MilesFilter

    Dim dr, dr2 As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim ID As Integer
    Dim args As String

    Private Sub MilesFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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


        '==============================BEGIN MILES Company Combo Box FIll in =============================================
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
        '===============================END MILES Company Combo Box Fill in ===============================================
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        args = Nothing
        'add dates
        Dim datesearch As String = "WHERE [MILEDATE] Between #" & dtpFromDate.Value.ToShortDateString & "# And #" & dtpToDate.Value.ToShortDateString & "#"

        args = args & datesearch

        If (datesearch <> Nothing And cboCompany.SelectedItem <> "- ALL -") Then
            args = args & " And "
        End If

        'search by company
        If (cboCompany.SelectedItem <> "- ALL -") Then
            Dim companysearch As String = "[COMPANIES.COMPANY] ='" & cboCompany.Text & "'"
            args = args & companysearch
        End If
        'end company search

        If (datesearch <> Nothing And cboEmployee.SelectedItem.ToString() <> "- ALL -") Then
            args = args & " And "
        End If

        'search by employee
        If (cboEmployee.SelectedItem.ToString() <> "- ALL -") Then
            Dim emp As Employee = CType(cboEmployee.SelectedItem, Employee)
            Dim employeesearch As String = "[WORKERS.ID] =" & emp.empID & ""
            args = args & employeesearch
        End If
        'end employee search

        'refresh 
        MilesEdit.RefreshDataGrid(args)
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        MilesEdit.RefreshDataGrid(Nothing)
    End Sub
End Class