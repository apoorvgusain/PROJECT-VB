Public Class Form1
    Dim i As Integer
    Dim array(10) As Integer
    Dim sum As Integer
    Dim avg As Single



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For i = 0 To 9
            array(i) = ListBox1.Items(i)

        Next
        For i = 0 To 9
            MessageBox.Show(array(i))


        Next


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        sum = 0
        For i = 0 To 9
            sum = sum + array(i)

        Next
        TextBox2.Text = sum


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        avg = sum \ 10
        TextBox2.Text = avg

    End Sub
End Class
