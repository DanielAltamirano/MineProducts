Imports System.Runtime.CompilerServices

Namespace Modules
    Module StringExtensions
        <Extension()>
        Public Function IsDecimal(aString As String) As Boolean
            Try
                Decimal.Parse(aString)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
    End Module
End NameSpace