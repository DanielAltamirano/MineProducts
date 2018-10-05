Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Models
Imports MineProducts.Services.Interfaces

Namespace Commands.MainView
    Public Class SaveProductSizeInformationCommand
        Inherits CommandBase

        Private ReadOnly _productSizeService As IProductSizeService
        Private ReadOnly _eventAggregator As IEventAggregator
        Private _productSizes As ICollection(Of ProductSize)
        Private _product As Product

        Public Sub New(productSizeService As IProductSizeService,
                       eventAggregator As IEventAggregator)
            _productSizeService = productSizeService
            _eventAggregator = eventAggregator
            _eventAggregator.Subscribe(Of SaveProductSizeInformationMessage)(
                Sub(message)
                    _productSizes = message.ProductSizes
                    _product = message.Product
                    Execute()
                End Sub
            )
        End Sub

        Public Overrides Sub Execute()
            For Each productSize As ProductSize In _productSizes
                If productSize.Id = -1 Then
                    productSize.Product = _product
                    _productSizeService.Create(productSize)
                ElseIf productSize.Product Is Nothing Then
                    _productSizeService.Delete(productSize)
                Else 
                    _productSizeService.Update(productSize)
                End If
            Next
            
            _eventAggregator.Publish(New UpdateProductListOnMainViewMessage())
        End Sub
    End Class
End NameSpace