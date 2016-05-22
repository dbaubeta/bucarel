Public Class ReporteStock
    Dim ctrl As New Negocio.Controller

    Private Sub ReporteStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim l As List(Of Entidades.reportestock)
        l = ctrl.obtenerReporteStock
        Me.reportestockBindingSource.DataSource = l
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReporteStock_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Me.ReportViewer1.Width = Me.Width - ReportViewer1.Left * 2
        Me.ReportViewer1.Height = Me.Height - ReportViewer1.Top

    End Sub
End Class