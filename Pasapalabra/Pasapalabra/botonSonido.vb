Public Class botonSonido
    'Función del evento "click" de este control, que se llama cada vez que se hace click en el mismo
    Private Sub sonido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sonido.Click
        'Asigna a la variable hayVolumen su estado opuesto, indicando el cambio de estado del control
        hayVolumen = Not hayVolumen
        'Llama a la función declarada debajo que verifica si hay sonido
        verificarVolumen()
    End Sub
    'Constructor de este control
    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        verificarVolumen()
    End Sub

    'Función que verifica si el volumen está prendido y modifica las propiedades del botón y del sonido
    Private Sub verificarVolumen()
        'Condicional que verifica la variable que indica si el volumen está prendido
        If hayVolumen Then
            'Cambia la imagen de este control por una de "audio encendido"
            sonido.Image = Image.FromFile(rutaImagenes & "audio-on.png")
            'Llama a la función que reproduce el sonido
            reproducir()
        Else
            'Cambia la imagen de este control por una de "audio apagado"
            sonido.Image = Image.FromFile(rutaImagenes & "no-audio.png")
            'Llama a la función que detiene el sonido 
            pausar()
        End If
    End Sub
End Class
