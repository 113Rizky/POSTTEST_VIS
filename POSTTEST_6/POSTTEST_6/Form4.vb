Imports MySqlConnector

Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Renderer = New DarkMenuRenderer()
        MuatComboFilm()
        TampilData()
        Kosong()
    End Sub

    ' ===================== HELPER =====================

    Private Sub MuatComboFilm()
        Try
            Dim dt As New DataTable()
            Dim query As String = "SELECT kodeFilm, judulFilm FROM tbfilm ORDER BY judulFilm ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
            cmbFilm.DataSource = dt
            cmbFilm.DisplayMember = "judulFilm"
            cmbFilm.ValueMember = "kodeFilm"
            cmbFilm.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data film: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Kosong()
        txtKodeUlasan.Clear()
        cmbFilm.SelectedIndex = -1
        txtReviewer.Clear()
        txtIsiUlasan.Clear()
        nudNilai.Value = 7
        dtpTanggal.Value = DateTime.Today
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKodeUlasan.Focus()
    End Sub

    Private Sub TampilData()
        dgvUlasan.DataSource = GetAllUlasan()
    End Sub

    ' ===================== DATABASE CALLS =====================

    Private Function GetAllUlasan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT u.kodeUlasan AS 'Kode', f.judulFilm AS 'Judul Film', " &
                "u.namaReviewer AS 'Reviewer', u.isiUlasan AS 'Ulasan', " &
                "u.nilaiUlasan AS 'Nilai', u.tanggal AS 'Tanggal' " &
                "FROM tbulasan u " &
                "INNER JOIN tbfilm f ON u.kodeFilm = f.kodeFilm " &
                "ORDER BY u.tanggal DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan ulasan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Private Function SearchUlasan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT u.kodeUlasan AS 'Kode', f.judulFilm AS 'Judul Film', " &
                "u.namaReviewer AS 'Reviewer', u.isiUlasan AS 'Ulasan', " &
                "u.nilaiUlasan AS 'Nilai', u.tanggal AS 'Tanggal' " &
                "FROM tbulasan u " &
                "INNER JOIN tbfilm f ON u.kodeFilm = f.kodeFilm " &
                "WHERE f.judulFilm LIKE @kw OR u.namaReviewer LIKE @kw OR u.isiUlasan LIKE @kw " &
                "ORDER BY u.tanggal DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari ulasan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Private Function KodeUlasanSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbulasan WHERE kodeUlasan = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Private Function SimpanUlasan(kode As String, kodeFilm As String, reviewer As String,
                                   isi As String, nilai As Decimal, tgl As Date) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbulasan (kodeUlasan, kodeFilm, namaReviewer, isiUlasan, nilaiUlasan, tanggal) " &
                "VALUES (@kode, @kodeFilm, @reviewer, @isi, @nilai, @tgl)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@kodeFilm", kodeFilm)
                    cmd.Parameters.AddWithValue("@reviewer", reviewer)
                    cmd.Parameters.AddWithValue("@isi", isi)
                    cmd.Parameters.AddWithValue("@nilai", nilai)
                    cmd.Parameters.AddWithValue("@tgl", tgl.ToString("yyyy-MM-dd"))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan ulasan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function UbahUlasan(kode As String, kodeFilm As String, reviewer As String,
                                 isi As String, nilai As Decimal, tgl As Date) As Boolean
        Try
            Dim query As String =
                "UPDATE tbulasan SET kodeFilm=@kodeFilm, namaReviewer=@reviewer, " &
                "isiUlasan=@isi, nilaiUlasan=@nilai, tanggal=@tgl WHERE kodeUlasan=@kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@kodeFilm", kodeFilm)
                    cmd.Parameters.AddWithValue("@reviewer", reviewer)
                    cmd.Parameters.AddWithValue("@isi", isi)
                    cmd.Parameters.AddWithValue("@nilai", nilai)
                    cmd.Parameters.AddWithValue("@tgl", tgl.ToString("yyyy-MM-dd"))
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah ulasan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function HapusUlasan(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbulasan WHERE kodeUlasan = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus ulasan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ===================== VALIDASI =====================

    Private Function ValidasiInput() As Boolean
        Dim valid As Boolean = True
        ErrorProvider1.Clear()

        If txtKodeUlasan.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtKodeUlasan, "Kode Ulasan tidak boleh kosong")
            valid = False
        End If
        If cmbFilm.SelectedIndex = -1 Then
            ErrorProvider1.SetError(cmbFilm, "Pilih film yang diulas")
            valid = False
        End If
        If txtReviewer.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtReviewer, "Nama reviewer tidak boleh kosong")
            valid = False
        End If
        If txtIsiUlasan.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtIsiUlasan, "Isi ulasan tidak boleh kosong")
            valid = False
        End If

        Return valid
    End Function

    ' ===================== BUTTON EVENTS =====================

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput() Then Exit Sub

        Dim kode As String = txtKodeUlasan.Text.Trim().ToUpper()
        If KodeUlasanSudahAda(kode) Then
            MessageBox.Show("Kode Ulasan sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeUlasan.Focus()
            Exit Sub
        End If

        Dim kodeFilm As String = cmbFilm.SelectedValue.ToString()
        If SimpanUlasan(kode, kodeFilm, txtReviewer.Text.Trim(),
                        txtIsiUlasan.Text.Trim(), nudNilai.Value, dtpTanggal.Value) Then
            MessageBox.Show("Ulasan berhasil disimpan! ⭐", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Not ValidasiInput() Then Exit Sub

        Dim kode As String = txtKodeUlasan.Text.Trim().ToUpper()
        Dim kodeFilm As String = cmbFilm.SelectedValue.ToString()
        If UbahUlasan(kode, kodeFilm, txtReviewer.Text.Trim(),
                      txtIsiUlasan.Text.Trim(), nudNilai.Value, dtpTanggal.Value) Then
            MessageBox.Show("Ulasan berhasil diubah! ✏", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeUlasan.Text.Trim() = "" Then
            MessageBox.Show("Pilih ulasan yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show(
            "Hapus ulasan ini?" & vbNewLine & "Data yang dihapus tidak bisa dikembalikan.",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If hasil = DialogResult.Yes Then
            If HapusUlasan(txtKodeUlasan.Text.Trim().ToUpper()) Then
                MessageBox.Show("Ulasan berhasil dihapus.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub dgvUlasan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUlasan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUlasan.Rows(e.RowIndex)
            txtKodeUlasan.Text = row.Cells("Kode").Value.ToString()

            ' Set ComboBox berdasarkan judul film
            Dim judulFilm As String = row.Cells("Judul Film").Value.ToString()
            For i As Integer = 0 To cmbFilm.Items.Count - 1
                Dim drv As DataRowView = CType(cmbFilm.Items(i), DataRowView)
                If drv("judulFilm").ToString() = judulFilm Then
                    cmbFilm.SelectedIndex = i
                    Exit For
                End If
            Next

            txtReviewer.Text = row.Cells("Reviewer").Value.ToString()
            txtIsiUlasan.Text = row.Cells("Ulasan").Value.ToString()

            Dim nilaiVal As Decimal
            If Decimal.TryParse(row.Cells("Nilai").Value.ToString(), nilaiVal) Then
                nudNilai.Value = nilaiVal
            End If

            Dim tglVal As Date
            If Date.TryParse(row.Cells("Tanggal").Value.ToString(), tglVal) Then
                dtpTanggal.Value = tglVal
            End If
        End If
    End Sub

    ' ===================== SEARCH =====================

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvUlasan.DataSource = SearchUlasan(txtSearch.Text.Trim())
        End If
    End Sub

    ' ===================== MENU NAVIGATION =====================

    Private Sub tsmiMenuUtama_Click(sender As Object, e As EventArgs) Handles tsmiMenuUtama.Click
        Dim f As New Form2()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub tsmiKoleksiFilm_Click(sender As Object, e As EventArgs) Handles tsmiKoleksiFilm.Click
        Dim f As New Form3()
        f.Show()
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

    Private Sub Form4_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class