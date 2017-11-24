Public Class ManagementKaryawan
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub ManagementKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

        refreshData()

    End Sub

    Private Sub refreshData()

        Dim sql As String = "SELECT id_karyawan,  nama,nama_tingkat as tingkat  FROM tbl_karyawan INNER JOIN tbl_tingkat_karyawan ON tbl_karyawan.id_tingkat_karyawan = tbl_tingkat_karyawan.id_tingkat_karyawan"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable

        adapter.Fill(dt)

        data_grid.DataSource = dt

        Dim sql_com As String = "SELECT * FROM tbl_tingkat_karyawan"
        Dim adapter_com As New SqlClient.SqlDataAdapter(sql_com, conn)
        Dim dt_com As New DataTable
        adapter_com.Fill(dt_com)

        Me.txt_tingkat.DataSource = dt_com
        Me.txt_tingkat.DisplayMember = "nama_tingkat"
        Me.txt_tingkat.ValueMember = "id_tingkat_karyawan"

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub is_enabled(ByVal bool As Boolean)
        Me.txt_alamat.Enabled = bool
        Me.txt_nama.Enabled = bool
        Me.txt_no_telp.Enabled = bool
        Me.txt_tingkat.Enabled = bool
        Me.rdo_jenis.Enabled = bool
        Me.rdo_jenis_2.Enabled = bool

    End Sub
    Private Sub is_clear()
        Me.txt_alamat.Clear()
        Me.txt_nama.Clear()
        Me.txt_no_telp.Clear()
        Me.txt_id.Clear()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        is_clear()
        Me.txt_id.Text = generateID("id_karyawan", conn)
        is_enabled(True)
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If Me.btn_insert.Text = "Update" Then
            If checkEmptyText(Me.txt_alamat, Me.txt_id, Me.txt_nama, Me.txt_no_telp, Me.txt_tingkat) Then
                Dim sql As String = "UPDATE tbl_karyawan SET id_tingkat_karyawan = @v2, nama = @v3, alamat = @v4, jenis_kelamin = @v5, no_telp = @v6 , picture = @v7 WHERE id_karyawan = @v1"
                Dim jenis As String = ""
                Using cmnd As New SqlClient.SqlCommand(sql, conn)
                    cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                    cmnd.Parameters.AddWithValue("@v2", Me.txt_tingkat.SelectedValue)
                    cmnd.Parameters.AddWithValue("@v3", Me.txt_nama.Text)
                    cmnd.Parameters.AddWithValue("@v4", Me.txt_alamat.Text)

                    If Me.rdo_jenis.Checked Then
                        jenis = "Laki - Laki"
                    Else
                        jenis = "Perempuan"
                    End If

                    cmnd.Parameters.AddWithValue("@v5", jenis)
                    cmnd.Parameters.AddWithValue("@v6", Me.txt_no_telp.Text)

                    Dim ms As New System.IO.MemoryStream
                    PictureBox1.Image.Save(ms, Imaging.ImageFormat.Png)
                    Dim arr_image() As Byte = ms.GetBuffer

                    cmnd.Parameters.AddWithValue("@v7", arr_image)


                    If MessageBox.Show("Update Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        cmnd.ExecuteNonQuery()
                        MessageBox.Show("Data Berhasil Diupdate", "Hapus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                End Using
            End If

        ElseIf Me.btn_insert.Text = "Insert" Then
            If checkEmptyText(Me.txt_alamat, Me.txt_id, Me.txt_nama, Me.txt_no_telp, Me.txt_tingkat) Then
                Dim sql As String = "INSERT INTO tbl_karyawan (id_karyawan, id_tingkat_karyawan, nama, alamat, jenis_kelamin, no_telp, picture) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7)"
                Dim jenis As String = ""
                Using cmnd As New SqlClient.SqlCommand(sql, conn)
                    cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                    cmnd.Parameters.AddWithValue("@v2", Me.txt_tingkat.SelectedValue)
                    cmnd.Parameters.AddWithValue("@v3", Me.txt_nama.Text)
                    cmnd.Parameters.AddWithValue("@v4", Me.txt_alamat.Text)

                    If Me.rdo_jenis.Checked Then
                        jenis = "Laki - Laki"
                    Else
                        jenis = "Perempuan"
                    End If

                    cmnd.Parameters.AddWithValue("@v5", jenis)
                    cmnd.Parameters.AddWithValue("@v6", Me.txt_no_telp.Text)

                    Dim ms As New System.IO.MemoryStream
                    PictureBox1.Image.Save(ms, Imaging.ImageFormat.Png)
                    Dim arr_image() As Byte = ms.GetBuffer

                    cmnd.Parameters.AddWithValue("@v7", arr_image)


                    If MessageBox.Show("Insert Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        cmnd.ExecuteNonQuery()
                        MessageBox.Show("Data Berhasil Diinsert", "Hapus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                End Using
            End If
        End If

        is_enabled(False)
        is_clear()
        Me.btn_insert.Text = "Insert"
        refreshData()

    End Sub

    Private Sub btn_edt_Click(sender As Object, e As EventArgs) Handles btn_edt.Click

        is_enabled(True)
        Me.btn_insert.Text = "Update"

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Me.txt_id.Text = "" Then
            Dim sql As String = "DELETE FROM tbl_anggota WHERE id_karyawan = '" + Me.txt_id.Text + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)

            If MessageBox.Show("Hapus Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cmnd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil Dihapus", "Hapus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            Me.txt_id.Text = data_grid.Rows(e.RowIndex).Cells(0).Value
            Dim sql As String = "SELECT * FROM tbl_karyawan WHERE id_karyawan = '" + Me.txt_id.Text + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                Me.txt_alamat.Text = rd.Item("alamat")
                Me.txt_id.Text = rd.Item("id_karyawan")
                Me.txt_nama.Text = rd.Item("nama")
                Me.txt_no_telp.Text = rd.Item("no_telp")
                Me.txt_tingkat.SelectedValue = rd.Item("id_tingkat_karyawan")


                'Dim pict() As Byte = rd.Item("picture")
                'Dim arr_image() As Byte = pict
                'Dim ms As New System.IO.MemoryStream(arr_image)
                'PictureBox1.Image = Image.FromStream(ms)

            End If

            rd.Close()
        End If
    End Sub
End Class