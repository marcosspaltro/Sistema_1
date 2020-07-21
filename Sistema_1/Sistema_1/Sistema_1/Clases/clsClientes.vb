Imports System.IO
Public Class clsClientes
#Region " Devolver Datos "
    Public Function Datos() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Nombre", GetType(String))

        If Not File.Exists(Application.StartupPath + "\Clientes.txt") Then
            Dim swCli As StreamWriter = New StreamWriter("Clientes.txt")
            swCli.Close()
        End If

        Dim srCli As New StreamReader("Clientes.txt")
        Dim vlinea As String = srCli.ReadLine

        While vlinea IsNot Nothing

            dt.Rows.Add(Codigo_Seleccionado(vlinea), Nombre_Seleccionado(vlinea))

            vlinea = srCli.ReadLine

        End While
        srCli.Close()

        Return dt

    End Function

    Public Function Max_Id() As Integer
        Dim srCli As New StreamReader("Clientes.txt")
        Dim vlinea As String = srCli.ReadLine

        Dim vmax As Integer = 0

        While vlinea IsNot Nothing
            If vlinea.IndexOf(".") > 0 Then
                Dim vindice As Integer = Codigo_Seleccionado(vlinea)
                If vmax < vindice Then
                    vmax = vindice
                End If
            End If
            vlinea = srCli.ReadLine

        End While
        srCli.Close()
        Return vmax
    End Function

#End Region

#Region " Editar Datos"
    Public Sub Agregar()

    End Sub

    Public Sub Editar()

    End Sub

    Public Sub Borrar()
        frmClientes.lstClientes.Items.RemoveAt(frmClientes.lstClientes.SelectedIndex)
    End Sub
    Public Sub nvalista()
        Using swCli As TextWriter = New StreamWriter("Clientes.txt")

            For Each items In frmClientes.lstClientes.Items
                swCli.WriteLine(items)
            Next
        End Using
    End Sub

#End Region
End Class
