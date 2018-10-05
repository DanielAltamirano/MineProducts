Imports System.ComponentModel
Imports MineProducts.My.Resources
Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Models
Imports MineProducts.Modules
Imports MineProducts.Views.Interfaces

Namespace Views
#If DEBUG Then
    Public Class MainFormView
        Inherits WorkaroundForDesigner
#Else
    Public Class MainFormView
        Inherits BaseView
#End If
        Implements IMainFormView
        Public Sub New(eventAggregator As IEventAggregator)
            _eventAggregator = eventAggregator
            InitializeComponent()
            BindControlsToFields()
        End Sub

        #Region "Fields"
        Private ReadOnly _eventAggregator As IEventAggregator
        Private ReadOnly _minesList As New BindingList(Of Mine)
        Private ReadOnly _productsList As New BindingList(Of Product)
        Private _lastSelectedMineId As Integer
        Private _lastSelectedProductId As Integer

        #End Region

        #Region "Properties"
        Public ReadOnly Property SelectedMine As Mine Implements IMainFormView.SelectedMine
            Get
                Return _minesList.FirstOrDefault(function(mine) mine.Id = _lastSelectedMineId)
            End Get
        End Property

        Public ReadOnly Property SelectedProduct As Product Implements IMainFormView.SelectedProduct
            Get
                Return _productsList.FirstOrDefault(function(product) product.Id = _lastSelectedProductId)
            End Get
        End Property
        #End Region

        #Region "Private methods"
        Private Sub BindControlsToFields()
            _minesList.AllowNew = True
            _minesList.AllowRemove = True
            _productsList.AllowNew = True
            _productsList.AllowRemove = True
            MineComboBox.DataSource = New BindingSource With {
                .DataSource = _minesList
            }
            ProductComboBox.DataSource = New BindingSource With {
                .DataSource = _productsList
            }
        End Sub
        
        Private Sub MineSelectionChanged() Handles MineComboBox.SelectedIndexChanged
            If MineComboBox.SelectedIndex <> -1 Then
                _lastSelectedMineId = DirectCast(MineComboBox.SelectedItem, Mine).Id
            End If
            ActivateAddMineInterface()
            _eventAggregator.Publish(New MainViewMineSelectionChangedMessage())
        End Sub

        Private Sub OpenAddMineView() Handles AddMineBtn.Click
            _eventAggregator.Publish(New OpenAddMineViewMessage())
        End Sub

        Private Sub OpenAddProductView() Handles AddProductBtn.Click
            _eventAggregator.Publish(New OpenAddProductViewMessage())
        End Sub

        Private Sub MineNameChanged Handles MineComboBox.TextChanged
            If MineComboBox.SelectedItem Is Nothing Then
                Return
            End If
            If _lastSelectedMineId <> DirectCast(MineComboBox.SelectedItem, Mine).Id Then
                Return
            End If

            ActivateEditMineInterface()
        End Sub

        Private Sub SaveMineInformation() Handles SaveMineBtn.Click
            'Invoke command
            Dim editedMine As Mine = _minesList.FirstOrDefault(function(mine) mine.Id = _lastSelectedMineId)
            editedMine.Name = MineComboBox.Text
            _eventAggregator.Publish(New SaveMineInformationMessage(editedMine))
            'Update UI
            ActivateAddMineInterface()
        End Sub

        Public Sub PrintProductInformation() Handles PrintBtn.Click
            If ProductComboBox.SelectedIndex <> -1 Then
                Dim dg = TechDataGridView
                _eventAggregator.Publish(New PrintProductInformationMessage(SelectedMine, SelectedProduct))
            End If
        End Sub

        Public Sub ExportToCsv() Handles ExportToCsvBtn.Click
            If ProductComboBox.SelectedIndex <> -1 Then
                _eventAggregator.Publish(New ExportToCsvMessage(SelectedProduct.ProductSizes))
            End If
        End Sub

        Private Sub ProductSelectionChanged() Handles ProductComboBox.SelectedIndexChanged
            If ProductComboBox.SelectedIndex <> -1 Then
                _lastSelectedProductId = DirectCast(ProductComboBox.SelectedItem, Product).Id
            End If
            ActivateAddProductInterface()
            RefreshProductInformation()
            LoadProductSizes()
        End Sub

        Private Sub SaveProductInformation() Handles SaveProductBtn.Click
            If Not ExplosiveDensityTxtBox.Text.IsDecimal() Then
                MsgBox(InvalidFieldsErrorCreatingProduct, MsgBoxStyle.Exclamation, ErrorDialogTitleCreatingProduct)
                Return
            End If
            Dim editedProduct As Product = _productsList.FirstOrDefault(function(mine) mine.Id = _lastSelectedProductId)
            editedProduct.Name = ProductComboBox.Text
            editedProduct.ApplicationEndUse = ApplicationEndUseTxtBox.Text
            editedProduct.FumeClass = FumeClassTxtBox.Text
            editedProduct.ExplosiveDensity = ExplosiveDensityTxtBox.Text

            Dim productSizes = New List(Of ProductSize)
            For Each row As DataGridViewRow In TechDataGridView.Rows
                If Not row.IsNewRow Then
                    Dim productSize = New ProductSize
                    productSize.CopyFrom(row)
                    productSize.Product = editedProduct
                    productSizes.Add(productSize)
                End If
            Next
            For Each productSize As ProductSize In editedProduct.ProductSizes
                If Not productSizes.Any(function(ps) ps.Id = productSize.Id) Then
                    productSize.Product = Nothing
                    productSizes.Add(productSize)
                End If
            Next
            Dim restoreMineId = _lastSelectedMineId
            Dim restoreProductId = _lastSelectedProductId

            _eventAggregator.Publish(New SaveProductInformationMessage(editedProduct))
            _eventAggregator.Publish(New SaveProductSizeInformationMessage(productSizes, editedProduct))
            
            'Update UI
            ActivateAddProductInterface()
            RestoreSelection(restoreMineId, restoreProductId)
        End Sub

        Private Sub DiscardAllChanges() Handles DiscardChangesBtn.Click
            RefreshMineInformation()
            RefreshProductInformation()
            LoadProductSizes()
            ActivateAddProductInterface()
            ActivateAddMineInterface()
        End Sub
        #End Region

        #Region "Public methods"
        Public Sub SetMinesList(mines As List(Of Mine)) Implements IMainFormView.SetMinesList
            _lastSelectedMineId = -1
            _minesList.Clear()
            mines.ForEach(sub(mine) _minesList.Add(mine))
            If MineComboBox.SelectedIndex <> -1 Then
                _lastSelectedMineId = DirectCast(MineComboBox.SelectedItem, Mine).Id
            End If
            UpdateEnabledControls()
        End Sub

        Public Sub SetProductsList(products As List(Of Product)) Implements IMainFormView.SetProductsList
            _lastSelectedProductId = -1
            _productsList.Clear()
            products.ForEach(sub(product) _productsList.Add(product))
            UpdateEnabledControls()
            If ProductComboBox.SelectedIndex <> -1 Then
                _lastSelectedProductId = DirectCast(ProductComboBox.SelectedItem, Product).Id
            End If
            RefreshProductInformation()
            LoadProductSizes()
        End Sub

        Private Sub LoadProductSizes()
            TechDataGridView.Rows.Clear()
            If ProductComboBox.SelectedIndex <> -1 Then
                Dim product = DirectCast(ProductComboBox.SelectedItem, Product)
                If product.ProductSizes.Count > 0 Then
                    TechDataGridView.Rows.Add(product.ProductSizes.Count)
                    Dim rowNum = 0
                    For Each productSize As ProductSize In product.ProductSizes
                        productSize.CopyTo(TechDataGridView.Rows.Item(rowNum))
                        rowNum = rowNum + 1
                    Next
                    TechDataGridView.Sort(TechDataGridView.Columns.Item("CartridgeDiameterIn"), ListSortDirection.Ascending)
                End If
            End If
        End Sub

        Public Overrides Sub ClearControls()
            'Not required for this view
        End Sub

        Private Sub ProductSizeCellEdit(sender As Object, e As DataGridViewCellEventArgs) Handles TechDataGridView.CellEndEdit
            If ProductComboBox.SelectedIndex <> -1 Then
                ActivateEditProductInterface()
            End If
        End Sub

        Private Sub TechDataGridView_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles TechDataGridView.RowsRemoved
            If DirectCast(sender, DataGridView).NewRowIndex >= 0 Then
                ActivateEditProductInterface()
            End If
        End Sub
#End Region
    End Class
End Namespace