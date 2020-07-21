Imports System.IO
Public Class frmClientes
    Dim cli As New clsClientes

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Aceptar" Then
            lstClientes.Items.Insert(lstClientes.SelectedIndex, txtClientes.Text)
            lstClientes.Items.RemoveAt(lstClientes.SelectedIndex)
            cmdEditar.Text = "Editar"
            nvalista()
        End If
        If Not lstClientes.SelectedIndex = -1 Then
            cmdEditar.Text = "Aceptar"
            txtClientes.Text = lstClientes.SelectedItem
        End If
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If Not txtClientes.Text = "" Then
            lstClientes.Items.Add(txtClientes.Text)
            txtClientes.Text = ""
        End If
        nvalista()
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        lstClientes.Items.RemoveAt(lstClientes.SelectedIndex)
        nvalista()
    End Sub

    Private Sub txtClientes_TextChanged(sender As Object, e As EventArgs) Handles txtClientes.TextChanged

    End Sub

    Private Sub lstClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClientes.SelectedIndexChanged
        txtClientes.Text = ""
        cmdEditar.Text = "Editar"
    End Sub
    Public Sub nvalista()
        Using swCli As TextWriter = New StreamWriter("Clientes.txt")
            For Each items In lstClientes.Items
                swCli.WriteLine(items)
            Next
        End Using
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = cli.Datos

        For Each dr As DataRow In dt.Rows
            lstClientes.Items.Add($"{dr.Item(0)}")
        Next
    End Sub
End Class
