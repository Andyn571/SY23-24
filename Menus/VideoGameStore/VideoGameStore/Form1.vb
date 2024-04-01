Imports System.IO
Imports System.Reflection.Emit

Public Class Form1
    Dim records(50) As String
    Dim count As Integer
    Dim current As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveToFile()
        If count > 0 Then
            current = count - 1
            ShowRecord(current)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SaveToFile()
        If current < count - 1 Then
            current = current + 1
        End If
        ShowRecord(current)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveToFile()
        current = 0
        ShowRecord(current)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Field1.Text = ""
        Field2.Text = ""
        Field3.Text = ""
        Field4.Text = ""
        Field5.Text = ""
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        current = count
        count = count + 1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        OpenFileDialog2.ShowDialog()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        OpenFileDialog3.ShowDialog()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        OpenFileDialog4.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
        PictureBox2.Load(OpenFileDialog1.FileName)
        PictureBox3.Load(OpenFileDialog1.FileName)
        PictureBox4.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveToFile()
    End Sub
    Sub SaveToFile()
        Dim r As String
        r += Field1.Text
        r += "|"
        r += Field2.Text
        r += "|"
        r += Field3.Text
        r += "|"
        r += Field4.Text
        r += "|"
        r += Field5.Text
        r += "|"
        r += Field6.Text
        r += "|"
        r += Field7.Text
        r += "|"
        r += Field8.Text
        r += "|"
        r += Field9.Text
        r += "|"
        r += Field10.Text
        r += "|"
        r += Field11.Text
        r += "|"
        r += Field12.Text
        r += "|"
        r += PictureBox1.ImageLocation
        r += PictureBox2.ImageLocation
        r += PictureBox3.ImageLocation
        r += PictureBox4.ImageLocation
        If count = 0 Then count = 1
        records(current) = r

        Dim outFile As New StreamWriter("data.txt")
        For index = 0 To count - 1
            outFile.WriteLine(records(index))
        Next
        outFile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim inFile As New StreamReader("data.txt")
            While (Not inFile.EndOfStream)
                records(count) = inFile.ReadLine
                count = count + 1
            End While
            inFile.Close()
            ShowRecord(0)
        End If
    End Sub
    Public Sub ShowRecord(index As Integer)
        PictureBox1.Image = Nothing
        If records(index) <> Nothing Then
            Dim Fields() As String
            Fields = records(index).Split("|")
            Field1.Text = Fields(0)
            Field2.Text = Fields(1)
            Field3.Text = Fields(2)
            Field4.Text = Fields(3)
            Field5.Text = Fields(4)
            Field6.Text = Fields(5)
            Field7.Text = Fields(6)
            Field8.Text = Fields(7)
            Field9.Text = Fields(8)
            Field10.Text = Fields(9)
            Field11.Text = Fields(10)
            Field12.Text = Fields(11)
            If File.Exists(Fields(11)) Then
                PictureBox1.Load(Fields(11))
                PictureBox2.Load(Fields(11))
                PictureBox3.Load(Fields(11))
                PictureBox4.Load(Fields(11))
            End If
        End If
    End Sub
End Class
