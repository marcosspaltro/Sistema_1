Imports System.IO
Public Class frmClientes
    Private clCli As New clsClientes

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As DataTable = clCli.Datos

        For Each dr As DataRow In dt.Rows
            lstClientes.Items.Add($"{dr.Item(0)}. {dr.Item(1)}")
        Next
    End Sub

    Private Sub lstClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClientes.SelectedIndexChanged
        txtClientes.Text = ""
        cmdEditar.Text = "Editar"
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cmdEditar.Text = "Editar" Then
            clCli.Agregar(txtClientes.Text)
            txtClientes.Text = ""
            Cargar_LST()
        End If
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If cmdEditar.Text = "Editar" Then
            If Not lstClientes.SelectedIndex = -1 Then
                Dim i As Integer = Codigo_Seleccionado(lstClientes.Text)
                clCli.Borrar(i)
                lstClientes.Items.RemoveAt(lstClientes.SelectedIndex)
                Cargar_LST()
            End If
        End If
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Aceptar" Then
            cmdEditar.Text = "Editar"
            Dim codid As String
            codid = Codigo_Seleccionado(lstClientes.Text)
            clCli.Editar(codid, txtClientes.Text)
            lstClientes.Items.Insert(lstClientes.SelectedIndex, codid + ". " + txtClientes.Text)
            lstClientes.Items.RemoveAt(lstClientes.SelectedIndex)
            Cargar_LST()

        End If
        If Not lstClientes.SelectedIndex = -1 Then
            cmdEditar.Text = "Aceptar"
            Dim codnom As String
            codnom = Nombre_Seleccionado(lstClientes.Text)
            txtClientes.Text = codnom
        End If

    End Sub
    Private Sub Cargar_LST()
        Dim dt As DataTable = clCli.Datos()

        With lstClientes
            .Items.Clear()

            For Each dr As DataRow In dt.Rows
                .Items.Add(dr.Item("Id") & ". " & dr.Item("Nombre"))
            Next
        End With
    End Sub
End Class