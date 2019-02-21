Imports System.Data.SqlClient
Imports System.IO
Public Class FormUser
    Private Sub DGUser_Paint(sender As Object, e As PaintEventArgs) Handles DGUser.Paint
        Dim barisKe, jmlBaris As Integer
        Dim IDUser As String

        jmlBaris = DGUser.RowCount - 1
        barisKe = DGUser.CurrentCell.RowIndex
        If barisKe < jmlBaris Then
            IDUser = DGUser.Item(0, barisKe).Value

            Dim Perintah As New SqlCommand
            Dim data As SqlDataReader

            KoneksiSQL = AmbilKoneksi()
            KoneksiSQL.Open()

            Perintah = KoneksiSQL.CreateCommand
            Perintah.CommandText = "Select Poto from TUser where IDUser = '" & IDUser & "' "

            data = Perintah.ExecuteReader
            data.Read()

            Dim MyFoto As Byte()
            If Not IsDBNull(data(0)) Then
                MyFoto = data(0)
                PBPotoUser.Image = Image.FromStream(New IO.MemoryStream(MyFoto))
                PBPotoUser.SizeMode = PictureBoxSizeMode.StretchImage
            End If
            KoneksiSQL.Close()
        Else
            PBPotoUser.ImageLocation = ("D:\Materi Asdos\VB Lanjut Sore 2019\RentalC\fotokosong.jpg")
            PBPotoUser.Load()
        End If
    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Perintah As New SqlCommand
        Dim daPerintah As New SqlDataAdapter
        Dim dsPerintah As New DataSet

        KoneksiSQL = AmbilKoneksi()
        KoneksiSQL.Open()

        Perintah = KoneksiSQL.CreateCommand
        Perintah.CommandText = "Select IDUser as 'ID USER', NamaUser as 'NAMA USER', Status as 'LEVEL' from TUser"
        daPerintah.SelectCommand = Perintah
        daPerintah.Fill(dsPerintah, "TUser")

        DGUser.DataSource = dsPerintah
        DGUser.DataMember = "TUser"
        DGUser.ReadOnly = True

        KoneksiSQL.Close()

    End Sub
End Class