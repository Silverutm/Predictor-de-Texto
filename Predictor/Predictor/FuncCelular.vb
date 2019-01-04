Module FuncCelular
    Public botonletas() As String = {" ", "", "abc", "def", "ghi", "jkl",
        "mno", "pqrs", "tuv", "wxyz"}
    Public botonpresionando As Integer

    Public botonIndices(tam), botonIndicopia(tam) As Integer
    Public NdebotonIndices As Integer

    Public Sub buscarenArbol()
        'MsgBox(botonpresionando & " " & botonletas(botonpresionando))
        Dim ncopias As Integer = 0
        For i = 1 To NdebotonIndices
            For Each c In botonletas(botonpresionando)
                If ListaAdyacencia(botonIndices(i), asqui(c)) <> 0 Then
                    ncopias += 1
                    botonIndicopia(ncopias) = ListaAdyacencia(botonIndices(i), asqui(c))
                End If
            Next
        Next

        For i = 1 To ncopias
            botonIndices(i) = botonIndicopia(i)
        Next
        NdebotonIndices = ncopias
    End Sub
End Module
