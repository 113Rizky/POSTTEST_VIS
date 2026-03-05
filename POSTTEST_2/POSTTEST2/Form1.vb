Public Class Form1
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtJudul.Text.Trim()
        Dim genre As String = txtGenre.Text.Trim()

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre harus diisi!")
            Exit Sub
        End If

        If CariIndexBuku(judul) <> -1 Then
            MessageBox.Show("Judul buku sudah ada!")
            Exit Sub
        End If

        TambahBuku(judul, genre)
        lstBuku.Items.Add(judul & " (" & genre & ")")

        txtJudul.Clear()
        txtGenre.Clear()
        txtJudul.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtJudul.Text.Trim()

        If judul = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!")
            Exit Sub
        End If

        Dim sukses As Boolean
        HapusBuku(judul, sukses)

        If sukses Then
            lstBuku.Items.Clear()

            For i As Integer = 0 To jumlah - 1
                lstBuku.Items.Add(judulBuku(i) & " (" & genreBuku(i) & ")")
            Next

            txtJudul.Clear()
        Else
            MessageBox.Show("Buku tidak ditemukan!")
        End If
    End Sub

End Class
