Public Class VentadeInterface(Of Rellenar)
    ''Metodos o Funciones sin Cuerpo
    Sub admProductos(ByVal producto As Rellenar)
    Function BuscarProducto(name As Object) As Boolean
    Sub Remove(name As Object)
    Sub RemoveAll()
    Function Read(name As Object) As Rellenar
    Function ReadAll() As List(Of Rellenar)
    Function Update(ByVal name As Object, ByVal producto As Rellenar) As Boolean
End Class
