<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Beranda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        MasterToolStripMenuItem = New ToolStripMenuItem()
        PegawaiToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        AnggotaToolStripMenuItem = New ToolStripMenuItem()
        BukuToolStripMenuItem = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        PeminjamanToolStripMenuItem = New ToolStripMenuItem()
        PengembalianToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        LaporanPeminjamanToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem1 = New ToolStripMenuItem()
        SKode = New ToolStripStatusLabel()
        ToolStripStatusLabel3 = New ToolStripStatusLabel()
        SNama = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        SLevel = New ToolStripStatusLabel()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel4 = New ToolStripStatusLabel()
        SJam = New ToolStripStatusLabel()
        ToolStripStatusLabel6 = New ToolStripStatusLabel()
        STanggal = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, MasterToolStripMenuItem, TransaksiToolStripMenuItem, LaporanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(898, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LoginToolStripMenuItem, LogoutToolStripMenuItem, ToolStripMenuItem1, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(224, 26)
        LoginToolStripMenuItem.Text = "Login"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(224, 26)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(221, 6)
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(224, 26)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' MasterToolStripMenuItem
        ' 
        MasterToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PegawaiToolStripMenuItem, ToolStripMenuItem2, AnggotaToolStripMenuItem, BukuToolStripMenuItem})
        MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        MasterToolStripMenuItem.Size = New Size(68, 24)
        MasterToolStripMenuItem.Text = "Master"
        ' 
        ' PegawaiToolStripMenuItem
        ' 
        PegawaiToolStripMenuItem.Name = "PegawaiToolStripMenuItem"
        PegawaiToolStripMenuItem.Size = New Size(224, 26)
        PegawaiToolStripMenuItem.Text = "Petugas"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(221, 6)
        ' 
        ' AnggotaToolStripMenuItem
        ' 
        AnggotaToolStripMenuItem.Name = "AnggotaToolStripMenuItem"
        AnggotaToolStripMenuItem.Size = New Size(224, 26)
        AnggotaToolStripMenuItem.Text = "Anggota"
        ' 
        ' BukuToolStripMenuItem
        ' 
        BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        BukuToolStripMenuItem.Size = New Size(224, 26)
        BukuToolStripMenuItem.Text = "Buku"
        ' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PeminjamanToolStripMenuItem, PengembalianToolStripMenuItem})
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        TransaksiToolStripMenuItem.Size = New Size(82, 24)
        TransaksiToolStripMenuItem.Text = "Transaksi"
        ' 
        ' PeminjamanToolStripMenuItem
        ' 
        PeminjamanToolStripMenuItem.Name = "PeminjamanToolStripMenuItem"
        PeminjamanToolStripMenuItem.Size = New Size(224, 26)
        PeminjamanToolStripMenuItem.Text = "Peminjaman"
        ' 
        ' PengembalianToolStripMenuItem
        ' 
        PengembalianToolStripMenuItem.Name = "PengembalianToolStripMenuItem"
        PengembalianToolStripMenuItem.Size = New Size(224, 26)
        PengembalianToolStripMenuItem.Text = "Pengembalian"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LaporanPeminjamanToolStripMenuItem, LaporanToolStripMenuItem1})
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(70, 24)
        LaporanToolStripMenuItem.Text = "History"
        ' 
        ' LaporanPeminjamanToolStripMenuItem
        ' 
        LaporanPeminjamanToolStripMenuItem.Name = "LaporanPeminjamanToolStripMenuItem"
        LaporanPeminjamanToolStripMenuItem.Size = New Size(237, 26)
        LaporanPeminjamanToolStripMenuItem.Text = "History Peminjaman"
        ' 
        ' LaporanToolStripMenuItem1
        ' 
        LaporanToolStripMenuItem1.Name = "LaporanToolStripMenuItem1"
        LaporanToolStripMenuItem1.Size = New Size(237, 26)
        LaporanToolStripMenuItem1.Text = "History Pengembalian"
        ' 
        ' SKode
        ' 
        SKode.Name = "SKode"
        SKode.Size = New Size(15, 20)
        SKode.Text = "-"
        ' 
        ' ToolStripStatusLabel3
        ' 
        ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        ToolStripStatusLabel3.Size = New Size(56, 20)
        ToolStripStatusLabel3.Text = "Nama :"
        ' 
        ' SNama
        ' 
        SNama.Name = "SNama"
        SNama.Size = New Size(15, 20)
        SNama.Text = "-"
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(50, 20)
        ToolStripStatusLabel2.Text = "Level :"
        ' 
        ' SLevel
        ' 
        SLevel.Name = "SLevel"
        SLevel.Size = New Size(15, 20)
        SLevel.Text = "-"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, SKode, ToolStripStatusLabel3, SNama, ToolStripStatusLabel2, SLevel, ToolStripStatusLabel4, SJam, ToolStripStatusLabel6, STanggal})
        StatusStrip1.Location = New Point(0, 507)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(898, 26)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(51, 20)
        ToolStripStatusLabel1.Text = "Kode :"
        ' 
        ' ToolStripStatusLabel4
        ' 
        ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        ToolStripStatusLabel4.Size = New Size(42, 20)
        ToolStripStatusLabel4.Text = "Jam :"
        ' 
        ' SJam
        ' 
        SJam.Name = "SJam"
        SJam.Size = New Size(15, 20)
        SJam.Text = "-"
        ' 
        ' ToolStripStatusLabel6
        ' 
        ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        ToolStripStatusLabel6.Size = New Size(68, 20)
        ToolStripStatusLabel6.Text = "Tanggal :"
        ' 
        ' STanggal
        ' 
        STanggal.Name = "STanggal"
        STanggal.Size = New Size(15, 20)
        STanggal.Text = "-"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Beranda
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(898, 533)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Beranda"
        StartPosition = FormStartPosition.Manual
        Text = "Beranda"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PegawaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents AnggotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeminjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengembalianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents STL1 As ToolStripStatusLabel
    Friend WithEvents SKode As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents SNama As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents SLevel As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents SJam As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents STanggal As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents LaporanPeminjamanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem1 As ToolStripMenuItem
End Class
