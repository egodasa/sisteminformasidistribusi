﻿Public Class Fmenu_karyawan
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Flogin.Show()
        main_form.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Fpenjualan_produk.Show()
        main_form.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Fpengiriman.Show()
        main_form.Hide()
    End Sub
End Class