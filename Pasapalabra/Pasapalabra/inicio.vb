Public Class inicio

    'Función que se llama cuando se dispara el evento click en el pictureBox "salir"
    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.MouseClick
        'Instrucción que detiene la ejecución del programa. Cierra el juego.
        End
    End Sub

    'Función que se llama cuando se dispara el evento click en el pictureBox "jugar"
    Private Sub Jugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jugar.MouseClick
        'Muestra el formulario de juego
        juego.Show()
        'Oculta este formulario
        Me.Hide()
    End Sub

    'Función que se llama cuando se dispara el evento load en el "formulario"
    Private Sub inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Llama a la función setStyle del formulario actual, la cual recibe como parámetros los tipos de estilos que se le aplicaran al control
        'los cuales son: doble buffer para el dibujado, tomar el control del dibujado del formulario y no limpiar el fondo del formulario al pintar.
        'Y también recibe el estado que se le quiere dar a estos estilos(verdadero o falso)  
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        'Cambia el icono del formulario
        Me.Icon = New Icon(rutaImagenes & "icono.ico")
        'Le asigna a la propiedad formBorderStyle del formulario actual el valor none, lo cual genera que la ventana no tenga el marco superior
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Le asigna a la propiedad windowState del formulario actual el estado maximizado, o sea, pantalla completa
        Me.WindowState = FormWindowState.Maximized
        'Le asigna a la propiedad enabled del formulario actual el valor true, por lo que se vuelve interactuable por el usuario
        Me.Enabled = True
        'Asignación de tamaño y ubicación de los controles del formulario
        'Le da tamaño al logo
        logo.Size = New Size(ancho / 1.8, alto / 1.8)
        'Ubica al logo en el formulario
        logo.Location = medio - New Point(logo.Width / 2 - 15, logo.Height / 2 + 130)
        'Le da tamaño al botón jugar
        jugar.Size = New Size(ancho / 3, 80)
        'Ubica al botón jugar en el formulario
        jugar.Location = New Point((ancho / 2) - (jugar.Width / 2), (logo.Height + logo.Location.Y) + 50)
        'Ubica al botón sonido en el formulario
        sonido.Location = New Point(ancho - sonido.Width - 10, 10)
        'Le da tamaño al botón salir
        salir.Size = New Size(ancho / 4, 80)
        'Ubica al botón salir en el formulario
        salir.Location = New Point(medio.X - (salir.Width / 2), jugar.Location.Y + jugar.Height + 60)
        'Le da tamaño al botón puntajes
        puntajes.Size = New Size(ancho / 4, 80)
        'Ubica al botón puntajes en el formulario
        puntajes.Location = New Point((ancho - puntajes.Width) - 20, salir.Location.Y)
        'Le da tamaño al botón comoJugar
        comoJugar.Size = New Size(ancho / 4, 80)
        'Ubica al botón comoJugar en el formulario
        comoJugar.Location = New Point(20, salir.Location.Y)
        'Le asigna a la propiedad backgroundImageLayout(disposición de la imagen de fondo) al formulario actual el valor stretch, lo que genera
        'Que la imagen del formulario se ajuste al tamaño del mismo
        Me.BackgroundImageLayout = ImageLayout.Stretch
        'Le asigna a la propiedad backgroundImage(imagen de fondo) del formulario actual una imágen cargada desde un archivo, el cual el nombre está definido por la variable
        'rutaImagenes que contiene la dirección de las imágenes del proyecto y un string literal con el nombre del archivo.
        Me.BackgroundImage = Image.FromFile(rutaImagenes & "fondo.png")
        'Le asigna a la propiedad Image(imagen) de los objetos una imágen cargada desde un archivo, el cual el nombre está definido por la variable
        'rutaImagenes que contiene la dirección de las imágenes del proyecto y un string literal con el nombre de la carpeta y el archivo.
        logo.Image = Image.FromFile(rutaImagenes & "logo.png")
        puntajes.Image = Image.FromFile(rutaImagenes & "botones\p.png")
        jugar.Image = Image.FromFile(rutaImagenes & "botones\j.png")
        salir.Image = Image.FromFile(rutaImagenes & "botones\s.png")
        comoJugar.Image = Image.FromFile(rutaImagenes & "botones\cj.png")
    End Sub

    'Función que se llama cuando se dispara el evento click en el pictureBox "puntajes"
    Private Sub puntajes_Click(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles puntajes.MouseClick
        'Llama a la función Show del formulario puntuaciones para mostrarlo
        puntuaciones.Show()
        'Llama a la funcion Hide del formulario actual para ocultarlo
        Me.Hide()
    End Sub

    'Función que se llama cuando se dispara el evento mouseEnter(el puntero del mouse entra en el area del objeto) en el pictureBox "puntajes"
    Private Sub puntajes_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles puntajes.MouseEnter
        'Le asigna a la propiedad Image(imagen) del objeto puntajes una imágen cargada desde un archivo, el cual el nombre está definido por la variable
        'rutaImagenes que contiene la dirección de las imágenes del proyecto y un string literal con el nombre de la carpeta y el archivo.
        puntajes.Image = Image.FromFile(rutaImagenes & "botones\ps.png")
    End Sub

    'Función que se llama cuando se dispara el evento mouseLeave(el puntero del mouse sale del area del objeto) en el pictureBox "puntajes"
    Private Sub puntajes_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles puntajes.MouseLeave
        'Le asigna a la propiedad Image(imagen) del objeto puntajes una imágen cargada desde un archivo, el cual el nombre está definido por la variable
        'rutaImagenes que contiene la dirección de las imágenes del proyecto y un string literal con el nombre de la carpeta y el archivo.
        puntajes.Image = Image.FromFile(rutaImagenes & "botones\p.png")
    End Sub

    'Función que se llama cuando se dispara el evento mouseEnter(el puntero del mouse entra en el area del objeto) en el pictureBox "comoJugar"
    Private Sub comoJugar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles comoJugar.MouseEnter
        'Le asigna a la propiedad Image(imagen) del objeto comoJugar una imágen cargada desde un archivo, el cual el nombre está definido por la variable
        'rutaImagenes que contiene la dirección de las imágenes del proyecto y un string literal con el nombre de la carpeta y el archivo.
        comoJugar.Image = Image.FromFile(rutaImagenes & "botones\cjs.png")
    End Sub

    'Función que se llama cuando se dispara el evento mouseLeave(el puntero del mouse sale del area del objeto) en el pictureBox "comoJugar"
    Private Sub comoJugar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles comoJugar.MouseLeave
        'Le asigna a la propiedad Image(imagen) del objeto comoJugar una imágen cargada desde un archivo, el cual el nombre está definido por la variable
        'rutaImagenes que contiene la dirección de las imágenes del proyecto y un string literal con el nombre de la carpeta y el archivo.
        comoJugar.Image = Image.FromFile(rutaImagenes & "botones\cj.png")
    End Sub

    'Función que se llama cuando se dispara el evento mouseEnter(el puntero del mouse entra en el area del objeto) en el pictureBox "salir"
    Private Sub salir_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles salir.MouseEnter
        'Le asigna a la propiedad Image(imagen) del objeto salir una imágen cargada desde un archivo, el cual el nombre está definido por la variable
        'rutaImagenes que contiene la dirección de las imágenes del proyecto y un string literal con el nombre de la carpeta y el archivo.
        salir.Image = Image.FromFile(rutaImagenes & "botones\ss.png")
    End Sub

    'Función que se llama cuando se dispara el evento mouseLeave(el puntero del mouse sale del area del objeto) en el pictureBox "salir"
    Private Sub salir_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles salir.MouseLeave
        'Le asigna a la propiedad Image(imagen) del objeto salir una imágen cargada desde un archivo, el cual el nombre está definido por la variable
        'rutaImagenes que contiene la dirección de las imágenes del proyecto y un string literal con el nombre de la carpeta y el archivo.
        salir.Image = Image.FromFile(rutaImagenes & "botones\s.png")
    End Sub

    'Función que se llama cuando se dispara el evento mouseEnter(el puntero del mouse entra en el area del objeto) en el pictureBox "jugar"
    Private Sub jugar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles jugar.MouseEnter
        'Le asigna a la propiedad Image(imagen) del objeto jugar una imágen cargada desde un archivo, el cual el nombre está definido por la variable
        'rutaImagenes que contiene la dirección de las imágenes del proyecto y un string literal con el nombre de la carpeta y el archivo.
        jugar.Image = Image.FromFile(rutaImagenes & "botones\js.png")
    End Sub

    'Función que se llama cuando se dispara el evento mouseLeave(el puntero del mouse sale del area del objeto) en el pictureBox "jugar"
    Private Sub jugar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles jugar.MouseLeave
        'Le asigna a la propiedad Image(imagen) del objeto jugar una imágen cargada desde un archivo, el cual el nombre está definido por la variable
        'rutaImagenes que contiene la dirección de las imágenes del proyecto y un string literal con el nombre de la carpeta y el archivo.
        jugar.Image = Image.FromFile(rutaImagenes & "botones\j.png")
    End Sub

    'Función que se llama cuando se dispara el evento click en el pictureBox "comoJugar"
    Private Sub comoJugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comoJugar.Click
        'Llama a la función Show del formulario puntuaciones para mostrarlo
        My.Forms.comoJugar.Show()
        'Llama a la funcion Hide del formulario actual para ocultarlo
        Me.Hide()
    End Sub
End Class
