Imports System.ComponentModel
Imports MineProducts.Commands.Interfaces

Namespace Commands

    Public MustInherit Class CommandBase
        Implements INotifyPropertyChanged
        Implements ICommand

        Private _isEnabled As Boolean
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub OnPropertyChanged(propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

        Public Property IsEnabled() As Boolean Implements ICommand.IsEnabled
            Get
                Return _isEnabled
            End Get
            Set
                _isEnabled = value
                OnPropertyChanged(nameof(IsEnabled))
            End Set
        End Property

        Public MustOverride Sub Execute() Implements ICommand.Execute
    End Class
End Namespace