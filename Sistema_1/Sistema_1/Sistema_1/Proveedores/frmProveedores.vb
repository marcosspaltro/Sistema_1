Imports System.IO
Public Class frmProveedores
    Dim cli As New clsProveedores

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Aceptar" Then
            cmdEditar.Text = "Editar"
            Dim codid As String
            codid = Codigo_Seleccionado(lstProveedores.Text)
            lstProveedores.Items.Insert(lstProveedores.SelectedIndex, codid + ". " + txtProveedores.Text)
            lstProveedores.Items.RemoveAt(lstProveedores.SelectedIndex)
            nvalista()

        End If
        If Not lstProveedores.SelectedIndex = -1 Then
            cmdEditar.Text = "Aceptar"
            Dim codnom As String
            codnom = Nombre_Seleccionado(lstProveedores.Text)
            txtProveedores.Text = codnom
        End If
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cmdEditar.Text = "Editar" Then
            lstProveedores.Items.Add((cli.Max_Id + 1).ToString() + ". " + txtProveedores.Text)
            txtProveedores.Text = ""
            nvalista()
        End If
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        lstProveedores.Items.RemoveAt(lstProveedores.SelectedIndex)
        nvalista()
    End Sub

    Private Sub txtProveedores_TextChanged(sender As Object, e As EventArgs) Handles txtProveedores.TextChanged

    End Sub

    Private Sub lstProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProveedores.SelectedIndexChanged
        txtProveedores.Text = ""
        cmdEditar.Text = "Editar"
    End Sub
    Public Sub nvalista()
        Using swProv As TextWriter = New StreamWriter("Proveedores.txt")
            For Each items In lstProveedores.Items
                swProv.WriteLine(items)
            Next
        End Using
    End Sub

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = cli.Datos

        For Each dr As DataRow In dt.Rows
            lstProveedores.Items.Add($"{dr.Item(0)}. {dr.Item(1)}")
        Next
    End Sub
End Class

