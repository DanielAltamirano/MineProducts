Namespace Models
    Public Class Product
        Inherits Base
        Public Property Name As String
        Public Property ApplicationEndUse As String
        Public Property FumeClass As String
        Public Property ExplosiveDensity As Decimal
        Public Property Mine As Mine
        Public Property ProductSizes As ICollection(Of ProductSize)
    End Class
End Namespace