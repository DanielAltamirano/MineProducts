Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Models
Imports MineProducts.Services.Interfaces
Imports MineProducts.Views.Interfaces

Namespace Commands.MainView
    Public Class UpdateProductListOnMainViewCommand
        Inherits CommandBase

        Private ReadOnly _mainView As IMainFormView
        Private ReadOnly _productService As IProductService
        Private ReadOnly _eventAggregator As IEventAggregator

        Public Sub New(mainView As IMainFormView,
                       productService As IProductService,
                       eventAggregator As IEventAggregator)
            _mainView = mainView
            _productService = productService
            _eventAggregator = eventAggregator
            _eventAggregator.Subscribe(Of UpdateProductListOnMainViewMessage)(Sub(m) Execute())
            _eventAggregator.Subscribe(Of MainViewMineSelectionChangedMessage)(Sub(m) Execute())
        End Sub

        Public Overrides Sub Execute()
            Dim selectedMine As Mine = _mainView.SelectedMine
            If selectedMine Is Nothing Then
                Return
            End If
            _mainView.SetProductsList(_productService.FindAll(selectedMine.Id))
        End Sub
    End Class
End NameSpace