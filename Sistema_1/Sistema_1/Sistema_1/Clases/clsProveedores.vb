Imports System.IO
Public Class clsProveedores
#Region " Devolver Datos "
    Public Function Datos() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Nombre", GetType(String))

        If Not File.Exists(Application.StartupPath + "\Proveedores.txt") Then
            Dim swProv As StreamWriter = New StreamWriter("Proveedores.txt")
            swProv.Close()
        End If

        Dim srProv As New StreamReader("Proveedores.txt")
        Dim vlinea As String = srProv.ReadLine

        While vlinea IsNot Nothing

            dt.Rows.Add(Codigo_Seleccionado(vlinea), Nombre_Seleccionado(vlinea))

            vlinea = srProv.ReadLine

        End While
        srProv.Close()

        Return dt

    End Function

    Public Function Max_Id() As Integer
        Dim srProv As New StreamReader("Proveedores.txt")
        Dim vlinea As String = srProv.ReadLine

        Dim vmax As Integer = 0

        While vlinea IsNot Nothing
            If vlinea.IndexOf(".") > 0 Then
                Dim vindice As Integer = Codigo_Seleccionado(vlinea)
                If vmax < vindice Then
                    vmax = vindice
                End If
            End If
            vlinea = srProv.ReadLine

        End While
        srProv.Close()
        Return vmax
    End Function

#End Region

#Region " Editar Datos"
    Public Sub Agregar()

    End Sub

    Public Sub Editar()

    End Sub

    Public Sub Borrar()
        frmProveedores.lstProveedores.Items.RemoveAt(frmProveedores.lstProveedores.SelectedIndex)
    End Sub
    Public Sub nvalista()
        Using swProv As TextWriter = New StreamWriter("Proveedores.txt")

            For Each items In frmProveedores.lstProveedores.Items
                swProv.WriteLine(items)
            Next
        End Using
    End Sub

#End Region
End Class

