Public Class Fkelola_supir
    Dim supir As New SqlHelper.DataQuery
    Dim current_id As Integer
    Private Function FormValidation()
        Return Tnm_supir.TextLength > 0
    End Function
    Private Sub SetFormData()
        supir.formData = New List(Of SqlHelper.SqlManipulation) From {
            New SqlHelper.SqlManipulation("nm_supir", SqlHelper.Query.SqlString(Tnm_supir.Text)),
            New SqlHelper.SqlManipulation("no_hp", SqlHelper.Query.SqlString(Tnohp.Text))
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetKoneksi()
        supir.table = "tbl_supir"
        supir.view = Nothing
        supir.primary_key = "id_supir"
        supir.primary_key_caption = "id_supir"
        supir.viewData = New List(Of SqlHelper.SqlView) From {
            New SqlHelper.SqlView("id_supir", "id_supir"),
            New SqlHelper.SqlView("nm_supir", "Nama Supir"),
            New SqlHelper.SqlView("no_hp", "NOHP")
            }
        DGproduk.DataSource = FetchData(supir.SelectMultiple())
        DGproduk.Columns(supir.primary_key_caption).Visible = False
        Bcancel.PerformClick()
    End Sub

    Private Sub CancelAction(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcancel.Click
        Bedit.Enabled = False
        Bsave.Enabled = True
        Tnm_supir.Focus()
        Tnm_supir.Clear()
        Tnohp.Clear()
    End Sub
    Private Sub CloseForm(sender As Object, e As EventArgs) Handles Bexit.Click
        If MessageBox.Show("Apakah Anda yakin ingin KELUAR?", "Peringatan!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) = DialogResult.Yes Then
            main_form.Show()
            Me.Close()
        End If
    End Sub
    Private Sub SaveData(sender As Object, e As EventArgs) Handles Bsave.Click
        If FormValidation() = True Then
            SetFormData()
        RunQuery(supir.Insert())
        Call successMessage()
        DGproduk.DataSource = FetchData(supir.SelectMultiple())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub GetDetail(ByVal x As Integer)
        Bedit.Enabled = True
        Bsave.Enabled = False
        Tnm_supir.Text = DGproduk.Rows(x).Cells("Nama Supir").Value
        Tnohp.Text = DGproduk.Rows(x).Cells("NOHP").Value
    End Sub
    Private Sub DeleteData(ByVal x As Integer)
        If MessageBox.Show("Apakah yakin data ini dihapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            RunQuery(supir.Delete(DGproduk.Rows(x).Cells(0).Value))
            DGproduk.DataSource = FetchData(supir.SelectMultiple())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub EditData(sender As Object, e As EventArgs) Handles Bedit.Click
        If FormValidation() = True Then
            SetFormData()
        RunQuery(supir.Update(DGproduk.Rows(current_id).Cells(0).Value.ToString()))
        Call editMessage()
        Bcancel.PerformClick()
            DGproduk.DataSource = FetchData(supir.SelectMultiple())
        End If
    End Sub

    Private Sub DGsatuan_MouseClick(sender As Object, e As MouseEventArgs) Handles DGproduk.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim pos = DGproduk.HitTest(e.X, e.Y).RowIndex
            If pos >= 0 Then
                MenuAksi.Show(DGproduk, New Point(e.X, e.Y))
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

    Private Sub DaftarSatuanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Fkota.ShowDialog()
    End Sub
End Class