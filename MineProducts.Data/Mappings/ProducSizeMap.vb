Imports FluentNHibernate.Mapping
Imports MineProducts.Data.Entities

Namespace Mappings
    Public Class ProducSizeMap
        Inherits ClassMap(Of ProductSize)
        Public Sub New()
            Id(Function(x) x.Id)
            Map(Function(x) x.CartridgeDiameterMm)
            Map(Function(x) x.CartridgeDiameterIn)
            Map(Function(x) x.DetonationVelocityMetersSec)
            Map(Function(x) x.DetonationVelocityFeetSec)
            References(Function(x) x.Product)
        End Sub
    End Class
End NameSpace