Imports System.Data.OleDb
Public Class AddRemoveProperty

    Private Sub AddProperty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Visible = False
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim id As Integer = cboRemoveAddress.SelectedValue
            Dim address As String = Nothing
            Dim company As Integer = -1

            Dim conn = GetDBConnection()
            Dim cmd As New OleDbCommand("SELECT ADDRESS,COMPANY FROM PROPERTIES WHERE ID=@ID", conn)
            cmd.Parameters.Add(New OleDbParameter("@ID", id))
            conn.Open()

            Dim dr As OleDbDataReader = cmd.ExecuteReader()

            Do While dr.Read()
                address = dr.GetString(0)
                company = dr.GetInt32(1)
            Loop

            dr.Close()
            cmd.Dispose()
            conn.Close()

            'Delete from table
            PropertiesTableAdapter.DeleteProperty(id)
            'Add to old table
            OldpropertiesTableAdapter1.AddOldProperties(id, address, company.ToString)
            'message
            MsgBox(address & " removed from database")
            'update
            RefreshData()
        End If
    End Sub

    Private Sub btnAdd_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If (txtAddress.Text.Equals("")) Then
            MsgBox("Address cannot be blank")
        Else
            Me.PropertiesTableAdapter.AddProperty(txtAddress.Text, cboCompany.SelectedValue)
            Dim maxHours As Decimal
            If (chkIsJob.Checked) Then
                Try
                    maxHours = Decimal.Parse(txtMaxHours.Text)
                Catch ex As Exception
                    MsgBox("Max Hours must be a number")
                    Return
                End Try

                JobsTableAdapter1.Insert(DatabaseFunctions.GetMostRecentlyAddedPropertyID(), maxHours)
            End If

            txtAddress.Clear()
            txtMaxHours.Clear()
            chkIsJob.Checked = False

            MsgBox(txtAddress.Text & " added to database")
            RefreshData()
        End If
    End Sub


    Private Sub RefreshData()
        'TODO: This line of code loads data into the 'LABORHOURSDataSet1.PROPERTIES' table. You can move, or remove it, as needed.
        Me.PropertiesTableAdapter.Fill(Me.LABORHOURSDataSet1.PROPERTIES)
        'TODO: This line of code loads data into the 'LABORHOURSDataSet1.PROPERTIES' table. You can move, or remove it, as needed.
        Me.PropertiesTableAdapter.Fill(Me.LABORHOURSDataSet1.PROPERTIES)
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.COMPANIES' table. You can move, or remove it, as needed.
        Me.COMPANIESTableAdapter.Fill(Me.LABORHOURSDataSet.COMPANIES)
        'TODO: This line of code loads data into the 'LABORHOURSDataSet.WORKERS' table. You can move, or remove it, as needed.
    End Sub

    Private Sub chkIsJob_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsJob.CheckedChanged
        If (chkIsJob.Checked) Then
            pnlMaxHours.Visible = True
        Else
            pnlMaxHours.Visible = False
        End If
    End Sub
End Class