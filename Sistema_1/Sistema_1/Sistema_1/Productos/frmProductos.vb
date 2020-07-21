Imports System.IO

Public Class frmProductos
    Dim prod As New clsProductos

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As DataTable = prod.Datos

        For Each dr As DataRow In dt.Rows
            lstProductos.Items.Add($"{dr.Item(0)}. {dr.Item(1)}")
        Next
    End Sub

    Private Sub lstProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProductos.SelectedIndexChanged
        txtProd.Text = ""
        cmdEditar.Text = "Editar"
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If cmdEditar.Text = "Editar" Then
            lstProductos.Items.Add((prod.Max_Id + 1).ToString() + ". " + txtProd.Text)
            txtProd.Text = ""
            nvalista()
        End If
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        lstProductos.Items.RemoveAt(lstProductos.SelectedIndex)
        nvalista()
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Aceptar" Then
            cmdEditar.Text = "Editar"
            Dim codid As String
            codid = Codigo_Seleccionado(lstProductos.Text)
            lstProductos.Items.Insert(lstProductos.SelectedIndex, codid + ". " + txtProd.Text)
            lstProductos.Items.RemoveAt(lstProductos.SelectedIndex)
            nvalista()

        End If
        If Not lstProductos.SelectedIndex = -1 Then
            cmdEditar.Text = "Aceptar"
            Dim codnom As String
            codnom = Nombre_Seleccionado(lstProductos.Text)
            txtProd.Text = codnom
        End If

    End Sub
    Private Sub nvalista()
        Using swProd As TextWriter = New StreamWriter("Productos.txt")
            For Each items In lstProductos.Items
                swProd.WriteLine(items)
            Next
        End Using
    End Sub
End Class