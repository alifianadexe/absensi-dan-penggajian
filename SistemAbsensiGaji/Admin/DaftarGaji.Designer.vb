<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DaftarGaji
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.add = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.cmb_box = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_tingkat = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_tingkat)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 185)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Gaji"
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(47, 277)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(120, 54)
        Me.add.TabIndex = 1
        Me.add.Text = "Add"
        Me.add.UseVisualStyleBackColor = True
        '
        'insert
        '
        Me.insert.Location = New System.Drawing.Point(173, 277)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(120, 54)
        Me.insert.TabIndex = 2
        Me.insert.Text = "Insert"
        Me.insert.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(47, 337)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(120, 54)
        Me.Delete.TabIndex = 3
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(173, 337)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(120, 54)
        Me.edit.TabIndex = 4
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'cmb_box
        '
        Me.cmb_box.FormattingEnabled = True
        Me.cmb_box.Location = New System.Drawing.Point(12, 28)
        Me.cmb_box.Name = "cmb_box"
        Me.cmb_box.Size = New System.Drawing.Size(166, 21)
        Me.cmb_box.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmb_box)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(194, 68)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Jenis Karyawan"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_jumlah)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 86)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 83)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Gaji"
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Location = New System.Drawing.Point(59, 48)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(172, 20)
        Me.txt_jumlah.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rp. -"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(118, 34)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(98, 20)
        Me.txt_id.TabIndex = 2
        '
        'txt_tingkat
        '
        Me.txt_tingkat.Location = New System.Drawing.Point(118, 60)
        Me.txt_tingkat.Name = "txt_tingkat"
        Me.txt_tingkat.Size = New System.Drawing.Size(172, 20)
        Me.txt_tingkat.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tingkat Karyawan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jumlah"
        '
        'DaftarGaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 403)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DaftarGaji"
        Me.Text = "DaftarGaji"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents add As Button
    Friend WithEvents insert As Button
    Friend WithEvents Delete As Button
    Friend WithEvents edit As Button
    Friend WithEvents cmb_box As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_tingkat As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
