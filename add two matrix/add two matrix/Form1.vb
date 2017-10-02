Public Class Form1
    Dim I, J As Integer
    Dim ARRAY1(2, 2), ARRAY2(2, 2), ARRAY3(2, 2) As Double


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For I = 1 To 2

            For J = 1 To 2

                ARRAY3(I, J) = ARRAY1(I, J) + ARRAY2(I, J)


            Next
        Next
        Label13.Text = ARRAY3(1, 1)
        Label12.Text = ARRAY3(1, 2)
        Label11.Text = ARRAY3(2, 1)
        Label10.Text = ARRAY3(2, 2)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For I = 1 To 2
            MsgBox("enter the number for row " & I)
            For J = 1 To 2
                MsgBox("enter the number for column" & J)
                ARRAY1(I, J) = InputBox("enter the number")

            Next
        Next

        Label1.Text = ARRAY1(1, 1)
        Label2.Text = ARRAY1(1, 2)
        Label3.Text = ARRAY1(2, 1)
        Label4.Text = ARRAY1(2, 2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For I = 1 To 2
            MsgBox("enter the number for row " & I)
            For J = 1 To 2
                MsgBox("enter the numbe for column" & J)
                ARRAY2(I, J) = InputBox("enter the number")
            Next
        Next
        Label9.Text = ARRAY2(1, 1)
        Label8.Text = ARRAY2(1, 2)
        Label7.Text = ARRAY2(2, 1)
        Label6.Text = ARRAY2(2, 2)

    End Sub

End Class
