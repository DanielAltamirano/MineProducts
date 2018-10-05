Imports MineProducts.Models

Namespace Services.Interfaces
    Public Interface IMineService
        Function FindAll() As ICollection(Of Mine)
        Sub Create(mine As Mine)
        Sub Update(mine As Mine)
    End Interface
End NameSpace