Imports CamadaBLL
Imports CamadaDTO
Public Class VisualizadorRelatorio
    Private Sub PrintPreviewControl1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VisualizadorRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t1 As Produto
        Dim t2 As New ProdutoBLL



        Me.ReportViewer1.RefreshReport()
    End Sub
End Class