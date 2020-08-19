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
        Me.mntFecha.Location = New System.Drawing.Point(0, 32)
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
        'ucFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chFecha)
        Me.Controls.Add(Me.mntFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Name = "ucFecha"
        Me.Size = New System.Drawing.Size(253, 233)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFecha As Label
    Friend WithEvents mntFecha As MonthCalendar
    Friend WithEvents chFecha As CheckBox
End Class
