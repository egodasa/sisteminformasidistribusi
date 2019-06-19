Imports SqlHelper
Public Class Fpengiriman_daftar
    Public current_id As Integer
    Public pengiriman As New DataQuery
    Private Sub Badd_Click(sender As Object, e As EventArgs) Handles Badd.Click
        Fpengiriman.ShowDialog()
    End Sub
    Private Sub Fdaftar_pengiriman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pengiriman.table = "tbl_pengiriman"
        pengiriman.view = "daftar_pengiriman"
        pengiriman.primary_key = "nomor_do"
        pengiriman.primary_key_caption = "Nomor DO"
        pengiriman.viewData = New List(Of SqlView) From {
            New SqlView("tgl_berangkat", "Tanggal Berangkat"),
            New SqlView("nomor_do", "Nomor DO"),
            New SqlView("nm_supir", "Nama Supir"),
            New SqlView("no_hp", "No. Hp"),
            New SqlView("nopol", "Plat Nomor"),
            New SqlView("nm_kota", "Nama Kota"),
            New SqlView("vol_ton", "Volume (Ton)"),
            New SqlView("vol_sak", "Volume (Sak)"),
            New SqlView("tarif", "Harga Satuan (PTSP)"),
            New SqlView("tarif_truk", "Harga Satuan (Truk)"),
            New SqlView("harga_ptsp", "Harga PTSP"),
            New SqlView("uang_jalan", "Uang Jalan"),
            New SqlView("sisa_uang_jalan", "Sisa Uang Jalan"),
            New SqlView("total_ongkos_jalan", "Total Ongkos"),
            New SqlView("jumlah_margin", "Jumlah Margin"),
            New SqlView("tgl_sampai", "Tanggal Sampai"),
            New SqlView("ket", "Keterangan"),
            New SqlView("nm_agen", "Nama Agen"),
            New SqlView("id_agen", "id_agen"),
            New SqlView("id_supir", "id_supir"),
            New SqlView("id_kota", "id_kota"),
            New SqlView("id_truk", "id_truk")
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
            RunQuery(pengiriman.Delete(DGpengiriman.Rows(x).Cells("Nomor DO").Value.ToString))
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If jenis_pengguna = "Admin" Then
                main_form.Show()
            Else
                Flogin.Show()
            End If
        End If
        Me.Close()
    End Sub

    Private Sub Tcari_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tcari.KeyUp
        If Tcari.TextLength = 0 Then
            DGpengiriman.DataSource = FetchData(pengiriman.SelectMultiple())
        Else
            If e.KeyValue = Keys.Enter Then
                DGpengiriman.DataSource = FetchData(pengiriman.SelectMultiple() & " WHERE nomor_do LIKE '%" & Tcari.Text & "%' OR nm_supir LIKE '%" & Tcari.Text & "%'")
            End If
        End If
    End Sub
End Class