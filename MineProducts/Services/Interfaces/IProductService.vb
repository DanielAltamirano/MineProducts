Imports MineProducts.Models

Namespace Services.Interfaces
    Public Interface IProductService
        Function FindAll(mineId As Integer) As ICollection(Of Product)
        Function FindAll() As ICollection(Of Product)
        Sub Create(product As Product)
        Sub Update(product As Product)
    End Interface
End NameSpace