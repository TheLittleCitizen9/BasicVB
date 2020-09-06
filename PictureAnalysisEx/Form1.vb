Imports System.Drawing.Imaging
Imports AForge.Imaging

Public Class Form1
    Private Sub ChangeColorButton_Click(sender As Object, e As EventArgs) Handles ChangeColorButton.Click
        Dim bmp As Bitmap = New Bitmap(PictureBox1.Image)
        Dim x As Integer
        Dim y As Integer
        For x = 0 To bmp.Width - 1

            For y = 0 To bmp.Height - 1
                Dim oldPixelColor As Color = bmp.GetPixel(x, y)
                Dim newPixelColor As Color = Color.FromArgb(0, oldPixelColor.G, 0)
                bmp.SetPixel(x, y, newPixelColor)
            Next

        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub LoadPicture_Click(sender As Object, e As EventArgs) Handles LoadPicture.Click
        Dim openfile As New OpenFileDialog
        If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openfile.FileName)
        End If
    End Sub

    Private Sub LineButton_Click(sender As Object, e As EventArgs) Handles LineButton.Click
        Dim G As Graphics = PictureBox1.CreateGraphics
        Dim P As Pen = New Pen(Brushes.AliceBlue, 10)
        G.DrawLine(P, New Point(0, 0), New Point(PictureBox1.Width, PictureBox1.Height))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As New Pen(Color.BlueViolet, 5)
        Dim g As Graphics
        g = PictureBox1.CreateGraphics
        g.DrawEllipse(p, 70, 10, 100, 150)
    End Sub
End Class
