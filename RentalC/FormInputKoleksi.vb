Imports System.Data.SqlClient

Public Class FormInputKoleksi
    Private Sub resetField()

        TextIDKoleksi.Text = ""
        TextJudul.Text = ""
        cmbJenis.SelectedIndex = 0
        TextBiayaSewa.Text = ""
        nudJumlah.Value = 0
        nudJangkaWaktu.Value = 0
        PBPentung.Visible = False
        LabelTidakTersedia.Visible = False
        PBCentang.Visible = False
        TextIDKoleksi.Focus()

    End Sub

    Private Sub FormInputKoleksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        resetField()

        Dim data As SqlDataReader
        Dim perintah As SqlCommand

        KoneksiSQL = AmbilKoneksi()
        KoneksiSQL.Open()

        perintah = KoneksiSQL.CreateCommand
        perintah.CommandText = "select IDLokasi, NamaLokasi from TLokasi"
        data = perintah.ExecuteReader

        While data.Read
            cmbIDLokasi.Items.Add(data(0) & " | " & data(1))
        End While

        KoneksiSQL.Close()
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        resetField()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub TextIDKoleksi_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextIDKoleksi.Leave
        Dim Perintah As SqlCommand
        Dim IDKoleksi As String
        Dim Data As SqlDataReader

        IDKoleksi = Trim(TextIDKoleksi.Text)

        KoneksiSQL = AmbilKoneksi()
        KoneksiSQL.Open()

        Perintah = KoneksiSQL.CreateCommand
        Perintah.CommandText = "select IDKoleksi from TKoleksi where IDKoleksi='" & IDKoleksi & "'"

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

    Private Sub BtnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        Dim IDKoleksi, Judul, Jenis, BiayaSewa, IDLokasi As String
        Dim Jumlah, JangkaWaktu As Integer

        Dim Perintah As SqlCommand

        IDKoleksi = TextIDKoleksi.Text
        Judul = TextJudul.Text
        Jenis = cmbJenis.Text
        Jumlah = nudJumlah.Text
        JangkaWaktu = nudJangkaWaktu.Text
        BiayaSewa = TextBiayaSewa.Text
        IDLokasi = cmbIDLokasi.Text

        IDLokasi = Strings.Left(cmbIDLokasi.Text, 4)

        If TextIDKoleksi.Text = "" Then
            MsgBox("Pastikan semua kolom terisi !", MsgBoxStyle.Critical, "Error")
            TextIDKoleksi.Focus()

        ElseIf TextJudul.Text = "" Then
            MsgBox("Pastikan semua kolom terisi !", MsgBoxStyle.Critical, "Error")
            TextJudul.Focus()

        ElseIf cmbJenis.Text = "" Then
            MsgBox("Pastikan semua kolom terisi !", MsgBoxStyle.Critical, "Error")
            cmbJenis.Focus()

        ElseIf nudJumlah.Value = 0 Then
            MsgBox("Pastikan semua kolom terisi !", MsgBoxStyle.Critical, "Error")
            nudJumlah.Focus()

        ElseIf nudJangkaWaktu.Value = 0 Then
            MsgBox("Pastikan semua kolom terisi !", MsgBoxStyle.Critical, "Error")
            nudJangkaWaktu.Focus()

        ElseIf TextBiayaSewa.Text = "" Then
            MsgBox("Pastikan semua kolom terisi !", MsgBoxStyle.Critical, "Error")
            TextBiayaSewa.Focus()

        ElseIf cmbIDLokasi.Text = "" Then
            MsgBox("Pastikan semua kolom terisi !", MsgBoxStyle.Critical, "Error")
            cmbIDLokasi.Focus()

        Else
            KoneksiSQL = AmbilKoneksi()
            KoneksiSQL.Open()

            Perintah = KoneksiSQL.CreateCommand
            Perintah.CommandText = "insert into TKoleksi values ('" & IDKoleksi & "','" &
                Judul & "','" & Jenis & "', '" & Jumlah & "', '" & JangkaWaktu & "', '" & BiayaSewa & "', '" & IDLokasi & "')"

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