Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(0, 0, 0)
        HScrollBar1.Maximum = 255
        HScrollBar1.Minimum = 0
        HScrollBar2.Minimum = 0
        HScrollBar3.Minimum = 0
        HScrollBar2.Maximum = 255
        HScrollBar3.Maximum = 255

    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll, HScrollBar2.Scroll, HScrollBar3.Scroll

        Me.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)



    End Sub
End Class
