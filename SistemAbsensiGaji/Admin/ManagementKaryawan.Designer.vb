<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementKaryawan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.data_grid = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdo_jenis = New System.Windows.Forms.RadioButton()
        Me.rdo_jenis_2 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_tingkat = New System.Windows.Forms.ComboBox()
        Me.txt_no_telp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_edt = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_no_telp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_tingkat)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rdo_jenis_2)
        Me.GroupBox1.Controls.Add(Me.rdo_jenis)
        Me.GroupBox1.Controls.Add(Me.txt_alamat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Diri"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CadetBlue
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(-10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(729, 65)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Management User"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'data_grid
        '
        Me.data_grid.AllowUserToAddRows = False
        Me.data_grid.AllowUserToDeleteRows = False
        Me.data_grid.AllowUserToOrderColumns = True
        Me.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid.Location = New System.Drawing.Point(12, 372)
        Me.data_grid.Name = "data_grid"
        Me.data_grid.ReadOnly = True
        Me.data_grid.Size = New System.Drawing.Size(689, 206)
        Me.data_grid.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SistemAbsensiGaji.My.Resources.Resources.Anonymous_User
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(389, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 189)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Foto Profil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Karyawan"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(95, 28)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(74, 20)
        Me.txt_id.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tingkat"
        '
        'txt_nama
        '
        Me.txt_nama.Enabled = False
        Me.txt_nama.Location = New System.Drawing.Point(95, 83)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(227, 20)
        Me.txt_nama.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nama"
        '
        'txt_alamat
        '
        Me.txt_alamat.Enabled = False
        Me.txt_alamat.Location = New System.Drawing.Point(95, 109)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(227, 48)
        Me.txt_alamat.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Alamat"
        '
        'rdo_jenis
        '
        Me.rdo_jenis.AutoSize = True
        Me.rdo_jenis.Enabled = False
        Me.rdo_jenis.Location = New System.Drawing.Point(96, 163)
        Me.rdo_jenis.Name = "rdo_jenis"
        Me.rdo_jenis.Size = New System.Drawing.Size(74, 17)
        Me.rdo_jenis.TabIndex = 8
        Me.rdo_jenis.TabStop = True
        Me.rdo_jenis.Text = "Laki - Laki"
        Me.rdo_jenis.UseVisualStyleBackColor = True
        '
        'rdo_jenis_2
        '
        Me.rdo_jenis_2.AutoSize = True
        Me.rdo_jenis_2.Enabled = False
        Me.rdo_jenis_2.Location = New System.Drawing.Point(176, 163)
        Me.rdo_jenis_2.Name = "rdo_jenis_2"
        Me.rdo_jenis_2.Size = New System.Drawing.Size(79, 17)
        Me.rdo_jenis_2.TabIndex = 9
        Me.rdo_jenis_2.TabStop = True
        Me.rdo_jenis_2.Text = "Perempuan"
        Me.rdo_jenis_2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Jenis Kelamin"
        '
        'txt_tingkat
        '
        Me.txt_tingkat.Enabled = False
        Me.txt_tingkat.FormattingEnabled = True
        Me.txt_tingkat.Location = New System.Drawing.Point(95, 54)
        Me.txt_tingkat.Name = "txt_tingkat"
        Me.txt_tingkat.Size = New System.Drawing.Size(121, 21)
        Me.txt_tingkat.TabIndex = 11
        '
        'txt_no_telp
        '
        Me.txt_no_telp.Enabled = False
        Me.txt_no_telp.Location = New System.Drawing.Point(95, 186)
        Me.txt_no_telp.Name = "txt_no_telp"
        Me.txt_no_telp.Size = New System.Drawing.Size(169, 20)
        Me.txt_no_telp.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "No Telp"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(532, 346)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(169, 20)
        Me.txt_search.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(481, 349)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Search"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(585, 122)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(116, 44)
        Me.btn_add.TabIndex = 16
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(585, 172)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(116, 44)
        Me.btn_insert.TabIndex = 17
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_edt
        '
        Me.btn_edt.Location = New System.Drawing.Point(585, 222)
        Me.btn_edt.Name = "btn_edt"
        Me.btn_edt.Size = New System.Drawing.Size(116, 44)
        Me.btn_edt.TabIndex = 18
        Me.btn_edt.Text = "Edit"
        Me.btn_edt.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(585, 272)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(116, 43)
        Me.btn_delete.TabIndex = 19
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'ManagementKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 590)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edt)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.data_grid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManagementKaryawan"
        Me.Text = "ManagementKaryawan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents data_grid As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rdo_jenis_2 As RadioButton
    Friend WithEvents rdo_jenis As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_tingkat As ComboBox
    Friend WithEvents txt_no_telp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_edt As Button
    Friend WithEvents btn_delete As Button
End Class
