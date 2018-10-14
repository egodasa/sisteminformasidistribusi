Imports CrystalDecisions.CrystalReports.Engine
Public Class Flaporan_CR
    Public CR As New ReportDocument()
    Public tipe_laporan As String
    Private Sub Flaporan1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If tipe_laporan = "harian" Then
            CR.Load("laporan/Pengiriman.rpt")
            CR.SetParameterValue("judul", "Tanggal " & Flaporan.Tharian.Value.ToString("dd MMMM yyyy"))
            CRlaporan.SelectionFormula = "{daftar_pengiriman1.tgl_berangkat} = Date(" & Flaporan.Tharian.Value.ToString("yyyy,M,d") & ")"
        ElseIf tipe_laporan = "bulanan" Then
            CR.Load("laporan/PengirimanBulanan.rpt")
            CR.SetParameterValue("judul", "Bulan " & Flaporan.Tbulanan.Value.ToString("MMMM yyyy"))
            CRlaporan.SelectionFormula = "Month({daftar_pengiriman1.tgl_berangkat}) = " & Flaporan.Tbulanan.Value.ToString("MM") & " AND Year({daftar_pengiriman1.tgl_berangkat}) = " & Flaporan.Tbulanan.Value.ToString("yyyy")
        ElseIf tipe_laporan = "tahunan" Then
            CR.Load("laporan/PengirimanTahunan.rpt")
            CR.SetParameterValue("judul", "Tahun " & Flaporan.Ttahunan.Value.ToString("yyyy"))
            CRlaporan.SelectionFormula = "Year({daftar_pengiriman1.tgl_berangkat}) = " & Flaporan.Ttahunan.Value.ToString("yyyy")
        ElseIf tipe_laporan = "custom" Then
            CR.Load("laporan/Pengiriman.rpt")
            CR.SetParameterValue("judul", "Per Tanggal " & Flaporan.Tawal.Value.ToString("dd MMMM yyyy") & " - " & Flaporan.Takhir.Value.ToString("dd MMMM yyyy"))
            CRlaporan.SelectionFormula = "{daftar_pengiriman1.tgl_berangkat} in Date(" & Flaporan.Tawal.Value.ToString("yyyy,M,d") & ") to Date (" & Flaporan.Takhir.Value.ToString("yyyy,M,d") & ")"
        End If
        CRlaporan.ReportSource = CR
    End Sub
End Class