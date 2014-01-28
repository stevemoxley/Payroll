Imports System.Data.OleDb

Public Class EditMiles

    Dim dr, dr2 As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim ID As Integer

    Private Sub EditMiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '==============================BEGIN Employee Combo Box FIll in =============================================
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM WORKERS", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim firstname As String = dr.GetString(1)
            Dim lastname As String = dr.GetString(2)
            Dim emp As New Employee(id, firstname, lastname, 0)
            cboEmployee.Items.Add(emp)
        Loop
        cboEmployee.SelectedIndex = 0
        cboEmployee.DisplayMember = "fullname"
        cboEmployee.ValueMember = "empID"
        dr.Close()
        conn.Close()
        '===============================END Employee Combo Box Fill in ===============================================

        'TODO: This line of code loads data into the 'LABORHOURSDataSet.COMPANIES' table. You can move, or remove it, as needed.
        Me.COMPANIESTableAdapter.Fill(Me.LABORHOURSDataSet.COMPANIES)
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.WORKERS' table. You can move, or remove it, as needed.
        Me.WORKERSTableAdapter.Fill(Me.LABORHOURSDataSet.WORKERS)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim rate As Double = 0.5
        If (txtMiles.Text.Equals("")) Then
            MsgBox("Please enter mileage")
            Return
        End If
        Dim emp As Employee = CType(cboEmployee.SelectedItem, Employee)
        MileageTableAdapter.UpdateQuery(emp.empID, Double.Parse(txtMiles.Text), cboCompany.SelectedValue, txtTo.Text, txtFrom.Text, rate, dtpDate.Value.ToShortDateString, ID)
        txtMiles.Clear()
        MilesEdit.RefreshDataGrid()
    End Sub

    Public Sub FillForm(ByVal mileid As Integer)
        ID = mileid
        Dim company As Integer
        Dim worker As Integer
        Dim miles As Double
        Dim miledate As Date
        Dim toAddress As String = Nothing
        Dim fromAddress As String = Nothing
        Dim rate As Integer


        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM MILEAGE WHERE ID=@ID", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", mileid))
        conn.Open()

        dr = cmd.ExecuteReader()

        Do While dr.Read()
            id = dr.GetInt32(0)
            worker = dr.GetInt32(1)
            miles = dr.GetDouble(2)
            company = dr.GetInt32(3)

            rate = dr.GetDouble(6)
            miledate = dr.GetDateTime(7)
            If (dr.GetString(4) IsNot Nothing) Then
                toAddress = dr.GetString(4)
            End If
            If (dr.GetString(5) IsNot Nothing) Then
                fromAddress = dr.GetString(5)
            End If

        Loop
        dr.Close()
        conn.Close()

        Try
            cboCompany.SelectedValue = company

            For Each item As Employee In cboEmployee.Items
                If (item.empID = worker) Then
                    cboEmployee.SelectedItem = item
                End If
            Next

            txtFrom.Text = fromAddress
            txtTo.Text = toAddress
            dtpDate.Text = miledate
            txtMiles.Text = miles.ToString
        Catch ex As Exception
            'MsgBox(ex.InnerException)
        End Try
    End Sub

End Class