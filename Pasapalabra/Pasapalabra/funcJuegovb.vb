Module funcJuegovb
    'Función para establecer el formulario de juego
    Public Sub establecerJuego(ByRef this As Form)
        'Asigna a la variable formJuego el formulario pasado por referencia
        formJuego = this
    End Sub

    'Función que carga las letras al juego
    Public Sub cargarImagenes()
        'Carga las imágenes con las letras azules
        For index As Integer = 0 To 26
            'Carga la imágen de la letra desde una ruta 
            letrasAzul(index) = (Image.FromFile(rutaImagenes & "letras\noPreguntado\" & abc(index) & ".png"))
        Next
        'Carga las imágenes con las letras amarillas
        For index As Integer = 0 To 26
            'Carga la imágen de la letra desde una ruta
            letrasAmarillo(index) = (Image.FromFile(rutaImagenes & "letras\preguntado\" & abc(index) & ".png"))
        Next
        'Carga las imágenes rojas
        For index As Integer = 0 To 26
            'Carga la imágen de la letra desde una ruta
            letrasRojo(index) = (Image.FromFile(rutaImagenes & "letras\incorrecto\" & abc(index) & ".png"))
        Next
        'Carga las imágenes verdes
        For index As Integer = 0 To 26
            'Carga la imágen de la letra desde una ruta
            letrasVerde(index) = (Image.FromFile(rutaImagenes & "letras\correcto\" & abc(index) & ".png"))
        Next
    End Sub

    'Función que carga las letras (Imagenes)
    Public Sub iniciarLetras()
        'Establece el indice de la letra actual en 0, o sea la primera, o sea la A
        indLetra = 0
        'Bucle que le asigna a cada letra el estado de "noPreguntado"
        For index As Integer = 0 To 26
            imgsLetras(index) = 1
        Next
    End Sub

    'Función que dibuja las letras de acuerdo a su estado actual
    Public Sub dibujarCorrespondientes(ByRef g As Graphics)
        'Hace un ciclo de repeticion llamado bucle, dibujando las letras mediante el indice asignado
        For index As Integer = 0 To 26
            'Revisa el estado de una letra y la dibuja en el color que le corresponde 
            Select Case imgsLetras(index)
                Case 1
                    g.DrawImage(letrasAzul(index), letras(index))
                Case 2
                    g.DrawImage(letrasAmarillo(index), letras(index))
                Case 3
                    g.DrawImage(letrasRojo(index), letras(index))
                Case 4
                    g.DrawImage(letrasVerde(index), letras(index))
            End Select
        Next
    End Sub

    'Función que aumenta el indice que indica la letra actual
    Public Sub aumentarIndice()
        'Condicional que revisa si se llegó al final del rosco
        If indLetra = 26 Then
            'Llama a la función vuelta que "reinicia" el rosco 
            vuelta()
        Else
            'Condicional que revisa si el estado de la letra no es "Incorrecto" o "Correcto"
            If imgsLetras(indLetra) < 2 Then
                'Le asigna a la letra actual el estado de preguntado
                imgsLetras(indLetra) = 2
                'Aumenta el indice que indica la letra actual
                indLetra = indLetra + 1
                'Condicional que comprueba si la siguiente letra fue preguntada
                If (imgsLetras(indLetra) + 1) > 2 Then
                    'Hace una recursión a la función
                    aumentarIndice()
                End If
            Else
                'Aumenta el indice que indica la letra actual
                indLetra = indLetra + 1
                'Hace una recursión a la función
                aumentarIndice()
            End If
        End If
    End Sub

    'Función que determina cuando se llega al final y reasigna el estado de las letras en ese momento
    Public Sub vuelta()
        'Bucle que recorre todas las letras desde el final
        For index As Integer = 26 To 0 Step -1
            'Condicional que comprueba si la letra actual tiene el estado "preguntada"
            If imgsLetras(index) = 2 Then
                'Asigna a la letra actual el estado "noPreguntado"
                imgsLetras(index) = 1
                'Asigna, al indice que indica la letra actual, la última letra con estado "preguntada"
                indLetra = index
            End If
        Next
        'Comprueba si no se llegó al final del juego (Todas las letras respondidas)
        comprobarFinal()
    End Sub

    'Función que comprueba la respuesta del usuario según la letra actual y las respuestas cargadas en el juego
    Public Sub comprobarRespuesta(ByVal resp As String, ByRef respuestas() As String)
        'Condicional que comprueba si la respuesta es correcta 
        If resp.ToUpper = respuestas(indLetra) Then
            'Le asigna a la letra actual el estado de "correcta"
            imgsLetras(indLetra) = 4
            'Asigna el sonido de que acertó la pregunta al audio
            sonidos.URL = rutaAudio & "acierto.wav"
        Else
            'Le asigna a la letra actual el estado de "incorrecta"
            imgsLetras(indLetra) = 3
            'Asigna el sonido de que falló la pregunta al audio
            sonidos.URL = rutaAudio & "desacierto.wav"
        End If
        'Condicional que verifica si está posicionado en la última letra
        If indLetra = 26 Then
            'Bucle que recorre las letras / misma funcionalidad que la función vuelta la cual no es posible aplicar acá
            For index As Integer = 26 To 0 Step -1
                If imgsLetras(index) = 2 Then
                    imgsLetras(index) = 1
                    indLetra = index
                End If
            Next
        Else
            'Bucle que "saltéa/esquiva" las letras que ya fueron respondidas
            While imgsLetras(indLetra) > 2 And indLetra < 27
                indLetra = indLetra + 1
            End While
        End If
        'Reproduce el sonido asignado cuando asierte o no
        sonidos.controls.play()
        'Llama a la función que comprueba el final del juego
        comprobarFinal()
    End Sub

    'Función que carga el texto de las preguntas y las respuestas al juego
    Public Sub cargarTexto(ByRef preguntas() As String, ByRef respuestas() As String, ByVal tematica As String)
        'Carga las preguntas
        preguntas = System.IO.File.ReadAllLines(tematica & "\preguntas.txt")
        'Carga las respuestas
        respuestas = System.IO.File.ReadAllLines(tematica & "\respuestas.txt")
    End Sub

    'Función que escribe la pregunta en su control correspondiente
    Public Sub escribirPregunta(ByRef pregunta As Label, ByRef preguntas() As String, ByRef letraActual As Label, ByRef respuesta As TextBox)
        'Condicional que verifica si se llegó al final del rosco
        If indLetra < 27 Then
            'Escribe en el control pregunta la pregunta actual
            pregunta.Text = preguntas(indLetra) & vbCrLf
            'Narra la pregunta
            narrador.SpeakAsync(preguntas(indLetra))
            'Escribe en el control la letra actual del juego
            letraActual.Text = "La letra actual es: " & abc(indLetra)
            'Limpia el control respuesta
            respuesta.Clear()
            'Pasa el foco al control respuesta
            respuesta.Focus()
        End If
    End Sub

    'Función que reproduce el sonido del juego
    Public Sub reproducir()
        'Pone al reproductor de sonido en el estado "reproducir"
        wmp.controls.play()
        'Le asigna al reproductor de sonido el atributo de "loop" en verdadero lo que genera que se reproduzca infinitamente
        wmp.settings.setMode("loop", True)
        'Le asigna al reproductor de sonido el atributo "volume" en 100 para que se escuche la pista de audio
        wmp.settings.volume = 100
        'Le asigna al reproductor de sonidos secundario el atributo "volume" en 100 para que se escuche la pista de audio 
        sonidos.settings.volume = 100
        'Condicional que verifica que la reproducción está apagada
        If Not reproduciendo Then
            'Le asigna la pista al reproductor de audio
            wmp.URL = rutaAudio & pista
            'Cambia el estado de reproducción a verdadero
            reproduciendo = True
        End If
    End Sub

    'Función que silencia los sonidos de los reproductores
    Public Sub pausar()
        'Le asigna al reproductor de sonido el atributo "volume" en 0 para que no se escuche la pista de audio
        wmp.settings.volume = 0
        'Le asigna al reproductor de sonido secundario el atributo "volume" en 0 para que no se escuche la pista de audio
        sonidos.settings.volume = 0
    End Sub

    'Función que cambia la pista actual por la pasada por parámetro
    Public Sub cambiarPista(ByVal nuevaPista As String)
        'Asigna la pista nueva
        pista = nuevaPista
        'Cambia el estado de reproduciendo a falso
        reproduciendo = False
    End Sub

    'Función que finaliza el juego
    Public Sub final()
        'Muestra el formulario principal
        inicio.Show()
        'Cambia el estado iniciado del juego a falso
        iniciado = False
        'Declara una variable a la que se le asigna el valor de la llamada a la función contarResultado 
        Dim res As String = contarResultado()
        'Comprueba si la respuesta de la función llamada anteriormente no es nula o vacía
        If Not (String.IsNullOrEmpty(res) Or res = "") Then
            'Añade el puntaje del jugador actual al final del archivo puntaje
            System.IO.File.AppendAllText(rutaPuntaje & "puntaje.txt", res & vbCrLf)
        End If
        'Reinicia el valor de la variable segundos
        segundos = 423
        'Cierra el formulario de juego
        formJuego.Close()
    End Sub

    'Función que cuenta el puntaje del usuario actual y lo devuelve en formato texto
    Public Function contarResultado() As String
        'Crea las variables que guardan la cantidad de aciertos, desaciertos y preguntas sin responder
        Dim correctas, incorrectas, sinResponder As Byte
        'Crea la variable que almacenará el texto a devolver por la función
        Dim final As String
        'Bucle que aumenta la cantidad de las variables mencionadas anteriormente según corresponda
        For index As Integer = 0 To 26
            'Switch que indentifica el estado en el que estaba la letra para posteriormente sumarle uno a su variable referente
            Select Case imgsLetras(index)
                Case 1, 2
                    sinResponder = sinResponder + 1
                Case 3
                    incorrectas = incorrectas + 1
                Case 4
                    correctas = correctas + 1
            End Select
        Next
        'Muestra al usuario el resultado obtenido
        MsgBox("Acertaste: " & correctas & ", Fallaste: " & incorrectas & ", No respondiste: " & sinResponder & ", Tiempo restante: " & segundos & "s.", MsgBoxStyle.Information, "Resultados")
        'Crea una variable nombre y le asigna el resultado de un InputBox en el que se le pregunta al usuario su nombre para registrar el record
        Dim nombre As String = InputBox("Ingrese su nombre", "Registrá tu record", "Jugador").Trim
        'Asigna en la variable de retorno el texto con el nombre y puntaje del jugador
        final = nombre & "," & correctas & "," & incorrectas & "," & sinResponder & "," & segundos
        'Condicional que comprueba si no se dió algún nombre
        If String.IsNullOrEmpty(nombre) Then
            'Devuelve un texto vacío
            Return ""
        End If

        'Devuelve la variable con el nombre y puntaje del jugador
        Return final
    End Function

    'Funcion que comprueba el final del juego
    Public Sub comprobarFinal()
        'Bucle que recorre las letras 
        For index As Integer = 0 To 26
            'Condicional que verifica si el estado de las letras es respuesto 
            If imgsLetras(index) <= 2 Then
                'Termina la ejecución de la función
                Return
            End If
        Next
        'Llama a la función final que termina el juego
        final()
    End Sub

    'Función que devuelve una lista ordenada de las filas con el puntaje
    Public Function acomodarPos() As List(Of String)()
        'Condicional que comprueba si no existe el archivo puntaje.txt
        If Not (System.IO.File.Exists(rutaPuntaje & "puntaje.txt")) Then
            'Crea el archivo de puntaje y lo cierra
            System.IO.File.Create(rutaPuntaje & "puntaje.txt").Close()
        End If
        'Declara un arreglo de strings que contendrá los puntajes
        Dim datos() As String
        'Le asigna al arregla datos todos los puntajes
        datos = System.IO.File.ReadAllLines(rutaPuntaje & "puntaje.txt")
        'Crea una lista de strings para guardar las posiciones
        Dim posiciones(datos.Length - 1) As List(Of String)
        'Crea una lista ordenada que contendrá todos los puntajes
        Dim datosFinal As New SortedList(Of Double, Integer)
        'Bucle que recorre los datos obtenidos del archivo de puntaje
        For i As Integer = 0 To datos.Length - 1
            'Variable auxiliar para almacenar las filas del puntaje para poder tratarlas con métodos
            Dim aux As String
            'Variable que almacena el índice del rango a tratar del texto de la variable aux
            Dim ind As Integer
            'Variable que almacena el total de puntos hechos por el usuario
            Dim sumTotal As Int64 = 0
            'Guarda en la variable aux el puntaje actual del índice
            aux = datos(i)
            'Bucle que recorre los datos del puntaje
            For j As Integer = 1 To 5
                'Guarda el índice del último caracter de los datos de puntaje del jugador actual
                ind = aux.Length - 1
                'Condicional que comprueba si la variable auxiliar contiene una coma
                If (aux.Contains(",")) Then
                    'Obtiene y almacena, en la variable ind, el indice de la primera coma que encuentre en el texto
                    ind = aux.IndexOf(",")
                    'Condcionales que comprueban la posición de los datos del personaje y dependiendo de la misma almacena los
                    'Puntos que obtuvo dependiendo el tipo de pregunta hecho.
                    If j = 1 Then
                        aux = aux.Remove(0, (ind + 1))
                        Continue For
                    ElseIf j = 2 Then
                        sumTotal = sumTotal + (Val(aux.Substring(0, ind)) * 7)
                    ElseIf j = 3 Then
                        sumTotal = sumTotal - (Val(aux.Substring(0, ind)) * 1)
                    Else
                        sumTotal = sumTotal + (Val(aux.Substring(0, ind)) * 0.05)
                    End If
                Else
                    sumTotal = sumTotal + ((Val(aux.Substring(0, ind + 1)) + 1) * 0.05)
                End If
                'Elimina el dato actual para poder analizar el que sigue y lo guarda en auxiliar
                aux = aux.Remove(0, (ind + 1))
            Next
            'Hace una cuenta para el puntaje total, de tal forma que sea difícil que se repita el mismo número. Esto se debe
            'A que en este tipo de lista no se pueden repetir los números.
            sumTotal = sumTotal * sumTotal * sumTotal * sumTotal

            'Bucle en el que detecta si el puntaje ya existe, si es así lo aumenta en uno para que no se repita
            While datosFinal.ContainsKey(sumTotal)
                sumTotal = sumTotal + 1
            End While
            'Agrega el puntaje a la colección de datos a devolver
            datosFinal.Add(sumTotal, i)
        Next

        'Bucle que obtiene todas las filas de puntajes y las añade a un objeto lista para que las pueda posicionar la tabla de manera correcta
        For i As Integer = datosFinal.Count - 1 To 0 Step -1
            'Declaración de variables auxiliares y asignación de las mismas con los datos correspondientes
            Dim aux As String
            Dim ind As Integer
            aux = datos(datosFinal.Values(i))
            posiciones(i) = New List(Of String)
            posiciones(i).Add(datosFinal.Count - i)

            'Bucle que recorre los datos del puntaje
            For j As Integer = 1 To 5
                ind = aux.Length - 1
                'Condicional que ordena los datos mostrados en la tabla de puntajes (nombre, correctas, incorrectas, no respondidas y tiempo)
                If (aux.Contains(",")) Then
                    ind = aux.IndexOf(",")
                    posiciones(i).Add(aux.Substring(0, ind))
                Else
                    posiciones(i).Add(aux.Substring(0, ind + 1) & "s")
                End If
                aux = aux.Remove(0, (ind + 1))
            Next
        Next

        'Devuelve el arreglo de las filas finales para la tabla
        Return posiciones
    End Function


    'Función que arma las filas para la tabla de puntajes
    Public Function datosTabla(ByVal posiciones() As List(Of String)) As ListViewItem()
        'Vector de filas para la tabla puntaje
        Dim datos(posiciones.Length - 1) As ListViewItem
        'Bucle que recorre todas las filas creadas
        For i As Integer = 0 To datos.Length - 1
            'Inicializa la fila y le asigna los datos correspondientes para posteriormente ser insertado en la tabla
            datos(i) = New ListViewItem
            datos(i).Text = posiciones(i).Item(0)
            datos(i).SubItems.Add(posiciones(i).Item(1))
            datos(i).SubItems.Add(posiciones(i).Item(2))
            datos(i).SubItems.Add(posiciones(i).Item(3))
            datos(i).SubItems.Add(posiciones(i).Item(4))
            datos(i).SubItems.Add(posiciones(i).Item(5))
        Next
        'Devuelve el vector de filas
        Return datos
    End Function

End Module
