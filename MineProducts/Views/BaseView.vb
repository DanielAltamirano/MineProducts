Imports MineProducts.Views.Interfaces

Namespace Views
    Public MustInherit Class BaseView
        Inherits Form
        Implements IFormView

        Public Event OnFormViewClosing() Implements IFormView.OnFormViewClosing

        Public Sub New()
            AddHandler OnFormViewClosing, AddressOf FormViewClosing
        End Sub

        Protected Sub FormViewClosing() Implements IFormView.FormViewClosing
            RaiseEvent OnFormViewClosing
        End Sub

        Public MustOverride Sub ClearControls() Implements IFormView.ClearControls

        Public Sub ShowView() Implements IFormView.ShowView
            ShowDialog()
        End Sub

        Public Sub CloseView() Implements IFormView.CloseView
            ClearControls()
            Close()
        End Sub
    End Class
End NameSpace