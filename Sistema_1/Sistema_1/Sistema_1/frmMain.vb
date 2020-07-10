Public Class frmMain
    Dim frProd As New frmProductos

    Private Sub mnuProductos_Click(sender As Object, e As EventArgs) Handles mnuProductos.Click
        frProd.MdiParent = Me
        frProd.Show()
        frProd.WindowState = FormWindowState.Minimized
        frProd.WindowState = FormWindowState.Maximized
    End Sub


End Class
