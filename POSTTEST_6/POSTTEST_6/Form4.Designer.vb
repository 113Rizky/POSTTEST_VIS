<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.tsmiNavigasi = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMenuUtama = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiKoleksiFilm = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSep = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblKodeUlasan = New System.Windows.Forms.Label()
        Me.txtKodeUlasan = New System.Windows.Forms.TextBox()
        Me.lblFilm = New System.Windows.Forms.Label()
        Me.cmbFilm = New System.Windows.Forms.ComboBox()
        Me.lblReviewer = New System.Windows.Forms.Label()
        Me.txtReviewer = New System.Windows.Forms.TextBox()
        Me.lblIsiUlasan = New System.Windows.Forms.Label()
        Me.txtIsiUlasan = New System.Windows.Forms.TextBox()
        Me.lblNilai = New System.Windows.Forms.Label()
        Me.nudNilai = New System.Windows.Forms.NumericUpDown()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.dgvUlasan = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        CType(Me.dgvUlasan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' MenuStrip1
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(30, 30, 47)
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.5)
        Me.MenuStrip1.ForeColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNavigasi})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1050, 30)
        Me.MenuStrip1.TabIndex = 0

        ' tsmiNavigasi
        Me.tsmiNavigasi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMenuUtama, Me.tsmiKoleksiFilm, Me.tsmiSep, Me.tsmiKeluar})
        Me.tsmiNavigasi.ForeColor = System.Drawing.Color.White
        Me.tsmiNavigasi.Name = "tsmiNavigasi"
        Me.tsmiNavigasi.Text = "  Navigasi  "

        ' tsmiMenuUtama
        Me.tsmiMenuUtama.Name = "tsmiMenuUtama"
        Me.tsmiMenuUtama.Text = "🏠  Menu Utama"

        ' tsmiKoleksiFilm
        Me.tsmiKoleksiFilm.Name = "tsmiKoleksiFilm"
        Me.tsmiKoleksiFilm.Text = "🎬  Koleksi Film"

        ' tsmiSep
        Me.tsmiSep.Name = "tsmiSep"

        ' tsmiKeluar
        Me.tsmiKeluar.Name = "tsmiKeluar"
        Me.tsmiKeluar.Text = "🚪  Keluar"

        ' pnlTop
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(30, 30, 47)
        Me.pnlTop.Controls.Add(Me.lblFormTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 30)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1050, 50)
        Me.pnlTop.TabIndex = 1

        ' lblFormTitle
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 13, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.White
        Me.lblFormTitle.Location = New System.Drawing.Point(15, 13)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Text = "⭐  Ulasan Film"

        ' pnlInput
        Me.pnlInput.BackColor = System.Drawing.Color.FromArgb(25, 25, 40)
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInput.Controls.Add(Me.lblKodeUlasan)
        Me.pnlInput.Controls.Add(Me.txtKodeUlasan)
        Me.pnlInput.Controls.Add(Me.lblFilm)
        Me.pnlInput.Controls.Add(Me.cmbFilm)
        Me.pnlInput.Controls.Add(Me.lblReviewer)
        Me.pnlInput.Controls.Add(Me.txtReviewer)
        Me.pnlInput.Controls.Add(Me.lblIsiUlasan)
        Me.pnlInput.Controls.Add(Me.txtIsiUlasan)
        Me.pnlInput.Controls.Add(Me.lblNilai)
        Me.pnlInput.Controls.Add(Me.nudNilai)
        Me.pnlInput.Controls.Add(Me.lblTanggal)
        Me.pnlInput.Controls.Add(Me.dtpTanggal)
        Me.pnlInput.Controls.Add(Me.lblCari)
        Me.pnlInput.Controls.Add(Me.txtSearch)
        Me.pnlInput.Location = New System.Drawing.Point(12, 90)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(340, 520)
        Me.pnlInput.TabIndex = 2

        ' lblKodeUlasan
        Me.lblKodeUlasan.AutoSize = True
        Me.lblKodeUlasan.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblKodeUlasan.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.lblKodeUlasan.Location = New System.Drawing.Point(12, 15)
        Me.lblKodeUlasan.Name = "lblKodeUlasan"
        Me.lblKodeUlasan.Text = "Kode Ulasan"

        Me.txtKodeUlasan.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.txtKodeUlasan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKodeUlasan.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtKodeUlasan.ForeColor = System.Drawing.Color.White
        Me.txtKodeUlasan.Location = New System.Drawing.Point(12, 35)
        Me.txtKodeUlasan.Name = "txtKodeUlasan"
        Me.txtKodeUlasan.Size = New System.Drawing.Size(314, 27)
        Me.txtKodeUlasan.MaxLength = 10
        Me.txtKodeUlasan.PlaceholderText = "contoh: U001"

        ' lblFilm
        Me.lblFilm.AutoSize = True
        Me.lblFilm.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblFilm.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.lblFilm.Location = New System.Drawing.Point(12, 75)
        Me.lblFilm.Name = "lblFilm"
        Me.lblFilm.Text = "Film"

        Me.cmbFilm.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.cmbFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFilm.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.cmbFilm.ForeColor = System.Drawing.Color.White
        Me.cmbFilm.FormattingEnabled = True
        Me.cmbFilm.Location = New System.Drawing.Point(12, 95)
        Me.cmbFilm.Name = "cmbFilm"
        Me.cmbFilm.Size = New System.Drawing.Size(314, 28)
        Me.cmbFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList

        ' lblReviewer
        Me.lblReviewer.AutoSize = True
        Me.lblReviewer.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblReviewer.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.lblReviewer.Location = New System.Drawing.Point(12, 137)
        Me.lblReviewer.Name = "lblReviewer"
        Me.lblReviewer.Text = "Nama Reviewer"

        Me.txtReviewer.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.txtReviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReviewer.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtReviewer.ForeColor = System.Drawing.Color.White
        Me.txtReviewer.Location = New System.Drawing.Point(12, 157)
        Me.txtReviewer.Name = "txtReviewer"
        Me.txtReviewer.Size = New System.Drawing.Size(314, 27)
        Me.txtReviewer.MaxLength = 50
        Me.txtReviewer.PlaceholderText = "Nama lengkap reviewer"

        ' lblIsiUlasan
        Me.lblIsiUlasan.AutoSize = True
        Me.lblIsiUlasan.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblIsiUlasan.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.lblIsiUlasan.Location = New System.Drawing.Point(12, 197)
        Me.lblIsiUlasan.Name = "lblIsiUlasan"
        Me.lblIsiUlasan.Text = "Isi Ulasan"

        Me.txtIsiUlasan.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.txtIsiUlasan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIsiUlasan.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.txtIsiUlasan.ForeColor = System.Drawing.Color.White
        Me.txtIsiUlasan.Location = New System.Drawing.Point(12, 217)
        Me.txtIsiUlasan.Multiline = True
        Me.txtIsiUlasan.Name = "txtIsiUlasan"
        Me.txtIsiUlasan.Size = New System.Drawing.Size(314, 65)
        Me.txtIsiUlasan.MaxLength = 255
        Me.txtIsiUlasan.PlaceholderText = "Tulis ulasan film di sini..."
        Me.txtIsiUlasan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical

        ' lblNilai
        Me.lblNilai.AutoSize = True
        Me.lblNilai.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblNilai.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.lblNilai.Location = New System.Drawing.Point(12, 297)
        Me.lblNilai.Name = "lblNilai"
        Me.lblNilai.Text = "Nilai Ulasan (1-10)"

        Me.nudNilai.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.nudNilai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudNilai.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.nudNilai.ForeColor = System.Drawing.Color.White
        Me.nudNilai.Location = New System.Drawing.Point(12, 317)
        Me.nudNilai.Maximum = 10
        Me.nudNilai.Minimum = 1
        Me.nudNilai.Name = "nudNilai"
        Me.nudNilai.Size = New System.Drawing.Size(314, 27)
        Me.nudNilai.Value = 7
        Me.nudNilai.DecimalPlaces = 1
        Me.nudNilai.Increment = New Decimal(New Integer() {5, 0, 0, 65536})

        ' lblTanggal
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.lblTanggal.Location = New System.Drawing.Point(12, 357)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Text = "Tanggal Ulasan"

        Me.dtpTanggal.CalendarForeColor = System.Drawing.Color.White
        Me.dtpTanggal.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTanggal.Location = New System.Drawing.Point(12, 377)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(314, 27)

        ' lblCari
        Me.lblCari.AutoSize = True
        Me.lblCari.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblCari.ForeColor = System.Drawing.Color.FromArgb(229, 9, 20)
        Me.lblCari.Location = New System.Drawing.Point(12, 420)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Text = "🔍  Cari Ulasan"

        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(12, 440)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(314, 27)
        Me.txtSearch.PlaceholderText = "Cari judul film, reviewer..."

        ' pnlButtons
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(25, 25, 40)
        Me.pnlButtons.Controls.Add(Me.btnSimpan)
        Me.pnlButtons.Controls.Add(Me.btnUbah)
        Me.pnlButtons.Controls.Add(Me.btnHapus)
        Me.pnlButtons.Controls.Add(Me.btnBatal)
        Me.pnlButtons.Location = New System.Drawing.Point(12, 620)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(340, 55)
        Me.pnlButtons.TabIndex = 3

        ' btnSimpan
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(0, 10)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(78, 35)
        Me.btnSimpan.Text = "💾 Simpan"
        Me.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand

        ' btnUbah
        Me.btnUbah.BackColor = System.Drawing.Color.FromArgb(52, 152, 219)
        Me.btnUbah.FlatAppearance.BorderSize = 0
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.btnUbah.ForeColor = System.Drawing.Color.White
        Me.btnUbah.Location = New System.Drawing.Point(86, 10)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(78, 35)
        Me.btnUbah.Text = "✏ Ubah"
        Me.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand

        ' btnHapus
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(229, 9, 20)
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(172, 10)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(78, 35)
        Me.btnHapus.Text = "🗑 Hapus"
        Me.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand

        ' btnBatal
        Me.btnBatal.BackColor = System.Drawing.Color.FromArgb(80, 80, 100)
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(258, 10)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(78, 35)
        Me.btnBatal.Text = "✖ Batal"
        Me.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand

        ' dgvUlasan
        Me.dgvUlasan.AllowUserToAddRows = False
        Me.dgvUlasan.AllowUserToDeleteRows = False
        Me.dgvUlasan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUlasan.BackgroundColor = System.Drawing.Color.FromArgb(25, 25, 40)
        Me.dgvUlasan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUlasan.GridColor = System.Drawing.Color.FromArgb(50, 50, 70)
        Me.dgvUlasan.Location = New System.Drawing.Point(368, 90)
        Me.dgvUlasan.Name = "dgvUlasan"
        Me.dgvUlasan.ReadOnly = True
        Me.dgvUlasan.RowHeadersVisible = False
        Me.dgvUlasan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUlasan.Size = New System.Drawing.Size(665, 590)
        Me.dgvUlasan.TabIndex = 4
        Me.dgvUlasan.MultiSelect = False
        Me.dgvUlasan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize

        Me.dgvUlasan.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 47)
        Me.dgvUlasan.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(229, 9, 20)
        Me.dgvUlasan.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.dgvUlasan.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(28, 28, 45)
        Me.dgvUlasan.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvUlasan.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.dgvUlasan.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(229, 9, 20)
        Me.dgvUlasan.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvUlasan.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 55)
        Me.dgvUlasan.RowTemplate.Height = 30

        ' ErrorProvider1
        Me.ErrorProvider1.ContainerControl = Me

        ' Form4
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(20, 20, 35)
        Me.ClientSize = New System.Drawing.Size(1050, 700)
        Me.Controls.Add(Me.dgvUlasan)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CineVault - Ulasan Film"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.dgvUlasan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiNavigasi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiMenuUtama As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiKoleksiFilm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents pnlInput As System.Windows.Forms.Panel
    Friend WithEvents lblKodeUlasan As System.Windows.Forms.Label
    Friend WithEvents txtKodeUlasan As System.Windows.Forms.TextBox
    Friend WithEvents lblFilm As System.Windows.Forms.Label
    Friend WithEvents cmbFilm As System.Windows.Forms.ComboBox
    Friend WithEvents lblReviewer As System.Windows.Forms.Label
    Friend WithEvents txtReviewer As System.Windows.Forms.TextBox
    Friend WithEvents lblIsiUlasan As System.Windows.Forms.Label
    Friend WithEvents txtIsiUlasan As System.Windows.Forms.TextBox
    Friend WithEvents lblNilai As System.Windows.Forms.Label
    Friend WithEvents nudNilai As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents dgvUlasan As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class