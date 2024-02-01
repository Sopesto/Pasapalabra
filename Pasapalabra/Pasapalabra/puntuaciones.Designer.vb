<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class puntuaciones
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
        Me.tablaPuntaje = New System.Windows.Forms.ListView
        Me.posicion = New System.Windows.Forms.ColumnHeader
        Me.nombre = New System.Windows.Forms.ColumnHeader
        Me.correctas = New System.Windows.Forms.ColumnHeader
        Me.incorrectas = New System.Windows.Forms.ColumnHeader
        Me.sinResponder = New System.Windows.Forms.ColumnHeader
        Me.tiempo = New System.Windows.Forms.ColumnHeader
        Me.sonido = New Pasapalabra.botonSonido
        Me.volverInicio = New System.Windows.Forms.PictureBox
        CType(Me.volverInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tablaPuntaje
        '
        Me.tablaPuntaje.BackColor = System.Drawing.SystemColors.HotTrack
        Me.tablaPuntaje.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.posicion, Me.nombre, Me.correctas, Me.incorrectas, Me.sinResponder, Me.tiempo})
        Me.tablaPuntaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tablaPuntaje.ForeColor = System.Drawing.SystemColors.Info
        Me.tablaPuntaje.GridLines = True
        Me.tablaPuntaje.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.tablaPuntaje.Location = New System.Drawing.Point(12, 26)
        Me.tablaPuntaje.Name = "tablaPuntaje"
        Me.tablaPuntaje.Size = New System.Drawing.Size(243, 97)
        Me.tablaPuntaje.TabIndex = 2
        Me.tablaPuntaje.UseCompatibleStateImageBehavior = False
        Me.tablaPuntaje.View = System.Windows.Forms.View.Details
        '
        'posicion
        '
        Me.posicion.Text = "Pos"
        '
        'nombre
        '
        Me.nombre.Text = "Nombre"
        Me.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'correctas
        '
        Me.correctas.Text = "Correctas"
        Me.correctas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'incorrectas
        '
        Me.incorrectas.Text = "Incorrectas "
        Me.incorrectas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sinResponder
        '
        Me.sinResponder.Text = "Sin Responder"
        Me.sinResponder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tiempo
        '
        Me.tiempo.Text = "Tiempo"
        Me.tiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sonido
        '
        Me.sonido.Location = New System.Drawing.Point(73, 170)
        Me.sonido.Name = "sonido"
        Me.sonido.Size = New System.Drawing.Size(60, 60)
        Me.sonido.TabIndex = 1
        '
        'volverInicio
        '
        Me.volverInicio.Location = New System.Drawing.Point(100, 50)
        Me.volverInicio.Name = "volverInicio"
        Me.volverInicio.Size = New System.Drawing.Size(100, 50)
        Me.volverInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.volverInicio.TabIndex = 3
        Me.volverInicio.TabStop = False
        '
        'puntuaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.volverInicio)
        Me.Controls.Add(Me.sonido)
        Me.Controls.Add(Me.tablaPuntaje)
        Me.Name = "puntuaciones"
        Me.Text = "puntuaciones"
        CType(Me.volverInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sonido As Pasapalabra.botonSonido
    Friend WithEvents tablaPuntaje As System.Windows.Forms.ListView
    Friend WithEvents nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents correctas As System.Windows.Forms.ColumnHeader
    Friend WithEvents sinResponder As System.Windows.Forms.ColumnHeader
    Friend WithEvents incorrectas As System.Windows.Forms.ColumnHeader
    Friend WithEvents posicion As System.Windows.Forms.ColumnHeader
    Friend WithEvents tiempo As System.Windows.Forms.ColumnHeader
    Friend WithEvents volverInicio As System.Windows.Forms.PictureBox
End Class
