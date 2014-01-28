Imports System.Data.OleDb

Public Class EnterMiles

    Dim dr, dr2 As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim ID As Integer

    Private Sub EnterMiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.PROPERTIES' table. You can move, or remove it, as needed.
        Me.PROPERTIESTableAdapter.Fill(Me.LABORHOURSDataSet.PROPERTIES)

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
            cboEmployee.Items.Add(emp)
        Loop
        cboEmployee.DisplayMember = "fullname"
        cboEmployee.ValueMember = "empID"
        cboEmployee.SelectedIndex = 0
        dr.Close()
        conn.Close()
        '===============================END Employee Combo Box Fill in ===============================================


        'TODO: This line of code loads data into the 'LABORHOURSDataSet.COMPANIES' table. You can move, or remove it, as needed.
        Me.COMPANIESTableAdapter.Fill(Me.LABORHOURSDataSet.COMPANIES)
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.WORKERS' table. You can move, or remove it, as needed.
        Me.WORKERSTableAdapter.Fill(Me.LABORHOURSDataSet.WORKERS)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim selEmp As Employee = CType(cboEmployee.SelectedItem, Employee)
        Dim rate As Double = 0.5
        Dim companyID As Integer = DatabaseFunctions.GetCompanyIDFromPropertyID(cboAddress.SelectedValue)
        If (txtMiles.Text.Equals("")) Then
            MsgBox("Please enter mileage")
            Return
        End If
        MileageTableAdapter.InsertQuery(selEmp.empID, txtMiles.Text, companyID, txtTo.Text, txtFrom.Text, rate, dtpDate.Value.ToShortDateString)
        txtMiles.Clear()
        MilesEdit.RefreshDataGrid()
    End Sub
End Class