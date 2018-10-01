<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MineComboBox = New System.Windows.Forms.ComboBox()
        Me.MineLbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.explosiveDensityTxtBox = New System.Windows.Forms.TextBox()
        Me.fumeClassTxtBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.appEndUseTxtBox = New System.Windows.Forms.TextBox()
        Me.explosiveDensityLbl = New System.Windows.Forms.Label()
        Me.fumeClassLbl = New System.Windows.Forms.Label()
        Me.appEndUseLbl = New System.Windows.Forms.Label()
        Me.explosiveProductLbl = New System.Windows.Forms.Label()
        Me.NewProductRdBtn = New System.Windows.Forms.RadioButton()
        Me.CloneProductRdBtn = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.MineComboBox)
        Me.GroupBox1.Controls.Add(Me.MineLbl)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.explosiveDensityTxtBox)
        Me.GroupBox1.Controls.Add(Me.fumeClassTxtBox)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.appEndUseTxtBox)
        Me.GroupBox1.Controls.Add(Me.explosiveDensityLbl)
        Me.GroupBox1.Controls.Add(Me.fumeClassLbl)
        Me.GroupBox1.Controls.Add(Me.appEndUseLbl)
        Me.GroupBox1.Controls.Add(Me.explosiveProductLbl)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 296)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "New Product"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(128, 224)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox2.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "To Mine"
        '
        'MineComboBox
        '
        Me.MineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MineComboBox.Enabled = False
        Me.MineComboBox.FormattingEnabled = True
        Me.MineComboBox.Location = New System.Drawing.Point(128, 24)
        Me.MineComboBox.Name = "MineComboBox"
        Me.MineComboBox.Size = New System.Drawing.Size(160, 21)
        Me.MineComboBox.TabIndex = 21
        '
        'MineLbl
        '
        Me.MineLbl.AutoSize = True
        Me.MineLbl.Enabled = False
        Me.MineLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MineLbl.Location = New System.Drawing.Point(8, 24)
        Me.MineLbl.Name = "MineLbl"
        Me.MineLbl.Size = New System.Drawing.Size(56, 13)
        Me.MineLbl.TabIndex = 20
        Me.MineLbl.Text = "From Mine"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'explosiveDensityTxtBox
        '
        Me.explosiveDensityTxtBox.Location = New System.Drawing.Point(128, 184)
        Me.explosiveDensityTxtBox.Name = "explosiveDensityTxtBox"
        Me.explosiveDensityTxtBox.Size = New System.Drawing.Size(160, 20)
        Me.explosiveDensityTxtBox.TabIndex = 15
        '
        'fumeClassTxtBox
        '
        Me.fumeClassTxtBox.Location = New System.Drawing.Point(128, 144)
        Me.fumeClassTxtBox.Name = "fumeClassTxtBox"
        Me.fumeClassTxtBox.Size = New System.Drawing.Size(160, 20)
        Me.fumeClassTxtBox.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(160, 20)
        Me.TextBox1.TabIndex = 17
        '
        'appEndUseTxtBox
        '
        Me.appEndUseTxtBox.Location = New System.Drawing.Point(128, 104)
        Me.appEndUseTxtBox.Name = "appEndUseTxtBox"
        Me.appEndUseTxtBox.Size = New System.Drawing.Size(160, 20)
        Me.appEndUseTxtBox.TabIndex = 18
        '
        'explosiveDensityLbl
        '
        Me.explosiveDensityLbl.AutoSize = True
        Me.explosiveDensityLbl.Location = New System.Drawing.Point(8, 184)
        Me.explosiveDensityLbl.Name = "explosiveDensityLbl"
        Me.explosiveDensityLbl.Size = New System.Drawing.Size(93, 13)
        Me.explosiveDensityLbl.TabIndex = 11
        Me.explosiveDensityLbl.Text = "Explosive Density:"
        '
        'fumeClassLbl
        '
        Me.fumeClassLbl.AutoSize = True
        Me.fumeClassLbl.Location = New System.Drawing.Point(8, 144)
        Me.fumeClassLbl.Name = "fumeClassLbl"
        Me.fumeClassLbl.Size = New System.Drawing.Size(64, 13)
        Me.fumeClassLbl.TabIndex = 12
        Me.fumeClassLbl.Text = "Fume Class:"
        '
        'appEndUseLbl
        '
        Me.appEndUseLbl.AutoSize = True
        Me.appEndUseLbl.Location = New System.Drawing.Point(8, 104)
        Me.appEndUseLbl.Name = "appEndUseLbl"
        Me.appEndUseLbl.Size = New System.Drawing.Size(106, 13)
        Me.appEndUseLbl.TabIndex = 13
        Me.appEndUseLbl.Text = "Application End Use:"
        '
        'explosiveProductLbl
        '
        Me.explosiveProductLbl.AutoSize = True
        Me.explosiveProductLbl.Location = New System.Drawing.Point(8, 64)
        Me.explosiveProductLbl.Name = "explosiveProductLbl"
        Me.explosiveProductLbl.Size = New System.Drawing.Size(95, 13)
        Me.explosiveProductLbl.TabIndex = 14
        Me.explosiveProductLbl.Text = "Explosive Product:"
        '
        'NewProductRdBtn
        '
        Me.NewProductRdBtn.AutoSize = True
        Me.NewProductRdBtn.Location = New System.Drawing.Point(48, 8)
        Me.NewProductRdBtn.Name = "NewProductRdBtn"
        Me.NewProductRdBtn.Size = New System.Drawing.Size(87, 17)
        Me.NewProductRdBtn.TabIndex = 15
        Me.NewProductRdBtn.TabStop = True
        Me.NewProductRdBtn.Text = "New Product"
        Me.NewProductRdBtn.UseVisualStyleBackColor = True
        '
        'CloneProductRdBtn
        '
        Me.CloneProductRdBtn.AutoSize = True
        Me.CloneProductRdBtn.Location = New System.Drawing.Point(192, 8)
        Me.CloneProductRdBtn.Name = "CloneProductRdBtn"
        Me.CloneProductRdBtn.Size = New System.Drawing.Size(92, 17)
        Me.CloneProductRdBtn.TabIndex = 15
        Me.CloneProductRdBtn.TabStop = True
        Me.CloneProductRdBtn.Text = "Clone Product"
        Me.CloneProductRdBtn.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(128, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 344)
        Me.Controls.Add(Me.CloneProductRdBtn)
        Me.Controls.Add(Me.NewProductRdBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents explosiveDensityTxtBox As TextBox
    Friend WithEvents fumeClassTxtBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents appEndUseTxtBox As TextBox
    Friend WithEvents explosiveDensityLbl As Label
    Friend WithEvents fumeClassLbl As Label
    Friend WithEvents appEndUseLbl As Label
    Friend WithEvents explosiveProductLbl As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MineComboBox As ComboBox
    Friend WithEvents MineLbl As Label
    Friend WithEvents NewProductRdBtn As RadioButton
    Friend WithEvents CloneProductRdBtn As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
End Class
