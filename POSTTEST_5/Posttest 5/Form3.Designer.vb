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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MenuStrip1 = New MenuStrip()
        tsmiNavigasi = New ToolStripMenuItem()
        tsmiMenuUtama = New ToolStripMenuItem()
        tsmiSep = New ToolStripSeparator()
        tsmiKeluar = New ToolStripMenuItem()
        pnlTop = New Panel()
        lblFormTitle = New Label()
        pnlInput = New Panel()
        lblKodeFilm = New Label()
        txtKodeFilm = New TextBox()
        lblJudul = New Label()
        txtJudul = New TextBox()
        lblGenre = New Label()
        cmbGenre = New ComboBox()
        lblTahun = New Label()
        txtTahun = New TextBox()
        lblSutradara = New Label()
        txtSutradara = New TextBox()
        lblRating = New Label()
        nudRating = New NumericUpDown()
        lblCari = New Label()
        txtSearch = New TextBox()
        pnlButtons = New Panel()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvFilm = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        pnlTop.SuspendLayout()
        pnlInput.SuspendLayout()
        CType(nudRating, ComponentModel.ISupportInitialize).BeginInit()
        pnlButtons.SuspendLayout()
        CType(dgvFilm, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(47))
        MenuStrip1.Font = New Font("Segoe UI", 9.5F)
        MenuStrip1.ForeColor = Color.White
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {tsmiNavigasi})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1050, 29)
        MenuStrip1.TabIndex = 0
        ' 
        ' tsmiNavigasi
        ' 
        tsmiNavigasi.DropDownItems.AddRange(New ToolStripItem() {tsmiMenuUtama, tsmiSep, tsmiKeluar})
        tsmiNavigasi.ForeColor = Color.White
        tsmiNavigasi.Name = "tsmiNavigasi"
        tsmiNavigasi.Size = New Size(100, 25)
        tsmiNavigasi.Text = "  Navigasi  "
        ' 
        ' tsmiMenuUtama
        ' 
        tsmiMenuUtama.Name = "tsmiMenuUtama"
        tsmiMenuUtama.Size = New Size(214, 26)
        tsmiMenuUtama.Text = "🏠  Menu Utama"
        ' 
        ' tsmiSep
        ' 
        tsmiSep.Name = "tsmiSep"
        tsmiSep.Size = New Size(211, 6)
        ' 
        ' tsmiKeluar
        ' 
        tsmiKeluar.Name = "tsmiKeluar"
        tsmiKeluar.Size = New Size(214, 26)
        tsmiKeluar.Text = "🚪  Keluar"
        ' 
        ' pnlTop
        ' 
        pnlTop.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(47))
        pnlTop.Controls.Add(lblFormTitle)
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 29)
        pnlTop.Margin = New Padding(3, 4, 3, 4)
        pnlTop.Name = "pnlTop"
        pnlTop.Size = New Size(1050, 62)
        pnlTop.TabIndex = 1
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.White
        lblFormTitle.Location = New Point(15, 16)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(255, 30)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "🎬  Koleksi Film Favorit"
        ' 
        ' pnlInput
        ' 
        pnlInput.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(40))
        pnlInput.BorderStyle = BorderStyle.FixedSingle
        pnlInput.Controls.Add(lblKodeFilm)
        pnlInput.Controls.Add(txtKodeFilm)
        pnlInput.Controls.Add(lblJudul)
        pnlInput.Controls.Add(txtJudul)
        pnlInput.Controls.Add(lblGenre)
        pnlInput.Controls.Add(cmbGenre)
        pnlInput.Controls.Add(lblTahun)
        pnlInput.Controls.Add(txtTahun)
        pnlInput.Controls.Add(lblSutradara)
        pnlInput.Controls.Add(txtSutradara)
        pnlInput.Controls.Add(lblRating)
        pnlInput.Controls.Add(nudRating)
        pnlInput.Controls.Add(lblCari)
        pnlInput.Controls.Add(txtSearch)
        pnlInput.Location = New Point(12, 112)
        pnlInput.Margin = New Padding(3, 4, 3, 4)
        pnlInput.Name = "pnlInput"
        pnlInput.Size = New Size(340, 600)
        pnlInput.TabIndex = 2
        ' 
        ' lblKodeFilm
        ' 
        lblKodeFilm.AutoSize = True
        lblKodeFilm.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblKodeFilm.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        lblKodeFilm.Location = New Point(12, 19)
        lblKodeFilm.Name = "lblKodeFilm"
        lblKodeFilm.Size = New Size(79, 20)
        lblKodeFilm.TabIndex = 0
        lblKodeFilm.Text = "Kode Film"
        ' 
        ' txtKodeFilm
        ' 
        txtKodeFilm.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(60))
        txtKodeFilm.BorderStyle = BorderStyle.FixedSingle
        txtKodeFilm.Font = New Font("Segoe UI", 10.0F)
        txtKodeFilm.ForeColor = Color.White
        txtKodeFilm.Location = New Point(12, 44)
        txtKodeFilm.Margin = New Padding(3, 4, 3, 4)
        txtKodeFilm.MaxLength = 10
        txtKodeFilm.Name = "txtKodeFilm"
        txtKodeFilm.PlaceholderText = "contoh: F001"
        txtKodeFilm.Size = New Size(314, 30)
        txtKodeFilm.TabIndex = 1
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblJudul.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        lblJudul.Location = New Point(12, 94)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(81, 20)
        lblJudul.TabIndex = 2
        lblJudul.Text = "Judul Film"
        ' 
        ' txtJudul
        ' 
        txtJudul.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(60))
        txtJudul.BorderStyle = BorderStyle.FixedSingle
        txtJudul.Font = New Font("Segoe UI", 10.0F)
        txtJudul.ForeColor = Color.White
        txtJudul.Location = New Point(12, 119)
        txtJudul.Margin = New Padding(3, 4, 3, 4)
        txtJudul.MaxLength = 100
        txtJudul.Name = "txtJudul"
        txtJudul.PlaceholderText = "Masukkan judul film"
        txtJudul.Size = New Size(314, 30)
        txtJudul.TabIndex = 3
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblGenre.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        lblGenre.Location = New Point(12, 169)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(51, 20)
        lblGenre.TabIndex = 4
        lblGenre.Text = "Genre"
        ' 
        ' cmbGenre
        ' 
        cmbGenre.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(60))
        cmbGenre.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGenre.FlatStyle = FlatStyle.Flat
        cmbGenre.Font = New Font("Segoe UI", 10.0F)
        cmbGenre.ForeColor = Color.White
        cmbGenre.FormattingEnabled = True
        cmbGenre.Items.AddRange(New Object() {"Action", "Adventure", "Animation", "Comedy", "Crime", "Documentary", "Drama", "Fantasy", "Horror", "Musical", "Romance", "Sci-Fi", "Thriller"})
        cmbGenre.Location = New Point(12, 194)
        cmbGenre.Margin = New Padding(3, 4, 3, 4)
        cmbGenre.Name = "cmbGenre"
        cmbGenre.Size = New Size(314, 31)
        cmbGenre.TabIndex = 5
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblTahun.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        lblTahun.Location = New Point(12, 246)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(85, 20)
        lblTahun.TabIndex = 6
        lblTahun.Text = "Tahun Rilis"
        ' 
        ' txtTahun
        ' 
        txtTahun.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(60))
        txtTahun.BorderStyle = BorderStyle.FixedSingle
        txtTahun.Font = New Font("Segoe UI", 10.0F)
        txtTahun.ForeColor = Color.White
        txtTahun.Location = New Point(12, 271)
        txtTahun.Margin = New Padding(3, 4, 3, 4)
        txtTahun.MaxLength = 4
        txtTahun.Name = "txtTahun"
        txtTahun.PlaceholderText = "contoh: 2023"
        txtTahun.Size = New Size(314, 30)
        txtTahun.TabIndex = 7
        ' 
        ' lblSutradara
        ' 
        lblSutradara.AutoSize = True
        lblSutradara.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblSutradara.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        lblSutradara.Location = New Point(12, 321)
        lblSutradara.Name = "lblSutradara"
        lblSutradara.Size = New Size(77, 20)
        lblSutradara.TabIndex = 8
        lblSutradara.Text = "Sutradara"
        ' 
        ' txtSutradara
        ' 
        txtSutradara.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(60))
        txtSutradara.BorderStyle = BorderStyle.FixedSingle
        txtSutradara.Font = New Font("Segoe UI", 10.0F)
        txtSutradara.ForeColor = Color.White
        txtSutradara.Location = New Point(12, 346)
        txtSutradara.Margin = New Padding(3, 4, 3, 4)
        txtSutradara.MaxLength = 100
        txtSutradara.Name = "txtSutradara"
        txtSutradara.PlaceholderText = "Nama sutradara"
        txtSutradara.Size = New Size(314, 30)
        txtSutradara.TabIndex = 9
        ' 
        ' lblRating
        ' 
        lblRating.AutoSize = True
        lblRating.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblRating.ForeColor = Color.FromArgb(CByte(200), CByte(200), CByte(200))
        lblRating.Location = New Point(12, 396)
        lblRating.Name = "lblRating"
        lblRating.Size = New Size(104, 20)
        lblRating.TabIndex = 10
        lblRating.Text = "Rating (1-10)"
        ' 
        ' nudRating
        ' 
        nudRating.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(60))
        nudRating.BorderStyle = BorderStyle.FixedSingle
        nudRating.DecimalPlaces = 1
        nudRating.Font = New Font("Segoe UI", 10.0F)
        nudRating.ForeColor = Color.White
        nudRating.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        nudRating.Location = New Point(12, 421)
        nudRating.Margin = New Padding(3, 4, 3, 4)
        nudRating.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        nudRating.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudRating.Name = "nudRating"
        nudRating.Size = New Size(314, 30)
        nudRating.TabIndex = 11
        nudRating.Value = New Decimal(New Integer() {7, 0, 0, 0})
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblCari.ForeColor = Color.FromArgb(CByte(229), CByte(9), CByte(20))
        lblCari.Location = New Point(12, 481)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(70, 20)
        lblCari.TabIndex = 12
        lblCari.Text = "Cari Film"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(60))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 10.0F)
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(12, 506)
        txtSearch.Margin = New Padding(3, 4, 3, 4)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari judul, genre, sutradara..."
        txtSearch.Size = New Size(314, 30)
        txtSearch.TabIndex = 13
        ' 
        ' pnlButtons
        ' 
        pnlButtons.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(40))
        pnlButtons.Controls.Add(btnSimpan)
        pnlButtons.Controls.Add(btnUbah)
        pnlButtons.Controls.Add(btnHapus)
        pnlButtons.Controls.Add(btnBatal)
        pnlButtons.Location = New Point(12, 725)
        pnlButtons.Margin = New Padding(3, 4, 3, 4)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Size = New Size(340, 69)
        pnlButtons.TabIndex = 3
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(39), CByte(174), CByte(96))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(0, 12)
        btnSimpan.Margin = New Padding(3, 4, 3, 4)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(78, 44)
        btnSimpan.TabIndex = 0
        btnSimpan.Text = "💾 Simpan" & vbCrLf
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        btnUbah.Cursor = Cursors.Hand
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(86, 12)
        btnUbah.Margin = New Padding(3, 4, 3, 4)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(78, 44)
        btnUbah.TabIndex = 1
        btnUbah.Text = "✏ Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(229), CByte(9), CByte(20))
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(172, 12)
        btnHapus.Margin = New Padding(3, 4, 3, 4)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(78, 44)
        btnHapus.TabIndex = 2
        btnHapus.Text = "🗑 Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(100))
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(258, 12)
        btnBatal.Margin = New Padding(3, 4, 3, 4)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(78, 44)
        btnBatal.TabIndex = 3
        btnBatal.Text = "✖ Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvFilm
        ' 
        dgvFilm.AllowUserToAddRows = False
        dgvFilm.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(55))
        dgvFilm.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvFilm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvFilm.BackgroundColor = Color.FromArgb(CByte(25), CByte(25), CByte(40))
        dgvFilm.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(47))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(229), CByte(9), CByte(20))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvFilm.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvFilm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(45))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(229), CByte(9), CByte(20))
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvFilm.DefaultCellStyle = DataGridViewCellStyle3
        dgvFilm.GridColor = Color.FromArgb(CByte(50), CByte(50), CByte(70))
        dgvFilm.Location = New Point(368, 112)
        dgvFilm.Margin = New Padding(3, 4, 3, 4)
        dgvFilm.MultiSelect = False
        dgvFilm.Name = "dgvFilm"
        dgvFilm.ReadOnly = True
        dgvFilm.RowHeadersVisible = False
        dgvFilm.RowHeadersWidth = 51
        dgvFilm.RowTemplate.Height = 30
        dgvFilm.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvFilm.Size = New Size(665, 688)
        dgvFilm.TabIndex = 4
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(35))
        ClientSize = New Size(1050, 825)
        Controls.Add(dgvFilm)
        Controls.Add(pnlButtons)
        Controls.Add(pnlInput)
        Controls.Add(pnlTop)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CineVault - Koleksi Film Favorit"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        pnlTop.ResumeLayout(False)
        pnlTop.PerformLayout()
        pnlInput.ResumeLayout(False)
        pnlInput.PerformLayout()
        CType(nudRating, ComponentModel.ISupportInitialize).EndInit()
        pnlButtons.ResumeLayout(False)
        CType(dgvFilm, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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