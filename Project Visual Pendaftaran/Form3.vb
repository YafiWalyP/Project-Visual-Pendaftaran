Public Class Form3
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?",
                                                "Konfirmasi Logout",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class