Imports MineProducts.Events.Interfaces
Imports MineProducts.Models

Namespace Events
    Public Class SaveMineInformationMessage
        Implements IApplicationEvent

        Public Property Mine As Mine

        Public Sub New(mine As Mine)
            Me.Mine = mine
        End Sub
    End Class
End NameSpace