Imports CrystalDecisions.CrystalReports.Engine
Public Class Flaporan_CR
    Public CR As New ReportDocument()
    Public tipe_laporan As String
    Private Sub Flaporan1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CR.SetDatabaseLogon(My.Settings.db_username, My.Settings.db_password, My.Settings.db_server, My.Settings.db_database)
        If tipe_laporan = "harian" Then
            CRlaporan.SelectionFormula = "{daftar_pengiriman1.tgl_berangkat} = Date(" & Flaporan.Tharian.Value.ToString("yyyy,M,d") & ")"
        ElseIf tipe_laporan = "bulanan" Then
            CRlaporan.SelectionFormula = "Month({daftar_pengiriman1.tgl_berangkat}) = " & Flaporan.Tbulanan.Value.ToString("MM") & " AND Year({daftar_pengiriman1.tgl_berangkat}) = " & Flaporan.Tbulanan.Value.ToString("yyyy")
        ElseIf tipe_laporan = "tahunan" Then
            CRlaporan.SelectionFormula = "Year({daftar_pengiriman1.tgl_berangkat}) = " & Flaporan.Ttahunan.Value.ToString("yyyy")
        ElseIf tipe_laporan = "custom" Then
            CRlaporan.SelectionFormula = "{daftar_pengiriman1.tgl_berangkat} = Date(" & Flaporan.Tawal.Value.ToString("yyyy,M,d") & ") to Date (" & Flaporan.Takhir.Value.ToString("yyyy,M,d") & ")"
        End If
        CRlaporan.ReportSource = CR
    End Sub
End Class