<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProveedores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProveedores))
        Me.grdProveedores = New Grilla2.SpeedGrilla()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtProveedores = New System.Windows.Forms.TextBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdProveedores
        '
        Me.grdProveedores.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdProveedores.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdProveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdProveedores.AutoResize = False
        Me.grdProveedores.bColor = System.Drawing.SystemColors.Window
        Me.grdProveedores.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdProveedores.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdProveedores.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdProveedores.Col = 0
        Me.grdProveedores.Cols = 10
        Me.grdProveedores.DataMember = ""
        Me.grdProveedores.DataSource = Nothing
        Me.grdProveedores.EnableEdicion = True
        Me.grdProveedores.Encabezado = ""
        Me.grdProveedores.fColor = System.Drawing.SystemColors.Control
        Me.grdProveedores.FixCols = 0
        Me.grdProveedores.FixRows = 0
        Me.grdProveedores.FuenteEncabezado = Nothing
        Me.grdProveedores.FuentePieDePagina = Nothing
        Me.grdProveedores.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdProveedores.Location = New System.Drawing.Point(12, 12)
        Me.grdProveedores.MenuActivado = False
        Me.grdProveedores.Name = "grdProveedores"
        Me.grdProveedores.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdProveedores.PintarFilaSel = True
        Me.grdProveedores.Redraw = True
        Me.grdProveedores.Row = 0
        Me.grdProveedores.Rows = 50
        Me.grdProveedores.Size = New System.Drawing.Size(776, 400)
        Me.grdProveedores.TabIndex = 0
        '
        'txtProveedores
        '
        Me.txtProveedores.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtProveedores.Location = New System.Drawing.Point(12, 418)
        Me.txtProveedores.Name = "txtProveedores"
        Me.txtProveedores.Size = New System.Drawing.Size(231, 20)
        Me.txtProveedores.TabIndex = 2
        '
        'frmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtProveedores)
        Me.Controls.Add(Me.grdProveedores)
        Me.Name = "frmProveedores"
        Me.Text = "frmProveedores"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdProveedores As Grilla2.SpeedGrilla
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents txtProveedores As TextBox
End Class
