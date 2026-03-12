Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggalLahir.Format = DateTimePickerFormat.Custom
        dtpTanggalLahir.CustomFormat = "dd/MM/yyyy"

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(sender, e)
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Foto"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Function AmbilHobby() As String
        Dim hobby As String = ""

        For Each ctrl As Control In gbHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    hobby &= ctrl.Text & ", "
                End If
            End If
        Next

        If hobby.EndsWith(", ") Then
            hobby = hobby.Substring(0, hobby.Length - 2)
        End If

        Return hobby
    End Function

    Private Function AdaHobbyDipilih() As Boolean
        For Each ctrl As Control In gbHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    Return True
                End If
            End If
        Next

        Return False
    End Function

    Private Function ValidasiInput() As Boolean
        If txtNama.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return False
        End If

        If txtUmur.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUmur.Focus()
            Return False
        End If

        If txtTelepon.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelepon.Focus()
            Return False
        End If

        If txtAlamat.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAlamat.Focus()
            Return False
        End If

        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not AdaHobbyDipilih() Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If Not ValidasiInput() Then
            Exit Sub
        End If

        Dim jenisKelamin As String = ""

        If rbLaki.Checked Then
            jenisKelamin = "Laki-Laki"
        ElseIf rbPerempuan.Checked Then
            jenisKelamin = "Perempuan"
        End If

        Dim frm As New FormHasil

        frm.lblNama.Text = txtNama.Text
        frm.lblUmur.Text = txtUmur.Text
        frm.lblTanggal.Text = dtpTanggalLahir.Text
        frm.lblJK.Text = jenisKelamin
        frm.lblTelepon.Text = txtTelepon.Text
        frm.lblHobby.Text = AmbilHobby()
        frm.lblAlamat.Text = txtAlamat.Text

        If PictureBox1.Image IsNot Nothing Then
            frm.PictureBox1.Image = PictureBox1.Image
            frm.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        frm.Show()
    End Sub

End Class