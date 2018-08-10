Public Class Flaporan
    Private Sub Bexit_Click(sender As Object, e As EventArgs) Handles Bexit.Click

        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If jenis_pengguna = "Admin" Then
                main_form.Show()
            Else
                Flogin.Show()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Flaporan_CR.tipe_laporan = "harian"
        Flaporan_CR.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Flaporan_CR.tipe_laporan = "bulanan"
        Flaporan_CR.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Flaporan_CR.tipe_laporan = "tahunan"
        Flaporan_CR.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Flaporan_CR.tipe_laporan = "custom"
        Flaporan_CR.ShowDialog()
    End Sub

    Private Sub Flaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class