Namespace Views
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MineView

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MineView))
        Me.mineTxt = New System.Windows.Forms.TextBox()
        Me.mineLbl = New System.Windows.Forms.Label()
        Me.createMineBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'mineTxt
        '
        Me.mineTxt.Location = New System.Drawing.Point(88, 24)
        Me.mineTxt.Name = "mineTxt"
        Me.mineTxt.Size = New System.Drawing.Size(160, 20)
        Me.mineTxt.TabIndex = 0
        '
        'mineLbl
        '
        Me.mineLbl.AutoSize = true
        Me.mineLbl.Location = New System.Drawing.Point(16, 24)
        Me.mineLbl.Name = "mineLbl"
        Me.mineLbl.Size = New System.Drawing.Size(64, 13)
        Me.mineLbl.TabIndex = 10
        Me.mineLbl.Text = "Mine Name:"
        '
        'createMineBtn
        '
        Me.createMineBtn.Location = New System.Drawing.Point(104, 56)
        Me.createMineBtn.Name = "createMineBtn"
        Me.createMineBtn.Size = New System.Drawing.Size(75, 23)
        Me.createMineBtn.TabIndex = 1
        Me.createMineBtn.Text = "Create"
        Me.createMineBtn.UseVisualStyleBackColor = true
        '
        'MineView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 93)
        Me.Controls.Add(Me.createMineBtn)
        Me.Controls.Add(Me.mineTxt)
        Me.Controls.Add(Me.mineLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "MineView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Mine"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

        Friend WithEvents mineTxt As TextBox
        Friend WithEvents mineLbl As Label
        Friend WithEvents createMineBtn As Button
    End Class
End NameSpace