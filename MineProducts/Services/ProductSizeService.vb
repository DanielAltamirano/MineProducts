Imports AutoMapper
Imports MineProducts.Data.Repositories.Interfaces
Imports MineProducts.Models
Imports MineProducts.Services.Interfaces

Namespace Services
    Public Class ProductSizeService
        Implements IProductSizeService

        Private ReadOnly _mapper As IMapper
        Private ReadOnly _productSizeRepository As IProductSizeRepository(Of Data.Entities.ProductSize)

        Public Sub New(mapper As IMapper, productSizeRepository As IProductSizeRepository(Of Data.Entities.ProductSize))
            _mapper = mapper
            _productSizeRepository = productSizeRepository
        End Sub

        Public Function FindAll(productId As Integer) As ICollection(Of Models.ProductSize) Implements IProductSizeService.FindAll
            Dim entityProductSizes As ICollection(Of Data.Entities.ProductSize) = _productSizeRepository.FindAll(productId)
            Dim modelProductSizes = New List(Of Models.ProductSize)
            For Each product As Data.Entities.ProductSize In entityProductSizes
                modelProductSizes.Add(_mapper.Map(Of Data.Entities.ProductSize, Models.ProductSize)(product))
            Next
            Return modelProductSizes
        End Function

        Public Function FindAll() As ICollection(Of Models.ProductSize) Implements IProductSizeService.FindAll
            Dim entityProductSizes As ICollection(Of Data.Entities.ProductSize) = _productSizeRepository.FindAll()
            Dim modelProductSizes = New List(Of Models.ProductSize)
            For Each product As Data.Entities.ProductSize In entityProductSizes
                modelProductSizes.Add(_mapper.Map(Of Data.Entities.ProductSize, Models.ProductSize)(product))
            Next
            Return modelProductSizes
        End Function

        Public Sub Create(productSize As Models.ProductSize) Implements IProductSizeService.Create
            Dim productSizeEntity As Data.Entities.ProductSize = _mapper.Map(Of Models.ProductSize, Data.Entities.ProductSize)(productSize)
            _productSizeRepository.Create(productSizeEntity)
        End Sub

        Public Sub Update(productSize As Models.ProductSize) Implements IProductSizeService.Update
            Dim productSizeEntity As Data.Entities.ProductSize = _mapper.Map(Of Models.ProductSize, Data.Entities.ProductSize)(productSize)
            _productSizeRepository.Update(productSizeEntity)
        End Sub

        Public Sub Delete(productSize As ProductSize) Implements IProductSizeService.Delete
            Dim productSizeEntity As Data.Entities.ProductSize = _mapper.Map(Of Models.ProductSize, Data.Entities.ProductSize)(productSize)
            _productSizeRepository.Delete(productSizeEntity)
        End Sub
    End Class
End NameSpace