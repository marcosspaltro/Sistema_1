Imports System.IO
Public Class frmProveedores
    Private clProv As New clsProveedores
    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim vTeclas() As Integer = {46}

        grdProveedores.TeclasManejadas = vTeclas

        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim fId As Integer = 0
        Dim fNombre As String = ""

        If txtProveedores.Text.Length Then
            fNombre = txtProveedores.Text
            If IsNumeric(txtProveedores.Text) Then fId = CInt(txtProveedores.Text)
        End If

        Dim dt As DataTable = clProv.Datos(fId, fNombre)

        With grdProveedores
            .MostrarDatos(dt, True)
            .ColW(0) = 60
            .ColW(1) = 150
            .FixCols = 1
        End With
    End Sub

    Private Sub grdProveedores_Editado(f As Short, c As Short, a As Object) Handles grdProveedores.Editado
        Dim vId As Integer = grdProveedores.Texto(f, grdProveedores.ColIndex("Id"))

        grdProveedores.Texto(f, c) = a
        If grdProveedores.Texto(f, c) = "" Then
            grdProveedores.ErrorEnTxt()
        Else
            If grdProveedores.EsUltimaF Then
                clProv.Agregar(a)
                grdProveedores.Texto(f, grdProveedores.ColIndex("Id")) = clProv.Max_Id
                grdProveedores.AgregarFila()
                grdProveedores.ActivarCelda(f + 1, c)
            Else
                grdProveedores.Texto(f, c) = a
                clProv.Editar(vId, a)
                grdProveedores.ActivarCelda(f + 1, c)
            End If
        End If

    End Sub
    Private Sub grdProveedores_KeyUp(sender As Object, e As Short) Handles grdProveedores.KeyUp
        Select Case e
            Case 46
                'Tecla Borrar/Delete
                If grdProveedores.Texto(, 0) <> 0 Then
                    If MsgBox($"¿Esta seguro de borrar el Provucto {grdProveedores.Texto(, 0)}. {grdProveedores.Texto(, 1)}?",
                          MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Borrar") = MsgBoxResult.Yes Then
                        'Borrar el registro
                        clProv.Borrar(grdProveedores.Texto(, 0))
                        grdProveedores.BorrarFila()
                    End If
                End If
            Case 32
                'Barra Espaciadora
        End Select
    End Sub

    Private Sub txtProveedores_TextChanged(sender As Object, e As EventArgs) Handles txtProveedores.TextChanged
        Cargar_LST()
    End Sub
End Class