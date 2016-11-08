Imports p01shoppingcart
Public Class Ventas
    Dim precio As Double
    Dim cargar As String
    'utilisamos Inplements como se muestra en p18practi
    Implements VentadeInterface(Of Productos)

    ' Utilisamos una lista de productos para hacer la llamada
    Public Lista_Productos As List(Of Productos)



    Public Sub admProductos(producto As Productos) Implements VentadeInterface(Of Productos).admProductos

        Lista_Productos.Add(producto)
    End Sub

    'generamos un constructor
    Public Sub New()
        Lista_Productos = New List(Of Productos)

    End Sub

    Property compr As Double
        Get
            Return precio
        End Get
        Set(ByVal value As Double)
            compr = value
        End Set
    End Property
    Property envia As Double
        Get
            Return cargar
        End Get
        Set(ByVal value As Double)
            cargar = value
        End Set
    End Property


    Public Sub Compra(ByVal prenda As System.Object)


    End Sub
End Class
