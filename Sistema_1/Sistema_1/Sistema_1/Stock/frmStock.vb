Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Public Class frmStock
    Private clStock As New clsStock
    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim vTeclas() As Integer = {46}
        grdStock.TeclasManejadas = vTeclas

        Cargar_LST()
    End Sub

    Private Sub Cargar_LST(Optional fFecha As String = "")
        Dim fId As Integer = 0
        Dim fNombre As String = ""

        If txtStock.Text.Length Then
            fNombre = txtStock.Text
            If IsNumeric(txtStock.Text) Then
                fId = CInt(txtStock.Text)
            End If
        End If

        Dim dt As DataTable = clStock.Datos(fId, fFecha, fId, fNombre)

        With grdStock
            .MostrarDatos(dt, True)

            .ColW(0) = 60
            .ColW(1) = 150
            .FixCols = 1
            Totales()
        End With
    End Sub
    Private Sub Totales()
        With grdStock
            Dim vCant As Integer
            For i As Integer = 1 To .Rows - 2
                vCant = vCant + .Texto(i, .ColIndex("Cantidad"))
            Next
            lblRegistros.Text = "Registros: " & .Rows - 2 & " Cantidad: " & vCant
        End With
    End Sub

    Private Sub grdStock_Editado(f As Short, c As Short, a As Object) Handles grdStock.Editado
        With grdStock
            Dim vId As Integer = grdStock.Texto(f, grdStock.ColIndex("Id"))
            Dim vfecha As Date
            Dim vid_Productos As Integer
            Dim vcantidad As Integer
            vfecha = .Texto(f, .ColIndex("Fecha"))
            vid_Productos = .Texto(f, .ColIndex("id_Productos"))
            vcantidad = .Texto(f, .ColIndex("cantidad"))

            Select Case c
                Case .ColIndex("Fecha")
                    If .EsUltimaF Then
                        .Texto(f, c) = a
                        .ActivarCelda(f, .ColIndex("Id_Productos"))
                    Else
                        .Texto(f, c) = a
                        clStock.Editar(vId, a, vid_Productos, vcantidad)
                        .ActivarCelda(f + 1, c)
                    End If

                Case .ColIndex("Id_Productos")
                    Dim vNombre As String = clStock.Nombre_Producto(a)
                    If .EsUltimaF Then
                        If vNombre.Length Then
                            .Texto(f, c) = a
                            .Texto(f, .ColIndex("Nombre")) = vNombre
                            .ActivarCelda(f, .ColIndex("Cantidad"))
                        Else
                            .ErrorEnTxt()
                        End If
                    Else
                        If vNombre.Length Then
                            .Texto(f, c) = a
                            .Texto(f, .ColIndex("Nombre")) = vNombre
                            clStock.Editar(vId, vfecha, a, vcantidad)
                            .ActivarCelda(f + 1, c)
                        Else
                            .ErrorEnTxt()
                        End If
                    End If

                Case .ColIndex("Cantidad")
                    .Texto(f, c) = a
                    If .Texto(f, c) < 0 Then
                        .ErrorEnTxt()
                    Else
                        If .EsUltimaF Then
                            If .Texto(f, .ColIndex("fecha")) < #1/1/1900# Then
                                .ActivarCelda(f, .ColIndex("fecha"))
                            Else
                                If .Texto(f, .ColIndex("Id_Productos")) = 0 Then
                                    .ActivarCelda("id_Productos")
                                Else
                                    clStock.Agregar(vfecha, vid_Productos, a)
                                    grdStock.Texto(f, grdStock.ColIndex("Id")) = clStock.Max_Id
                                    .AgregarFila()
                                    .ActivarCelda(f + 1, .ColIndex("Fecha"))
                                    Totales()
                                End If
                            End If
                        Else
                            clStock.Editar(vId, vfecha, vid_Productos, a)
                            .ActivarCelda(f + 1, .ColIndex("cantidad"))
                            Totales()
                        End If
                    End If
            End Select
        End With

    End Sub

    Private Sub grdStock_KeyUp(sender As Object, e As Short) Handles grdStock.KeyUp
        Select Case e
            Case 46
                'Tecla Borrar/Delete
                If grdStock.Texto(, 0) <> 0 Then
                    If MsgBox($"¿Esta seguro de borrar el producto {grdStock.Texto(, 0)}. {grdStock.Texto(, 1)}?",
                          MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Borrar") = MsgBoxResult.Yes Then
                        'Borrar el registro
                        clStock.Borrar(grdStock.Texto(, 0))
                        grdStock.BorrarFila()
                    End If
                End If
            Case 32
                'Barra Espaciadora
        End Select

    End Sub

    Private Sub txtStock_TextChanged(sender As Object, e As EventArgs) Handles txtStock.TextChanged
        Cargar_LST()
    End Sub

    Private Sub grdStock_Load(sender As Object, e As EventArgs) Handles grdStock.Load

    End Sub

    Private Sub btnFiltro_Fecha_Click(sender As Object, e As EventArgs) Handles btnFiltro_Fecha.Click
        Cargar_LST(uFecha.Devolver_cadena)
    End Sub
    Private Sub ucFecha_Cambio_Fecha() Handles uFecha.cambio_fecha
        Cargar_LST(uFecha.Devolver_cadena)
    End Sub
End Class