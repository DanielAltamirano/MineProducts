Imports MineProducts.Events.Interfaces
Imports MineProducts.Models

Namespace Events
    Public Class SaveProductInformationMessage
        Implements IApplicationEvent

        Public Property Product As Product

        Public Sub New(product As Product)
            Me.Product = product
        End Sub
    End Class
End NameSpace