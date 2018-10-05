Imports MineProducts.Config
Imports MineProducts.Views
Imports Unity
Imports MineProducts.Presenters.MainView

Public Class Program
    Public Shared Sub Main()
        Dim container = UnityConfig.GetConfiguredContainer()

        Dim mainViewPresenter = container.Resolve(Of MainViewPresenter)

        Dim mainFormView = DirectCast(mainViewPresenter.View, MainFormView)
        mainFormView.Tag = mainViewPresenter

        Application.Run(mainFormView)
    End Sub
End Class
