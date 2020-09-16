Imports System.Windows.Forms

Public Class VentanaPrincipaldelSistema

    Private Sub NuevoUsuarioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoUsuarioToolStripMenuItem.Click
        NUEVOUSUARIO.MdiParent = Me
        NUEVOUSUARIO.Show()
    End Sub

    Private Sub ListaDeUsuariosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeUsuariosToolStripMenuItem.Click
        LISTAUSUARIOS.MdiParent = Me
        LISTAUSUARIOS.Show()
    End Sub

    Private Sub NuevoAtletaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoAtletaToolStripMenuItem.Click
        NUEVOATLETA.MdiParent = Me
        NUEVOATLETA.Show()
    End Sub

    Private Sub ListaDeAtletasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeAtletasToolStripMenuItem.Click
        LISTA_DE_ATLETAS.MdiParent = Me
        LISTA_DE_ATLETAS.Show()
    End Sub

    Private Sub CalleToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'NUEVACOMPETENCIACALLE.MdiParent = Me
        'NUEVACOMPETENCIACALLE.Show()
    End Sub

    Private Sub ListaDeCompetenciasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeCompetenciasToolStripMenuItem.Click
        LISTACOMPETENCIAS.MdiParent = Me
        LISTACOMPETENCIAS.Show()
    End Sub

    Private Sub NuevoJuezToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoJuezToolStripMenuItem.Click
        NUEVOJUEZ.MdiParent = Me
        NUEVOJUEZ.Show()
    End Sub

    Private Sub ListaDeJuecesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeJuecesToolStripMenuItem.Click
        LISTAJUECES.MdiParent = Me
        LISTAJUECES.Show()
    End Sub

    Private Sub NuevoClubFederaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoClubFederaciónToolStripMenuItem.Click
        NUEVOCLUBFEDERACION.MdiParent = Me
        NUEVOCLUBFEDERACION.Show()
    End Sub

    Private Sub ListaDeClubesFederacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaDeClubesFederacionesToolStripMenuItem.Click
        LISTADOCLUBFEDERACION.MdiParent = Me
        LISTADOCLUBFEDERACION.Show()
    End Sub

    Private Sub NuevaCompetenciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaCompetenciaToolStripMenuItem.Click
        NUEVACOMPETENCIA.MdiParent = Me
        NUEVACOMPETENCIA.Show()
    End Sub

    Private Sub AtletasPorCompetenciaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AtletasPorCompetenciaToolStripMenuItem.Click
        ATLETAS_POR_COMPETENCIA.Show()
    End Sub

    Private Sub MenuStrip_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub
End Class
