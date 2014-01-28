Imports System.Data.OleDb



Public Class CommissionEdit

    Dim dr, dr2 As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim ID As Integer = -1

    Public Sub PopulateForm(ByVal commissionid As Integer)
        ID = commissionid
        Dim address As Integer
        Dim worker As Integer
        Dim amount As Double
        Dim invoiceamount As Double
        Dim earneddate As Date

        Dim conn = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT * FROM COMMISSION WHERE COMMISSION.ID = @ID", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", commissionid))
        conn.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        Do While dr.Read()
            address = dr.GetInt32(1)
            amount = dr.GetDouble(2)
            invoiceamount = dr.GetDouble(3)
            worker = dr.GetInt32(4)
            earneddate = dr.GetDateTime(5)
        Loop
        dr.Close()
        conn.Close()

        Try
            cboAddress.SelectedValue = address
            For Each item As Employee In cboAgent.Items
                If (item.empID = worker) Then
                    cboAgent.SelectedItem = item
                End If
            Next
            txtAmount.Text = amount
            txtInvoice.Text = invoiceamount
            dtpDate.Value = earneddate

        Catch ex As Exception
            MsgBox(ex.InnerException)
        End Try
    End Sub

    Private Sub CommissionEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
            cboAgent.Items.Add(emp)
        Loop
        cboAgent.DisplayMember = "fullname"
        cboAgent.ValueMember = "empID"
        cboAgent.SelectedIndex = 0
        dr.Close()
        conn.Close()
        '===============================END Employee Combo Box Fill in ===============================================


        'TODO: This line of code loads data into the 'LABORHOURSDataSet.PROPERTIES' table. You can move, or remove it, as needed.
        Me.PROPERTIESTableAdapter.Fill(Me.LABORHOURSDataSet.PROPERTIES)
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.WORKERS' table. You can move, or remove it, as needed.
        Me.WORKERSTableAdapter.Fill(Me.LABORHOURSDataSet.WORKERS)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim selEmp As Employee = CType(cboAgent.SelectedItem, Employee)

        CommissionTableAdapter.UpdateQuery(cboAddress.SelectedValue, Double.Parse(txtAmount.Text), selEmp.empID, dtpDate.Value.ToShortDateString, Double.Parse(txtInvoice.Text), ID)
        EditCommission.RefreshDataGrid()
    End Sub

End Class