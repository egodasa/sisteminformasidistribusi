Public Class Flaporan
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If jenis_pengguna = "Admin" Then
            main_form.Show()
        Else
            Flogin.Show()
        End If
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Flaporan_CR.tipe_laporan = "harian"
        Flaporan_CR.CR.SetParameterValue("judul", "Per Tanggal " & penjualan_awal.Value.ToString("dd MMMM yyyy") & " - " & penjualan_akhir.Value.ToString("dd MMMM yyyy"))
        Flaporan_CR.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Flaporan_CR.tipe_laporan = "bulanan"
        Flaporan_CR.CR.SetParameterValue("judul", "Per Tanggal " & pembelian_awal.Value.ToString("dd MMMM yyyy") & " - " & pembelian_akhir.Value.ToString("dd MMMM yyyy"))
        Flaporan_CR.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Flaporan_CR.tipe_laporan = "tahunan"
        Flaporan_CR.CR.SetParameterValue("judul", "Per Tanggal " & laba_awal.Value.ToString("dd MMMM yyyy"))
        Flaporan_CR.ShowDialog()
    End Sub
    Private Sub Flaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Flaporan_CR.CR.Load("laporan/Pengiriman.rpt")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Flaporan_CR.tipe_laporan = "custom"
        Flaporan_CR.CR.SetParameterValue("judul", "Per Tanggal " & laba_awal.Value.ToString("dd MMMM yyyy"))
        Flaporan_CR.ShowDialog()
    End Sub
End Class