Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Models
Imports MineProducts.Services.Interfaces

Namespace Commands.MainView
    Public Class SaveMineInformationCommand
        Inherits CommandBase

        Private ReadOnly _mineService As IMineService
        Private ReadOnly _eventAggregator As IEventAggregator
        Private _mine As Mine

        Public Sub New(mineService As IMineService,
                       eventAggregator As IEventAggregator)
            _mineService = mineService
            _eventAggregator = eventAggregator
            _eventAggregator.Subscribe(Of SaveMineInformationMessage)(
                Sub(m)
                    _mine = m.Mine
                    Execute()
                End Sub
            )
        End Sub

        Public Overrides Sub Execute()
            _mineService.Update(_mine)
            _eventAggregator.Publish(New MineCreatedMessage())
        End Sub
    End Class
End NameSpace