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
        Flaporan_CR.CR.SetParameterValue("judul", "Tanggal " & Tharian.Value.ToString("dd MMMM yyyy"))
        Flaporan_CR.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Flaporan_CR.tipe_laporan = "bulanan"
        Flaporan_CR.CR.SetParameterValue("judul", "Bulan " & Tbulanan.Value.ToString("MMMM yyyy"))
        Flaporan_CR.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Flaporan_CR.tipe_laporan = "tahunan"
        Flaporan_CR.CR.SetParameterValue("judul", "Tahun " & Ttahunan.Value.ToString("yyyy"))
        Flaporan_CR.ShowDialog()
    End Sub
    Private Sub Flaporan_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Label1.Location = New Point(107, 26)
        BWlaporan.RunWorkerAsync()
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Flaporan_CR.tipe_laporan = "custom"
        Flaporan_CR.CR.SetParameterValue("judul", "Per Tanggal " & Tawal.Value.ToString("dd MMMM yyyy") & " - " & Takhir.Value.ToString("dd MMMM yyyy"))
        Flaporan_CR.ShowDialog()
    End Sub

    Private Sub BWlaporan_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWlaporan.DoWork
        Flaporan_CR.CR.Load("laporan/Pengiriman.rpt")
    End Sub
    Private Sub BWlaporan_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BWlaporan.RunWorkerCompleted
        Label1.Visible = False
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        GroupBox4.Visible = True
        Bexit.Visible = True
    End Sub
End Class