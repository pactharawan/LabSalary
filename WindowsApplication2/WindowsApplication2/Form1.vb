Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        lbl1.Text = txt1.Text * 12
        lbl2.Text = lbl1.Text * 0.05
        lbl3.Text = lbl1.Text - lbl2.Text
    End Sub
End Class
