Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Services.Interfaces
Imports MineProducts.Views.Interfaces

Namespace Commands.MainView
    Public Class UpdateMineListOnMainViewCommand
        Inherits CommandBase

        Private ReadOnly _view As IMinesListView
        Private ReadOnly _mineService As IMineService
        Private ReadOnly _eventAggregator As IEventAggregator

        Public Sub New(view As IMinesListView,
                       mineService As IMineService,
                       eventAggregator As IEventAggregator)
            _view = view
            _mineService = mineService
            _eventAggregator = eventAggregator
            _eventAggregator.Subscribe(Of UpdateMineListOnMainViewMessage)(Sub(m) Execute())
        End Sub

        Public Overrides Sub Execute()
            _view.SetMinesList(_mineService.FindAll())
        End Sub
    End Class
End NameSpace