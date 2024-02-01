<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comoJugar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.volverInicio = New System.Windows.Forms.PictureBox
        Me.sonido = New Pasapalabra.botonSonido
        CType(Me.volverInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'volverInicio
        '
        Me.volverInicio.Location = New System.Drawing.Point(40, 313)
        Me.volverInicio.Name = "volverInicio"
        Me.volverInicio.Size = New System.Drawing.Size(100, 50)
        Me.volverInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.volverInicio.TabIndex = 4
        Me.volverInicio.TabStop = False
        '
        'sonido
        '
        Me.sonido.Location = New System.Drawing.Point(547, 12)
        Me.sonido.Name = "sonido"
        Me.sonido.Size = New System.Drawing.Size(60, 60)
        Me.sonido.TabIndex = 0
        '
        'comoJugar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(619, 432)
        Me.Controls.Add(Me.volverInicio)
        Me.Controls.Add(Me.sonido)
        Me.Name = "comoJugar"
        Me.Text = "comoJugar"
        CType(Me.volverInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sonido As Pasapalabra.botonSonido
    Friend WithEvents volverInicio As System.Windows.Forms.PictureBox
End Class
