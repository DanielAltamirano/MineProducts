Imports MineProducts.Models

Namespace Views.Interfaces
    Public Interface IProductListView
        Inherits IFormView
        Sub SetProductsList(products As List(Of Product))
    End Interface
End NameSpace