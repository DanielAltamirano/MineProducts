Imports MineProducts.Commands.Interfaces
Imports MineProducts.Events.Interfaces
Imports MineProducts.Presenters.Interfaces
Imports MineProducts.Services.Interfaces
Imports MineProducts.Views.Interfaces

Namespace Presenters.MainView
    Public Class MainViewPresenter
        Implements IMainViewPresenter

        Public ReadOnly View As IMainFormView

        Private ReadOnly _mineViewPresenter As IMineViewPresenter
        Private ReadOnly _productViewPresenter As IProductViewPresenter
        Private ReadOnly _mineService As IMineService
        Private ReadOnly _productService As IProductService
        Private ReadOnly _productSizeService As IProductSizeService
        Private ReadOnly _eventAggregator As IEventAggregator
        Private ReadOnly _commands As New List(Of ICommand)

        Public Sub New(mainView As IMainFormView,
                       mineViewPresenter As IMineViewPresenter,
                       productViewPresenter As IProductViewPresenter,
                       mineService As IMineService,
                       productService As IProductService,
                       productSizeService As IProductSizeService,
                       eventAggregator As IEventAggregator)
            _mineViewPresenter = mineViewPresenter
            _productViewPresenter = productViewPresenter
            _mineService = mineService
            _productService = productService
            _productSizeService = productSizeService
            _eventAggregator = eventAggregator

            View = mainView

            Configure()
        End Sub
    End Class
End Namespace