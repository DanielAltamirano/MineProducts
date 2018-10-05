Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Presenters.Interfaces

Namespace Commands.ProductView
    Public Class ShowProductViewCommand
        Inherits CommandBase

        Private ReadOnly _presenter As IProductViewPresenter
        Private ReadOnly _eventAggregator As IEventAggregator

        Public Sub New(presenter As IProductViewPresenter, eventAggregator As IEventAggregator)
            _presenter = presenter
            _eventAggregator = eventAggregator
            _eventAggregator.Subscribe(Of OpenAddProductViewMessage)(Sub() Execute())
        End Sub

        Public Overrides Sub Execute()
            _eventAggregator.Publish(New UpdateMineListOnProductViewMessage())
            _presenter.Show()
        End Sub
    End Class
End Namespace