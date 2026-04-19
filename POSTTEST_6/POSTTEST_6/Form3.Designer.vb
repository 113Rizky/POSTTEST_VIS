<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.tsmiSep = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblKodeFilm = New System.Windows.Forms.Label()
        Me.txtKodeFilm = New System.Windows.Forms.TextBox()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.cmbGenre = New System.Windows.Forms.ComboBox()
        Me.lblTahun = New System.Windows.Forms.Label()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.lblSutradara = New System.Windows.Forms.Label()
        Me.txtSutradara = New System.Windows.Forms.TextBox()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.nudRating = New System.Windows.Forms.NumericUpDown()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.dgvFilm = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        CType(Me.dgvFilm, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tsmiNavigasi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMenuUtama, Me.tsmiSep, Me.tsmiKeluar})
        Me.tsmiNavigasi.ForeColor = System.Drawing.Color.White
        Me.tsmiNavigasi.Name = "tsmiNavigasi"
        Me.tsmiNavigasi.Text = "  Navigasi  "

        ' tsmiMenuUtama
        Me.tsmiMenuUtama.Name = "tsmiMenuUtama"
        Me.tsmiMenuUtama.Text = "🏠  Menu Utama"

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
        Me.lblFormTitle.Text = "🎬  Koleksi Film Favorit"

        ' pnlInput
        Me.pnlInput.BackColor = System.Drawing.Color.FromArgb(25, 25, 40)
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlInput.Controls.Add(Me.lblKodeFilm)
        Me.pnlInput.Controls.Add(Me.txtKodeFilm)
        Me.pnlInput.Controls.Add(Me.lblJudul)
        Me.pnlInput.Controls.Add(Me.txtJudul)
        Me.pnlInput.Controls.Add(Me.lblGenre)
        Me.pnlInput.Controls.Add(Me.cmbGenre)
        Me.pnlInput.Controls.Add(Me.lblTahun)
        Me.pnlInput.Controls.Add(Me.txtTahun)
        Me.pnlInput.Controls.Add(Me.lblSutradara)
        Me.pnlInput.Controls.Add(Me.txtSutradara)
        Me.pnlInput.Controls.Add(Me.lblRating)
        Me.pnlInput.Controls.Add(Me.nudRating)
        Me.pnlInput.Controls.Add(Me.lblCari)
        Me.pnlInput.Controls.Add(Me.txtSearch)
        Me.pnlInput.Location = New System.Drawing.Point(12, 90)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(340, 480)
        Me.pnlInput.TabIndex = 2

        ' Baris 1: Kode Film
        Me.lblKodeFilm.AutoSize = True
        Me.lblKodeFilm.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblKodeFilm.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.lblKodeFilm.Location = New System.Drawing.Point(12, 15)
        Me.lblKodeFilm.Name = "lblKodeFilm"
        Me.lblKodeFilm.Text = "Kode Film"

        Me.txtKodeFilm.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.txtKodeFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKodeFilm.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtKodeFilm.ForeColor = System.Drawing.Color.White
        Me.txtKodeFilm.Location = New System.Drawing.Point(12, 35)
        Me.txtKodeFilm.Name = "txtKodeFilm"
        Me.txtKodeFilm.Size = New System.Drawing.Size(314, 27)
        Me.txtKodeFilm.MaxLength = 10
        Me.txtKodeFilm.PlaceholderText = "contoh: F001"

        ' Baris 2: Judul Film
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblJudul.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.lblJudul.Location = New System.Drawing.Point(12, 75)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Text = "Judul Film"

        Me.txtJudul.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.txtJudul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJudul.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtJudul.ForeColor = System.Drawing.Color.White
        Me.txtJudul.Location = New System.Drawing.Point(12, 95)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(314, 27)
        Me.txtJudul.MaxLength = 100
        Me.txtJudul.PlaceholderText = "Masukkan judul film"

        ' Baris 3: Genre
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblGenre.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.lblGenre.Location = New System.Drawing.Point(12, 135)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Text = "Genre"

        Me.cmbGenre.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.cmbGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbGenre.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.cmbGenre.ForeColor = System.Drawing.Color.White
        Me.cmbGenre.FormattingEnabled = True
        Me.cmbGenre.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Comedy", "Crime", "Documentary", "Drama", "Fantasy", "Horror", "Musical", "Romance", "Sci-Fi", "Thriller"})
        Me.cmbGenre.Location = New System.Drawing.Point(12, 155)
        Me.cmbGenre.Name = "cmbGenre"
        Me.cmbGenre.Size = New System.Drawing.Size(314, 28)
        Me.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList

        ' Baris 4: Tahun Rilis
        Me.lblTahun.AutoSize = True
        Me.lblTahun.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblTahun.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.lblTahun.Location = New System.Drawing.Point(12, 197)
        Me.lblTahun.Name = "lblTahun"
        Me.lblTahun.Text = "Tahun Rilis"

        Me.txtTahun.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.txtTahun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTahun.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtTahun.ForeColor = System.Drawing.Color.White
        Me.txtTahun.Location = New System.Drawing.Point(12, 217)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(314, 27)
        Me.txtTahun.MaxLength = 4
        Me.txtTahun.PlaceholderText = "contoh: 2023"

        ' Baris 5: Sutradara
        Me.lblSutradara.AutoSize = True
        Me.lblSutradara.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblSutradara.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.lblSutradara.Location = New System.Drawing.Point(12, 257)
        Me.lblSutradara.Name = "lblSutradara"
        Me.lblSutradara.Text = "Sutradara"

        Me.txtSutradara.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.txtSutradara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSutradara.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtSutradara.ForeColor = System.Drawing.Color.White
        Me.txtSutradara.Location = New System.Drawing.Point(12, 277)
        Me.txtSutradara.Name = "txtSutradara"
        Me.txtSutradara.Size = New System.Drawing.Size(314, 27)
        Me.txtSutradara.MaxLength = 100
        Me.txtSutradara.PlaceholderText = "Nama sutradara"

        ' Baris 6: Rating
        Me.lblRating.AutoSize = True
        Me.lblRating.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblRating.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200)
        Me.lblRating.Location = New System.Drawing.Point(12, 317)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Text = "Rating (1-10)"

        Me.nudRating.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.nudRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudRating.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.nudRating.ForeColor = System.Drawing.Color.White
        Me.nudRating.Location = New System.Drawing.Point(12, 337)
        Me.nudRating.Maximum = 10
        Me.nudRating.Minimum = 1
        Me.nudRating.Name = "nudRating"
        Me.nudRating.Size = New System.Drawing.Size(314, 27)
        Me.nudRating.Value = 7
        Me.nudRating.DecimalPlaces = 1
        Me.nudRating.Increment = New Decimal(New Integer() {5, 0, 0, 65536})

        ' Baris 7: Cari
        Me.lblCari.AutoSize = True
        Me.lblCari.Font = New System.Drawing.Font("Segoe UI", 8.5, System.Drawing.FontStyle.Bold)
        Me.lblCari.ForeColor = System.Drawing.Color.FromArgb(229, 9, 20)
        Me.lblCari.Location = New System.Drawing.Point(12, 385)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Text = "🔍  Cari Film"

        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(40, 40, 60)
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(12, 405)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(314, 27)
        Me.txtSearch.PlaceholderText = "Cari judul, genre, sutradara..."

        ' pnlButtons
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(25, 25, 40)
        Me.pnlButtons.Controls.Add(Me.btnSimpan)
        Me.pnlButtons.Controls.Add(Me.btnUbah)
        Me.pnlButtons.Controls.Add(Me.btnHapus)
        Me.pnlButtons.Controls.Add(Me.btnBatal)
        Me.pnlButtons.Location = New System.Drawing.Point(12, 580)
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

        ' dgvFilm
        Me.dgvFilm.AllowUserToAddRows = False
        Me.dgvFilm.AllowUserToDeleteRows = False
        Me.dgvFilm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFilm.BackgroundColor = System.Drawing.Color.FromArgb(25, 25, 40)
        Me.dgvFilm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFilm.GridColor = System.Drawing.Color.FromArgb(50, 50, 70)
        Me.dgvFilm.Location = New System.Drawing.Point(368, 90)
        Me.dgvFilm.Name = "dgvFilm"
        Me.dgvFilm.ReadOnly = True
        Me.dgvFilm.RowHeadersVisible = False
        Me.dgvFilm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFilm.Size = New System.Drawing.Size(665, 550)
        Me.dgvFilm.TabIndex = 4
        Me.dgvFilm.MultiSelect = False

        ' Styling DGV
        Me.dgvFilm.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 47)
        Me.dgvFilm.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(229, 9, 20)
        Me.dgvFilm.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.dgvFilm.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(28, 28, 45)
        Me.dgvFilm.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvFilm.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.dgvFilm.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(229, 9, 20)
        Me.dgvFilm.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvFilm.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(35, 35, 55)
        Me.dgvFilm.RowTemplate.Height = 30

        ' ErrorProvider1
        Me.ErrorProvider1.ContainerControl = Me

        ' Form3
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(20, 20, 35)
        Me.ClientSize = New System.Drawing.Size(1050, 660)
        Me.Controls.Add(Me.dgvFilm)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CineVault - Koleksi Film Favorit"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        CType(Me.dgvFilm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiNavigasi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiMenuUtama As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents pnlInput As System.Windows.Forms.Panel
    Friend WithEvents lblKodeFilm As System.Windows.Forms.Label
    Friend WithEvents txtKodeFilm As System.Windows.Forms.TextBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents txtJudul As System.Windows.Forms.TextBox
    Friend WithEvents lblGenre As System.Windows.Forms.Label
    Friend WithEvents cmbGenre As System.Windows.Forms.ComboBox
    Friend WithEvents lblTahun As System.Windows.Forms.Label
    Friend WithEvents txtTahun As System.Windows.Forms.TextBox
    Friend WithEvents lblSutradara As System.Windows.Forms.Label
    Friend WithEvents txtSutradara As System.Windows.Forms.TextBox
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents nudRating As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents dgvFilm As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class