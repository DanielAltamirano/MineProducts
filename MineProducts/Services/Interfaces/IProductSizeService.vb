Imports MineProducts.Models

Namespace Services.Interfaces
    Public Interface IProductSizeService
        Function FindAll(productId As Integer) As ICollection(Of ProductSize)
        Function FindAll() As ICollection(Of ProductSize)
        Sub Create(product As ProductSize)
        Sub Update(product As ProductSize)
        Sub Delete(product As ProductSize)
    End Interface
End NameSpace