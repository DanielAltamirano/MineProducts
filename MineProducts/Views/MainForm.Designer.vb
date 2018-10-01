Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainForm
        Inherits System.Windows.Forms.Form

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
            Me.InformationGrp = New System.Windows.Forms.GroupBox()
            Me.ExplosiveProductComboBox = New System.Windows.Forms.ComboBox()
            Me.MineComboBox = New System.Windows.Forms.ComboBox()
            Me.NewExplosiveProductBtn = New System.Windows.Forms.Button()
            Me.NewMineBtn = New System.Windows.Forms.Button()
            Me.ExplosiveDensityTxtBox = New System.Windows.Forms.TextBox()
            Me.FumeClassTxtBox = New System.Windows.Forms.TextBox()
            Me.AppEndUseTxtBox = New System.Windows.Forms.TextBox()
            Me.ExplosiveDensityLbl = New System.Windows.Forms.Label()
            Me.FumeClassLbl = New System.Windows.Forms.Label()
            Me.AppEndUseLbl = New System.Windows.Forms.Label()
            Me.ExplosiveProductLbl = New System.Windows.Forms.Label()
            Me.MineLbl = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.TechDataGridView = New System.Windows.Forms.DataGridView()
            Me.CartridgeDiameterMillimeters = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CartridgeDiameterInches = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DetonationVelocityMSec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DetonationVelocityFtSec = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.InformationGrp.SuspendLayout()
            CType(Me.TechDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'InformationGrp
            '
            Me.InformationGrp.Controls.Add(Me.ExplosiveProductComboBox)
            Me.InformationGrp.Controls.Add(Me.MineComboBox)
            Me.InformationGrp.Controls.Add(Me.NewExplosiveProductBtn)
            Me.InformationGrp.Controls.Add(Me.NewMineBtn)
            Me.InformationGrp.Controls.Add(Me.ExplosiveDensityTxtBox)
            Me.InformationGrp.Controls.Add(Me.FumeClassTxtBox)
            Me.InformationGrp.Controls.Add(Me.AppEndUseTxtBox)
            Me.InformationGrp.Controls.Add(Me.ExplosiveDensityLbl)
            Me.InformationGrp.Controls.Add(Me.FumeClassLbl)
            Me.InformationGrp.Controls.Add(Me.AppEndUseLbl)
            Me.InformationGrp.Controls.Add(Me.ExplosiveProductLbl)
            Me.InformationGrp.Controls.Add(Me.MineLbl)
            Me.InformationGrp.Location = New System.Drawing.Point(16, 16)
            Me.InformationGrp.Name = "InformationGrp"
            Me.InformationGrp.Size = New System.Drawing.Size(456, 184)
            Me.InformationGrp.TabIndex = 3
            Me.InformationGrp.TabStop = False
            Me.InformationGrp.Text = "Information"
            '
            'ExplosiveProductComboBox
            '
            Me.ExplosiveProductComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ExplosiveProductComboBox.FormattingEnabled = True
            Me.ExplosiveProductComboBox.Location = New System.Drawing.Point(136, 56)
            Me.ExplosiveProductComboBox.Name = "ExplosiveProductComboBox"
            Me.ExplosiveProductComboBox.Size = New System.Drawing.Size(160, 21)
            Me.ExplosiveProductComboBox.TabIndex = 4
            '
            'MineComboBox
            '
            Me.MineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MineComboBox.FormattingEnabled = True
            Me.MineComboBox.Location = New System.Drawing.Point(136, 24)
            Me.MineComboBox.Name = "MineComboBox"
            Me.MineComboBox.Size = New System.Drawing.Size(160, 21)
            Me.MineComboBox.TabIndex = 4
            '
            'NewExplosiveProductBtn
            '
            Me.NewExplosiveProductBtn.Location = New System.Drawing.Point(312, 56)
            Me.NewExplosiveProductBtn.Name = "NewExplosiveProductBtn"
            Me.NewExplosiveProductBtn.Size = New System.Drawing.Size(128, 23)
            Me.NewExplosiveProductBtn.TabIndex = 3
            Me.NewExplosiveProductBtn.Text = "Add Product"
            Me.NewExplosiveProductBtn.UseVisualStyleBackColor = True
            '
            'NewMineBtn
            '
            Me.NewMineBtn.Location = New System.Drawing.Point(312, 24)
            Me.NewMineBtn.Name = "NewMineBtn"
            Me.NewMineBtn.Size = New System.Drawing.Size(128, 23)
            Me.NewMineBtn.TabIndex = 3
            Me.NewMineBtn.Text = "Add Mine"
            Me.NewMineBtn.UseVisualStyleBackColor = True
            '
            'ExplosiveDensityTxtBox
            '
            Me.ExplosiveDensityTxtBox.Location = New System.Drawing.Point(136, 152)
            Me.ExplosiveDensityTxtBox.Name = "ExplosiveDensityTxtBox"
            Me.ExplosiveDensityTxtBox.Size = New System.Drawing.Size(160, 20)
            Me.ExplosiveDensityTxtBox.TabIndex = 2
            '
            'FumeClassTxtBox
            '
            Me.FumeClassTxtBox.Location = New System.Drawing.Point(136, 120)
            Me.FumeClassTxtBox.Name = "FumeClassTxtBox"
            Me.FumeClassTxtBox.Size = New System.Drawing.Size(160, 20)
            Me.FumeClassTxtBox.TabIndex = 2
            '
            'AppEndUseTxtBox
            '
            Me.AppEndUseTxtBox.Location = New System.Drawing.Point(136, 88)
            Me.AppEndUseTxtBox.Name = "AppEndUseTxtBox"
            Me.AppEndUseTxtBox.Size = New System.Drawing.Size(160, 20)
            Me.AppEndUseTxtBox.TabIndex = 2
            '
            'ExplosiveDensityLbl
            '
            Me.ExplosiveDensityLbl.AutoSize = True
            Me.ExplosiveDensityLbl.Location = New System.Drawing.Point(16, 152)
            Me.ExplosiveDensityLbl.Name = "ExplosiveDensityLbl"
            Me.ExplosiveDensityLbl.Size = New System.Drawing.Size(93, 13)
            Me.ExplosiveDensityLbl.TabIndex = 1
            Me.ExplosiveDensityLbl.Text = "Explosive Density:"
            '
            'FumeClassLbl
            '
            Me.FumeClassLbl.AutoSize = True
            Me.FumeClassLbl.Location = New System.Drawing.Point(16, 120)
            Me.FumeClassLbl.Name = "FumeClassLbl"
            Me.FumeClassLbl.Size = New System.Drawing.Size(64, 13)
            Me.FumeClassLbl.TabIndex = 1
            Me.FumeClassLbl.Text = "Fume Class:"
            '
            'AppEndUseLbl
            '
            Me.AppEndUseLbl.AutoSize = True
            Me.AppEndUseLbl.Location = New System.Drawing.Point(16, 88)
            Me.AppEndUseLbl.Name = "AppEndUseLbl"
            Me.AppEndUseLbl.Size = New System.Drawing.Size(106, 13)
            Me.AppEndUseLbl.TabIndex = 1
            Me.AppEndUseLbl.Text = "Application End Use:"
            '
            'ExplosiveProductLbl
            '
            Me.ExplosiveProductLbl.AutoSize = True
            Me.ExplosiveProductLbl.Location = New System.Drawing.Point(16, 56)
            Me.ExplosiveProductLbl.Name = "ExplosiveProductLbl"
            Me.ExplosiveProductLbl.Size = New System.Drawing.Size(95, 13)
            Me.ExplosiveProductLbl.TabIndex = 1
            Me.ExplosiveProductLbl.Text = "Explosive Product:"
            '
            'MineLbl
            '
            Me.MineLbl.AutoSize = True
            Me.MineLbl.Location = New System.Drawing.Point(16, 24)
            Me.MineLbl.Name = "MineLbl"
            Me.MineLbl.Size = New System.Drawing.Size(33, 13)
            Me.MineLbl.TabIndex = 0
            Me.MineLbl.Text = "Mine:"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(176, 472)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(120, 23)
            Me.Button1.TabIndex = 8
            Me.Button1.Text = "Export to CSV"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'TechDataGridView
            '
            Me.TechDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.TechDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CartridgeDiameterMillimeters, Me.CartridgeDiameterInches, Me.DetonationVelocityMSec, Me.DetonationVelocityFtSec})
            Me.TechDataGridView.Location = New System.Drawing.Point(16, 208)
            Me.TechDataGridView.Name = "TechDataGridView"
            Me.TechDataGridView.Size = New System.Drawing.Size(456, 256)
            Me.TechDataGridView.TabIndex = 7
            '
            'CartridgeDiameterMillimeters
            '
            Me.CartridgeDiameterMillimeters.HeaderText = "Cartridge Diameter (mm)"
            Me.CartridgeDiameterMillimeters.Name = "CartridgeDiameterMillimeters"
            Me.CartridgeDiameterMillimeters.ReadOnly = True
            '
            'CartridgeDiameterInches
            '
            Me.CartridgeDiameterInches.HeaderText = "Cartridge Diameter (in)"
            Me.CartridgeDiameterInches.Name = "CartridgeDiameterInches"
            '
            'DetonationVelocityMSec
            '
            Me.DetonationVelocityMSec.HeaderText = "Detonation Velocity (m/sec)"
            Me.DetonationVelocityMSec.Name = "DetonationVelocityMSec"
            Me.DetonationVelocityMSec.ReadOnly = True
            '
            'DetonationVelocityFtSec
            '
            Me.DetonationVelocityFtSec.HeaderText = "DetonationVelocity (f/sec)"
            Me.DetonationVelocityFtSec.Name = "DetonationVelocityFtSec"
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(487, 502)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.TechDataGridView)
            Me.Controls.Add(Me.InformationGrp)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Explosive Products"
            Me.InformationGrp.ResumeLayout(False)
            Me.InformationGrp.PerformLayout()
            CType(Me.TechDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents InformationGrp As GroupBox
        Friend WithEvents ExplosiveProductComboBox As ComboBox
        Friend WithEvents MineComboBox As ComboBox
        Friend WithEvents NewExplosiveProductBtn As Button
        Friend WithEvents NewMineBtn As Button
        Friend WithEvents ExplosiveDensityTxtBox As TextBox
        Friend WithEvents FumeClassTxtBox As TextBox
        Friend WithEvents AppEndUseTxtBox As TextBox
        Friend WithEvents ExplosiveDensityLbl As Label
        Friend WithEvents FumeClassLbl As Label
        Friend WithEvents AppEndUseLbl As Label
        Friend WithEvents ExplosiveProductLbl As Label
        Friend WithEvents MineLbl As Label
        Friend WithEvents Button1 As Button
        Friend WithEvents TechDataGridView As DataGridView
        Friend WithEvents CartridgeDiameterMillimeters As DataGridViewTextBoxColumn
        Friend WithEvents CartridgeDiameterInches As DataGridViewTextBoxColumn
        Friend WithEvents DetonationVelocityMSec As DataGridViewTextBoxColumn
        Friend WithEvents DetonationVelocityFtSec As DataGridViewTextBoxColumn
    End Class
End Namespace