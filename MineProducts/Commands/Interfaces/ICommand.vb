Imports System.ComponentModel

Namespace Commands.Interfaces
    Public Interface ICommand
        Inherits INotifyPropertyChanged

        Sub Execute()
    End Interface
End Namespace