Public Class Fkota
    Dim kota As New SqlHelper.DataQuery
    Dim current_id As Integer
    Private Sub SetFormData()
        kota.formData = New List(Of SqlHelper.SqlManipulation) From {
            New SqlHelper.SqlManipulation("nm_kota", SqlHelper.Query.SqlString(Tnm_kota.Text)),
            New SqlHelper.SqlManipulation("tarif", Ttarif.Value)
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kota.table = "tbl_kota"
        kota.view = Nothing
        kota.primary_key = "id_kota"
        kota.primary_key_caption = "id_kota"
        kota.viewData = New List(Of SqlHelper.SqlView) From {
            New SqlHelper.SqlView("id_kota", "id_kota"),
            New SqlHelper.SqlView("nm_kota", "Nama_Kota"),
            New SqlHelper.SqlView("tarif", "Tarif")
            }
        DGsatuan.DataSource = FetchData(kota.SelectMultiple())
        DGsatuan.Columns(kota.primary_key_caption).Visible = False
    End Sub
    Private Sub GetDetail(ByVal x As Integer)
        Bedit.Enabled = True
        Bsave.Enabled = False
        Tnm_kota.Text = DGsatuan.Rows(x).Cells(1).Value
        Ttarif.Text = DGsatuan.Rows(x).Cells(2).Value
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        SetFormData()
        RunQuery(kota.Update(DGsatuan.Rows(current_id).Cells(0).Value.ToString()))
        Call editMessage()
        Bcancel.PerformClick()
        DGsatuan.DataSource = FetchData(kota.SelectMultiple())
    End Sub
    Private Sub DeleteData(ByVal x As Integer)
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            RunQuery(kota.Delete(DGsatuan.Rows(x).Cells(0).Value))
            DGsatuan.DataSource = FetchData(kota.SelectMultiple())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub SaveData(sender As Object, e As EventArgs) Handles Bsave.Click
        SetFormData()
        RunQuery(kota.Insert())
        Call successMessage()
        DGsatuan.DataSource = FetchData(kota.SelectMultiple())
        Bcancel.PerformClick()
    End Sub
    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bsave.Enabled = True
        Tnm_kota.Clear()
        Ttarif.ResetText()
        Tnm_kota.Focus()
    End Sub

    Private Sub DGsatuan_MouseClick(sender As Object, e As MouseEventArgs) Handles DGsatuan.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim pos = DGsatuan.HitTest(e.X, e.Y).RowIndex
            If pos >= 0 Then
                MenuAksi.Show(DGsatuan, New Point(e.X, e.Y))
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