<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucFecha
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
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.mntFecha = New System.Windows.Forms.MonthCalendar()
        Me.chFecha = New System.Windows.Forms.CheckBox()
        Me.tabseleccion = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstSemanas = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lstAñoMes = New System.Windows.Forms.ListBox()
        Me.lstMes = New System.Windows.Forms.ListBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.lstAño = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtDesde = New System.Windows.Forms.DateTimePicker()
        Me.tabseleccion.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(3, 203)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 13)
        Me.lblFecha.TabIndex = 0
        '
        'mntFecha
        '
        Me.mntFecha.Location = New System.Drawing.Point(0, 0)
        Me.mntFecha.Name = "mntFecha"
        Me.mntFecha.TabIndex = 1
        '
        'chFecha
        '
        Me.chFecha.AutoSize = True
        Me.chFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chFecha.Location = New System.Drawing.Point(3, 3)
        Me.chFecha.Name = "chFecha"
        Me.chFecha.Size = New System.Drawing.Size(54, 17)
        Me.chFecha.TabIndex = 2
        Me.chFecha.Text = "Fecha"
        Me.chFecha.UseVisualStyleBackColor = True
        '
        'tabseleccion
        '
        Me.tabseleccion.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tabseleccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabseleccion.Controls.Add(Me.TabPage1)
        Me.tabseleccion.Controls.Add(Me.TabPage2)
        Me.tabseleccion.Controls.Add(Me.TabPage3)
        Me.tabseleccion.Controls.Add(Me.TabPage4)
        Me.tabseleccion.Controls.Add(Me.TabPage5)
        Me.tabseleccion.Location = New System.Drawing.Point(6, 26)
        Me.tabseleccion.Name = "tabseleccion"
        Me.tabseleccion.SelectedIndex = 0
        Me.tabseleccion.Size = New System.Drawing.Size(480, 223)
        Me.tabseleccion.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.mntFecha)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(472, 197)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Fecha"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstSemanas)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(472, 197)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Semana"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstSemanas
        '
        Me.lstSemanas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstSemanas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstSemanas.FormattingEnabled = True
        Me.lstSemanas.Location = New System.Drawing.Point(3, 3)
        Me.lstSemanas.Name = "lstSemanas"
        Me.lstSemanas.Size = New System.Drawing.Size(466, 191)
        Me.lstSemanas.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lstAñoMes)
        Me.TabPage3.Controls.Add(Me.lstMes)
        Me.TabPage3.Location = New System.Drawing.Point(4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(472, 197)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Mes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lstAñoMes
        '
        Me.lstAñoMes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstAñoMes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstAñoMes.FormattingEnabled = True
        Me.lstAñoMes.Location = New System.Drawing.Point(363, 3)
        Me.lstAñoMes.Name = "lstAñoMes"
        Me.lstAñoMes.Size = New System.Drawing.Size(106, 182)
        Me.lstAñoMes.TabIndex = 3
        '
        'lstMes
        '
        Me.lstMes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstMes.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstMes.FormattingEnabled = True
        Me.lstMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.lstMes.Location = New System.Drawing.Point(0, 0)
        Me.lstMes.Name = "lstMes"
        Me.lstMes.Size = New System.Drawing.Size(106, 197)
        Me.lstMes.TabIndex = 2
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.lstAño)
        Me.TabPage4.Location = New System.Drawing.Point(4, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(472, 197)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Año"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'lstAño
        '
        Me.lstAño.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstAño.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAño.FormattingEnabled = True
        Me.lstAño.Location = New System.Drawing.Point(0, 0)
        Me.lstAño.Name = "lstAño"
        Me.lstAño.Size = New System.Drawing.Size(472, 197)
        Me.lstAño.TabIndex = 3
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Controls.Add(Me.Label1)
        Me.TabPage5.Controls.Add(Me.dtHasta)
        Me.TabPage5.Controls.Add(Me.dtDesde)
        Me.TabPage5.Location = New System.Drawing.Point(4, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(472, 197)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "D-H"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hasta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desde"
        '
        'dtHasta
        '
        Me.dtHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtHasta.Location = New System.Drawing.Point(3, 57)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(110, 20)
        Me.dtHasta.TabIndex = 4
        '
        'dtDesde
        '
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(3, 18)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(110, 20)
        Me.dtDesde.TabIndex = 3
        '
        'ucFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabseleccion)
        Me.Controls.Add(Me.chFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Name = "ucFecha"
        Me.Size = New System.Drawing.Size(489, 249)
        Me.tabseleccion.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFecha As Label
    Friend WithEvents mntFecha As MonthCalendar
    Friend WithEvents chFecha As CheckBox
    Friend WithEvents tabseleccion As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lstSemanas As ListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lstAñoMes As ListBox
    Friend WithEvents lstMes As ListBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents lstAño As ListBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtHasta As DateTimePicker
    Friend WithEvents dtDesde As DateTimePicker
End Class
