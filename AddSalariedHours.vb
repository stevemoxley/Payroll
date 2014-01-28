Imports System.Data.OleDb

Public Class AddSalariedHours


    Dim dr, dr2 As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand

    Private Sub AddSalariedHours_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReloadListBox()
    End Sub

    Public Sub ReloadListBox()
        lboxSalaried.Items.Clear()
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT WORKERS.ID, WORKERFIRST, WORKERLAST FROM (SALARIED INNER JOIN WORKERS ON SALARIED.ID=WORKERS.ID)", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim firstname As String = dr.GetString(1)
            Dim lastname As String = dr.GetString(2)
            Dim emp As New Employee(id, firstname, lastname, 0)
            lboxSalaried.Items.Add(emp)
        Loop
        lboxSalaried.SelectedIndex = 0
        lboxSalaried.DisplayMember = "fullname"
        lboxSalaried.ValueMember = "ID"
        dr.Close()
        conn.Close()
    End Sub

    Private Sub btnAddSalaried_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSalaried.Click
        AddNewSalariedWorker.Visible = True
    End Sub

    Private Sub btnRemoveSalaried_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSalaried.Click
        If MessageBox.Show("Are you sure you want to remove this employee?", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim emp As Employee = CType(lboxSalaried.SelectedItem, Employee)
            Dim ID As Integer = emp.empID
            SALARIEDTableAdapter.DeleteWorker(ID)
        End If

        ReloadListBox()
    End Sub

    Private Sub btnEnterHours_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterHours.Click
        Dim counter As Integer
        For counter = 0 To lboxSalaried.Items.Count - 1

            'Set the selecteditem to the current item
            lboxSalaried.SelectedIndex = counter

            'Get the regular address
            Dim address As Integer 'address employee normally works at
            Dim type As Integer 'type of work ID
            Dim typename As String 'type of work name
            Dim emp As Employee = CType(lboxSalaried.SelectedItem, Employee)

            Dim empID As Integer = emp.empID
            Dim conn = GetDBConnection()
            Dim cmd As New OleDbCommand("SELECT ID,REGULARADDRESS,TYPE FROM SALARIED WHERE ID=@ID", conn)
            cmd.Parameters.Add(New OleDbParameter("@ID", empID))
            conn.Open()

            Dim dr As OleDbDataReader = cmd.ExecuteReader()

            Do While dr.Read()
                address = dr.GetInt16(1)
                type = dr.GetInt32(2)
            Loop

            dr.Close()

            'Get the employee rate
            Dim Rate As Double
            Dim cmd2 As New OleDbCommand("SELECT ID,RATE FROM WORKERS WHERE ID=@ID", conn)
            cmd2.Parameters.Add(New OleDbParameter("@ID", empID))

            Dim dr2 As OleDbDataReader = cmd2.ExecuteReader()

            Do While dr2.Read()
                Rate = dr2.GetDouble(1)
            Loop

            dr2.Close()
            conn.Close()

            'Get the work type
            typename = GetWorkTypeNameFromID(type)

            'Enter into the database

            If (empID = 16) Then
                EnterScatteredSitesAllocation(LaborhoursTableAdapter, empID, 25, dtpTo, typename, "", Rate)
                EnterScatteredSitesAllocation(LaborhoursTableAdapter, empID, 25, dtpFrom, typename, "", Rate)
            ElseIf (empID = 21) Then
                EnterScatteredSitesAllocation(LaborhoursTableAdapter, empID, 40, dtpTo, typename, "", Rate)
                EnterScatteredSitesAllocation(LaborhoursTableAdapter, empID, 40, dtpFrom, typename, "", Rate)
            Else
                LaborhoursTableAdapter.InsertLaborHours(address, empID, 40, dtpTo.Value.ToShortDateString, "", typename, "", Rate)
                LaborhoursTableAdapter.InsertLaborHours(address, empID, 40, dtpFrom.Value.ToShortDateString, "", typename, "", Rate)
            End If


        Next

        MsgBox("Finished")
    End Sub
End Class