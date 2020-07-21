Module Herramientas

    ''' <summary>
    ''' Devuelve el Valor en una cadena con formato #. Texto
    ''' </summary>
    ''' <param name="s">Cadena a evaluar</param>
    ''' <returns>Integer</returns>
    Public Function Codigo_Seleccionado(ByVal s As String) As Integer
        Dim i As Integer
        If s.IndexOf(".") Then
            Dim n As String = s.Substring(0, s.IndexOf("."))
            If IsNumeric(n) Then i = CInt(n)
        End If
        Return i
    End Function

    ''' <summary>
    ''' Devuelve el Nombre en una cadena con formato #. Texto
    ''' </summary>
    ''' <param name="s">Cadena a evaluar</param>
    ''' <returns>String</returns>
    Public Function Nombre_Seleccionado(ByVal s As String) As String
        If s.IndexOf(".") > -1 Then
            s = s.Substring(s.IndexOf(".") + 2)
        End If
        Return s
    End Function
End Module
