<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class juego
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
        Me.components = New System.ComponentModel.Container
        Me.Pregunta = New System.Windows.Forms.Label
        Me.enviar = New System.Windows.Forms.Button
        Me.pasapalabra = New System.Windows.Forms.Button
        Me.rendirse = New System.Windows.Forms.Button
        Me.Respuesta = New System.Windows.Forms.TextBox
        Me.reloj = New System.Windows.Forms.Timer(Me.components)
        Me.tiempo = New System.Windows.Forms.Label
        Me.preguntaDeJuego = New System.Windows.Forms.Label
        Me.guiaRespuesta = New System.Windows.Forms.Label
        Me.guiaPregunta = New System.Windows.Forms.Label
        Me.letraActual = New System.Windows.Forms.Label
        Me.preparado = New System.Windows.Forms.PictureBox
        Me.sonido = New Pasapalabra.botonSonido
        CType(Me.preparado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pregunta
        '
        Me.Pregunta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pregunta.Cursor = System.Windows.Forms.Cursors.Help
        Me.Pregunta.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pregunta.ForeColor = System.Drawing.Color.OrangeRed
        Me.Pregunta.Location = New System.Drawing.Point(12, 342)
        Me.Pregunta.Name = "Pregunta"
        Me.Pregunta.Size = New System.Drawing.Size(370, 110)
        Me.Pregunta.TabIndex = 0
        '
        'enviar
        '
        Me.enviar.BackColor = System.Drawing.Color.White
        Me.enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.enviar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.enviar.FlatAppearance.BorderSize = 0
        Me.enviar.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviar.ForeColor = System.Drawing.Color.White
        Me.enviar.Location = New System.Drawing.Point(388, 376)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(234, 35)
        Me.enviar.TabIndex = 1
        Me.enviar.UseVisualStyleBackColor = False
        '
        'pasapalabra
        '
        Me.pasapalabra.BackColor = System.Drawing.Color.White
        Me.pasapalabra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pasapalabra.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pasapalabra.ForeColor = System.Drawing.Color.White
        Me.pasapalabra.Location = New System.Drawing.Point(388, 417)
        Me.pasapalabra.Name = "pasapalabra"
        Me.pasapalabra.Size = New System.Drawing.Size(147, 33)
        Me.pasapalabra.TabIndex = 2
        Me.pasapalabra.UseVisualStyleBackColor = False
        '
        'rendirse
        '
        Me.rendirse.BackColor = System.Drawing.Color.White
        Me.rendirse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rendirse.FlatAppearance.BorderSize = 2
        Me.rendirse.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rendirse.ForeColor = System.Drawing.Color.White
        Me.rendirse.Location = New System.Drawing.Point(541, 417)
        Me.rendirse.Name = "rendirse"
        Me.rendirse.Size = New System.Drawing.Size(81, 33)
        Me.rendirse.TabIndex = 3
        Me.rendirse.UseVisualStyleBackColor = False
        '
        'Respuesta
        '
        Me.Respuesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Respuesta.Location = New System.Drawing.Point(388, 342)
        Me.Respuesta.Name = "Respuesta"
        Me.Respuesta.Size = New System.Drawing.Size(233, 62)
        Me.Respuesta.TabIndex = 4
        '
        'reloj
        '
        Me.reloj.Interval = 1000
        '
        'tiempo
        '
        Me.tiempo.BackColor = System.Drawing.Color.White
        Me.tiempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiempo.Location = New System.Drawing.Point(0, 0)
        Me.tiempo.Name = "tiempo"
        Me.tiempo.Size = New System.Drawing.Size(130, 47)
        Me.tiempo.TabIndex = 5
        Me.tiempo.Text = "0:00"
        Me.tiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'preguntaDeJuego
        '
        Me.preguntaDeJuego.BackColor = System.Drawing.Color.Black
        Me.preguntaDeJuego.Font = New System.Drawing.Font("Segoe UI Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preguntaDeJuego.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.preguntaDeJuego.Location = New System.Drawing.Point(0, 0)
        Me.preguntaDeJuego.Name = "preguntaDeJuego"
        Me.preguntaDeJuego.Size = New System.Drawing.Size(610, 111)
        Me.preguntaDeJuego.TabIndex = 7
        Me.preguntaDeJuego.Text = "Elija una temática"
        Me.preguntaDeJuego.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'guiaRespuesta
        '
        Me.guiaRespuesta.AutoSize = True
        Me.guiaRespuesta.BackColor = System.Drawing.Color.Transparent
        Me.guiaRespuesta.Font = New System.Drawing.Font("Alef", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guiaRespuesta.ForeColor = System.Drawing.Color.DarkGreen
        Me.guiaRespuesta.Location = New System.Drawing.Point(0, 0)
        Me.guiaRespuesta.Name = "guiaRespuesta"
        Me.guiaRespuesta.Size = New System.Drawing.Size(136, 32)
        Me.guiaRespuesta.TabIndex = 10
        Me.guiaRespuesta.Text = "Respuesta"
        '
        'guiaPregunta
        '
        Me.guiaPregunta.AutoSize = True
        Me.guiaPregunta.BackColor = System.Drawing.Color.Transparent
        Me.guiaPregunta.Font = New System.Drawing.Font("Alef", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guiaPregunta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.guiaPregunta.Location = New System.Drawing.Point(0, 0)
        Me.guiaPregunta.Name = "guiaPregunta"
        Me.guiaPregunta.Size = New System.Drawing.Size(123, 32)
        Me.guiaPregunta.TabIndex = 11
        Me.guiaPregunta.Text = "Pregunta"
        '
        'letraActual
        '
        Me.letraActual.AutoSize = True
        Me.letraActual.BackColor = System.Drawing.Color.Transparent
        Me.letraActual.Font = New System.Drawing.Font("Miriam Libre", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.letraActual.ForeColor = System.Drawing.Color.Black
        Me.letraActual.Location = New System.Drawing.Point(158, 237)
        Me.letraActual.Name = "letraActual"
        Me.letraActual.Size = New System.Drawing.Size(0, 32)
        Me.letraActual.TabIndex = 12
        '
        'preparado
        '
        Me.preparado.Location = New System.Drawing.Point(476, 130)
        Me.preparado.Name = "preparado"
        Me.preparado.Size = New System.Drawing.Size(100, 50)
        Me.preparado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.preparado.TabIndex = 13
        Me.preparado.TabStop = False
        '
        'sonido
        '
        Me.sonido.Location = New System.Drawing.Point(564, 173)
        Me.sonido.Name = "sonido"
        Me.sonido.Size = New System.Drawing.Size(60, 60)
        Me.sonido.TabIndex = 9
        '
        'juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(634, 462)
        Me.Controls.Add(Me.sonido)
        Me.Controls.Add(Me.preguntaDeJuego)
        Me.Controls.Add(Me.preparado)
        Me.Controls.Add(Me.tiempo)
        Me.Controls.Add(Me.guiaPregunta)
        Me.Controls.Add(Me.guiaRespuesta)
        Me.Controls.Add(Me.letraActual)
        Me.Controls.Add(Me.Respuesta)
        Me.Controls.Add(Me.rendirse)
        Me.Controls.Add(Me.pasapalabra)
        Me.Controls.Add(Me.enviar)
        Me.Controls.Add(Me.Pregunta)
        Me.Name = "juego"
        Me.Text = "Pasapalabra"
        CType(Me.preparado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pregunta As System.Windows.Forms.Label
    Friend WithEvents enviar As System.Windows.Forms.Button
    Friend WithEvents pasapalabra As System.Windows.Forms.Button
    Friend WithEvents rendirse As System.Windows.Forms.Button
    Friend WithEvents Respuesta As System.Windows.Forms.TextBox
    Friend WithEvents reloj As System.Windows.Forms.Timer
    Friend WithEvents tiempo As System.Windows.Forms.Label
    Friend WithEvents preguntaDeJuego As System.Windows.Forms.Label
    Friend WithEvents sonido As Pasapalabra.botonSonido
    Friend WithEvents guiaRespuesta As System.Windows.Forms.Label
    Friend WithEvents guiaPregunta As System.Windows.Forms.Label
    Friend WithEvents letraActual As System.Windows.Forms.Label
    Friend WithEvents preparado As System.Windows.Forms.PictureBox
End Class
