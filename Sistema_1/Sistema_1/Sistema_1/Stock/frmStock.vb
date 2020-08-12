Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Public Class frmStock
    Private clStock As New clsStock
    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim vTeclas() As Integer = {46}
        grdStock.TeclasManejadas = vTeclas

        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim fId As Integer = 0
        Dim fFecha As String = ""
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
        End With
    End Sub

    Private Sub grdStock_Editado(f As Short, c As Short, a As Object) Handles grdStock.Editado
        Dim vId As Integer = grdStock.Texto(f, grdStock.ColIndex("Id"))

        With grdStock
            Select Case c
                Case .ColIndex("Fecha")
                    .Texto(f, c) = a
                    .ActivarCelda(f, .ColIndex("Id_Productos"))

                Case .ColIndex("Id_Productos")
                    Dim vNombre As String = clStock.Nombre_Producto(a)
                    If vNombre.Length Then
                        .Texto(f, c) = a
                        .Texto(f, .ColIndex("Nombre")) = vNombre
                        .ActivarCelda(f, .ColIndex("Cantidad"))
                    Else
                        .ErrorEnTxt()
                    End If

                Case .ColIndex("Cantidad")
                    If .Texto(f, .ColIndex("fecha")) < #1/1/1900# Then
                        .ActivarCelda(f, .ColIndex("fecha"))
                    Else
                        If .Texto(f, .ColIndex("Id_Productos")) = "" Then
                            .ActivarCelda("id_Productos")
                        Else
                            Dim fecha As Date
                            Dim id_Productos As Integer
                            Dim cantidad As Integer
                            fecha = .Texto(f, .ColIndex("Fecha"))
                            id_Productos = .Texto(f, .ColIndex("id_Productos"))
                            cantidad = .Texto(f, .ColIndex("cantidad"))
                            If grdStock.EsUltimaF Then
                                .Texto(f, c) = a
                                clStock.Agregar(fecha, id_Productos, cantidad)
                                grdStock.Texto(f, grdStock.ColIndex("Id")) = clStock.Max_Id
                            Else
                                'si edito que pase a la fila de abajo, no la siguiente
                            End If

                        End If


                    End If

                    If vId <> 0 Then
                        'clStock.Editar("j")
                    Else
                        'clStock.Agregar("j")

                        'Escribir el Id de la nueva fila en la columna Id
                        .AgregarFila()
                    End If
                    .ActivarCelda(f + 1, .ColIndex("Fecha"))

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
End Class