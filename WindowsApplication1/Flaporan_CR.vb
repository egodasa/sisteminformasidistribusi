Imports CrystalDecisions.CrystalReports.Engine
Public Class Flaporan_CR
    Public CR As New ReportDocument()
    Public tipe_laporan As String
    Private Sub Flaporan1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CR.SetDatabaseLogon(My.Settings.db_username, My.Settings.db_password, My.Settings.db_server, My.Settings.db_database)
        If tipe_laporan = "harian" Then
            CRlaporan.SelectionFormula = "{tbl_transaksi1.tgl_transaksi} in Date(" & Flaporan.penjualan_awal.Value.ToString("yyyy,M,d") & ") to Date(" & Flaporan.penjualan_akhir.Value.ToString("yyyy,M,d") & ")"
        ElseIf tipe_laporan = "bulanan" Then
            CRlaporan.SelectionFormula = "{tbl_pembelian1.tgl_pembelian} in Date(" & Flaporan.pembelian_awal.Value.ToString("yyyy,M,d") & ") to Date(" & Flaporan.pembelian_akhir.Value.ToString("yyyy,M,d") & ")"
        ElseIf tipe_laporan = "tahunan" Then
            CRlaporan.SelectionFormula = "{laporan_laba_rugi1.tgl_jual} in Date(" & Flaporan.laba_awal.Value.ToString("yyyy,M,d") & ") to Date(" & Flaporan.laba_akhir.Value.ToString("yyyy,M,d") & ")"
        ElseIf tipe_laporan = "custom" Then
        End If
        CRlaporan.ReportSource = CR
    End Sub
End Class