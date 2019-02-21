<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputLokasi
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
        Me.LabelTidakTersedia = New System.Windows.Forms.Label()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PBPentung = New System.Windows.Forms.PictureBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.PBCentang = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextNamaLokasi = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextTempat = New System.Windows.Forms.TextBox()
        Me.TextIDLokasi = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PBPentung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCentang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTidakTersedia
        '
        Me.LabelTidakTersedia.AutoSize = True
        Me.LabelTidakTersedia.Location = New System.Drawing.Point(269, 38)
        Me.LabelTidakTersedia.Name = "LabelTidakTersedia"
        Me.LabelTidakTersedia.Size = New System.Drawing.Size(70, 13)
        Me.LabelTidakTersedia.TabIndex = 13
        Me.LabelTidakTersedia.Text = "tidak tersedia"
        '
        'BtnInsert
        '
        Me.BtnInsert.Location = New System.Drawing.Point(78, 19)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsert.TabIndex = 0
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(243, 19)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'PBPentung
        '
        Me.PBPentung.ImageLocation = "D:\Materi Asdos\VB Lanjut Sore 2019\RentalC\pentung.png"
        Me.PBPentung.Location = New System.Drawing.Point(240, 35)
        Me.PBPentung.Name = "PBPentung"
        Me.PBPentung.Size = New System.Drawing.Size(23, 20)
        Me.PBPentung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPentung.TabIndex = 12
        Me.PBPentung.TabStop = False
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(161, 19)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 1
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'PBCentang
        '
        Me.PBCentang.ImageLocation = "D:\Materi Asdos\VB Lanjut Sore 2019\RentalC\centang.png"
        Me.PBCentang.Location = New System.Drawing.Point(240, 35)
        Me.PBCentang.Name = "PBCentang"
        Me.PBCentang.Size = New System.Drawing.Size(23, 20)
        Me.PBCentang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCentang.TabIndex = 11
        Me.PBCentang.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(23, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 26)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(125, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT LOKASI"
        '
        'TextNamaLokasi
        '
        Me.TextNamaLokasi.Location = New System.Drawing.Point(133, 64)
        Me.TextNamaLokasi.Name = "TextNamaLokasi"
        Me.TextNamaLokasi.Size = New System.Drawing.Size(203, 20)
        Me.TextNamaLokasi.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnClose)
        Me.GroupBox2.Controls.Add(Me.BtnReset)
        Me.GroupBox2.Controls.Add(Me.BtnInsert)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 47)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manajemen"
        '
        'TextTempat
        '
        Me.TextTempat.Location = New System.Drawing.Point(133, 93)
        Me.TextTempat.Name = "TextTempat"
        Me.TextTempat.Size = New System.Drawing.Size(203, 20)
        Me.TextTempat.TabIndex = 7
        '
        'TextIDLokasi
        '
        Me.TextIDLokasi.Location = New System.Drawing.Point(133, 35)
        Me.TextIDLokasi.Name = "TextIDLokasi"
        Me.TextIDLokasi.Size = New System.Drawing.Size(100, 20)
        Me.TextIDLokasi.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelTidakTersedia)
        Me.GroupBox1.Controls.Add(Me.PBPentung)
        Me.GroupBox1.Controls.Add(Me.PBCentang)
        Me.GroupBox1.Controls.Add(Me.TextTempat)
        Me.GroupBox1.Controls.Add(Me.TextNamaLokasi)
        Me.GroupBox1.Controls.Add(Me.TextIDLokasi)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 142)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Lokasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tempat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Lokasi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Lokasi"
        '
        'FormInputLokasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 290)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormInputLokasi"
        Me.Text = "FormInputLokasi"
        CType(Me.PBPentung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCentang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelTidakTersedia As System.Windows.Forms.Label
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents PBPentung As System.Windows.Forms.PictureBox
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents PBCentang As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextNamaLokasi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextTempat As System.Windows.Forms.TextBox
    Friend WithEvents TextIDLokasi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
