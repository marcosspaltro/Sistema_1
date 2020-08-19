<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStock))
        Me.grdStock = New Grilla2.SpeedGrilla()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnFiltro_Fecha = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdStock
        '
        Me.grdStock.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.None
        Me.grdStock.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
        Me.grdStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStock.AutoResize = False
        Me.grdStock.bColor = System.Drawing.SystemColors.Window
        Me.grdStock.bColorSel = System.Drawing.SystemColors.Highlight
        Me.grdStock.bFColor = System.Drawing.SystemColors.WindowText
        Me.grdStock.bFColorSel = System.Drawing.SystemColors.HighlightText
        Me.grdStock.Col = 0
        Me.grdStock.Cols = 10
        Me.grdStock.DataMember = ""
        Me.grdStock.DataSource = Nothing
        Me.grdStock.EnableEdicion = True
        Me.grdStock.Encabezado = ""
        Me.grdStock.fColor = System.Drawing.SystemColors.Control
        Me.grdStock.FixCols = 0
        Me.grdStock.FixRows = 0
        Me.grdStock.FuenteEncabezado = Nothing
        Me.grdStock.FuentePieDePagina = Nothing
        Me.grdStock.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None
        Me.grdStock.Location = New System.Drawing.Point(0, 0)
        Me.grdStock.MenuActivado = False
        Me.grdStock.Name = "grdStock"
        Me.grdStock.PieDePagina = "" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Page {0} of {1}"
        Me.grdStock.PintarFilaSel = True
        Me.grdStock.Redraw = True
        Me.grdStock.Row = 0
        Me.grdStock.Rows = 50
        Me.grdStock.Size = New System.Drawing.Size(594, 453)
        Me.grdStock.TabIndex = 0
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(100, 213)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(157, 20)
        Me.txtStock.TabIndex = 2
        '
        'lblRegistros
        '
        Me.lblRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.Location = New System.Drawing.Point(249, 421)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(17, 13)
        Me.lblRegistros.TabIndex = 3
        Me.lblRegistros.Text = "lbl"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.grdStock)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnFiltro_Fecha)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MonthCalendar1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtStock)
        Me.SplitContainer1.Size = New System.Drawing.Size(776, 422)
        Me.SplitContainer1.SplitterDistance = 538
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 4
        '
        'btnFiltro_Fecha
        '
        Me.btnFiltro_Fecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFiltro_Fecha.Location = New System.Drawing.Point(9, 177)
        Me.btnFiltro_Fecha.Name = "btnFiltro_Fecha"
        Me.btnFiltro_Fecha.Size = New System.Drawing.Size(248, 23)
        Me.btnFiltro_Fecha.TabIndex = 4
        Me.btnFiltro_Fecha.Text = "Filtrar por fecha"
        Me.btnFiltro_Fecha.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscador general:"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(6, 9)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lblRegistros)
        Me.Name = "frmStock"
        Me.Text = "frmStock"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdStock As Grilla2.SpeedGrilla
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblRegistros As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnFiltro_Fecha As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
