Imports MineProducts.Events.Interfaces
Imports MineProducts.Models

Namespace Events
    Public Class SaveProductSizeInformationMessage
        Implements IApplicationEvent

        Public Property ProductSizes As ICollection(Of ProductSize)
        Public Property Product As Product

        Public Sub New(productSizes As ICollection(Of ProductSize),
                       product As Product)
            Me.ProductSizes = productSizes
            Me.Product = product
        End Sub
    End Class
End NameSpace