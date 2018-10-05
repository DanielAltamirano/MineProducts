Imports MineProducts.Commands.Interfaces
Imports MineProducts.Events.Interfaces
Imports MineProducts.Presenters.Interfaces
Imports MineProducts.Services.Interfaces
Imports MineProducts.Views.Interfaces

Namespace Presenters.ProductView
    Public Class ProductViewPresenter
        Implements IProductViewPresenter

        Private ReadOnly _mineService As IMineService
        Private ReadOnly _productService As IProductService
        Private ReadOnly _eventAggregator As IEventAggregator
        Private ReadOnly _commands As New List(Of ICommand)
        Public Property View As IProductView Implements IProductViewPresenter.FormView

        Public Sub New(productView As IProductView,
                       mineService As IMineService,
                       productService As IProductService,
                       eventAggregator As IEventAggregator)
            _mineService = mineService
            _productService = productService
            _eventAggregator = eventAggregator

            View = productView

            Configure()
        End Sub
    End Class
End Namespace