Public Class comoJugar

    'Función del evento click del botón volverInicio, vuelve al formulario principal
    Private Sub volverInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volverInicio.Click
        'Llama a la función que muestra el formulario principal
        inicio.Show()
        'Libera todos los recursos de este formulario
        Me.Dispose()
    End Sub

    'Función que se llama cuando carga el formulario actual
    Private Sub comoJugar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Le asigna a la propiedad formBorderStyle del formulario actual el valor none, lo cual genera que la ventana no tenga el marco superior
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Cambia el icono del formulario
        Me.Icon = New Icon(rutaImagenes & "icono.ico")
        'Le asigna a la propiedad windowState del formulario actual el estado maximizado, o sea, pantalla completa
        Me.WindowState = FormWindowState.Maximized
        'Le asigna a la propiedad enabled del formulario actual el valor true, por lo que se vuelve interactuable por el usuario
        Me.Enabled = True
        'Ajusta la posición del sonido en el formulario
        sonido.Location = New Point(ancho - sonido.Width - 10, 10)
        'Ajusta la posición del botón volverInicio en el formulario
        volverInicio.Location = New Point(10, alto - volverInicio.Height - 10)
        'Asigna la imagen de fondo al formulario y la adapta al mismo
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = Image.FromFile(rutaImagenes & "inst.png")
        'Asigna la imagen correspondiente al botón volverInicio
        volverInicio.Image = Image.FromFile(rutaImagenes & "\botones\volver.png")
    End Sub
End Class