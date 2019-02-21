Imports System.Data.SqlClient

Public Class FormInputLokasi

    Private Sub resetField()

        TextIDLokasi.Text = ""
        TextNamaLokasi.Text = ""
        TextTempat.Text = ""
        PBPentung.Visible = False
        LabelTidakTersedia.Visible = False
        PBCentang.Visible = False
        TextIDLokasi.Focus()

    End Sub

    Private Sub TextIDLokasi_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextIDLokasi.Leave
        Dim Perintah As SqlCommand
        Dim IDLokasi As String
        Dim Data As SqlDataReader

        IDLokasi = Trim(TextIDLokasi.Text)

        KoneksiSQL = AmbilKoneksi()
        KoneksiSQL.Open()

        Perintah = KoneksiSQL.CreateCommand
        Perintah.CommandText = "select IDLokasi from TLokasi where IDLokasi='" & IDLokasi & "'"

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

    Private Sub FormInputLokasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resetField()
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        resetField()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        Dim IDLokasi, NamaLokasi, Tempat As String

        Dim Perintah As SqlCommand

        IDLokasi = Trim(TextIDLokasi.Text)
        NamaLokasi = TextNamaLokasi.Text
        Tempat = TextTempat.Text

        If TextIDLokasi.Text = "" Then
            MsgBox("ID Lokasi belum terisi !", MsgBoxStyle.Critical, "Error")
            TextIDLokasi.Focus()

        ElseIf TextNamaLokasi.Text = "" Then
            MsgBox("Nama Lokasi belum terisi !", MsgBoxStyle.Critical, "Error")
            TextNamaLokasi.Focus()

        ElseIf TextTempat.Text = "" Then
            MsgBox("Tempat Lokasi belum terisi !", MsgBoxStyle.Critical, "Error")
            TextTempat.Focus()

        Else
            KoneksiSQL = AmbilKoneksi()
            KoneksiSQL.Open()

            Perintah = KoneksiSQL.CreateCommand
            Perintah.CommandText = "insert into TLokasi values ('" & IDLokasi & "','" &
                NamaLokasi & "','" & Tempat & "')"

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