Imports System.Data.OleDb

Public Class Login_Page

    'Dim provider As String
    'Dim dataFile As String
    'Dim connString As String
    'Dim myConnection As OleDbConnection = New OleDbConnection


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        'dataFile = "C:\Users\evkirpal\Documents\Alarm Management.accdb"
        'connString = provider And dataFile
        'myConnection.ConnectionString = connString
        'myConnection.Open()

        Delay(1)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        'dataFile = "C:\Users\evkirpal\Documents\Alarm Management.accdb"
        'connString = provider And dataFile
        'myConnection.ConnectionString = connString
        'myConnection.Open()
        'Delay(1)


        Form1.Show()
        Me.Hide()
    End Sub
End Class