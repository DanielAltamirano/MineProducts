Imports MineProducts.Models

Namespace Views.Interfaces
    Public Interface IProductView
        Inherits IFormView
        Inherits IValidateFieldsView
        Inherits IMinesListView
        ReadOnly Property SelectedMine As Mine
        Property ProductName As String
        Property ApplicationEndUse As String
        Property ExplosiveDensity As String
        Property FumeClass As String
    End Interface
End NameSpace