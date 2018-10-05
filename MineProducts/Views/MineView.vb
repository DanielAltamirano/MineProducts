Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Views.Interfaces

Namespace Views
#if DEBUG
    Public Class MineView
        Inherits WorkaroundForDesigner
#else 
    Public Class MineView
        Inherits BaseView
#End If
        Implements IMineView
        Public Sub New(eventAggregator As IEventAggregator)
            _eventAggregator = eventAggregator
            InitializeComponent()
            SetEventMessages()
        End Sub

        #Region "Fields"
        Private ReadOnly _eventAggregator As IEventAggregator
        #End Region

        #Region "Properties"
        Public Property MineName As String Implements IMineView.MineName
            Get
                Return mineTxt.Text
            End Get
            Set
                mineTxt.Text = Value
            End Set
        End Property
        #End Region

        #Region "Private methods"
        Private Sub SetEventMessages()
            AddHandler createMineBtn.Click,
                Sub(s, e) _eventAggregator.Publish(New CreateMineMessage())
        End Sub
        #End Region

        #Region "Public methods"
        Public Overrides Sub ClearControls()
            MineName = String.Empty
        End Sub
        #End Region

    End Class
End NameSpace