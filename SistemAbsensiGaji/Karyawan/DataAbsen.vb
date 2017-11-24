Public Class DataAbsen

    Private Sub DataAbsen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hari As Integer = 0

        Dim Start As New DateTime(2017, 11, 1)
        Dim Final As New DateTime(2017, 11, 30)

        Dim angka As Integer = 1


        Dim currD As TimeSpan = Final - Start

        Dim startN As Integer = Start.Day
        Dim tambah As Integer = 0

        For i As Integer = 0 To 7
            Me.DataGridView1.Rows.Add()
            For j As Integer = 0 To 5
                If Start.Month Mod 2 = 1 Then
                    If Start.Day <= 31 Then
                        Me.DataGridView1.Rows(i).Cells(j).Value = Start.ToShortDateString
                        tambah += 1
                        Start.AddDays(1)
                    ElseIf Start.Day <= 30 Then
                        Me.DataGridView1.Rows(i).Cells(j).Value = Start.ToShortDateString
                        tambah += 1
                        Start.AddDays(1)
                    End If
                End If

            Next
        Next

        MessageBox.Show(Start.AddDays(2))







    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class