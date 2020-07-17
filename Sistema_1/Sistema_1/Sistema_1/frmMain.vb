Public Class frmMain
    Dim frProd As New frmProductos

    Private Sub mnuProductos_Click(sender As Object, e As EventArgs) Handles mnuProductos.Click
        frProd.MdiParent = Me
        frProd.Show()
        frProd.WindowState = FormWindowState.Minimized
        frProd.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
