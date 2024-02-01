Public Class juego
    'Elije la tematica
    Private tematica As Byte
    'Preguntas y respuestas
    Private preguntas(27), respuestas(27) As String
    'Manejador de gráficos
    Private g As Graphics
    'Nombre de archivos
    Private listaNombres As ObjectModel.ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetDirectories(rutaTextoJuego)
    'Posición X de los botones de las temáticas
    Private bx As Integer = 15
    'Posición Y de los botones de las temáticas
    Private by As Integer = medio.Y / 3
    'Tamaño de los botones de las temáticas
    Private btam As Byte

    'Función del evento load que se llama al cargar el formulario
    Private Sub juego_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Inicializa el generador de números aleatorios permitiendo que sea diferente el número obtenido al azar cada vez que se llama a esta función
        Randomize()
        'Pausa el narrador
        narrador.Pause()
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
        'Ubica el control que muestra el tiempo restante de juego
        tiempo.Location = New Point(medio.X - (tiempo.Width / 2), 0)
        'Ubica el control que maneja el sonido
        sonido.Location = New Point(ancho - sonido.Width - 10, 10)
        'Ubica la pregunta que se mostrará al iniciar el juego
        preguntaDeJuego.Location = New Point(medio.X - preguntaDeJuego.Width / 2, 10)
        'Ubica y dimensiona el gif que se muestra al empezar un juego nuevo
        preparado.SetBounds(0, 0, ancho, alto)
        'Dimensiona y ubica el cuadro de pregunta
        Pregunta.Size = New Size(ancho / 2 - 10, alto / 3)
        Pregunta.Location = New Point(10, alto - Pregunta.Height - 10)
        'Dimensiona y ubica la entrada de la respuesta del usuario
        Respuesta.Size = New Size(Pregunta.Width - 10, Font.Height)
        Respuesta.Location = New Point(medio.X + 10, Pregunta.Location.Y)
        'Dimensiona y ubica el botón de enviar respuesta
        enviar.Size = New Size(Respuesta.Width, Pregunta.Height / 2.5)
        enviar.Location = New Point(Respuesta.Location.X, Respuesta.Location.Y + Respuesta.Height + 20)
        'Dimensiona y ubica el botón pasapalabra
        pasapalabra.Size = New Size(enviar.Width / 1.73, alto - (enviar.Height + enviar.Location.Y) - 20)
        pasapalabra.Location = New Point(enviar.Location.X, enviar.Location.Y + enviar.Height + 10)
        'Dimensiona y ubica el botón de rendición del usuario
        rendirse.Size = New Size(enviar.Width / 2.47, alto - (enviar.Height + enviar.Location.Y) - 20)
        rendirse.Location = New Point(pasapalabra.Width + pasapalabra.Location.X + 10, pasapalabra.Location.Y)
        'Ubica los titulos de "Pregunta" y "Respuesta" en el formulario
        guiaPregunta.Location = New Point((Pregunta.Location.X + Pregunta.Width) / 2 - (guiaPregunta.Width / 2), Pregunta.Location.Y - guiaPregunta.Height)
        guiaRespuesta.Location = New Point((Respuesta.Location.X + Respuesta.Width / 2) - (guiaRespuesta.Width / 2), Respuesta.Location.Y - guiaRespuesta.Height)
        'Ubica el texto de la letra actual en el medio de la pantalla
        letraActual.Location = medio - New Point((Me.Height / 7), (Me.Height / 7))
        'Asgina la imagen fondo al formulario y la ajusta a su tamaño
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = Image.FromFile(rutaImagenes & "fondo.png")
        'Asigna su imagen correspondiente a cada botón
        rendirse.BackgroundImage = Image.FromFile(rutaImagenes & "botones\rendirse.png")
        pasapalabra.BackgroundImage = Image.FromFile(rutaImagenes & "botones\pasapalabra.png")
        enviar.BackgroundImage = Image.FromFile(rutaImagenes & "botones\enviar.png")
        'Asigna el tamaño de cada letra en el rosco
        tam = Me.Height / 18
        'Asigna el tamaño de los botones de tematicas
        btam = Me.Height / 6
        'Bucle que crea un botón por cada temática, además del botón que elige una temática aleatoria
        'En el mismo se asignan las propiedades correspondientes y se agregan a la lista de controles del formulario actual
        'Tambien se le asigna la función que va a manejar su evento click
        For i As Integer = 0 To listaNombres.Count
            Dim boton As New Button()
            boton.SetBounds(bx, by, btam * 2, btam)
            boton.Enabled = True
            boton.Visible = True
            boton.BackColor = Color.Black
            boton.ForeColor = Color.Lime
            boton.Font = New Font("monospace", Single.Parse(btam / 5), FontStyle.Regular)
            boton.CausesValidation = True
            AddHandler boton.Click, AddressOf preguntaDeJuego_Click
            boton.Name = "tematica" & i

            If i = listaNombres.Count Then
                boton.Text = "Aleatorio"
            Else
                boton.Text = listaNombres.Item(i).Substring(listaNombres.Item(i).LastIndexOf("\") + 1)
            End If

            Me.Controls.Add(boton)
            boton.BringToFront()
            bx += btam * 2 + 15

            If bx > btam * 9 Then
                bx = 15
                by += medio.Y / 3 + 20
            End If

        Next
    End Sub

    'Función que se llama cada vez que se dispare el evento "click" del botón preguntaDeJuego
    Private Sub preguntaDeJuego_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For i As Integer = 0 To listaNombres.Count

            If Me.Controls.Item(Me.Controls.IndexOfKey("tematica" & i)).Capture And i <> listaNombres.Count Then
                tematica = Val(Me.Controls.Item(Me.Controls.IndexOfKey("tematica" & i)).Name.Last())
            ElseIf Me.Controls.Item(Me.Controls.IndexOfKey("tematica" & i)).Capture And i = listaNombres.Count Then
                'Asigna a la variable tematica el número, elegido al azar, de la temática a mostrar
                tematica = Int(Rnd() * listaNombres.Count)
            End If

            Me.Controls.Item(Me.Controls.IndexOfKey("tematica" & i)).Dispose()
        Next
        'Libera los recursos del control preguntaDeJuego
        preguntaDeJuego.Dispose()
        'Asigna el gif al control que indicaq que empezará el juego
        preparado.Image = Image.FromFile(rutaImagenes & "empezar.gif")
        'Llama a la función que inicializa el juego
        iniciarJuego()
        'Inicia el contador de tiempo
        reloj.Start()
    End Sub

    'Función que se llama para iniciar el juego
    Private Sub iniciarJuego()
        'Establece de forma global el formulario de juego para ser usado de forma ágil por otros formularios
        establecerJuego(Me)
        'Carga las imagenes de las letras al proyecto
        cargarImagenes()
        'Inicia las letras en no preguntado
        iniciarLetras()
        'Bucle que itera por la cantidad de letras
        For index As Integer = 0 To 26
            'Asigna el tamaño a letra actual
            letras(index).Size = New Size(tam, tam)
            'Asigna la ubicación de la letra actual apartir de una formula trigonométrica 'Fuente: "Ej: Encuentra el punto en un círculo dado un ángulo y el radio"-(https://youtu.be/uAEwq3vBUnc?feature=shared)
            letras(index).Location = New Point(medio.X - 15, medio.Y / 1.5) + New Point(-(Me.Height / 4) * Math.Cos(ang * (index + 1) + (27 * 0.52)), -200 * Math.Sin(ang * (index + 1) + (27 * 0.52)))
        Next
        'Carga el texto de las temáticas al juego
        cargarTexto(preguntas, respuestas, listaNombres(tematica))
        'Escribe la primera pregunta
        escribirPregunta(Pregunta, preguntas, letraActual, Respuesta)
        'Crea el controlador de los gráficos del formulario actual
        g = Me.CreateGraphics()
        'Asigna a la variable iniciado el estado true, indicando que el juego ya empezó
        iniciado = True
    End Sub

    'Función del evento que se llama cada vez que el evento tick del timer reloj se llama(1 segundo)
    Private Sub reloj_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reloj.Tick

        'Decrementa la variable segundo en uno
        segundos = segundos - 1
        'Condicional que pregunta cuando pasaron 3s desde que se inició el timer para dar comienzo al juego
        If segundos = 420 Then
            'Despausa el narrador
            narrador.Resume()
            'Libera los recursos del control que contiene el gif de empezar
            preparado.Dispose()
        End If
        'Condicional que pregunta si segundos es múltiplo de 60 para agregar, o no, un 0 al comienzo
        If (segundos Mod 60 < 10) Then
            'Escribe el tiempo en formato mm:ss agregandole un 0 en los 
            tiempo.Text = Int(segundos / 60) & ":0" & (segundos Mod 60)
        Else
            'Escribe el tiempo en formato mm:ss 
            tiempo.Text = Int(segundos / 60) & ":" & (segundos Mod 60)
        End If
        'Condicional que revisa si terminó el tiempo de juego
        If segundos = 0 Then
            'Frena el timer del juego
            reloj.Stop()
            'Llama a la función que finaliza el juego
            final()
        Else
            'Ajusta el color del reloj, de manera que mientras menos tiempo quede más rojo se pone
            tiempo.BackColor = Color.FromArgb(255, 250, 255 - Math.Pow(2, ((255 - (segundos / 2)) * 0.03)), 255 - Math.Pow(2, ((255 - segundos / 2) * 0.03)))
        End If
    End Sub

    'Función del evento click, que se llama cada vez que presionan el botón rendirse
    Private Sub rendirse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rendirse.Click
        'Frena el timer del juego
        reloj.Stop()
        'Crea una variable que recibe la respuesta de una ventana emergente que pretende confirmar la opción de rendición
        Dim rsp As MsgBoxResult = MsgBox("¿Realmente desea rendirse?", MsgBoxStyle.YesNo, "Rendición")
        'Condicional que verifica la respuesta del usuario a la pregunta anterior
        If rsp = MsgBoxResult.Yes Then
            'Llama a la función que finaliza el juego
            final()
        Else
            'Reanuda el timer del juego
            reloj.Start()
        End If
    End Sub

    'Función del evento click, que se llama cada vez que presionan el botón enviar
    Private Sub enviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enviar.Click
        'Comprueba si la narración no se completó
        If Not narrador.GetCurrentlySpokenPrompt.IsCompleted Then
            'Cancela la narración actual para que no se junte con la siguiente
            narrador.SpeakAsyncCancel(narrador.GetCurrentlySpokenPrompt)
        End If
        'Llama a la función que comprueba si la respuesta enviada por el usuario es correcta
        comprobarRespuesta(Respuesta.Text, respuestas)
        'Llama a la función que escribe la siguiente pregunta
        escribirPregunta(Pregunta, preguntas, letraActual, Respuesta)
        'Llama a la función que dibuja las letras
        dibujarCorrespondientes(g)
    End Sub

    'Función del evento keyUp, que se llama cada vez que se suelta una tecla presionada en control respuesta
    Private Sub Respuesta_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Respuesta.KeyUp
        'Condicional que verifica si se presionó la tecla "Enter"
        If e.KeyCode = Keys.Enter Then
            'Hace click en el botón enviar
            enviar.PerformClick()
        End If
    End Sub

    'Función del evento click, que se llama cada vez que presionan el botón pasapalabra
    Private Sub pasapalabra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pasapalabra.Click
        'Comprueba si la narración no se completó
        If Not narrador.GetCurrentlySpokenPrompt.IsCompleted Then
            'Cancela la narración actual para que no se junte con la siguiente
            narrador.SpeakAsyncCancel(narrador.GetCurrentlySpokenPrompt)
        End If
        'Llama a la función que aumenta el indice de letras por lo que hace referencia la siguiente
        aumentarIndice()
        'Llama a la función que escribe la siguiente pregunta
        escribirPregunta(Pregunta, preguntas, letraActual, Respuesta)
        'Llama a la función que dibuja las letras
        dibujarCorrespondientes(g)
    End Sub

    'Función del evento paint, que se llama cada vez que se dibuja el formulario
    Private Sub juego_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        'Condicional que verifica si el juego fue iniciado
        If iniciado Then
            'Llama a la función que dibuja las letras
            dibujarCorrespondientes(g)
        End If
    End Sub
End Class