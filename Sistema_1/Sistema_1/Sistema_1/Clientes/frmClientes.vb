Imports System.IO
Public Class frmClientes
    Private clCli As New clsClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim dt As DataTable = clCli.Datos()

        With grdClientes
            .MostrarDatos(dt, True)
            .ColW(0) = 60
            .ColW(1) = 150
            .FixCols = 1
        End With
    End Sub

    Private Sub grdClientes_Editado(f As Short, c As Short, a As Object) Handles grdClientes.Editado
        Dim vId As Integer = grdClientes.Texto(f, grdClientes.ColIndex("Id"))

        If grdClientes.EsUltimaF Then
            clCli.Agregar(a)
            grdClientes.Texto(f, grdClientes.ColIndex("Id")) = clCli.Max_Id
            grdClientes.AgregarFila()
            grdClientes.ActivarCelda(f + 1, c)
        Else
            clCli.Editar(vId, a)
        End If

        grdClientes.Texto(f, c) = a
    End Sub
End Class