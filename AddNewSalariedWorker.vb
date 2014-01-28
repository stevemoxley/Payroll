Imports System.Data.OleDb

Public Class AddNewSalariedWorker

    Dim dr, dr2 As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand

    Private Sub AddNewSalariedWorker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
            cboWorker.Items.Add(emp)
        Loop
        cboWorker.DisplayMember = "fullname"
        cboWorker.ValueMember = "empID"
        cboWorker.SelectedIndex = 0
        dr.Close()
        conn.Close()
        '===============================END Employee Combo Box Fill in ===============================================

        '==============================BEGIN Type Combo Box FIll in =============================================
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM WORKTYPES", conn)
        conn.Open()

        dr = cmd.ExecuteReader()

        Do While dr.Read()
            Dim id As Integer = dr.GetInt32(0)
            Dim type As String = dr.GetString(1)
            Dim typeLI As New TypeListItem(type, id)
            If (Not (type.Equals("Sick") Or type.Equals("Vacation") Or type.Equals("Holiday"))) Then
                cboType.Items.Add(typeLI)
            End If
        Loop
        cboType.DisplayMember = "Type"
        cboType.ValueMember = "ID"
        cboType.SelectedIndex = 0
        dr.Close()
        conn.Close()
        '===============================END Type Combo Box Fill in ===============================================

        'TODO: This line of code loads data into the 'LABORHOURSDataSet.PROPERTIES' table. You can move, or remove it, as needed.
        Me.PROPERTIESTableAdapter.Fill(Me.LABORHOURSDataSet.PROPERTIES)

    End Sub

    Private Sub btnMakeSalaried_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeSalaried.Click
        Dim emp As Employee = CType(cboWorker.SelectedItem, Employee)
        Dim type As TypeListItem = CType(cboType.SelectedItem, TypeListItem)
        SalariedTableAdapter1.InsertWorker(emp.empID, cboLocation.SelectedValue, type.ID)
        AddSalariedHours.ReloadListBox()
        MsgBox("Employee " & emp.fullname & " added as a salaried employee.")
    End Sub
End Class

Public Class TypeListItem

    Dim typec As String
    Dim idc As Integer

    Public Sub New(ByVal type As String, ByVal ID As Integer)
        typec = type
        idc = ID
    End Sub


    Public Property Type As String
        Get
            Return typec
        End Get
        Set(ByVal value As String)
            typec = value
        End Set
    End Property

    Public Property ID As Integer
        Get
            Return idc
        End Get
        Set(ByVal value As Integer)
            idc = value
        End Set
    End Property
End Class