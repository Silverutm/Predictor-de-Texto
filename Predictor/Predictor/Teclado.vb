Imports System.IO
Public Class Teclado
    Dim letra As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub lblSugerencia_Click(sender As Object, e As EventArgs) Handles lblSugerencia.Click
        For i = NdeIndicesdeCadena To lblSugerencia.Text.Length - 1
            esletra(lblSugerencia.Text(i))
            txtEscribir.Text &= lblSugerencia.Text(i)
        Next
        esespacio()
        txtEscribir.Text &= " "
        txtEscribir.Select(txtEscribir.Text.Length, 0)
        'txtEscribir.Focus()
    End Sub

    Private Sub esletra(ByVal ek As Char)
        letra = asqui(ek)
        cadena &= ek
        sugiere(letra)
        lblSugerencia.Text = respuesta

    End Sub

    Private Sub esespacio()
        actualiza()
        cadena = ""
        indice = 0
        NdeIndicesdeCadena = 0
        lblSugerencia.Text = ""
    End Sub

    Private Sub txtEscribir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEscribir.KeyPress
        If e.KeyChar = " " Then
            esespacio()
        Else
            esletra(e.KeyChar)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

    End Sub

    Private Sub btnEntrenar_Click(sender As Object, e As EventArgs) Handles btnEntrenar.Click
        Dim fileName, calculationText As String
        Dim openDlg As OpenFileDialog
        openDlg = New OpenFileDialog() '// make a new dialog'
        If openDlg.ShowDialog() = DialogResult.OK Then
            '// the user clicked OK'
            fileName = openDlg.FileName
            calculationText = File.ReadAllText(fileName)

            For Each c In calculationText
                If c = " " Then
                    esespacio()
                Else
                    esletra(c)
                End If
            Next
            txtEscribir.Text = ""
            lblSugerencia.Text = ""
            'Dim numeros() As String
            'numeros = calculationText.Split(" ")

            'Limybas = CInt(numeros(0))
            'Limxbas = CInt(numeros(1))
            'xbas = 1
            'ybas = 1
            'For i = 2 To numeros.Length - 1
            ' formasbasicas(ybas, xbas) = CBool(numeros(i))
            ' xbas += 1
            'If xbas = Limxbas + 1 Then
            'xbas = 1
            'ybas += 1
            'End If
            '   Next
            '  Dim ulti() As String
            ' ulti = fileName.Split("\")
            'lblFbasica.Text = ulti(ulti.Length - 1)
            MsgBox(NdePalabras)
        End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        txtEscribir.Text = ""
    End Sub
End Class
