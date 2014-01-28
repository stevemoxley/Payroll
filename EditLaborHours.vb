Imports System.Data.OleDb

Public Class EditLaborHours

    Dim dr, dr2 As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim ID As Integer

    Public Sub FillForm(ByVal laborhoursID As String)
        Dim address As Integer
        Dim worker As Integer
        Dim hours As Double
        Dim workdate As Date
        Dim notes As String = Nothing
        Dim type As String = Nothing
        Dim OTDT As String = Nothing

        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM LABORHOURS WHERE ID=@ID", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", laborhoursID))
        conn.Open()

        dr = cmd.ExecuteReader()

        Do While dr.Read()
            ID = dr.GetInt32(0)
            address = dr.GetInt32(1)
            worker = dr.GetInt32(2)
            hours = dr.GetDouble(3)
            workdate = dr.GetDateTime(4)
            notes = dr.GetString(5)
            If (dr.GetString(6) IsNot Nothing) Then
                type = dr.GetString(6)
            End If

            If (Not IsDBNull(dr.GetValue(7))) Then
                OTDT = dr.GetString(7)
            Else
                OTDT = ""
            End If

        Loop
        dr.Close()
        conn.Close()

        Try
            cboAddress.SelectedValue = address
            For Each item As Employee In cboWorker.Items
                If (item.empID = worker) Then
                    cboWorker.SelectedItem = item
                End If
            Next
            txtHours.Text = hours
            timePicker.Value = workdate
            tboxNotes.Text = notes
            cboType.Text = type
            cboType.SelectedText = type
            If (OTDT.Equals("")) Then
                cboOTDT.SelectedItem = "None"
            Else
                cboOTDT.SelectedItem = OTDT
            End If
        Catch ex As Exception
            MsgBox(ex.InnerException)
        End Try

    End Sub

    Private Sub EditProperty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.WORKERS' table. You can move, or remove it, as needed.
        Me.WORKERSTableAdapter.Fill(Me.LABORHOURSDataSet.WORKERS)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim selEmp As Employee = CType(cboWorker.SelectedItem, Employee)


        Dim hours As Decimal = Decimal.Parse(txtHours.Text)

        Dim OTDT As String = cboOTDT.SelectedItem

        If (OTDT.Equals("None")) Then
            OTDT = ""
        End If

        Dim rate As Decimal
        Dim empID = selEmp.empID
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT ID,RATE FROM WORKERS WHERE ID=@ID", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", empID))
        conn.Open()

        dr = cmd.ExecuteReader()

        Do While dr.Read()
            rate = dr.GetValue(1)
        Loop

        dr.Close()
        conn.Close()

        'TODO manual rate override

        Dim companyID As Integer = GetCompanyIDFromPropertyID(cboAddress.SelectedValue)
        Dim companyLaborRate As Decimal = GetCompanyLaborRateFromCompanyID(companyID)
        Dim companySupervisorRate As Decimal = GetCompanySupervisorRateFromCompanyID(companyID)

        'Check if the company has a different labor rate
        If (companyLaborRate > 0) Then
            LaborhoursTableAdapter.UpdateQuery(hours, timePicker.Value.ToShortDateString, tboxNotes.Text, cboAddress.SelectedValue, selEmp.empID, cboType.Text, OTDT, companyLaborRate, ID)
            'Check if the company has a supervisor rate.
            If (companySupervisorRate > 0) Then
                'If it does then add half of the labor at the supervisor rate
                LaborhoursTableAdapter.UpdateQuery(hours / 2, timePicker.Value.ToShortDateString, tboxNotes.Text, cboAddress.SelectedValue, selEmp.empID, "Supervisor", OTDT, companySupervisorRate, ID)
            End If
        Else
            'If it doesnt just use the regular employee rate
            LaborhoursTableAdapter.UpdateQuery(hours, timePicker.Value.ToShortDateString, tboxNotes.Text, cboAddress.SelectedValue, selEmp.empID, cboType.Text, OTDT, rate, ID)
        End If



        DBEdit.RefreshDataGrid()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        Try
            If (cboType.SelectedItem.Equals("Sick") Or cboType.SelectedItem.Equals("Vacation")) Then
                cboOTDT.Enabled = False
            Else
                cboOTDT.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class