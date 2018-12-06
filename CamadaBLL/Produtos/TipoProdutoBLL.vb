Imports CamadaDAL
Imports CamadaDTO
Public Class TipoProdutoBLL
    Public Function GetTodosOsTipos() As List(Of TipoProduto)
        Dim db As New TipoProdutoDAL
        Return db.GetTipoProduto
    End Function
    Public Function GetTipoPorId(ByVal TipoId As Integer) As TipoProduto
        Dim bd As New TipoProdutoDAL
        Return bd.GetTipoProdutoPorId(TipoId)

    End Function
    Public Function SalvarTipoProduto(ByVal Tipo As TipoProduto)
        Dim db As New TipoProdutoDAL
        Return db.SalvaTipoprodtuo(Tipo)

    End Function
    Public Function DeletaTipoProduto(ByVal TipoId As Integer)
        Dim db As New TipoProdutoDAL
        Return db.DeletaTipoProduto(TipoId)
    End Function
    Public Function GetTipoProdutoProDescricao(ByRef strDescricao As String) As List(Of TipoProduto)
        Dim db As New TipoProdutoDAL
        Return db.GetTipoProdutoPorDescricao(strDescricao)
    End Function
End Class
