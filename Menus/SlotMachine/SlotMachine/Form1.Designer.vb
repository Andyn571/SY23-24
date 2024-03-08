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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SpinButton = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.r1Label = New System.Windows.Forms.Label()
        Me.r2Label = New System.Windows.Forms.Label()
        Me.r3label = New System.Windows.Forms.Label()
        Me.WheelControl4 = New SlotMachine.WheelControl()
        Me.WheelControl5 = New SlotMachine.WheelControl()
        Me.WheelControl6 = New SlotMachine.WheelControl()
        Me.AddMoney = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SpinButton
        '
        Me.SpinButton.Location = New System.Drawing.Point(281, 277)
        Me.SpinButton.Name = "SpinButton"
        Me.SpinButton.Size = New System.Drawing.Size(188, 33)
        Me.SpinButton.TabIndex = 0
        Me.SpinButton.Text = "Spin"
        Me.SpinButton.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "images.png")
        Me.ImageList1.Images.SetKeyName(1, "images (1).png")
        Me.ImageList1.Images.SetKeyName(2, "images (3).png")
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'r1Label
        '
        Me.r1Label.AutoSize = True
        Me.r1Label.Location = New System.Drawing.Point(87, 237)
        Me.r1Label.Name = "r1Label"
        Me.r1Label.Size = New System.Drawing.Size(53, 20)
        Me.r1Label.TabIndex = 5
        Me.r1Label.Text = "Label1"
        '
        'r2Label
        '
        Me.r2Label.AutoSize = True
        Me.r2Label.Location = New System.Drawing.Point(281, 237)
        Me.r2Label.Name = "r2Label"
        Me.r2Label.Size = New System.Drawing.Size(53, 20)
        Me.r2Label.TabIndex = 6
        Me.r2Label.Text = "Label2"
        '
        'r3label
        '
        Me.r3label.AutoSize = True
        Me.r3label.Location = New System.Drawing.Point(475, 237)
        Me.r3label.Name = "r3label"
        Me.r3label.Size = New System.Drawing.Size(53, 20)
        Me.r3label.TabIndex = 7
        Me.r3label.Text = "Label3"
        '
        'WheelControl4
        '
        Me.WheelControl4.itemValue = 0
        Me.WheelControl4.Location = New System.Drawing.Point(87, 46)
        Me.WheelControl4.Name = "WheelControl4"
        Me.WheelControl4.Size = New System.Drawing.Size(188, 188)
        Me.WheelControl4.spinTime = 2000
        Me.WheelControl4.TabIndex = 8
        '
        'WheelControl5
        '
        Me.WheelControl5.itemValue = 0
        Me.WheelControl5.Location = New System.Drawing.Point(281, 46)
        Me.WheelControl5.Name = "WheelControl5"
        Me.WheelControl5.Size = New System.Drawing.Size(188, 188)
        Me.WheelControl5.spinTime = 2000
        Me.WheelControl5.TabIndex = 9
        '
        'WheelControl6
        '
        Me.WheelControl6.itemValue = 0
        Me.WheelControl6.Location = New System.Drawing.Point(475, 46)
        Me.WheelControl6.Name = "WheelControl6"
        Me.WheelControl6.Size = New System.Drawing.Size(188, 188)
        Me.WheelControl6.spinTime = 2000
        Me.WheelControl6.TabIndex = 10
        '
        'AddMoney
        '
        Me.AddMoney.Location = New System.Drawing.Point(329, 336)
        Me.AddMoney.Name = "AddMoney"
        Me.AddMoney.Size = New System.Drawing.Size(94, 29)
        Me.AddMoney.TabIndex = 12
        Me.AddMoney.Text = "AddMoney"
        Me.AddMoney.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(346, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddMoney)
        Me.Controls.Add(Me.WheelControl6)
        Me.Controls.Add(Me.WheelControl5)
        Me.Controls.Add(Me.WheelControl4)
        Me.Controls.Add(Me.r3label)
        Me.Controls.Add(Me.r2Label)
        Me.Controls.Add(Me.r1Label)
        Me.Controls.Add(Me.SpinButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SpinButton As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents WheelControl1 As WheelControl
    Friend WithEvents WheelControl2 As WheelControl
    Friend WithEvents WheelControl3 As WheelControl
    Friend WithEvents r1Label As Label
    Friend WithEvents r2Label As Label
    Friend WithEvents r3label As Label
    Friend WithEvents WheelControl4 As WheelControl
    Friend WithEvents WheelControl5 As WheelControl
    Friend WithEvents WheelControl6 As WheelControl
    Friend WithEvents AddMoney As Button
    Friend WithEvents Label1 As Label
End Class
