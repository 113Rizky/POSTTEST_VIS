Imports System.IO

Public Class FormInput

    Dim fotoPath As String = ""

    Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.SelectedTab = tabDataUtama

        cmbKomunitas.Items.Clear()
        cmbKomunitas.Items.Add("Programming")
        cmbKomunitas.Items.Add("Design")
        cmbKomunitas.Items.Add("Gaming")
        cmbKomunitas.Items.Add("Multimedia")
        cmbKomunitas.Items.Add("Networking")

        mtbNoHP.Mask = "0000-0000-0000"
    End Sub

    Private Sub btnKeTabKontak_Click(sender As Object, e As EventArgs) Handles btnKeTabKontak.Click
        TabControl1.SelectedTab = tabKontakInfo
    End Sub

    Private Sub btnKembaliKeTabUtama_Click(sender As Object, e As EventArgs) Handles btnKembaliKeTabUtama.Click
        TabControl1.SelectedTab = tabDataUtama
    End Sub

    Private Sub btnKeTabProfil_Click(sender As Object, e As EventArgs) Handles btnKeTabProfil.Click
        TabControl1.SelectedTab = tabProfilAktivitas
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image File|*.jpg;*.jpeg;*.png"
        OpenFileDialog1.Title = "Pilih Foto Profil"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            fotoPath = OpenFileDialog1.FileName
            picFoto.Image = Image.FromFile(fotoPath)
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtIDAnggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDAnggota.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub mtbNoHP_Leave(sender As Object, e As EventArgs) Handles mtbNoHP.Leave
        If Not mtbNoHP.MaskCompleted Then
            ErrorProvider1.SetError(mtbNoHP, "Nomor HP harus lengkap")
        Else
            ErrorProvider1.SetError(mtbNoHP, "")
        End If
    End Sub

    Private Function ValidasiInput() As Boolean
        ErrorProvider1.Clear()

        If txtNama.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong")
            Return False
        End If

        If txtIDAnggota.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtIDAnggota, "Inputan tidak boleh kosong")
            Return False
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If cmbKomunitas.Text.Trim() = "" Then
            ErrorProvider1.SetError(cmbKomunitas, "Inputan tidak boleh kosong")
            Return False
        End If

        If Not mtbNoHP.MaskCompleted Then
            ErrorProvider1.SetError(mtbNoHP, "Inputan tidak boleh kosong")
            Return False
        End If

        If txtEmail.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtEmail, "Inputan tidak boleh kosong")
            Return False
        End If

        If txtAlamat.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtAlamat, "Inputan tidak boleh kosong")
            Return False
        End If

        If picFoto.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not rbKetua.Checked And Not rbAnggota.Checked And Not rbAdmin.Checked And Not rbKoordinator.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not chkDesain.Checked And Not chkNgoding.Checked And Not chkMenulis.Checked And Not chkPublicSpeaking.Checked And
           Not chkFotografi.Checked And Not chkEditing.Checked And Not chkRelawan.Checked And Not chkEvent.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function AmbilPeran() As String
        If rbKetua.Checked Then
            Return "Ketua"
        ElseIf rbAnggota.Checked Then
            Return "Anggota"
        ElseIf rbAdmin.Checked Then
            Return "Admin"
        ElseIf rbKoordinator.Checked Then
            Return "Koordinator"
        Else
            Return ""
        End If
    End Function

    Private Function AmbilHobi() As String
        Dim hasil As String = ""

        If chkDesain.Checked Then hasil &= "Desain, "
        If chkNgoding.Checked Then hasil &= "Ngoding, "
        If chkMenulis.Checked Then hasil &= "Menulis, "
        If chkPublicSpeaking.Checked Then hasil &= "Public Speaking, "
        If chkFotografi.Checked Then hasil &= "Fotografi, "
        If chkEditing.Checked Then hasil &= "Editing, "
        If chkRelawan.Checked Then hasil &= "Relawan, "
        If chkEvent.Checked Then hasil &= "Event, "

        If hasil <> "" Then
            hasil = hasil.Substring(0, hasil.Length - 2)
        End If

        Return hasil
    End Function

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If ValidasiInput() = False Then Exit Sub

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin dicetak ke kartu?", "Konfirmasi Cetak", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            Dim frm As New FormKartu

            frm.lblNama.Text = txtNama.Text
            frm.lblID.Text = txtIDAnggota.Text
            frm.lblKomunitas.Text = cmbKomunitas.Text
            frm.lblKontak.Text = mtbNoHP.Text & " / " & txtEmail.Text
            frm.lblHobi.Text = AmbilHobi()

            If picFoto.Image IsNot Nothing Then
                frm.picKartu.Image = picFoto.Image
            End If

            frm.Show()

        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Data tidak dicetak")

        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Proses dibatalkan")
        End If
    End Sub

    Public Sub SimpanDataKeFile()
        If ValidasiInput() = False Then
            Exit Sub
        End If

        Dim hasil As DialogResult
        hasil = MessageBox.Show("Apakah data ingin disimpan?", "Konfirmasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
            SaveFileDialog1.Title = "Simpan Data"

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim isi As String = ""
                isi &= "Nama: " & txtNama.Text & Environment.NewLine
                isi &= "ID Anggota: " & txtIDAnggota.Text & Environment.NewLine
                isi &= "Tanggal Lahir: " & dtpTanggalLahir.Value.ToShortDateString() & Environment.NewLine
                isi &= "Jenis Kelamin: " & If(rbLaki.Checked, "Laki-laki", "Perempuan") & Environment.NewLine
                isi &= "Komunitas: " & cmbKomunitas.Text & Environment.NewLine
                isi &= "No HP: " & mtbNoHP.Text & Environment.NewLine
                isi &= "Email: " & txtEmail.Text & Environment.NewLine
                isi &= "Alamat: " & txtAlamat.Text & Environment.NewLine
                isi &= "Peran: " & AmbilPeran() & Environment.NewLine
                isi &= "Aktivitas: " & AmbilHobi()

                File.WriteAllText(SaveFileDialog1.FileName, isi)
                MessageBox.Show("File berhasil disimpan")
            End If
        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Data tidak disimpan")
        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Proses dibatalkan")
        End If
    End Sub

    Public Sub BukaDataDariFile()
        OpenFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        OpenFileDialog1.Title = "Buka Data"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim isi As String = File.ReadAllText(OpenFileDialog1.FileName)
            MessageBox.Show(isi, "Isi File")
        End If
    End Sub

End Class