Imports FluentNHibernate.Mapping
Imports MineProducts.Data.Entities

Namespace Mappings
    Public Class MineMap
        Inherits ClassMap(Of Mine)
        Public Sub New()
            Id(Function(x) x.Id)
            Map(Function(x) x.Name)
            HasMany(Function(x) x.Products).Inverse()
        End Sub
    End Class
End NameSpace