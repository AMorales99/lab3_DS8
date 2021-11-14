Imports System.Data.SqlClient
Imports System.Net
Public Class FormRegistrar
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim query As String
        Dim comando As SqlCommand
        query = "Insert into tbl_datoscliente (id_cliente, nombre, apellido, telefono_movil, direccion, fecha_creacion)Values ("
        query &= "" & 4 & ""
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

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress


        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
End Class