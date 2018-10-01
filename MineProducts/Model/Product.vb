Namespace Model
    Public Class Product
        Inherits Base
        Public Property Name As String
        Public Property ApplicationEndUse As String
        Public Property FumeClass As String
        Public Property ExplosiveDensity As Decimal
        Public Overridable Property ProductSizes As List(Of ProductSize)
    End Class
End Namespace