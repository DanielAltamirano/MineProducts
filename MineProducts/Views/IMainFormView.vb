Imports MineProducts.Model

Namespace Views
    Public Interface IMainFormView
        Property ProductFieldsEnabled As Boolean
        Property ExportAsCsvEnabled As Boolean
        Sub SelectMine(mine As Mine)
        Sub SelectProduct(product As Product)
        Sub SetMinesList(mines As List(Of Mine))
        Sub SetProductsList(products As List(Of Product))
    End Interface
End Namespace