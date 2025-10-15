Imports MySql.Data.MySqlClient

Public Class Form1
    Dim Conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Dim Rd As MySqlDataReader

    ' ==== KONEKSI KE DATABASE ====
    Sub Koneksi()
        Dim str As String = "server=localhost;user id=root;password=;database=pendaftaran"
        Conn = New MySqlConnection(str)
        Conn.Open()
    End Sub

    ' ==== LOGIN BUTTON ====
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If TextBoxEmail.Text = "" Or TextBoxPassword.Text = "" Then
            MessageBox.Show("Silakan isi email dan password terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Call Koneksi()
            Dim query As String = "SELECT * FROM tb_siswa WHERE email=@e AND password=@p"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@e", TextBoxEmail.Text)
            Cmd.Parameters.AddWithValue("@p", TextBoxPassword.Text)

            Rd = Cmd.ExecuteReader()

            If Rd.HasRows Then
                Rd.Read()
                MessageBox.Show("Login berhasil! Selamat datang, " & Rd("nama") & "!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Email atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Conn.Close()

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    ' ==== LINK KE FORM PENDAFTARAN ====
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form7.Show()
        Me.Hide()
    End Sub
End Class
