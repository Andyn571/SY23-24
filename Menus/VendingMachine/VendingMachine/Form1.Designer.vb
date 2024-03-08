<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.DollarButton = New System.Windows.Forms.Button()
        Me.QuarterButton = New System.Windows.Forms.Button()
        Me.DimeButton = New System.Windows.Forms.Button()
        Me.NickelButton = New System.Windows.Forms.Button()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.CoinReturnButton = New System.Windows.Forms.Button()
        Me.dollarpb = New System.Windows.Forms.PictureBox()
        Me.quarterpb = New System.Windows.Forms.PictureBox()
        Me.dimepb = New System.Windows.Forms.PictureBox()
        Me.nickelpb = New System.Windows.Forms.PictureBox()
        Me.ProductControl1 = New VendingMachine.ProductControl()
        Me.ProductControl2 = New VendingMachine.ProductControl()
        Me.ProductControl3 = New VendingMachine.ProductControl()
        Me.ProductControl4 = New VendingMachine.ProductControl()
        Me.ProductControl5 = New VendingMachine.ProductControl()
        Me.ProductControl6 = New VendingMachine.ProductControl()
        Me.ProductControl7 = New VendingMachine.ProductControl()
        Me.ProductControl8 = New VendingMachine.ProductControl()
        Me.ProductControl9 = New VendingMachine.ProductControl()
        Me.ProductControl10 = New VendingMachine.ProductControl()
        Me.ProductControl11 = New VendingMachine.ProductControl()
        Me.ProductControl12 = New VendingMachine.ProductControl()
        Me.ProductControl13 = New VendingMachine.ProductControl()
        Me.ProductControl14 = New VendingMachine.ProductControl()
        Me.ProductControl15 = New VendingMachine.ProductControl()
        Me.ProductControl16 = New VendingMachine.ProductControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductPicture = New System.Windows.Forms.PictureBox()
        CType(Me.dollarpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quarterpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimepb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nickelpb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DollarButton
        '
        Me.DollarButton.BackgroundImage = Global.VendingMachine.My.Resources.Resources.dollarcoin
        Me.DollarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DollarButton.Location = New System.Drawing.Point(25, 36)
        Me.DollarButton.Name = "DollarButton"
        Me.DollarButton.Size = New System.Drawing.Size(71, 59)
        Me.DollarButton.TabIndex = 0
        Me.DollarButton.Text = "Dollars"
        Me.DollarButton.UseVisualStyleBackColor = True
        '
        'QuarterButton
        '
        Me.QuarterButton.BackgroundImage = Global.VendingMachine.My.Resources.Resources.quarter
        Me.QuarterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.QuarterButton.Location = New System.Drawing.Point(125, 36)
        Me.QuarterButton.Name = "QuarterButton"
        Me.QuarterButton.Size = New System.Drawing.Size(71, 59)
        Me.QuarterButton.TabIndex = 1
        Me.QuarterButton.Text = "Quarters"
        Me.QuarterButton.UseVisualStyleBackColor = True
        '
        'DimeButton
        '
        Me.DimeButton.BackgroundImage = Global.VendingMachine.My.Resources.Resources.dime_
        Me.DimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DimeButton.Location = New System.Drawing.Point(25, 140)
        Me.DimeButton.Name = "DimeButton"
        Me.DimeButton.Size = New System.Drawing.Size(71, 59)
        Me.DimeButton.TabIndex = 2
        Me.DimeButton.Text = "Dimes"
        Me.DimeButton.UseVisualStyleBackColor = True
        '
        'NickelButton
        '
        Me.NickelButton.BackgroundImage = Global.VendingMachine.My.Resources.Resources.nickel
        Me.NickelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NickelButton.Location = New System.Drawing.Point(125, 140)
        Me.NickelButton.Name = "NickelButton"
        Me.NickelButton.Size = New System.Drawing.Size(71, 59)
        Me.NickelButton.TabIndex = 3
        Me.NickelButton.Text = "Nickles"
        Me.NickelButton.UseVisualStyleBackColor = True
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(186, 1)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(53, 20)
        Me.TotalLabel.TabIndex = 4
        Me.TotalLabel.Text = "Label1"
        '
        'CoinReturnButton
        '
        Me.CoinReturnButton.Location = New System.Drawing.Point(2, 205)
        Me.CoinReturnButton.Name = "CoinReturnButton"
        Me.CoinReturnButton.Size = New System.Drawing.Size(194, 29)
        Me.CoinReturnButton.TabIndex = 5
        Me.CoinReturnButton.Text = "CoinReturn"
        Me.CoinReturnButton.UseVisualStyleBackColor = True
        '
        'dollarpb
        '
        Me.dollarpb.BackgroundImage = Global.VendingMachine.My.Resources.Resources.dollarcoin
        Me.dollarpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.dollarpb.Location = New System.Drawing.Point(2, 240)
        Me.dollarpb.Name = "dollarpb"
        Me.dollarpb.Size = New System.Drawing.Size(40, 52)
        Me.dollarpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dollarpb.TabIndex = 6
        Me.dollarpb.TabStop = False
        Me.dollarpb.Visible = False
        '
        'quarterpb
        '
        Me.quarterpb.BackgroundImage = Global.VendingMachine.My.Resources.Resources.quarter
        Me.quarterpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.quarterpb.Location = New System.Drawing.Point(48, 240)
        Me.quarterpb.Name = "quarterpb"
        Me.quarterpb.Size = New System.Drawing.Size(40, 52)
        Me.quarterpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.quarterpb.TabIndex = 7
        Me.quarterpb.TabStop = False
        Me.quarterpb.Visible = False
        '
        'dimepb
        '
        Me.dimepb.BackgroundImage = Global.VendingMachine.My.Resources.Resources.dime_
        Me.dimepb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.dimepb.Location = New System.Drawing.Point(2, 298)
        Me.dimepb.Name = "dimepb"
        Me.dimepb.Size = New System.Drawing.Size(40, 52)
        Me.dimepb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dimepb.TabIndex = 7
        Me.dimepb.TabStop = False
        Me.dimepb.Visible = False
        '
        'nickelpb
        '
        Me.nickelpb.BackgroundImage = Global.VendingMachine.My.Resources.Resources.nickel
        Me.nickelpb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.nickelpb.Location = New System.Drawing.Point(48, 298)
        Me.nickelpb.Name = "nickelpb"
        Me.nickelpb.Size = New System.Drawing.Size(40, 52)
        Me.nickelpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nickelpb.TabIndex = 7
        Me.nickelpb.TabStop = False
        Me.nickelpb.Visible = False
        '
        'ProductControl1
        '
        Me.ProductControl1.Location = New System.Drawing.Point(479, 1)
        Me.ProductControl1.Name = "ProductControl1"
        Me.ProductControl1.productcount = 3
        Me.ProductControl1.productid = "A1"
        Me.ProductControl1.productimage = Global.VendingMachine.My.Resources.Resources.Lighthouse299_99_
        Me.ProductControl1.productprice = New Decimal(New Integer() {29999, 0, 0, 131072})
        Me.ProductControl1.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl1.TabIndex = 8
        '
        'ProductControl2
        '
        Me.ProductControl2.Location = New System.Drawing.Point(599, 1)
        Me.ProductControl2.Name = "ProductControl2"
        Me.ProductControl2.productcount = 2
        Me.ProductControl2.productid = "A2"
        Me.ProductControl2.productimage = Global.VendingMachine.My.Resources.Resources.WhiteHouse99_99
        Me.ProductControl2.productprice = New Decimal(New Integer() {9999, 0, 0, 131072})
        Me.ProductControl2.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl2.TabIndex = 9
        '
        'ProductControl3
        '
        Me.ProductControl3.Location = New System.Drawing.Point(719, 1)
        Me.ProductControl3.Name = "ProductControl3"
        Me.ProductControl3.productcount = 3
        Me.ProductControl3.productid = "A3"
        Me.ProductControl3.productimage = Global.VendingMachine.My.Resources.Resources.Boutique259_99
        Me.ProductControl3.productprice = New Decimal(New Integer() {25999, 0, 0, 131072})
        Me.ProductControl3.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl3.TabIndex = 10
        '
        'ProductControl4
        '
        Me.ProductControl4.Location = New System.Drawing.Point(839, 1)
        Me.ProductControl4.Name = "ProductControl4"
        Me.ProductControl4.productcount = 4
        Me.ProductControl4.productid = "A4"
        Me.ProductControl4.productimage = Global.VendingMachine.My.Resources.Resources.AT_AT849_95
        Me.ProductControl4.productprice = New Decimal(New Integer() {84999, 0, 0, 131072})
        Me.ProductControl4.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl4.TabIndex = 11
        '
        'ProductControl5
        '
        Me.ProductControl5.Location = New System.Drawing.Point(479, 96)
        Me.ProductControl5.Name = "ProductControl5"
        Me.ProductControl5.productcount = 2
        Me.ProductControl5.productid = "B1"
        Me.ProductControl5.productimage = Global.VendingMachine.My.Resources.Resources.Gauntlet63_99
        Me.ProductControl5.productprice = New Decimal(New Integer() {6399, 0, 0, 131072})
        Me.ProductControl5.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl5.TabIndex = 12
        '
        'ProductControl6
        '
        Me.ProductControl6.Location = New System.Drawing.Point(599, 96)
        Me.ProductControl6.Name = "ProductControl6"
        Me.ProductControl6.productcount = 3
        Me.ProductControl6.productid = "B2"
        Me.ProductControl6.productimage = Global.VendingMachine.My.Resources.Resources.Dagobah110_00
        Me.ProductControl6.productprice = New Decimal(New Integer() {11000, 0, 0, 131072})
        Me.ProductControl6.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl6.TabIndex = 13
        '
        'ProductControl7
        '
        Me.ProductControl7.Location = New System.Drawing.Point(719, 96)
        Me.ProductControl7.Name = "ProductControl7"
        Me.ProductControl7.productcount = 4
        Me.ProductControl7.productid = "B3"
        Me.ProductControl7.productimage = Global.VendingMachine.My.Resources.Resources.himeji159_95
        Me.ProductControl7.productprice = New Decimal(New Integer() {15995, 0, 0, 131072})
        Me.ProductControl7.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl7.TabIndex = 19
        '
        'ProductControl8
        '
        Me.ProductControl8.Location = New System.Drawing.Point(839, 96)
        Me.ProductControl8.Name = "ProductControl8"
        Me.ProductControl8.productcount = 2
        Me.ProductControl8.productid = "B4"
        Me.ProductControl8.productimage = Global.VendingMachine.My.Resources.Resources.R2D2_239_99
        Me.ProductControl8.productprice = New Decimal(New Integer() {23999, 0, 0, 131072})
        Me.ProductControl8.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl8.TabIndex = 18
        '
        'ProductControl9
        '
        Me.ProductControl9.Location = New System.Drawing.Point(479, 205)
        Me.ProductControl9.Name = "ProductControl9"
        Me.ProductControl9.productcount = 1
        Me.ProductControl9.productid = "C1"
        Me.ProductControl9.productimage = Global.VendingMachine.My.Resources.Resources.Rover239_95
        Me.ProductControl9.productprice = New Decimal(New Integer() {23995, 0, 0, 131072})
        Me.ProductControl9.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl9.TabIndex = 17
        '
        'ProductControl10
        '
        Me.ProductControl10.Location = New System.Drawing.Point(599, 205)
        Me.ProductControl10.Name = "ProductControl10"
        Me.ProductControl10.productcount = 2
        Me.ProductControl10.productid = "C2"
        Me.ProductControl10.productimage = Global.VendingMachine.My.Resources.Resources.sesame189_96
        Me.ProductControl10.productprice = New Decimal(New Integer() {18996, 0, 0, 131072})
        Me.ProductControl10.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl10.TabIndex = 16
        '
        'ProductControl11
        '
        Me.ProductControl11.Location = New System.Drawing.Point(719, 205)
        Me.ProductControl11.Name = "ProductControl11"
        Me.ProductControl11.productcount = 3
        Me.ProductControl11.productid = "C3"
        Me.ProductControl11.productimage = Global.VendingMachine.My.Resources.Resources.TallNeck129_99
        Me.ProductControl11.productprice = New Decimal(New Integer() {12999, 0, 0, 131072})
        Me.ProductControl11.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl11.TabIndex = 15
        '
        'ProductControl12
        '
        Me.ProductControl12.Location = New System.Drawing.Point(839, 205)
        Me.ProductControl12.Name = "ProductControl12"
        Me.ProductControl12.productcount = 5
        Me.ProductControl12.productid = "C4"
        Me.ProductControl12.productimage = Global.VendingMachine.My.Resources.Resources.Dagobah110_00
        Me.ProductControl12.productprice = New Decimal(New Integer() {11000, 0, 0, 131072})
        Me.ProductControl12.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl12.TabIndex = 14
        '
        'ProductControl13
        '
        Me.ProductControl13.Location = New System.Drawing.Point(479, 314)
        Me.ProductControl13.Name = "ProductControl13"
        Me.ProductControl13.productcount = 1
        Me.ProductControl13.productid = "D1"
        Me.ProductControl13.productimage = Global.VendingMachine.My.Resources.Resources.Gauntlet63_99
        Me.ProductControl13.productprice = New Decimal(New Integer() {6399, 0, 0, 131072})
        Me.ProductControl13.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl13.TabIndex = 23
        '
        'ProductControl14
        '
        Me.ProductControl14.Location = New System.Drawing.Point(599, 314)
        Me.ProductControl14.Name = "ProductControl14"
        Me.ProductControl14.productcount = 3
        Me.ProductControl14.productid = "D2"
        Me.ProductControl14.productimage = Global.VendingMachine.My.Resources.Resources.Boutique259_99
        Me.ProductControl14.productprice = New Decimal(New Integer() {25999, 0, 0, 131072})
        Me.ProductControl14.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl14.TabIndex = 22
        '
        'ProductControl15
        '
        Me.ProductControl15.Location = New System.Drawing.Point(719, 314)
        Me.ProductControl15.Name = "ProductControl15"
        Me.ProductControl15.productcount = 3
        Me.ProductControl15.productid = "D3"
        Me.ProductControl15.productimage = Global.VendingMachine.My.Resources.Resources.WhiteHouse99_99
        Me.ProductControl15.productprice = New Decimal(New Integer() {9999, 0, 0, 131072})
        Me.ProductControl15.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl15.TabIndex = 21
        '
        'ProductControl16
        '
        Me.ProductControl16.Location = New System.Drawing.Point(839, 314)
        Me.ProductControl16.Name = "ProductControl16"
        Me.ProductControl16.productcount = 4
        Me.ProductControl16.productid = "D4"
        Me.ProductControl16.productimage = Global.VendingMachine.My.Resources.Resources.Lighthouse299_99_
        Me.ProductControl16.productprice = New Decimal(New Integer() {30000, 0, 0, 131072})
        Me.ProductControl16.Size = New System.Drawing.Size(114, 103)
        Me.ProductControl16.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Buy"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(202, 225)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(125, 27)
        Me.IDTextBox.TabIndex = 25
        '
        'ProductPicture
        '
        Me.ProductPicture.Location = New System.Drawing.Point(599, 416)
        Me.ProductPicture.Name = "ProductPicture"
        Me.ProductPicture.Size = New System.Drawing.Size(234, 126)
        Me.ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductPicture.TabIndex = 26
        Me.ProductPicture.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 554)
        Me.Controls.Add(Me.ProductPicture)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProductControl13)
        Me.Controls.Add(Me.ProductControl14)
        Me.Controls.Add(Me.ProductControl15)
        Me.Controls.Add(Me.ProductControl16)
        Me.Controls.Add(Me.ProductControl7)
        Me.Controls.Add(Me.ProductControl8)
        Me.Controls.Add(Me.ProductControl9)
        Me.Controls.Add(Me.ProductControl10)
        Me.Controls.Add(Me.ProductControl11)
        Me.Controls.Add(Me.ProductControl12)
        Me.Controls.Add(Me.ProductControl6)
        Me.Controls.Add(Me.ProductControl5)
        Me.Controls.Add(Me.ProductControl4)
        Me.Controls.Add(Me.ProductControl3)
        Me.Controls.Add(Me.ProductControl2)
        Me.Controls.Add(Me.ProductControl1)
        Me.Controls.Add(Me.nickelpb)
        Me.Controls.Add(Me.dimepb)
        Me.Controls.Add(Me.quarterpb)
        Me.Controls.Add(Me.dollarpb)
        Me.Controls.Add(Me.CoinReturnButton)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.NickelButton)
        Me.Controls.Add(Me.DimeButton)
        Me.Controls.Add(Me.QuarterButton)
        Me.Controls.Add(Me.DollarButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dollarpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quarterpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimepb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nickelpb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DollarButton As Button
    Friend WithEvents QuarterButton As Button
    Friend WithEvents DimeButton As Button
    Friend WithEvents NickelButton As Button
    Friend WithEvents TotalLabel As Label
    Friend WithEvents CoinReturnButton As Button
    Friend WithEvents dollarpb As PictureBox
    Friend WithEvents quarterpb As PictureBox
    Friend WithEvents dimepb As PictureBox
    Friend WithEvents nickelpb As PictureBox
    Friend WithEvents ProductControl1 As ProductControl
    Friend WithEvents ProductControl2 As ProductControl
    Friend WithEvents ProductControl3 As ProductControl
    Friend WithEvents ProductControl4 As ProductControl
    Friend WithEvents ProductControl5 As ProductControl
    Friend WithEvents ProductControl6 As ProductControl
    Friend WithEvents ProductControl7 As ProductControl
    Friend WithEvents ProductControl8 As ProductControl
    Friend WithEvents ProductControl9 As ProductControl
    Friend WithEvents ProductControl10 As ProductControl
    Friend WithEvents ProductControl11 As ProductControl
    Friend WithEvents ProductControl12 As ProductControl
    Friend WithEvents ProductControl13 As ProductControl
    Friend WithEvents ProductControl14 As ProductControl
    Friend WithEvents ProductControl15 As ProductControl
    Friend WithEvents ProductControl16 As ProductControl
    Friend WithEvents Button1 As Button
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents ProductPicture As PictureBox
End Class
