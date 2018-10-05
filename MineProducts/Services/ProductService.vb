Imports AutoMapper
Imports MineProducts.Data.Entities
Imports MineProducts.Data.Repositories.Interfaces
Imports MineProducts.Services.Interfaces

Namespace Services
    Public Class ProductService
        Implements IProductService

        Private ReadOnly _mapper As IMapper
        Private ReadOnly _productRepository As IProductRepository(Of Product)

        Public Sub New(mapper As IMapper, productRepository As IProductRepository(Of Product))
            _mapper = mapper
            _productRepository = productRepository
        End Sub

        Public Sub Create(product As Models.Product) Implements IProductService.Create
            Dim productEntity As Product = _mapper.Map(Of Models.Product, Product)(product)
            _productRepository.Create(productEntity)
        End Sub

        Public Sub Update(product As Models.Product) Implements IProductService.Update
            Dim productEntity As Product = _mapper.Map(Of Models.Product, Product)(product)
            _productRepository.Update(productEntity)
        End Sub

        Public Function FindAll(mineId As Integer) As ICollection(Of Models.Product) Implements IProductService.FindAll
            Dim entityProducts = _productRepository.FindAll(mineId)
            Dim modelProducts = New List(Of Models.Product)
            For Each product As Product In entityProducts
                modelProducts.Add(_mapper.Map(Of Product, Models.Product)(product))
            Next
            Return modelProducts
        End Function

        Public Function FindAll() As ICollection(Of Models.Product) Implements IProductService.FindAll
            Dim entityProducts = _productRepository.FindAll()
            Dim modelProducts = New List(Of Models.Product)
            For Each product As Product In entityProducts
                modelProducts.Add(_mapper.Map(Of Product, Models.Product)(product))
            Next
            Return modelProducts
        End Function
    End Class
End NameSpace