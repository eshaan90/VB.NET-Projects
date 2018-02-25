Public Class Test_Page
    Private Sub Test_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestdbDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.TestdbDataSet.Student)

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Add Button
        Dim i, sno As Integer
        Dim sname As String
        Dim rw As DataRow
        'Add a new row to the Student table.
        rw = TestdbDataSet.Tables(0).NewRow
        sno = InputBox("Enter the Roll no of the Student:")
        sname = InputBox("Enter the Name of the Student:")
        rw.Item("SNo") = sno
        rw.Item("SName") = sname
        Try
            TestdbDataSet.Tables(0).Rows.Add(rw)
            'Update the Student table in the testdb database.
            i = StudentTableAdapter.Update(TestdbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'Displays number of rows updated. 
        MessageBox.Show("no of rows updated=" & i)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Update Button
        Dim i, rwno As Integer
        Dim colname As String
        Dim value As Object
        colname = InputBox("Enter the name of the Column to be updated")
        rwno = InputBox("Enter the Row Number to be updated: Row No starts from 0")
        value = InputBox("Enter the value to be entered into the Student table")
        Try
            'Update the column in the Student table.
            TestdbDataSet.Tables(0).Rows(rwno).Item(colname) = value
            'Update the Student table in the testdb database.
            i = StudentTableAdapter.Update(TestdbDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'Displays number of rows updated.
        MessageBox.Show("no of rows updated=" & i)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Delete Button
        Dim i As Integer
        Dim rno As Integer
        rno = InputBox("Enter the Row no to be deleted: Row no starts from 0")
        Try
            'Delete a row from the Student table.
            TestdbDataSet.Tables(0).Rows(rno).Delete()
            'Update the Student table in the testdb database.
            i = StudentTableAdapter.Update(TestdbDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Displays number of rows updated. 
        MessageBox.Show("no of rows updated=" & i)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class