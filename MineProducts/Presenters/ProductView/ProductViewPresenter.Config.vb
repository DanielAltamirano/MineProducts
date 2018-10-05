Imports MineProducts.Commands.ProductView
Imports MineProducts.Events
Imports MineProducts.Presenters.Interfaces

Namespace Presenters.ProductView
    Partial Class ProductViewPresenter
        Private Sub Configure()
            InstantiateViewCommands()
            LoadInitialData()
        End Sub

        Private Sub LoadInitialData()
            _eventAggregator.Publish(New UpdateMineListOnProductViewMessage())
        End Sub

        Private Sub InstantiateViewCommands()
            _commands.Add(New AddProductCommand(View, _productService, _eventAggregator))
            _commands.Add(new UpdateMineListOnProductViewCommand(View, _mineService, _eventAggregator))
        End Sub

        Public Sub Show() Implements IViewPresenter.Show
            View.ClearControls()
            View.ShowView()
        End Sub
    End Class
End Namespace