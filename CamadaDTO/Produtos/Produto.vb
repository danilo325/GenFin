Public Class Produto
    Private Produto_Id As Integer
    Private Produto_Nome As String
    Private Produto_Tipo As Integer
    Private Produto_Unidade As String
    Private Produto_Quantidade As Double
    Private Produto_PrecoCusto As Double
    Private Produto_PrecoVenda As Double
    Private Produto_Ativo As Boolean
    Private Produto_Acao As Byte

    Public Property Id As Integer
        Get
            Return Produto_Id
        End Get
        Set(value As Integer)
            Produto_Id = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return Produto_Nome
        End Get
        Set(value As String)
            Produto_Nome = value
        End Set
    End Property

    Public Property Tipo As Integer
        Get
            Return Produto_Tipo
        End Get
        Set(value As Integer)
            Produto_Tipo = value
        End Set
    End Property

    Public Property Unidade As String
        Get
            Return Produto_Unidade
        End Get
        Set(value As String)
            Produto_Unidade = value
        End Set
    End Property

    Public Property Quantidade As Double
        Get
            Return Produto_Quantidade
        End Get
        Set(value As Double)
            Produto_Quantidade = value
        End Set
    End Property

    Public Property PrecoCusto As Double
        Get
            Return Produto_PrecoCusto
        End Get
        Set(value As Double)
            Produto_PrecoCusto = value
        End Set
    End Property

    Public Property PrecoVenda As Double
        Get
            Return Produto_PrecoVenda
        End Get
        Set(value As Double)
            Produto_PrecoVenda = value
        End Set
    End Property

    Public Property Ativo As Boolean
        Get
            Return Produto_Ativo
        End Get
        Set(value As Boolean)
            Produto_Ativo = value
        End Set
    End Property

    Public Property Acao As Byte
        Get
            Return Produto_Acao
        End Get
        Set(value As Byte)
            Produto_Acao = value
        End Set
    End Property
End Class
