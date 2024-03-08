Imports System.Reflection.Emit

Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Dim dollars As Integer
    Public Property bankAccount As Decimal



    Private Sub SpinButton_Click(sender As Object, e As EventArgs) Handles SpinButton.Click
        Timer1.Enabled = True
        If dollars >= 1 Then
            dollars -= 1
            Label1.Text = dollars.ToString("c2")
            WheelControl4.Spin()
            WheelControl5.Spin()
            WheelControl6.Spin()
            r1Label.Text = WheelControl4.itemValue
            r2Label.Text = WheelControl5.itemValue
            r3label.Text = WheelControl6.itemValue
        End If
    End Sub

    Private Sub AddMoney_Click(sender As Object, e As EventArgs) Handles AddMoney.Click
        dollars += 1
        Label1.Text = dollars.ToString("c2")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        r1Label.Text = WheelControl4.itemValue
        r2Label.Text = WheelControl5.itemValue
        r3label.Text = WheelControl6.itemValue
        Timer1.Enabled = False
        If WheelControl4.itemValue = WheelControl5.itemValue And WheelControl5.itemValue = WheelControl6.itemValue Then
            BackColor = Color.Green
        Else
            BackColor = Color.White
        End If
    End Sub
End Class
