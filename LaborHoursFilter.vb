Imports System.Data.OleDb

Public Class LaborHoursFilter

    Dim args As String = Nothing
    Dim dr As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click

        args = Nothing
        'add dates
        Dim datesearch As String = "WHERE [WORKDATE] Between #" & dtpFrom.Value.ToShortDateString & "# And #" & dtpTo.Value.ToShortDateString & "#"

        args = args & datesearch

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

        If (datesearch <> Nothing And Not cboType.SelectedItem.Equals("- ALL - ")) Then
            args = args & " And "
        End If

        'search by type
        If (Not cboType.SelectedItem.Equals("- ALL - ")) Then
            Dim typesearch As String = "[LABORHOURS.TYPE] ='" & cboType.SelectedItem & "'"
            args = args & typesearch
        End If
        'end search by type

        If (datesearch <> Nothing And Not cboOTDT.SelectedItem.Equals("- ALL - ")) Then
            args = args & " And "
        End If

        'search by OTDT
        If (Not cboOTDT.SelectedItem.Equals("- ALL - ")) Then
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


        'refresh 
        DBEdit.RefreshDataGrid(args)
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        DBEdit.RefreshDataGrid(Nothing)
    End Sub

    Private Sub LaborHoursFilter_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Laborhours Type Combo box
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM WORKTYPES", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        cboType.Items.Add("- ALL - ")
        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim name As String = dr.GetString(1)
            cboType.Items.Add(name)
        Loop

        cboType.SelectedIndex = 0
        dr.Close()
        conn.Close()
        'end laborhours type combo box

        'labor hours overtime combo box
        cboOTDT.Items.Add("- ALL - ")
        cboOTDT.Items.Add("None")
        cboOTDT.Items.Add("Overtime")
        cboOTDT.Items.Add("Double Time")
        cboOTDT.SelectedIndex = 0

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

        'TODO: This line of code loads data into the 'LABORHOURSDataSet.COMPANIES' table. You can move, or remove it, as needed.
        Me.COMPANIESTableAdapter.Fill(Me.LABORHOURSDataSet.COMPANIES)
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.PROPERTIES' table. You can move, or remove it, as needed.
        Me.PROPERTIESTableAdapter.Fill(Me.LABORHOURSDataSet.PROPERTIES)
    End Sub

    Private Sub cboCompany_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCompany.SelectedIndexChanged

    End Sub

    Private Sub cboAddress_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAddress.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAddress.Click

    End Sub

    Private Sub cboEmployee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmployee.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub cboOTDT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOTDT.SelectedIndexChanged

    End Sub

    Private Sub dtpTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpTo.ValueChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged

    End Sub

    Private Sub chkSickVac_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSickVac.CheckedChanged

    End Sub
End Class