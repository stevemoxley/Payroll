Public Class MainForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterHours.Click
        EnterLaborHours.Visible = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewHours.Click
        DBEdit.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateReports.Click
        Reporting.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterMiles.Click
        EnterMiles.Visible = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewMiles.Click
        MilesEdit.Visible = True
    End Sub

    Private Sub btnSalary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalary.Click
        AddSalariedHours.Visible = True
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProperty.Click
        AddRemoveProperty.Visible = True
    End Sub

    Private Sub btnAddRemoveCompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompany.Click
        AddRemoveCompany.Visible = True
    End Sub

    Private Sub btnCommission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommission.Click
        EnterCommission.Visible = True
    End Sub

    Private Sub btnViewCommission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewCommission.Click
        EditCommission.Visible = True
    End Sub
End Class