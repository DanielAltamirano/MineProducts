Imports MineProducts.Views.Interfaces

Namespace Views
    Partial Class ProductView
        
        Public ReadOnly Property FieldsAreComplete As Boolean Implements IValidateFieldsView.FieldsAreComplete
            Get
                Return Not String.IsNullOrEmpty(ApplicationEndUse) And
                       Not String.IsNullOrEmpty(FumeClass) And
                       Not String.IsNullOrEmpty(ExplosiveDensity) And
                       MineComboBox.SelectedItem IsNot Nothing And
                       Not String.IsNullOrEmpty(ExplosiveProductName)
            End Get
        End Property

        Public ReadOnly Property FieldsAreValid As Boolean Implements IValidateFieldsView.FieldsAreValid
            Get
                Try
                    Decimal.Parse(ExplosiveDensityTxt.Text)
                    Return True
                Catch ex As Exception
                    Return False
                End Try
            End Get
        End Property

    End Class
End NameSpace