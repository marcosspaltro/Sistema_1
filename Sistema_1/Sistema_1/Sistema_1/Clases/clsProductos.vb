Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class clsProductos

#Region " Devolver Datos "
    Public Function Datos() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Nombre", GetType(String))

        If Not File.Exists(Application.StartupPath + "\Productos.txt") Then
            Dim swProd As StreamWriter = New StreamWriter("Productos.txt")
            swProd.Close()
        End If

        Dim srProd As New StreamReader("Productos.txt")
        Dim vlinea As String = srProd.ReadLine

        While vlinea IsNot Nothing

            dt.Rows.Add(Codigo_Seleccionado(vlinea), Nombre_Seleccionado(vlinea))

            vlinea = srProd.ReadLine

        End While
        srProd.Close()

        Return dt

    End Function

    Public Function Max_Id() As Integer
        Dim srProd As New StreamReader("Productos.txt")
        Dim vlinea As String = srProd.ReadLine

        Dim vmax As Integer = 0

        While vlinea IsNot Nothing
            If vlinea.IndexOf(".") > 0 Then
                Dim vindice As Integer = Codigo_Seleccionado(vlinea)
                If vmax < vindice Then
                    vmax = vindice
                End If
            End If
            vlinea = srProd.ReadLine

        End While
        srProd.Close()
        Return vmax
    End Function

#End Region

#Region " Editar Datos"
    Public Sub Agregar()

    End Sub

    Public Sub Editar()

    End Sub

    Public Sub Borrar()
        frmProductos.lstProductos.Items.RemoveAt(frmProductos.lstProductos.SelectedIndex)
    End Sub
    Public Sub nvalista()
        Using swProd As TextWriter = New StreamWriter("Productos.txt")

            For Each items In frmProductos.lstProductos.Items
                swProd.WriteLine(items)
            Next
        End Using
    End Sub

#End Region
End Class
