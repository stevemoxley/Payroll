Imports System.Data.OleDb

Public Class MilesEdit

    Dim FilterArgs As String = Nothing


    Public Sub RefreshDataGrid()
        RefreshDataGrid(FilterArgs)
    End Sub

    Public Sub RefreshDataGrid(ByVal args As String)

        FilterArgs = args

        Dim con = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT * FROM (MILEAGE INNER JOIN WORKERS ON MILEAGE.WORKER = WORKERS.ID) INNER JOIN COMPANIES ON MILEAGE.COMPANY = COMPANIES.ID " & FilterArgs & " ORDER BY MILEAGE.ID DESC;")
        con.Open()
        Dim OleDataAdapter As New OleDbDataAdapter(cmd)
        Dim builder As New OleDbCommandBuilder(OleDataAdapter)
        Dim DS As New DataSet()
        OleDataAdapter.SelectCommand.Connection = con
        OleDataAdapter.Fill(DS, "MILEAGE")
        con.Close()
        con = Nothing

        DataGridView1.DataSource = DS.Tables(0)

        DataGridView1.Columns("WORKER").Visible = False
        DataGridView1.Columns("MILEAGE.COMPANY").Visible = False
        DataGridView1.Columns("WORKERS.ID").Visible = False
        DataGridView1.Columns("COMPANIES.ID").Visible = False
        DataGridView1.Columns("WORKERS.RATE").Visible = False


        With DataGridView1

        End With
    End Sub

    Private Sub MilesEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RefreshDataGrid()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim ID As Integer = DataGridView1.CurrentRow.Cells("MILEAGE.ID").Value
        EditMiles.Visible = True
        EditMiles.FillForm(ID)
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Dim ID As Integer = DataGridView1.CurrentRow.Cells("MILEAGE.ID").Value
        EditMiles.Visible = True
        EditMiles.FillForm(ID)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim ID As Integer = DataGridView1.CurrentRow.Cells("MILEAGE.ID").Value
        EditMiles.Visible = True
        EditMiles.FillForm(ID)
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Dim ID As Integer = DataGridView1.CurrentRow.Cells("MILEAGE.ID").Value
        EditMiles.Visible = True
        EditMiles.FillForm(ID)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim ID As Integer = DataGridView1.CurrentRow.Cells("MILEAGE.ID").Value
            MileageTableAdapter.DeleteQuery(ID)
            RefreshDataGrid()
        End If
    End Sub

    Private Sub FilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterToolStripMenuItem.Click
        MilesFilter.Visible = True
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        RefreshDataGrid()
    End Sub
End Class