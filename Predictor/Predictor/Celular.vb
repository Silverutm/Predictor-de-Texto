Public Class Celular
    Dim letra As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEscribir.TextChanged

    End Sub

    Private Sub btnDEF_Click(sender As Object, e As EventArgs) Handles btnDEF.Click
        botonpresionando = 3
        buscarenArbol()
        imprimesug()
    End Sub

    Private Sub btnGHI_Click(sender As Object, e As EventArgs) Handles btnGHI.Click
        botonpresionando = 4
        buscarenArbol()
        imprimesug()
    End Sub

    Private Sub btnJKL_Click(sender As Object, e As EventArgs) Handles btnJKL.Click
        botonpresionando = 5
        buscarenArbol()
        imprimesug()
    End Sub

    Private Sub btnMNO_Click(sender As Object, e As EventArgs) Handles btnMNO.Click
        botonpresionando = 6
        buscarenArbol()
        imprimesug()
    End Sub

    Private Sub btnPQRS_Click(sender As Object, e As EventArgs) Handles btnPQRS.Click
        botonpresionando = 7
        buscarenArbol()
        imprimesug()
    End Sub

    Private Sub btnTUV_Click(sender As Object, e As EventArgs) Handles btnTUV.Click
        botonpresionando = 8
        buscarenArbol()
        imprimesug()
    End Sub

    Private Sub btnWXYZ_Click(sender As Object, e As EventArgs) Handles btnWXYZ.Click
        botonpresionando = 9
        buscarenArbol()
        imprimesug()
    End Sub

    Private Sub btnEs_Click(sender As Object, e As EventArgs) Handles btnEs.Click
        botonpresionando = 0
        esespacio()
        txtEscribir.Text &= " "
        'es igual a aceptar sugerencia
    End Sub

    Private Function may(ByVal i As Integer, ByVal j As Integer) As Integer
        If RepeticionesMias(InddelMaxHijosyYo(i)) >= RepeticionesMias(InddelMaxHijosyYo(j)) Then
            Return i
        Else
            Return j
        End If
    End Function

    Private Sub btnABC_Click(sender As Object, e As EventArgs) Handles btnABC.Click
        botonpresionando = 2
        buscarenArbol()
        imprimesug()
        'lblSug1.Text = ""

    End Sub

    Private Sub Celular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        botonIndices(1) = 0
        NdebotonIndices = 1
    End Sub

    Private Sub imprimesug()
        If NdebotonIndices = 0 Then
            lblSug1.Text = ""
            lblSug2.Text = ""
            lblSug3.Text = ""
            Exit Sub
        End If
        Dim maxi As Integer = 1
        maxi = botonIndices(1)
        For i = 1 To NdebotonIndices
            maxi = may(maxi, botonIndices(i))
        Next
        lblSug1.Text = Palabras(InddelMaxHijosyYo(maxi))

        Dim maxi2 As Integer = botonIndices(1)
        If NdebotonIndices >= 2 Then

            For i = 1 To NdebotonIndices
                If may(maxi2, botonIndices(i)) <> maxi Then
                    maxi2 = may(maxi2, botonIndices(i))
                End If
            Next
            lblSug2.Text = Palabras(InddelMaxHijosyYo(maxi2))
        Else
            lblSug2.Text = ""
        End If


        If NdebotonIndices >= 3 Then
            Dim maxi3 = botonIndices(1)
            For i = 1 To NdebotonIndices
                If may(maxi3, botonIndices(i)) <> maxi And may(maxi3, botonIndices(i)) <> maxi2 Then
                    maxi3 = may(maxi3, botonIndices(i))
                End If
            Next
            lblSug3.Text = Palabras(InddelMaxHijosyYo(maxi3))
        Else
            lblSug3.Text = ""
        End If

    End Sub

    Private Sub lblSug1_Click(sender As Object, e As EventArgs) Handles lblSug1.Click
        For Each c In lblSug1.Text
            esletra(c)
        Next
        txtEscribir.Text &= lblSug1.Text
        esespacio()
        txtEscribir.Text &= " "
        txtEscribir.Focus()
        txtEscribir.Select(txtEscribir.Text.Length, 0)
        NdebotonIndices = 1
        botonIndices(1) = 0
        lblSug2.Text = ""
        lblSug1.Text = ""
        lblSug3.Text = ""
    End Sub

    Private Sub esletra(ByVal ek As Char)
        letra = asqui(ek)
        cadena &= ek
        sugiere(letra)
        'lblSugerencia.Text = respuesta

    End Sub

    Private Sub esespacio()
        actualiza()
        cadena = ""
        indice = 0
        NdeIndicesdeCadena = 0
        'lblSugerencia.Text = ""
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        lblSug1.Text = txtNada.Text
    End Sub

    Private Sub lblSug3_Click(sender As Object, e As EventArgs) Handles lblSug3.Click
        For Each c In lblSug3.Text
            esletra(c)
        Next
        txtEscribir.Text &= lblSug3.Text
        esespacio()
        txtEscribir.Text &= " "
        txtEscribir.Focus()
        txtEscribir.Select(txtEscribir.Text.Length, 0)
        NdebotonIndices = 1
        botonIndices(1) = 0
        lblSug2.Text = ""
        lblSug1.Text = ""
        lblSug3.Text = ""
    End Sub

    Private Sub lblSug2_Click(sender As Object, e As EventArgs) Handles lblSug2.Click
        For Each c In lblSug1.Text
            esletra(c)
        Next
        txtEscribir.Text &= lblSug2.Text
        esespacio()
        txtEscribir.Text &= " "
        txtEscribir.Focus()
        txtEscribir.Select(txtEscribir.Text.Length, 0)
        NdebotonIndices = 1
        botonIndices(1) = 0
        lblSug2.Text = ""
        lblSug1.Text = ""
        lblSug3.Text = ""
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        txtEscribir.Text = ""
    End Sub
End Class