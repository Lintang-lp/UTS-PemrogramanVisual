Public Class Awal_User

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Transaksi.Judul_Film.Text = ""
        Transaksi.Studio.Text = ""
        Transaksi.Hari.Text = ""
        Transaksi.Jam_Tayang.Text = ""
        Transaksi.NO_Kursi_1.Text = ""
        Transaksi.No_Kursi_2.Text = ""
        Transaksi.Harga.Text = ""
        Transaksi.Jumlah_Tiket.Text = ""

        Transaksi.D_JudulFilm.Text = "Judul Film"
        Transaksi.D_Studio.Text = "Studio"
        Transaksi.D_hari.Text = "______"
        Transaksi.D_JumlahTiket.Text = "______"
        Transaksi.D_JamTayang.Text = "______"
        Transaksi.D_NoKursi.Text = "______"
        Transaksi.D_TotalPesan.Text = ""
        Transaksi.D_Discount.Text = ""
        Transaksi.D_TotalBayar.Text = ""

        Transaksi.B_TotalBayar.Text = ""
        Transaksi.B_Pembayaran.Text = ""
        Transaksi.B_Kembalian.Text = ""

        Transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class