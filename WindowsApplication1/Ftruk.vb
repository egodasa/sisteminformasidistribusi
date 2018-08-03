Public Class Ftruk
    Dim truk As New SqlHelper.DataQuery
    Dim current_id As Integer
    Private Sub SetFormData()
        truk.formData = New List(Of SqlHelper.SqlManipulation) From {
            New SqlHelper.SqlManipulation("nopol", SqlHelper.Query.SqlString(Tnopol.Text)),
            New SqlHelper.SqlManipulation("id_agen", Cagen.SelectedValue)
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        truk.table = "tbl_truk"
        truk.view = "daftar_truk"
        truk.primary_key = "id_truk"
        truk.primary_key_caption = "id_truk"
        truk.viewData = New List(Of SqlHelper.SqlView) From {
            New SqlHelper.SqlView("id_truk", "id_truk"),
            New SqlHelper.SqlView("nopol", "Nomor Polisi"),
            New SqlHelper.SqlView("id_agen", "id_agen"),
            New SqlHelper.SqlView("nm_agen", "Agen")
            }
        FetchComboboxData(SqlHelper.Query.SelectAll("tbl_agen_truk"), Cagen, "nm_agen", "id_agen")
        DGtruk.DataSource = FetchData(truk.SelectMultiple())
        DGtruk.Columns(truk.primary_key_caption).Visible = False
        DGtruk.Columns("id_agen").Visible = False
    End Sub
    Private Sub GetDetail(ByVal x As Integer)
        Bedit.Enabled = True
        Bsave.Enabled = False
        Tnopol.Text = DGtruk.Rows(x).Cells(1).Value
        Cagen.SelectedValue = DGtruk.Rows(x).Cells(2).Value
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        SetFormData()
        RunQuery(truk.Update(DGtruk.Rows(current_id).Cells(0).Value.ToString()))
        Call editMessage()
        Bcancel.PerformClick()
        DGtruk.DataSource = FetchData(truk.SelectMultiple())
    End Sub
    Private Sub DeleteData(ByVal x As Integer)
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            RunQuery(truk.Delete(DGtruk.Rows(x).Cells(0).Value))
            DGtruk.DataSource = FetchData(truk.SelectMultiple())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub SaveData(sender As Object, e As EventArgs) Handles Bsave.Click
        SetFormData()
        RunQuery(truk.Insert())
        Call successMessage()
        DGtruk.DataSource = FetchData(truk.SelectMultiple())
        Bcancel.PerformClick()
    End Sub
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bsave.Enabled = True
        Tnopol.Clear()
        Cagen.SelectedIndex = -1
        Tnopol.Focus()
    End Sub

    Private Sub DGsatuan_MouseClick(sender As Object, e As MouseEventArgs) Handles DGtruk.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim pos = DGtruk.HitTest(e.X, e.Y).RowIndex
            If pos >= 0 Then
                MenuAksi.Show(DGtruk, New Point(e.X, e.Y))
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