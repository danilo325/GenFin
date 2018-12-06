Imports MySql.Data.MySqlClient
Imports CamadaDTO
Imports System.Collections.Generic

Public Class ProdutosDAL
    Public Function DeletaProdutoPorId(ByVal _produtoId As Integer) As Boolean
        Dim strSql As String
        Dim objDB As AcessoDados
        strSql = "DELETE FROM produto WHERE id_produto = " & _produtoId
        objDB = New AcessoDados
        objDB.ExecuteQuery(strSql)
        Return True
    End Function

    Public Function GetProdutos() As List(Of Produto)
        Dim objdb As New AcessoDados
        Dim strSql As String = ""
        strSql = "SELECT * FROM produto"
        Dim dr As MySqlDataReader = objdb.ExecuteAndGetReader(strSql)
        Dim lista As New List(Of Produto)
        While dr.Read
            Dim prod As Produto = New Produto With {
                .Id = IIf(IsDBNull(dr("id_produto")), 0, dr("id_produto")),
                .Nome = IIf(IsDBNull(dr("nome")), "", dr("nome")),
                .Tipo = IIf(IsDBNull(dr("tipo")), 0, dr("tipo")),
                .Unidade = IIf(IsDBNull(dr("unidade")), "", dr("unidade")),
                .Quantidade = IIf(IsDBNull(dr("quantidade")), 0, dr("quantidade")),
                .PrecoCusto = IIf(IsDBNull(dr("preco_custo")), 0, dr("preco_custo")),
                .PrecoVenda = IIf(IsDBNull(dr("preco_venda")), 0, dr("preco_venda")),
                .Ativo = IIf(IsDBNull(dr("ativo")), 0, dr("ativo"))
            }
            lista.add(prod)
        End While
        dr.Close()
        Return lista
    End Function


    Public Function GetProdutoPorDescicao(ByVal produtoDescricao As String) As Produto
        Dim objdb As New AcessoDados
        Dim strSql As String = ""
        strSql = "SELECT * FROM produto WHERE nome = '" & produtoDescricao & "'"
        Dim dr As MySqlDataReader = objdb.ExecuteAndGetReader(strSql)
        Dim prod As Produto = Nothing
        While dr.Read
            prod = New Produto With {
                .Id = IIf(IsDBNull(dr("id_produto")), 0, dr("id_produto")),
                .Nome = IIf(IsDBNull(dr("nome")), "", dr("nome")),
                .Tipo = IIf(IsDBNull(dr("tipo")), 0, dr("tipo")),
                .Unidade = IIf(IsDBNull(dr("unidade")), "", dr("unidade")),
                .Quantidade = IIf(IsDBNull(dr("quantidade")), 0, dr("quantidade")),
                .PrecoCusto = IIf(IsDBNull(dr("preco_custo")), 0, dr("preco_custo")),
                .PrecoVenda = IIf(IsDBNull(dr("preco_venda")), 0, dr("preco_venda")),
                .Ativo = IIf(IsDBNull(dr("ativo")), 0, dr("ativo"))
            }
        End While
        dr.Close()
        Return prod
    End Function

    Public Function GetPesquisaProduto(ByVal id As Integer, ByVal nome As String, ByVal tipo As Integer, ByVal ativo As Integer) As List(Of Produto)
        Dim strSql As String = ""
        strSql = "SELECT * FROM produto "
        Dim maisdeuma As Boolean = False 'Esta variável ira dizer somente se existe mais de uma clausula na procura do sql

        If id > 0 Then 'Maior que zero pois não existe produto com id zero ou menor
            If Not maisdeuma Then
                strSql += " WHERE id_produto = " & id
                maisdeuma = True
            Else
                strSql += " AND id_produto = " & id
            End If
        End If
        If Not String.IsNullOrEmpty(nome) Then
            If Not maisdeuma Then
                strSql += " WHERE nome LIKE '%" & nome & "%' "
                maisdeuma = True
            Else
                strSql += " AND nome LIKE '%" & nome & "%' "
            End If
        End If
        If tipo > 0 Then
            If Not maisdeuma Then
                strSql += " WHERE tipo = " & tipo
                maisdeuma = True
            Else
                strSql += " AND tipo = " & tipo
            End If
        End If
        If Not String.IsNullOrEmpty(ativo) Then
            If Not maisdeuma Then
                strSql += " WHERE ativo = " & If(ativo = 0, 0, 1)
                maisdeuma = True
            Else
                strSql += " AND ativo = " & If(ativo = 0, 0, 1)
            End If
        End If

        Dim objdb As New AcessoDados
        Dim dr As MySqlDataReader = objdb.ExecuteAndGetReader(strSql)
        Dim lista As New List(Of Produto)
        While dr.Read
            Dim prod As Produto = New Produto With {
                .Id = IIf(IsDBNull(dr("id_produto")), 0, dr("id_produto")),
                .Nome = IIf(IsDBNull(dr("nome")), "", dr("nome")),
                .Tipo = IIf(IsDBNull(dr("tipo")), 0, dr("tipo")),
                .Unidade = IIf(IsDBNull(dr("unidade")), "", dr("unidade")),
                .Quantidade = IIf(IsDBNull(dr("quantidade")), 0, dr("quantidade")),
                .PrecoCusto = IIf(IsDBNull(dr("preco_custo")), 0, dr("preco_custo")),
                .PrecoVenda = IIf(IsDBNull(dr("preco_venda")), 0, dr("preco_venda")),
                .Ativo = IIf(IsDBNull(dr("ativo")), 0, dr("ativo"))
            }
            lista.Add(prod)
        End While
        dr.Close()
        Return lista
    End Function

    Public Function GetProdutoPorId(ByVal produtoid As Integer) As Produto
        Dim objdb As New AcessoDados
        Dim strSql As String = ""
        strSql = "SELECT * FROM produto WHERE id_produto = " & produtoid
        Dim dr As MySqlDataReader = objdb.ExecuteAndGetReader(strSql)
        Dim prod As Produto = Nothing
        While dr.Read
            prod = New Produto
            prod.Id = IIf(IsDBNull(dr("id_produto")), 0, dr("id_produto"))
            prod.Nome = IIf(IsDBNull(dr("nome")), "", dr("nome"))
            prod.Tipo = IIf(IsDBNull(dr("tipo")), 0, dr("tipo"))
            prod.Unidade = IIf(IsDBNull(dr("unidade")), "", dr("unidade"))
            prod.Quantidade = IIf(IsDBNull(dr("quantidade")), 0, dr("quantidade"))
            prod.PrecoCusto = IIf(IsDBNull(dr("preco_custo")), 0, dr("preco_custo"))
            prod.PrecoVenda = IIf(IsDBNull(dr("preco_venda")), 0, dr("preco_venda"))
            prod.Ativo = IIf(IsDBNull(dr("ativo")), 0, dr("ativo"))
        End While
        dr.Close()
        Return prod
    End Function

    Public Function GetProdutosPorTipo(ByVal tipoid As Integer) As List(Of Produto)
        Dim objdb As New AcessoDados
        Dim strSql As String = ""
        strSql = "SELECT * FROM produto WHERE tipo = " & tipoid
        Dim dr As MySqlDataReader = objdb.ExecuteAndGetReader(strSql)
        Dim lista As New List(Of Produto)
        While dr.Read
            Dim prod As Produto = New Produto
            prod.Id = IIf(IsDBNull(dr("id_produto")), 0, dr("id_produto"))
            prod.Nome = IIf(IsDBNull(dr("nome")), "", dr("nome"))
            prod.Tipo = IIf(IsDBNull(dr("tipo")), 0, dr("tipo"))
            prod.Unidade = IIf(IsDBNull(dr("unidade")), "", dr("unidade"))
            prod.Quantidade = IIf(IsDBNull(dr("quantidade")), 0, dr("quantidade"))
            prod.PrecoCusto = IIf(IsDBNull(dr("preco_custo")), 0, dr("preco_custo"))
            prod.PrecoVenda = IIf(IsDBNull(dr("preco_venda")), 0, dr("preco_venda"))
            prod.Ativo = IIf(IsDBNull(dr("ativo")), 0, dr("ativo"))
            lista.Add(prod)
        End While
        dr.Close()
        Return lista
    End Function
    Public Function SalvaProduto(ByVal _produto As Produto) As Boolean
        Dim strSql As String = ""
        Dim objdb As New AcessoDados
        If _produto.Acao = FlagAcao.Insert Then
            strSql = "INSERT INTO produto(nome,tipo,unidade,quantidade,preco_custo,preco_venda,ativo)" &
                "VALUES('" & _produto.Nome & "'," & _produto.Tipo & ",'" & _produto.Unidade & "','" &
                _produto.Quantidade.ToString.Replace(",", ".") & "','" & _produto.PrecoCusto.ToString.Replace(",", ".") & "','" & _produto.PrecoVenda.ToString.Replace(",", ".") & "'," & _produto.Ativo & ")"
        ElseIf _produto.Acao = FlagAcao.Update Then
            strSql = "UPDATE produto SET " &
                "nome = " & _produto.Nome &
                "tipo = " & _produto.Tipo &
                "unidade = " & _produto.Unidade &
                "quantidade = " & _produto.Quantidade &
                "preco_custo = " & _produto.PrecoCusto &
                "preco_venda = " & _produto.PrecoVenda &
                "ativo = " & _produto.Ativo &
                " WHERE id_produto = " & _produto.Id
        End If
        objdb.ExecuteQuery(strSql)
        Return True
    End Function
End Class
