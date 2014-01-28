Imports System.Data.OleDb

Public Class DBEdit

    Private FilterArgs As String = Nothing

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        RefreshDataGrid(FilterArgs)


        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim ID As Integer = DataGridView1.CurrentRow.Cells("LABORHOURS.ID").Value
        EditLaborHours.Visible = True
        EditLaborHours.FillForm(ID)
    End Sub

    Public Sub RefreshDataGrid()
        RefreshDataGrid(FilterArgs)
    End Sub

    Public Sub RefreshDataGrid(ByVal args As String)
        FilterArgs = args
        Dim con = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT IIf([LABORHOURS.TYPE]='Rehab',[LABORHOURS.RATE]*1.15,[LABORHOURS.RATE]) AS RATENORM, [WORKERFIRST]+' '+[WORKERLAST] AS WORKERNAME, IIf([LABORHOURS.OTDT]='Overtime',[RATENORM]*1.5,IIf([LABORHOURS.OTDT]='Double Time',[RATENORM]*2,[RATENORM])) AS FINALRATE, IIf([LABORHOURS.TYPE]='Rehab',[LABORHOURS.HOURS]*[LABORHOURS.RATE]*1.15,[LABORHOURS.HOURS]*[LABORHOURS.RATE]) AS COSTNORM, IIf([LABORHOURS.OTDT]='Overtime',[COSTNORM]*1.5,IIf([LABORHOURS.OTDT]='Double Time',[COSTNORM]*2,[COSTNORM])) AS COST, * FROM ((LABORHOURS INNER JOIN PROPERTIES ON LABORHOURS.ADDRESS=PROPERTIES.ID) INNER JOIN COMPANIES ON PROPERTIES.COMPANY=COMPANIES.ID) INNER JOIN WORKERS ON LABORHOURS.WORKER=WORKERS.ID " & FilterArgs & " ORDER BY LABORHOURS.ID DESC;")
        con.Open()
        Dim OleDataAdapter As New OleDbDataAdapter(cmd)
        Dim builder As New OleDbCommandBuilder(OleDataAdapter)
        Dim DS As New DataSet()
        OleDataAdapter.SelectCommand.Connection = con
        OleDataAdapter.Fill(DS, "LABORHOURS")
        con.Close()
        con = Nothing

        DataGridView1.DataSource = DS.Tables(0)

        DataGridView1.Columns("LABORHOURS.ID").Visible = True
        DataGridView1.Columns("LABORHOURS.ADDRESS").Visible = False
        DataGridView1.Columns("WORKER").Visible = False
        DataGridView1.Columns("PROPERTIES.COMPANY").Visible = False
        DataGridView1.Columns("COMPANIES.ID").Visible = False
        DataGridView1.Columns("PROPERTIES.ID").Visible = False
        DataGridView1.Columns("WORKERS.ID").Visible = False
        DataGridView1.Columns("WORKERS.RATE").Visible = False
        DataGridView1.Columns("COSTNORM").Visible = False
        DataGridView1.Columns("LABORHOURS.RATE").Visible = False


        With DataGridView1
            .Columns("LABORHOURS.ID").DisplayIndex = 0
            .Columns("PROPERTIES.ADDRESS").DisplayIndex = 1
            .Columns("WORKERFIRST").DisplayIndex = 2
            .Columns("WORKERLAST").DisplayIndex = 3
            .Columns("HOURS").DisplayIndex = 4
            .Columns("COST").DisplayIndex = 5
            .Columns("TYPE").DisplayIndex = 6
            .Columns("WORKDATE").DisplayIndex = 7
            .Columns("COMPANIES.COMPANY").DisplayIndex = 8
            .Columns("OTDT").DisplayIndex = 9
            .Columns("NOTES").DisplayIndex = 10

        End With
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim ID As Integer = DataGridView1.CurrentRow.Cells("LABORHOURS.ID").Value
            LaborhoursTableAdapter.DeleteQuery(ID)
            RefreshDataGrid(FilterArgs)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick, DataGridView1.CellContentDoubleClick
        Dim ID As Integer = DataGridView1.CurrentRow.Cells("LABORHOURS.ID").Value
        EditLaborHours.Visible = True
        EditLaborHours.FillForm(ID)
    End Sub

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Dim ID As Integer = DataGridView1.CurrentRow.Cells("LABORHOURS.ID").Value
        EditLaborHours.Visible = True
        EditLaborHours.FillForm(ID)
    End Sub

    Private Sub FilterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterToolStripMenuItem.Click
        LaborHoursFilter.Visible = True
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        RefreshDataGrid()
    End Sub


End Class