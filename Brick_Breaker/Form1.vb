Public Class Form1

    Dim bricks(26) As PictureBox
    Dim dy As Integer
    Dim dx As Integer
    Dim xvalue As Integer
    Dim yvalue As Integer
    Dim score As Integer
    Dim lives As Integer
    Dim gameover As Boolean = False




    Private Sub Paddle_left_Tick(sender As Object, e As EventArgs) Handles Paddle_left.Tick
        If Paddle.Location.X > 0 And pause_lbl.Text = "Pause" And gameover = False Then

            Paddle.Left -= 10


        End If
    End Sub

    Private Sub Paddle_right_Tick(sender As Object, e As EventArgs) Handles Paddle_right.Tick
        If Paddle.Location.X < 756 And pause_lbl.Text = "Pause" And gameover = False Then

            Paddle.Left += 10

        End If
    End Sub

    Private Sub Paddle_Click(sender As Object, e As EventArgs) Handles Paddle.Click

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Then

            Paddle_left.Start()



        End If

        If e.KeyCode = Keys.Right Then

            Paddle_right.Start()

        End If


        If e.KeyCode = Keys.Space And You_win_lbl.Visible = False Then


            Ball.Start()
            gameover = False


        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Paddle_left.Stop()
        Paddle_right.Stop()

    End Sub

    Private Sub Ball_Tick(sender As Object, e As EventArgs) Handles Ball.Tick


        Ballo.Left += dx
        Ballo.Top += dy


        If (Ballo.Location.Y < 3 Or Ballo.Bounds.IntersectsWith(Paddle.Bounds)) Then

            dy += 0.5
            dx += 0.5

            dy = -dy


        End If

        For x As Integer = 0 To 26


            If (Ballo.Bounds.IntersectsWith(bricks(x).Bounds) Or bricks(x).Bounds.IntersectsWith(Ballo.Bounds)) Then

                If (bricks(x).Visible = True) Then

                    'dy = 6

                    dy = -dy
                    'xvalue = 4


                    bricks(x).Visible = False

                    If (bricks(x).Visible = False) Then
                        timer_score.Start()
                    End If




                Else


                End If




            End If


        Next




        If Ballo.Location.X > 830 Or Ballo.Location.X < 0 Then

          

            dx = -dx
            xvalue += 1


        End If




    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, PictureBox9.Click, PictureBox8.Click, PictureBox7.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox3.Click, PictureBox24.Click, PictureBox23.Click, PictureBox22.Click, PictureBox21.Click, PictureBox20.Click, PictureBox19.Click, PictureBox18.Click, PictureBox17.Click, PictureBox16.Click, PictureBox15.Click, PictureBox14.Click, PictureBox13.Click, PictureBox12.Click, PictureBox11.Click, PictureBox10.Click, PictureBox27.Click, PictureBox26.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.WindowState = FormWindowState.Maximized


        If Me.WindowState = FormWindowState.Maximized Then


            Panel1.Width = CInt(Me.Width - 847)
            Panel2.Left = CInt(Panel1.Width - Panel2.Width) / 2
            Panel3.Left = CInt(Panel1.Width - Panel3.Width)
            'close_lbl.Left = CInt(Me.Width - 240)



        End If



        Paddle_left.Stop()
        Paddle_right.Stop()
        Life.Stop()



        yvalue = -4.03
        xvalue = 7

        dy = yvalue
        dx = xvalue
        score = 0
        lives = 3

        Restart_lbl.Text = "Restart"
        'Restart_lbl.Left = 95



        bricks(0) = PictureBox1
        bricks(1) = PictureBox2
        bricks(2) = PictureBox3
        bricks(3) = PictureBox4
        bricks(4) = PictureBox5
        bricks(5) = PictureBox6
        bricks(6) = PictureBox7
        bricks(7) = PictureBox8
        bricks(8) = PictureBox9
        bricks(9) = PictureBox10
        bricks(10) = PictureBox11
        bricks(11) = PictureBox12
        bricks(12) = PictureBox13
        bricks(13) = PictureBox14
        bricks(14) = PictureBox15
        bricks(15) = PictureBox16
        bricks(16) = PictureBox17
        bricks(17) = PictureBox18
        bricks(18) = PictureBox19
        bricks(19) = PictureBox20
        bricks(20) = PictureBox21
        bricks(21) = PictureBox22
        bricks(22) = PictureBox23
        bricks(23) = PictureBox24
        bricks(24) = PictureBox25
        bricks(25) = PictureBox26
        bricks(26) = PictureBox27










    End Sub

    Private Sub GamePlay_Tick(sender As Object, e As EventArgs) Handles GamePlay.Tick

       



        If (Ballo.Location.Y > Me.Height) Then


            Ball.Stop()
            Ballo.Top = CInt(Paddle.Location.Y) - 15
            Ballo.Left = CInt(Paddle.Location.X) + 12
            Life.Start()

            'dy = yvalue
            'dx = xvalue


            dx = -dx

            gameover = True






        End If







        If (bricks(0).Visible = False And bricks(1).Visible = False And bricks(2).Visible = False And bricks(3).Visible = False And bricks(4).Visible = False And bricks(5).Visible = False And bricks(6).Visible = False And bricks(7).Visible = False And bricks(8).Visible = False And bricks(9).Visible = False And bricks(10).Visible = False And bricks(11).Visible = False And bricks(12).Visible = False And bricks(13).Visible = False And bricks(14).Visible = False And bricks(15).Visible = False And bricks(16).Visible = False And bricks(17).Visible = False And bricks(18).Visible = False And bricks(19).Visible = False And bricks(20).Visible = False And bricks(21).Visible = False And bricks(22).Visible = False And bricks(23).Visible = False And bricks(24).Visible = False And bricks(25).Visible = False And bricks(26).Visible = False) Then

            Ball.Stop()
            You_win_lbl.Visible = True




        End If






    End Sub

    Private Sub timer_score_Tick(sender As Object, e As EventArgs) Handles timer_score.Tick
        score += 1
        Score_lbl.Text = "Score: " & score
        timer_score.Stop()


    End Sub

    Private Sub Score_lbl_Click(sender As Object, e As EventArgs) Handles Score_lbl.Click

    End Sub

    Private Sub Life_Tick(sender As Object, e As EventArgs) Handles Life.Tick
        lives -= 1
        Lives_lbl.Text = "Lives: " & lives

        If lives = 0 Then

            Ball.Stop()
            You_win_lbl.Text = "You Lose"
            You_win_lbl.BackColor = Color.Red
            You_win_lbl.Visible = True
            pause_lbl.Visible = False



            Restart_lbl.Text = "Play Again"
            Restart_lbl.Left = CInt(Panel2.Width - Restart_lbl.Width) / 2








        End If



        Life.Stop()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles close_lbl.Click
        Me.Close()


    End Sub

    Private Sub Ballo_Click(sender As Object, e As EventArgs) Handles Ballo.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Restart_lbl_Click(sender As Object, e As EventArgs) Handles Restart_lbl.Click
        Me.Controls.Clear()

        InitializeComponent()
        Form1_Load(e, e)


        Ball.Start()
        gameover = False



    End Sub

    Private Sub speed_Tick(sender As Object, e As EventArgs) Handles speed.Tick




    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles pause_lbl.Click

        If pause_lbl.Text = "Pause" Then

            Ball.Stop()
            Paddle_left.Stop()
            Paddle_right.Stop()


            pause_lbl.BackColor = Color.Green
            pause_lbl.Text = "Play"

        ElseIf pause_lbl.Text = "Play" Then


            pause_lbl.BackColor = Color.Red
            pause_lbl.Text = "Pause"


            Ball.Start()
            'Paddle_left.Start()
            'Paddle_right.Start()
            GamePlay.Start()
            'timer_score.Start()
            'Life.Start()


        End If

       




    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs)

        



    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Lives_lbl_Click(sender As Object, e As EventArgs) Handles Lives_lbl.Click

    End Sub


    Private Sub Label3_Click_2(sender As Object, e As EventArgs) Handles Label3.Click

        Ball.Stop()
        Paddle_left.Stop()
        Paddle_right.Stop()
        GamePlay.Stop()
        timer_score.Stop()
        Life.Stop()


        pause_lbl.BackColor = Color.Green
        pause_lbl.Text = "Play"




        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Maximize_Click(sender As Object, e As EventArgs) Handles Maximize.Click

        If Me.WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Maximized
            Panel1.Width = CInt(Me.Width - 847)
            Panel2.Left = CInt(Panel1.Width - Panel2.Width) / 2
            Panel3.Left = CInt(Panel1.Width - Panel3.Width)

        ElseIf Me.WindowState = FormWindowState.Maximized Then

            Me.WindowState = FormWindowState.Normal
            Panel1.Width = CInt(Me.Width - 847)
            Panel2.Left = CInt(Panel1.Width - Panel2.Width) / 2
            Panel3.Left = CInt(Panel1.Width - Panel3.Width)



        End If


    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
