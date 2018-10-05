Namespace Views.Interfaces
    Public Interface IValidateFieldsView
        Inherits IFormView
        ReadOnly Property FieldsAreComplete As Boolean
        ReadOnly Property FieldsAreValid As Boolean
    End Interface
End NameSpace