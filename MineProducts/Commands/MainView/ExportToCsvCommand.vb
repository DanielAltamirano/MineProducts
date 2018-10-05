Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Models
Imports MineProducts.My.Resources

Namespace Commands.MainView
    Public Class ExportToCsvCommand
        Inherits CommandBase

        Private ReadOnly _eventAggregator As IEventAggregator
        Private _productSizes As ICollection(Of ProductSize)

        Public Sub New(eventAggregator As IEventAggregator)
            _eventAggregator = eventAggregator
            _eventAggregator.Subscribe(Of ExportToCsvMessage)(
                Sub(message)
                    _productSizes = message.ProductSizes
                    Execute()
                End Sub
            )
        End Sub

        Private Function GenerateCsvString() As List(Of String)
            Dim csvLines As New List(Of String)
            csvLines.Add($"Cartridge Diameter (mm), Cartridge Diameter (ins), Detonation Velocity (m/sec), Detonation Velocity (f/sec)")
            For Each productSize As ProductSize In _productSizes
                csvLines.Add($"{productSize.CartridgeDiameterMm}, {productSize.CartridgeDiameterIn}, {productSize.DetonationVelocityMetersSec}, {productSize.DetonationVelocityFeetSec}")
            Next
            Return csvLines
        End Function

        Public Overrides Sub Execute()
            Dim csvLines = GenerateCsvString()
            Dim saveFileDialog As New SaveFileDialog With {
                .Filter = CsvSaveDialogFilter
            }

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                If saveFileDialog.FileName <> String.Empty Then
                    IO.File.WriteAllLines(saveFileDialog.FileName, csvLines)
                End If
            End If
        End Sub
    End Class
End NameSpace