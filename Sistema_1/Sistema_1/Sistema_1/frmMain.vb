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

    Private Sub mnuClientes_Click(sender As Object, e As EventArgs) Handles mnuClientes.Click
        frmClientes.MdiParent = Me
        frmClientes.Show()
        frmClientes.WindowState = FormWindowState.Minimized
        frmClientes.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub mnuProveedores_Click(sender As Object, e As EventArgs) Handles mnuProveedores.Click
        frmProveedores.MdiParent = Me
        frmProveedores.Show()
        frmProveedores.WindowState = FormWindowState.Minimized
        frmProveedores.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        frmStock.MdiParent = Me
        frmStock.Show()
        frmStock.WindowState = FormWindowState.Minimized
        frmStock.WindowState = FormWindowState.Maximized
    End Sub
End Class
