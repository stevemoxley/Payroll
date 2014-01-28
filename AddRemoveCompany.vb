Public Class AddRemoveCompany

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim laborRate As Double
        Dim supervisorRate As Double

        Try
            laborRate = Double.Parse(txtLaborRate.Text)
        Catch ex As Exception
            MsgBox("Maintenance Rate must be a number")
            Return
        End Try

        Try
            supervisorRate = Double.Parse(txtSupervisorRate.Text)
        Catch ex As Exception
            MsgBox("Supervisor Rate must be a number")
            Return
        End Try

        CompaniesTableAdapter1.Insert(txtCompany.Text, laborRate, supervisorRate)

        MsgBox("Company " + txtCompany.Text + " added to the database")
        txtCompany.Clear()
        txtLaborRate.Clear()
        txtSupervisorRate.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim id As Integer = cboCompanies.SelectedValue
            Dim name As String = cboCompanies.SelectedText
            CompaniesTableAdapter1.DeleteQuery(id)
            MsgBox("Company " + name + " removed from database")
        End If
    End Sub

    Private Sub AddRemoveCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub RefreshData()
        'TODO: This line of code loads data into the 'LABORHOURSDataSet1.COMPANIES' table. You can move, or remove it, as needed.
        Me.CompaniesTableAdapter1.Fill(Me.LABORHOURSDataSet1.COMPANIES)
    End Sub
End Class