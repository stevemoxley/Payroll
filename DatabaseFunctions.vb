Imports System.Data.OleDb

Module DatabaseFunctions

    Public Function GetDBConnection()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=|DataDirectory|\LABORHOURS.accdb;")
        Return conn
    End Function

    Public Function GetWorkTypeNameFromID(ByVal id As Integer)
        Dim conn = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT WORKTYPE FROM WORKTYPES WHERE ID=@ID", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", id))
        conn.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Dim name As String = Nothing

        Do While dr.Read()
            name = dr.GetString(0)
        Loop

        dr.Close()
        conn.Close()
        cmd.Dispose()

        Return name

    End Function

    Public Function GetCompanyIDFromPropertyID(ByVal id As Integer)
        Dim conn = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT COMPANIES.ID FROM COMPANIES INNER JOIN PROPERTIES ON COMPANIES.[ID] = PROPERTIES.[COMPANY] WHERE PROPERTIES.ID  = @ID", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", id))
        conn.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Dim companyID As Integer = Nothing

        Do While dr.Read()
            companyID = dr.GetInt32(0)
        Loop

        dr.Close()
        conn.Close()
        cmd.Dispose()

        Return companyID

    End Function

    Public Function GetCompanyNameFromCompanyID(ByVal id As Integer)
        Dim conn = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT COMPANY FROM COMPANIES WHERE (ID = @ID)", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", id))
        conn.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Dim companyName As String = Nothing

        Do While dr.Read()
            companyName = dr.GetString(0)
        Loop

        dr.Close()
        conn.Close()
        cmd.Dispose()

        Return companyName

    End Function

    Public Function GetCompanyLaborRateFromCompanyID(ByVal id As Integer)
        Dim conn = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT LABORRATE FROM COMPANIES WHERE (ID = @ID)", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", id))
        conn.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Dim laborRate As Decimal = Nothing

        Do While dr.Read()
            laborRate = dr.GetDecimal(0)
        Loop

        dr.Close()
        conn.Close()
        cmd.Dispose()

        Return laborRate

    End Function

    Public Function GetCompanySupervisorRateFromCompanyID(ByVal id As Integer)
        Dim conn = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT SUPERVISORRATE FROM COMPANIES WHERE (ID = @ID)", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", id))
        conn.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Dim laborRate As Decimal = Nothing

        Do While dr.Read()
            laborRate = dr.GetDecimal(0)
        Loop

        dr.Close()
        conn.Close()
        cmd.Dispose()

        Return laborRate

    End Function

    Public Sub EnterScatteredSitesAllocation(ByRef LaborhoursTableAdapter As LABORHOURSDataSetTableAdapters.LABORHOURSTableAdapter, ByVal empID As Integer, ByVal hours As Decimal, ByVal timepicker As DateTimePicker, ByVal type As String, ByVal OTDT As String, ByVal Rate As Decimal)
        'BIP
        LaborhoursTableAdapter.InsertLaborHours(344, empID, hours * 0.14, timepicker.Value.ToShortDateString, "", type, OTDT, Rate)
        'SLB
        LaborhoursTableAdapter.InsertLaborHours(354, empID, hours * 0.12, timepicker.Value.ToShortDateString, "", type, OTDT, Rate)
        '7270
        LaborhoursTableAdapter.InsertLaborHours(355, empID, hours * 0.03, timepicker.Value.ToShortDateString, "", type, OTDT, Rate)
        '1019
        LaborhoursTableAdapter.InsertLaborHours(356, empID, hours * 0.02, timepicker.Value.ToShortDateString, "", type, OTDT, Rate)
        'Chestlin
        LaborhoursTableAdapter.InsertLaborHours(358, empID, hours * 0.22, timepicker.Value.ToShortDateString, "", type, OTDT, Rate)
        '6609
        LaborhoursTableAdapter.InsertLaborHours(359, empID, hours * 0.02, timepicker.Value.ToShortDateString, "", type, OTDT, Rate)
        'Chamberlain
        LaborhoursTableAdapter.InsertLaborHours(360, empID, hours * 0.15, timepicker.Value.ToShortDateString, "", type, OTDT, Rate)
        'Normandy
        LaborhoursTableAdapter.InsertLaborHours(361, empID, hours * 0.17, timepicker.Value.ToShortDateString, "", type, OTDT, Rate)
        'FGL
        LaborhoursTableAdapter.InsertLaborHours(390, empID, hours * 0.13, timepicker.Value.ToShortDateString, "", type, OTDT, Rate)
    End Sub

    Public Function CheckIfAboveMaxJobHours(ByVal jobID As Integer)
        Dim result As Boolean = False
        Dim maxJobHours As Integer

        Try
            '===================================GET MAX JOB HOURS======================================
            Dim conn = GetDBConnection()
            Dim cmd As New OleDbCommand("SELECT MAXHOURS FROM JOBS WHERE ID=@ID", conn)
            cmd.Parameters.Add(New OleDbParameter("@ID", jobID))
            conn.Open()

            Dim dr As OleDbDataReader = cmd.ExecuteReader()

            Do While dr.Read()
                maxJobHours = dr.GetDecimal(0)
            Loop

            dr.Close()
            conn.Close()
            cmd.Dispose()
            '=========================================================================================

            '=================================GET TOTAL JOB HOURS=====================================
            Dim totalJobHours As Decimal
            cmd = New OleDbCommand("SELECT SUM(HOURS) FROM LABORHOURS WHERE ADDRESS=@ID", conn)
            cmd.Parameters.Add(New OleDbParameter("@ID", jobID))
            conn.Open()

            dr = cmd.ExecuteReader()

            Do While dr.Read()
                totalJobHours = dr.GetDouble(0)
            Loop

            dr.Close()
            conn.Close()
            cmd.Dispose()
            '=========================================================================================

            If (totalJobHours >= maxJobHours And maxJobHours > 0) Then
                MsgBox("Maximum number of hours on this job has been reached. Notify the Supervisor of Maintenance")
                result = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result
    End Function

    Public Function GetMostRecentlyAddedPropertyID()
        Dim conn = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT TOP 1 ID FROM PROPERTIES ORDER BY ID DESC", conn)
        conn.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Dim id As Integer

        Do While dr.Read()
            id = dr.GetInt32(0)
        Loop

        dr.Close()
        conn.Close()
        cmd.Dispose()

        Return id
    End Function

    Public Function GetWorkTypeFromWorkerID(ByVal workerID As Integer)
        Dim conn = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT WORKTYPE FROM WORKERS WHERE (ID = @ID)", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", workerID))
        conn.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Dim workType As Integer = Nothing

        Do While dr.Read()
            workType = dr.GetInt32(0)
        Loop

        dr.Close()
        conn.Close()
        cmd.Dispose()

        Return workType
    End Function

    Public Function GetPropertyFromWorkerID(ByVal workerID As Integer)
        Dim conn = GetDBConnection()
        Dim cmd As New OleDbCommand("SELECT PROPERTY FROM WORKERS WHERE (ID = @ID)", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", workerID))
        conn.Open()

        Dim dr As OleDbDataReader = cmd.ExecuteReader()
        Dim prop As Integer = Nothing

        Do While dr.Read()
            prop = dr.GetInt32(0)
        Loop

        dr.Close()
        conn.Close()
        cmd.Dispose()

        Return prop
    End Function

    Public Sub SetEmployeeCBOSelectedValueFromID(ByRef cboEmployee As ComboBox, ByVal id As Integer)

        For Each Employee As Employee In cboEmployee.Items
            If (Employee.empID = id) Then
                cboEmployee.SelectedItem = Employee
            End If
        Next

    End Sub

End Module
