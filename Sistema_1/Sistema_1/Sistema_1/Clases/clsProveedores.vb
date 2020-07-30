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
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim cm As New OleDb.OleDbCommand("SELECT MAX(Id) FROM Proveedores", db)

        Dim d As Object = Nothing

        cm.CommandType = CommandType.Text
        db.Open()
        d = cm.ExecuteScalar()

        Return CInt(d)
    End Function

#End Region

#Region " Editar Datos"
    Public Sub Agregar(ByVal nombre_Nuevo As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"INSERT INTO Proveedores (Nombre) VALUES('{nombre_Nuevo}') ", db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()

    End Sub

    Public Sub Editar(ByVal id As Integer, ByVal Nombre_Nuevo As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"UPDATE Proveedores SET Nombre='{Nombre_Nuevo}' WHERE ID={id} ", db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()

    End Sub


    Public Sub Borrar(ByVal Id As Integer)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand("DELETE FROM Proveedores WHERE ID =" & Id, db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()

    End Sub

#End Region
End Class
