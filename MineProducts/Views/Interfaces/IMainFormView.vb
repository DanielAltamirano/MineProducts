Imports MineProducts.Models

Namespace Views.Interfaces
    Public Interface IMainFormView
        Inherits IMinesListView
        Inherits IProductListView
        ReadOnly Property SelectedMine As Mine
        ReadOnly Property SelectedProduct As Product
    End Interface
End Namespace