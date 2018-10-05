Imports MineProducts.Events.Interfaces
Imports MineProducts.Models

Namespace Events
    Public Class ExportToCsvMessage
        Implements IApplicationEvent

        Public Property ProductSizes As ICollection(Of ProductSize)

        Public Sub New(productSizes As ICollection(Of ProductSize))
            Me.ProductSizes = productSizes
        End Sub
    End Class
End NameSpace