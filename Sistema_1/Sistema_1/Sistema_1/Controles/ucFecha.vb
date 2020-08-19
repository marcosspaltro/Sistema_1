Public Class ucFecha
    Public Event cambio_fecha()
    Private Sub mntFecha_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mntFecha.DateChanged
        lblFecha.Text = "La fecha es: " + mntFecha.SelectionRange.Start.ToString("dd/MM/yy")
        If chFecha.Checked Then RaiseEvent cambio_fecha()
    End Sub
    Public Function Devolver_cadena() As String
        Dim vFiltro As String = ""
        If chFecha.Checked Then
            vFiltro = $"Fecha= #{mntFecha.SelectionRange.Start:MM/dd/yy}#"
        End If
        Return vFiltro
    End Function

    Private Sub chFecha_CheckedChanged(sender As Object, e As EventArgs) Handles chFecha.CheckedChanged
        RaiseEvent cambio_fecha()
    End Sub
End Class
