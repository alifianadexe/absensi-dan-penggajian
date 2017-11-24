Public Class Login
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader



    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If Not Me.txt_name.Text = "" Then
            Dim sql As String = "SELECT * FROM tbl_karyawan WHERE id_karyawan = '" + Me.txt_name.Text + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            Dim tingkat As String = ""
            Dim id As String = ""
            If rd.HasRows Then

                tingkat = rd.Item("id_tingkat_karyawan")
                id = rd.Item("id_karyawan")

                If tingkat = "TKR001" Then
                    NavigationAdmin.Tag = id
                    NavigationAdmin.Show()
                Else
                    NavigationKaryawan.Tag = id
                    NavigationKaryawan.Show()
                End If
            End If

            rd.Close()

        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateConnString()
        conn.Open()

    End Sub
End Class