Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Renderer = New DarkMenuRenderer()
    End Sub

    Private Sub tsmiKoleksiFilm_Click(sender As Object, e As EventArgs) Handles tsmiKoleksiFilm.Click
        BukaFormFilm()
    End Sub

    Private Sub tsmiUlasanFilm_Click(sender As Object, e As EventArgs) Handles tsmiUlasanFilm.Click
        BukaFormUlasan()
    End Sub

    Private Sub btnMulai_Click(sender As Object, e As EventArgs) Handles btnMulai.Click
        BukaFormFilm()
    End Sub

    Private Sub btnUlasan_Click(sender As Object, e As EventArgs) Handles btnUlasan.Click
        BukaFormUlasan()
    End Sub

    Private Sub BukaFormFilm()
        Dim formFilm As New Form3()
        formFilm.Show()
        Me.Hide()
    End Sub

    Private Sub BukaFormUlasan()
        Dim formUlasan As New Form4()
        formUlasan.Show()
        Me.Hide()
    End Sub

    Private Sub tsmiKeluar_Click(sender As Object, e As EventArgs) Handles tsmiKeluar.Click
        Dim hasil As DialogResult
        hasil = MessageBox.Show(
            "Apakah Anda yakin ingin keluar?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub tsmiInfo_Click(sender As Object, e As EventArgs) Handles tsmiInfo.Click
        MessageBox.Show(
            "CineVault - Manajemen Koleksi Film Favorit" & vbNewLine &
            "━━━━━━━━━━━━━━━━━━━━━━━━━━━" & vbNewLine &
            "Versi : 2.0" & vbNewLine &
            "Platform : VB.NET Windows Forms" & vbNewLine &
            "Database : MySQL (dbcinevault)" & vbNewLine & vbNewLine &
            "Fitur:" & vbNewLine &
            "  ✓ Tambah / Ubah / Hapus koleksi film" & vbNewLine &
            "  ✓ Cari film" & vbNewLine &
            "  ✓ Tambah / Ubah / Hapus ulasan film" & vbNewLine &
            "  ✓ Cari ulasan" & vbNewLine &
            "  ✓ Relasi tabel film ↔ ulasan (Foreign Key)",
            "Informasi Aplikasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class