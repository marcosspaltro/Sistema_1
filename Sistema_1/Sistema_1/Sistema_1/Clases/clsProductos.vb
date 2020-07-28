Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices

Public Class clsProductos

#Region " Devolver Datos "
    Public Function Datos() As DataTable
        Dim dt As New DataTable("Datos")
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dat As New OleDb.OleDbDataAdapter("SELECT * FROM Productos", db)
        dat.Fill(dt)
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
    Public Sub Agregar(ByVal nombre_Nuevo As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"INSERT INTO Productos (Nombre) VALUES('{nombre_Nuevo}') ", db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()
    End Sub

    Public Sub Editar(ByVal id As Integer, ByVal Nombre_Nuevo As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"UPDATE Productos SET Nombre='{Nombre_Nuevo}' WHERE ID={id} ", db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()

    End Sub

    Public Sub Borrar(ByVal Id As Integer)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand("DELETE FROM Productos WHERE ID =" & Id, db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()

    End Sub

#End Region
End Class
