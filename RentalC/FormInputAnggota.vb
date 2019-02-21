Imports System.Data.SqlClient
Imports System.IO

Public Class FormInputAnggota
    Private Sub resetField()

        TextIDAnggota.Text = ""
        TextNamaAnggota.Text = ""
        rtbAlamat.Text = ""
        TextNoHP.Text = ""
        PBPentung.Visible = False
        LabelTidakTersedia.Visible = False
        PBCentang.Visible = False
        PBPoto.ImageLocation = ("D:\Materi Asdos\VB Lanjut Sore 2019\RentalC\fotokosong.jpg")
        TextIDAnggota.Focus()

    End Sub

    Private Sub FormInputAnggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resetField()
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        resetField()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub TextIDAnggota_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextIDAnggota.Leave
        Dim Perintah As SqlCommand
        Dim IDAnggota As String
        Dim Data As SqlDataReader

        IDAnggota = Trim(TextIDAnggota.Text)

        KoneksiSQL = AmbilKoneksi()
        KoneksiSQL.Open()

        Perintah = KoneksiSQL.CreateCommand
        Perintah.CommandText = "select IDAnggota from TAnggota where IDAnggota='" & IDAnggota & "'"

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
    Private Sub BtnFoto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnFoto.Click
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
        Dim IDAnggota, NamaAnggota, Alamat, NoHP As String

        Dim Perintah As SqlCommand

        IDAnggota = Trim(TextIDAnggota.Text)
        NamaAnggota = TextNamaAnggota.Text
        Alamat = rtbAlamat.Text
        NoHP = TextNoHP.Text

        If TextIDAnggota.Text = "" Then
            MsgBox("ID Anggota belum terisi !", MsgBoxStyle.Critical, "Error")
            TextIDAnggota.Focus()

        ElseIf TextNamaAnggota.Text = "" Then
            MsgBox("Nama Anggota belum terisi !", MsgBoxStyle.Critical, "Error")
            TextNamaAnggota.Focus()

        ElseIf rtbAlamat.Text = "" Then
            MsgBox("Alamat belum terisi !", MsgBoxStyle.Critical, "Error")
            rtbAlamat.Focus()

        ElseIf TextNoHP.Text = "" Then
            MsgBox("No HP belum terisi !", MsgBoxStyle.Critical, "Error")
            TextNoHP.Focus()

        Else
            KoneksiSQL = AmbilKoneksi()
            KoneksiSQL.Open()

            Perintah = KoneksiSQL.CreateCommand
            Perintah.CommandText = "insert into TAnggota values ('" & IDAnggota & "','" &
                NamaAnggota & "','" & Alamat & "',@Gambar, '" & NoHP & "')"

            Dim ms As New MemoryStream
            PBPoto.Image.Save(ms, PBPoto.Image.RawFormat)
            Perintah.Parameters.Add("@Gambar", SqlDbType.Image).Value = ms.ToArray

            If Perintah.ExecuteNonQuery > 0 Then
                MsgBox("Data berhasil ditambahkan", MsgBoxStyle.Information, "Informasi")
            Else
                MsgBox("Data gagal ditambahkan", MsgBoxStyle.Critical, "Error")
            End If

            KoneksiSQL.Close()

            resetField()
        End If
    End Sub
End Class