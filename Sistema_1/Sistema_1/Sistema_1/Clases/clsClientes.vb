Imports System.IO
Public Class clsClientes

#Region " Devolver Datos "
    Public Function Datos() As DataTable
        Dim dt As New DataTable()
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dat As New OleDb.OleDbDataAdapter("SELECT * FROM Clientes", db)
        dat.Fill(dt)
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
    Public Sub Agregar(ByVal nombre_Nuevo As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"INSERT INTO Clientes (Nombre) VALUES('{nombre_Nuevo}') ", db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()

    End Sub

    Public Sub Editar(ByVal id As Integer, ByVal Nombre_Nuevo As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"UPDATE Clientes SET Nombre='{Nombre_Nuevo}' WHERE ID={id} ", db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()

    End Sub

    Public Sub Borrar(ByVal Id As Integer)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand("DELETE FROM Clientes WHERE ID =" & Id, db)
        db.Open()
        dc.ExecuteNonQuery()
        db.Close()

    End Sub

#End Region
End Class
