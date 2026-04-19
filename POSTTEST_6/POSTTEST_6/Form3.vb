Imports MySqlConnector

Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Renderer = New DarkMenuRenderer()
        TampilData()
        Kosong()
    End Sub

    ' ===================== HELPER =====================

    Private Sub Kosong()
        txtKodeFilm.Clear()
        txtJudul.Clear()
        cmbGenre.SelectedIndex = -1
        txtTahun.Clear()
        txtSutradara.Clear()
        nudRating.Value = 7
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKodeFilm.Focus()
    End Sub

    Private Sub TampilData()
        dgvFilm.DataSource = GetAllFilm()
    End Sub

    ' ===================== DATABASE CALLS =====================

    Private Function GetAllFilm() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeFilm AS 'Kode', judulFilm AS 'Judul Film', genre AS 'Genre', tahunRilis AS 'Tahun', sutradara AS 'Sutradara', rating AS 'Rating' FROM tbfilm ORDER BY kodeFilm ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Private Function SearchFilm(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodeFilm AS 'Kode', judulFilm AS 'Judul Film', genre AS 'Genre', tahunRilis AS 'Tahun', sutradara AS 'Sutradara', rating AS 'Rating' " &
                "FROM tbfilm WHERE kodeFilm LIKE @kw OR judulFilm LIKE @kw OR genre LIKE @kw OR sutradara LIKE @kw ORDER BY kodeFilm ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Private Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbfilm WHERE kodeFilm = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Private Function SimpanFilm(kode As String, judul As String, genre As String, tahun As String, sutradara As String, rating As Decimal) As Boolean
        Try
            Dim query As String = "INSERT INTO tbfilm (kodeFilm, judulFilm, genre, tahunRilis, sutradara, rating) VALUES (@kode, @judul, @genre, @tahun, @sutradara, @rating)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@tahun", tahun)
                    cmd.Parameters.AddWithValue("@sutradara", sutradara)
                    cmd.Parameters.AddWithValue("@rating", rating)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function UbahFilm(kode As String, judul As String, genre As String, tahun As String, sutradara As String, rating As Decimal) As Boolean
        Try
            Dim query As String = "UPDATE tbfilm SET judulFilm=@judul, genre=@genre, tahunRilis=@tahun, sutradara=@sutradara, rating=@rating WHERE kodeFilm=@kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@tahun", tahun)
                    cmd.Parameters.AddWithValue("@sutradara", sutradara)
                    cmd.Parameters.AddWithValue("@rating", rating)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function HapusFilm(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbfilm WHERE kodeFilm = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ===================== VALIDASI =====================

    Private Function ValidasiInput() As Boolean
        Dim valid As Boolean = True
        ErrorProvider1.Clear()

        If txtKodeFilm.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtKodeFilm, "Kode Film tidak boleh kosong")
            valid = False
        End If
        If txtJudul.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtJudul, "Judul Film tidak boleh kosong")
            valid = False
        End If
        If cmbGenre.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cmbGenre, "Pilih genre film")
            valid = False
        End If
        If txtTahun.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtTahun, "Tahun Rilis tidak boleh kosong")
            valid = False
        Else
            Dim thn As Integer
            If Not Integer.TryParse(txtTahun.Text.Trim(), thn) OrElse thn < 1888 OrElse thn > 2100 Then
                ErrorProvider1.SetError(txtTahun, "Tahun tidak valid (1888 - 2100)")
                valid = False
            End If
        End If
        If txtSutradara.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtSutradara, "Nama sutradara tidak boleh kosong")
            valid = False
        End If

        Return valid
    End Function

    ' ===================== BUTTON EVENTS =====================

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput() Then Exit Sub

        Dim kode As String = txtKodeFilm.Text.Trim().ToUpper()
        If KodeSudahAda(kode) Then
            MessageBox.Show("Kode Film sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeFilm.Focus()
            Exit Sub
        End If

        If SimpanFilm(kode, txtJudul.Text.Trim(), cmbGenre.SelectedItem.ToString(),
                      txtTahun.Text.Trim(), txtSutradara.Text.Trim(), nudRating.Value) Then
            MessageBox.Show("Film berhasil disimpan! 🎬", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Not ValidasiInput() Then Exit Sub

        Dim kode As String = txtKodeFilm.Text.Trim().ToUpper()
        If UbahFilm(kode, txtJudul.Text.Trim(), cmbGenre.SelectedItem.ToString(),
                    txtTahun.Text.Trim(), txtSutradara.Text.Trim(), nudRating.Value) Then
            MessageBox.Show("Data film berhasil diubah! ✏", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeFilm.Text.Trim() = "" Then
            MessageBox.Show("Pilih data film yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeFilm.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show(
            "Hapus film """ & txtJudul.Text & """?" & vbNewLine & "Data yang dihapus tidak bisa dikembalikan.",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If hasil = DialogResult.Yes Then
            If HapusFilm(txtKodeFilm.Text.Trim().ToUpper()) Then
                MessageBox.Show("Film berhasil dihapus.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    ' ===================== DATAGRIDVIEW CLICK =====================

    Private Sub dgvFilm_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFilm.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvFilm.Rows(e.RowIndex)
            txtKodeFilm.Text = row.Cells("Kode").Value.ToString()
            txtJudul.Text = row.Cells("Judul Film").Value.ToString()

            Dim genreVal As String = row.Cells("Genre").Value.ToString()
            Dim idx As Integer = cmbGenre.Items.IndexOf(genreVal)
            If idx >= 0 Then cmbGenre.SelectedIndex = idx Else cmbGenre.SelectedIndex = -1

            txtTahun.Text = row.Cells("Tahun").Value.ToString()
            txtSutradara.Text = row.Cells("Sutradara").Value.ToString()

            Dim ratingVal As Decimal
            If Decimal.TryParse(row.Cells("Rating").Value.ToString(), ratingVal) Then
                nudRating.Value = ratingVal
            End If
        End If
    End Sub

    ' ===================== SEARCH =====================

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvFilm.DataSource = SearchFilm(txtSearch.Text.Trim())
        End If
    End Sub

    ' ===================== KEY VALIDATION =====================

    Private Sub txtTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTahun.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKodeFilm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeFilm.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
            txtJudul.Focus()
        End If
    End Sub

    ' ===================== MENU NAVIGATION =====================

    Private Sub tsmiMenuUtama_Click(sender As Object, e As EventArgs) Handles tsmiMenuUtama.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub tsmiKeluar_Click(sender As Object, e As EventArgs) Handles tsmiKeluar.Click
        Dim hasil As DialogResult = MessageBox.Show(
            "Apakah Anda yakin ingin keluar?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If hasil = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class