Imports System.IO
Public Class frmClientes
    Dim cli As New clsClientes

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Aceptar" Then
            cmdEditar.Text = "Editar"
            Dim codid As String
            codid = Codigo_Seleccionado(lstClientes.Text)
            lstClientes.Items.Insert(lstClientes.SelectedIndex, codid + ". " + txtClientes.Text)
            lstClientes.Items.RemoveAt(lstClientes.SelectedIndex)
            nvalista()

        End If
        If Not lstClientes.SelectedIndex = -1 Then
            cmdEditar.Text = "Aceptar"
            Dim codnom As String
            codnom = Nombre_Seleccionado(lstClientes.Text)
            txtClientes.Text = codnom
        End If
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cmdEditar.Text = "Editar" Then
            lstClientes.Items.Add((cli.Max_Id + 1).ToString() + ". " + txtClientes.Text)
            txtClientes.Text = ""
            nvalista()
        End If
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
            lstClientes.Items.Add($"{dr.Item(0)}. {dr.Item(1)}")
        Next
    End Sub
End Class
