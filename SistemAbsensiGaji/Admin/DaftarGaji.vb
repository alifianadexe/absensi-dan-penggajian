Public Class DaftarGaji
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Private Sub DaftarGaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT * FROM tbl_tingkat_karyawan"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        cmb_box.DataSource = dt
        cmb_box.DisplayMember = "nama_tingkat"
        cmb_box.ValueMember = "id_nama_tingkat"

    End Sub

    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        If Me.insert.Text = "Update" Then
            If checkEmptyText(Me.txt_id, Me.txt_jumlah, Me.txt_tingkat) Then
                Dim sql As String = "UPDATE tbl_tingkat_karyawan SET tingkat_karyawan = @v1 , jumlah_gaji = @v2 WHERE id_tingkat_karyawan  = '" + Me.txt_id.Text + "'"

                Dim jenis As String = ""
                Using cmnd As New SqlClient.SqlCommand(sql, conn)

                    cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                    cmnd.Parameters.AddWithValue("@v2", Me.txt_tingkat.Text)
                    cmnd.Parameters.AddWithValue("@v3", Me.txt_jumlah.Text)

                    If MessageBox.Show("Update Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        cmnd.ExecuteNonQuery()
                        MessageBox.Show("Data Berhasil Diupdate", "Hapus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                End Using
            End If

        ElseIf Me.insert.Text = "Insert" Then
            If checkEmptyText(Me.txt_id, Me.txt_jumlah, Me.txt_tingkat) Then
                Dim sql As String = "INSERT INTO tbl_tingkat_karyawan (id_tingka_karyawan, tingkat_karyawan, jumlah_gaji) VALUES (@v1, @v2, @v3)"
                Dim jenis As String = ""
                Using cmnd As New SqlClient.SqlCommand(sql, conn)
                    cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                    cmnd.Parameters.AddWithValue("@v2", Me.txt_tingkat.Text)
                    cmnd.Parameters.AddWithValue("@v3", Me.txt_jumlah.Text)

                    If MessageBox.Show("Insert Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        cmnd.ExecuteNonQuery()
                        MessageBox.Show("Data Berhasil Diinsert", "Hapus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    End If
                End Using
            End If
        End If

        is_enabled(False)
        is_clear()
        Me.insert.Text = "Insert"
        refreshData()
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        is_enabled(True)
        Me.insert.Text = "Update"

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If Not Me.txt_id.Text = "" Then
            Dim sql As String = "DELETE tbl_tingkat_karyawan WHERE id_tingkat_karyawan = @v1"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
            cmnd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Diinsert", "Hapus", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub add_ad_Click(sender As Object, e As EventArgs) Handles add.Click
        is_clear()
        is_enabled(True)
        Me.txt_id.Text = generateID("id_tingkat_karyawan", conn)
    End Sub

    Private Sub is_enabled(ByVal bool As Boolean)
        Me.txt_jumlah.Enabled = bool
        Me.txt_tingkat.Enabled = bool

    End Sub

    Private Sub is_clear()
        Me.txt_id.Clear()
        Me.txt_jumlah.Clear()
        Me.txt_tingkat.Clear()
    End Sub

End Class