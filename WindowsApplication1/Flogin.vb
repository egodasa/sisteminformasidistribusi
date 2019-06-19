Public Class Flogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim data_pengguna As DataTable = FetchData("select * from tbl_pengguna where username = '" & Tusername.Text & "' AND password=md5('" & Tpassword.Text & "')")
        If data_pengguna.Rows.Count = 1 Then
            username = Tusername.Text
            jenis_pengguna = data_pengguna.Rows(0).Item("tipe")
            Tusername.Clear()
            Tpassword.Clear()
            If data_pengguna.Rows(0).Item("tipe") = "Admin" Then
                main_form = Fmenu
            ElseIf data_pengguna.Rows(0).Item("tipe") = "Karyawan" Then
                main_form = Fpengiriman_daftar
            Else
                main_form = Flaporan
            End If
            main_form.Show()
            Me.Hide()
        Else
            MessageBox.Show("Username atau password salah!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Tusername.Clear()
            Tpassword.Clear()
            Tusername.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Fpengaturan.ShowDialog()
    End Sub

    Private Sub Flogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
