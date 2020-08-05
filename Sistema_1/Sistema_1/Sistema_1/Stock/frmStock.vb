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
        Dim fNombre As String = ""

        If txtStock.Text.Length Then
            fNombre = txtStock.Text
            If IsNumeric(txtStock.Text) Then fId = CInt(txtStock.Text)
        End If

        Dim dt As DataTable = clStock.Datos(fId, fNombre)

        With grdStock
            .MostrarDatos(dt, True)
            .ColW(0) = 60
            .ColW(1) = 150
            .FixCols = 1
        End With
    End Sub

    Private Sub grdStock_Editado(f As Short, c As Short, a As Object) Handles grdStock.Editado
        Dim vId As Integer = grdStock.Texto(f, grdStock.ColIndex("Id"))

        If grdStock.EsUltimaF Then
            clStock.Agregar(a)
            grdStock.Texto(f, grdStock.ColIndex("ID")) = clStock.Max_Id
            grdStock.AgregarFila()
            grdStock.ActivarCelda(f + 1, c)
        Else
            clStock.Editar(vId, a)
        End If

        grdStock.Texto(f, c) = a
    End Sub
    Private Sub grdStock_KeyUp(sender As Object, e As Short) Handles grdStock.KeyUp
        Select Case e
            Case 46
                'Tecla Borrar/Delete
                If grdStock.Texto(, 0) <> 0 Then
                    If MsgBox($"¿Esta seguro de borrar el Stockucto {grdStock.Texto(, 0)}. {grdStock.Texto(, 1)}?",
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

End Class