Imports MineProducts.Commands.Interfaces
Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Models
Imports MineProducts.Modules
Imports MineProducts.My.Resources
Imports MineProducts.Services.Interfaces
Imports MineProducts.Views.Interfaces

Namespace Commands.ProductView
    Public Class AddProductCommand
        Inherits CommandBase
        Implements IValidateCommand

        Private ReadOnly _productView As IProductView
        Private ReadOnly _productService As IProductService
        Private ReadOnly _eventAggregator As IEventAggregator
        Private _product As Product

        Public Sub New(productView As IProductView,
                       productService As IProductService,
                       eventAggregator As IEventAggregator)
            _productView = productView
            _productService = productService
            _eventAggregator = eventAggregator
            _eventAggregator.Subscribe(Of CreateProductMessage)(
                Sub()
                    _product = New Product With {
                        .Name = _productView.ProductName,
                        .ApplicationEndUse = _productView.ApplicationEndUse,
                        .ExplosiveDensity = _productView.ExplosiveDensity,
                        .FumeClass = _productView.FumeClass,
                        .Mine = _productView.SelectedMine
                    }
                    If ValidFields() Then
                        Execute()
                    End If
                End Sub
            )
        End Sub

        Public Function ValidFields() As Boolean Implements IValidateCommand.ValidFields
            If Not _product.FieldsNotNullOrEmpty() Then
                MsgBox(IncompleteFieldsErrorCreatingProduct, MsgBoxStyle.Exclamation, ErrorDialogTitleCreatingProduct)
                Return False
            End If
            If Not _product.ExplosiveDensity.IsDecimal() Then
                MsgBox(InvalidFieldsErrorCreatingProduct, MsgBoxStyle.Exclamation, ErrorDialogTitleCreatingProduct)
                Return False
            End If
            Return True
        End Function
        
        Public Overrides Sub Execute()
            _productService.Create(_product)
            _eventAggregator.Publish(New ProductCreatedMessage())
            _productView.CloseView()
        End Sub
    End Class
End Namespace