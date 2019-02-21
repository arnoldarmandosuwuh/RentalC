Imports System.Data.SqlClient
Imports System.IO

Public Class FormInputUser

    Private Sub resetField()

        TextIDUser.Text = ""
        TextNamaUser.Text = ""
        TextPassword.Text = ""
        TextRePassword.Text = ""
        CmbLevelUser.SelectedIndex = 0
        PBPentung.Visible = False
        LabelTidakTersedia.Visible = False
        PBCentang.Visible = False
        PBPoto.ImageLocation = ("D:\Materi Asdos\VB Lanjut Sore 2019\RentalC\fotokosong.jpg")

    End Sub

    Private Sub FormInputUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        resetField()

    End Sub

    Private Sub TextIDUser_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextIDUser.Leave

        Dim Perintah As SqlCommand
        Dim IDUser As String
        Dim Data As SqlDataReader

        IDUser = Trim(TextIDUser.Text)

        KoneksiSQL = AmbilKoneksi()
        KoneksiSQL.Open()

        Perintah = KoneksiSQL.CreateCommand
        Perintah.CommandText = "select IDUser from TUser where IDUser='" & IDUser & "'"

        Data = Perintah.ExecuteReader
        If Data.Read Then
            ' data ada, sehingga username sudah terpakai
            LabelTidakTersedia.Visible = True
            LabelTidakTersedia.Text = "tidak tersedia"
            PBPentung.Visible = True
            PBCentang.Visible = False
        Else
            ' datanya tidak ada, usernamenya belum terpakai
            PBPentung.Visible = False
            LabelTidakTersedia.Visible = False
            PBCentang.Visible = True
        End If
        KoneksiSQL.Close()

    End Sub

    Private Sub BtnFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFoto.Click

        ODBukaPoto.InitialDirectory = "D:\Materi Asdos\VB Lanjut Sore 2019\RentalC\Pictures\"

        ODBukaPoto.Filter = "All files (*.*)|*.*|JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|" &
            "PNG Files (*.png)|*.png|GIF Files (*.gif)|*.gif"

        Try
            If ODBukaPoto.ShowDialog = Windows.Forms.DialogResult.OK Then
                PBPoto.Image = New Bitmap(ODBukaPoto.FileName)
                PBPoto.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click

        ' mendeklarasikan variabel untuk menyimpan data yang dituliskan di form
        Dim IDUser, NamaUser, Password, RePassword, Status As String

        ' membuat variabel untuk perintah SQL
        Dim Perintah As SqlCommand

        ' data yang diketikkan di form disimpan di variabel-variabel yang telah dideklarasikan
        IDUser = Trim(TextIDUser.Text)
        NamaUser = TextNamaUser.Text
        Password = TextPassword.Text
        RePassword = TextRePassword.Text
        Status = CmbLevelUser.Text

        If TextIDUser.Text = "" Then
            MsgBox("ID User belum terisi !", MsgBoxStyle.Critical, "Error")
            TextIDUser.Focus()

        ElseIf TextNamaUser.Text = "" Then
            MsgBox("Nama User belum terisi !", MsgBoxStyle.Critical, "Error")
            TextNamaUser.Focus()

            ' memeriksa apakah data yang diisikan di Password sama dengan data di RePassword
        ElseIf Password = RePassword Then
            ' data di Password sama dengan data di RePassword

            ' data user baru siap dimasukkan ke database

            ' membuat koneksi ke database
            KoneksiSQL = AmbilKoneksi()
            KoneksiSQL.Open()

            ' membuat perintah SQL
            Perintah = KoneksiSQL.CreateCommand
            Perintah.CommandText = "insert into TUser values ('" & IDUser & "','" &
                NamaUser & "','" & Password & "','" & Status & "',@Gambar)"

            Dim ms As New MemoryStream
            PBPoto.Image.Save(ms, PBPoto.Image.RawFormat)
            Perintah.Parameters.Add("@Gambar", SqlDbType.Image).Value = ms.ToArray

            ' menjalankan perintah SQL
            If Perintah.ExecuteNonQuery > 0 Then
                ' data berhasil ditambahkan
                MsgBox("Data berhasil ditambahkan", MsgBoxStyle.Information, "Informasi")
            Else
                ' data gagal ditambahkan
                MsgBox("Data gagal ditambahkan", MsgBoxStyle.Critical, "Error")
            End If

            ' memutuskan koneksi dengan database
            KoneksiSQL.Close()

            ' menghapus isi form
            resetField()

        Else
            ' data di Password berbeda dengan data di RePassword
            MsgBox("Pastikan password dan re-password sama", MsgBoxStyle.Exclamation, "Error")
        End If

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        resetField()
    End Sub
End Class
