Imports System.IO

Public Class frmProductos
    Private clProd As New clsProductos
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim dt As DataTable = clProd.Datos()

        With grdProductos
            .MostrarDatos(dt, True)
            .ColW(0) = 60
            .ColW(1) = 150
            .FixCols = 1
        End With
    End Sub

    Private Sub grdProductos_Editado(f As Short, c As Short, a As Object) Handles grdProductos.Editado
        Dim vId As Integer = grdProductos.Texto(f, grdProductos.ColIndex("Id"))

        If grdProductos.EsUltimaF Then
            clProd.Agregar(a)
            grdProductos.Texto(f, grdProductos.ColIndex("Id")) = clProd.Max_Id
            grdProductos.AgregarFila()
            grdProductos.ActivarCelda(f + 1, c)
        Else
            clProd.Editar(vId, a)
        End If

        grdProductos.Texto(f, c) = a
    End Sub
End Class