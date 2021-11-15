Imports System.Data.SqlClient

Public Class FormEscogerUsuario
    Private Sub FormEscogerUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Dim query As String = "Select id_cliente, nombre, apellido From tbl_datoscliente"
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
        Else
            pregunta = MsgBox("¿Desea ver los movimientos del usuario " & nombreEmpleado & "?", vbYesNo)
            If pregunta = vbYes Then
                FormMovimientos.MdiParent = FormMDI
                FormMovimientos.WindowState = FormWindowState.Maximized
                FormCrearCuenta.txtNombreCompleto.Text = dtgListaUsuarios.Item(1, e.RowIndex).Value.ToString & " " & dtgListaUsuarios.Item(2, e.RowIndex).Value.ToString
                accion = "M"
                FormMovimientos.Show()

            End If
        End If

    End Sub
End Class