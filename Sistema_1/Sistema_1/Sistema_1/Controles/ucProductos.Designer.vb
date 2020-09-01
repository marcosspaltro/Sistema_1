<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucProductos
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstProds = New System.Windows.Forms.ListBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtprueba = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstProds
        '
        Me.lstProds.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstProds.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstProds.FormattingEnabled = True
        Me.lstProds.Location = New System.Drawing.Point(15, 24)
        Me.lstProds.Name = "lstProds"
        Me.lstProds.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstProds.Size = New System.Drawing.Size(358, 390)
        Me.lstProds.TabIndex = 6
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(69, 16)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Productos"
        '
        'txtprueba
        '
        Me.txtprueba.Location = New System.Drawing.Point(69, 411)
        Me.txtprueba.Name = "txtprueba"
        Me.txtprueba.Size = New System.Drawing.Size(100, 20)
        Me.txtprueba.TabIndex = 7
        '
        'ucProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtprueba)
        Me.Controls.Add(Me.lstProds)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "ucProductos"
        Me.Size = New System.Drawing.Size(385, 431)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstProds As ListBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtprueba As TextBox
End Class
