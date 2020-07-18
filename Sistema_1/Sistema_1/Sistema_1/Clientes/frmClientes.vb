Public Class frmClientes
    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Aceptar" Then
            lstClientes.Items.Insert(lstClientes.SelectedIndex, txtClientes.Text)
            lstClientes.Items.RemoveAt(lstClientes.SelectedIndex)
            cmdEditar.Text = "Editar"
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
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        lstClientes.Items.RemoveAt(lstClientes.SelectedIndex)
    End Sub

    Private Sub txtClientes_TextChanged(sender As Object, e As EventArgs) Handles txtClientes.TextChanged

    End Sub

    Private Sub lstClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClientes.SelectedIndexChanged
        txtClientes.Text = ""
        cmdEditar.Text = "Editar"
    End Sub
End Class