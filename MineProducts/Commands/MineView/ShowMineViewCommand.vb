Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Presenters.Interfaces

Namespace Commands.MineView
    Public Class ShowMineViewCommand
        Inherits CommandBase

        Private ReadOnly _presenter As IMineViewPresenter
        Private ReadOnly _eventAggregator As IEventAggregator

        Public Sub New(presenter As IMineViewPresenter, eventAggregator As IEventAggregator)
            _presenter = presenter
            _eventAggregator = eventAggregator
            _eventAggregator.Subscribe(Of OpenAddMineViewMessage)(Sub() Execute())
        End Sub

        Public Overrides Sub Execute()
            _presenter.Show()
        End Sub
    End Class
End Namespace