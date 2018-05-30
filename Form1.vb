Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.t.Abort()
        Form2.RestartTh()
        Form2.t.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.t.Abort()
        Form2.Draw(False)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.t.Abort()
    End Sub
End Class

'https://zhidao.baidu.com/question/507061160.html
'Private Sub Draw()
'    Dim bmp As New Bitmap(200, 100, Imaging.PixelFormat.Format32bppArgb)
'    bmp.SetPixel(10, 10, Color.Red)  '在PictureBox1控件的（10，10）坐标，画一个红点
'    Form2.PictureBox1.Image = bmp
'End Sub