Public Class Menu
    Private Sub btnTeclado_Click(sender As Object, e As EventArgs) Handles btnTeclado.Click
        FT = New Teclado
        FT.Show()
    End Sub

    Private Sub btnCelular_Click(sender As Object, e As EventArgs) Handles btnCelular.Click
        FC = New Celular
        FC.Show()
    End Sub
End Class