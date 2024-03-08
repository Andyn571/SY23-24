Public Class ProductControl
    Public Property productid As String
    Public Property productprice As Decimal
    Public Property productimage As Image
    Public Property productcount As Integer
    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDLabel.Text = productid
        PriceLabel.Text = productprice.ToString("c2")
        PictureBox1.Image = productimage
    End Sub
    Sub buy()
        If productcount > 0 Then
            productcount = productcount - 1
        End If
        If productcount = 0 Then
            PictureBox1.Image = Nothing
        End If

    End Sub
End Class
