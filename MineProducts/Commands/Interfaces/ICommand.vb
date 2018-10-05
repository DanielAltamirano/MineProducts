Imports System.ComponentModel

Namespace Commands.Interfaces
    Public Interface ICommand
        Property IsEnabled As Boolean
        Sub Execute()
    End Interface
End Namespace