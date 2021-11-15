Imports System.Data.SqlClient
Public Class FormEscogerUsuario2

    Private Sub FormEscogerUsuario2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Dim query As String = "Select dC.id_cliente, dC.nombre, dC.apellido, c.id_cuenta, c.tipo, c.saldo 
                               From tbl_datoscliente dC right join tbl_cuenta c On dC.id_cliente = c.id_cliente
                               Order By dC.id_cliente, tipo"
        da = New SqlDataAdapter(query, mYConn)
        da.Fill(dt)
        If dt.Rows.Count Then
            dtgListaUsuarios2.DataSource = dt
        End If
        If mYConn.State <> ConnectionState.Closed Then mYConn.Close()
    End Sub

    Private Sub dtgListaUsuarios2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgListaUsuarios2.CellContentClick
        Dim pregunta As String
        Dim nombreEmpleado As String
        nombreEmpleado = dtgListaUsuarios2.Item(1, e.RowIndex).Value.ToString & " " & dtgListaUsuarios2.Item(2, e.RowIndex).Value.ToString
        Dim nombreCuenta As String = "Cuenta Corriente"
        Dim cuenta As String = dtgListaUsuarios2.Item(4, e.RowIndex).Value.ToString
        If (cuenta = "1") Then
            nombreCuenta = "Cuenta De Ahorros"
        End If
        pregunta = MsgBox("¿Desea depositar/retirar dinero del usuario " & nombreEmpleado & " en la cuenta " & cuenta & "?", vbYesNo)
        If pregunta = vbYes Then
            FormDepoReti.MdiParent = FormMDI
            FormDepoReti.WindowState = FormWindowState.Maximized
            FormDepoReti.txtNombreCompleto.Text = dtgListaUsuarios2.Item(1, e.RowIndex).Value.ToString & " " & dtgListaUsuarios2.Item(2, e.RowIndex).Value.ToString
            FormDepoReti.txtNombreCuenta.Text = nombreCuenta
            FormDepoReti.txtNumCuenta.Text = dtgListaUsuarios2.Item(3, e.RowIndex).Value.ToString
            FormDepoReti.txtSaldo.Text = dtgListaUsuarios2.Item(5, e.RowIndex).Value.ToString
            accion = dtgListaUsuarios2.Item(0, e.RowIndex).Value.ToString
            FormDepoReti.Show()

        End If
    End Sub
End Class