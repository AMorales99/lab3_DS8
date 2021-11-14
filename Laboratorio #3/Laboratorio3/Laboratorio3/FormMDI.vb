Public Class FormMDI

    ''Color del texo en el MenuStrip
    Private Sub FormMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.ForeColor = Color.White
    End Sub
    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        MenuStrip1.ForeColor = Color.Black
    End Sub
    Private Sub MenuStrip1_MouseLeave(sender As Object, e As EventArgs) Handles MenuStrip1.MouseLeave
        MenuStrip1.ForeColor = Color.White
    End Sub

    Private Sub RegistrarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarClienteToolStripMenuItem.Click
        FormRegistrar.MdiParent = Me
        FormRegistrar.WindowState = FormWindowState.Maximized
        FormRegistrar.Show()
    End Sub

    Private Sub CrearCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearCuentaToolStripMenuItem.Click
        FormCrearCuenta.MdiParent = Me
        FormCrearCuenta.WindowState = FormWindowState.Maximized
        FormCrearCuenta.Show()
    End Sub

    Private Sub DepósitoRetiroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepósitoRetiroToolStripMenuItem.Click
        FormDepoReti.MdiParent = Me
        FormDepoReti.WindowState = FormWindowState.Maximized
        FormDepoReti.Show()
    End Sub

    Private Sub MovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosToolStripMenuItem.Click
        FormMovimientos.MdiParent = Me
        FormMovimientos.WindowState = FormWindowState.Maximized
        FormMovimientos.Show()
    End Sub
End Class
