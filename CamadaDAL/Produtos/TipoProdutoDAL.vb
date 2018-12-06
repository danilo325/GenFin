Imports MySql.Data.MySqlClient
Imports CamadaDTO
Imports System.Collections.Generic

Public Class TipoProdutoDAL
    Public Function DeletaTipoProduto(ByVal tipoProdutoId As Integer) As Boolean
        Dim strSql As String
        Dim objDB As AcessoDados
        strSql = "DELETE FROM tipos_produto WHERE id_tipo = " & tipoProdutoId
        objDB = New AcessoDados
        objDB.ExecuteQuery(strSql)
        Return True
    End Function

    Public Function GetTipoProduto() As List(Of TipoProduto)
        Dim objdb As New AcessoDados
        Dim strSql As String = ""
        strSql = "SELECT * FROM tipos_produto"
        Dim dr As MySqlDataReader = objdb.ExecuteAndGetReader(strSql)
        Dim lista As New List(Of TipoProduto)
        '  lista.Add(New TipoProduto())
        While dr.Read
            Dim tprod As TipoProduto = New TipoProduto
            tprod.Id = IIf(IsDBNull(dr("id_tipo")), 0, dr("id_tipo"))
            tprod.Descricao = IIf(IsDBNull(dr("descricao")), "", dr("descricao"))
            lista.Add(tprod)
        End While
        dr.Close()
        Return lista
    End Function
    Public Function GetTipoProdutoPorId(ByVal tipoprodid As Integer) As TipoProduto
        Dim objdb As New AcessoDados
        Dim strSql As String = ""
        strSql = "SELECT * FROM tipos_produto WHERE id_tipo = " & tipoprodid
        Dim dr As MySqlDataReader = objdb.ExecuteAndGetReader(strSql)
        Dim tprod As TipoProduto = Nothing
        While dr.Read
            tprod = New TipoProduto
            tprod.Id = IIf(IsDBNull(dr("id_tipo")), 0, dr("id_tipo"))
            tprod.Descricao = IIf(IsDBNull(dr("descricao")), "", dr("descricao"))

        End While
        dr.Close()
        Return tprod
    End Function
    Public Function GetTipoProdutoPorDescricao(ByVal strDescriacao As String) As List(Of TipoProduto)
        Dim objdb As New AcessoDados
        Dim strSql As String = ""
        strSql = "SELECT * FROM tipos_produto WHERE descricao like '%" & strDescriacao & "%'"
        Dim dr As MySqlDataReader = objdb.ExecuteAndGetReader(strSql)
        Dim lista As New List(Of TipoProduto)
        While dr.Read
            Dim tprod As TipoProduto = New TipoProduto
            tprod.Id = IIf(IsDBNull(dr("id_tipo")), 0, dr("id_tipo"))
            tprod.Descricao = IIf(IsDBNull(dr("descricao")), "", dr("descricao"))
            lista.Add(tprod)
        End While
        dr.Close()
        Return lista
    End Function

    Public Function SalvaTipoprodtuo(ByVal tipoproduto As TipoProduto) As Boolean
        Dim strsql As String = String.Empty
        Dim objdb As New AcessoDados
        If tipoproduto.Acao = FlagAcao.Insert Then
            strsql = "INSERT INTO  tipos_produto(descricao) VALUES('" & tipoproduto.Descricao & "')"
        ElseIf tipoproduto.Acao = FlagAcao.Update Then
            strsql = "UPDATE tipos_produto SET descricao = '" & tipoproduto.Descricao & " WHERE id_tipo = " & tipoproduto.Id
        Else
            Return False
        End If
        Try
            objdb.ExecuteQuery(strsql)
        Catch ex As Exception
            Throw New Exception
        End Try
        Return True
    End Function


End Class
