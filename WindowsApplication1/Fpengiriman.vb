Public Class Fpengiriman
    Dim agen As New SqlHelper.DataQuery
    Dim supir As New SqlHelper.DataQuery
    Dim truk As New SqlHelper.DataQuery
    Dim kota As New SqlHelper.DataQuery
    Private Sub LoadForm(sender As Object, e As EventArgs) Handles MyBase.Load
        agen.table = "tbl_agen_truk"
        supir.table = "tbl_supir"
        truk.table = "tbl_truk"
        kota.table = "tbl_kota"
        FetchComboboxData(SqlHelper.Query.SelectAll("daftar_truk"), Ctruk, "nopol", "id_truk")
        FetchComboboxData(SqlHelper.Query.SelectAll("tbl_supir"), Csupir, "nm_supir", "id_supir")
        FetchComboboxData(SqlHelper.Query.SelectAll("tbl_kota"), Ckota, "nm_kota", "id_kota")
        FetchComboboxData(SqlHelper.Query.SelectAll("tbl_agen_truk"), Cagen, "nm_agen", "id_agen")
        ResetForm()
    End Sub
    Private Sub SetPengirimanValue()
        Fpengiriman_daftar.pengiriman.formData = New List(Of SqlHelper.SqlManipulation) From {
            New SqlHelper.SqlManipulation("nomor_do", SqlHelper.Query.SqlString(Tno_do.Text)),
            New SqlHelper.SqlManipulation("tgl_berangkat", SqlHelper.Query.SqlString(Ttgl_berangkat.Value.ToString("yyyy-MM-dd"))),
            New SqlHelper.SqlManipulation("tgl_sampai", SqlHelper.Query.SqlString(Ttgl_sampai.Value.ToString("yyyy-MM-dd"))),
            New SqlHelper.SqlManipulation("id_supir", Csupir.SelectedValue),
            New SqlHelper.SqlManipulation("id_truk", Ctruk.SelectedValue),
            New SqlHelper.SqlManipulation("id_kota", Ckota.SelectedValue),
            New SqlHelper.SqlManipulation("tarif_ptsp", Ttarif.Value),
            New SqlHelper.SqlManipulation("vol_ton", Tton.Value),
            New SqlHelper.SqlManipulation("vol_sak", Tsak.Value),
            New SqlHelper.SqlManipulation("tarif_truk", Tbiaya_truk.Value),
            New SqlHelper.SqlManipulation("sisa_uang_jalan", Tsisa.Value),
            New SqlHelper.SqlManipulation("ket", SqlHelper.Query.SqlString(Tketerangan.Text))
            }
    End Sub
    Private Sub SetSupirValue()
        supir.formData = New List(Of SqlHelper.SqlManipulation) From {
            New SqlHelper.SqlManipulation("nm_supir", SqlHelper.Query.SqlString(Csupir.Text)),
            New SqlHelper.SqlManipulation("no_hp", SqlHelper.Query.SqlString(Tnohp.Text))
            }
    End Sub
    Private Sub SetTrukValue()
        truk.formData = New List(Of SqlHelper.SqlManipulation) From {
             New SqlHelper.SqlManipulation("nopol", SqlHelper.Query.SqlString(Ctruk.Text)),
             New SqlHelper.SqlManipulation("id_agen", Cagen.SelectedValue)
            }
    End Sub
    Private Sub SetAgenValue()
        agen.formData = New List(Of SqlHelper.SqlManipulation) From {
            New SqlHelper.SqlManipulation("nm_agen", SqlHelper.Query.SqlString(Cagen.Text))
            }
    End Sub
    Private Sub SetKotaValue()
        kota.formData = New List(Of SqlHelper.SqlManipulation) From {
            New SqlHelper.SqlManipulation("nm_kota", SqlHelper.Query.SqlString(Ckota.Text)),
            New SqlHelper.SqlManipulation("tarif", Ttarif.Value)
        }
    End Sub

    Private Sub AddPengiriman(sender As Object, e As EventArgs) Handles Badd.Click
        If Csupir.SelectedIndex = -1 Then
            SetSupirValue()
            RunQuery(supir.Insert())
            Dim id_supir As DataTable = FetchData("SELECT LAST_INSERT_ID() AS id")
            FetchComboboxData(SqlHelper.Query.SelectAll("tbl_supir"), Csupir, "nm_supir", "id_supir")
            Csupir.SelectedValue = id_supir.Rows(0).Item("id")
        End If
        If Cagen.SelectedIndex = -1 Then
            SetAgenValue()
            RunQuery(agen.Insert())
            Dim id_agen As DataTable = FetchData("SELECT LAST_INSERT_ID() AS id")
            FetchComboboxData(SqlHelper.Query.SelectAll("tbl_agen_truk"), Cagen, "nm_agen", "id_agen")
            Cagen.SelectedValue = id_agen.Rows(0).Item("id")
        End If
        If Ctruk.SelectedIndex = -1 Then
            SetTrukValue()
            RunQuery(truk.Insert())
            Dim id_truk As DataTable = FetchData("SELECT LAST_INSERT_ID() AS id")
            FetchComboboxData(SqlHelper.Query.SelectAll("daftar_truk"), Ctruk, "nopol", "id_truk")
            Ctruk.SelectedValue = id_truk.Rows(0).Item("id")
        End If
        If Ckota.SelectedIndex = -1 Then
            SetKotaValue()
            RunQuery(kota.Insert())
            Dim id_kota As DataTable = FetchData("SELECT LAST_INSERT_ID() AS id")
            FetchComboboxData(SqlHelper.Query.SelectAll("tbl_kota"), Ckota, "nm_kota", "id_kota")
            Ckota.SelectedValue = id_kota.Rows(0).Item("id")
        End If
        SetPengirimanValue()
        MessageBox.Show(Fpengiriman_daftar.pengiriman.Insert())
        RunQuery(Fpengiriman_daftar.pengiriman.Insert())
        Fpengiriman_daftar.DGpengiriman.DataSource = FetchData(Fpengiriman_daftar.pengiriman.SelectMultiple())
        Call successMessage()
        ResetForm()
    End Sub
    Private Sub ResetForm()
        Ttgl_berangkat.ResetText()
        Ttgl_sampai.ResetText()
        Tno_do.Clear()
        Tnohp.Clear()
        Tton.ResetText()
        Tsak.ResetText()
        Tbiaya_truk.ResetText()
        Ttarif.ResetText()
        Tsisa.ResetText()
        Ttotal_ongkos.ResetText()
        Tuang_jalan.ResetText()
        Ctruk.SelectedIndex = -1
        Csupir.SelectedIndex = -1
        Cagen.SelectedIndex = -1
        Ckota.SelectedIndex = -1
        Tketerangan.Clear()
        Ttotal_tarif.ResetText()
        Ttotal_biaya_truk.ResetText()
        Tno_do.Focus()
    End Sub
    Private Sub CancelAction(sender As Object, e As EventArgs) Handles Bcancel.Click
        ResetForm()
    End Sub

    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Bexit.Click
        Me.Close()
    End Sub

    Private Sub DaftarPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Fpengiriman_daftar.ShowDialog()
    End Sub
    Private Sub DaftarProdukToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Fkelola_supir.ShowDialog()
    End Sub

    Private Sub DaftarSatuanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Fkota.ShowDialog()
    End Sub

    Private Sub GetDetailSupir(ByVal sender As Object, ByVal e As EventArgs) Handles Csupir.Leave
        If Csupir.SelectedIndex <> -1 Then
            Dim data As DataTable = FetchData(supir.SelectAll("id_supir", "=", Csupir.SelectedValue))
            Tnohp.Text = data.Rows(0).Item("no_hp")
        End If
    End Sub

    Private Sub GetTrukDetail(ByVal sender As Object, ByVal e As EventArgs) Handles Ctruk.Leave
        If Ctruk.SelectedIndex <> -1 Then
            Dim data As DataTable = FetchData(truk.SelectAll("id_truk", "=", Ctruk.SelectedValue))
            Cagen.SelectedValue = data.Rows(0).Item("id_agen")
        End If
    End Sub

    Private Sub GetKotaDetail(ByVal sender As Object, ByVal e As EventArgs) Handles Ckota.Leave
        If Ckota.SelectedIndex <> -1 Then
            Dim data As DataTable = FetchData(kota.SelectAll("id_kota", "=", Ckota.SelectedValue))
            Ttarif.Value = data.Rows(0).Item("tarif")
        End If
    End Sub

    Private Sub HitungTotalOngkos(sender As Object, e As KeyEventArgs) Handles Tbiaya_truk.ValueChanged
        If Tton.Value <> 0 Then
            Ttotal_ongkos.Value = Tton.Value * Tbiaya_truk.Value
        End If
    End Sub

    Private Sub HitungUangJalan(sender As Object, e As KeyEventArgs) Handles Tsisa.ValueChanged
        If Ttotal_ongkos.Value <> 0 Then
            Tuang_jalan.Value = Ttotal_ongkos.Value - Tsisa.Value
        End If
    End Sub

    Private Sub Tno_do_KeyUp(sender As Object, e As KeyEventArgs) Handles Tno_do.KeyUp
        If e.KeyData = Keys.Enter Then
            Ttgl_berangkat.Focus()
        End If
    End Sub

    Private Sub Ttgl_berangkat_KeyUp(sender As Object, e As KeyEventArgs) Handles Ttgl_berangkat.KeyUp
        If e.KeyData = Keys.Enter Then
            Ttgl_sampai.Focus()
        End If
    End Sub

    Private Sub Ckota_KeyUp(sender As Object, e As KeyEventArgs) Handles Ckota.KeyUp
        If e.KeyData = Keys.Enter Then
            Ctruk.Focus()
        End If
    End Sub

    Private Sub Ctruk_KeyUp(sender As Object, e As KeyEventArgs) Handles Ctruk.KeyUp
        If e.KeyData = Keys.Enter Then
            Cagen.Focus()
        End If
    End Sub

    Private Sub Cagen_KeyUp(sender As Object, e As KeyEventArgs) Handles Cagen.KeyUp
        If e.KeyData = Keys.Enter Then
            Csupir.Focus()
        End If
    End Sub

    Private Sub Csupir_KeyUp(sender As Object, e As KeyEventArgs) Handles Csupir.KeyUp
        If e.KeyData = Keys.Enter Then
            Tnohp.Focus()
        End If
    End Sub

    Private Sub Tnohp_TextChanged(sender As Object, e As KeyEventArgs) Handles Tnohp.KeyUp
        If e.KeyData = Keys.Enter Then
            Tton.Focus()
        End If
    End Sub

    Private Sub Tton_KeyUp(sender As Object, e As KeyEventArgs) Handles Tton.KeyUp
        If e.KeyData = Keys.Enter Then
            Tsak.Focus()
        End If
    End Sub

    Private Sub Tsak_KeyUp(sender As Object, e As KeyEventArgs) Handles Tsak.KeyUp
        If e.KeyData = Keys.Enter Then
            Ttarif.Focus()
        End If
    End Sub

    Private Sub Ttarif_KeyUp(sender As Object, e As KeyEventArgs) Handles Ttarif.KeyUp
        If e.KeyData = Keys.Enter Then
            Tbiaya_truk.Focus()
        End If
    End Sub

    Private Sub Tbiaya_truk_KeyUp(sender As Object, e As KeyEventArgs) Handles Tbiaya_truk.KeyUp
        If e.KeyData = Keys.Enter Then
            Tsisa.Focus()
            Ttotal_ongkos.Value = Tton.Value * Tbiaya_truk.Value
        End If
    End Sub

    Private Sub Tsisa_KeyUp(sender As Object, e As KeyEventArgs) Handles Tsisa.KeyUp
        If e.KeyData = Keys.Enter Then
            Tketerangan.Focus()
            Tuang_jalan.Value = Ttotal_ongkos.Value - Tsisa.Value
        End If
    End Sub

    Private Sub Ttgl_sampai_KeyUp(sender As Object, e As KeyEventArgs) Handles Ttgl_sampai.KeyUp
        If e.KeyData = Keys.Enter Then
            Ckota.Focus()
        End If
    End Sub

    Private Sub Ttarif_Leave(sender As Object, e As EventArgs) Handles Ttarif.Leave
        Ttotal_tarif.Value = Ttarif.Value * Tton.Value
    End Sub

    Private Sub Tbiaya_truk_Leave(sender As Object, e As EventArgs) Handles Tbiaya_truk.Leave
        Ttotal_biaya_truk.Value = Tton.Value * Tbiaya_truk.Value
    End Sub

End Class