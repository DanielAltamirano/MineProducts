Imports MineProducts.Data.Entities

Namespace Repositories.Interfaces
    Public Interface IProductRepository(Of T)
        Inherits IBaseRepository(Of T)
        Overloads Function FindAll(mineId As Integer) As ICollection(Of Product)
    End Interface
End NameSpace