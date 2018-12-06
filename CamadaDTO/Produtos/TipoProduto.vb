Public Class TipoProduto
    Private TipoProduto_Id As Integer
    Private TipoProduto_Descricao As String
    Private TipoProduto_Acao As Byte

    Public Property Id As Integer
        Get
            Return TipoProduto_Id
        End Get
        Set(value As Integer)
            TipoProduto_Id = value
        End Set
    End Property

    Public Property Descricao As String
        Get
            Return TipoProduto_Descricao
        End Get
        Set(value As String)
            TipoProduto_Descricao = value
        End Set
    End Property

    Public Property Acao As Byte
        Get
            Return TipoProduto_Acao
        End Get
        Set(value As Byte)
            TipoProduto_Acao = value
        End Set
    End Property
End Class
