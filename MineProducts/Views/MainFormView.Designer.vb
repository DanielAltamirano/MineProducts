Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainFormView

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFormView))
        Me.InformationGrp = New System.Windows.Forms.GroupBox()
        Me.ProductComboBox = New System.Windows.Forms.ComboBox()
        Me.MineComboBox = New System.Windows.Forms.ComboBox()
        Me.DiscardChangesBtn = New System.Windows.Forms.Button()
        Me.AddProductBtn = New System.Windows.Forms.Button()
        Me.AddMineBtn = New System.Windows.Forms.Button()
        Me.ExplosiveDensityTxtBox = New System.Windows.Forms.TextBox()
        Me.FumeClassTxtBox = New System.Windows.Forms.TextBox()
        Me.ApplicationEndUseTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExplosiveDensityLbl = New System.Windows.Forms.Label()
        Me.FumeClassLbl = New System.Windows.Forms.Label()
        Me.AppEndUseLbl = New System.Windows.Forms.Label()
        Me.ExplosiveProductLbl = New System.Windows.Forms.Label()
        Me.MineLbl = New System.Windows.Forms.Label()
        Me.SaveProductBtn = New System.Windows.Forms.Button()
        Me.SaveMineBtn = New System.Windows.Forms.Button()
        Me.ExportToCsvBtn = New System.Windows.Forms.Button()
        Me.TechDataGridView = New System.Windows.Forms.DataGridView()
        Me.CartridgeDiameterMm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartridgeDiameterIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetonationVelocityMetersSec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetonationVelocityFeetSec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintBtn = New System.Windows.Forms.Button()
        Me.InformationGrp.SuspendLayout
        CType(Me.TechDataGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'InformationGrp
        '
        Me.InformationGrp.Controls.Add(Me.ProductComboBox)
        Me.InformationGrp.Controls.Add(Me.MineComboBox)
        Me.InformationGrp.Controls.Add(Me.DiscardChangesBtn)
        Me.InformationGrp.Controls.Add(Me.AddProductBtn)
        Me.InformationGrp.Controls.Add(Me.AddMineBtn)
        Me.InformationGrp.Controls.Add(Me.ExplosiveDensityTxtBox)
        Me.InformationGrp.Controls.Add(Me.FumeClassTxtBox)
        Me.InformationGrp.Controls.Add(Me.ApplicationEndUseTxtBox)
        Me.InformationGrp.Controls.Add(Me.Label1)
        Me.InformationGrp.Controls.Add(Me.ExplosiveDensityLbl)
        Me.InformationGrp.Controls.Add(Me.FumeClassLbl)
        Me.InformationGrp.Controls.Add(Me.AppEndUseLbl)
        Me.InformationGrp.Controls.Add(Me.ExplosiveProductLbl)
        Me.InformationGrp.Controls.Add(Me.MineLbl)
        Me.InformationGrp.Controls.Add(Me.SaveProductBtn)
        Me.InformationGrp.Controls.Add(Me.SaveMineBtn)
        Me.InformationGrp.Location = New System.Drawing.Point(16, 16)
        Me.InformationGrp.Name = "InformationGrp"
        Me.InformationGrp.Size = New System.Drawing.Size(456, 184)
        Me.InformationGrp.TabIndex = 3
        Me.InformationGrp.TabStop = false
        Me.InformationGrp.Text = "Information"
        '
        'ProductComboBox
        '
        Me.ProductComboBox.DisplayMember = "Name"
        Me.ProductComboBox.FormattingEnabled = true
        Me.ProductComboBox.Location = New System.Drawing.Point(136, 56)
        Me.ProductComboBox.Name = "ProductComboBox"
        Me.ProductComboBox.Size = New System.Drawing.Size(160, 21)
        Me.ProductComboBox.TabIndex = 2
        '
        'MineComboBox
        '
        Me.MineComboBox.DisplayMember = "Name"
        Me.MineComboBox.FormattingEnabled = true
        Me.MineComboBox.Location = New System.Drawing.Point(136, 24)
        Me.MineComboBox.Name = "MineComboBox"
        Me.MineComboBox.Size = New System.Drawing.Size(160, 21)
        Me.MineComboBox.TabIndex = 0
        '
        'DiscardChangesBtn
        '
        Me.DiscardChangesBtn.Enabled = false
        Me.DiscardChangesBtn.Location = New System.Drawing.Point(312, 88)
        Me.DiscardChangesBtn.Name = "DiscardChangesBtn"
        Me.DiscardChangesBtn.Size = New System.Drawing.Size(128, 23)
        Me.DiscardChangesBtn.TabIndex = 3
        Me.DiscardChangesBtn.Text = "Discard Changes"
        Me.DiscardChangesBtn.UseVisualStyleBackColor = true
        '
        'AddProductBtn
        '
        Me.AddProductBtn.Location = New System.Drawing.Point(312, 56)
        Me.AddProductBtn.Name = "AddProductBtn"
        Me.AddProductBtn.Size = New System.Drawing.Size(128, 23)
        Me.AddProductBtn.TabIndex = 3
        Me.AddProductBtn.Text = "Add Product"
        Me.AddProductBtn.UseVisualStyleBackColor = true
        '
        'AddMineBtn
        '
        Me.AddMineBtn.Location = New System.Drawing.Point(312, 24)
        Me.AddMineBtn.Name = "AddMineBtn"
        Me.AddMineBtn.Size = New System.Drawing.Size(128, 23)
        Me.AddMineBtn.TabIndex = 1
        Me.AddMineBtn.Text = "Add Mine"
        Me.AddMineBtn.UseVisualStyleBackColor = true
        '
        'ExplosiveDensityTxtBox
        '
        Me.ExplosiveDensityTxtBox.Enabled = false
        Me.ExplosiveDensityTxtBox.Location = New System.Drawing.Point(136, 152)
        Me.ExplosiveDensityTxtBox.Name = "ExplosiveDensityTxtBox"
        Me.ExplosiveDensityTxtBox.Size = New System.Drawing.Size(120, 20)
        Me.ExplosiveDensityTxtBox.TabIndex = 6
        '
        'FumeClassTxtBox
        '
        Me.FumeClassTxtBox.Enabled = false
        Me.FumeClassTxtBox.Location = New System.Drawing.Point(136, 120)
        Me.FumeClassTxtBox.Name = "FumeClassTxtBox"
        Me.FumeClassTxtBox.Size = New System.Drawing.Size(160, 20)
        Me.FumeClassTxtBox.TabIndex = 5
        '
        'ApplicationEndUseTxtBox
        '
        Me.ApplicationEndUseTxtBox.Enabled = false
        Me.ApplicationEndUseTxtBox.Location = New System.Drawing.Point(136, 88)
        Me.ApplicationEndUseTxtBox.Name = "ApplicationEndUseTxtBox"
        Me.ApplicationEndUseTxtBox.Size = New System.Drawing.Size(160, 20)
        Me.ApplicationEndUseTxtBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(264, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "g/cc"
        '
        'ExplosiveDensityLbl
        '
        Me.ExplosiveDensityLbl.AutoSize = true
        Me.ExplosiveDensityLbl.Location = New System.Drawing.Point(16, 152)
        Me.ExplosiveDensityLbl.Name = "ExplosiveDensityLbl"
        Me.ExplosiveDensityLbl.Size = New System.Drawing.Size(93, 13)
        Me.ExplosiveDensityLbl.TabIndex = 1
        Me.ExplosiveDensityLbl.Text = "Explosive Density:"
        '
        'FumeClassLbl
        '
        Me.FumeClassLbl.AutoSize = true
        Me.FumeClassLbl.Location = New System.Drawing.Point(16, 120)
        Me.FumeClassLbl.Name = "FumeClassLbl"
        Me.FumeClassLbl.Size = New System.Drawing.Size(64, 13)
        Me.FumeClassLbl.TabIndex = 1
        Me.FumeClassLbl.Text = "Fume Class:"
        '
        'AppEndUseLbl
        '
        Me.AppEndUseLbl.AutoSize = true
        Me.AppEndUseLbl.Location = New System.Drawing.Point(16, 88)
        Me.AppEndUseLbl.Name = "AppEndUseLbl"
        Me.AppEndUseLbl.Size = New System.Drawing.Size(106, 13)
        Me.AppEndUseLbl.TabIndex = 1
        Me.AppEndUseLbl.Text = "Application End Use:"
        '
        'ExplosiveProductLbl
        '
        Me.ExplosiveProductLbl.AutoSize = true
        Me.ExplosiveProductLbl.Location = New System.Drawing.Point(16, 56)
        Me.ExplosiveProductLbl.Name = "ExplosiveProductLbl"
        Me.ExplosiveProductLbl.Size = New System.Drawing.Size(95, 13)
        Me.ExplosiveProductLbl.TabIndex = 1
        Me.ExplosiveProductLbl.Text = "Explosive Product:"
        '
        'MineLbl
        '
        Me.MineLbl.AutoSize = true
        Me.MineLbl.Location = New System.Drawing.Point(16, 24)
        Me.MineLbl.Name = "MineLbl"
        Me.MineLbl.Size = New System.Drawing.Size(33, 13)
        Me.MineLbl.TabIndex = 0
        Me.MineLbl.Text = "Mine:"
        '
        'SaveProductBtn
        '
        Me.SaveProductBtn.Enabled = false
        Me.SaveProductBtn.Location = New System.Drawing.Point(312, 56)
        Me.SaveProductBtn.Name = "SaveProductBtn"
        Me.SaveProductBtn.Size = New System.Drawing.Size(128, 23)
        Me.SaveProductBtn.TabIndex = 8
        Me.SaveProductBtn.Text = "Save Product"
        Me.SaveProductBtn.UseVisualStyleBackColor = true
        Me.SaveProductBtn.Visible = false
        '
        'SaveMineBtn
        '
        Me.SaveMineBtn.Enabled = false
        Me.SaveMineBtn.Location = New System.Drawing.Point(312, 24)
        Me.SaveMineBtn.Name = "SaveMineBtn"
        Me.SaveMineBtn.Size = New System.Drawing.Size(128, 23)
        Me.SaveMineBtn.TabIndex = 7
        Me.SaveMineBtn.Text = "Save Mine"
        Me.SaveMineBtn.UseVisualStyleBackColor = true
        Me.SaveMineBtn.Visible = false
        '
        'ExportToCsvBtn
        '
        Me.ExportToCsvBtn.Enabled = false
        Me.ExportToCsvBtn.Location = New System.Drawing.Point(248, 472)
        Me.ExportToCsvBtn.Name = "ExportToCsvBtn"
        Me.ExportToCsvBtn.Size = New System.Drawing.Size(144, 23)
        Me.ExportToCsvBtn.TabIndex = 1
        Me.ExportToCsvBtn.Text = "Export to CSV"
        Me.ExportToCsvBtn.UseVisualStyleBackColor = true
        '
        'TechDataGridView
        '
        Me.TechDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TechDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CartridgeDiameterMm, Me.CartridgeDiameterIn, Me.DetonationVelocityMetersSec, Me.DetonationVelocityFeetSec})
        Me.TechDataGridView.Enabled = false
        Me.TechDataGridView.Location = New System.Drawing.Point(16, 208)
        Me.TechDataGridView.Name = "TechDataGridView"
        Me.TechDataGridView.Size = New System.Drawing.Size(456, 256)
        Me.TechDataGridView.TabIndex = 0
        '
        'CartridgeDiameterMm
        '
        Me.CartridgeDiameterMm.HeaderText = "Cartridge Diameter (mm)"
        Me.CartridgeDiameterMm.Name = "CartridgeDiameterMm"
        Me.CartridgeDiameterMm.ReadOnly = true
        '
        'CartridgeDiameterIn
        '
        Me.CartridgeDiameterIn.HeaderText = "Cartridge Diameter (in)"
        Me.CartridgeDiameterIn.Name = "CartridgeDiameterIn"
        '
        'DetonationVelocityMetersSec
        '
        Me.DetonationVelocityMetersSec.HeaderText = "Detonation Velocity (m/sec)"
        Me.DetonationVelocityMetersSec.Name = "DetonationVelocityMetersSec"
        Me.DetonationVelocityMetersSec.ReadOnly = true
        '
        'DetonationVelocityFeetSec
        '
        Me.DetonationVelocityFeetSec.HeaderText = "DetonationVelocity (f/sec)"
        Me.DetonationVelocityFeetSec.Name = "DetonationVelocityFeetSec"
        '
        'PrintBtn
        '
        Me.PrintBtn.Enabled = false
        Me.PrintBtn.Location = New System.Drawing.Point(88, 472)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(144, 23)
        Me.PrintBtn.TabIndex = 1
        Me.PrintBtn.Text = "Print Product Information"
        Me.PrintBtn.UseVisualStyleBackColor = true
        '
        'MainFormView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 507)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.ExportToCsvBtn)
        Me.Controls.Add(Me.TechDataGridView)
        Me.Controls.Add(Me.InformationGrp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.Name = "MainFormView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Explosive Products"
        Me.InformationGrp.ResumeLayout(false)
        Me.InformationGrp.PerformLayout
        CType(Me.TechDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
        Friend WithEvents InformationGrp As GroupBox
        Friend WithEvents ProductComboBox As ComboBox
        Friend WithEvents MineComboBox As ComboBox
        Friend WithEvents AddProductBtn As Button
        Friend WithEvents AddMineBtn As Button
        Friend WithEvents ExplosiveDensityTxtBox As TextBox
        Friend WithEvents FumeClassTxtBox As TextBox
        Friend WithEvents ApplicationEndUseTxtBox As TextBox
        Friend WithEvents ExplosiveDensityLbl As Label
        Friend WithEvents FumeClassLbl As Label
        Friend WithEvents AppEndUseLbl As Label
        Friend WithEvents ExplosiveProductLbl As Label
        Friend WithEvents MineLbl As Label
        Friend WithEvents ExportToCsvBtn As Button
        Friend WithEvents TechDataGridView As DataGridView
        Friend WithEvents PrintBtn As Button
        Friend WithEvents DiscardChangesBtn As Button
        Friend WithEvents SaveMineBtn As Button
        Friend WithEvents SaveProductBtn As Button
        Friend WithEvents CartridgeDiameterMm As DataGridViewTextBoxColumn
        Friend WithEvents CartridgeDiameterIn As DataGridViewTextBoxColumn
        Friend WithEvents DetonationVelocityMetersSec As DataGridViewTextBoxColumn
        Friend WithEvents DetonationVelocityFeetSec As DataGridViewTextBoxColumn
        Friend WithEvents Label1 As Label
    End Class
End Namespace