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
    Private auto_mode As Integer = 0
    Private manual_mode As Integer = 0

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics()
        'Button3.Enabled = False
        ' Button3.Visible = False
        Dim brush3 As Brush
        brush3 = New Drawing.SolidBrush(Color.LawnGreen)
        GroupBox1.Enabled = False
        TextBox10.Text += 141.1
        GroupBox4.Hide()

        'TODO: This line of code loads data into the 'Alarm_recorderDataSet.Alarms' table. You can move, or remove it, as needed.
        Alarms_Page.AlarmsTableAdapter.Fill(Alarms_Page.Alarm_recorderDataSet.Alarms)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Setup.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Alarms_Page.Show()
        Me.Hide()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Test_Page.Show()
        Me.Hide()

    End Sub

    'Graphic Design for the DW GUI
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

    'Lube Oil Pump Start Button
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    'Lube Oil Pump Stop Button
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
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

    'Manual Mode Radio Button
    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GroupBox1.Show()
        GroupBox4.Hide()
        GroupBox5.Hide()
        GroupBox1.Enabled = True
        GroupBox4.Enabled = False
        GroupBox5.Enabled = False
        manual_mode = 1
        auto_mode = 0

    End Sub

    'HPU Pump A Start Button
    Public Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If hpu_a = 0 And hpu_b = 0 Then
            Delay(1)
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

    'HPU Pump A Stop Button
    Public Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If hpu_a = 1 And (dw_on = 0 Or cal_sum > 2) Then
            Delay(1)
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

    'HPU Pump B Start Button
    Public Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If hpu_a = 0 And hpu_b = 0 Then
            Delay(1)
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

    'HPU Pump B Stop Button
    Public Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If hpu_b = 1 And (dw_on = 0 Or cal_sum > 2) Then
            Delay(1)
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

    'Low Clutch Activation Button
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
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

    'High Clutch Activation Button
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
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

    'DW On Button
    Public Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
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

    'DW Off Button
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        cal_sum = cal12 + cal3 + cal4 + cal56
        If dw_on = 1 And cal_sum > 2 Then
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

    'DW Brake Calipers 1,2 Release Button
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If hpu_a = 1 Or hpu_b = 1 Then
            If (dw_on = 0 And cal_sum > 2) Or (dw_on = 1 And (low_clutch = 1 Or high_clutch = 1)) Then
                Delay(1)
                Using brush4 As New SolidBrush(Color.White)
                    g.FillRectangle(brush4, 388, 432, 7, 25) 'DW Brakes 1,2
                    g.FillRectangle(brush4, 367, 432, 7, 25) 'DW Brakes 1,2
                End Using
                Button16.Enabled = False
                Button16.Visible = False
                Button21.Enabled = True
                Button21.Visible = True

                TextBox5.Text = TextBox7.Text - 4
                cal12 = 0
                cal_sum = cal12 + cal3 + cal4 + cal56
                If cal_sum = 0 Then
                    Button37.Enabled = True
                    Button37.Visible = True
                    Button38.Enabled = False
                    Button38.Visible = False
                End If
            End If
        End If
    End Sub

    'DW Brake Calipers 1,2 Apply Button
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If cal12 = 0 Then
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

            TextBox5.Text = 0.0
            cal_sum = cal12 + cal3 + cal4 + cal56
            If cal_sum = 4 Then
                Button38.Enabled = True
                Button38.Visible = True
                Button37.Enabled = False
                Button37.Visible = False
            End If
        End If

    End Sub

    'DW Brake Calipers 3 Release Button
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If hpu_a = 1 Or hpu_b = 1 Then
            If (dw_on = 0 And cal_sum > 2) Or (dw_on = 1 And (low_clutch = 1 Or high_clutch = 1)) Then
                Delay(1)
                Using brush4 As New SolidBrush(Color.White)
                    g.FillRectangle(brush4, 388, 359, 7, 25) 'DW Brakes 3
                End Using
                Button15.Enabled = False
                Button15.Visible = False
                Button22.Enabled = True
                Button22.Visible = True

                TextBox4.Text = TextBox7.Text - 4
                cal3 = 0
                cal_sum = cal12 + cal3 + cal4 + cal56
                If cal_sum = 0 Then
                    Button37.Enabled = True
                    Button37.Visible = True
                    Button38.Enabled = False
                    Button38.Visible = False
                End If
            End If
        End If
    End Sub

    'DW Brake Calipers 3 Apply Button
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If cal3 = 0 Then
            Delay(1)
            Using brush4 As New SolidBrush(Color.Green)
                g.FillRectangle(brush4, 388, 359, 7, 25) 'DW Brakes 3
            End Using
            cal3 = 1
            Button22.Enabled = False
            Button22.Visible = False
            Button15.Enabled = True
            Button15.Visible = True

            TextBox4.Text = 0.0
            cal_sum = cal12 + cal3 + cal4 + cal56
            If cal_sum = 4 Then
                Button38.Enabled = True
                Button38.Visible = True
                Button37.Enabled = False
                Button37.Visible = False
            End If
        End If
    End Sub

    'DW Brake Calipers 4 Release Button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If hpu_a = 1 Or hpu_b = 1 Then
            If (dw_on = 0 And cal_sum > 2) Or (dw_on = 1 And (low_clutch = 1 Or high_clutch = 1)) Then
                Delay(1)
                Using brush4 As New SolidBrush(Color.White)
                    g.FillRectangle(brush4, 227, 359, 7, 25) 'DW Brakes 4
                End Using
                Button3.Enabled = False
                Button3.Visible = False
                Button23.Enabled = True
                Button23.Visible = True

                TextBox3.Text = TextBox7.Text - 4
                cal4 = 0
                cal_sum = cal12 + cal3 + cal4 + cal56
                If cal_sum = 0 Then
                    Button37.Enabled = True
                    Button37.Visible = True
                    Button38.Enabled = False
                    Button38.Visible = False
                End If
            End If
        End If
    End Sub

    'DW Brake Calipers 4 Apply Button
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If cal4 = 0 Then
            Delay(1)
            Using brush4 As New SolidBrush(Color.Green)
                g.FillRectangle(brush4, 227, 359, 7, 25) 'DW Brakes 4
            End Using
            cal4 = 1
            Button23.Enabled = False
            Button23.Visible = False
            Button3.Enabled = True
            Button3.Visible = True

            TextBox3.Text = 0.0
            cal_sum = cal12 + cal3 + cal4 + cal56
            If cal_sum = 4 Then
                Button38.Enabled = True
                Button38.Visible = True
                Button37.Enabled = False
                Button37.Visible = False
            End If
        End If
    End Sub

    'DW Brake Calipers 5,6 Release Button
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If hpu_a = 1 Or hpu_b = 1 Then
            If (dw_on = 0 And cal_sum > 2) Or (dw_on = 1 And (low_clutch = 1 Or high_clutch = 1)) Then
                Delay(1)
                Using brush4 As New SolidBrush(Color.White)
                    g.FillRectangle(brush4, 227, 432, 7, 25) 'DW Brakes 5,6
                    g.FillRectangle(brush4, 248, 432, 7, 25) 'DW Brakes 5,6
                End Using
                Button19.Enabled = False
                Button19.Visible = False
                Button24.Enabled = True
                Button24.Visible = True

                TextBox6.Text = TextBox7.Text - 4
                cal56 = 0
                cal_sum = cal12 + cal3 + cal4 + cal56
                If cal_sum = 0 Then
                    Button37.Enabled = True
                    Button37.Visible = True
                    Button38.Enabled = False
                    Button38.Visible = False
                End If
            End If
        End If
    End Sub

    'DW Brake Calipers 5,6 Apply Button
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If cal56 = 0 Then
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

            TextBox6.Text = 0.0
            cal_sum = cal12 + cal3 + cal4 + cal56
            If cal_sum = 4 Then
                Button38.Enabled = True
                Button38.Visible = True
                Button37.Enabled = False
                Button37.Visible = False
            End If
        End If
    End Sub

    'Emergency Stop Button is pressed
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If e_stop = 0 Or cal_sum <> 4 Or lube_oil = 1 Or dw_on = 1 Or hpu_a = 1 Or hpu_b = 1 Then
            Delay(0.5)
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

            Button38.Visible = True
            Button38.Enabled = False
            Button37.Enabled = False
            Button9.Enabled = False
            Button11.Enabled = False
            TextBox5.Text = 0.0
            TextBox3.Text = 0.0
            TextBox6.Text = 0.0
            TextBox4.Text = 0.0

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

        'Auto Mode Controls 
        Button35.Enabled = False
        Button36.Enabled = False

        Button43.Enabled = False
        Button41.Enabled = False
        Button41.Visible = False
        Button43.Visible = True

        Button42.Enabled = False
        Button42.Visible = False
        Button44.Enabled = False
        Button44.Visible = True

        Button39.Enabled = False
        Button39.Visible = False
        Button40.Enabled = False
        Button40.Visible = True

        Button31.Enabled = False
        Button31.Visible = False
        Button34.Enabled = False
        Button34.Visible = True

        Button32.Enabled = False
        Button33.Enabled = False

        Button30.Visible = False
        Button30.Enabled = False
        Button29.Visible = True
        Button29.Enabled = True


        e_stop = 1
    End Sub

    'Emergency Release Button is pressed
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If e_stop = 1 Then
            Delay(0.5)

            'Manual Mode Controls
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


            Button38.Enabled = True
            Button37.Enabled = True
            Button9.Enabled = True
            Button11.Enabled = True

            'Auto Mode Controls
            Button35.Enabled = True
            Button36.Enabled = True
            Button43.Enabled = True
            Button41.Enabled = True
            Button42.Enabled = True
            Button44.Enabled = True
            Button39.Enabled = True
            Button40.Enabled = True
            Button31.Enabled = True
            Button34.Enabled = True
            Button32.Enabled = True
            Button33.Enabled = True

            Button30.Visible = True
            Button30.Enabled = True
            Button29.Visible = False
            Button29.Enabled = False
            e_stop = 0

        End If
    End Sub

    'Manual Mode UP Button
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

    'Manual Mode Down Button
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


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label16.Text = TimeOfDay
    End Sub



    'Brake Calipers Release Button
    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        If hpu_a = 1 Or hpu_b = 1 Then
            If dw_on = 1 And (low_clutch = 1 Or high_clutch = 1) And cal_sum <> 0 Then
                Delay(1)
                Using brush4 As New SolidBrush(Color.White)
                    g.FillRectangle(brush4, 388, 432, 7, 25) 'DW Brakes 1,2
                    g.FillRectangle(brush4, 367, 432, 7, 25) 'DW Brakes 1,2
                    g.FillRectangle(brush4, 388, 359, 7, 25) 'DW Brakes 3
                    g.FillRectangle(brush4, 227, 359, 7, 25) 'DW Brakes 4
                    g.FillRectangle(brush4, 227, 432, 7, 25) 'DW Brakes 5,6
                    g.FillRectangle(brush4, 248, 432, 7, 25) 'DW Brakes 5,6
                End Using
                Button16.Enabled = False
                Button16.Visible = False
                Button21.Enabled = True
                Button21.Visible = True

                Button15.Enabled = False
                Button15.Visible = False
                Button22.Enabled = True
                Button22.Visible = True

                Button3.Enabled = False
                Button3.Visible = False
                Button23.Enabled = True
                Button23.Visible = True

                Button19.Enabled = False
                Button19.Visible = False
                Button24.Enabled = True
                Button24.Visible = True

                TextBox5.Text = TextBox7.Text - 4
                TextBox4.Text = TextBox7.Text - 4
                TextBox3.Text = TextBox7.Text - 4
                TextBox6.Text = TextBox7.Text - 4



                cal56 = 0
                cal4 = 0
                cal3 = 0
                cal12 = 0
                cal_sum = cal12 + cal3 + cal4 + cal56

                Button38.Enabled = False
                Button38.Visible = False
                Button37.Enabled = True
                Button37.Visible = True
            End If
        End If
    End Sub

    'Brake Calipers Apply Button
    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        cal_sum = cal12 + cal3 + cal4 + cal56
        If cal_sum <> 4 Then
            Delay(1)
            Using brush4 As New SolidBrush(Color.Green)
                g.FillRectangle(brush4, 388, 432, 7, 25) 'DW Brakes 1,2
                g.FillRectangle(brush4, 367, 432, 7, 25) 'DW Brakes 1,2
                g.FillRectangle(brush4, 388, 359, 7, 25) 'DW Brakes 3
                g.FillRectangle(brush4, 227, 359, 7, 25) 'DW Brakes 4
                g.FillRectangle(brush4, 227, 432, 7, 25) 'DW Brakes 5,6
                g.FillRectangle(brush4, 248, 432, 7, 25) 'DW Brakes 5,6

            End Using
            cal12 = 1
            cal3 = 1
            cal4 = 1
            cal56 = 1
            Button21.Enabled = False
            Button21.Visible = False
            Button16.Enabled = True
            Button16.Visible = True

            Button22.Enabled = False
            Button22.Visible = False
            Button15.Enabled = True
            Button15.Visible = True

            Button23.Enabled = False
            Button23.Visible = False
            Button3.Enabled = True
            Button3.Visible = True

            Button24.Enabled = False
            Button24.Visible = False
            Button19.Enabled = True
            Button19.Visible = True


            TextBox5.Text = 0.0
            TextBox4.Text = 0.0
            TextBox3.Text = 0.0
            TextBox6.Text = 0.0

            cal_sum = cal12 + cal3 + cal4 + cal56
            Button37.Enabled = False
            Button37.Visible = False
            Button38.Enabled = True
            Button38.Visible = True
        End If
    End Sub




    'DW Auto Mode 

    'Auto Mode Selected
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        GroupBox4.Show()
        GroupBox1.Hide()
        GroupBox5.Hide()
        GroupBox1.Enabled = False
        GroupBox5.Enabled = False
        GroupBox4.Enabled = True
        auto_mode = 1
        manual_mode = 0
    End Sub


    'DW ON button- Auto Mode
    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If dw_on = 0 And e_stop = 0 Then

            If hpu_a = 0 And hpu_b = 0 Then
                Delay(0.5)
                Using brush3 As New SolidBrush(Color.LawnGreen)
                    g.FillEllipse(brush3, 110, 680, 40, 40) 'HPU Pump A
                End Using
                Button44.Enabled = False
                Button44.Visible = False
                Button42.Enabled = True
                Button42.Visible = True
                While TextBox7.Text < 159
                    TextBox7.Text += 11
                End While
                hpu_a = 1
            End If

            If lube_oil = 0 Then
                Delay(0.5)
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
            End If

        End If

        If dw_on = 0 And lube_oil = 1 And (hpu_a = 1 Or hpu_b = 1) Then
            Delay(0.5)
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
            Button34.Enabled = False
            Button34.Visible = False
            Button31.Enabled = True
            Button31.Visible = True
        End If
    End Sub

    'DW Off button- Auto Mode
    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If dw_on = 1 Then
            If cal_sum > 1 Then
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
                Button31.Enabled = False
                Button31.Visible = False
                Button34.Enabled = True
                Button34.Visible = True
            End If

        End If

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

            If TextBox2.Text > 130 Or TextBox1.Text > 130 Then



                high_clutch = 0
                low_clutch = 0
                TextBox2.Text = 0.0
                TextBox1.Text = 0.0
                Button36.BackColor = Color.Gainsboro
                Button35.BackColor = Color.Gainsboro
            End If
        End If
    End Sub

    'E-stop button- Auto Mode
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If e_stop = 0 Or cal_sum <> 4 Or lube_oil = 1 Or dw_on = 1 Or hpu_a = 1 Or hpu_b = 1 Then
            Delay(0.5)
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

            Button38.Visible = True
            Button38.Enabled = False
            Button37.Enabled = False
            Button9.Enabled = False
            Button11.Enabled = False
            TextBox5.Text = 0.0
            TextBox3.Text = 0.0
            TextBox6.Text = 0.0
            TextBox4.Text = 0.0

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

        Button35.Enabled = False
        Button36.Enabled = False

        Button43.Enabled = False
        Button41.Enabled = False
        Button41.Visible = False
        Button43.Visible = True

        Button42.Enabled = False
        Button42.Visible = False
        Button44.Enabled = False
        Button44.Visible = True

        Button39.Enabled = False
        Button39.Visible = True
        Button40.Enabled = False
        Button40.Visible = False

        Button31.Enabled = False
        Button31.Visible = False
        Button34.Enabled = False
        Button34.Visible = True

        Button32.Enabled = False
        Button33.Enabled = False

        Button30.Visible = False
        Button30.Enabled = False
        Button29.Visible = True
        Button29.Enabled = True

        Button6.Visible = False
        Button6.Enabled = False
        Button25.Visible = True
        Button25.Enabled = True

        e_stop = 1
    End Sub

    'E-stop Release button- Auto Mode
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If e_stop = 1 Then
            Delay(0.5)
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

            Button38.Enabled = True
            Button37.Enabled = True
            Button9.Enabled = True
            Button11.Enabled = True

            Button35.Enabled = True
            Button36.Enabled = True
            Button43.Enabled = True
            Button41.Enabled = True
            Button42.Enabled = True
            Button44.Enabled = True
            Button39.Enabled = True

            Button31.Enabled = True
            Button34.Enabled = True
            Button32.Enabled = True
            Button33.Enabled = True

            Button30.Visible = True
            Button30.Enabled = True
            Button29.Visible = False
            Button29.Enabled = False
            e_stop = 0
        End If
    End Sub

    'DW Brakes On Button -Auto Mode
    Public Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        cal_sum = cal12 + cal3 + cal4 + cal56
        If cal_sum <> 4 Then
            Delay(1)
            Using brush4 As New SolidBrush(Color.Green)
                g.FillRectangle(brush4, 388, 432, 7, 25) 'DW Brakes 1,2
                g.FillRectangle(brush4, 367, 432, 7, 25) 'DW Brakes 1,2
                g.FillRectangle(brush4, 388, 359, 7, 25) 'DW Brakes 3
                g.FillRectangle(brush4, 227, 359, 7, 25) 'DW Brakes 4
                g.FillRectangle(brush4, 227, 432, 7, 25) 'DW Brakes 5,6
                g.FillRectangle(brush4, 248, 432, 7, 25) 'DW Brakes 5,6

            End Using
            cal12 = 1
            cal3 = 1
            cal4 = 1
            cal56 = 1
            Button21.Enabled = False
            Button21.Visible = False
            Button16.Enabled = True
            Button16.Visible = True

            Button22.Enabled = False
            Button22.Visible = False
            Button15.Enabled = True
            Button15.Visible = True

            Button23.Enabled = False
            Button23.Visible = False
            Button3.Enabled = True
            Button3.Visible = True

            Button24.Enabled = False
            Button24.Visible = False
            Button19.Enabled = True
            Button19.Visible = True


            TextBox5.Text = 0.0
            TextBox4.Text = 0.0
            TextBox3.Text = 0.0
            TextBox6.Text = 0.0

            cal_sum = cal12 + cal3 + cal4 + cal56
            Button37.Enabled = False
            Button37.Visible = False
            Button38.Enabled = True
            Button38.Visible = True

            Button40.Enabled = False
            Button40.Visible = False
            Button39.Enabled = True
            Button39.Visible = True
        End If
    End Sub

    'DW Brakes Off Button -Auto Mode
    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        If hpu_a = 1 Or hpu_b = 1 Then
            If dw_on = 1 And (low_clutch = 1 Or high_clutch = 1) And cal_sum <> 0 Then
                Delay(1)
                Using brush4 As New SolidBrush(Color.White)
                    g.FillRectangle(brush4, 388, 432, 7, 25) 'DW Brakes 1,2
                    g.FillRectangle(brush4, 367, 432, 7, 25) 'DW Brakes 1,2
                    g.FillRectangle(brush4, 388, 359, 7, 25) 'DW Brakes 3
                    g.FillRectangle(brush4, 227, 359, 7, 25) 'DW Brakes 4
                    g.FillRectangle(brush4, 227, 432, 7, 25) 'DW Brakes 5,6
                    g.FillRectangle(brush4, 248, 432, 7, 25) 'DW Brakes 5,6
                End Using
                Button16.Enabled = False
                Button16.Visible = False
                Button21.Enabled = True
                Button21.Visible = True

                Button15.Enabled = False
                Button15.Visible = False
                Button22.Enabled = True
                Button22.Visible = True

                Button3.Enabled = False
                Button3.Visible = False
                Button23.Enabled = True
                Button23.Visible = True

                Button19.Enabled = False
                Button19.Visible = False
                Button24.Enabled = True
                Button24.Visible = True

                TextBox5.Text = TextBox7.Text - 4
                TextBox4.Text = TextBox7.Text - 4
                TextBox3.Text = TextBox7.Text - 4
                TextBox6.Text = TextBox7.Text - 4



                cal56 = 0
                cal4 = 0
                cal3 = 0
                cal12 = 0
                cal_sum = cal12 + cal3 + cal4 + cal56

                Button38.Enabled = False
                Button38.Visible = False
                Button37.Enabled = True
                Button37.Visible = True

                Button39.Enabled = False
                Button39.Visible = False
                Button40.Enabled = True
                Button40.Visible = True
            End If
        End If
    End Sub

    'DW Low Clutch Activation Button -Auto Mode
    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
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
                    Button35.BackColor = Color.Gainsboro
                End If
                Button36.BackColor = Color.Green
            End If
        End If
    End Sub

    'DW High Clutch Activation Button -Auto Mode
    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        If TextBox10.Text > 140 And low_clutch = 1 Then
            Delay(1)
            TextBox1.Text = 135.5
            high_clutch = 1
            low_clutch = 0
            TextBox2.Text = 0.0
            Button35.BackColor = Color.Green
            Button36.BackColor = Color.Gainsboro
        End If
    End Sub

    'Auto Mode UP Button
    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
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

    'Auto Mode Down Button
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
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

    'HPU Pump A Start Button -Auto Mode
    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        If hpu_a = 0 And hpu_b = 0 Then
            Delay(1)
            Using brush3 As New SolidBrush(Color.LawnGreen)
                g.FillEllipse(brush3, 110, 680, 40, 40) 'HPU Pump A
            End Using
            Button44.Enabled = False
            Button44.Visible = False
            Button42.Enabled = True
            Button42.Visible = True
            While TextBox7.Text < 159
                TextBox7.Text += 11
            End While
            hpu_a = 1
        End If
    End Sub

    'HPU Pump A Stop Button -Auto Mode
    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        If hpu_a = 1 And (dw_on = 0 Or cal_sum > 2) Then
            Delay(1)
            Using brush3 As New SolidBrush(Color.White)
                g.FillEllipse(brush3, 110, 680, 40, 40) 'HPU Pump A
            End Using
            Button44.Enabled = True
            Button44.Visible = True
            Button42.Enabled = False
            Button42.Visible = False
            While TextBox7.Text <> 0
                TextBox7.Text -= 11
            End While
            hpu_a = 0
        End If
    End Sub

    'HPU Pump B Start Button -Auto Mode
    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        If hpu_a = 0 And hpu_b = 0 Then
            Delay(1)
            Using brush3 As New SolidBrush(Color.LawnGreen)
                g.FillEllipse(brush3, 410, 680, 40, 40) 'HPU Pump B
            End Using
            Button43.Enabled = False
            Button43.Visible = False
            Button41.Enabled = True
            Button41.Visible = True
            While TextBox7.Text < 159
                TextBox7.Text += 11
            End While
            hpu_b = 1
        End If
    End Sub

    'HPU Pump B Stop Button -Auto Mode
    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        If hpu_b = 1 And (dw_on = 0 Or cal_sum > 2) Then
            Delay(1)
            Using brush3 As New SolidBrush(Color.White)
                g.FillEllipse(brush3, 410, 680, 40, 40) 'HPU Pump B
            End Using
            Button41.Enabled = False
            Button41.Visible = False
            Button43.Enabled = True
            Button43.Visible = True
            While TextBox7.Text <> 0
                TextBox7.Text -= 11
            End While
            hpu_b = 0
        End If

    End Sub


    'Simulation Mode Selector
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        GroupBox5.Show()
        GroupBox1.Hide()
        GroupBox4.Hide()
        GroupBox5.Enabled = True
        GroupBox4.Enabled = False
        GroupBox1.Enabled = False
        manual_mode = 1
        auto_mode = 0
    End Sub

    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        TextBox10.Text = CInt(Math.Ceiling(Rnd() * 120)) + 1

        Dim id As Integer
        Dim curr_time As DateTime = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss")
        Dim alarm_desc, alarm_status, machine_unit As String
        Dim rw As DataRow
        'Add a new row to the Alarms table.
        rw = Alarms_Page.Alarm_recorderDataSet.Tables(0).NewRow
        id = Alarms_Page.Alarm_recorderDataSet.Tables(0).Rows.Count + 1
        machine_unit = "DW"
        alarm_status = "Active"
        alarm_desc = "DW Low air Pressure"
        rw.Item("Alarm ID") = id
        rw.Item("Alarm Time") = curr_time
        rw.Item("Alarm Description") = alarm_desc
        rw.Item("Machine Unit") = machine_unit
        rw.Item("Alarm Status") = alarm_status
        Try
            Alarms_Page.Alarm_recorderDataSet.Tables(0).Rows.Add(rw)
            'Update the Alarms table in the alarm_Recorder database.
            Alarms_Page.AlarmsTableAdapter.Update(Alarms_Page.Alarm_recorderDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click

        Dim curr_time As DateTime = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss")
        Dim alarm_desc, alarm_status, machine_unit As String
        Dim rw As DataRow
        'Add a new row to the Alarms table.
        rw = Alarms_Page.Alarm_recorderDataSet.Tables(0).NewRow
        machine_unit = "DW"
        alarm_status = "Active"
        alarm_desc = "DW Low air Pressure"
        'rw.Item("Alarm ID") = id
        rw.Item("Alarm Time") = curr_time
        rw.Item("Alarm Description") = alarm_desc
        rw.Item("Machine Unit") = machine_unit
        rw.Item("Alarm Status") = alarm_status
        Try
            'Update the column in the Alarms table.
            ' Alarms_Page.Alarm_recorderDataSet.Tables(0).Rows(rwno).Item(colname) = value
            'Update the Alarms table in the alarm_Recorder database.
            '  Alarms_Page.AlarmsTableAdapter.Update(Alarms_Page.Alarm_recorderDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Web_Browser.Show()
        Me.Hide()

    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        If hpu_a = 1 Or hpu_b = 1 Then
            TextBox7.Text = CInt(Math.Ceiling(Rnd() * 145)) + 1

            If cal_sum <> 4 Then
                Delay(1)
                Using brush4 As New SolidBrush(Color.Green)
                    g.FillRectangle(brush4, 388, 432, 7, 25) 'DW Brakes 1,2
                    g.FillRectangle(brush4, 367, 432, 7, 25) 'DW Brakes 1,2
                    g.FillRectangle(brush4, 388, 359, 7, 25) 'DW Brakes 3
                    g.FillRectangle(brush4, 227, 359, 7, 25) 'DW Brakes 4
                    g.FillRectangle(brush4, 227, 432, 7, 25) 'DW Brakes 5,6
                    g.FillRectangle(brush4, 248, 432, 7, 25) 'DW Brakes 5,6

                End Using
                cal12 = 1
                cal3 = 1
                cal4 = 1
                cal56 = 1
                Button21.Enabled = False
                Button21.Visible = False
                Button16.Enabled = True
                Button16.Visible = True

                Button22.Enabled = False
                Button22.Visible = False
                Button15.Enabled = True
                Button15.Visible = True

                Button23.Enabled = False
                Button23.Visible = False
                Button3.Enabled = True
                Button3.Visible = True

                Button24.Enabled = False
                Button24.Visible = False
                Button19.Enabled = True
                Button19.Visible = True


                TextBox5.Text = 0.0
                TextBox4.Text = 0.0
                TextBox3.Text = 0.0
                TextBox6.Text = 0.0

                cal_sum = cal12 + cal3 + cal4 + cal56
                Button37.Enabled = False
                Button37.Visible = False
                Button38.Enabled = True
                Button38.Visible = True

                Button40.Enabled = False
                Button40.Visible = False
                Button39.Enabled = True
                Button39.Visible = True

                Dim id1 As Integer
                Dim curr_time1 As DateTime = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss")
                Dim alarm_desc1, alarm_status1, machine_unit1 As String
                Dim rw1 As DataRow
                'Add a new row to the Alarms table.
                rw1 = Alarms_Page.Alarm_recorderDataSet.Tables(0).NewRow
                id1 = Alarms_Page.Alarm_recorderDataSet.Tables(0).Rows.Count + 1
                machine_unit1 = "DW_ HPU"
                alarm_status1 = "Active"
                alarm_desc1 = "DW Brakes Activated"
                rw1.Item("Alarm ID") = id1
                rw1.Item("Alarm Time") = curr_time1
                rw1.Item("Alarm Description") = alarm_desc1
                rw1.Item("Machine Unit") = machine_unit1
                rw1.Item("Alarm Status") = alarm_status1
                Try
                    Alarms_Page.Alarm_recorderDataSet.Tables(0).Rows.Add(rw1)
                    'Update the Alarms table in the alarm_Recorder database.
                    Alarms_Page.AlarmsTableAdapter.Update(Alarms_Page.Alarm_recorderDataSet)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If

            Dim id As Integer
            Dim curr_time As DateTime = DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss")
            Dim alarm_desc, alarm_status, machine_unit As String
            Dim rw As DataRow
            'Add a new row to the Alarms table.
            rw = Alarms_Page.Alarm_recorderDataSet.Tables(0).NewRow
            id = Alarms_Page.Alarm_recorderDataSet.Tables(0).Rows.Count + 1
            machine_unit = "DW_ HPU"
            alarm_status = "Active"
            alarm_desc = "DW Low HPU Pressure"
            rw.Item("Alarm ID") = id
            rw.Item("Alarm Time") = curr_time
            rw.Item("Alarm Description") = alarm_desc
            rw.Item("Machine Unit") = machine_unit
            rw.Item("Alarm Status") = alarm_status
            Try
                Alarms_Page.Alarm_recorderDataSet.Tables(0).Rows.Add(rw)
                'Update the Alarms table in the alarm_Recorder database.
                Alarms_Page.AlarmsTableAdapter.Update(Alarms_Page.Alarm_recorderDataSet)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub


End Class
