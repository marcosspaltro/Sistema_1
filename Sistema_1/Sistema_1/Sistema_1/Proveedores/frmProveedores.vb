Imports System.IO
Public Class frmProveedores
    Private clProv As New clsProveedores
    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim dt As DataTable = clProv.Datos()

        With grdProveedores
            .MostrarDatos(dt, True)
            .ColW(0) = 60
            .ColW(1) = 150
            .FixCols = 1
        End With
    End Sub

    Private Sub grdProveedores_Editado(f As Short, c As Short, a As Object) Handles grdProveedores.Editado
        Dim vId As Integer = grdProveedores.Texto(f, grdProveedores.ColIndex("Id"))

        If grdProveedores.EsUltimaF Then
            clProv.Agregar(a)
            grdProveedores.Texto(f, grdProveedores.ColIndex("Id")) = clProv.Max_Id
            grdProveedores.AgregarFila()
            grdProveedores.ActivarCelda(f + 1, c)
        Else
            clProv.Editar(vId, a)
        End If

        grdProveedores.Texto(f, c) = a
    End Sub
End Class