Imports System.IO
Public Class frmClientes
    Private clCli As New clsClientes
    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim vTeclas() As Integer = {46}

        grdClientes.TeclasManejadas = vTeclas
        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim fId As Integer = 0
        Dim fNombre As String = ""

        If txtClientes.Text.Length Then
            fNombre = txtClientes.Text
            If IsNumeric(txtClientes.Text) Then fId = CInt(txtClientes.Text)
        End If

        Dim dt As DataTable = clCli.Datos(fId, fNombre)

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
    Private Sub grdClientes_KeyUp(sender As Object, e As Short) Handles grdClientes.KeyUp
        Select Case e
            Case 46
                'Tecla Borrar/Delete
                If grdClientes.Texto(, 0) <> 0 Then
                    If MsgBox($"¿Esta seguro de borrar el Cliucto {grdClientes.Texto(, 0)}. {grdClientes.Texto(, 1)}?",
                          MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Borrar") = MsgBoxResult.Yes Then
                        'Borrar el registro
                        clCli.Borrar(grdClientes.Texto(, 0))
                        grdClientes.BorrarFila()
                    End If
                End If
            Case 32
                'Barra Espaciadora
        End Select
    End Sub

    Private Sub txtClientes_TextChanged(sender As Object, e As EventArgs) Handles txtClientes.TextChanged
        Cargar_LST()
    End Sub
End Class