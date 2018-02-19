Public Class Form1

    Dim g As System.Drawing.Graphics


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics()
        Button3.Enabled = False
        Button3.Visible = False
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
        myGraphics.DrawString("M", myFont, myBrush, 712, 173) 'DW A 
        myGraphics.DrawString("M", myFont, myBrush, 712, 283) 'DW B
        myGraphics.DrawString("M", myFont, myBrush, 712, 382) 'DW C
        myGraphics.DrawString("M", myFont, myBrush, 612, 170) 'DW A Blower
        myGraphics.DrawString("M", myFont, myBrush, 612, 283) 'DW B Blower
        myGraphics.DrawString("M", myFont, myBrush, 612, 381) 'DW C Blower


        Using pen1 As New Pen(Color.LightGray, 1)
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
        End Using

        Using pen2 As New Pen(Color.Black, 1)
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
            e.Graphics.DrawEllipse(pen2, 180, 775, 10, 10) 'HPU Tank Temp High
            e.Graphics.DrawEllipse(pen2, 180, 800, 10, 10) 'HPU Tank Level Low

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

        End Using

        Using brush1 As New SolidBrush(Color.LightGray)
            e.Graphics.FillRectangle(brush1, 238, 360, 7, 100) 'DW Drum
            e.Graphics.FillRectangle(brush1, 378, 360, 7, 100) 'DW Drum
            e.Graphics.FillRectangle(brush1, 245, 390, 135, 40) 'DW Drum
            e.Graphics.FillEllipse(brush1, 730, 790, 60, 60) 'Lube Oil Pump
            e.Graphics.FillEllipse(brush1, 100, 670, 60, 60) 'HPU Pump A
            e.Graphics.FillEllipse(brush1, 400, 670, 60, 60) 'HPU Pump B
            e.Graphics.FillEllipse(brush1, 180, 775, 10, 10) 'HPU Tank Temp High
            e.Graphics.FillEllipse(brush1, 180, 800, 10, 10) 'HPU Tank Level Low
        End Using

        Using brush2 As New SolidBrush(Color.White)
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

            e.Graphics.FillRectangle(brush2, 227, 359, 7, 25) 'DW Brakes
            e.Graphics.FillRectangle(brush2, 388, 359, 7, 25) 'DW Brakes
            e.Graphics.FillRectangle(brush2, 227, 432, 7, 25) 'DW Brakes
            e.Graphics.FillRectangle(brush2, 388, 432, 7, 25) 'DW Brakes
            e.Graphics.FillRectangle(brush2, 248, 432, 7, 25) 'DW Brakes
            e.Graphics.FillRectangle(brush2, 367, 432, 7, 25) 'DW Brakes

        End Using

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using brush3 As New SolidBrush(Color.LawnGreen)
            g.FillEllipse(brush3, 600, 160, 60, 60) 'DW A Blower
            g.FillEllipse(brush3, 600, 270, 60, 60) 'DW B Blower
        End Using
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Button3.Enabled = False
    End Sub
End Class
