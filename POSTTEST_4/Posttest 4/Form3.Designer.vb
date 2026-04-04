<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblJudulKartu = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblNama = New Label()
        picKartu = New PictureBox()
        lblKomunitas = New Label()
        lblID = New Label()
        lblKontak = New Label()
        lblHobi = New Label()
        CType(picKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulKartu
        ' 
        lblJudulKartu.AutoSize = True
        lblJudulKartu.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulKartu.Location = New Point(289, 56)
        lblJudulKartu.Name = "lblJudulKartu"
        lblJudulKartu.Size = New Size(176, 25)
        lblJudulKartu.TabIndex = 0
        lblJudulKartu.Text = "PLAYER CARD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(270, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nama           :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(271, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 20)
        Label3.TabIndex = 2
        Label3.Text = "ID                 :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(271, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 20)
        Label4.TabIndex = 3
        Label4.Text = "Aktivitas       :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(270, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 20)
        Label5.TabIndex = 4
        Label5.Text = "Kontak          :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(270, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 20)
        Label6.TabIndex = 5
        Label6.Text = "Komunitas    :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(393, 141)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(15, 20)
        lblNama.TabIndex = 6
        lblNama.Text = "-"
        ' 
        ' picKartu
        ' 
        picKartu.BorderStyle = BorderStyle.FixedSingle
        picKartu.Location = New Point(30, 108)
        picKartu.Name = "picKartu"
        picKartu.Size = New Size(198, 240)
        picKartu.TabIndex = 7
        picKartu.TabStop = False
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Location = New Point(393, 203)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(15, 20)
        lblKomunitas.TabIndex = 8
        lblKomunitas.Text = "-"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(393, 171)
        lblID.Name = "lblID"
        lblID.Size = New Size(15, 20)
        lblID.TabIndex = 9
        lblID.Text = "-"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.Location = New Point(393, 237)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(15, 20)
        lblKontak.TabIndex = 10
        lblKontak.Text = "-"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Location = New Point(393, 274)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(15, 20)
        lblHobi.TabIndex = 11
        lblHobi.Text = "-"
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblHobi)
        Controls.Add(lblKontak)
        Controls.Add(lblID)
        Controls.Add(lblKomunitas)
        Controls.Add(picKartu)
        Controls.Add(lblNama)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblJudulKartu)
        Name = "FormKartu"
        Text = "Form Kartu"
        CType(picKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulKartu As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents picKartu As PictureBox
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobi As Label
End Class
