Public Class FormMDI

    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        FormRegistrar.MdiParent = Me
        FormRegistrar.WindowState = FormWindowState.Maximized
        FormRegistrar.Show()
    End Sub

    Private Sub CrearCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearCuentaToolStripMenuItem.Click
        FormEscogerUsuario.MdiParent = Me
        FormEscogerUsuario.WindowState = FormWindowState.Maximized
        accion = "C"

        FormEscogerUsuario.Show()
    End Sub

    Private Sub DepósitoRetiroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepósitoRetiroToolStripMenuItem.Click
        FormEscogerUsuario2.MdiParent = Me
        FormEscogerUsuario2.WindowState = FormWindowState.Maximized
        accion = "D"

        FormEscogerUsuario2.Show()
    End Sub

    Private Sub MovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosToolStripMenuItem.Click
        FormEscogerUsuario.MdiParent = Me
        FormEscogerUsuario.WindowState = FormWindowState.Maximized
        accion = "M"

        FormEscogerUsuario.Show()

    End Sub

    Private Sub PresentaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresentaciónToolStripMenuItem.Click
        Presentacion.MdiParent = Me
        Presentacion.WindowState = FormWindowState.Maximized
        Presentacion.Show()
    End Sub

    Private Sub FormMDI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If mYConn.State <> ConnectionState.Closed Then mYConn.Close()
        Form1.Close()
    End Sub
End Class
