Imports System.Data.OleDb

Public Class EditCommission

    Dim FilterArgs As String = Nothing

    Public Sub RefreshDataGrid()
        RefreshDataGrid(FilterArgs)
    End Sub

    Public Sub RefreshDataGrid(ByVal args As String)
        FilterArgs = args
        Dim con = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT * FROM ((COMPANIES INNER JOIN PROPERTIES ON COMPANIES.[ID] = PROPERTIES.[COMPANY]) INNER JOIN COMMISSION ON PROPERTIES.[ID] = COMMISSION.[PROPERTYID]) INNER JOIN WORKERS ON COMMISSION.EMPLOYEE = WORKERS.ID " & FilterArgs & " ORDER BY COMMISSION.ID DESC;")
        con.Open()
        Dim OleDataAdapter As New OleDbDataAdapter(cmd)
        Dim builder As New OleDbCommandBuilder(OleDataAdapter)
        Dim DS As New DataSet()
        OleDataAdapter.SelectCommand.Connection = con
        OleDataAdapter.Fill(DS, "COMMISSION")
        con.Close()
        con = Nothing

        DataGridView1.DataSource = DS.Tables(0)

        DataGridView1.Columns("PROPERTIES.ID").Visible = False
        DataGridView1.Columns("COMPANIES.ID").Visible = False
        DataGridView1.Columns("PROPERTIES.COMPANY").Visible = False
        DataGridView1.Columns("PROPERTYID").Visible = False
        DataGridView1.Columns("EMPLOYEE").Visible = False
        DataGridView1.Columns("WORKERS.ID").Visible = False
        DataGridView1.Columns("RATE").Visible = False

        With DataGridView1
            .Columns("COMMISSION.ID").DisplayIndex = 0
            .Columns("ADDRESS").DisplayIndex = 1
            .Columns("COMPANIES.COMPANY").DisplayIndex = 2
            .Columns("AMOUNT").DisplayIndex = 3
            .Columns("INVOICEAMOUNT").DisplayIndex = 4
            .Columns("WORKERFIRST").DisplayIndex = 5
            .Columns("WORKERLAST").DisplayIndex = 6
            .Columns("EARNEDDATE").DisplayIndex = 7
        End With


    End Sub

    Private Sub EditCommission_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshDataGrid()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim ID As Integer = DataGridView1.CurrentRow.Cells("COMMISSION.ID").Value
        CommissionEdit.Visible = True
        CommissionEdit.PopulateForm(ID)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim ID As Integer = DataGridView1.CurrentRow.Cells("COMMISSION.ID").Value
        CommissionEdit.Visible = True
        CommissionEdit.PopulateForm(ID)
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Dim ID As Integer = DataGridView1.CurrentRow.Cells("COMMISSION.ID").Value
        CommissionEdit.Visible = True
        CommissionEdit.PopulateForm(ID)
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Dim ID As Integer = DataGridView1.CurrentRow.Cells("COMMISSION.ID").Value
        CommissionEdit.Visible = True
        CommissionEdit.PopulateForm(ID)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim ID As Integer = DataGridView1.CurrentRow.Cells("COMMISSION.ID").Value
            CommissionTableAdapter.DeleteQuery(ID)
            RefreshDataGrid()
        End If
    End Sub

    Private Sub FilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterToolStripMenuItem.Click
        CommissionFilter.Visible = True
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim ID As Integer = DataGridView1.CurrentRow.Cells("COMMISSION.ID").Value
        CommissionEdit.Visible = True
        CommissionEdit.PopulateForm(ID)
    End Sub
End Class