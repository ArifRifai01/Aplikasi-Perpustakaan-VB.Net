<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPeminjaman
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        LBNo = New Label()
        LBNama = New Label()
        LBAlamat = New Label()
        LBTelepon = New Label()
        cbkode = New ComboBox()
        Label11 = New Label()
        txkode = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        LBTanggal = New Label()
        LBJam = New Label()
        LBPetugas = New Label()
        Label7 = New Label()
        LBJudul = New Label()
        Label8 = New Label()
        txjumlah = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Button4 = New Button()
        Timer1 = New Timer(components)
        Label9 = New Label()
        LBPengarang = New Label()
        Label10 = New Label()
        LBTahun = New Label()
        Label15 = New Label()
        LBTotal = New Label()
        DataGridView2 = New DataGridView()
        Label16 = New Label()
        LBTelahpinjam = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(384, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 30)
        Label1.TabIndex = 40
        Label1.Text = "Peminjaman Buku"
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(34, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 22)
        Label2.TabIndex = 41
        Label2.Text = "No Pinjam : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(34, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 22)
        Label3.TabIndex = 41
        Label3.Text = "Kode Anggota : "
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(34, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 22)
        Label4.TabIndex = 41
        Label4.Text = "Nama : "
        ' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(34, 168)
        Label5.Name = "Label5"
        Label5.Size = New Size(124, 22)
        Label5.TabIndex = 41
        Label5.Text = "Alamat : "
        ' 
        ' Label6
        ' 
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(34, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(124, 22)
        Label6.TabIndex = 41
        Label6.Text = "Telepon : "
        ' 
        ' LBNo
        ' 
        LBNo.BorderStyle = BorderStyle.Fixed3D
        LBNo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBNo.Location = New Point(192, 63)
        LBNo.Name = "LBNo"
        LBNo.Size = New Size(170, 22)
        LBNo.TabIndex = 42
        LBNo.Text = "LBNo"
        ' 
        ' LBNama
        ' 
        LBNama.BorderStyle = BorderStyle.Fixed3D
        LBNama.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBNama.Location = New Point(192, 133)
        LBNama.Name = "LBNama"
        LBNama.Size = New Size(359, 22)
        LBNama.TabIndex = 43
        LBNama.Text = "LBNama"
        ' 
        ' LBAlamat
        ' 
        LBAlamat.BorderStyle = BorderStyle.Fixed3D
        LBAlamat.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBAlamat.Location = New Point(192, 168)
        LBAlamat.Name = "LBAlamat"
        LBAlamat.Size = New Size(359, 22)
        LBAlamat.TabIndex = 44
        LBAlamat.Text = "LBAlamat"
        ' 
        ' LBTelepon
        ' 
        LBTelepon.BorderStyle = BorderStyle.Fixed3D
        LBTelepon.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBTelepon.Location = New Point(192, 203)
        LBTelepon.Name = "LBTelepon"
        LBTelepon.Size = New Size(359, 22)
        LBTelepon.TabIndex = 45
        LBTelepon.Text = "LBTelepon"
        ' 
        ' cbkode
        ' 
        cbkode.FormattingEnabled = True
        cbkode.Location = New Point(192, 95)
        cbkode.Name = "cbkode"
        cbkode.Size = New Size(124, 28)
        cbkode.TabIndex = 46
        ' 
        ' Label11
        ' 
        Label11.BorderStyle = BorderStyle.Fixed3D
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(31, 245)
        Label11.Name = "Label11"
        Label11.Size = New Size(124, 22)
        Label11.TabIndex = 47
        Label11.Text = "Kode Buku : "
        ' 
        ' txkode
        ' 
        txkode.Location = New Point(167, 243)
        txkode.Name = "txkode"
        txkode.Size = New Size(105, 27)
        txkode.TabIndex = 48
        ' 
        ' Label12
        ' 
        Label12.BorderStyle = BorderStyle.Fixed3D
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(574, 63)
        Label12.Name = "Label12"
        Label12.Size = New Size(124, 22)
        Label12.TabIndex = 49
        Label12.Text = "Tanggal : "
        ' 
        ' Label13
        ' 
        Label13.BorderStyle = BorderStyle.Fixed3D
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(574, 98)
        Label13.Name = "Label13"
        Label13.Size = New Size(124, 22)
        Label13.TabIndex = 50
        Label13.Text = "Jam : "
        ' 
        ' Label14
        ' 
        Label14.BorderStyle = BorderStyle.Fixed3D
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(574, 133)
        Label14.Name = "Label14"
        Label14.Size = New Size(124, 22)
        Label14.TabIndex = 51
        Label14.Text = "Petugas : "
        ' 
        ' LBTanggal
        ' 
        LBTanggal.BorderStyle = BorderStyle.Fixed3D
        LBTanggal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBTanggal.Location = New Point(729, 63)
        LBTanggal.Name = "LBTanggal"
        LBTanggal.Size = New Size(159, 22)
        LBTanggal.TabIndex = 52
        LBTanggal.Text = "LBTanggal"
        ' 
        ' LBJam
        ' 
        LBJam.BorderStyle = BorderStyle.Fixed3D
        LBJam.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBJam.Location = New Point(729, 98)
        LBJam.Name = "LBJam"
        LBJam.Size = New Size(159, 22)
        LBJam.TabIndex = 53
        LBJam.Text = "LBJam"
        ' 
        ' LBPetugas
        ' 
        LBPetugas.BorderStyle = BorderStyle.Fixed3D
        LBPetugas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBPetugas.Location = New Point(729, 133)
        LBPetugas.Name = "LBPetugas"
        LBPetugas.Size = New Size(159, 22)
        LBPetugas.TabIndex = 54
        LBPetugas.Text = "LBPetugas"
        ' 
        ' Label7
        ' 
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(292, 245)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 22)
        Label7.TabIndex = 55
        Label7.Text = "Judul : "
        ' 
        ' LBJudul
        ' 
        LBJudul.BorderStyle = BorderStyle.Fixed3D
        LBJudul.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBJudul.Location = New Point(368, 245)
        LBJudul.Name = "LBJudul"
        LBJudul.Size = New Size(211, 22)
        LBJudul.TabIndex = 56
        LBJudul.Text = "LBJudul"
        ' 
        ' Label8
        ' 
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(602, 245)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 22)
        Label8.TabIndex = 57
        Label8.Text = "Jumlah : "
        ' 
        ' txjumlah
        ' 
        txjumlah.Location = New Point(684, 242)
        txjumlah.Name = "txjumlah"
        txjumlah.Size = New Size(106, 27)
        txjumlah.TabIndex = 58
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(810, 242)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 28)
        Button1.TabIndex = 59
        Button1.Text = "Input"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(34, 320)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(883, 193)
        DataGridView1.TabIndex = 60
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(687, 528)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 36)
        Button2.TabIndex = 61
        Button2.Text = "Simpan"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(813, 528)
        Button4.Name = "Button4"
        Button4.Size = New Size(104, 36)
        Button4.TabIndex = 63
        Button4.Text = "Tutup"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(34, 281)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 22)
        Label9.TabIndex = 64
        Label9.Text = "Pengarang : "
        ' 
        ' LBPengarang
        ' 
        LBPengarang.BorderStyle = BorderStyle.Fixed3D
        LBPengarang.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBPengarang.Location = New Point(167, 281)
        LBPengarang.Name = "LBPengarang"
        LBPengarang.Size = New Size(241, 22)
        LBPengarang.TabIndex = 65
        LBPengarang.Text = "LBPengarang"
        ' 
        ' Label10
        ' 
        Label10.BorderStyle = BorderStyle.Fixed3D
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(441, 281)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 22)
        Label10.TabIndex = 66
        Label10.Text = "Tahun : "
        ' 
        ' LBTahun
        ' 
        LBTahun.BorderStyle = BorderStyle.Fixed3D
        LBTahun.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBTahun.Location = New Point(517, 281)
        LBTahun.Name = "LBTahun"
        LBTahun.Size = New Size(114, 22)
        LBTahun.TabIndex = 67
        LBTahun.Text = "LBTahun"
        ' 
        ' Label15
        ' 
        Label15.BorderStyle = BorderStyle.Fixed3D
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(668, 281)
        Label15.Name = "Label15"
        Label15.Size = New Size(95, 22)
        Label15.TabIndex = 68
        Label15.Text = "Total Buku : "
        ' 
        ' LBTotal
        ' 
        LBTotal.BorderStyle = BorderStyle.Fixed3D
        LBTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBTotal.Location = New Point(774, 281)
        LBTotal.Name = "LBTotal"
        LBTotal.Size = New Size(114, 22)
        LBTotal.TabIndex = 69
        LBTotal.Text = "LBTotal"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(34, 584)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(883, 170)
        DataGridView2.TabIndex = 70
        ' 
        ' Label16
        ' 
        Label16.BorderStyle = BorderStyle.Fixed3D
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(34, 772)
        Label16.Name = "Label16"
        Label16.Size = New Size(121, 22)
        Label16.TabIndex = 71
        Label16.Text = "Telah Pinjam : "
        ' 
        ' LBTelahpinjam
        ' 
        LBTelahpinjam.BorderStyle = BorderStyle.Fixed3D
        LBTelahpinjam.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBTelahpinjam.Location = New Point(167, 772)
        LBTelahpinjam.Name = "LBTelahpinjam"
        LBTelahpinjam.Size = New Size(149, 22)
        LBTelahpinjam.TabIndex = 72
        ' 
        ' FormPeminjaman
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(955, 821)
        Controls.Add(LBTelahpinjam)
        Controls.Add(Label16)
        Controls.Add(DataGridView2)
        Controls.Add(LBTotal)
        Controls.Add(Label15)
        Controls.Add(LBTahun)
        Controls.Add(Label10)
        Controls.Add(LBPengarang)
        Controls.Add(Label9)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(txjumlah)
        Controls.Add(Label8)
        Controls.Add(LBJudul)
        Controls.Add(Label7)
        Controls.Add(LBPetugas)
        Controls.Add(LBJam)
        Controls.Add(LBTanggal)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(txkode)
        Controls.Add(Label11)
        Controls.Add(cbkode)
        Controls.Add(LBTelepon)
        Controls.Add(LBAlamat)
        Controls.Add(LBNama)
        Controls.Add(LBNo)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormPeminjaman"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormPeminjaman"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LBNo As Label
    Friend WithEvents LBNama As Label
    Friend WithEvents LBAlamat As Label
    Friend WithEvents LBTelepon As Label
    Friend WithEvents cbkode As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txkode As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents LBTanggal As Label
    Friend WithEvents LBJam As Label
    Friend WithEvents LBPetugas As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBJudul As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txjumlah As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label9 As Label
    Friend WithEvents LBPengarang As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LBTahun As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LBTotal As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents LBTelahpinjam As Label
End Class
