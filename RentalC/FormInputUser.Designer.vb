<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInputUser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PBPoto = New System.Windows.Forms.PictureBox()
        Me.LabelTidakTersedia = New System.Windows.Forms.Label()
        Me.PBPentung = New System.Windows.Forms.PictureBox()
        Me.PBCentang = New System.Windows.Forms.PictureBox()
        Me.BtnFoto = New System.Windows.Forms.Button()
        Me.CmbLevelUser = New System.Windows.Forms.ComboBox()
        Me.TextRePassword = New System.Windows.Forms.TextBox()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.TextNamaUser = New System.Windows.Forms.TextBox()
        Me.TextIDUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.ODBukaPoto = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBPoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBPentung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBCentang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 26)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT USER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PBPoto)
        Me.GroupBox1.Controls.Add(Me.LabelTidakTersedia)
        Me.GroupBox1.Controls.Add(Me.PBPentung)
        Me.GroupBox1.Controls.Add(Me.PBCentang)
        Me.GroupBox1.Controls.Add(Me.BtnFoto)
        Me.GroupBox1.Controls.Add(Me.CmbLevelUser)
        Me.GroupBox1.Controls.Add(Me.TextRePassword)
        Me.GroupBox1.Controls.Add(Me.TextPassword)
        Me.GroupBox1.Controls.Add(Me.TextNamaUser)
        Me.GroupBox1.Controls.Add(Me.TextIDUser)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 208)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data user"
        '
        'PBPoto
        '
        Me.PBPoto.Image = CType(resources.GetObject("PBPoto.Image"), System.Drawing.Image)
        Me.PBPoto.Location = New System.Drawing.Point(342, 35)
        Me.PBPoto.Name = "PBPoto"
        Me.PBPoto.Size = New System.Drawing.Size(114, 139)
        Me.PBPoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBPoto.TabIndex = 14
        Me.PBPoto.TabStop = False
        '
        'LabelTidakTersedia
        '
        Me.LabelTidakTersedia.AutoSize = True
        Me.LabelTidakTersedia.Location = New System.Drawing.Point(269, 35)
        Me.LabelTidakTersedia.Name = "LabelTidakTersedia"
        Me.LabelTidakTersedia.Size = New System.Drawing.Size(70, 13)
        Me.LabelTidakTersedia.TabIndex = 13
        Me.LabelTidakTersedia.Text = "tidak tersedia"
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
        'BtnFoto
        '
        Me.BtnFoto.Location = New System.Drawing.Point(261, 151)
        Me.BtnFoto.Name = "BtnFoto"
        Me.BtnFoto.Size = New System.Drawing.Size(75, 23)
        Me.BtnFoto.TabIndex = 10
        Me.BtnFoto.Text = "Pilih Foto"
        Me.BtnFoto.UseVisualStyleBackColor = True
        '
        'CmbLevelUser
        '
        Me.CmbLevelUser.FormattingEnabled = True
        Me.CmbLevelUser.Items.AddRange(New Object() {"admin", "staff", "umum"})
        Me.CmbLevelUser.Location = New System.Drawing.Point(133, 151)
        Me.CmbLevelUser.Name = "CmbLevelUser"
        Me.CmbLevelUser.Size = New System.Drawing.Size(121, 21)
        Me.CmbLevelUser.TabIndex = 9
        '
        'TextRePassword
        '
        Me.TextRePassword.Location = New System.Drawing.Point(133, 122)
        Me.TextRePassword.Name = "TextRePassword"
        Me.TextRePassword.Size = New System.Drawing.Size(203, 20)
        Me.TextRePassword.TabIndex = 8
        '
        'TextPassword
        '
        Me.TextPassword.Location = New System.Drawing.Point(133, 93)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(203, 20)
        Me.TextPassword.TabIndex = 7
        '
        'TextNamaUser
        '
        Me.TextNamaUser.Location = New System.Drawing.Point(133, 64)
        Me.TextNamaUser.Name = "TextNamaUser"
        Me.TextNamaUser.Size = New System.Drawing.Size(203, 20)
        Me.TextNamaUser.TabIndex = 6
        '
        'TextIDUser
        '
        Me.TextIDUser.Location = New System.Drawing.Point(133, 35)
        Me.TextIDUser.Name = "TextIDUser"
        Me.TextIDUser.Size = New System.Drawing.Size(100, 20)
        Me.TextIDUser.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Level user"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Re-Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID User"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnClose)
        Me.GroupBox2.Controls.Add(Me.BtnReset)
        Me.GroupBox2.Controls.Add(Me.BtnInsert)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(462, 51)
        Me.GroupBox2.TabIndex = 3
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
        'ODBukaPoto
        '
        Me.ODBukaPoto.FileName = "OpenFileDialog1"
        '
        'FormInputUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 321)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormInputUser"
        Me.Text = "Form Tambah User Baru"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBPoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBPentung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBCentang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PBPoto As System.Windows.Forms.PictureBox
    Friend WithEvents LabelTidakTersedia As System.Windows.Forms.Label
    Friend WithEvents PBPentung As System.Windows.Forms.PictureBox
    Friend WithEvents PBCentang As System.Windows.Forms.PictureBox
    Friend WithEvents BtnFoto As System.Windows.Forms.Button
    Friend WithEvents CmbLevelUser As System.Windows.Forms.ComboBox
    Friend WithEvents TextRePassword As System.Windows.Forms.TextBox
    Friend WithEvents TextPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextNamaUser As System.Windows.Forms.TextBox
    Friend WithEvents TextIDUser As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnInsert As System.Windows.Forms.Button
    Friend WithEvents ODBukaPoto As System.Windows.Forms.OpenFileDialog

End Class
