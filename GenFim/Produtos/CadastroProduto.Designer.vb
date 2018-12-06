<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroProduto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Menu_sup = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.gpb_cadastro = New System.Windows.Forms.GroupBox()
        Me.bnt_novoTipo = New System.Windows.Forms.Button()
        Me.chb_ativo = New System.Windows.Forms.CheckBox()
        Me.txb_pcusto = New System.Windows.Forms.TextBox()
        Me.lbl_pvenda = New System.Windows.Forms.Label()
        Me.txb_pvenda = New System.Windows.Forms.TextBox()
        Me.lbl_pcusto = New System.Windows.Forms.Label()
        Me.txb_quantidade = New System.Windows.Forms.TextBox()
        Me.lbl_quantidade = New System.Windows.Forms.Label()
        Me.txb_uniMedida = New System.Windows.Forms.TextBox()
        Me.lbl_uniMedida = New System.Windows.Forms.Label()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.txb_descricao = New System.Windows.Forms.TextBox()
        Me.lbl_descricao = New System.Windows.Forms.Label()
        Me.bnt_cadastro = New System.Windows.Forms.Button()
        Me.gpb_novoTipo = New System.Windows.Forms.GroupBox()
        Me.bnt_cancelaTipo = New System.Windows.Forms.Button()
        Me.bnt_salvaTipo = New System.Windows.Forms.Button()
        Me.txb_nomeTipo = New System.Windows.Forms.TextBox()
        Me.lbl_nomeTipo = New System.Windows.Forms.Label()
        Me.lbl_tituloTela = New System.Windows.Forms.Label()
        Me.bnt_limpa = New System.Windows.Forms.Button()
        Me.bnt_cancela = New System.Windows.Forms.Button()
        Me.Menu_sup.SuspendLayout()
        Me.gpb_cadastro.SuspendLayout()
        Me.gpb_novoTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu_sup
        '
        Me.Menu_sup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.Menu_sup.Location = New System.Drawing.Point(0, 0)
        Me.Menu_sup.Name = "Menu_sup"
        Me.Menu_sup.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Menu_sup.Size = New System.Drawing.Size(800, 24)
        Me.Menu_sup.TabIndex = 0
        Me.Menu_sup.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(128, 20)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'gpb_cadastro
        '
        Me.gpb_cadastro.Controls.Add(Me.bnt_novoTipo)
        Me.gpb_cadastro.Controls.Add(Me.chb_ativo)
        Me.gpb_cadastro.Controls.Add(Me.txb_pcusto)
        Me.gpb_cadastro.Controls.Add(Me.lbl_pvenda)
        Me.gpb_cadastro.Controls.Add(Me.txb_pvenda)
        Me.gpb_cadastro.Controls.Add(Me.lbl_pcusto)
        Me.gpb_cadastro.Controls.Add(Me.txb_quantidade)
        Me.gpb_cadastro.Controls.Add(Me.lbl_quantidade)
        Me.gpb_cadastro.Controls.Add(Me.txb_uniMedida)
        Me.gpb_cadastro.Controls.Add(Me.lbl_uniMedida)
        Me.gpb_cadastro.Controls.Add(Me.cmb_tipo)
        Me.gpb_cadastro.Controls.Add(Me.lbl_tipo)
        Me.gpb_cadastro.Controls.Add(Me.txb_descricao)
        Me.gpb_cadastro.Controls.Add(Me.lbl_descricao)
        Me.gpb_cadastro.Location = New System.Drawing.Point(12, 71)
        Me.gpb_cadastro.Name = "gpb_cadastro"
        Me.gpb_cadastro.Size = New System.Drawing.Size(509, 191)
        Me.gpb_cadastro.TabIndex = 1
        Me.gpb_cadastro.TabStop = False
        Me.gpb_cadastro.Text = "Cadastro Produtos"
        '
        'bnt_novoTipo
        '
        Me.bnt_novoTipo.Location = New System.Drawing.Point(172, 97)
        Me.bnt_novoTipo.Name = "bnt_novoTipo"
        Me.bnt_novoTipo.Size = New System.Drawing.Size(75, 23)
        Me.bnt_novoTipo.TabIndex = 14
        Me.bnt_novoTipo.Text = "Novo Tipo"
        Me.bnt_novoTipo.UseVisualStyleBackColor = True
        '
        'chb_ativo
        '
        Me.chb_ativo.AutoSize = True
        Me.chb_ativo.Checked = True
        Me.chb_ativo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chb_ativo.Location = New System.Drawing.Point(392, 100)
        Me.chb_ativo.Name = "chb_ativo"
        Me.chb_ativo.Size = New System.Drawing.Size(50, 17)
        Me.chb_ativo.TabIndex = 13
        Me.chb_ativo.Text = "Ativo"
        Me.chb_ativo.UseVisualStyleBackColor = True
        '
        'txb_pcusto
        '
        Me.txb_pcusto.Location = New System.Drawing.Point(394, 62)
        Me.txb_pcusto.Name = "txb_pcusto"
        Me.txb_pcusto.Size = New System.Drawing.Size(99, 20)
        Me.txb_pcusto.TabIndex = 11
        Me.txb_pcusto.Text = "0"
        '
        'lbl_pvenda
        '
        Me.lbl_pvenda.AutoSize = True
        Me.lbl_pvenda.Location = New System.Drawing.Point(307, 65)
        Me.lbl_pvenda.Name = "lbl_pvenda"
        Me.lbl_pvenda.Size = New System.Drawing.Size(79, 13)
        Me.lbl_pvenda.TabIndex = 10
        Me.lbl_pvenda.Text = "Preço de custo"
        '
        'txb_pvenda
        '
        Me.txb_pvenda.Location = New System.Drawing.Point(394, 27)
        Me.txb_pvenda.Name = "txb_pvenda"
        Me.txb_pvenda.Size = New System.Drawing.Size(99, 20)
        Me.txb_pvenda.TabIndex = 9
        Me.txb_pvenda.Text = "0"
        '
        'lbl_pcusto
        '
        Me.lbl_pcusto.AutoSize = True
        Me.lbl_pcusto.Location = New System.Drawing.Point(307, 30)
        Me.lbl_pcusto.Name = "lbl_pcusto"
        Me.lbl_pcusto.Size = New System.Drawing.Size(83, 13)
        Me.lbl_pcusto.TabIndex = 8
        Me.lbl_pcusto.Text = "Preço de venda"
        '
        'txb_quantidade
        '
        Me.txb_quantidade.Location = New System.Drawing.Point(67, 146)
        Me.txb_quantidade.Name = "txb_quantidade"
        Me.txb_quantidade.Size = New System.Drawing.Size(190, 20)
        Me.txb_quantidade.TabIndex = 7
        Me.txb_quantidade.Text = "0"
        '
        'lbl_quantidade
        '
        Me.lbl_quantidade.AutoSize = True
        Me.lbl_quantidade.Location = New System.Drawing.Point(6, 149)
        Me.lbl_quantidade.Name = "lbl_quantidade"
        Me.lbl_quantidade.Size = New System.Drawing.Size(62, 13)
        Me.lbl_quantidade.TabIndex = 6
        Me.lbl_quantidade.Text = "Quantidade"
        '
        'txb_uniMedida
        '
        Me.txb_uniMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txb_uniMedida.Location = New System.Drawing.Point(67, 110)
        Me.txb_uniMedida.MaxLength = 4
        Me.txb_uniMedida.Name = "txb_uniMedida"
        Me.txb_uniMedida.Size = New System.Drawing.Size(61, 20)
        Me.txb_uniMedida.TabIndex = 5
        '
        'lbl_uniMedida
        '
        Me.lbl_uniMedida.AutoSize = True
        Me.lbl_uniMedida.Location = New System.Drawing.Point(6, 113)
        Me.lbl_uniMedida.Name = "lbl_uniMedida"
        Me.lbl_uniMedida.Size = New System.Drawing.Size(64, 13)
        Me.lbl_uniMedida.TabIndex = 4
        Me.lbl_uniMedida.Text = "Uni. Medida"
        '
        'cmb_tipo
        '
        Me.cmb_tipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_tipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_tipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(67, 69)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(190, 21)
        Me.cmb_tipo.TabIndex = 3
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(6, 69)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(28, 13)
        Me.lbl_tipo.TabIndex = 2
        Me.lbl_tipo.Text = "Tipo"
        '
        'txb_descricao
        '
        Me.txb_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txb_descricao.Location = New System.Drawing.Point(67, 24)
        Me.txb_descricao.Name = "txb_descricao"
        Me.txb_descricao.Size = New System.Drawing.Size(190, 20)
        Me.txb_descricao.TabIndex = 1
        '
        'lbl_descricao
        '
        Me.lbl_descricao.AutoSize = True
        Me.lbl_descricao.Location = New System.Drawing.Point(6, 27)
        Me.lbl_descricao.Name = "lbl_descricao"
        Me.lbl_descricao.Size = New System.Drawing.Size(55, 13)
        Me.lbl_descricao.TabIndex = 0
        Me.lbl_descricao.Text = "Descriçao"
        '
        'bnt_cadastro
        '
        Me.bnt_cadastro.Location = New System.Drawing.Point(712, 279)
        Me.bnt_cadastro.Name = "bnt_cadastro"
        Me.bnt_cadastro.Size = New System.Drawing.Size(75, 23)
        Me.bnt_cadastro.TabIndex = 2
        Me.bnt_cadastro.Text = "Cadastrar"
        Me.bnt_cadastro.UseVisualStyleBackColor = True
        '
        'gpb_novoTipo
        '
        Me.gpb_novoTipo.Controls.Add(Me.bnt_cancelaTipo)
        Me.gpb_novoTipo.Controls.Add(Me.bnt_salvaTipo)
        Me.gpb_novoTipo.Controls.Add(Me.txb_nomeTipo)
        Me.gpb_novoTipo.Controls.Add(Me.lbl_nomeTipo)
        Me.gpb_novoTipo.Location = New System.Drawing.Point(536, 71)
        Me.gpb_novoTipo.Name = "gpb_novoTipo"
        Me.gpb_novoTipo.Size = New System.Drawing.Size(252, 191)
        Me.gpb_novoTipo.TabIndex = 3
        Me.gpb_novoTipo.TabStop = False
        Me.gpb_novoTipo.Text = "Novo tipo"
        '
        'bnt_cancelaTipo
        '
        Me.bnt_cancelaTipo.Location = New System.Drawing.Point(32, 162)
        Me.bnt_cancelaTipo.Name = "bnt_cancelaTipo"
        Me.bnt_cancelaTipo.Size = New System.Drawing.Size(90, 23)
        Me.bnt_cancelaTipo.TabIndex = 5
        Me.bnt_cancelaTipo.Text = "Cancela"
        Me.bnt_cancelaTipo.UseVisualStyleBackColor = True
        '
        'bnt_salvaTipo
        '
        Me.bnt_salvaTipo.Location = New System.Drawing.Point(141, 162)
        Me.bnt_salvaTipo.Name = "bnt_salvaTipo"
        Me.bnt_salvaTipo.Size = New System.Drawing.Size(90, 23)
        Me.bnt_salvaTipo.TabIndex = 4
        Me.bnt_salvaTipo.Text = "Salva Tipo"
        Me.bnt_salvaTipo.UseVisualStyleBackColor = True
        '
        'txb_nomeTipo
        '
        Me.txb_nomeTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txb_nomeTipo.Location = New System.Drawing.Point(68, 28)
        Me.txb_nomeTipo.Name = "txb_nomeTipo"
        Me.txb_nomeTipo.Size = New System.Drawing.Size(136, 20)
        Me.txb_nomeTipo.TabIndex = 3
        '
        'lbl_nomeTipo
        '
        Me.lbl_nomeTipo.AutoSize = True
        Me.lbl_nomeTipo.Location = New System.Drawing.Point(7, 31)
        Me.lbl_nomeTipo.Name = "lbl_nomeTipo"
        Me.lbl_nomeTipo.Size = New System.Drawing.Size(59, 13)
        Me.lbl_nomeTipo.TabIndex = 2
        Me.lbl_nomeTipo.Text = "Nome Tipo"
        '
        'lbl_tituloTela
        '
        Me.lbl_tituloTela.AutoSize = True
        Me.lbl_tituloTela.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tituloTela.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_tituloTela.Location = New System.Drawing.Point(16, 32)
        Me.lbl_tituloTela.Name = "lbl_tituloTela"
        Me.lbl_tituloTela.Size = New System.Drawing.Size(272, 36)
        Me.lbl_tituloTela.TabIndex = 4
        Me.lbl_tituloTela.Text = "Cadastro de Produtos"
        '
        'bnt_limpa
        '
        Me.bnt_limpa.Location = New System.Drawing.Point(362, 279)
        Me.bnt_limpa.Name = "bnt_limpa"
        Me.bnt_limpa.Size = New System.Drawing.Size(75, 23)
        Me.bnt_limpa.TabIndex = 5
        Me.bnt_limpa.Text = "Limpar"
        Me.bnt_limpa.UseVisualStyleBackColor = True
        '
        'bnt_cancela
        '
        Me.bnt_cancela.Location = New System.Drawing.Point(12, 279)
        Me.bnt_cancela.Name = "bnt_cancela"
        Me.bnt_cancela.Size = New System.Drawing.Size(75, 23)
        Me.bnt_cancela.TabIndex = 6
        Me.bnt_cancela.Text = "Cancelar"
        Me.bnt_cancela.UseVisualStyleBackColor = True
        '
        'CadastroProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 308)
        Me.Controls.Add(Me.bnt_cancela)
        Me.Controls.Add(Me.bnt_limpa)
        Me.Controls.Add(Me.lbl_tituloTela)
        Me.Controls.Add(Me.gpb_novoTipo)
        Me.Controls.Add(Me.bnt_cadastro)
        Me.Controls.Add(Me.gpb_cadastro)
        Me.Controls.Add(Me.Menu_sup)
        Me.MainMenuStrip = Me.Menu_sup
        Me.Name = "CadastroProduto"
        Me.Text = "CadastroProduto"
        Me.Menu_sup.ResumeLayout(False)
        Me.Menu_sup.PerformLayout()
        Me.gpb_cadastro.ResumeLayout(False)
        Me.gpb_cadastro.PerformLayout()
        Me.gpb_novoTipo.ResumeLayout(False)
        Me.gpb_novoTipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Menu_sup As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents gpb_cadastro As GroupBox
    Friend WithEvents lbl_descricao As Label
    Friend WithEvents chb_ativo As CheckBox
    Friend WithEvents txb_pcusto As TextBox
    Friend WithEvents lbl_pvenda As Label
    Friend WithEvents txb_pvenda As TextBox
    Friend WithEvents lbl_pcusto As Label
    Friend WithEvents txb_quantidade As TextBox
    Friend WithEvents lbl_quantidade As Label
    Friend WithEvents txb_uniMedida As TextBox
    Friend WithEvents lbl_uniMedida As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents txb_descricao As TextBox
    Friend WithEvents bnt_cadastro As Button
    Friend WithEvents gpb_novoTipo As GroupBox
    Friend WithEvents bnt_salvaTipo As Button
    Friend WithEvents txb_nomeTipo As TextBox
    Friend WithEvents lbl_nomeTipo As Label
    Friend WithEvents lbl_tituloTela As Label
    Friend WithEvents bnt_novoTipo As Button
    Friend WithEvents bnt_cancelaTipo As Button
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents bnt_limpa As Button
    Friend WithEvents bnt_cancela As Button
End Class
