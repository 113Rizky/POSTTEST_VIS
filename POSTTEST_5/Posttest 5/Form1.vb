Public Class Form1

    ' Kredensial login hardcoded (tidak perlu registrasi)
    Private Const VALID_USERNAME As String = "Rizky"
    Private Const VALID_PASSWORD As String = "113"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ProsesLogin()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
            ProsesLogin()
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
            txtPassword.Focus()
        End If
    End Sub

    Private Sub ProsesLogin()
        Dim user As String = txtUsername.Text.Trim()
        Dim pass As String = txtPassword.Text

        If user = "" OrElse pass = "" Then
            TampilkanError("Username dan password tidak boleh kosong!")
            Return
        End If

        If user = VALID_USERNAME AndAlso pass = VALID_PASSWORD Then
            lblError.Visible = False
            Dim formMenu As New Form2()
            formMenu.Show()
            Me.Hide()
        Else
            TampilkanError("Username atau password salah!")
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub

    Private Sub TampilkanError(pesan As String)
        lblError.Text = "⚠  " & pesan
        lblError.Visible = True
    End Sub

End Class