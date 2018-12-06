<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaProdutos
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
        Me.lbl_tituloTela = New System.Windows.Forms.Label()
        Me.Menu_sup = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv_produtos = New System.Windows.Forms.DataGridView()
        Me.bnt_novo = New System.Windows.Forms.Button()
        Me.bnt_fecha = New System.Windows.Forms.Button()
        Me.gpb_pesquisa = New System.Windows.Forms.GroupBox()
        Me.lbl_nome = New System.Windows.Forms.Label()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.lbl_ativo = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txb_id = New System.Windows.Forms.TextBox()
        Me.txb_nome = New System.Windows.Forms.TextBox()
        Me.cmb_ativo = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.bnt_pesquisa = New System.Windows.Forms.Button()
        Me.Menu_sup.SuspendLayout()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpb_pesquisa.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_tituloTela
        '
        Me.lbl_tituloTela.AutoSize = True
        Me.lbl_tituloTela.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tituloTela.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_tituloTela.Location = New System.Drawing.Point(12, 34)
        Me.lbl_tituloTela.Name = "lbl_tituloTela"
        Me.lbl_tituloTela.Size = New System.Drawing.Size(220, 36)
        Me.lbl_tituloTela.TabIndex = 6
        Me.lbl_tituloTela.Text = "Lista de produtos"
        '
        'Menu_sup
        '
        Me.Menu_sup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.Menu_sup.Location = New System.Drawing.Point(0, 0)
        Me.Menu_sup.Name = "Menu_sup"
        Me.Menu_sup.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Menu_sup.Size = New System.Drawing.Size(800, 24)
        Me.Menu_sup.TabIndex = 5
        Me.Menu_sup.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(128, 20)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'dgv_produtos
        '
        Me.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_produtos.Location = New System.Drawing.Point(12, 203)
        Me.dgv_produtos.Name = "dgv_produtos"
        Me.dgv_produtos.Size = New System.Drawing.Size(770, 211)
        Me.dgv_produtos.TabIndex = 7
        '
        'bnt_novo
        '
        Me.bnt_novo.Location = New System.Drawing.Point(713, 419)
        Me.bnt_novo.Name = "bnt_novo"
        Me.bnt_novo.Size = New System.Drawing.Size(75, 23)
        Me.bnt_novo.TabIndex = 9
        Me.bnt_novo.Text = "Novo"
        Me.bnt_novo.UseVisualStyleBackColor = True
        '
        'bnt_fecha
        '
        Me.bnt_fecha.Location = New System.Drawing.Point(577, 419)
        Me.bnt_fecha.Name = "bnt_fecha"
        Me.bnt_fecha.Size = New System.Drawing.Size(75, 23)
        Me.bnt_fecha.TabIndex = 10
        Me.bnt_fecha.Text = "Fechar"
        Me.bnt_fecha.UseVisualStyleBackColor = True
        '
        'gpb_pesquisa
        '
        Me.gpb_pesquisa.Controls.Add(Me.bnt_pesquisa)
        Me.gpb_pesquisa.Controls.Add(Me.cmb_tipo)
        Me.gpb_pesquisa.Controls.Add(Me.cmb_ativo)
        Me.gpb_pesquisa.Controls.Add(Me.txb_nome)
        Me.gpb_pesquisa.Controls.Add(Me.txb_id)
        Me.gpb_pesquisa.Controls.Add(Me.lbl_id)
        Me.gpb_pesquisa.Controls.Add(Me.lbl_ativo)
        Me.gpb_pesquisa.Controls.Add(Me.lbl_tipo)
        Me.gpb_pesquisa.Controls.Add(Me.lbl_nome)
        Me.gpb_pesquisa.Location = New System.Drawing.Point(12, 92)
        Me.gpb_pesquisa.Name = "gpb_pesquisa"
        Me.gpb_pesquisa.Size = New System.Drawing.Size(770, 105)
        Me.gpb_pesquisa.TabIndex = 12
        Me.gpb_pesquisa.TabStop = False
        Me.gpb_pesquisa.Text = "Pesquisa"
        '
        'lbl_nome
        '
        Me.lbl_nome.AutoSize = True
        Me.lbl_nome.Location = New System.Drawing.Point(6, 75)
        Me.lbl_nome.Name = "lbl_nome"
        Me.lbl_nome.Size = New System.Drawing.Size(35, 13)
        Me.lbl_nome.TabIndex = 0
        Me.lbl_nome.Text = "Nome"
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.Location = New System.Drawing.Point(233, 75)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(28, 13)
        Me.lbl_tipo.TabIndex = 1
        Me.lbl_tipo.Text = "Tipo"
        '
        'lbl_ativo
        '
        Me.lbl_ativo.AutoSize = True
        Me.lbl_ativo.Location = New System.Drawing.Point(230, 29)
        Me.lbl_ativo.Name = "lbl_ativo"
        Me.lbl_ativo.Size = New System.Drawing.Size(31, 13)
        Me.lbl_ativo.TabIndex = 2
        Me.lbl_ativo.Text = "Ativo"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(25, 29)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(16, 13)
        Me.lbl_id.TabIndex = 3
        Me.lbl_id.Text = "Id"
        '
        'txb_id
        '
        Me.txb_id.Location = New System.Drawing.Point(47, 29)
        Me.txb_id.Name = "txb_id"
        Me.txb_id.Size = New System.Drawing.Size(70, 20)
        Me.txb_id.TabIndex = 4
        '
        'txb_nome
        '
        Me.txb_nome.Location = New System.Drawing.Point(47, 68)
        Me.txb_nome.Name = "txb_nome"
        Me.txb_nome.Size = New System.Drawing.Size(158, 20)
        Me.txb_nome.TabIndex = 5
        '
        'cmb_ativo
        '
        Me.cmb_ativo.FormattingEnabled = True
        Me.cmb_ativo.Location = New System.Drawing.Point(267, 26)
        Me.cmb_ativo.Name = "cmb_ativo"
        Me.cmb_ativo.Size = New System.Drawing.Size(117, 21)
        Me.cmb_ativo.TabIndex = 6
        '
        'cmb_tipo
        '
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(267, 72)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(117, 21)
        Me.cmb_tipo.TabIndex = 7
        '
        'bnt_pesquisa
        '
        Me.bnt_pesquisa.Location = New System.Drawing.Point(466, 66)
        Me.bnt_pesquisa.Name = "bnt_pesquisa"
        Me.bnt_pesquisa.Size = New System.Drawing.Size(75, 23)
        Me.bnt_pesquisa.TabIndex = 8
        Me.bnt_pesquisa.Text = "Pesquisa"
        Me.bnt_pesquisa.UseVisualStyleBackColor = True
        '
        'ListaProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gpb_pesquisa)
        Me.Controls.Add(Me.bnt_fecha)
        Me.Controls.Add(Me.bnt_novo)
        Me.Controls.Add(Me.dgv_produtos)
        Me.Controls.Add(Me.lbl_tituloTela)
        Me.Controls.Add(Me.Menu_sup)
        Me.Name = "ListaProdutos"
        Me.Text = "ListaProdutos"
        Me.Menu_sup.ResumeLayout(False)
        Me.Menu_sup.PerformLayout()
        CType(Me.dgv_produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpb_pesquisa.ResumeLayout(False)
        Me.gpb_pesquisa.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_tituloTela As Label
    Friend WithEvents Menu_sup As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents dgv_produtos As DataGridView
    Friend WithEvents bnt_novo As Button
    Friend WithEvents bnt_fecha As Button
    Friend WithEvents gpb_pesquisa As GroupBox
    Friend WithEvents bnt_pesquisa As Button
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents cmb_ativo As ComboBox
    Friend WithEvents txb_nome As TextBox
    Friend WithEvents txb_id As TextBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_ativo As Label
    Friend WithEvents lbl_tipo As Label
    Friend WithEvents lbl_nome As Label
End Class
