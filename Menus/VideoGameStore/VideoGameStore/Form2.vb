Imports System.Reflection.Emit

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        dollars += 1
        Label4.Text = dollars.ToString("c2")
    End Sub
End Class