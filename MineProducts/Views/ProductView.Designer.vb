Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ProductView
        
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductView))
        Me.MineComboBox = New System.Windows.Forms.ComboBox()
        Me.ToMineLbl = New System.Windows.Forms.Label()
        Me.CreateCloneBtn = New System.Windows.Forms.Button()
        Me.ExplosiveDensityTxt = New System.Windows.Forms.TextBox()
        Me.FumeClassTxt = New System.Windows.Forms.TextBox()
        Me.ProductNameTxt = New System.Windows.Forms.TextBox()
        Me.ApplicationEndUseTxt = New System.Windows.Forms.TextBox()
        Me.explosiveDensityLbl = New System.Windows.Forms.Label()
        Me.fumeClassLbl = New System.Windows.Forms.Label()
        Me.appEndUseLbl = New System.Windows.Forms.Label()
        Me.explosiveProductLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'MineComboBox
        '
        Me.MineComboBox.DisplayMember = "Name"
        Me.MineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MineComboBox.FormattingEnabled = true
        Me.MineComboBox.Location = New System.Drawing.Point(144, 24)
        Me.MineComboBox.Name = "MineComboBox"
        Me.MineComboBox.Size = New System.Drawing.Size(160, 21)
        Me.MineComboBox.TabIndex = 27
        '
        'ToMineLbl
        '
        Me.ToMineLbl.AutoSize = true
        Me.ToMineLbl.Location = New System.Drawing.Point(24, 24)
        Me.ToMineLbl.Name = "ToMineLbl"
        Me.ToMineLbl.Size = New System.Drawing.Size(33, 13)
        Me.ToMineLbl.TabIndex = 33
        Me.ToMineLbl.Text = "Mine:"
        '
        'CreateCloneBtn
        '
        Me.CreateCloneBtn.Location = New System.Drawing.Point(120, 224)
        Me.CreateCloneBtn.Name = "CreateCloneBtn"
        Me.CreateCloneBtn.Size = New System.Drawing.Size(75, 23)
        Me.CreateCloneBtn.TabIndex = 28
        Me.CreateCloneBtn.Text = "Create"
        Me.CreateCloneBtn.UseVisualStyleBackColor = true
        '
        'ExplosiveDensityTxt
        '
        Me.ExplosiveDensityTxt.Location = New System.Drawing.Point(144, 184)
        Me.ExplosiveDensityTxt.Name = "ExplosiveDensityTxt"
        Me.ExplosiveDensityTxt.Size = New System.Drawing.Size(120, 20)
        Me.ExplosiveDensityTxt.TabIndex = 26
        '
        'FumeClassTxt
        '
        Me.FumeClassTxt.Location = New System.Drawing.Point(144, 144)
        Me.FumeClassTxt.Name = "FumeClassTxt"
        Me.FumeClassTxt.Size = New System.Drawing.Size(160, 20)
        Me.FumeClassTxt.TabIndex = 25
        '
        'ProductNameTxt
        '
        Me.ProductNameTxt.Location = New System.Drawing.Point(144, 64)
        Me.ProductNameTxt.Name = "ProductNameTxt"
        Me.ProductNameTxt.Size = New System.Drawing.Size(160, 20)
        Me.ProductNameTxt.TabIndex = 23
        '
        'ApplicationEndUseTxt
        '
        Me.ApplicationEndUseTxt.Location = New System.Drawing.Point(144, 104)
        Me.ApplicationEndUseTxt.Name = "ApplicationEndUseTxt"
        Me.ApplicationEndUseTxt.Size = New System.Drawing.Size(160, 20)
        Me.ApplicationEndUseTxt.TabIndex = 24
        '
        'explosiveDensityLbl
        '
        Me.explosiveDensityLbl.AutoSize = true
        Me.explosiveDensityLbl.Location = New System.Drawing.Point(24, 184)
        Me.explosiveDensityLbl.Name = "explosiveDensityLbl"
        Me.explosiveDensityLbl.Size = New System.Drawing.Size(93, 13)
        Me.explosiveDensityLbl.TabIndex = 29
        Me.explosiveDensityLbl.Text = "Explosive Density:"
        '
        'fumeClassLbl
        '
        Me.fumeClassLbl.AutoSize = true
        Me.fumeClassLbl.Location = New System.Drawing.Point(24, 144)
        Me.fumeClassLbl.Name = "fumeClassLbl"
        Me.fumeClassLbl.Size = New System.Drawing.Size(64, 13)
        Me.fumeClassLbl.TabIndex = 30
        Me.fumeClassLbl.Text = "Fume Class:"
        '
        'appEndUseLbl
        '
        Me.appEndUseLbl.AutoSize = true
        Me.appEndUseLbl.Location = New System.Drawing.Point(24, 104)
        Me.appEndUseLbl.Name = "appEndUseLbl"
        Me.appEndUseLbl.Size = New System.Drawing.Size(106, 13)
        Me.appEndUseLbl.TabIndex = 31
        Me.appEndUseLbl.Text = "Application End Use:"
        '
        'explosiveProductLbl
        '
        Me.explosiveProductLbl.AutoSize = true
        Me.explosiveProductLbl.Location = New System.Drawing.Point(24, 64)
        Me.explosiveProductLbl.Name = "explosiveProductLbl"
        Me.explosiveProductLbl.Size = New System.Drawing.Size(95, 13)
        Me.explosiveProductLbl.TabIndex = 32
        Me.explosiveProductLbl.Text = "Explosive Product:"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(272, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "g/cc"
        '
        'ProductView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 269)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MineComboBox)
        Me.Controls.Add(Me.ToMineLbl)
        Me.Controls.Add(Me.CreateCloneBtn)
        Me.Controls.Add(Me.ExplosiveDensityTxt)
        Me.Controls.Add(Me.FumeClassTxt)
        Me.Controls.Add(Me.ProductNameTxt)
        Me.Controls.Add(Me.ApplicationEndUseTxt)
        Me.Controls.Add(Me.explosiveDensityLbl)
        Me.Controls.Add(Me.fumeClassLbl)
        Me.Controls.Add(Me.appEndUseLbl)
        Me.Controls.Add(Me.explosiveProductLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "ProductView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Product"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

        Friend WithEvents MineComboBox As ComboBox
        Friend WithEvents ToMineLbl As Label
        Friend WithEvents CreateCloneBtn As Button
        Friend WithEvents ExplosiveDensityTxt As TextBox
        Friend WithEvents FumeClassTxt As TextBox
        Friend WithEvents ProductNameTxt As TextBox
        Friend WithEvents ApplicationEndUseTxt As TextBox
        Friend WithEvents explosiveDensityLbl As Label
        Friend WithEvents fumeClassLbl As Label
        Friend WithEvents appEndUseLbl As Label
        Friend WithEvents explosiveProductLbl As Label
        Friend WithEvents Label1 As Label
    End Class
End NameSpace