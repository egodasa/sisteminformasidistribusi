Public Class Fpengiriman_daftar
    Public current_id As Integer
    Public pengiriman As New SqlHelper.DataQuery
    Private Sub Badd_Click(sender As Object, e As EventArgs) Handles Badd.Click
        Fpengiriman.ShowDialog()
    End Sub
    Private Sub Fdaftar_pengiriman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pengiriman.table = "tbl_pengiriman"
        pengiriman.view = "daftar_pengiriman"
        pengiriman.primary_key = "no_do"
        pengiriman.primary_key_caption = "Nomor DO"
        pengiriman.viewData = New List(Of SqlHelper.SqlView) From {
            New SqlHelper.SqlView("tgl_berangkat", "Tanggal Berangkat"),
            New SqlHelper.SqlView("nomor_do", "Nomor DO"),
            New SqlHelper.SqlView("nm_supir", "Nama Supir"),
            New SqlHelper.SqlView("no_hp", "No. Hp"),
            New SqlHelper.SqlView("nopol", "Plat Nomor"),
            New SqlHelper.SqlView("nm_kota", "Nama Kota"),
            New SqlHelper.SqlView("vol_ton", "Volume (Ton)"),
            New SqlHelper.SqlView("vol_sak", "Volume (Sak)"),
            New SqlHelper.SqlView("tarif", "Harga Satuan (PTSP)"),
            New SqlHelper.SqlView("tarif_truk", "Harga Satuan (Truk)"),
            New SqlHelper.SqlView("harga_ptsp", "Harga PTSP"),
            New SqlHelper.SqlView("uang_jalan", "Uang Jalan"),
            New SqlHelper.SqlView("sisa_uang_jalan", "Sisa Uang Jalan"),
            New SqlHelper.SqlView("total_ongkos_jalan", "Total Ongkos"),
            New SqlHelper.SqlView("jumlah_margin", "Jumlah Margin"),
            New SqlHelper.SqlView("tgl_sampai", "Tanggal Sampai"),
            New SqlHelper.SqlView("ket", "Keterangan"),
            New SqlHelper.SqlView("nm_agen", "Nama Agen"),
            New SqlHelper.SqlView("id_agen", "id_agen"),
            New SqlHelper.SqlView("id_supir", "id_supir"),
            New SqlHelper.SqlView("id_kota", "id_kota"),
            New SqlHelper.SqlView("id_truk", "id_truk")
            }
        DGpengiriman.DataSource = FetchData(pengiriman.SelectMultiple())
        DGpengiriman.Columns("id_agen").Visible = False
        DGpengiriman.Columns("Nama Agen").Visible = False
        DGpengiriman.Columns("id_supir").Visible = False
        DGpengiriman.Columns("id_kota").Visible = False
        DGpengiriman.Columns("id_truk").Visible = False
    End Sub
    Private Sub DeletePengiriman(ByVal x As Integer)
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            RunQuery(pengiriman.Delete(DGpengiriman.Rows(x).Cells(pengiriman.primary_key).Value.ToString))
            DGpengiriman.DataSource = FetchData(pengiriman.SelectMultiple())
        End If
    End Sub

    Private Sub DGpengiriman_MouseClick(sender As Object, e As MouseEventArgs) Handles DGpengiriman.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim pos = DGpengiriman.HitTest(e.X, e.Y).RowIndex
            If pos >= 0 Then
                MenuAksi.Show(DGpengiriman, New Point(e.X, e.Y))
                current_id = pos
            End If
        End If
    End Sub

    Private Sub Mhapus_Click(sender As Object, e As EventArgs) Handles Mhapus.Click
        DeletePengiriman(current_id)
    End Sub
End Class