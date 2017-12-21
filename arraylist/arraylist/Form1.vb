Public Class Form1
    Dim a As New ArrayList()
    Dim index As Integer
    Dim value As Integer
    Dim min As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        index = TextBox1.Text
        value = TextBox2.Text
        a.Insert(index, value)
        For i = 0 To a.Count - 1
            MessageBox.Show(a.Item(i))
        Next


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        a.RemoveAt(index)
        MessageBox.Show("value is deleted sucessfully")



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        min = a.Item(0)
        For i = 0 To a.Count - 1
            If min > a.Item(i) Then
                min = a.Item(i)
                MessageBox.Show(min)

            End If
        Next

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
