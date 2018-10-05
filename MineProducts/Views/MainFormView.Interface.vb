Imports MineProducts.Models

Namespace Views
    Partial Class MainFormView
        Private Sub ActivateAddMineInterface()
            AddMineBtn.Visible = True
            SaveMineBtn.Visible = Not AddMineBtn.Visible
            DiscardChangesBtn.Enabled = SaveMineBtn.Visible Or SaveProductBtn.Visible
        End Sub

        Private Sub ActivateEditMineInterface()
            DiscardChangesBtn.Enabled = True
            AddMineBtn.Visible = False
            SaveMineBtn.Visible = Not AddMineBtn.Visible
        End Sub

        Private Sub ActivateAddProductInterface()
            AddProductBtn.Visible = True
            SaveProductBtn.Visible = Not AddProductBtn.Visible
            SaveProductBtn.Enabled = SaveProductBtn.Visible
            DiscardChangesBtn.Enabled = SaveMineBtn.Visible Or SaveProductBtn.Visible
        End Sub

        Private Sub ActivateEditProductInterface() Handles ProductComboBox.KeyPress,
                                                      ApplicationEndUseTxtBox.KeyPress,
                                                      FumeClassTxtBox.KeyPress,
                                                      ExplosiveDensityTxtBox.KeyPress
            DiscardChangesBtn.Enabled = True
            AddProductBtn.Visible = False
            SaveProductBtn.Visible = Not AddProductBtn.Visible
            SaveProductBtn.Enabled = SaveProductBtn.Visible
        End Sub

        Private Sub RefreshMineInformation()
            MineComboBox.Text = If(SelectedMine Is Nothing, String.Empty, SelectedMine.Name)
        End Sub

        Private Sub RefreshProductInformation()
            ApplicationEndUseTxtBox.Text = If(SelectedProduct Is Nothing, String.Empty, SelectedProduct.ApplicationEndUse)
            FumeClassTxtBox.Text = If(SelectedProduct Is Nothing, String.Empty, SelectedProduct.FumeClass)
            ExplosiveDensityTxtBox.Text = If(SelectedProduct Is Nothing, String.Empty, SelectedProduct.ExplosiveDensity)
        End Sub

        Private Sub UpdateEnabledControls()
            MineComboBox.Enabled = (MineComboBox.Items.Count <> 0)
            ProductComboBox.Enabled = (ProductComboBox.Items.Count <> 0)
            AddProductBtn.Enabled = (MineComboBox.Items.Count <> 0)
            ApplicationEndUseTxtBox.Enabled = (ProductComboBox.SelectedItem IsNot Nothing Or SaveProductBtn.Enabled)
            FumeClassTxtBox.Enabled = (ProductComboBox.SelectedItem IsNot Nothing Or SaveProductBtn.Enabled)
            ExplosiveDensityTxtBox.Enabled = (ProductComboBox.SelectedItem IsNot Nothing Or SaveProductBtn.Enabled)
            TechDataGridView.Enabled = (ProductComboBox.SelectedItem IsNot Nothing Or SaveProductBtn.Enabled)
            PrintBtn.Enabled = (ProductComboBox.SelectedItem IsNot Nothing Or SaveProductBtn.Enabled)
            ExportToCsvBtn.Enabled = (ProductComboBox.SelectedItem IsNot Nothing Or SaveProductBtn.Enabled)
        End Sub

        Private Sub RestoreSelection(restoreMineId As Integer, restoreProductId As Integer)
            Dim mineEnum = MineComboBox.Items.GetEnumerator()
            While mineEnum.MoveNext()
                Dim mine = DirectCast(mineEnum.Current, Mine)
                If mine.Id = restoreMineId Then
                    MineComboBox.SelectedItem = mineEnum.Current
                    Exit While
                End If
            End While
            Dim productEnum = ProductComboBox.Items.GetEnumerator()
            While productEnum.MoveNext()
                Dim product = DirectCast(productEnum.Current, Product)
                If product.Id = restoreProductId Then
                    ProductComboBox.SelectedItem = productEnum.Current
                    Exit While
                End If
            End While
        End Sub
    End Class
End NameSpace