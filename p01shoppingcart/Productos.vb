Imports System.IO
Public Class Productos

    Private Id As Integer
    Private Complemt As String
    Private Titulo As String
    Dim prends As Double
    Dim cas As String
    Public Sub New()
        Id = 0
        Titulo = "Sin titulo"
        Complemt = False
    End Sub
    Public Sub New(id As Integer, titulo As String, completado As String)
        id = id
        titulo = titulo
        Complemt = completado
    End Sub
    ' Properties
    Public Property Id() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

    Public Property Titulos() As String
        Get
            Return Titulo
        End Get
        Set(ByVal value As String)
            Titulo = value
        End Set
    End Property

    Public Property Completados() As Boolean
        Get
            Return Complemt
        End Get
        Set(ByVal value As Boolean)
            Complemt = value
        End Set
    End Property

    Public Sub Imagen(ByVal sender As Image)
        'sender = Image.FromFile(Image.Item(0))

    End Sub

    Property compr As Double
        Get
            Return cas
        End Get
        Set(ByVal value As Double)
            cas = value
        End Set
    End Property
    Property envia As Double
        Get
            Return prends
        End Get
        Set(ByVal value As Double)
            prends = value
        End Set
    End Property

End Class
