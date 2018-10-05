Imports MineProducts.Events.Interfaces
Imports MineProducts.Models

Namespace Events
    Public Class PrintProductInformationMessage
        Implements IApplicationEvent

        Public Property SelectedMine As Mine
        Public Property SelectedProduct As Product

        Public Sub New(selectedMine As Mine,
                       selectedProduct As Product)
            Me.SelectedMine = selectedMine
            Me.SelectedProduct = selectedProduct
        End Sub
    End Class
End NameSpace