Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        Dim dirinfo = New DirectoryInfo(dir)
        Dim files = dirinfo.GetFiles("*.jpg")
        ImageList1.Images.Clear()
        ListView1.Items.Clear()
        ListView1.View = View.LargeIcon
        Dim i = 0
        For Each file In files
            Dim image = Bitmap.FromFile(file.FullName)
            ImageList1.Images.Add(image)
            ListView1.Items.Add(file.Name, i)
            i = i + 1
        Next

    End Sub
End Class
