Imports MineProducts.Commands.MainView
Imports MineProducts.Commands.MineView
Imports MineProducts.Commands.ProductView
Imports MineProducts.Events
Imports MineProducts.Presenters.Interfaces

Namespace Presenters.MainView
    Partial Class MainViewPresenter

        Private Sub Configure()
            InstantiateViewCommands()
            SubscribeToMessages()
            LoadInitialData()
        End Sub

        Private Sub SubscribeToMessages()
            _eventAggregator.Subscribe(Of MineCreatedMessage)(Sub() _eventAggregator.Publish(New UpdateMineListOnMainViewMessage()))
            _eventAggregator.Subscribe(Of ProductCreatedMessage)(Sub() _eventAggregator.Publish(New UpdateProductListOnMainViewMessage()))
            _eventAggregator.Subscribe(Of ProductUpdatedMessage)(Sub() _eventAggregator.Publish(New UpdateProductListOnMainViewMessage()))
        End Sub

        Private Sub InstantiateViewCommands()
            _commands.Add(New ShowMineViewCommand(_mineViewPresenter, _eventAggregator))
            _commands.Add(New ShowProductViewCommand(_productViewPresenter, _eventAggregator))
            _commands.Add(New SaveMineInformationCommand(_mineService, _eventAggregator))
            _commands.Add(New SaveProductInformationCommand(_productService, _eventAggregator))
            _commands.Add(New UpdateMineListOnMainViewCommand(View, _mineService, _eventAggregator))
            _commands.Add(New UpdateProductListOnMainViewCommand(View, _productService, _eventAggregator))
            _commands.Add(New SaveProductSizeInformationCommand(_productSizeService, _eventAggregator))
            _commands.Add(New ExportToCsvCommand(_eventAggregator))
            _commands.Add(New PrintProductInformationCommand(_eventAggregator))
        End Sub

        Private Sub LoadInitialData()
            _eventAggregator.Publish(New UpdateMineListOnMainViewMessage())
            _eventAggregator.Publish(New UpdateProductListOnMainViewMessage())
        End Sub

        Public Sub ShowView() Implements IViewPresenter.Show
            'Not required for Main Form
        End Sub
    End Class
End Namespace