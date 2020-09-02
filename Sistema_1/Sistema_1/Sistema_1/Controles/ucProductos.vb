
Public Class ucProductos
    Public Event Cambio_Productos()
    Private clProds As New clsProductos

    Private Sub ucProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Llenar_List(lstProds, "Productos")
        If Not lstProds.SelectedIndex = -1 Then RaiseEvent Cambio_Productos()
    End Sub

    Private Sub cmdNinguno_Click(sender As Object, e As EventArgs)
        lstProds.SelectedIndex = -1
    End Sub

    'Private Sub lstProds_MouseClick(sender As Object, e As MouseEventArgs) Handles lstProds.MouseClick
    '    Select Case e.Button
    '        Case MouseButtons.Right
    '            For i As Integer = 0 To lstProds.Items.Count - 1
    '                If lstProds.GetSelected(i) = True Then
    '                    lstProds.SetSelected(i, False)
    '                Else
    '                    lstProds.SetSelected(i, True)
    '                End If
    '            Next
    '    End Select
    'End Sub

    Private Sub lstProds_MouseUp(sender As Object, e As MouseEventArgs) Handles lstProds.MouseUp
        Select Case e.Button
            Case MouseButtons.Right
                For i As Integer = 0 To lstProds.Items.Count - 1
                    'If lstProds.GetSelected(i) = True Then
                    '    lstProds.SetSelected(i, False)
                    'Else
                    '    lstProds.SetSelected(i, True)
                    'End If
                    lstProds.SetSelected(i, Not lstProds.GetSelected(i))
                Next
            Case MouseButtons.Middle
                lstProds.SelectedIndex = -1
        End Select
    End Sub
    Public Function Devolver_Cadena() As String
        Dim vFiltro As String = ""
        Dim nombre As String = ""
        If Not lstProds.SelectedIndex = -1 Then

            For Each i In lstProds.SelectedItems
                Dim nvoNombre As String = i.Substring(lstProds.Text.IndexOf(". ") + 2)
                If nombre = "" Then
                    nombre = nvoNombre
                Else
                    nombre = nombre + $"%' OR Nombre LIKE '%{nvoNombre}"
                End If
                vFiltro = $" Nombre LIKE '%{nombre}%'"

            Next
        End If
        Return vFiltro

    End Function

    Private Sub lstProds_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProds.SelectedIndexChanged
        RaiseEvent Cambio_Productos()
    End Sub
End Class
