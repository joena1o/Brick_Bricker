<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Paddle = New System.Windows.Forms.PictureBox()
        Me.Paddle_left = New System.Windows.Forms.Timer(Me.components)
        Me.Paddle_right = New System.Windows.Forms.Timer(Me.components)
        Me.Ballo = New System.Windows.Forms.PictureBox()
        Me.Ball = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.PictureBox22 = New System.Windows.Forms.PictureBox()
        Me.PictureBox23 = New System.Windows.Forms.PictureBox()
        Me.PictureBox24 = New System.Windows.Forms.PictureBox()
        Me.GamePlay = New System.Windows.Forms.Timer(Me.components)
        Me.timer_score = New System.Windows.Forms.Timer(Me.components)
        Me.You_win_lbl = New System.Windows.Forms.Label()
        Me.Life = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox25 = New System.Windows.Forms.PictureBox()
        Me.PictureBox26 = New System.Windows.Forms.PictureBox()
        Me.PictureBox27 = New System.Windows.Forms.PictureBox()
        Me.speed = New System.Windows.Forms.Timer(Me.components)
        Me.Score_lbl = New System.Windows.Forms.Label()
        Me.Lives_lbl = New System.Windows.Forms.Label()
        Me.close_lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pause_lbl = New System.Windows.Forms.Label()
        Me.Restart_lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Maximize = New System.Windows.Forms.Label()
        CType(Me.Paddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ballo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Paddle
        '
        Me.Paddle.BackColor = System.Drawing.Color.Red
        Me.Paddle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Paddle.Location = New System.Drawing.Point(416, 707)
        Me.Paddle.Name = "Paddle"
        Me.Paddle.Size = New System.Drawing.Size(74, 10)
        Me.Paddle.TabIndex = 0
        Me.Paddle.TabStop = False
        '
        'Paddle_left
        '
        Me.Paddle_left.Enabled = True
        Me.Paddle_left.Interval = 10
        '
        'Paddle_right
        '
        Me.Paddle_right.Enabled = True
        Me.Paddle_right.Interval = 10
        '
        'Ballo
        '
        Me.Ballo.BackColor = System.Drawing.Color.OrangeRed
        Me.Ballo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Ballo.Location = New System.Drawing.Point(461, 492)
        Me.Ballo.Name = "Ballo"
        Me.Ballo.Size = New System.Drawing.Size(15, 14)
        Me.Ballo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ballo.TabIndex = 1
        Me.Ballo.TabStop = False
        '
        'Ball
        '
        Me.Ball.Enabled = True
        Me.Ball.Interval = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(107, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(197, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Location = New System.Drawing.Point(287, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox4.Location = New System.Drawing.Point(377, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox5.Location = New System.Drawing.Point(467, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox5.TabIndex = 2
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.Location = New System.Drawing.Point(557, 4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox6.TabIndex = 2
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox7.Location = New System.Drawing.Point(647, 4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox7.TabIndex = 2
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox8.Location = New System.Drawing.Point(737, 4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox8.TabIndex = 2
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox9.Location = New System.Drawing.Point(647, 67)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox9.TabIndex = 2
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox10.Location = New System.Drawing.Point(737, 36)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox10.TabIndex = 2
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox11.Location = New System.Drawing.Point(647, 35)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox11.TabIndex = 2
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox12.Location = New System.Drawing.Point(557, 36)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox12.TabIndex = 2
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox13.Location = New System.Drawing.Point(467, 36)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox13.TabIndex = 2
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox14.Location = New System.Drawing.Point(377, 36)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox14.TabIndex = 2
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox15.Location = New System.Drawing.Point(287, 36)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox15.TabIndex = 2
        Me.PictureBox15.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox16.Location = New System.Drawing.Point(197, 36)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox16.TabIndex = 2
        Me.PictureBox16.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox17.Location = New System.Drawing.Point(107, 36)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox17.TabIndex = 2
        Me.PictureBox17.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox18.Location = New System.Drawing.Point(107, 67)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox18.TabIndex = 2
        Me.PictureBox18.TabStop = False
        '
        'PictureBox19
        '
        Me.PictureBox19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox19.Location = New System.Drawing.Point(17, 67)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox19.TabIndex = 2
        Me.PictureBox19.TabStop = False
        '
        'PictureBox20
        '
        Me.PictureBox20.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox20.Location = New System.Drawing.Point(197, 67)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox20.TabIndex = 2
        Me.PictureBox20.TabStop = False
        '
        'PictureBox21
        '
        Me.PictureBox21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox21.Location = New System.Drawing.Point(287, 67)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox21.TabIndex = 2
        Me.PictureBox21.TabStop = False
        '
        'PictureBox22
        '
        Me.PictureBox22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox22.Location = New System.Drawing.Point(467, 67)
        Me.PictureBox22.Name = "PictureBox22"
        Me.PictureBox22.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox22.TabIndex = 2
        Me.PictureBox22.TabStop = False
        '
        'PictureBox23
        '
        Me.PictureBox23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox23.Location = New System.Drawing.Point(377, 67)
        Me.PictureBox23.Name = "PictureBox23"
        Me.PictureBox23.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox23.TabIndex = 2
        Me.PictureBox23.TabStop = False
        '
        'PictureBox24
        '
        Me.PictureBox24.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox24.Location = New System.Drawing.Point(557, 67)
        Me.PictureBox24.Name = "PictureBox24"
        Me.PictureBox24.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox24.TabIndex = 2
        Me.PictureBox24.TabStop = False
        '
        'GamePlay
        '
        Me.GamePlay.Enabled = True
        Me.GamePlay.Interval = 10
        '
        'timer_score
        '
        Me.timer_score.Enabled = True
        Me.timer_score.Interval = 1
        '
        'You_win_lbl
        '
        Me.You_win_lbl.AutoSize = True
        Me.You_win_lbl.BackColor = System.Drawing.Color.Yellow
        Me.You_win_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.You_win_lbl.ForeColor = System.Drawing.Color.DarkGray
        Me.You_win_lbl.Location = New System.Drawing.Point(283, 188)
        Me.You_win_lbl.Name = "You_win_lbl"
        Me.You_win_lbl.Size = New System.Drawing.Size(273, 69)
        Me.You_win_lbl.TabIndex = 4
        Me.You_win_lbl.Text = "You Win!"
        Me.You_win_lbl.Visible = False
        '
        'Life
        '
        Me.Life.Enabled = True
        Me.Life.Interval = 1
        '
        'PictureBox25
        '
        Me.PictureBox25.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox25.Location = New System.Drawing.Point(17, 4)
        Me.PictureBox25.Name = "PictureBox25"
        Me.PictureBox25.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox25.TabIndex = 2
        Me.PictureBox25.TabStop = False
        '
        'PictureBox26
        '
        Me.PictureBox26.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox26.Location = New System.Drawing.Point(17, 36)
        Me.PictureBox26.Name = "PictureBox26"
        Me.PictureBox26.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox26.TabIndex = 2
        Me.PictureBox26.TabStop = False
        '
        'PictureBox27
        '
        Me.PictureBox27.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox27.Location = New System.Drawing.Point(737, 67)
        Me.PictureBox27.Name = "PictureBox27"
        Me.PictureBox27.Size = New System.Drawing.Size(91, 31)
        Me.PictureBox27.TabIndex = 2
        Me.PictureBox27.TabStop = False
        '
        'speed
        '
        Me.speed.Interval = 10
        '
        'Score_lbl
        '
        Me.Score_lbl.AutoSize = True
        Me.Score_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_lbl.ForeColor = System.Drawing.Color.OrangeRed
        Me.Score_lbl.Location = New System.Drawing.Point(12, 52)
        Me.Score_lbl.Name = "Score_lbl"
        Me.Score_lbl.Size = New System.Drawing.Size(86, 25)
        Me.Score_lbl.TabIndex = 0
        Me.Score_lbl.Text = "Score: 0"
        '
        'Lives_lbl
        '
        Me.Lives_lbl.AutoSize = True
        Me.Lives_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lives_lbl.ForeColor = System.Drawing.Color.Red
        Me.Lives_lbl.Location = New System.Drawing.Point(162, 53)
        Me.Lives_lbl.Name = "Lives_lbl"
        Me.Lives_lbl.Size = New System.Drawing.Size(73, 24)
        Me.Lives_lbl.TabIndex = 1
        Me.Lives_lbl.Text = "Lives: 3"
        '
        'close_lbl
        '
        Me.close_lbl.AutoSize = True
        Me.close_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close_lbl.ForeColor = System.Drawing.Color.Transparent
        Me.close_lbl.Location = New System.Drawing.Point(126, 5)
        Me.close_lbl.Name = "close_lbl"
        Me.close_lbl.Size = New System.Drawing.Size(20, 20)
        Me.close_lbl.TabIndex = 2
        Me.close_lbl.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.pause_lbl)
        Me.Panel2.Controls.Add(Me.Restart_lbl)
        Me.Panel2.Controls.Add(Me.Score_lbl)
        Me.Panel2.Controls.Add(Me.Lives_lbl)
        Me.Panel2.Location = New System.Drawing.Point(34, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 283)
        Me.Panel2.TabIndex = 7
        '
        'pause_lbl
        '
        Me.pause_lbl.AutoSize = True
        Me.pause_lbl.BackColor = System.Drawing.Color.Transparent
        Me.pause_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pause_lbl.ForeColor = System.Drawing.Color.White
        Me.pause_lbl.Location = New System.Drawing.Point(81, 116)
        Me.pause_lbl.Name = "pause_lbl"
        Me.pause_lbl.Size = New System.Drawing.Size(99, 36)
        Me.pause_lbl.TabIndex = 6
        Me.pause_lbl.Text = "Pause"
        '
        'Restart_lbl
        '
        Me.Restart_lbl.AutoSize = True
        Me.Restart_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Restart_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Restart_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Restart_lbl.Location = New System.Drawing.Point(79, 181)
        Me.Restart_lbl.Name = "Restart_lbl"
        Me.Restart_lbl.Size = New System.Drawing.Size(109, 33)
        Me.Restart_lbl.TabIndex = 5
        Me.Restart_lbl.Text = "Restart"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(847, -17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 792)
        Me.Panel1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Maximize)
        Me.Panel3.Controls.Add(Me.close_lbl)
        Me.Panel3.Location = New System.Drawing.Point(149, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(147, 31)
        Me.Panel3.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(73, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "_"
        '
        'Maximize
        '
        Me.Maximize.AutoSize = True
        Me.Maximize.Font = New System.Drawing.Font("Webdings", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Maximize.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Maximize.Location = New System.Drawing.Point(97, 4)
        Me.Maximize.Name = "Maximize"
        Me.Maximize.Size = New System.Drawing.Size(23, 20)
        Me.Maximize.TabIndex = 5
        Me.Maximize.Text = "c"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(1156, 719)
        Me.Controls.Add(Me.You_win_lbl)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox19)
        Me.Controls.Add(Me.PictureBox23)
        Me.Controls.Add(Me.PictureBox24)
        Me.Controls.Add(Me.PictureBox22)
        Me.Controls.Add(Me.PictureBox21)
        Me.Controls.Add(Me.PictureBox20)
        Me.Controls.Add(Me.PictureBox18)
        Me.Controls.Add(Me.PictureBox27)
        Me.Controls.Add(Me.PictureBox26)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.PictureBox16)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox25)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Ballo)
        Me.Controls.Add(Me.Paddle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Paddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ballo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox27, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Paddle As System.Windows.Forms.PictureBox
    Friend WithEvents Paddle_left As System.Windows.Forms.Timer
    Friend WithEvents Paddle_right As System.Windows.Forms.Timer
    Friend WithEvents Ballo As System.Windows.Forms.PictureBox
    Friend WithEvents Ball As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox18 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox19 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox21 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox22 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox23 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox24 As System.Windows.Forms.PictureBox
    Friend WithEvents GamePlay As System.Windows.Forms.Timer
    Friend WithEvents timer_score As System.Windows.Forms.Timer
    Friend WithEvents You_win_lbl As System.Windows.Forms.Label
    Friend WithEvents Life As System.Windows.Forms.Timer
    Friend WithEvents PictureBox25 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox26 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox27 As System.Windows.Forms.PictureBox
    Friend WithEvents speed As System.Windows.Forms.Timer
    Friend WithEvents Score_lbl As System.Windows.Forms.Label
    Friend WithEvents Lives_lbl As System.Windows.Forms.Label
    Friend WithEvents close_lbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pause_lbl As System.Windows.Forms.Label
    Friend WithEvents Restart_lbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Maximize As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel

End Class
