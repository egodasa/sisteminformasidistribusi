Imports SqlHelper
Public Class Fdistributor
    Dim agen As New DataQuery
    Dim current_id As Integer
    Private Function FormValidation()
        Return Tnm_agen.TextLength > 0
    End Function
    Private Sub SetFormData()
        agen.formData = New List(Of SqlManipulation) From {
            New SqlManipulation("nm_distributor", Query.SqlString(Tnm_agen.Text)),
            New SqlManipulation("no_telpon", Query.SqlString(Ttelp.Text)),
            New SqlManipulation("alamat", Query.SqlString(Talamat.Text))
            }
    End Sub
    Private Sub LoadForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetKoneksi()
        agen.table = "tbl_distributor"
        agen.view = Nothing
        agen.primary_key = "id_distributor"
        agen.primary_key_caption = "id_distributor"
        agen.viewData = New List(Of SqlView) From {
            New SqlView("id_distributor", "id_distributor"),
            New SqlView("nm_distributor", "Nama distributor"),
            New SqlView("no_telpon", "Nomor Telpon"),
            New SqlView("alamat", "Alamat")
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
        If FormValidation() = True Then
            SetFormData()
            RunQuery(agen.Insert())
            Call successMessage()
            DGpemasok.DataSource = FetchData(agen.SelectMultiple())
            Bcancel.PerformClick()
        End If
    End Sub
    Private Sub GetDetail(ByVal x As Integer)
        Bedit.Enabled = True
        Bsave.Enabled = False
        Tnm_agen.Text = DGpemasok.Rows(x).Cells("Nama distributor").Value
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
        If FormValidation() = True Then
            SetFormData()
            RunQuery(agen.Update(DGpemasok.Rows(current_id).Cells(0).Value.ToString()))
            Call editMessage()
            Bcancel.PerformClick()
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