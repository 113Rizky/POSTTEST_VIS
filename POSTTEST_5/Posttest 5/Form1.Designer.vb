<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlLogin = New Panel()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        lblError = New Label()
        lblTitle = New Label()
        lblSubtitle = New Label()
        pnlHeader = New Panel()
        lblFilmIcon = New Label()
        pnlLogin.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLogin
        ' 
        pnlLogin.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(35))
        pnlLogin.Controls.Add(lblUsername)
        pnlLogin.Controls.Add(txtUsername)
        pnlLogin.Controls.Add(lblPassword)
        pnlLogin.Controls.Add(txtPassword)
        pnlLogin.Controls.Add(btnLogin)
        pnlLogin.Controls.Add(lblError)
        pnlLogin.Dock = DockStyle.Fill
        pnlLogin.Location = New Point(0, 162)
        pnlLogin.Margin = New Padding(3, 4, 3, 4)
        pnlLogin.Name = "pnlLogin"
        pnlLogin.Padding = New Padding(30, 25, 30, 25)
        pnlLogin.Size = New Size(632, 338)
        pnlLogin.TabIndex = 1
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        lblUsername.Location = New Point(35, 38)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(80, 20)
        lblUsername.TabIndex = 0
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(60))
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 10.0F)
        txtUsername.ForeColor = Color.White
        txtUsername.Location = New Point(35, 65)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(348, 30)
        txtUsername.TabIndex = 1
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        lblPassword.Location = New Point(35, 119)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(76, 20)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(60))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 10.0F)
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(35, 146)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "●"c
        txtPassword.Size = New Size(348, 30)
        txtPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(229), CByte(9), CByte(20))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(35, 202)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(348, 52)
        btnLogin.TabIndex = 4
        btnLogin.Text = "MASUK"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblError
        ' 
        lblError.AutoSize = True
        lblError.Font = New Font("Segoe UI", 9.0F)
        lblError.ForeColor = Color.FromArgb(CByte(229), CByte(9), CByte(20))
        lblError.Location = New Point(35, 269)
        lblError.Name = "lblError"
        lblError.Size = New Size(0, 20)
        lblError.TabIndex = 5
        lblError.Visible = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(137, 38)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(153, 41)
        lblTitle.TabIndex = 0
        lblTitle.Text = "CineVault"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 9.0F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(180))
        lblSubtitle.Location = New Point(137, 79)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(175, 20)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Koleksi Film Favorit Anda"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(47))
        pnlHeader.Controls.Add(lblFilmIcon)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(632, 162)
        pnlHeader.TabIndex = 0
        ' 
        ' lblFilmIcon
        ' 
        lblFilmIcon.AutoSize = True
        lblFilmIcon.Font = New Font("Segoe UI", 30.0F)
        lblFilmIcon.ForeColor = Color.FromArgb(CByte(229), CByte(9), CByte(20))
        lblFilmIcon.Location = New Point(17, 32)
        lblFilmIcon.Name = "lblFilmIcon"
        lblFilmIcon.Size = New Size(98, 67)
        lblFilmIcon.TabIndex = 2
        lblFilmIcon.Text = "🎬"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(35))
        ClientSize = New Size(632, 500)
        Controls.Add(pnlLogin)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CineVault - Login"
        pnlLogin.ResumeLayout(False)
        pnlLogin.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLogin As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblFilmIcon As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
End Class