Imports System.Threading
Public Class Form2
    Public t As New Thread(AddressOf Draw)

    Private Delegate Sub VoidDelegate()

    Public Sub Draw(Optional ByVal IsAddList As Boolean = True)
        Dim boxX, boxY As Integer
        Dim R, B, G As Integer
        Dim ran As New Random

        boxX = PictureBox1.Width
        boxY = PictureBox1.Height
        Dim bmp As New Bitmap(boxX, boxY, Imaging.PixelFormat.Format32bppArgb)
        'Randomize()
        For y = 0 To boxY - 1
            For x = 0 To boxX - 1
                R = ran.Next(256)
                G = ran.Next(256)
                B = ran.Next(256)
                'PictureBox1.Image = bmp
                Me.Invoke(New VoidDelegate(Sub()
                                               bmp.SetPixel(x, y, Color.FromArgb(R, G, B))
                                               PictureBox1.Image = bmp
                                               If IsAddList Then
                                                   Form1.ListBox1.Items.Add(R)
                                                   Form1.ListBox1.SelectedIndex = Form1.ListBox1.Items.Count - 1
                                               End If
                                           End Sub))
                'If IsAddList Then t.Sleep(0)
            Next x
        Next y
    End Sub

    Public Sub RestartTh()
        t = New Thread(AddressOf Draw)
    End Sub
End Class