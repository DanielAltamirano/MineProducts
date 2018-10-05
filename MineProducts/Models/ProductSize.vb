Imports MineProducts.My.Resources

Namespace Models
    Public Class ProductSize
        Inherits Base
        Private _detonationVelocityFeetSec As Decimal
        Const A As Decimal = 5981.326
        Const B As Decimal = 2833.804
        Const C As Decimal = -556.407

        Public ReadOnly Property CartridgeDiameterMm As Decimal
            Get
                Return CartridgeDiameterIn * Decimal.Parse(InchesToMillimeters)
            End Get
        End Property
        Public Property CartridgeDiameterIn As Decimal
        Public ReadOnly Property DetonationVelocityMetersSec As Decimal
            Get
                Return DetonationVelocityFeetSec * Decimal.Parse(FeetSecToMtsSec)
            End Get
        End Property

        Public Property DetonationVelocityFeetSec As Decimal
            Get
                If _detonationVelocityFeetSec = 0 And CartridgeDiameterIn <> 0 Then
                    Return A + (B * CartridgeDiameterIn) + (C)*(10^(-CartridgeDiameterIn))
                End If
                Return _detonationVelocityFeetSec
            End Get
            Set
                _detonationVelocityFeetSec = value
            End Set
        End Property

        Public Property Product As Product
    End Class
End Namespace