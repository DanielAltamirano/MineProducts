Imports System.ComponentModel
Imports MineProducts.Commands.Interfaces

Namespace Commands

    Public MustInherit Class CommandBase
        Implements ICommand

        Private _tooltip As String

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

        Public Overridable Sub Execute() Implements ICommand.Execute
        End Sub
    End Class
End Namespace