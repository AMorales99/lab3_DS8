Imports System.Data.SqlClient
Imports System.Net
Public Class FormRegistrar
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim query As String
        Dim comando As SqlCommand
        query = "Insert into tbl_datoscliente (id_cliente, nombre, apellido, telefono_movil, direccion, fecha_creacion)Values ("
        query &= "" & 3 & ""
        query &= ",'" & txtNombre.Text & "'"
        query &= ",'" & txtApellido.Text & "'"
        query &= ",'" & txtTelefono.Text & "'"
        query &= ",'" & rtxtDireccion.Text & "'"
        query &= ", GETDATE()" & ")"
        Try

            comando = New SqlCommand(query, mYConn)
            mYConn.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Los Datos se insertaron. ")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If mYConn.State <> ConnectionState.Closed Then mYConn.Close()
        End Try

    End Sub
End Class