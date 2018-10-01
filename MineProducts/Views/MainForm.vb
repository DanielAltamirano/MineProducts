Imports MineProducts.Model

Namespace Views
    Public Class MainForm
        Implements IMainFormView

        Sub MainForm()

        End Sub

        Public Property ProductFieldsEnabled As Boolean Implements IMainFormView.ProductFieldsEnabled
        Public Property ExportAsCsvEnabled As Boolean Implements IMainFormView.ExportAsCsvEnabled

        Public Sub SelectMine(mine As Mine) Implements IMainFormView.SelectMine
            Throw New NotImplementedException
        End Sub

        Public Sub SelectProduct(product As Product) Implements IMainFormView.SelectProduct
            Throw New NotImplementedException
        End Sub

        Public Sub SetMinesList(mines As List(Of Mine)) Implements IMainFormView.SetMinesList
            Throw New NotImplementedException
        End Sub

        Public Sub SetProductsList(products As List(Of Product)) Implements IMainFormView.SetProductsList
            Throw New NotImplementedException
        End Sub
    End Class
End Namespace