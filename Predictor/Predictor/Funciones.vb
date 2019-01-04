Module Funciones
    Public FC As New Celular
    Public FT As New Teclado

    Public tam As Integer = 1000000
    Public ListaAdyacencia(tam, 27) As Integer

    Public RepeticionesMias(tam) As Integer 'Cuantas veces me han dado la palabra
    Public InddelMaxHijosyYo(tam) As Integer    'Id de mi hijo mas repetido
    Public NdePalabras As Integer = 27       'Id de la ultima palabra

    Public Palabras(tam) As String      'La palabra en ese ID
    Public respuesta As String             'palabra sugerida
    Public letradeVertice(tam) As Short     'Que letra tengo

    Public cadena As String = ""
    Public indice As Integer

    Public indicesDeCadena(40) As Integer
    Public NdeIndicesdeCadena As Integer

    Public Function asqui(ByVal c As Char) As Integer
        Return Asc(c) - Asc("a")
    End Function

    Public Function asquireverso(ByVal l As Integer) As Char
        Return Chr(l + Asc("a"))
    End Function

    Public Sub sugiere(ByVal letra As Integer)
        If ListaAdyacencia(indice, letra) <> 0 Then
            indice = ListaAdyacencia(indice, letra)
        Else
            NdePalabras += 1
            ListaAdyacencia(indice, letra) = NdePalabras
            indice = NdePalabras
        End If
        NdeIndicesdeCadena += 1
        indicesDeCadena(NdeIndicesdeCadena) = indice
        respuesta = Palabras(InddelMaxHijosyYo(indice))
    End Sub

    Public Sub limpiar()
        For i = 0 To tam - 1
            RepeticionesMias(i) = 0
            InddelMaxHijosyYo(i) = i
        Next
        For i = 0 To 26
            ListaAdyacencia(0, i) = i + 1
            letradeVertice(i + 1) = i
            Palabras(i + 1) = asquireverso(i)
            'MsgBox(asquireverso(i) & " " & Palabras(i + 1))
            RepeticionesMias(i + 1) = 1
        Next
    End Sub
    Public Function mayor(ByVal i As Integer, ByVal j As Integer) As Integer
        If RepeticionesMias(i) >= RepeticionesMias(j) Then
            Return i
        Else
            Return j
        End If
    End Function

    Public Sub actualiza()
        RepeticionesMias(indice) += 1
        Dim indtem As Integer
        For i = NdeIndicesdeCadena To 1 Step -1
            indtem = indicesDeCadena(i)
            InddelMaxHijosyYo(indtem) = mayor(InddelMaxHijosyYo(indtem), indice)
        Next
        Palabras(indice) = cadena
    End Sub
End Module
