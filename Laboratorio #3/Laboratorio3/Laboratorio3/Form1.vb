﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conexion()
            mYConn.Open()
            ' MsgBox("conexion realizada con exito", MessageBoxIcon.Information)'
            FormMDI.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("error al realizar la conexion", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If mYConn.State <> ConnectionState.Closed Then mYConn.Close()

        End Try
    End Sub
End Class