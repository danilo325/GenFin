Imports CamadaBLL
Imports CamadaDTO
Public Class ListaProdutos
    Private col_id As New DataGridViewTextBoxColumn
    Private col_nome As New DataGridViewTextBoxColumn
    Private col_tipo As New DataGridViewTextBoxColumn
    Private col_unidade As New DataGridViewTextBoxColumn
    Private col_quatidade As New DataGridViewTextBoxColumn
    Private col_precocusto As New DataGridViewTextBoxColumn
    Private col_precovenda As New DataGridViewTextBoxColumn
    Private col_ativo As New DataGridViewTextBoxColumn



    Private Sub ListaProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreparaLista()
        CarregaDadosProdutos()

    End Sub

    Private Sub Pesquisa()
        If String.IsNullOrEmpty(txb_id.Text) And String.IsNullOrEmpty(txb_nome.Text) And String.IsNullOrEmpty(cmb_ativo.Text) And String.IsNullOrEmpty(cmb_tipo.Text) Then
            CarregaDadosProdutos()
        ElseIf


        End If
    End Sub

    Private Sub PreparaLista()
        With col_id
            .HeaderText = "ID"
            .Width = 20
        End With
        With col_nome
            .HeaderText = "Nome"
            .Width = 200
        End With
        With col_tipo
            .HeaderText = "Tipo"
            .Width = 100
        End With
        With col_unidade
            .HeaderText = "Unidade"
            .Width = 30
        End With
        With col_quatidade
            .HeaderText = "Quantidade"
            .Width = 50
        End With
        With col_precocusto
            .HeaderText = "Preço Custo"
            .Width = 50
        End With
        With col_precovenda
            .HeaderText = "Preço Venda"
            .Width = 50
        End With
        With col_ativo
            .HeaderText = "Ativo"
            .Width = 10
        End With

        dgv_produtos.Columns.AddRange(col_id, col_nome, col_unidade, col_tipo, col_quatidade, col_precocusto, col_precovenda, col_ativo)

    End Sub


    Private Sub CarregaDadosProdutos()

        Dim prodBLL As New ProdutoBLL
        Dim tipo As New TipoProdutoBLL
        Dim produtos As New List(Of Produto)
        Try
            produtos = prodBLL.GetTodosProdutos
            For Each prod As Produto In produtos
                dgv_produtos.Rows.Add(prod.Id, prod.Nome, prod.Unidade, tipo.GetTipoPorId(prod.Tipo).Descricao, prod.Quantidade, prod.PrecoCusto, prod.PrecoVenda, prod.Ativo)

            Next prod
            'dgv_produtos.DataSource = produtos
            'dgv_produtos.Columns("Acao").Visible = False 'remove somente a colina de acao pois esta nao infuencia em nada
        Catch ex As Exception
            MsgBox("Problemas" & vbNewLine & ex.ToString, MsgBoxStyle.Critical, "Problemas para recuperar lista de produtos")
        End Try
    End Sub



    Private Sub bnt_novo_Click(sender As Object, e As EventArgs) Handles bnt_novo.Click
        CadastroProduto.Show()

    End Sub

    Private Sub bnt_fecha_Click(sender As Object, e As EventArgs) Handles bnt_fecha.Click
        Me.Close()
    End Sub
End Class