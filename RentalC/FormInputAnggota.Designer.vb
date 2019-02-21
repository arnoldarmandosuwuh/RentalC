<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputAnggota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInputAnggota))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFoto = New System.Windows.Forms.Button()
        Me.TextNoHP = New System.Windows.Forms.TextBox()
        Me.rtbAlamat = New System.Windows.Forms.RichTextBox()
        Me.PBPoto = New System.Windows.Forms.PictureBox()
        Me.LabelTidakTersedia = New System.Windows.Forms.Label()
        Me.PBPentung = New System.Windows.Forms.PictureBox()
        Me.PBCentang = New System.Windows.Forms.PictureBox()
        Me.TextNamaAnggota = New System.Windows.Forms.TextBox()
        Me.TextIDAnggota = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ODBukaPoto = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBPoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPentung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCentang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnClose)
        Me.GroupBox2.Controls.Add(Me.BtnReset)
        Me.GroupBox2.Controls.Add(Me.BtnInsert)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 47)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manajemen"
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(329, 19)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(205, 19)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 1
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(87, 19)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsert.TabIndex = 0
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnFoto)
        Me.GroupBox1.Controls.Add(Me.TextNoHP)
        Me.GroupBox1.Controls.Add(Me.rtbAlamat)
        Me.GroupBox1.Controls.Add(Me.PBPoto)
        Me.GroupBox1.Controls.Add(Me.LabelTidakTersedia)
        Me.GroupBox1.Controls.Add(Me.PBPentung)
        Me.GroupBox1.Controls.Add(Me.PBCentang)
        Me.GroupBox1.Controls.Add(Me.TextNamaAnggota)
        Me.GroupBox1.Controls.Add(Me.TextIDAnggota)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 189)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Anggota"
        '
        'BtnFoto
        '
        Me.BtnFoto.Location = New System.Drawing.Point(266, 148)
        Me.BtnFoto.Name = "BtnFoto"
        Me.BtnFoto.Size = New System.Drawing.Size(75, 23)
        Me.BtnFoto.TabIndex = 3
        Me.BtnFoto.Text = "Pilih Foto"
        Me.BtnFoto.UseVisualStyleBackColor = True
        '
        'TextNoHP
        '
        Me.TextNoHP.Location = New System.Drawing.Point(133, 150)
        Me.TextNoHP.Name = "TextNoHP"
        Me.TextNoHP.Size = New System.Drawing.Size(127, 20)
        Me.TextNoHP.TabIndex = 16
        '
        'rtbAlamat
        '
        Me.rtbAlamat.Location = New System.Drawing.Point(133, 90)
        Me.rtbAlamat.Name = "rtbAlamat"
        Me.rtbAlamat.Size = New System.Drawing.Size(208, 55)
        Me.rtbAlamat.TabIndex = 15
        Me.rtbAlamat.Text = ""
        '
        'PBPoto
        '
        Me.PBPoto.Image = CType(resources.GetObject("PBPoto.Image"), System.Drawing.Image)
        Me.PBPoto.Location = New System.Drawing.Point(349, 35)
        Me.PBPoto.Name = "PBPoto"
        Me.PBPoto.Size = New System.Drawing.Size(110, 136)
        Me.PBPoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPoto.TabIndex = 14
        Me.PBPoto.TabStop = False
        '
        'LabelTidakTersedia
        '
        Me.LabelTidakTersedia.AutoSize = True
        Me.LabelTidakTersedia.Location = New System.Drawing.Point(266, 38)
        Me.LabelTidakTersedia.Name = "LabelTidakTersedia"
        Me.LabelTidakTersedia.Size = New System.Drawing.Size(70, 13)
        Me.LabelTidakTersedia.TabIndex = 13
        Me.LabelTidakTersedia.Text = "tidak tersedia"
        '
        'PBPentung
        '
        Me.PBPentung.ImageLocation = "D:\Materi Asdos\VB Lanjut Sore 2019\RentalC\pentung.png"
        Me.PBPentung.Location = New System.Drawing.Point(237, 35)
        Me.PBPentung.Name = "PBPentung"
        Me.PBPentung.Size = New System.Drawing.Size(23, 20)
        Me.PBPentung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPentung.TabIndex = 12
        Me.PBPentung.TabStop = False
        '
        'PBCentang
        '
        Me.PBCentang.ImageLocation = "D:\Materi Asdos\VB Lanjut Sore 2019\RentalC\centang.png"
        Me.PBCentang.Location = New System.Drawing.Point(237, 35)
        Me.PBCentang.Name = "PBCentang"
        Me.PBCentang.Size = New System.Drawing.Size(23, 20)
        Me.PBCentang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCentang.TabIndex = 11
        Me.PBCentang.TabStop = False
        '
        'TextNamaAnggota
        '
        Me.TextNamaAnggota.Location = New System.Drawing.Point(133, 64)
        Me.TextNamaAnggota.Name = "TextNamaAnggota"
        Me.TextNamaAnggota.Size = New System.Drawing.Size(208, 20)
        Me.TextNamaAnggota.TabIndex = 6
        '
        'TextIDAnggota
        '
        Me.TextIDAnggota.Location = New System.Drawing.Point(133, 35)
        Me.TextIDAnggota.Name = "TextIDAnggota"
        Me.TextIDAnggota.Size = New System.Drawing.Size(98, 20)
        Me.TextIDAnggota.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "No HP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Anggota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Anggota"
        '
        'ODBukaPoto
        '
        Me.ODBukaPoto.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 26)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT ANGGOTA"
        '
        'FormInputAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 299)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormInputAnggota"
        Me.Text = "FormInputAnggota"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBPoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPentung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCentang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnFoto As System.Windows.Forms.Button
    Friend WithEvents TextNoHP As System.Windows.Forms.TextBox
    Friend WithEvents rtbAlamat As System.Windows.Forms.RichTextBox
    Friend WithEvents PBPoto As System.Windows.Forms.PictureBox
    Friend WithEvents LabelTidakTersedia As System.Windows.Forms.Label
    Friend WithEvents PBPentung As System.Windows.Forms.PictureBox
    Friend WithEvents PBCentang As System.Windows.Forms.PictureBox
    Friend WithEvents TextNamaAnggota As System.Windows.Forms.TextBox
    Friend WithEvents TextIDAnggota As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ODBukaPoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
