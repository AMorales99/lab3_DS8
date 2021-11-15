
Imports System.Data.SqlClient
Imports System.Net
Public Class FormCrearCuenta
    Private Sub FormCrearCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTipoCuenta.Items.Add("Cuenta De Ahorros")
        cboTipoCuenta.Items.Add("Cuenta Corriente")
        cboTipoCuenta.SelectedIndex = 0
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If (cboTipoCuenta.Text = "Cuenta De Ahorros") Then
            txtSaldo.Text = "0.00"
        Else
            txtSaldo.Text = "100.00"
        End If
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        If (cboTipoCuenta.Text = "Cuenta De Ahorros" Or cboTipoCuenta.Text = "Cuenta Corriente") Then
            Dim query As String
            Dim comando As SqlCommand
            Dim cboTipo = 2
            Dim idUsuario = accion
            If cboTipoCuenta.Text = "Cuenta De Ahorros" Then
                cboTipo = 1
            End If
            query = "Insert into tbl_cuenta (id_cliente, tipo, saldo, fecha_creacion, fecha_modificacion) Values ("
            query &= "" & idUsuario & ""
            query &= "," & cboTipo & ""
            query &= "," & txtSaldo.Text & ""
            query &= ", GETDATE()" & ""
            query &= ", GETDATE()" & ")"
            Try

                comando = New SqlCommand(query, mYConn)
                mYConn.Open()
                comando.ExecuteNonQuery()
                MessageBox.Show("Se ha creado la cuenta exitosamente")

            Catch ex As Exception
                MessageBox.Show("No se ha podido crear la cuenta, inténtelo nuevamente..." & idUsuario & " " & cboTipo)
            Finally
                If mYConn.State <> ConnectionState.Closed Then mYConn.Close()
            End Try
        Else
            MessageBox.Show("Escoja uno de los 2 tipos de cuentas que ofrecemos")
        End If
    End Sub

    Private Sub txtSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldo.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cboTipoCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoCuenta.SelectedIndexChanged
        If (cboTipoCuenta.Text = "Cuenta De Ahorros") Then
            txtSaldo.Text = "0.00"
        Else
            txtSaldo.Text = "100.00"
        End If
    End Sub
End Class