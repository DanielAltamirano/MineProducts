Imports MineProducts.Models

Namespace Views.Interfaces
    Public Interface IMinesListView
        Inherits IFormView
        Sub SetMinesList(mines As List(Of Mine))
    End Interface
End NameSpace