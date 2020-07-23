Imports System.IO

Public Class frmProductos
    Private clProd As New clsProductos

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As DataTable = clProd.Datos

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
            clProd.Agregar(txtProd.Text)
            txtProd.Text = ""
            Cargar_LST()
        End If
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        If Not cmdEditar.Text = "Editar" Then
            If lstProductos.SelectedIndex = -1 Then
                Dim i As Integer = Codigo_Seleccionado(lstProductos.Text)
                clProd.Borrar(i)
                lstProductos.Items.RemoveAt(lstProductos.SelectedIndex)
                Cargar_LST()
            End If
        End If
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If cmdEditar.Text = "Aceptar" Then
            cmdEditar.Text = "Editar"
            Dim codid As String
            codid = Codigo_Seleccionado(lstProductos.Text)
            clProd.Editar(codid, txtProd.Text)
            lstProductos.Items.Insert(lstProductos.SelectedIndex, codid + ". " + txtProd.Text)
            lstProductos.Items.RemoveAt(lstProductos.SelectedIndex)
            Cargar_LST()

        End If
        If Not lstProductos.SelectedIndex = -1 Then
            cmdEditar.Text = "Aceptar"
            Dim codnom As String
            codnom = Nombre_Seleccionado(lstProductos.Text)
            txtProd.Text = codnom
        End If

    End Sub
    Private Sub Cargar_LST()
        Dim dt As DataTable = clProd.Datos()

        With lstProductos
            .Items.Clear()
            Application.DoEvents()

            For Each dr As DataRow In dt.Rows
                .Items.Add(dr.Item("Id") & ". " & dr.Item("Nombre"))
            Next
        End With
    End Sub
End Class