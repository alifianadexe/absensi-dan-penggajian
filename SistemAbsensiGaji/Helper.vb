Module Helper
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Public Function generateConnString()
        Dim connString As String = "Data Source=localhost,1433;Network Library=DBMSSOCN;Initial Catalog=db_penggajian;user id=alifianadexe;password=adexe123"
        conn.ConnectionString = connString
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            conn.Close()
        End If
        Return connString
    End Function

    Public Function checkEmptyText(ParamArray ByVal obj() As Object)
        Dim bool As Boolean = True
        For i As Integer = 0 To UBound(obj)
            If obj(i).Text = "" Then
                MessageBox.Show("Isi Semua Kolom Yang Kosong", "Isi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                bool = False
            End If
        Next

        Return bool
    End Function

    Public Function generateID(ByVal what As String, ByVal conn As SqlClient.SqlConnection)
        Dim id As String = ""
        Select Case what
            Case "id_karyawan"
                Dim sql As String = "SELECT " + what + " FROM tbl_karyawan ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "KRY001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "KRY00" + id
                    ElseIf Len(id) = 2 Then
                        id = "KRY0" + id
                    ElseIf Len(id) = 3 Then
                        id = "KRY" + id
                    End If
                End If
                rd.Close()
            Case "id_absen"
                Dim sql As String = "SELECT " + what + " FROM tbl_absen ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "2017168001"
                Else
                    id = Val(rd.Item(0)) + 1
                End If

                rd.Close()
            Case "id_gaji"
                Dim sql As String = "SELECT " + what + " FROM tbl_gaji ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "192001"
                Else
                    id = Val(rd.Item(0)) + 1
                End If
                rd.Close()

            Case "id_potongan"
                Dim sql As String = "SELECT " + what + " FROM tbl_potongan ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "POT001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "POT00" + id
                    ElseIf Len(id) = 2 Then
                        id = "POT0" + id
                    ElseIf Len(id) = 3 Then
                        id = "POT" + id
                    End If
                End If
                rd.Close()
            Case "id_lembur"
                Dim sql As String = "SELECT " + what + " FROM tbl_lembur ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "2203001"
                Else
                    id = Val(rd.Item(0)) + 1
                End If
                rd.Close()
            Case "id_tingkat_karyawan"
                Dim sql As String = "SELECT " + what + " FROM tbl_tingkat_karyawan ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "TKR001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "TKR00" + id
                    ElseIf Len(id) = 2 Then
                        id = "TKR0" + id
                    ElseIf Len(id) = 3 Then
                        id = "TKR" + id
                    End If
                End If
                rd.Close()
            Case "id_main_system"
                Dim sql As String = "SELECT " + what + " FROM tbl_main_system ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "MNSO01"
                Else
                    id = Val(Mid(rd.Item(0), 5, 2)) + 1
                    If Len(id) = 1 Then
                        id = "MNSO0" + id
                    ElseIf Len(id) = 2 Then
                        id = "MNSO" + id
                    End If
                End If
                rd.Close()

        End Select

        Return id

    End Function


    Public Function is_check(ByVal sql As String, ByVal conn As SqlClient.SqlConnection) As Boolean
        Dim bool As Boolean = True
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            bool = False
        End If
        rd.Close()
        Return bool
    End Function


End Module
