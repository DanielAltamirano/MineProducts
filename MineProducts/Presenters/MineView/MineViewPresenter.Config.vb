Imports MineProducts.Commands.MineView
Imports MineProducts.Presenters.Interfaces

Namespace Presenters.MineView
    Partial Class MineViewPresenter
        Private Sub Configure()
            InstantiateViewCommands()
            SubscribeToMessages()
        End Sub

        Private Sub SubscribeToMessages()

        End Sub

        Private Sub InstantiateViewCommands()
            _commands.Add(New AddMineCommand(FormView, _mineService, _eventAggregator))
        End Sub

        Public Sub Show() Implements IViewPresenter.Show
            FormView.ShowView()
        End Sub
    End Class
End Namespace