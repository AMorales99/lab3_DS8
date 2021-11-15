
Imports System.Data.SqlClient
Imports System.Net
Public Class FormCrearCuenta
    Private Sub FormCrearCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboTipoCuenta.Items.Add("Cuenta De Ahorros")
        cboTipoCuenta.Items.Add("Cuenta Corriente")
        cboTipoCuenta.SelectedIndex = 0
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        txtSaldo.Text = 0.00
    End Sub
    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Dim query As String
        Dim comando As SqlCommand
        Dim cboTipo = 0
        If cboTipoCuenta.Text = "Cuenta De Ahorros" Then
            cboTipo = 1
        End If


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