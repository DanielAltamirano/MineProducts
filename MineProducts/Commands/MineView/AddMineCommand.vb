Imports MineProducts.Commands.Interfaces
Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Models
Imports MineProducts.Services.Interfaces
Imports MineProducts.Views.Interfaces

Namespace Commands.MineView

    Public Class AddMineCommand
        Inherits CommandBase
        Implements IValidateCommand

        Private ReadOnly _mineView As IMineView
        Private ReadOnly _mineService As IMineService
        Private ReadOnly _eventAggregator As IEventAggregator

        Public Sub New(mineView As IMineView,
                       mineService As IMineService, eventAggregator As IEventAggregator)
            _mineView = mineView
            _mineService = mineService
            _eventAggregator = eventAggregator
            _eventAggregator.Subscribe(Of CreateMineMessage)(Sub(m) Execute())
        End Sub

        Public Function ValidFields() As Boolean Implements IValidateCommand.ValidFields
            Throw New NotImplementedException
        End Function

        Public Overrides Sub Execute()
            Dim mine As New Mine
            mine.Name = _mineView.MineName
            _mineService.Create(mine)
            _eventAggregator.Publish(New MineCreatedMessage())
            _mineView.CloseView()
        End Sub
    End Class
End Namespace