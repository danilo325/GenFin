Imports CamadaDTO
Imports CamadaDAL
Public Class ProdutoBLL
    Public Function GetTodosProdutos() As List(Of Produto)
        Dim db As New ProdutosDAL
        Return db.GetProdutos

    End Function

    Public Function GetProdutoPorId(ByVal ProdutoId As Integer) As Produto
        Dim db As New ProdutosDAL
        Return db.GetProdutoPorId(ProdutoId)
    End Function
    Public Function GetProdutoPorDescricao(ByVal ProdutoDescricao As String) As Produto
        Dim db As New ProdutosDAL
        Return db.GetProdutoPorDescicao(ProdutoDescricao)
    End Function

    Public Function GetProdutoPorTipo(ByVal TipoId As Integer) As List(Of Produto)
        Dim db As New ProdutosDAL
        Return db.GetProdutosPorTipo(TipoId)
    End Function

    Public Function SalvaProdtuto(ByVal Prod As Produto)
        Dim db As New ProdutosDAL
        Return db.SalvaProduto(Prod)
    End Function
    Public Function DeletaProduto(ByVal ProdutoId As Integer)
        Dim db As New ProdutosDAL
        Return db.DeletaProdutoPorId(ProdutoId)
    End Function

    Public Function PesquisaProduto() As List(Of Produto)

    End Function
End Class
