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
        LabelIPS = New Label()
        LabelIPK = New Label()
        Hasil = New Label()
        IPK = New TextBox()
        IPS = New TextBox()
        BtnTambah = New Button()
        BtnReset = New Button()
        SuspendLayout()
        ' 
        ' LabelIPS
        ' 
        LabelIPS.AutoSize = True
        LabelIPS.Location = New Point(176, 142)
        LabelIPS.Name = "LabelIPS"
        LabelIPS.Size = New Size(86, 20)
        LabelIPS.TabIndex = 0
        LabelIPS.Text = "IP Semester"
        ' 
        ' LabelIPK
        ' 
        LabelIPK.AutoSize = True
        LabelIPK.Location = New Point(176, 224)
        LabelIPK.Name = "LabelIPK"
        LabelIPK.Size = New Size(89, 20)
        LabelIPK.TabIndex = 1
        LabelIPK.Text = "IP Kumulatif"
        ' 
        ' Hasil
        ' 
        Hasil.AutoSize = True
        Hasil.Location = New Point(350, 270)
        Hasil.Name = "Hasil"
        Hasil.Size = New Size(42, 20)
        Hasil.TabIndex = 2
        Hasil.Text = "Hasil"
        ' 
        ' IPK
        ' 
        IPK.Location = New Point(285, 224)
        IPK.Name = "IPK"
        IPK.ReadOnly = True
        IPK.Size = New Size(182, 27)
        IPK.TabIndex = 3
        ' 
        ' IPS
        ' 
        IPS.Location = New Point(285, 139)
        IPS.Name = "IPS"
        IPS.Size = New Size(182, 27)
        IPS.TabIndex = 4
        ' 
        ' BtnTambah
        ' 
        BtnTambah.Location = New Point(275, 183)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(94, 29)
        BtnTambah.TabIndex = 5
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = True
        ' 
        ' BtnReset
        ' 
        BtnReset.Location = New Point(385, 183)
        BtnReset.Name = "BtnReset"
        BtnReset.Size = New Size(94, 29)
        BtnReset.TabIndex = 6
        BtnReset.Text = "Reset"
        BtnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnReset)
        Controls.Add(BtnTambah)
        Controls.Add(IPS)
        Controls.Add(IPK)
        Controls.Add(Hasil)
        Controls.Add(LabelIPK)
        Controls.Add(LabelIPS)
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelIPS As Label
    Friend WithEvents LabelIPK As Label
    Friend WithEvents Hasil As Label
    Friend WithEvents IPK As TextBox
    Friend WithEvents IPS As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnReset As Button

End Class
