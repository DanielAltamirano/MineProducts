Imports FluentNHibernate.Mapping
Imports MineProducts.Data.Entities

Namespace Mappings
    Public Class ProductMap
        Inherits ClassMap(Of Product)
        Public Sub New()
            Id(Function(x) x.Id)
            Map(Function(x) x.ApplicationEndUse)
            Map(Function(x) x.FumeClass)
            Map(Function(x) x.ExplosiveDensity)
            Map(Function(x) x.Name)
            References(Function(x) x.Mine).Not.LazyLoad()
            HasMany(Function(x) x.ProductSizes).Not.LazyLoad()
        End Sub
    End Class
End NameSpace