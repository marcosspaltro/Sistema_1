Imports System.IO
Public Class clsClientes
    Public Function Datos() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Nombre", GetType(String))

        If Not File.Exists(Application.StartupPath + "\Clientes.txt") Then
            Dim swcli As StreamWriter = New StreamWriter("Clientes.txt")
            swcli.Close()
        End If

        Dim srcli As New StreamReader("Clientes.txt")
        Dim vlinea As String = srcli.ReadLine

        While vlinea IsNot Nothing

            dt.Rows.Add(Nombre_Seleccionado(vlinea))

            vlinea = srcli.ReadLine

        End While
        srcli.Close()

        Return dt

    End Function

End Class
