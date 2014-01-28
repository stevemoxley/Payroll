Imports System.Data.OleDb

Public Class Employee

    Dim idc As Integer
    Dim first As String
    Dim last As String
    Dim ratec As Double
    Dim dr, dr2 As OleDbDataReader
    Dim conn As OleDbConnection
    Dim cmd As OleDbCommand

    Public Sub New()

    End Sub

    Public Sub New(ByVal _id As Integer, ByVal _first As String, ByVal _last As String, ByVal _rate As Double)
        idc = _id
        first = _first
        last = _last
        ratec = _rate
    End Sub

    Public Property firstname As String
        Get
            Return first
        End Get
        Set(ByVal value As String)
            first = value
        End Set
    End Property

    Public Property lastname As String
        Get
            Return last
        End Get
        Set(ByVal value As String)
            last = value
        End Set
    End Property

    Public Property empID As Integer
        Get
            Return idc
        End Get
        Set(ByVal value As Integer)
            idc = value
        End Set
    End Property

    Public Property rate As String
        Get
            Return ratec
        End Get
        Set(ByVal value As String)
            ratec = value
        End Set
    End Property

    Public ReadOnly Property fullname As String
        Get
            Return first & " " & last
        End Get
    End Property

    Public ReadOnly Property fullnameID As String
        Get
            Return first & " " & last & "-" & idc
        End Get
    End Property


    Public Sub GetNameFromID(ByVal id As Integer)
        idc = id
        conn = GetDBConnection()
        cmd = New OleDbCommand("SELECT * FROM WORKERS WHERE ID=@ID", conn)
        cmd.Parameters.Add(New OleDbParameter("@ID", id))
        conn.Open()

        dr = cmd.ExecuteReader()

        Do While dr.Read()
            first = dr.GetString(1)
            last = dr.GetString(2)
        Loop
        dr.Close()
        conn.Close()
    End Sub


End Class
