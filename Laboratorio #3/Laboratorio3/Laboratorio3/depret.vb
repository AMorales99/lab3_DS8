Public Class depret

    Private depositos As Decimal


    Public Sub asignar(ByRef depositado As Decimal)

        depositos = depositado

    End Sub


    Public Function SaldoActual() As Decimal


        SaldoActual += depositos


    End Function
End Class
