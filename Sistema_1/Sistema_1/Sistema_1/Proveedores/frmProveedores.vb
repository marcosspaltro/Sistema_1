Imports System.IO
Public Class frmProveedores
    Private clProv As New clsProveedores

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As DataTable = clProv.Datos

        For Each dr As DataRow In dt.Rows
            lstProveedores.Items.Add($"{dr.Item(0)}. {dr.Item(1)}")
        Next
    End Sub

    Private Sub lstProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProveedores.SelectedIndexChanged
        txtProveedores.Text = ""
        cmdEditar.Text = "Editar"
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cmdEditar.Text = "Editar" Then
            clProv.Agregar(txtProveedores.Text)
            txtProveedores.Text = ""
            Cargar_LST()
        End If
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If cmdEditar.Text = "Editar" Then
            If Not lstProveedores.SelectedIndex = -1 Then
                Dim i As Integer = Codigo_Seleccionado(lstProveedores.Text)
                clProv.Borrar(i)
                lstProveedores.Items.RemoveAt(lstProveedores.SelectedIndex)
                Cargar_LST()
            End If
        End If
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Aceptar" Then
            cmdEditar.Text = "Editar"
            Dim codid As String
            codid = Codigo_Seleccionado(lstProveedores.Text)
            clProv.Editar(codid, txtProveedores.Text)
            lstProveedores.Items.Insert(lstProveedores.SelectedIndex, codid + ". " + txtProveedores.Text)
            lstProveedores.Items.RemoveAt(lstProveedores.SelectedIndex)
            Cargar_LST()

        End If
        If Not lstProveedores.SelectedIndex = -1 Then
            cmdEditar.Text = "Aceptar"
            Dim codnom As String
            codnom = Nombre_Seleccionado(lstProveedores.Text)
            txtProveedores.Text = codnom
        End If

    End Sub
    Private Sub Cargar_LST()
        Dim dt As DataTable = clProv.Datos()

        With lstProveedores
            .Items.Clear()

            For Each dr As DataRow In dt.Rows
                .Items.Add(dr.Item("Id") & ". " & dr.Item("Nombre"))
            Next
        End With
    End Sub
End Class