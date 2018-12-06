Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class AcessoDados

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim isTran As Boolean
    Dim trans As MySqlTransaction
    Dim connStr As String

    Public Shared Function GetConnectionString(ByVal Optional strConnection As String = "") As String
        Dim retorno As New String("")
        If Not String.IsNullOrEmpty(strConnection) Then
            Try
                retorno = ConfigurationManager.ConnectionStrings(strConnection).ConnectionString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            retorno = ConfigurationManager.ConnectionStrings("ConexaoMySQL").ConnectionString
        End If
        Return retorno
    End Function

    Private Function Connect() As Boolean
        Dim connstr As String
        Dim bln As Boolean

        If conn Is Nothing Then
            connstr = GetConnectionString("ConexaoMySQL")
            If connstr <> String.Empty Then
                bln = True
                conn = New MySqlConnection(connstr)
            Else
                bln = False
            End If

        End If

        If conn.State = ConnectionState.Closed Then
            Try
                conn.Open()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        Return bln

    End Function
    Public Sub CloseConnection()
        If Not conn Is Nothing Then
            If Not conn.State = ConnectionState.Closed Then
                conn.Close()
            End If
        End If
    End Sub

    Public Function ExecuteQuery(ByVal strCmdTxt As String) As Boolean
        Dim intRows As Integer
        If conn.State = ConnectionState.Closed Then
            Connect()
        End If
        cmd = New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = strCmdTxt
        cmd.CommandType = CommandType.Text

        If Not isTran Then
            intRows = cmd.ExecuteNonQuery
            conn.Close()
        Else
            cmd.Transaction = trans
            intRows = cmd.ExecuteNonQuery
        End If

        If intRows > 0 Then
            ExecuteQuery = True
        Else
            ExecuteQuery = False
        End If
    End Function

    Public Function ExecuteAndGetReader(ByVal strCmdTxt As String) As MySqlDataReader
        If conn.State = ConnectionState.Closed Then
            Connect()
        End If

        cmd = New MySqlCommand
        cmd.Connection = conn
        cmd.CommandText = strCmdTxt
        cmd.CommandType = CommandType.Text

        If Not isTran Then
            ExecuteAndGetReader = cmd.ExecuteReader
        Else
            cmd.Transaction = trans
            ExecuteAndGetReader = cmd.ExecuteReader
        End If
    End Function
    Public Sub New()
        If Not Connect() Then
            Exit Sub
        End If
    End Sub

    Public Sub BeginTransaction()
        If isTran Then Return
        If conn.State = ConnectionState.Broken Then
            conn.Open()
        End If
        trans = conn.BeginTransaction
        isTran = True

    End Sub
    Public Sub CommitTransaction()
        If Not isTran Then Return
        trans.Commit()
        conn.Close()
        trans = Nothing
        isTran = False
    End Sub

    Public Sub RollBackTransaction()
        If Not isTran Then Return
        trans.Rollback()
        conn.Close()
        trans = Nothing
        isTran = False

    End Sub
End Class
