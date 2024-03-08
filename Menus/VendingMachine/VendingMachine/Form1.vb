Imports System.Net.Security

Public Class Form1
    Dim WithEvents cs As New CoinSlot
    Private Sub NickelButton_Click(sender As Object, e As EventArgs) Handles NickelButton.Click
        cs.insertnickel()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub DimeButton_Click(sender As Object, e As EventArgs) Handles DimeButton.Click
        cs.insertdimes()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub QuarterButton_Click(sender As Object, e As EventArgs) Handles QuarterButton.Click
        cs.insertquarter()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub DollarButton_Click(sender As Object, e As EventArgs) Handles DollarButton.Click
        cs.insertdollars()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub CoinReturnButton_Click(sender As Object, e As EventArgs) Handles CoinReturnButton.Click
        cs.coinreturn()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            dollarpb.Visible = True
        Else
            dollarpb.Visible = False
        End If
        If q > 0 Then
            quarterpb.Visible = True
        Else
            quarterpb.Visible = False
        End If
        If di > 0 Then
            dimepb.Visible = True
        Else
            dimepb.Visible = False
        End If
        If n > 0 Then
            nickelpb.Visible = True
        Else
            nickelpb.Visible = False
        End If
    End Sub

    Private Sub ProductControl2_Load(sender As Object, e As EventArgs) Handles ProductControl2.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case IDTextBox.Text
            Case ProductControl1.productid
                cs.buy(ProductControl1)
            Case ProductControl2.productid
                cs.buy(ProductControl2)
            Case ProductControl3.productid
                cs.buy(ProductControl3)
            Case ProductControl4.productid
                cs.buy(ProductControl4)
            Case ProductControl5.productid
                cs.buy(ProductControl5)
            Case ProductControl6.productid
                cs.buy(ProductControl6)
            Case ProductControl7.productid
                cs.buy(ProductControl7)
            Case ProductControl8.productid
                cs.buy(ProductControl8)
            Case ProductControl9.productid
                cs.buy(ProductControl9)
            Case ProductControl10.productid
                cs.buy(ProductControl10)
            Case ProductControl11.productid
                cs.buy(ProductControl11)
            Case ProductControl12.productid
                cs.buy(ProductControl12)
            Case ProductControl13.productid
                cs.buy(ProductControl13)
            Case ProductControl14.productid
                cs.buy(ProductControl14)
            Case ProductControl15.productid
                cs.buy(ProductControl15)
            Case ProductControl16.productid
                cs.buy(ProductControl16)
            Case Else
        End Select
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_buyevent(p As Image) Handles cs.buyevent
        ProductPicture.Image = p

    End Sub
End Class
