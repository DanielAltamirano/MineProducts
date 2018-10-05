Imports MineProducts.Commands.Interfaces
Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Models
Imports MineProducts.Modules
Imports MineProducts.My.Resources
Imports MineProducts.Services.Interfaces

Namespace Commands.MainView
    Public Class SaveProductInformationCommand
        Inherits CommandBase
        Implements IValidateCommand

        Private ReadOnly _productService As IProductService
        Private ReadOnly _eventAggregator As IEventAggregator
        Private _product As Product

        Public Sub New(productService As IProductService,
                       eventAggregator As IEventAggregator)
            _productService = productService
            _eventAggregator = eventAggregator
            _eventAggregator.Subscribe(Of SaveProductInformationMessage)(
                Sub(message)
                    _product = message.Product
                    If ValidFields() Then
                        Execute()
                    End If
                End Sub
                )
        End Sub

        Public Overrides Sub Execute()
            _productService.Update(_product)
            _eventAggregator.Publish(New ProductUpdatedMessage())
        End Sub

        Public Function ValidFields() As Boolean Implements IValidateCommand.ValidFields
            If Not _product.FieldsNotNullOrEmpty() Then
                MsgBox(IncompleteFieldsErrorCreatingProduct, MsgBoxStyle.Exclamation, ErrorDialogTitleCreatingProduct)
                Return False
            End If
            Return True
        End Function
    End Class
End NameSpace