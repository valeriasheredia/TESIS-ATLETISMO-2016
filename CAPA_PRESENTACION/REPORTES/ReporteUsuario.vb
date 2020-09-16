Imports CrystalDecisions.Shared

Public Class ReporteUsuario

    Private Sub ReporteUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim objreporte As New ReporteUsuario

        CrystalReportViewer1.ReportSource = objreporte

    End Sub
End Class

