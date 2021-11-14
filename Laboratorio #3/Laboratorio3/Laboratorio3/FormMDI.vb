Public Class FormMDI

    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        FormRegistrar.MdiParent = Me
        FormRegistrar.WindowState = FormWindowState.Maximized
        FormRegistrar.Show()
    End Sub

    Private Sub CrearCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearCuentaToolStripMenuItem.Click
        FormEscogerUsuario.MdiParent = Me
        FormEscogerUsuario.WindowState = FormWindowState.Maximized
        FormEscogerUsuario.Show()

        accion = "C"
    End Sub

    Private Sub DepósitoRetiroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepósitoRetiroToolStripMenuItem.Click
        FormDepoReti.MdiParent = Me
        FormDepoReti.WindowState = FormWindowState.Maximized
        FormDepoReti.Show()
        FormDepoReti.GroupBox1.Left = FormDepoReti.Width / 2 - (FormDepoReti.GroupBox1.Width / 2)
        FormDepoReti.GroupBox2.Left = FormDepoReti.Width / 2 - (FormDepoReti.GroupBox2.Width / 2)
        FormDepoReti.GroupBox3.Left = FormDepoReti.Width / 2 - (FormDepoReti.GroupBox3.Width / 2)
    End Sub

    Private Sub MovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosToolStripMenuItem.Click
        FormEscogerUsuario.MdiParent = Me
        FormEscogerUsuario.WindowState = FormWindowState.Maximized
        FormEscogerUsuario.Show()

        accion = "M"
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
