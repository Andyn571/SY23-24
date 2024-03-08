Public Class Form2dPlatformer
    Dim movespeed As Integer = 5
    Dim isjumping As Boolean
    Dim Artifact As Integer
    Private Sub Form2dPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.D
                TMRD.Start()
            Case Keys.A
                TMRA.Start()
            Case Keys.W
                TMRW.Start()
                isjumping = True
        End Select
    End Sub

    Private Sub TMRD_Tick(sender As Object, e As EventArgs) Handles TMRD.Tick
        PicPlayer2.Left += movespeed
    End Sub

    Private Sub Form2dPlatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.D
                TMRD.Stop()
            Case Keys.A
                TMRA.Stop()
            Case Keys.W
                TMRW.Stop()
                isjumping = False
        End Select
    End Sub

    Private Sub TMRA_Tick(sender As Object, e As EventArgs) Handles TMRA.Tick
        PicPlayer2.Left -= movespeed
    End Sub

    Private Sub TMRW_Tick(sender As Object, e As EventArgs) Handles TMRW.Tick
        PicPlayer2.Top -= movespeed
    End Sub

    Private Sub Form2dPlatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TMRGameLogic.Start()
    End Sub

    Private Sub TMRGameLogic_Tick(sender As Object, e As EventArgs) Handles TMRGameLogic.Tick
        If PicPlayer2.Bounds.IntersectsWith(PicGround.Bounds) Then
            TMRGravity.Stop()
        Else
            If isjumping = False Then
                TMRGravity.Start()
            End If
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "Boundary" Then
                    If PicPlayer2.Bounds.IntersectsWith(b.Bounds) Then
                        TMRGravity.Stop()
                    End If
                End If
            End If
        Next
        For Each d As Control In Me.Controls
            If TypeOf d Is PictureBox Then
                If d.Tag = "Death" Then
                    If PicPlayer2.Bounds.IntersectsWith(d.Bounds) Then
                        Me.Close()
                    End If
                End If
            End If
        Next
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "Restart" Then
                    If PicPlayer2.Bounds.IntersectsWith(b.Bounds) Then
                        PicPlayer2.Location = New Point(486, 841)
                    End If
                End If
            End If
            If b.Tag = "Artifact" Then
                If b.Visible And PicPlayer2.Bounds.IntersectsWith(b.Bounds) Then
                    b.Visible = False
                    Label1.Text = Artifact
                    Artifact += 1
                End If
            End If
        Next
    End Sub

    Private Sub TMRGravity_Tick(sender As Object, e As EventArgs) Handles TMRGravity.Tick
        PicPlayer2.Top += movespeed
    End Sub
End Class
