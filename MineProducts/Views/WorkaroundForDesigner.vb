Namespace Views

    'This class is here for the sole purpose of forcing the Form Designer to work on each View
    'See this link for more information https://stackoverflow.com/questions/1620847/how-can-i-get-visual-studio-2008-windows-forms-designer-to-render-a-form-that-im/2406058#2406058
    Public Class WorkaroundForDesigner
        Inherits BaseView

        Public Overrides Sub ClearControls()
            'Not required
        End Sub
    End Class
End NameSpace