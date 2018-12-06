Imports CamadaBLL
Imports CamadaDTO
Public Class CadastroProduto
    Private Produtos As List(Of Produto)
    Private Produto As Produto
    Private Tipos As List(Of TipoProduto)
    Private Tipo As TipoProduto
    Private Erro As New ErrorProvider
    Private Sub CadastroProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpb_novoTipo.Visible = False
        CarregaComboTipo()

    End Sub

    Public Sub CarregaComboTipo()
        Dim clsBLL As New TipoProdutoBLL
        Tipos = clsBLL.GetTodosOsTipos

        With cmb_tipo
            .DataSource = Tipos
            .DisplayMember = "Descricao"
            .ValueMember = "Id"
        End With
        cmb_tipo.SelectedValue = ""



    End Sub

    Private Sub GravaNovoTipo()
        Dim clsBLL As New TipoProdutoBLL
        If String.IsNullOrEmpty(txb_nomeTipo.Text) Then
            Erro.SetError(txb_nomeTipo, "Não pode ser Vazio")
        ElseIf clsBLL.GetTipoProdutoProDescricao(txb_nomeTipo.Text.Trim.ToUpper).Count > 0 Then

            Erro.SetError(txb_nomeTipo, "Já existe um tipo com este Nome")
        Else
            Dim bln As Boolean
            Dim tipoBLL As New TipoProdutoBLL
            Dim tipolocal As New TipoProduto
            'Salva os tipos de produtos em Uppercase para ficar padronizado
            tipolocal.Descricao = txb_nomeTipo.Text.Trim.ToUpper
            tipolocal.Acao = 1
            bln = tipoBLL.SalvarTipoProduto(tipolocal)
            If bln Then
                txb_nomeTipo.Text = ""
                CarregaComboTipo()
                Erro.SetError(txb_nomeTipo, "")
                MsgBox("O tipo " & txb_nomeTipo.Text.Trim & " foi salvo com sucesso", MsgBoxStyle.Information, "Tipo Gravado com sucesso")
            Else
                MsgBox("Problemas Ao gravar o tipo", MsgBoxStyle.Critical)
            End If


        End If

    End Sub
    Public Sub SalvaProduto()
        Dim prod As Produto
        Dim tipoProd As New TipoProduto
        Dim prodBLL As New ProdutoBLL
        Dim tipoProdBll As New TipoProdutoBLL

        If ValidaFormulario() Then
            prod = New Produto With {
                .Acao = 1,
                .Nome = txb_descricao.Text.Trim.ToUpper,
                .Unidade = txb_uniMedida.Text.Trim.ToUpper,
                .Quantidade = Double.Parse(txb_quantidade.Text.Trim),
                .Ativo = chb_ativo.Checked,
                .PrecoCusto = Double.Parse(txb_pcusto.Text.Trim),
                .PrecoVenda = Double.Parse(txb_pvenda.Text.Trim),
                .Tipo = cmb_tipo.SelectedValue
                }
            Try
                prodBLL.SalvaProdtuto(prod)
            Catch ex As Exception
                MsgBox(("Problema ao salvar o produto novo." & vbNewLine & ex.ToString), MsgBoxStyle.Critical, "Problema ao finalizar Cadastro")
                Return
            End Try
            MsgBox("O produto " & txb_descricao.Text.Trim.ToUpper & " foi salvo.", vbApplicationModal, "Produto Salvo com Sucesso")
            ResetFormulario()
        End If
    End Sub
    Private Sub ResetFormulario()
        txb_descricao.ResetText()
        txb_pcusto.Text = 0
        txb_pvenda.Text = 0
        txb_uniMedida.ResetText()
        txb_quantidade.Text = 0
        cmb_tipo.ResetText()
        chb_ativo.ResetText()

    End Sub

    Private Function ValidaFormulario() As Boolean
        Dim produtoBLL As New ProdutoBLL

        If String.IsNullOrEmpty(txb_descricao.Text.Trim) Then
            Erro.SetError(txb_descricao, "Não pode ficar vazio")
            Return False
        ElseIf Not IsNothing(produtoBLL.GetProdutoPorDescricao(txb_descricao.Text.Trim)) Then

            Erro.SetError(txb_descricao, "Já exsite um produto com este nome")
            Return False
        Else
            Erro.SetError(txb_descricao, "")
        End If


        If String.IsNullOrEmpty(cmb_tipo.Text) Then
            Erro.SetError(cmb_tipo, "Este valor não pode ficar vazio.")
            Return False
        ElseIf cmb_tipo.SelectedIndex = -1 Then
            Erro.SetError(cmb_tipo, "Este tipo nao existe.")
            Return False

        Else
            Erro.SetError(cmb_tipo, "")
        End If


        If String.IsNullOrEmpty(txb_uniMedida.Text) Then
            Erro.SetError(txb_uniMedida, "Valor não pode ficar vazio.")
            Return False
        Else
            Erro.SetError(txb_uniMedida, "")
        End If
        If String.IsNullOrEmpty(txb_quantidade.Text.Trim) Then
            Erro.SetError(txb_quantidade, "Quantidade nao pode ser vazio")
            Return False
        ElseIf Not IsNumeric(txb_quantidade.Text.Trim) Then
            Erro.SetError(txb_quantidade, "Valor invalido para quantidade")
            Return False
        Else
            Erro.SetError(txb_quantidade, "")
        End If
        If String.IsNullOrEmpty(txb_pcusto.Text) Then
            Erro.SetError(txb_pcusto, "O Preço de custo nao pode ser vazio")
            Return False
        ElseIf Not IsNumeric(txb_pcusto.Text.Trim) Then
            Erro.SetError(txb_pcusto, "Valor invalido para preço de custo")
            Return False
        Else
            Erro.SetError(txb_pcusto, "")
        End If
        If String.IsNullOrEmpty(txb_pvenda.Text.Trim) Then
            Erro.SetError(txb_pvenda, "O preço de venda nao pode ser vazio")
            Return False
        ElseIf Not IsNumeric(txb_pvenda.Text.Trim) Then
            Erro.SetError(txb_pvenda, "Valor invalido para preço de venda")
            Return False
        Else
            Erro.SetError(txb_pvenda, "")
        End If

        Return True
    End Function

    Private Sub bnt_cancelaTipo_Click(sender As Object, e As EventArgs) Handles bnt_cancelaTipo.Click
        txb_nomeTipo.Text = String.Empty
        gpb_novoTipo.Visible = False
        Erro.SetError(txb_nomeTipo, "")
    End Sub

    Private Sub bnt_novoTipo_Click(sender As Object, e As EventArgs) Handles bnt_novoTipo.Click
        gpb_novoTipo.Visible = True
    End Sub



    Private Sub bnt_salvaTipo_Click(sender As Object, e As EventArgs) Handles bnt_salvaTipo.Click
        GravaNovoTipo()
    End Sub

    Private Sub gpb_novoTipo_Enter(sender As Object, e As EventArgs) Handles gpb_novoTipo.Enter

    End Sub

    Private Sub bnt_cadastro_Click(sender As Object, e As EventArgs) Handles bnt_cadastro.Click
        SalvaProduto()
    End Sub

    Private Sub bnt_limpa_Click(sender As Object, e As EventArgs) Handles bnt_limpa.Click
        ResetFormulario()
    End Sub

    Private Sub bnt_cancela_Click(sender As Object, e As EventArgs) Handles bnt_cancela.Click
        ResetFormulario()
        Me.Close()
    End Sub
End Class