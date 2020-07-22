Imports System.IO
Public Class clsProveedores

#Region " Devolver Datos "
    Public Function Datos() As DataTable
        Dim dt As New DataTable()
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dat As New OleDb.OleDbDataAdapter("SELECT * FROM Proveedores", db)
        dat.Fill(dt)
        Return dt

    End Function

    Public Function Max_Id() As Integer
        Dim SrProv As New StreamReader("Proveedores.txt")
        Dim vlinea As String = SrProv.ReadLine

        Dim vmax As Integer = 0

        While vlinea IsNot Nothing
            If vlinea.IndexOf(".") > 0 Then
                Dim vindice As Integer = Codigo_Seleccionado(vlinea)
                If vmax < vindice Then
                    vmax = vindice
                End If
            End If
            vlinea = SrProv.ReadLine

        End While
        SrProv.Close()
        Return vmax
    End Function

#End Region

#Region " Editar Datos"
    Public Sub Agregar(ByVal nombre_Nuevo As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"INSERT INTO Proveedores (Nombre) VALUES('{nombre_Nuevo}') ", db)
        db.Open()
        dc.ExecuteNonQuery()
    End Sub

    Public Sub Editar(ByVal id As Integer, ByVal Nombre_Nuevo As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"UPDATE Proveedores SET Nombre='{Nombre_Nuevo}' WHERE ID={id} ", db)
        db.Open()
        dc.ExecuteNonQuery()
    End Sub

    Public Sub Borrar(ByVal Id As Integer)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand("DELETE FROM Proveedores WHERE ID =" & Id, db)
        db.Open()
        dc.ExecuteNonQuery()
    End Sub

#End Region
End Class
