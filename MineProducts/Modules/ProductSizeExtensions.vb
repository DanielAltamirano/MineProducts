Imports System.Runtime.CompilerServices
Imports MineProducts.Models

Namespace Modules
    Module ProductSizeExtensions
        <Extension()>
        Public Sub CopyTo(productSize As ProductSize, row As DataGridViewRow)
            If row Is Nothing Then
                Return
            End If
            row.Cells.Item(nameof(productSize.CartridgeDiameterMm)).Value = productSize.CartridgeDiameterMm
            row.Cells.Item(nameof(productSize.CartridgeDiameterIn)).Value = productSize.CartridgeDiameterIn
            row.Cells.Item(nameof(productSize.DetonationVelocityMetersSec)).Value = productSize.DetonationVelocityMetersSec
            row.Cells.Item(nameof(productSize.DetonationVelocityFeetSec)).Value = productSize.DetonationVelocityFeetSec
            row.Tag = productSize.Id
        End Sub

        <Extension()>
        Public Sub CopyFrom(productSize As ProductSize, row As DataGridViewRow)
            If row Is Nothing Then
                Return
            End If
            productSize.CartridgeDiameterIn = Decimal.Parse(row.Cells.Item(nameof(productSize.CartridgeDiameterIn)).Value)

            Dim detonationVelocityFeetSec = row.Cells.Item(nameof(productSize.DetonationVelocityFeetSec)).Value
            If detonationVelocityFeetSec IsNot Nothing Then
                productSize.DetonationVelocityFeetSec = Decimal.Parse(detonationVelocityFeetSec)
            End If
            productSize.Id = -1
            If row.Tag IsNot Nothing Then
                productSize.Id = DirectCast(row.Tag, Integer)
            End If
        End Sub

        <Extension()>
        Public Sub CopyFrom(productSizeDest As ProductSize, productSizeOrig As ProductSize)
            If productSizeOrig Is Nothing Then
                Return
            End If
            productSizeDest.CartridgeDiameterIn = productSizeOrig.CartridgeDiameterIn
            productSizeDest.DetonationVelocityFeetSec = productSizeOrig.DetonationVelocityFeetSec
        End Sub
    End Module
End NameSpace