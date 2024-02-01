Module varUsoCom
    'Formulario del juego
    Public formJuego As Form
    'Marca la letra actual
    Public indLetra As Byte = 0
    'Posiciones de las letras
    Public letras(27) As Rectangle
    'Tamaño de las letras
    Public tam As Byte
    'Distancia de entre letras en grados
    Public ReadOnly ang As Double = (Math.PI * 2) / 27
    'Ancho de la pantalla
    Public ReadOnly ancho As Integer = My.Computer.Screen.Bounds.Width
    'Alto de la pantalla
    Public ReadOnly alto As Integer = My.Computer.Screen.Bounds.Height
    'Centro de la pantalla
    Public ReadOnly medio As Point = New Point(ancho / 2, alto / 2)
    'Opcion de volumen
    Public hayVolumen As Boolean = True
    'Rutas especiales
    Public ReadOnly paths As String = Application.StartupPath
    'Ruta de las imagenes
    Public ReadOnly rutaImagenes As String = paths & "\Pasapalabras\imagenes\"
    'Ruta de las tematicas
    Public ReadOnly rutaTextoJuego As String = paths & "\Pasapalabras\juego\tematicas\"
    'Ruta de los audios
    Public ReadOnly rutaAudio As String = paths & "\Pasapalabras\audio\"
    'Ruta del puntaje
    Public ReadOnly rutaPuntaje As String = paths & "\Pasapalabras\juego\puntaje\"
    'Imagenes de las letras
    Public letrasAzul(27), letrasAmarillo(27), letrasRojo(27), letrasVerde(27) As Image
    'Tipo de color de la letra
    '1:No preguntado(Azul) 2:Preguntado(Amarillo) 3:Fallido(Rojo) 4:Correcto(Verde) 
    Public imgsLetras(27) As Byte
    'Comprueba si inicio el juego
    Public iniciado As Boolean = False
    'Letras
    Public ReadOnly abc() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    'Pista a reproducir
    Public pista As String = "PI.wav"
    'Tiempo de juego
    Public segundos As Integer = 423
    'Estado de reproducción de sonido
    Public reproduciendo As Boolean = False
    'Reproductores de sonido
    Public wmp, sonidos As New WMPLib.WindowsMediaPlayer
    'Narrador de preguntas
    Public narrador As New System.Speech.Synthesis.SpeechSynthesizer
End Module