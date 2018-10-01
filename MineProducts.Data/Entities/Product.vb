Namespace Entities

    Public Class Product
        Inherits Base
        Public Overridable Property Name As String
        Public Overridable Property ApplicationEndUse As String
        Public Overridable Property FumeClass As String
        Public Overridable Property ExplosiveDensity As Decimal
        Public Overridable Property Mine As Mine
        Public Overridable Property ProductSizes As ICollection(Of ProductSize)
    End Class
End Namespace