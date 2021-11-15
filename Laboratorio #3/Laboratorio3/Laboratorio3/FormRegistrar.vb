Imports System.Data.SqlClient
Imports System.Net
Public Class FormRegistrar
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim query As String
        Dim comando As SqlCommand
        query = "Insert into tbl_datoscliente ( nombre, apellido, telefono_movil, direccion, fecha_creacion)Values ("
        query &= "'" & txtNombre1.Text & "'"
        query &= ",'" & txtApellido1.Text & "'"
        query &= ",'" & txtTelefono1.Text & "'"
        query &= ",'" & rtxtDireccion1.Text & "'"
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



    Private Sub txtTelefono1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class