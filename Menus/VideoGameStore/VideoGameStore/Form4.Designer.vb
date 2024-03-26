<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.NGSItemsPic = New System.Windows.Forms.PictureBox()
        Me.BuyGameBoyButton = New System.Windows.Forms.Button()
        Me.BlueBuyButton = New System.Windows.Forms.Button()
        Me.MarioBuyButton = New System.Windows.Forms.Button()
        Me.RedBuyButton = New System.Windows.Forms.Button()
        Me.TetrisBuyButton = New System.Windows.Forms.Button()
        CType(Me.NGSItemsPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NGSItemsPic
        '
        Me.NGSItemsPic.Image = CType(resources.GetObject("NGSItemsPic.Image"), System.Drawing.Image)
        Me.NGSItemsPic.Location = New System.Drawing.Point(12, 12)
        Me.NGSItemsPic.Name = "NGSItemsPic"
        Me.NGSItemsPic.Size = New System.Drawing.Size(919, 787)
        Me.NGSItemsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NGSItemsPic.TabIndex = 0
        Me.NGSItemsPic.TabStop = False
        '
        'BuyGameBoyButton
        '
        Me.BuyGameBoyButton.Font = New System.Drawing.Font("Lucida Handwriting", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BuyGameBoyButton.Location = New System.Drawing.Point(21, 724)
        Me.BuyGameBoyButton.Name = "BuyGameBoyButton"
        Me.BuyGameBoyButton.Size = New System.Drawing.Size(388, 55)
        Me.BuyGameBoyButton.TabIndex = 1
        Me.BuyGameBoyButton.Text = "Buy Nintendo Gameboy for $90"
        Me.BuyGameBoyButton.UseVisualStyleBackColor = True
        '
        'BlueBuyButton
        '
        Me.BlueBuyButton.Font = New System.Drawing.Font("Lucida Handwriting", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BlueBuyButton.Location = New System.Drawing.Point(427, 130)
        Me.BlueBuyButton.Name = "BlueBuyButton"
        Me.BlueBuyButton.Size = New System.Drawing.Size(243, 55)
        Me.BlueBuyButton.TabIndex = 2
        Me.BlueBuyButton.Text = "Buy Pokemon Blue Catridge for $30"
        Me.BlueBuyButton.UseVisualStyleBackColor = True
        '
        'MarioBuyButton
        '
        Me.MarioBuyButton.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MarioBuyButton.Location = New System.Drawing.Point(676, 131)
        Me.MarioBuyButton.Name = "MarioBuyButton"
        Me.MarioBuyButton.Size = New System.Drawing.Size(237, 55)
        Me.MarioBuyButton.TabIndex = 3
        Me.MarioBuyButton.Text = "Buy Super Mario Land Catridge for $15"
        Me.MarioBuyButton.UseVisualStyleBackColor = True
        '
        'RedBuyButton
        '
        Me.RedBuyButton.Font = New System.Drawing.Font("Lucida Handwriting", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RedBuyButton.Location = New System.Drawing.Point(427, 458)
        Me.RedBuyButton.Name = "RedBuyButton"
        Me.RedBuyButton.Size = New System.Drawing.Size(243, 55)
        Me.RedBuyButton.TabIndex = 4
        Me.RedBuyButton.Text = "Buy Pokemon Red Catridge for $30"
        Me.RedBuyButton.UseVisualStyleBackColor = True
        '
        'TetrisBuyButton
        '
        Me.TetrisBuyButton.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TetrisBuyButton.Location = New System.Drawing.Point(676, 458)
        Me.TetrisBuyButton.Name = "TetrisBuyButton"
        Me.TetrisBuyButton.Size = New System.Drawing.Size(237, 55)
        Me.TetrisBuyButton.TabIndex = 5
        Me.TetrisBuyButton.Text = "Buy Tetris for $20"
        Me.TetrisBuyButton.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(943, 811)
        Me.Controls.Add(Me.TetrisBuyButton)
        Me.Controls.Add(Me.RedBuyButton)
        Me.Controls.Add(Me.MarioBuyButton)
        Me.Controls.Add(Me.BlueBuyButton)
        Me.Controls.Add(Me.BuyGameBoyButton)
        Me.Controls.Add(Me.NGSItemsPic)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.NGSItemsPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NGSItemsPic As PictureBox
    Friend WithEvents BuyGameBoyButton As Button
    Friend WithEvents BlueBuyButton As Button
    Friend WithEvents MarioBuyButton As Button
    Friend WithEvents RedBuyButton As Button
    Friend WithEvents TetrisBuyButton As Button
End Class
