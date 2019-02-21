<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBiayaSewa = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbIDLokasi = New System.Windows.Forms.ComboBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.nudJangkaWaktu = New System.Windows.Forms.NumericUpDown()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.nudJumlah = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelTidakTersedia = New System.Windows.Forms.Label()
        Me.PBPentung = New System.Windows.Forms.PictureBox()
        Me.PBCentang = New System.Windows.Forms.PictureBox()
        Me.TextJudul = New System.Windows.Forms.TextBox()
        Me.TextIDKoleksi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.nudJangkaWaktu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudJumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBPentung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCentang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBiayaSewa
        '
        Me.TextBiayaSewa.Location = New System.Drawing.Point(126, 176)
        Me.TextBiayaSewa.Name = "TextBiayaSewa"
        Me.TextBiayaSewa.Size = New System.Drawing.Size(241, 20)
        Me.TextBiayaSewa.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 26)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT KOLEKSI"
        '
        'cmbIDLokasi
        '
        Me.cmbIDLokasi.FormattingEnabled = True
        Me.cmbIDLokasi.Location = New System.Drawing.Point(126, 202)
        Me.cmbIDLokasi.Name = "cmbIDLokasi"
        Me.cmbIDLokasi.Size = New System.Drawing.Size(138, 21)
        Me.cmbIDLokasi.TabIndex = 21
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(165, 19)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 1
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'nudJangkaWaktu
        '
        Me.nudJangkaWaktu.Location = New System.Drawing.Point(126, 148)
        Me.nudJangkaWaktu.Name = "nudJangkaWaktu"
        Me.nudJangkaWaktu.Size = New System.Drawing.Size(138, 20)
        Me.nudJangkaWaktu.TabIndex = 19
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(76, 19)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsert.TabIndex = 0
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'nudJumlah
        '
        Me.nudJumlah.Location = New System.Drawing.Point(126, 120)
        Me.nudJumlah.Name = "nudJumlah"
        Me.nudJumlah.Size = New System.Drawing.Size(138, 20)
        Me.nudJumlah.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnClose)
        Me.GroupBox2.Controls.Add(Me.BtnReset)
        Me.GroupBox2.Controls.Add(Me.BtnInsert)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 51)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manajemen"
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(253, 19)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'cmbJenis
        '
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"- Pilih Jenis Buku -", "Action", "Komedi", "Thriller", "Horor", "Sci-Fiksi", "Drama"})
        Me.cmbJenis.Location = New System.Drawing.Point(126, 93)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(241, 21)
        Me.cmbJenis.TabIndex = 17
        Me.cmbJenis.Text = "- Pilih Jenis Buku -"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "ID Lokasi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Biaya sewa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbIDLokasi)
        Me.GroupBox1.Controls.Add(Me.TextBiayaSewa)
        Me.GroupBox1.Controls.Add(Me.nudJangkaWaktu)
        Me.GroupBox1.Controls.Add(Me.nudJumlah)
        Me.GroupBox1.Controls.Add(Me.cmbJenis)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LabelTidakTersedia)
        Me.GroupBox1.Controls.Add(Me.PBPentung)
        Me.GroupBox1.Controls.Add(Me.PBCentang)
        Me.GroupBox1.Controls.Add(Me.TextJudul)
        Me.GroupBox1.Controls.Add(Me.TextIDKoleksi)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 246)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Koleksi"
        '
        'LabelTidakTersedia
        '
        Me.LabelTidakTersedia.AutoSize = True
        Me.LabelTidakTersedia.Location = New System.Drawing.Point(299, 38)
        Me.LabelTidakTersedia.Name = "LabelTidakTersedia"
        Me.LabelTidakTersedia.Size = New System.Drawing.Size(70, 13)
        Me.LabelTidakTersedia.TabIndex = 13
        Me.LabelTidakTersedia.Text = "tidak tersedia"
        '
        'PBPentung
        '
        Me.PBPentung.ImageLocation = "D:\Materi Asdos\VB Lanjut Sore 2019\RentalC\pentung.png"
        Me.PBPentung.Location = New System.Drawing.Point(270, 35)
        Me.PBPentung.Name = "PBPentung"
        Me.PBPentung.Size = New System.Drawing.Size(23, 20)
        Me.PBPentung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPentung.TabIndex = 12
        Me.PBPentung.TabStop = False
        '
        'PBCentang
        '
        Me.PBCentang.ImageLocation = "D:\Materi Asdos\VB Lanjut Sore 2019\RentalC\centang.png"
        Me.PBCentang.Location = New System.Drawing.Point(270, 35)
        Me.PBCentang.Name = "PBCentang"
        Me.PBCentang.Size = New System.Drawing.Size(23, 20)
        Me.PBCentang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCentang.TabIndex = 11
        Me.PBCentang.TabStop = False
        '
        'TextJudul
        '
        Me.TextJudul.Location = New System.Drawing.Point(126, 64)
        Me.TextJudul.Name = "TextJudul"
        Me.TextJudul.Size = New System.Drawing.Size(241, 20)
        Me.TextJudul.TabIndex = 6
        '
        'TextIDKoleksi
        '
        Me.TextIDKoleksi.Location = New System.Drawing.Point(126, 35)
        Me.TextIDKoleksi.Name = "TextIDKoleksi"
        Me.TextIDKoleksi.Size = New System.Drawing.Size(138, 20)
        Me.TextIDKoleksi.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Jangka waktu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Jenis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Judul"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Koleksi"
        '
        'FormInputKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 362)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormInputKoleksi"
        Me.Text = "FormInputKoleksi"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudJangkaWaktu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudJumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBPentung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCentang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBiayaSewa As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbIDLokasi As System.Windows.Forms.ComboBox
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents nudJangkaWaktu As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents nudJumlah As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelTidakTersedia As System.Windows.Forms.Label
    Friend WithEvents PBPentung As System.Windows.Forms.PictureBox
    Friend WithEvents PBCentang As System.Windows.Forms.PictureBox
    Friend WithEvents TextJudul As System.Windows.Forms.TextBox
    Friend WithEvents TextIDKoleksi As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
