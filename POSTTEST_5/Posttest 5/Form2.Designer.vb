<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiKoleksiFilm = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiTentang = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlWelcome = New System.Windows.Forms.Panel()
        Me.lblWelcomeIcon = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblWelcomeSub = New System.Windows.Forms.Label()
        Me.btnMulai = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlWelcome.SuspendLayout()
        Me.SuspendLayout()

        ' MenuStrip1
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(30, 30, 47)
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.5, System.Drawing.FontStyle.Regular)
        Me.MenuStrip1.ForeColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiTentang})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(700, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"


        ' tsmiFile
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiKoleksiFilm, Me.tsmiSeparator1, Me.tsmiKeluar})
        Me.tsmiFile.ForeColor = System.Drawing.Color.White
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(60, 24)
        Me.tsmiFile.Text = "  Menu  "

        ' tsmiKoleksiFilm
        Me.tsmiKoleksiFilm.Name = "tsmiKoleksiFilm"
        Me.tsmiKoleksiFilm.Size = New System.Drawing.Size(200, 24)
        Me.tsmiKoleksiFilm.Text = "🎬  Koleksi Film"

        ' tsmiSeparator1
        Me.tsmiSeparator1.Name = "tsmiSeparator1"
        Me.tsmiSeparator1.Size = New System.Drawing.Size(197, 6)

        ' tsmiKeluar
        Me.tsmiKeluar.Name = "tsmiKeluar"
        Me.tsmiKeluar.Size = New System.Drawing.Size(200, 24)
        Me.tsmiKeluar.Text = "🚪  Keluar"

        ' tsmiTentang
        Me.tsmiTentang.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiInfo})
        Me.tsmiTentang.ForeColor = System.Drawing.Color.White
        Me.tsmiTentang.Name = "tsmiTentang"
        Me.tsmiTentang.Size = New System.Drawing.Size(70, 24)
        Me.tsmiTentang.Text = "  Tentang  "

        ' tsmiInfo
        Me.tsmiInfo.Name = "tsmiInfo"
        Me.tsmiInfo.Size = New System.Drawing.Size(200, 24)
        Me.tsmiInfo.Text = "ℹ  Informasi Aplikasi"

        ' pnlWelcome
        Me.pnlWelcome.BackColor = System.Drawing.Color.FromArgb(20, 20, 35)
        Me.pnlWelcome.Controls.Add(Me.lblWelcomeIcon)
        Me.pnlWelcome.Controls.Add(Me.lblWelcome)
        Me.pnlWelcome.Controls.Add(Me.lblWelcomeSub)
        Me.pnlWelcome.Controls.Add(Me.btnMulai)
        Me.pnlWelcome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWelcome.Location = New System.Drawing.Point(0, 30)
        Me.pnlWelcome.Name = "pnlWelcome"
        Me.pnlWelcome.Size = New System.Drawing.Size(700, 470)
        Me.pnlWelcome.TabIndex = 1

        ' lblWelcomeIcon
        Me.lblWelcomeIcon.AutoSize = False
        Me.lblWelcomeIcon.Font = New System.Drawing.Font("Segoe UI", 55)
        Me.lblWelcomeIcon.ForeColor = System.Drawing.Color.FromArgb(229, 9, 20)
        Me.lblWelcomeIcon.Location = New System.Drawing.Point(0, 70)
        Me.lblWelcomeIcon.Name = "lblWelcomeIcon"
        Me.lblWelcomeIcon.Size = New System.Drawing.Size(700, 120)
        Me.lblWelcomeIcon.TabIndex = 0
        Me.lblWelcomeIcon.Text = "🎬"
        Me.lblWelcomeIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' lblWelcome
        Me.lblWelcome.AutoSize = False
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 22, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(0, 195)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(700, 50)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Selamat Datang di CineVault"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' lblWelcomeSub
        Me.lblWelcomeSub.AutoSize = False
        Me.lblWelcomeSub.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.lblWelcomeSub.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
        Me.lblWelcomeSub.Location = New System.Drawing.Point(0, 250)
        Me.lblWelcomeSub.Name = "lblWelcomeSub"
        Me.lblWelcomeSub.Size = New System.Drawing.Size(700, 30)
        Me.lblWelcomeSub.TabIndex = 2
        Me.lblWelcomeSub.Text = "Kelola dan simpan koleksi film favorit Anda"
        Me.lblWelcomeSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' btnMulai
        Me.btnMulai.BackColor = System.Drawing.Color.FromArgb(229, 9, 20)
        Me.btnMulai.FlatAppearance.BorderSize = 0
        Me.btnMulai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMulai.Font = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold)
        Me.btnMulai.ForeColor = System.Drawing.Color.White
        Me.btnMulai.Location = New System.Drawing.Point(250, 310)
        Me.btnMulai.Name = "btnMulai"
        Me.btnMulai.Size = New System.Drawing.Size(200, 45)
        Me.btnMulai.TabIndex = 3
        Me.btnMulai.Text = "Lihat Koleksi Film"
        Me.btnMulai.UseVisualStyleBackColor = False
        Me.btnMulai.Cursor = System.Windows.Forms.Cursors.Hand

        ' Form2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(20, 20, 35)
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.Controls.Add(Me.pnlWelcome)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CineVault - Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlWelcome.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiKoleksiFilm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTentang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlWelcome As System.Windows.Forms.Panel
    Friend WithEvents lblWelcomeIcon As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblWelcomeSub As System.Windows.Forms.Label
    Friend WithEvents btnMulai As System.Windows.Forms.Button
End Class