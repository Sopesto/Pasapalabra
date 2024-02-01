<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class botonSonido
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
        Me.sonido = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'sonido
        '
        Me.sonido.Location = New System.Drawing.Point(0, 0)
        Me.sonido.Name = "sonido"
        Me.sonido.Padding = New System.Windows.Forms.Padding(5)
        Me.sonido.Size = New System.Drawing.Size(60, 60)
        Me.sonido.TabIndex = 0
        Me.sonido.UseVisualStyleBackColor = True
        '
        'botonSonido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.sonido)
        Me.Name = "botonSonido"
        Me.Size = New System.Drawing.Size(60, 60)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sonido As System.Windows.Forms.Button

End Class
