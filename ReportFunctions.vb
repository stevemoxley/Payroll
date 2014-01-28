Imports Microsoft.Office.Interop

Module ReportFunctions

    Public Sub GenerateReport(ByVal reportName As String)
        ' Start a new instance of Access for Automation:
        Dim oAccess As Access.Application
        oAccess = New Access.Application()
        oAccess.Application.Visible = True
        ' Open a database in exclusive mode:
        oAccess.OpenCurrentDatabase(Application.StartupPath & "\LABORHOURS.accdb", False)
        ' Preview a report named Sales:
        oAccess.DoCmd.OpenReport(reportName, Access.AcView.acViewPreview)
    End Sub

    Public Sub GenerateReport(ByVal reportName As String, ByVal reportParameters As String)
        ' Start a new instance of Access for Automation:
        Dim oAccess As Access.Application
        oAccess = New Access.Application()
        oAccess.Application.Visible = True
        ' Open a database in exclusive mode:
        oAccess.OpenCurrentDatabase(Application.StartupPath & "\LABORHOURS.accdb", False)
        ' Preview a report named Sales:
        oAccess.DoCmd.OpenReport(reportName, Access.AcView.acViewPreview, , reportParameters)
    End Sub

End Module


