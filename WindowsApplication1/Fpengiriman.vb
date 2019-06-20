Imports SqlHelper
Public Class Fpengiriman
    Dim agen As New DataQuery
    Dim distributor As New DataQuery
    Dim supir As New DataQuery
    Dim truk As New DataQuery
    Dim kota As New DataQuery
    Private list_supir, list_agen, list_truk, list_kota, list_distributor As DataTable
    Private Function FormValidation()
        Return Tno_do.TextLength <> 0 And Ckota.Text.Length <> 0 And Ctruk.Text.Length <> 0 And Csupir.Text.Length <> 0 And Cagen.Text.Length <> 0
    End Function
    Private Sub LoadForm(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        agen.table = "tbl_agen_truk"
        distributor.table = "tbl_distributor"
        supir.table = "tbl_supir"
        truk.table = "tbl_truk"
        kota.table = "tbl_kota"
        list_distributor = FetchData(Query.SelectAll("tbl_distributor"))
        list_supir = FetchData(Query.SelectAll("tbl_supir"))
        list_agen = FetchData(Query.SelectAll("tbl_agen_truk"))
        list_truk = FetchData(Query.SelectAll("daftar_truk"))
        list_kota = FetchData(Query.SelectAll("tbl_kota"))
        With Ctruk
            .DataSource = list_truk
            .ValueMember = "id_truk"
            .DisplayMember = "nopol"
        End With
        With Cdistributor
            .DataSource = list_distributor
            .ValueMember = "id_distributor"
            .DisplayMember = "nm_distributor"
        End With
        With Cagen
            .DataSource = list_agen
            .ValueMember = "id_agen"
            .DisplayMember = "nm_agen"
        End With
        With Csupir
            .DataSource = list_supir
            .ValueMember = "id_supir"
            .DisplayMember = "nm_supir"
        End With
        With Ckota
            .DataSource = list_kota
            .ValueMember = "id_kota"
            .DisplayMember = "nm_kota"
        End With
        ResetForm()
    End Sub
    Private Sub SetPengirimanValue()
        Fpengiriman_daftar.pengiriman.formData = New List(Of SqlManipulation) From {
            New SqlManipulation("nomor_do", Query.SqlString(Tno_do.Text)),
            New SqlManipulation("tgl_berangkat", Query.SqlString(Ttgl_berangkat.Value.ToString("yyyy-MM-dd"))),
            New SqlManipulation("tgl_sampai", Query.SqlString(Ttgl_sampai.Value.ToString("yyyy-MM-dd"))),
            New SqlManipulation("id_supir", Csupir.SelectedValue),
            New SqlManipulation("id_truk", Ctruk.SelectedValue),
            New SqlManipulation("id_kota", Ckota.SelectedValue),
            New SqlManipulation("id_distributor", Cdistributor.SelectedValue),
            New SqlManipulation("tarif_ptsp", Ttarif.Value),
            New SqlManipulation("vol_ton", Tton.Value),
            New SqlManipulation("vol_sak", Tsak.Value),
            New SqlManipulation("tarif_truk", Tbiaya_truk.Value),
            New SqlManipulation("sisa_uang_jalan", Tsisa.Value),
            New SqlManipulation("nm_gudang", Query.SqlString(Tgudang.Text)),
            New SqlManipulation("ket", Query.SqlString(Tketerangan.Text))
            }
    End Sub
    Private Sub SetSupirValue()
        supir.formData = New List(Of SqlManipulation) From {
            New SqlManipulation("nm_supir", Query.SqlString(Csupir.Text)),
            New SqlManipulation("no_hp", Query.SqlString(Tnohp.Text))
            }
    End Sub
    Private Sub SetTrukValue()
        truk.formData = New List(Of SqlManipulation) From {
             New SqlManipulation("nopol", Query.SqlString(Ctruk.Text)),
             New SqlManipulation("id_agen", Cagen.SelectedValue)
            }
    End Sub
    Private Sub SetAgenValue()
        agen.formData = New List(Of SqlManipulation) From {
            New SqlManipulation("nm_agen", Query.SqlString(Cagen.Text))
            }
    End Sub
    Private Sub SetDistributorValue()
        distributor.formData = New List(Of SqlManipulation) From {
            New SqlManipulation("nm_distributor", Query.SqlString(Cdistributor.Text))
            }
    End Sub
    Private Sub SetKotaValue()
        kota.formData = New List(Of SqlManipulation) From {
            New SqlManipulation("nm_kota", Query.SqlString(Ckota.Text)),
            New SqlManipulation("tarif", Ttarif.Value)
        }
    End Sub

    Private Sub AddPengiriman(ByVal sender As Object, ByVal e As EventArgs) Handles Badd.Click
        If FormValidation() = True Then
            If Csupir.SelectedIndex = -1 Then
                SetSupirValue()
                RunQuery(supir.Insert())
                Dim id_supir As DataTable = FetchData("SELECT LAST_INSERT_ID() AS id")
                list_supir = FetchData(Query.SelectAll("tbl_supir"))
                Csupir.DataSource = list_supir
                Csupir.SelectedValue = id_supir.Rows(0).Item("id")
            End If
            If Cagen.SelectedIndex = -1 Then
                SetAgenValue()
                RunQuery(agen.Insert())
                Dim id_agen As DataTable = FetchData("SELECT LAST_INSERT_ID() AS id")
                list_agen = FetchData(Query.SelectAll("tbl_agen_truk"))
                Cagen.DataSource = list_agen
                Cagen.SelectedValue = id_agen.Rows(0).Item("id")
            End If
            If Cdistributor.SelectedIndex = -1 Then
                SetDistributorValue()
                RunQuery(distributor.Insert())
                Dim id_distributor As DataTable = FetchData("SELECT LAST_INSERT_ID() AS id")
                list_distributor = FetchData(Query.SelectAll("tbl_distributor"))
                Cdistributor.DataSource = list_distributor
                Cdistributor.SelectedValue = id_distributor.Rows(0).Item("id")
            End If
            If Ctruk.SelectedIndex = -1 Then
                SetTrukValue()
                RunQuery(truk.Insert())
                Dim id_truk As DataTable = FetchData("SELECT LAST_INSERT_ID() AS id")
                list_truk = FetchData(Query.SelectAll("daftar_truk"))
                Ctruk.DataSource = list_truk
                Ctruk.SelectedValue = id_truk.Rows(0).Item("id")
            End If
            If Ckota.SelectedIndex = -1 Then
                SetKotaValue()
                RunQuery(kota.Insert())
                Dim id_kota As DataTable = FetchData("SELECT LAST_INSERT_ID() AS id")
                list_kota = FetchData(Query.SelectAll("tbl_kota"))
                Ckota.DataSource = list_kota
                Ckota.SelectedValue = id_kota.Rows(0).Item("id")
            End If
            SetPengirimanValue()
            RunQuery(Fpengiriman_daftar.pengiriman.Insert())
            Fpengiriman_daftar.DGpengiriman.DataSource = FetchData(Fpengiriman_daftar.pengiriman.SelectMultiple())
            Call successMessage()
            ResetForm()
        End If
    End Sub
    Private Sub ResetForm()
        Ttgl_berangkat.ResetText()
        Ttgl_sampai.ResetText()
        Tno_do.Clear()
        Tnohp.Clear()
        Tton.Value = 0
        Tsak.Value = 0
        Tbiaya_truk.Value = 0
        Ttarif.Value = 0
        Tsisa.Value = 0
        Ttotal_ongkos.Value = 0
        Tuang_jalan.Value = 0
        Ctruk.SelectedIndex = -1
        Csupir.SelectedIndex = -1
        Cagen.SelectedIndex = -1
        Cdistributor.SelectedIndex = -1
        Ckota.SelectedIndex = -1
        Tgudang.Clear()
        Tketerangan.Clear()
        Ttotal_tarif.Value = 0
        Ttotal_biaya_truk.Value = 0
        Tno_do.Focus()
    End Sub
    Private Sub CancelAction(ByVal sender As Object, ByVal e As EventArgs) Handles Bcancel.Click
        ResetForm()
    End Sub

    Private Sub CloseForm(ByVal sender As Object, ByVal e As EventArgs) Handles Bexit.Click
        Me.Close()
    End Sub

    Private Sub DaftarPembelianToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Fpengiriman_daftar.ShowDialog()
    End Sub
    Private Sub DaftarProdukToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Fkelola_supir.ShowDialog()
    End Sub

    Private Sub DaftarSatuanToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Fkota.ShowDialog()
    End Sub

    Private Sub GetDetailSupir(ByVal sender As Object, ByVal e As EventArgs) Handles Csupir.Leave
        If Csupir.SelectedIndex <> -1 Then
            Tnohp.Text = list_supir.Rows(Csupir.SelectedIndex).Item("no_hp")
        End If
    End Sub

    Private Sub GetTrukDetail(ByVal sender As Object, ByVal e As EventArgs) Handles Ctruk.Leave
        If Ctruk.SelectedIndex <> -1 Then
            Cagen.SelectedValue = list_truk.Rows(Ctruk.SelectedIndex).Item("id_agen")
        End If
    End Sub

    Private Sub GetKotaDetail(ByVal sender As Object, ByVal e As EventArgs) Handles Ckota.Leave
        If Ckota.SelectedIndex <> -1 Then
            Ttarif.Value = list_kota.Rows(Ckota.SelectedIndex).Item("tarif")
        End If
    End Sub

    Private Sub HitungTotalOngkos(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Tbiaya_truk.KeyUp
        If e.KeyData = Keys.Enter Then
            If Tton.Value <> 0 Then
                Ttotal_ongkos.Value = Tton.Value * Tbiaya_truk.Value
            End If
        End If
    End Sub

    Private Sub HitungUangJalan(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Tsisa.KeyUp
        If e.KeyData = Keys.Enter Then
            If Ttotal_ongkos.Value <> 0 Then
                Tuang_jalan.Value = Ttotal_ongkos.Value - Tsisa.Value
            End If
        End If
    End Sub

    Private Sub Tno_do_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Tno_do.KeyUp
        If e.KeyData = Keys.Enter Then
            Dim data As DataTable = FetchData(Query.SelectAll("tbl_pengiriman", "nomor_do", "=", Query.SqlString(Tno_do.Text)))
            If data.Rows.Count > 0 Then
                MessageBox.Show("Nomor DO " & Tno_do.Text & " sudah ada!")
                Tno_do.Clear()
                Tno_do.Focus()
            Else
                Ttgl_berangkat.Focus()
            End If
        End If
    End Sub

    Private Sub Ttgl_berangkat_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Ttgl_berangkat.KeyUp
        If e.KeyData = Keys.Enter Then
            Ttgl_sampai.Focus()
        End If
    End Sub

    Private Sub Ckota_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Ckota.KeyUp
        If e.KeyData = Keys.Enter Then
            Cdistributor.Focus()
        End If
    End Sub

    Private Sub Cdistributor_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Cdistributor.KeyUp
        If e.KeyData = Keys.Enter Then
            Tgudang.Focus()
        End If
    End Sub

    Private Sub Tgudang_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Tgudang.KeyUp
        If e.KeyData = Keys.Enter Then
            Ctruk.Focus()
        End If
    End Sub

    Private Sub Ctruk_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Ctruk.KeyUp
        If e.KeyData = Keys.Enter Then
            Cagen.Focus()
        End If
    End Sub

    Private Sub Cagen_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Cagen.KeyUp
        If e.KeyData = Keys.Enter Then
            Csupir.Focus()
        End If
    End Sub

    Private Sub Csupir_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Csupir.KeyUp
        If e.KeyData = Keys.Enter Then
            Tnohp.Focus()
        End If
    End Sub

    Private Sub Tnohp_TextChanged(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Tnohp.KeyUp
        If e.KeyData = Keys.Enter Then
            Tton.Focus()
        End If
    End Sub

    Private Sub Tton_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Tton.KeyUp
        If e.KeyData = Keys.Enter Then
            Tsak.Focus()
        End If
    End Sub

    Private Sub Tsak_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Tsak.KeyUp
        If e.KeyData = Keys.Enter Then
            Ttarif.Focus()
        End If
    End Sub

    Private Sub Ttarif_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Ttarif.KeyUp
        If e.KeyData = Keys.Enter Then
            Tbiaya_truk.Focus()
        End If
    End Sub

    Private Sub Tbiaya_truk_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Tbiaya_truk.KeyUp
        If e.KeyData = Keys.Enter Then
            Tsisa.Focus()
            Ttotal_ongkos.Value = Tton.Value * Tbiaya_truk.Value
        End If
    End Sub

    Private Sub Tsisa_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Tsisa.KeyUp
        If e.KeyData = Keys.Enter Then
            If Ttotal_ongkos.Value - Tsisa.Value >= 0 Then
                Tuang_jalan.Value = Ttotal_ongkos.Value - Tsisa.Value
                Tketerangan.Focus()
            Else
                MessageBox.Show("Sisa uang jalan terlalu besar!", "Pesan")
                Tsisa.Value = 0
                Tsisa.ResetText()
                Tsisa.Focus()
            End If
        End If
    End Sub

    Private Sub Ttgl_sampai_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Ttgl_sampai.KeyUp
        If e.KeyData = Keys.Enter Then
            Ckota.Focus()
        End If
    End Sub

    Private Sub Ttarif_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Ttarif.Leave
        Ttotal_tarif.Value = Ttarif.Value * Tton.Value
    End Sub

    Private Sub Tbiaya_truk_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles Tbiaya_truk.Leave
        Ttotal_biaya_truk.Value = Tton.Value * Tbiaya_truk.Value
    End Sub

End Class