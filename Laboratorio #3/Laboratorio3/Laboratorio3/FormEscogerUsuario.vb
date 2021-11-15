Imports System.Data.SqlClient

Public Class FormEscogerUsuario
    Private Sub FormEscogerUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgListaUsuarios.Left = Me.Width / 2 - (dtgListaUsuarios.Width / 2)
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Dim query As String
        If accion = "D" Then
            query = "Select dC.id_cliente As 'ID Usuario', dC.nombre As Nombre, dC.apellido As Apellido, c.id_cuenta As 'ID Cuenta', c.tipo As Tipo, c.saldo As Saldo 
                     From tbl_datoscliente dC right join tbl_cuenta c On dC.id_cliente = c.id_cliente
                     Order By dC.id_cliente, tipo"
        Else
            query = "Select id_cliente As 'ID Usuario', nombre As Nombre, apellido As Apellido From tbl_datoscliente"
        End If

        da = New SqlDataAdapter(query, mYConn)
        da.Fill(dt)
        If dt.Rows.Count Then
            dtgListaUsuarios.DataSource = dt
        End If
        If mYConn.State <> ConnectionState.Closed Then mYConn.Close()
    End Sub

    Private Sub dtgListaUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgListaUsuarios.CellClick
        Dim pregunta As String
        Dim nombreEmpleado As String
        nombreEmpleado = dtgListaUsuarios.Item(1, e.RowIndex).Value.ToString & " " & dtgListaUsuarios.Item(2, e.RowIndex).Value.ToString
        If accion = "C" Then
            pregunta = MsgBox("¿Desea crearle una cuenta al usuario " & nombreEmpleado & "?", vbYesNo)
            If pregunta = vbYes Then
                FormCrearCuenta.MdiParent = FormMDI
                FormCrearCuenta.WindowState = FormWindowState.Maximized
                FormCrearCuenta.txtNombreCompleto.Text = dtgListaUsuarios.Item(1, e.RowIndex).Value.ToString & " " & dtgListaUsuarios.Item(2, e.RowIndex).Value.ToString
                accion = dtgListaUsuarios.Item(0, e.RowIndex).Value.ToString
                FormCrearCuenta.Show()

            End If
        ElseIf accion = "D" Then
            nombreEmpleado = dtgListaUsuarios.Item(1, e.RowIndex).Value.ToString & " " & dtgListaUsuarios.Item(2, e.RowIndex).Value.ToString
            Dim nombreCuenta As String = "Cuenta Corriente"
            Dim cuenta As String = dtgListaUsuarios.Item(4, e.RowIndex).Value.ToString
            Dim numeroCuenta As String = dtgListaUsuarios.Item(3, e.RowIndex).Value.ToString
            If (cuenta = "1") Then
                nombreCuenta = "Cuenta De Ahorros"
            End If
            pregunta = MsgBox("¿Desea depositar/retirar dinero del usuario " & nombreEmpleado & " en la cuenta " & nombreCuenta & " con ID " & numeroCuenta & "?", vbYesNo)
            If pregunta = vbYes Then
                FormDepoReti.MdiParent = FormMDI
                FormDepoReti.WindowState = FormWindowState.Maximized
                FormDepoReti.txtNombreCompleto.Text = dtgListaUsuarios.Item(1, e.RowIndex).Value.ToString & " " & dtgListaUsuarios.Item(2, e.RowIndex).Value.ToString
                FormDepoReti.txtNombreCuenta.Text = nombreCuenta
                FormDepoReti.txtNumCuenta.Text = dtgListaUsuarios.Item(3, e.RowIndex).Value.ToString
                FormDepoReti.txtSaldo.Text = dtgListaUsuarios.Item(5, e.RowIndex).Value.ToString
                accion = dtgListaUsuarios.Item(0, e.RowIndex).Value.ToString
                FormDepoReti.Show()

            End If
        Else
            pregunta = MsgBox("¿Desea ver los movimientos del usuario " & nombreEmpleado & "?", vbYesNo)
            If pregunta = vbYes Then
                FormMovimientos.MdiParent = FormMDI
                FormMovimientos.WindowState = FormWindowState.Maximized
                FormMovimientos.txtNombreCompleto.Text = dtgListaUsuarios.Item(1, e.RowIndex).Value.ToString & " " & dtgListaUsuarios.Item(2, e.RowIndex).Value.ToString
                idUsuario = dtgListaUsuarios.Item(0, e.RowIndex).Value.ToString
                accion = "M"
                FormMovimientos.Show()

            End If
        End If

    End Sub
End Class