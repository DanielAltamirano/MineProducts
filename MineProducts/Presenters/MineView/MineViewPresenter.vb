Imports MineProducts.Commands.Interfaces
Imports MineProducts.Events.Interfaces
Imports MineProducts.Presenters.Interfaces
Imports MineProducts.Services.Interfaces
Imports MineProducts.Views.Interfaces

Namespace Presenters.MineView
    Public Class MineViewPresenter
        Implements IMineViewPresenter

        Private ReadOnly _mineService As IMineService
        Private ReadOnly _eventAggregator As IEventAggregator
        Private ReadOnly _commands As New List(Of ICommand)
        Public Property FormView As IMineView Implements IMineViewPresenter.FormView

        Public Sub New(mineView As IMineView,
                       mineService As IMineService,
                       eventAggregator As IEventAggregator)
            _mineService = mineService
            _eventAggregator = eventAggregator

            FormView = mineView

            Configure()
        End Sub
    End Class
End Namespace