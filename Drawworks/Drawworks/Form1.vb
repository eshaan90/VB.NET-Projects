Imports System.Data.OleDb

Public Class Form1

    Dim g As System.Drawing.Graphics
    Private low_clutch As Integer = 0
    Private high_clutch As Integer = 0
    Private lube_oil As Integer = 0
    Private hpu_a As Integer = 0
    Private hpu_b As Integer = 0
    Private dw_on As Integer = 0
    Private cal12 As Integer = 1
    Private cal56 As Integer = 1
    Private cal3 As Integer = 1
    Private cal4 As Integer = 1
    Private e_stop As Integer = 0
    Private cal_sum As Integer = cal12 + cal3 + cal4 + cal56
    Const floor_saver As Single = 4.57
    Const roof_saver As Single = 117.16

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics()
        'Button3.Enabled = False
        ' Button3.Visible = False
        Dim brush3 As Brush
        brush3 = New Drawing.SolidBrush(Color.LawnGreen)
        GroupBox1.Enabled = False
        TextBox10.Text += 141.1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Setup.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Alarms_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim myGraphics As Graphics = Me.CreateGraphics

        Dim myFont As Font
        Dim myBrush As Brush
        myBrush = New Drawing.SolidBrush(Color.Black)
        myFont = New System.Drawing.Font("Times New Roman", 24)
        Dim pen1 As New Pen(Color.LightGray, 1)
        Dim pen2 As New Pen(Color.Black, 1)
        Dim brush1 As New SolidBrush(Color.LightGray)
        Dim brush2 As New SolidBrush(Color.White)
        Dim brush4 As New SolidBrush(Color.Green)

        myGraphics.DrawString("M", myFont, myBrush, 712, 173) 'DW A 
        myGraphics.DrawString("M", myFont, myBrush, 712, 283) 'DW B
        myGraphics.DrawString("M", myFont, myBrush, 712, 382) 'DW C
        myGraphics.DrawString("M", myFont, myBrush, 612, 170) 'DW A Blower
        myGraphics.DrawString("M", myFont, myBrush, 612, 283) 'DW B Blower
        myGraphics.DrawString("M", myFont, myBrush, 612, 381) 'DW C Blower



        e.Graphics.DrawLine(pen1, 600, 595, 1120, 595)
        e.Graphics.DrawLine(pen1, 1120, 595, 1120, 900)
        e.Graphics.DrawLine(pen1, 80, 595, 570, 595)
        e.Graphics.DrawLine(pen1, 580, 595, 600, 595)
        e.Graphics.DrawLine(pen1, 580, 595, 580, 900)
        e.Graphics.DrawLine(pen1, 20, 595, 80, 595)
        e.Graphics.DrawLine(pen1, 20, 595, 20, 900)
        e.Graphics.DrawLine(pen1, 570, 595, 570, 900)
        e.Graphics.DrawLine(pen1, 20, 900, 570, 900)
        e.Graphics.DrawLine(pen1, 580, 900, 1120, 900)

        e.Graphics.DrawEllipse(pen1, 700, 160, 60, 60) 'DW A
        e.Graphics.DrawEllipse(pen1, 700, 270, 60, 60) 'DW B
        e.Graphics.DrawEllipse(pen1, 700, 370, 60, 60) 'DW C
        e.Graphics.DrawEllipse(pen1, 600, 160, 60, 60) 'DW A Blower
        e.Graphics.DrawEllipse(pen1, 600, 270, 60, 60) 'DW B Blower
        e.Graphics.DrawEllipse(pen1, 600, 370, 60, 60) 'DW C Blower


        e.Graphics.DrawRectangle(pen2, 237, 359, 8, 101) 'DW Drum
        e.Graphics.DrawRectangle(pen2, 377, 359, 8, 101) 'DW Drum
        e.Graphics.DrawRectangle(pen2, 245, 389, 135, 41) 'DW Drum
        e.Graphics.DrawEllipse(pen2, 100, 670, 61, 61) 'HPU Pump A
        e.Graphics.DrawEllipse(pen2, 400, 670, 61, 61) 'HPU Pump B
        e.Graphics.DrawEllipse(pen2, 730, 790, 61, 61) 'Lube Oil Pump
        e.Graphics.DrawRectangle(pen2, 757, 686, 7, 105) 'Lube Oil Pipeline
        e.Graphics.DrawRectangle(pen2, 757, 620, 7, 41) 'Lube Oil Pipeline
        e.Graphics.DrawRectangle(pen2, 757, 620, 150, 7) 'Lube Oil Pipeline
        e.Graphics.DrawRectangle(pen2, 900, 620, 7, 41) 'Lube Oil Pipeline


        e.Graphics.DrawLine(pen2, 660, 190, 690, 190) 'DW A Blower
        e.Graphics.DrawLine(pen2, 660, 300, 690, 300) 'DW B Blower
        e.Graphics.DrawLine(pen2, 660, 400, 690, 400) 'DW C Blower
        e.Graphics.DrawEllipse(pen2, 680, 160, 15, 30) 'DW A Blower
        e.Graphics.DrawEllipse(pen2, 680, 270, 15, 30) 'DW B Blower
        e.Graphics.DrawEllipse(pen2, 680, 370, 15, 30) 'DW C Blower
        e.Graphics.DrawEllipse(pen2, 680, 190, 15, 30) 'DW A Blower
        e.Graphics.DrawEllipse(pen2, 680, 300, 15, 30) 'DW B Blower
        e.Graphics.DrawEllipse(pen2, 680, 400, 15, 30) 'DW C Blower

        e.Graphics.DrawRectangle(pen2, 127, 630, 7, 40) 'HPU System Pipeline
        e.Graphics.DrawRectangle(pen2, 127, 731, 7, 20) 'HPU System Pipeline
        e.Graphics.DrawRectangle(pen2, 426, 731, 7, 20) 'HPU System Pipeline
        e.Graphics.DrawRectangle(pen2, 426, 630, 7, 40) 'HPU System Pipeline
        e.Graphics.DrawRectangle(pen2, 127, 630, 300, 7) 'HPU System Pipeline
        e.Graphics.DrawRectangle(pen2, 127, 751, 360, 7) 'HPU System Pipeline
        e.Graphics.DrawRectangle(pen2, 350, 580, 7, 50) 'HPU System Pipeline
        e.Graphics.DrawRectangle(pen2, 400, 870, 90, 7) 'HPU System Pipeline
        e.Graphics.DrawRectangle(pen2, 487, 751, 7, 126) 'HPU System Pipeline

        e.Graphics.DrawRectangle(pen2, 121, 320, 30, 7) 'DW Pipeline
        e.Graphics.DrawRectangle(pen2, 121, 507, 30, 7) 'DW Pipeline
        e.Graphics.DrawRectangle(pen2, 458, 317, 30, 7) 'DW Pipeline
        e.Graphics.DrawRectangle(pen2, 458, 507, 30, 7) 'DW Pipeline
        e.Graphics.DrawRectangle(pen2, 121, 320, 7, 225) 'DW Pipeline
        e.Graphics.DrawRectangle(pen2, 488, 317, 7, 228) 'DW Pipeline
        e.Graphics.DrawRectangle(pen2, 121, 545, 374, 7) 'DW Pipeline
        e.Graphics.DrawRectangle(pen2, 350, 552, 7, 20) 'DW Pipeline

        e.Graphics.DrawRectangle(pen2, 75, 210, 397, 7) 'Clutch Pipeline
        e.Graphics.DrawRectangle(pen2, 75, 150, 31, 7) 'Clutch Pipeline
        e.Graphics.DrawRectangle(pen2, 430, 150, 35, 7) 'Clutch Pipeline
        e.Graphics.DrawRectangle(pen2, 75, 150, 7, 60) 'Clutch Pipeline
        e.Graphics.DrawRectangle(pen2, 465, 150, 7, 60) 'Clutch Pipeline

        e.Graphics.DrawRectangle(pen2, 227, 359, 7, 25) 'DW Brakes
        e.Graphics.DrawRectangle(pen2, 388, 359, 7, 25) 'DW Brakes 
        e.Graphics.DrawRectangle(pen2, 227, 432, 7, 25) 'DW Brakes 
        e.Graphics.DrawRectangle(pen2, 388, 432, 7, 25) 'DW Brakes 
        e.Graphics.DrawRectangle(pen2, 248, 432, 7, 25) 'DW Brakes 
        e.Graphics.DrawRectangle(pen2, 367, 432, 7, 25) 'DW Brakes 

        e.Graphics.FillRectangle(brush1, 238, 360, 7, 100) 'DW Drum
        e.Graphics.FillRectangle(brush1, 378, 360, 7, 100) 'DW Drum
        e.Graphics.FillRectangle(brush1, 245, 390, 135, 40) 'DW Drum
        e.Graphics.FillEllipse(brush1, 730, 790, 60, 60) 'Lube Oil Pump
        e.Graphics.FillEllipse(brush1, 100, 670, 60, 60) 'HPU Pump A
        e.Graphics.FillEllipse(brush1, 400, 670, 60, 60) 'HPU Pump B


        e.Graphics.FillEllipse(brush2, 700, 160, 60, 60) 'DW A Motor
        e.Graphics.FillEllipse(brush2, 700, 270, 60, 60) 'DW B Motor
        e.Graphics.FillEllipse(brush2, 700, 370, 60, 60) 'DW C Motor
        e.Graphics.FillEllipse(brush2, 600, 160, 60, 60) 'DW A Blower Motor
        e.Graphics.FillEllipse(brush2, 600, 270, 60, 60) 'DW B Blower Motor
        e.Graphics.FillEllipse(brush2, 600, 370, 60, 60) 'DW C Blower Motor
        e.Graphics.FillEllipse(brush2, 740, 800, 40, 40) 'Lube Oil Pump
        e.Graphics.FillEllipse(brush2, 110, 680, 40, 40) 'HPU Pump A
        e.Graphics.FillEllipse(brush2, 410, 680, 40, 40) 'HPU Pump B
        e.Graphics.FillRectangle(brush2, 757, 686, 7, 105) 'Lube Oil Pipeline
        e.Graphics.FillRectangle(brush2, 757, 620, 7, 41) 'Lube Oil Pipeline
        e.Graphics.FillRectangle(brush2, 757, 620, 150, 7) 'Lube Oil Pipeline
        e.Graphics.FillRectangle(brush2, 900, 620, 7, 41) 'Lube Oil Pipeline

        e.Graphics.FillRectangle(brush2, 127, 630, 7, 40) 'HPU System Pipeline
        e.Graphics.FillRectangle(brush2, 127, 731, 7, 20) 'HPU System Pipeline
        e.Graphics.FillRectangle(brush2, 426, 731, 7, 20) 'HPU System Pipeline
        e.Graphics.FillRectangle(brush2, 426, 630, 7, 40) 'HPU System Pipeline
        e.Graphics.FillRectangle(brush2, 127, 630, 300, 7) 'HPU System Pipeline
        e.Graphics.FillRectangle(brush2, 127, 751, 360, 7) 'HPU System Pipeline
        e.Graphics.FillRectangle(brush2, 350, 580, 7, 50) 'HPU System Pipeline
        e.Graphics.FillRectangle(brush2, 400, 870, 90, 7) 'HPU System Pipeline
        e.Graphics.FillRectangle(brush2, 487, 751, 7, 126) 'HPU System Pipeline

        e.Graphics.FillRectangle(brush2, 121, 320, 30, 7) 'DW Pipeline
        e.Graphics.FillRectangle(brush2, 121, 507, 30, 7) 'DW Pipeline
        e.Graphics.FillRectangle(brush2, 458, 317, 30, 7) 'DW Pipeline
        e.Graphics.FillRectangle(brush2, 458, 507, 30, 7) 'DW Pipeline
        e.Graphics.FillRectangle(brush2, 121, 320, 7, 225) 'DW Pipeline
        e.Graphics.FillRectangle(brush2, 488, 317, 7, 228) 'DW Pipeline
        e.Graphics.FillRectangle(brush2, 121, 545, 374, 7) 'DW Pipeline
        e.Graphics.FillRectangle(brush2, 350, 552, 7, 20) 'DW Pipeline

        e.Graphics.FillRectangle(brush2, 75, 210, 397, 7) 'Clutch Pipeline
        e.Graphics.FillRectangle(brush2, 75, 150, 31, 7) 'Clutch Pipeline
        e.Graphics.FillRectangle(brush2, 430, 150, 35, 7) 'Clutch Pipeline
        e.Graphics.FillRectangle(brush2, 75, 150, 7, 60) 'Clutch Pipeline
        e.Graphics.FillRectangle(brush2, 465, 150, 7, 60) 'Clutch Pipeline

        e.Graphics.FillRectangle(brush4, 227, 359, 7, 25) 'DW Brakes 4
        e.Graphics.FillRectangle(brush4, 388, 359, 7, 25) 'DW Brakes 3
        e.Graphics.FillRectangle(brush4, 227, 432, 7, 25) 'DW Brakes 5,6
        e.Graphics.FillRectangle(brush4, 388, 432, 7, 25) 'DW Brakes 1,2
        e.Graphics.FillRectangle(brush4, 248, 432, 7, 25) 'DW Brakes 5,6
        e.Graphics.FillRectangle(brush4, 367, 432, 7, 25) 'DW Brakes 1,2
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Lube Oil Pump Start Button
        Delay(1)
        Using brush3 As New SolidBrush(Color.LawnGreen)
            g.FillEllipse(brush3, 740, 800, 40, 40) 'Lube Oil Pump
        End Using
        Button5.Enabled = False
        Button5.Visible = False
        Button14.Enabled = True
        Button14.Visible = True
        While TextBox9.Text < 88
            TextBox9.Text += 11
        End While
        lube_oil = 1
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click 'Lube Oil Pump Stop Button
        If dw_on = 0 Then
            Delay(1)
            Using brush2 As New SolidBrush(Color.White)
                g.FillEllipse(brush2, 740, 800, 40, 40) 'Lube Oil Pump
            End Using
            Button5.Enabled = True
            Button5.Visible = True
            Button14.Enabled = False
            Button14.Visible = False
            While TextBox9.Text <> 0
                TextBox9.Text -= 11
            End While
            lube_oil = 0
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged 'Manual Mode Radio Button
        If RadioButton1.Checked Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Public Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click 'HPU Pump A Start Button
        If hpu_a = 0 And hpu_b = 0 Then
            Delay(2)
            Using brush3 As New SolidBrush(Color.LawnGreen)
                g.FillEllipse(brush3, 110, 680, 40, 40) 'HPU Pump A
            End Using
            Button7.Enabled = False
            Button7.Visible = False
            Button13.Enabled = True
            Button13.Visible = True
            While TextBox7.Text < 159
                TextBox7.Text += 11
            End While
            hpu_a = 1
        End If

    End Sub

    Public Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click 'HPU Pump A Stop Button
        If hpu_a = 1 And dw_on = 0 Then
            Delay(2)
            Using brush3 As New SolidBrush(Color.White)
                g.FillEllipse(brush3, 110, 680, 40, 40) 'HPU Pump A
            End Using
            Button7.Enabled = True
            Button7.Visible = True
            Button13.Enabled = False
            Button13.Visible = False
            While TextBox7.Text <> 0
                TextBox7.Text -= 11
            End While
            hpu_a = 0
        End If

    End Sub

    Public Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click 'HPU Pump B Start Button
        If hpu_a = 0 And hpu_b = 0 Then
            Delay(2)
            Using brush3 As New SolidBrush(Color.LawnGreen)
                g.FillEllipse(brush3, 410, 680, 40, 40) 'HPU Pump B
            End Using
            Button8.Enabled = False
            Button8.Visible = False
            Button12.Enabled = True
            Button12.Visible = True
            While TextBox7.Text < 159
                TextBox7.Text += 11
            End While
            hpu_b = 1
        End If

    End Sub

    Public Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click 'HPU Pump B Stop Button
        If hpu_b = 1 And dw_on = 0 Then
            Delay(2)
            Using brush3 As New SolidBrush(Color.White)
                g.FillEllipse(brush3, 410, 680, 40, 40) 'HPU Pump B
            End Using
            Button12.Enabled = False
            Button12.Visible = False
            Button8.Enabled = True
            Button8.Visible = True
            While TextBox7.Text <> 0
                TextBox7.Text -= 11
            End While
            hpu_b = 0
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click 'Low Clutch Activation Button
        If dw_on = 1 Then
            If TextBox10.Text > 140 Then
                Delay(1)
                If high_clutch = 0 Then
                    TextBox2.Text = 135.5
                    low_clutch = 1
                Else
                    high_clutch = 0
                    low_clutch = 1
                    TextBox2.Text = 135.5
                    TextBox1.Text = 0.0
                    Button11.BackColor = Color.Gainsboro
                End If
                Button9.BackColor = Color.Green
            End If
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click 'High Clutch Activation Button
        If TextBox10.Text > 140 And low_clutch = 1 Then
            Delay(1)
            TextBox1.Text = 135.5
            high_clutch = 1
            low_clutch = 0
            TextBox2.Text = 0.0
            Button11.BackColor = Color.Green
            Button9.BackColor = Color.Gainsboro
        End If
    End Sub

    Public Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click 'DW On Button
        'If lube_oil = 1 Then
        'If hpu_a = 1 Or hpu_b = 1 Then
        If dw_on = 0 Then
            Delay(2)

            Using brush3 As New SolidBrush(Color.LawnGreen)
                g.FillEllipse(brush3, 700, 160, 60, 60) 'DW A Motor
                g.FillEllipse(brush3, 700, 270, 60, 60) 'DW B Motor
                g.FillEllipse(brush3, 700, 370, 60, 60) 'DW C Motor
                g.FillEllipse(brush3, 600, 160, 60, 60) 'DW A Blower Motor
                g.FillEllipse(brush3, 600, 270, 60, 60) 'DW B Blower Motor
                g.FillEllipse(brush3, 600, 370, 60, 60) 'DW C Blower Motor

            End Using
            Dim myFont As Font
            Dim myBrush As Brush
            myBrush = New Drawing.SolidBrush(Color.Black)
            myFont = New System.Drawing.Font("Times New Roman", 24)
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 712, 173) 'DW A 
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 712, 283) 'DW B
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 712, 382) 'DW C
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 612, 170) 'DW A Blower
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 612, 283) 'DW B Blower
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 612, 381) 'DW C Blower
            dw_on = 1
            Button10.Enabled = False
            Button10.Visible = False
            Button20.Enabled = True
            Button20.Visible = True
        End If

    End Sub


    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click 'DW Off Button

        If dw_on = 1 Then
            Delay(2)
            Using brush3 As New SolidBrush(Color.White)
                g.FillEllipse(brush3, 700, 160, 60, 60) 'DW A Motor
                g.FillEllipse(brush3, 700, 270, 60, 60) 'DW B Motor
                g.FillEllipse(brush3, 700, 370, 60, 60) 'DW C Motor
                g.FillEllipse(brush3, 600, 160, 60, 60) 'DW A Blower Motor
                g.FillEllipse(brush3, 600, 270, 60, 60) 'DW B Blower Motor
                g.FillEllipse(brush3, 600, 370, 60, 60) 'DW C Blower Motor

            End Using
            Dim myFont As Font
            Dim myBrush As Brush
            myBrush = New Drawing.SolidBrush(Color.Black)
            myFont = New System.Drawing.Font("Times New Roman", 24)
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 712, 173) 'DW A 
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 712, 283) 'DW B
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 712, 382) 'DW C
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 612, 170) 'DW A Blower
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 612, 283) 'DW B Blower
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 612, 381) 'DW C Blower
            dw_on = 0
            Button20.Enabled = False
            Button20.Visible = False
            Button10.Enabled = True
            Button10.Visible = True
        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click 'DW Brake Calipers 1,2 Release Button
        If hpu_a = 1 Or hpu_b = 1 Then
            If (dw_on = 0 And cal_sum > 2) Or (dw_on = 1 And low_clutch = 1) Then
                Delay(1)
                Using brush4 As New SolidBrush(Color.White)
                    g.FillRectangle(brush4, 388, 432, 7, 25) 'DW Brakes 1,2
                    g.FillRectangle(brush4, 367, 432, 7, 25) 'DW Brakes 1,2
                End Using
                Button16.Enabled = False
                Button16.Visible = False
                Button21.Enabled = True
                Button21.Visible = True
                Delay(0.5)
                TextBox5.Text = TextBox7.Text - 4
                cal12 = 0
                cal_sum = cal12 + cal3 + cal4 + cal56

            End If
        End If

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click 'DW Brake Calipers 1,2 Apply Button
        If dw_on = 0 And cal12 = 0 Then
            Delay(1)
            Using brush4 As New SolidBrush(Color.Green)
                g.FillRectangle(brush4, 388, 432, 7, 25) 'DW Brakes 1,2
                g.FillRectangle(brush4, 367, 432, 7, 25) 'DW Brakes 1,2
            End Using
            cal12 = 1
            Button21.Enabled = False
            Button21.Visible = False
            Button16.Enabled = True
            Button16.Visible = True
            Delay(0.5)
            TextBox5.Text = 0.0
            cal_sum = cal12 + cal3 + cal4 + cal56
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click 'DW Brake Calipers 3 Release Button
        If hpu_a = 1 Or hpu_b = 1 Then
            If (dw_on = 0 And cal_sum > 2) Or (dw_on = 1 And low_clutch = 1) Then
                Delay(1)
                Using brush4 As New SolidBrush(Color.White)
                    g.FillRectangle(brush4, 388, 359, 7, 25) 'DW Brakes 3
                End Using
                Button15.Enabled = False
                Button15.Visible = False
                Button22.Enabled = True
                Button22.Visible = True
                Delay(0.5)
                TextBox4.Text = TextBox7.Text - 4
                cal3 = 0
                cal_sum = cal12 + cal3 + cal4 + cal56
            End If
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click 'DW Brake Calipers 3 Apply Button
        If dw_on = 0 And cal3 = 0 Then
            Delay(1)
            Using brush4 As New SolidBrush(Color.Green)
                g.FillRectangle(brush4, 388, 359, 7, 25) 'DW Brakes 3
            End Using
            cal3 = 1
            Button22.Enabled = False
            Button22.Visible = False
            Button15.Enabled = True
            Button15.Visible = True
            Delay(0.5)
            TextBox4.Text = 0.0
            cal_sum = cal12 + cal3 + cal4 + cal56
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'DW Brake Calipers 4 Release Button
        If hpu_a = 1 Or hpu_b = 1 Then
            If (dw_on = 0 And cal_sum > 2) Or (dw_on = 1 And low_clutch = 1) Then
                Delay(1)
                Using brush4 As New SolidBrush(Color.White)
                    g.FillRectangle(brush4, 227, 359, 7, 25) 'DW Brakes 4
                End Using
                Button3.Enabled = False
                Button3.Visible = False
                Button23.Enabled = True
                Button23.Visible = True
                Delay(0.5)
                TextBox3.Text = TextBox7.Text - 4
                cal4 = 0
                cal_sum = cal12 + cal3 + cal4 + cal56
            End If
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click 'DW Brake Calipers 4 Apply Button
        If dw_on = 0 And cal4 = 0 Then
            Delay(1)
            Using brush4 As New SolidBrush(Color.Green)
                g.FillRectangle(brush4, 227, 359, 7, 25) 'DW Brakes 4
            End Using
            cal4 = 1
            Button23.Enabled = False
            Button23.Visible = False
            Button3.Enabled = True
            Button3.Visible = True
            Delay(0.5)
            TextBox3.Text = 0.0
            cal_sum = cal12 + cal3 + cal4 + cal56
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click 'DW Brake Calipers 5,6 Release Button
        If hpu_a = 1 Or hpu_b = 1 Then
            If (dw_on = 0 And cal_sum > 2) Or (dw_on = 1 And low_clutch = 1) Then
                Delay(1)
                Using brush4 As New SolidBrush(Color.White)
                    g.FillRectangle(brush4, 227, 432, 7, 25) 'DW Brakes 5,6
                    g.FillRectangle(brush4, 248, 432, 7, 25) 'DW Brakes 5,6
                End Using
                Button19.Enabled = False
                Button19.Visible = False
                Button24.Enabled = True
                Button24.Visible = True
                Delay(0.5)
                TextBox6.Text = TextBox7.Text - 4
                cal56 = 0
                cal_sum = cal12 + cal3 + cal4 + cal56
            End If
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click 'DW Brake Calipers 5,6 Apply Button
        If dw_on = 0 And cal56 = 0 Then
            Delay(1)
            Using brush4 As New SolidBrush(Color.Green)
                g.FillRectangle(brush4, 227, 432, 7, 25) 'DW Brakes 5,6
                g.FillRectangle(brush4, 248, 432, 7, 25) 'DW Brakes 5,6
            End Using
            cal56 = 1
            Button24.Enabled = False
            Button24.Visible = False
            Button19.Enabled = True
            Button19.Visible = True
            Delay(0.5)
            TextBox6.Text = 0.0
            cal_sum = cal12 + cal3 + cal4 + cal56
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click 'Emergency Stop Button is pressed

        If e_stop = 0 Or cal_sum <> 4 Or lube_oil = 1 Or dw_on = 1 Or hpu_a = 1 Or hpu_b = 1 Then
            Delay(2)
            Using brush4 As New SolidBrush(Color.Green)
                g.FillRectangle(brush4, 227, 432, 7, 25) 'DW Brakes 5,6
                g.FillRectangle(brush4, 248, 432, 7, 25) 'DW Brakes 5,6
                g.FillRectangle(brush4, 227, 359, 7, 25) 'DW Brakes 4
                g.FillRectangle(brush4, 388, 359, 7, 25) 'DW Brakes 3
                g.FillRectangle(brush4, 388, 432, 7, 25) 'DW Brakes 1,2
                g.FillRectangle(brush4, 367, 432, 7, 25) 'DW Brakes 1,2
            End Using
            cal12 = 1
            cal3 = 1
            cal4 = 1
            cal56 = 1
            cal_sum = cal12 + cal3 + cal4 + cal56
            Button24.Enabled = False
            Button24.Visible = False
            Button19.Enabled = False
            Button19.Visible = True
            Button22.Enabled = False
            Button22.Visible = False
            Button15.Enabled = False
            Button15.Visible = True
            Button23.Enabled = False
            Button23.Visible = False
            Button3.Enabled = False
            Button3.Visible = True
            Button21.Enabled = False
            Button21.Visible = False
            Button16.Enabled = False
            Button16.Visible = True
            TextBox5.Text = 0.0
            TextBox3.Text = 0.0
            TextBox6.Text = 0.0
            TextBox4.Text = 0.0

            Delay(1)
            Using brush3 As New SolidBrush(Color.White)
                g.FillEllipse(brush3, 700, 160, 60, 60) 'DW A Motor
                g.FillEllipse(brush3, 700, 270, 60, 60) 'DW B Motor
                g.FillEllipse(brush3, 700, 370, 60, 60) 'DW C Motor
                g.FillEllipse(brush3, 600, 160, 60, 60) 'DW A Blower Motor
                g.FillEllipse(brush3, 600, 270, 60, 60) 'DW B Blower Motor
                g.FillEllipse(brush3, 600, 370, 60, 60) 'DW C Blower Motor
            End Using
            Dim myFont As Font
            Dim myBrush As Brush
            myBrush = New Drawing.SolidBrush(Color.Black)
            myFont = New System.Drawing.Font("Times New Roman", 24)
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 712, 173) 'DW A 
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 712, 283) 'DW B
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 712, 382) 'DW C
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 612, 170) 'DW A Blower
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 612, 283) 'DW B Blower
            Me.CreateGraphics.DrawString("M", myFont, myBrush, 612, 381) 'DW C Blower
            dw_on = 0
            Button20.Enabled = False
            Button20.Visible = False
            Button10.Enabled = False
            Button10.Visible = True


            Using brush3 As New SolidBrush(Color.White)
                g.FillEllipse(brush3, 110, 680, 40, 40) 'HPU Pump A
                g.FillEllipse(brush3, 410, 680, 40, 40) 'HPU Pump B
            End Using
            Button12.Enabled = False
            Button12.Visible = False
            Button8.Enabled = False
            Button8.Visible = True
            Button7.Enabled = False
            Button7.Visible = True
            Button13.Enabled = False
            Button13.Visible = False
            While TextBox7.Text <> 0
                TextBox7.Text -= 11
            End While
            hpu_b = 0
            hpu_a = 0

            Using brush2 As New SolidBrush(Color.White)
                g.FillEllipse(brush2, 740, 800, 40, 40) 'Lube Oil Pump
            End Using
            Button5.Enabled = False
            Button5.Visible = True
            Button14.Enabled = False
            Button14.Visible = False
            While TextBox9.Text <> 0
                TextBox9.Text -= 11
            End While
            lube_oil = 0

            Button17.Enabled = False
            Button18.Enabled = False
        End If
        Button6.Visible = False
        Button6.Enabled = False
        Button25.Visible = True
        Button25.Enabled = True
        e_stop = 1
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click 'Emergency Release Button is pressed
        If e_stop = 1 Then
            Delay(1)
            Button5.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True
            Button10.Enabled = True
            Button19.Enabled = True
            Button15.Enabled = True
            Button3.Enabled = True
            Button16.Enabled = True

            Button25.Visible = False
            Button25.Enabled = False
            Button6.Visible = True
            Button6.Enabled = True
            Button17.Enabled = True
            Button18.Enabled = True

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If dw_on = 1 And lube_oil = 1 And cal_sum = 0 Then
            If TextBox8.Text < roof_saver - 5 Then
                If low_clutch = 1 Then
                    TextBox8.Text += 2.8
                ElseIf high_clutch = 1 Then
                    TextBox8.Text += 5
                End If
            End If
        End If

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If dw_on = 1 And lube_oil = 1 And cal_sum = 0 Then
            If TextBox8.Text > floor_saver + 5 Then
                If low_clutch = 1 Then
                    TextBox8.Text -= 2.8
                ElseIf high_clutch = 1 Then
                    TextBox8.Text -= 5
                End If
            End If
        End If
    End Sub

    Private Sub Button17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Button17.KeyPress

    End Sub
End Class
