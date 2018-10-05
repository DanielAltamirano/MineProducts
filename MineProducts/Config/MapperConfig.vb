Imports AutoMapper
Imports MineProducts.Models

Namespace Config
    Public Class MapperConfig

        Private Shared _mapper As IMapper

        Private Shared ReadOnly Property Mapper As IMapper
            Get
                _mapper = Configure().CreateMapper()
                Return _mapper
            End Get
        End Property
        
        Public Shared Function Configure() As MapperConfiguration
            Dim mapperConfiguration = New MapperConfiguration(
                Sub(config)
                    config.CreateMap(Of Mine, Data.Entities.Mine)
                    config.CreateMap(Of Data.Entities.Mine, Mine)
                    config.CreateMap(Of ProductSize, Data.Entities.ProductSize)
                    config.CreateMap(Of Data.Entities.ProductSize, ProductSize)
                    config.CreateMap(Of Product, Data.Entities.Product)
                    config.CreateMap(Of Data.Entities.Product, Product).
                        ForMember(Function(dest) dest.ProductSizes, Sub(opt) opt.MapFrom(function(src) src.ProductSizes))
                End Sub
            )

            Return mapperConfiguration
        End Function

        Public Shared Function GetConfiguredMapper() As IMapper
            Return Mapper
        End Function
    End Class
End NameSpace