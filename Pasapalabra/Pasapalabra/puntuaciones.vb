Public Class puntuaciones
    'Tamaño de la tabla
    Private tamTabla As Integer

    'Función que se llama cuando carga el formulario actual
    Private Sub puntuaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Colección de cada fila de la tabla
        Dim items() As ListViewItem
        'Llama a la función setStyle del formulario actual, la cual recibe como parámetros los tipos de estilos que se le aplicaran al control
        'los cuales son: doble buffer para el dibujado, tomar el control del dibujado del formulario y no limpiar el fondo del formulario al pintar.
        'Y también recibe el estado que se le quiere dar a estos estilos(verdadero o falso)  
        Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint, True)
        'Cambia el icono del formulario
        Me.Icon = New Icon(rutaImagenes & "icono.ico")
        'Ajusta el tamaño de las columnas al tamaño del contenido de su encabezado
        tablaPuntaje.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        'Asigna a la colección de filas los datos de los puntajes acomodados por puntaje
        items = datosTabla(acomodarPos())
        'Bucle que itera por la cantidad de filas
        For i As Integer = items.Length - 1 To 0 Step -1
            'Añade al contenedor tabla cada una de las filas
            tablaPuntaje.Items.Add(items(i))
        Next
        'Ajusta el tamaño de la columna nombre por el contenido de su columna
        tablaPuntaje.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        'Bucle que itera por cada columna de la tabla
        For index As Integer = 0 To tablaPuntaje.Columns.Count - 1
            'Ajusta el tamaño de la tabla a la suma del tamaño de todas sus columnas
            tamTabla = tamTabla + tablaPuntaje.Columns.Item(index).Width
        Next
        'Le asigna a la propiedad formBorderStyle del formulario actual el valor none, lo cual genera que la ventana no tenga el marco superior
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Le asigna a la propiedad windowState del formulario actual el estado maximizado, o sea, pantalla completa
        Me.WindowState = FormWindowState.Maximized
        'Le asigna a la propiedad enabled del formulario actual el valor true, por lo que se vuelve interactuable por el usuario
        Me.Enabled = True
        'Ajusta el tamaño y posición de la tabla en el formulario
        tablaPuntaje.Size = New Size(tamTabla + 5, alto - sonido.Height * 4 - 10)
        tablaPuntaje.Location = medio - New Point(tablaPuntaje.Width / 2, tablaPuntaje.Height / 2)
        'Ajusta la posición del sonido en el formulario
        sonido.Location = New Point(ancho - sonido.Width - 10, 10)
        'Ajusta la posición del botón volverInicio en el formulario
        volverInicio.Location = New Point(10, alto - volverInicio.Height - 10)
        'Asigna la imagen de fondo al formulario y la adapta al mismo
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = Image.FromFile(rutaImagenes & "fondo.png")
        'Asigna la imagen correspondiente al botón volverInicio
        volverInicio.Image = Image.FromFile(rutaImagenes & "\botones\volver.png")
    End Sub

    'Función del evento click del botón volverInicio, vuelve al formulario principal
    Private Sub volverInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volverInicio.Click
        'Llama a la función que muestra el formulario principal
        inicio.Show()
        'Libera todos los recursos de este formulario
        Me.Dispose()
    End Sub
End Class