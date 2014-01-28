Imports System.Data.OleDb

Public Class EnterCommission

    Dim dr, dr2 As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand

    Private Sub EnterCommission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '==============================BEGIN Employee Combo Box FIll in =============================================
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT ID, WORKERFIRST, WORKERLAST FROM WORKERS", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim firstname As String = dr.GetString(1)
            Dim lastname As String = dr.GetString(2)
            Dim emp As Employee = New Employee(id, firstname, lastname, 0)
            cboAgent.Items.Add(emp)
        Loop
        cboAgent.SelectedIndex = 0
        cboAgent.DisplayMember = "fullname"
        cboAgent.ValueMember = "empID"
        dr.Close()
        conn.Close()
        '===============================END Employee Combo Box Fill in ===============================================


        'TODO: This line of code loads data into the 'LABORHOURSDataSet.PROPERTIES' table. You can move, or remove it, as needed.
        Me.PROPERTIESTableAdapter.Fill(Me.LABORHOURSDataSet.PROPERTIES)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (txtAmount.Text.Equals("")) Then
            MsgBox("Please enter a commission amount")
            Return
        End If
        If (txtInvoice.Text.Equals("")) Then
            MsgBox("Please enter an invoice amount")
            Return
        End If

        Dim selEmp As Employee = CType(cboAgent.SelectedItem, Employee)

        CommissionTableAdapter.AddCommission(cboAddress.SelectedValue, Double.Parse(txtAmount.Text), selEmp.empID, dtpDate.Value.ToShortDateString, Double.Parse(txtInvoice.Text))
        txtAmount.Clear()
        txtInvoice.Clear()
        EditCommission.RefreshDataGrid()

    End Sub
End Class