Public Class Alarms_Page


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Public Sub Alarms_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Alarm_recorderDataSet.Alarms' table. You can move, or remove it, as needed.
        Me.AlarmsTableAdapter.Fill(Me.Alarm_recorderDataSet.Alarms)

    End Sub

    'Ack One Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If Alarm_recorderDataSet.Tables(0).Rows() Then
        'End If

        'End If
    End Sub
End Class