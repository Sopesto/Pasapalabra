<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Me.logo = New System.Windows.Forms.PictureBox
        Me.puntajes = New System.Windows.Forms.PictureBox
        Me.sonido = New Pasapalabra.botonSonido
        Me.comoJugar = New System.Windows.Forms.PictureBox
        Me.jugar = New System.Windows.Forms.PictureBox
        Me.salir = New System.Windows.Forms.PictureBox
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puntajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comoJugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.logo.Enabled = False
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(470, 194)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 3
        Me.logo.TabStop = False
        '
        'puntajes
        '
        Me.puntajes.BackColor = System.Drawing.Color.Transparent
        Me.puntajes.Location = New System.Drawing.Point(327, 226)
        Me.puntajes.Name = "puntajes"
        Me.puntajes.Size = New System.Drawing.Size(100, 50)
        Me.puntajes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.puntajes.TabIndex = 5
        Me.puntajes.TabStop = False
        '
        'sonido
        '
        Me.sonido.Location = New System.Drawing.Point(432, 328)
        Me.sonido.Name = "sonido"
        Me.sonido.Size = New System.Drawing.Size(60, 60)
        Me.sonido.TabIndex = 4
        '
        'comoJugar
        '
        Me.comoJugar.BackColor = System.Drawing.Color.Transparent
        Me.comoJugar.Location = New System.Drawing.Point(372, 283)
        Me.comoJugar.Name = "comoJugar"
        Me.comoJugar.Size = New System.Drawing.Size(100, 50)
        Me.comoJugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.comoJugar.TabIndex = 6
        Me.comoJugar.TabStop = False
        '
        'jugar
        '
        Me.jugar.BackColor = System.Drawing.Color.Transparent
        Me.jugar.Location = New System.Drawing.Point(98, 238)
        Me.jugar.Name = "jugar"
        Me.jugar.Size = New System.Drawing.Size(100, 50)
        Me.jugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.jugar.TabIndex = 7
        Me.jugar.TabStop = False
        '
        'salir
        '
        Me.salir.BackColor = System.Drawing.Color.Transparent
        Me.salir.Location = New System.Drawing.Point(193, 306)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(100, 50)
        Me.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.salir.TabIndex = 8
        Me.salir.TabStop = False
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(494, 390)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.jugar)
        Me.Controls.Add(Me.comoJugar)
        Me.Controls.Add(Me.puntajes)
        Me.Controls.Add(Me.sonido)
        Me.Controls.Add(Me.logo)
        Me.Name = "inicio"
        Me.Text = "Pasapalabra"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puntajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comoJugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents sonido As Pasapalabra.botonSonido
    Friend WithEvents puntajes As System.Windows.Forms.PictureBox
    Friend WithEvents comoJugar As System.Windows.Forms.PictureBox
    Friend WithEvents jugar As System.Windows.Forms.PictureBox
    Friend WithEvents salir As System.Windows.Forms.PictureBox

End Class
