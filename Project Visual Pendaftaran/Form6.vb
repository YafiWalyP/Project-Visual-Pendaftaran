Public Class Form6

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim columnName As String = DataGridView1.Columns(e.ColumnIndex).Name

            If columnName = "Upload" Then
                Dim namaDok As String = DataGridView1.Rows(e.RowIndex).Cells("Dokumen").Value

                Dim ofd As New OpenFileDialog()
                ofd.Filter = "PDF Files|*.pdf"
                ofd.Title = "Upload " & namaDok

                If ofd.ShowDialog() = DialogResult.OK Then
                    ' Ubah kolom status menjadi Sudah (nama file)
                    DataGridView1.Rows(e.RowIndex).Cells("Status").Value = "Sudah (" & IO.Path.GetFileName(ofd.FileName) & ")"
                End If

            ElseIf columnName = "Hapus" Then
                DataGridView1.Rows(e.RowIndex).Cells("Status").Value = "Belum Upload"
                MessageBox.Show("File telah dihapus dari dokumen: " & DataGridView1.Rows(e.RowIndex).Cells("Dokumen").Value)
            End If
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        DataGridView1.Rows.Clear()

        Dim jalur As String = ComboBox1.SelectedItem.ToString()

        DataGridView1.Rows.Add("KK", "Wajib")
        DataGridView1.Rows.Add("SKL", "Wajib")
        DataGridView1.Rows.Add("AKTE", "Wajib")

        If jalur = "Jalur Prestasi" Then
            DataGridView1.Rows.Add("RAPORT", "Wajib")
        ElseIf jalur = "Jalur Non Tes" Then
            DataGridView1.Rows.Add("RAPORT", "Wajib")
            DataGridView1.Rows.Add("SERTIFIKAT", "Wajib")
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Dokumen", "Nama Dokumen")
        DataGridView1.Columns.Add("Status", "Status")

        Dim btnUpload As New DataGridViewButtonColumn()
        btnUpload.HeaderText = "Upload"
        btnUpload.Name = "Upload"
        btnUpload.Text = "Upload"
        btnUpload.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(btnUpload)

        Dim btnHapus As New DataGridViewButtonColumn()
        btnHapus.HeaderText = "Hapus"
        btnHapus.Name = "Hapus"
        btnHapus.Text = "Hapus"
        btnHapus.UseColumnTextForButtonValue = True
        DataGridView1.Columns.Add(btnHapus)

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?",
                                                "Konfirmasi Logout",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Form1.Show()  'tampilkan login lagi
            Me.Close()    'tutup form sekarang
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class