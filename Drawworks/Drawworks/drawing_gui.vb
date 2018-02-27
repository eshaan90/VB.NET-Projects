Public Class drawing_gui

    Dim g As System.Drawing.Graphics

    Public Sub draw()
        g = Form1.CreateGraphics()
        Dim myGraphics As Graphics = Form1.CreateGraphics
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



        myGraphics.DrawLine(pen1, 600, 595, 1120, 595)
        myGraphics.DrawLine(pen1, 1120, 595, 1120, 900)
        myGraphics.DrawLine(pen1, 80, 595, 570, 595)
        myGraphics.DrawLine(pen1, 580, 595, 600, 595)
        myGraphics.DrawLine(pen1, 580, 595, 580, 900)
        myGraphics.DrawLine(pen1, 20, 595, 80, 595)
        myGraphics.DrawLine(pen1, 20, 595, 20, 900)
        myGraphics.DrawLine(pen1, 570, 595, 570, 900)
        myGraphics.DrawLine(pen1, 20, 900, 570, 900)
        myGraphics.DrawLine(pen1, 580, 900, 1120, 900)

        myGraphics.DrawEllipse(pen1, 700, 160, 60, 60) 'DW A
        myGraphics.DrawEllipse(pen1, 700, 270, 60, 60) 'DW B
        myGraphics.DrawEllipse(pen1, 700, 370, 60, 60) 'DW C
        myGraphics.DrawEllipse(pen1, 600, 160, 60, 60) 'DW A Blower
        myGraphics.DrawEllipse(pen1, 600, 270, 60, 60) 'DW B Blower
        myGraphics.DrawEllipse(pen1, 600, 370, 60, 60) 'DW C Blower


        myGraphics.DrawRectangle(pen2, 237, 359, 8, 101) 'DW Drum
        myGraphics.DrawRectangle(pen2, 377, 359, 8, 101) 'DW Drum
        myGraphics.DrawRectangle(pen2, 245, 389, 135, 41) 'DW Drum
        myGraphics.DrawEllipse(pen2, 100, 670, 61, 61) 'HPU Pump A
        myGraphics.DrawEllipse(pen2, 400, 670, 61, 61) 'HPU Pump B
        myGraphics.DrawEllipse(pen2, 730, 790, 61, 61) 'Lube Oil Pump
        myGraphics.DrawRectangle(pen2, 757, 686, 7, 105) 'Lube Oil Pipeline
        myGraphics.DrawRectangle(pen2, 757, 620, 7, 41) 'Lube Oil Pipeline
        myGraphics.DrawRectangle(pen2, 757, 620, 150, 7) 'Lube Oil Pipeline
        myGraphics.DrawRectangle(pen2, 900, 620, 7, 41) 'Lube Oil Pipeline


        myGraphics.DrawLine(pen2, 660, 190, 690, 190) 'DW A Blower
        myGraphics.DrawLine(pen2, 660, 300, 690, 300) 'DW B Blower
        myGraphics.DrawLine(pen2, 660, 400, 690, 400) 'DW C Blower
        myGraphics.DrawEllipse(pen2, 680, 160, 15, 30) 'DW A Blower
        myGraphics.DrawEllipse(pen2, 680, 270, 15, 30) 'DW B Blower
        myGraphics.DrawEllipse(pen2, 680, 370, 15, 30) 'DW C Blower
        myGraphics.DrawEllipse(pen2, 680, 190, 15, 30) 'DW A Blower
        myGraphics.DrawEllipse(pen2, 680, 300, 15, 30) 'DW B Blower
        myGraphics.DrawEllipse(pen2, 680, 400, 15, 30) 'DW C Blower

        myGraphics.DrawRectangle(pen2, 127, 630, 7, 40) 'HPU System Pipeline
        myGraphics.DrawRectangle(pen2, 127, 731, 7, 20) 'HPU System Pipeline
        myGraphics.DrawRectangle(pen2, 426, 731, 7, 20) 'HPU System Pipeline
        myGraphics.DrawRectangle(pen2, 426, 630, 7, 40) 'HPU System Pipeline
        myGraphics.DrawRectangle(pen2, 127, 630, 300, 7) 'HPU System Pipeline
        myGraphics.DrawRectangle(pen2, 127, 751, 360, 7) 'HPU System Pipeline
        myGraphics.DrawRectangle(pen2, 350, 580, 7, 50) 'HPU System Pipeline
        myGraphics.DrawRectangle(pen2, 400, 870, 90, 7) 'HPU System Pipeline
        myGraphics.DrawRectangle(pen2, 487, 751, 7, 126) 'HPU System Pipeline

        myGraphics.DrawRectangle(pen2, 121, 320, 30, 7) 'DW Pipeline
        myGraphics.DrawRectangle(pen2, 121, 507, 30, 7) 'DW Pipeline
        myGraphics.DrawRectangle(pen2, 458, 317, 30, 7) 'DW Pipeline
        myGraphics.DrawRectangle(pen2, 458, 507, 30, 7) 'DW Pipeline
        myGraphics.DrawRectangle(pen2, 121, 320, 7, 225) 'DW Pipeline
        myGraphics.DrawRectangle(pen2, 488, 317, 7, 228) 'DW Pipeline
        myGraphics.DrawRectangle(pen2, 121, 545, 374, 7) 'DW Pipeline
        myGraphics.DrawRectangle(pen2, 350, 552, 7, 20) 'DW Pipeline

        myGraphics.DrawRectangle(pen2, 75, 210, 397, 7) 'Clutch Pipeline
        myGraphics.DrawRectangle(pen2, 75, 150, 31, 7) 'Clutch Pipeline
        myGraphics.DrawRectangle(pen2, 430, 150, 35, 7) 'Clutch Pipeline
        myGraphics.DrawRectangle(pen2, 75, 150, 7, 60) 'Clutch Pipeline
        myGraphics.DrawRectangle(pen2, 465, 150, 7, 60) 'Clutch Pipeline

        myGraphics.DrawRectangle(pen2, 227, 359, 7, 25) 'DW Brakes
        myGraphics.DrawRectangle(pen2, 388, 359, 7, 25) 'DW Brakes 
        myGraphics.DrawRectangle(pen2, 227, 432, 7, 25) 'DW Brakes 
        myGraphics.DrawRectangle(pen2, 388, 432, 7, 25) 'DW Brakes 
        myGraphics.DrawRectangle(pen2, 248, 432, 7, 25) 'DW Brakes 
        myGraphics.DrawRectangle(pen2, 367, 432, 7, 25) 'DW Brakes 

        myGraphics.FillRectangle(brush1, 238, 360, 7, 100) 'DW Drum
        myGraphics.FillRectangle(brush1, 378, 360, 7, 100) 'DW Drum
        myGraphics.FillRectangle(brush1, 245, 390, 135, 40) 'DW Drum
        myGraphics.FillEllipse(brush1, 730, 790, 60, 60) 'Lube Oil Pump
        myGraphics.FillEllipse(brush1, 100, 670, 60, 60) 'HPU Pump A
        myGraphics.FillEllipse(brush1, 400, 670, 60, 60) 'HPU Pump B


        myGraphics.FillEllipse(brush2, 700, 160, 60, 60) 'DW A Motor
        myGraphics.FillEllipse(brush2, 700, 270, 60, 60) 'DW B Motor
        myGraphics.FillEllipse(brush2, 700, 370, 60, 60) 'DW C Motor
        myGraphics.FillEllipse(brush2, 600, 160, 60, 60) 'DW A Blower Motor
        myGraphics.FillEllipse(brush2, 600, 270, 60, 60) 'DW B Blower Motor
        myGraphics.FillEllipse(brush2, 600, 370, 60, 60) 'DW C Blower Motor
        myGraphics.FillEllipse(brush2, 740, 800, 40, 40) 'Lube Oil Pump
        myGraphics.FillEllipse(brush2, 110, 680, 40, 40) 'HPU Pump A
        myGraphics.FillEllipse(brush2, 410, 680, 40, 40) 'HPU Pump B
        myGraphics.FillRectangle(brush2, 757, 686, 7, 105) 'Lube Oil Pipeline
        myGraphics.FillRectangle(brush2, 757, 620, 7, 41) 'Lube Oil Pipeline
        myGraphics.FillRectangle(brush2, 757, 620, 150, 7) 'Lube Oil Pipeline
        myGraphics.FillRectangle(brush2, 900, 620, 7, 41) 'Lube Oil Pipeline

        myGraphics.FillRectangle(brush2, 127, 630, 7, 40) 'HPU System Pipeline
        myGraphics.FillRectangle(brush2, 127, 731, 7, 20) 'HPU System Pipeline
        myGraphics.FillRectangle(brush2, 426, 731, 7, 20) 'HPU System Pipeline
        myGraphics.FillRectangle(brush2, 426, 630, 7, 40) 'HPU System Pipeline
        myGraphics.FillRectangle(brush2, 127, 630, 300, 7) 'HPU System Pipeline
        myGraphics.FillRectangle(brush2, 127, 751, 360, 7) 'HPU System Pipeline
        myGraphics.FillRectangle(brush2, 350, 580, 7, 50) 'HPU System Pipeline
        myGraphics.FillRectangle(brush2, 400, 870, 90, 7) 'HPU System Pipeline
        myGraphics.FillRectangle(brush2, 487, 751, 7, 126) 'HPU System Pipeline

        myGraphics.FillRectangle(brush2, 121, 320, 30, 7) 'DW Pipeline
        myGraphics.FillRectangle(brush2, 121, 507, 30, 7) 'DW Pipeline
        myGraphics.FillRectangle(brush2, 458, 317, 30, 7) 'DW Pipeline
        myGraphics.FillRectangle(brush2, 458, 507, 30, 7) 'DW Pipeline
        myGraphics.FillRectangle(brush2, 121, 320, 7, 225) 'DW Pipeline
        myGraphics.FillRectangle(brush2, 488, 317, 7, 228) 'DW Pipeline
        myGraphics.FillRectangle(brush2, 121, 545, 374, 7) 'DW Pipeline
        myGraphics.FillRectangle(brush2, 350, 552, 7, 20) 'DW Pipeline

        myGraphics.FillRectangle(brush2, 75, 210, 397, 7) 'Clutch Pipeline
        myGraphics.FillRectangle(brush2, 75, 150, 31, 7) 'Clutch Pipeline
        myGraphics.FillRectangle(brush2, 430, 150, 35, 7) 'Clutch Pipeline
        myGraphics.FillRectangle(brush2, 75, 150, 7, 60) 'Clutch Pipeline
        myGraphics.FillRectangle(brush2, 465, 150, 7, 60) 'Clutch Pipeline

        myGraphics.FillRectangle(brush4, 227, 359, 7, 25) 'DW Brakes 4
        myGraphics.FillRectangle(brush4, 388, 359, 7, 25) 'DW Brakes 3
        myGraphics.FillRectangle(brush4, 227, 432, 7, 25) 'DW Brakes 5,6
        myGraphics.FillRectangle(brush4, 388, 432, 7, 25) 'DW Brakes 1,2
        myGraphics.FillRectangle(brush4, 248, 432, 7, 25) 'DW Brakes 5,6
        myGraphics.FillRectangle(brush4, 367, 432, 7, 25) 'DW Brakes 1,2
    End Sub

End Class
