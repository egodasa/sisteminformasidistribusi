Public Class Fagen
    Dim agen As New SqlHelper.DataQuery
    Dim current_id As Integer
    Private Sub SetFormData()
        agen.formData = New List(Of SqlHelper.SqlManipulation) From {
            New SqlHelper.SqlManipulation("nm_agen", SqlHelper.Query.SqlString(Tnm_agen.Text)),
            New SqlHelper.SqlManipulation("no_telpon", SqlHelper.Query.SqlString(Ttelp.Text)),
            New SqlHelper.SqlManipulation("alamat", SqlHelper.Query.SqlString(Talamat.Text))
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetKoneksi()
        agen.table = "tbl_agen_truk"
        agen.view = Nothing
        agen.primary_key = "id_agen"
        agen.primary_key_caption = "id_agen"
        agen.viewData = New List(Of SqlHelper.SqlView) From {
            New SqlHelper.SqlView("id_agen", "id_agen"),
            New SqlHelper.SqlView("nm_agen", "Nama Agen"),
            New SqlHelper.SqlView("no_telpon", "Nomor Telpon"),
            New SqlHelper.SqlView("alamat", "Alamat")
            }
        DGpemasok.DataSource = FetchData(agen.SelectMultiple())
        DGpemasok.Columns(agen.primary_key_caption).Visible = False
        Bcancel.PerformClick()
    End Sub

    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bsave.Enabled = True
        Tnm_agen.Focus()
        Tnm_agen.Clear()
        Ttelp.Clear()
        Talamat.Clear()
    End Sub
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            main_form.Show()
            Me.Close()
        End If
    End Sub
    Private Sub SaveData(sender As Object, e As EventArgs) Handles Bsave.Click
        SetFormData()
        RunQuery(agen.Insert())
        Call successMessage()
        DGpemasok.DataSource = FetchData(agen.SelectMultiple())
        Bcancel.PerformClick()
    End Sub
    Private Sub GetDetail(ByVal x As Integer)
        Bedit.Enabled = True
        Bsave.Enabled = False
        Tnm_agen.Text = DGpemasok.Rows(x).Cells("Nama Agen").Value
        Ttelp.Text = DGpemasok.Rows(x).Cells("Nomor Telpon").Value
        Talamat.Text = DGpemasok.Rows(x).Cells("Alamat").Value
    End Sub
    Private Sub DeleteData(ByVal x As Integer)
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            RunQuery(agen.Delete(DGpemasok.Rows(x).Cells(0).Value))
            DGpemasok.DataSource = FetchData(agen.SelectMultiple())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        SetFormData()
        RunQuery(agen.Update(DGpemasok.Rows(current_id).Cells(0).Value.ToString()))
        Call editMessage()
        Bcancel.PerformClick()
        DGpemasok.DataSource = FetchData(agen.SelectMultiple())
    End Sub

    Private Sub FindData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tcari.TextChanged
        If Tcari.Text.Length <> 0 Then
            'DGpemasok.DataSource = FetchData("select * from daftar_pemasok where `Nama_Pemasok` like '%" & Tcari.Text & "%'")
        Else
            DGpemasok.DataSource = FetchData(agen.SelectMultiple())
        End If
    End Sub

    Private Sub DGsatuan_MouseClick(sender As Object, e As MouseEventArgs) Handles DGpemasok.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim pos = DGpemasok.HitTest(e.X, e.Y).RowIndex
            If pos >= 0 Then
                MenuAksi.Show(DGpemasok, New Point(e.X, e.Y))
                current_id = pos
            End If
        End If
    End Sub

    Private Sub Medit_Click(sender As Object, e As EventArgs) Handles Medit.Click
        GetDetail(current_id)
    End Sub
    Private Sub Mhapus_Click(sender As Object, e As EventArgs) Handles Mhapus.Click
        DeleteData(current_id)
    End Sub
End Class