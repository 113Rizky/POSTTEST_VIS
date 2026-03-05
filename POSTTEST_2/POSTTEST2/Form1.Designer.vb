<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Boxbuku = New GroupBox()
        btnHapus = New Button()
        btnTambah = New Button()
        txtGenre = New TextBox()
        txtJudul = New TextBox()
        LblGenre = New Label()
        LblJudul = New Label()
        lstBuku = New ListBox()
        Label1 = New Label()
        Boxbuku.SuspendLayout()
        SuspendLayout()
        ' 
        ' Boxbuku
        ' 
        Boxbuku.Controls.Add(btnHapus)
        Boxbuku.Controls.Add(btnTambah)
        Boxbuku.Controls.Add(txtGenre)
        Boxbuku.Controls.Add(txtJudul)
        Boxbuku.Controls.Add(LblGenre)
        Boxbuku.Controls.Add(LblJudul)
        Boxbuku.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Boxbuku.Location = New Point(159, 21)
        Boxbuku.Name = "Boxbuku"
        Boxbuku.Size = New Size(407, 178)
        Boxbuku.TabIndex = 0
        Boxbuku.TabStop = False
        Boxbuku.Text = "Manajemen Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.ForeColor = Color.Red
        btnHapus.Location = New Point(223, 118)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 4
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.ForeColor = Color.Lime
        btnTambah.Location = New Point(109, 118)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 3
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtGenre
        ' 
        txtGenre.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGenre.Location = New Point(109, 70)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(196, 27)
        txtGenre.TabIndex = 1
        ' 
        ' txtJudul
        ' 
        txtJudul.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudul.Location = New Point(109, 35)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(196, 27)
        txtJudul.TabIndex = 2
        ' 
        ' LblGenre
        ' 
        LblGenre.AutoSize = True
        LblGenre.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblGenre.Location = New Point(3, 73)
        LblGenre.Name = "LblGenre"
        LblGenre.Size = New Size(55, 20)
        LblGenre.TabIndex = 1
        LblGenre.Text = "Genre :"
        ' 
        ' LblJudul
        ' 
        LblJudul.AutoSize = True
        LblJudul.Font = New Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblJudul.Location = New Point(3, 38)
        LblJudul.Name = "LblJudul"
        LblJudul.Size = New Size(86, 20)
        LblJudul.TabIndex = 0
        LblJudul.Text = "Judul Buku :"
        ' 
        ' lstBuku
        ' 
        lstBuku.FormattingEnabled = True
        lstBuku.Location = New Point(159, 263)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(407, 164)
        lstBuku.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(159, 237)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 23)
        Label1.TabIndex = 2
        Label1.Text = "Daftar buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lstBuku)
        Controls.Add(Boxbuku)
        Name = "Form1"
        Text = "Form1"
        Boxbuku.ResumeLayout(False)
        Boxbuku.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Boxbuku As GroupBox
    Friend WithEvents LblGenre As Label
    Friend WithEvents LblJudul As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents lstBuku As ListBox
    Friend WithEvents Label1 As Label

End Class
