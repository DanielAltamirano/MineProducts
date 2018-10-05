Imports System.ComponentModel
Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Models
Imports MineProducts.Views.Interfaces

Namespace Views
#If DEBUG Then
    Public Class ProductView
        Inherits WorkaroundForDesigner
#Else
    Public Class ProductView
        Inherits BaseView
#End If
        Implements IProductView
        
        Public Sub New(eventAggregator As IEventAggregator)
            _eventAggregator = eventAggregator
            InitializeComponent()
            BindControlsToFields()
        End Sub

        #Region "Fields"
        Private ReadOnly _eventAggregator As IEventAggregator
        Private ReadOnly _minesList As New BindingList(Of Mine)
        Private _lastSelectedMineId As Integer
        #End Region
        
        #Region "Properties"
        Public ReadOnly Property SelectedMine As Mine Implements IProductView.SelectedMine
            Get
                Return _minesList.FirstOrDefault(function(mine) mine.Id = _lastSelectedMineId)
            End Get
        End Property

        Private Property ExplosiveProductName As String Implements IProductView.ProductName
            Get
                Return ProductNameTxt.Text
            End Get
            Set
                ProductNameTxt.Text = Value
            End Set
        End Property

        Public Property ApplicationEndUse As String Implements IProductView.ApplicationEndUse
            Get
                Return ApplicationEndUseTxt.Text
            End Get
            Set
                ApplicationEndUseTxt.Text = Value
            End Set
        End Property

        Public Property ExplosiveDensity As Decimal Implements IProductView.ExplosiveDensity
            Get
                Return ExplosiveDensityTxt.Text
            End Get
            Set
                ExplosiveDensityTxt.Text = Value
            End Set
        End Property

        Public Property FumeClass As String Implements IProductView.FumeClass
            Get
                Return FumeClassTxt.Text
            End Get
            Set
                FumeClassTxt.Text = Value
            End Set
        End Property
        #End Region
        
        #Region "Private methods"
        Private Sub BindControlsToFields()
            _minesList.AllowNew = True
            _minesList.AllowRemove = True
            MineComboBox.DataSource = New BindingSource With {
                .DataSource = _minesList
            }
        End Sub

        Private Sub MineSelectionChanged() Handles MineComboBox.SelectedIndexChanged
            If MineComboBox.SelectedIndex <> -1 Then
                _lastSelectedMineId = DirectCast(MineComboBox.SelectedItem, Mine).Id
            End If
        End Sub
        
        Public Sub PublishCreateProductMessage() Handles CreateCloneBtn.Click
            _eventAggregator.Publish(New CreateProductMessage())
        End Sub
        #End Region

        #Region "Public methods"
        Public Sub SetMinesList(mines As List(Of Mine)) Implements IMinesListView.SetMinesList
            _lastSelectedMineId = -1
            _minesList.Clear()
            mines.ForEach(sub(mine) _minesList.Add(mine))
            If MineComboBox.SelectedIndex <> -1 Then
                _lastSelectedMineId = DirectCast(MineComboBox.SelectedItem, Mine).Id
            End If
        End Sub
        #End Region
    End Class
End Namespace