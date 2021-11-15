Public Class FormDepoReti


    Dim dr As New depret
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click


    End Sub

    Private Sub rbDeposito_CheckedChanged(sender As Object, e As EventArgs) Handles rbDeposito.CheckedChanged

        Dim nombre As String
        Dim cuenta As Integer
        Dim saldo As Decimal

        nombre = txtNombreCompleto.Text
        'cuenta = Val(txtCuenta.Text)
        saldo = Val(txtSaldo.Text)



        Dim depositar As Decimal
Start:
        depositar = InputBox("Ingrese el monto a Depositar ", "Deposito")

        If IsNumeric(depositar) Then
            'MsgBox(txtCuenta.Text)
            dr.asignar(depositar)


        Else
            MsgBox("debe ingresar un monto valido")
            GoTo Start

        End If


    End Sub

    Private Sub txtNumCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtNumCuenta.TextChanged

    End Sub
End Class