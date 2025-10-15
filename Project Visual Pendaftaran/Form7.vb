Imports MySql.Data.MySqlClient

Public Class Form7
    Dim Conn As MySqlConnection
    Dim Cmd As MySqlCommand

    Sub Koneksi()
        Dim str As String = "server=localhost;user id=root;password=;database=pendaftaran"
        Conn = New MySqlConnection(str)
        Conn.Open()
    End Sub

    Private Sub ButtonDaftar_Click(sender As Object, e As EventArgs) Handles ButtonDaftar.Click
        If TextBoxNama.Text = "" Or TextBoxEmail.Text = "" Or TextBoxPassword.Text = "" Then
            MessageBox.Show("Silakan isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Call Koneksi()
            Dim query As String = "INSERT INTO tb_siswa (nama, email, password) VALUES (@nama, @email, @password)"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nama", TextBoxNama.Text)
            Cmd.Parameters.AddWithValue("@email", TextBoxEmail.Text)
            Cmd.Parameters.AddWithValue("@password", TextBoxPassword.Text)

            Cmd.ExecuteNonQuery()
            MessageBox.Show("Pendaftaran berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Hide()
            Form1.Show() ' kembali ke login
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub
End Class
