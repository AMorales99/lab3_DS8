Imports System.Data.SqlClient
Imports System.Net
Public Class FormDepoReti


    Dim dr As New depret
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click


    End Sub


    Private Sub rbDeposito_Click(sender As Object, e As EventArgs) Handles rbDeposito.Click

        Dim nombre As String
        Dim cuenta As Integer
        Dim saldo As Decimal
        Dim numCuenta As Integer
        Dim query As String
        Dim comando As SqlCommand
        nombre = txtNombreCompleto.Text
        saldo = Val(txtSaldo.Text)
        numCuenta = Val(txtNumCuenta.Text)



        Dim depositar As Decimal
Start:
        depositar = InputBox("Ingrese el monto a Depositar ", "Deposito")

        If IsNumeric(depositar) Then


            query = "insert into tbl_movimientos (id_cuenta, deposito, retiro, fecha) values("
            query &= "'" & numCuenta & "'"
            query &= ",'" & depositar & "'"
            query &= ", 0"
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






        Else
            MsgBox("debe ingresar un monto valido")
            GoTo Start

        End If

    End Sub

    Private Sub rbRetiro_Click(sender As Object, e As EventArgs) Handles rbRetiro.Click
        Dim nombre As String
        Dim cuenta As Integer
        Dim saldo As Decimal
        Dim numCuenta As Integer
        Dim query As String
        Dim comando As SqlCommand
        nombre = txtNombreCompleto.Text
        saldo = Val(txtSaldo.Text)
        numCuenta = Val(txtNumCuenta.Text)




        Dim depositar As Decimal


        Try





            If saldo = 0.00 Then
                MsgBox("No cuenta con saldo en su cuenta, Proceda a depositar")

            Else
                depositar = InputBox("Ingrese el monto a Retirar ", "Retirar")

                If saldo < depositar Then


                    MsgBox("Saldo Insuficiente")

                Else
                    query = "insert into tbl_movimientos (id_cuenta, deposito, retiro, fecha) values("
                    query &= "'" & numCuenta & "'"
                    query &= ", 0"
                    query &= ",'" & depositar & "'"
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





                End If

            End If





        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
End Class