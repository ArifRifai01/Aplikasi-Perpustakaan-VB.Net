<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengembalian
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
        DataGridView2 = New DataGridView()
        LBlama = New Label()
        Label15 = New Label()
        LBtanggalpinjam = New Label()
        Label10 = New Label()
        Button4 = New Button()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        txjumlah = New TextBox()
        Label8 = New Label()
        LBJudul = New Label()
        Label7 = New Label()
        LBTanggalkembali = New Label()
        Label12 = New Label()
        txkodebuku = New TextBox()
        Label11 = New Label()
        LBNama = New Label()
        LBNo = New Label()
        Label3 = New Label()
        Label2 = New Label()
        LBTelahpinjam = New Label()
        Label16 = New Label()
        txkodeanggota = New TextBox()
        LBNopinjam = New Label()
        Label5 = New Label()
        LBDenda = New Label()
        Label9 = New Label()
        LBTotal = New Label()
        Label13 = New Label()
        LBDenda2 = New Label()
        Label17 = New Label()
        LBKembali = New Label()
        Label18 = New Label()
        Label19 = New Label()
        txbayar = New TextBox()
        LBPetugas = New Label()
        LBJam = New Label()
        Label14 = New Label()
        Label20 = New Label()
        Button3 = New Button()
        Timer1 = New Timer(components)
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(409, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 30)
        Label1.TabIndex = 41
        Label1.Text = "Pengembalian Buku"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(39, 644)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.RowTemplate.Height = 29
        DataGridView2.Size = New Size(923, 144)
        DataGridView2.TabIndex = 105
        ' 
        ' LBlama
        ' 
        LBlama.BorderStyle = BorderStyle.Fixed3D
        LBlama.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBlama.Location = New Point(652, 238)
        LBlama.Name = "LBlama"
        LBlama.Size = New Size(114, 22)
        LBlama.TabIndex = 104
        LBlama.Text = "LBlama"
        ' 
        ' Label15
        ' 
        Label15.BorderStyle = BorderStyle.Fixed3D
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(545, 238)
        Label15.Name = "Label15"
        Label15.Size = New Size(110, 22)
        Label15.TabIndex = 103
        Label15.Text = "Lama Pinjam : "
        ' 
        ' LBtanggalpinjam
        ' 
        LBtanggalpinjam.BorderStyle = BorderStyle.Fixed3D
        LBtanggalpinjam.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBtanggalpinjam.Location = New Point(419, 238)
        LBtanggalpinjam.Name = "LBtanggalpinjam"
        LBtanggalpinjam.Size = New Size(114, 22)
        LBtanggalpinjam.TabIndex = 102
        LBtanggalpinjam.Text = "LBtanggalpinjam"
        ' 
        ' Label10
        ' 
        Label10.BorderStyle = BorderStyle.Fixed3D
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(289, 238)
        Label10.Name = "Label10"
        Label10.Size = New Size(130, 22)
        Label10.TabIndex = 101
        Label10.Text = "Tanggal Pinjam : "
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(163, 531)
        Button4.Name = "Button4"
        Button4.Size = New Size(104, 36)
        Button4.TabIndex = 98
        Button4.Text = "Clear"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(37, 531)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 36)
        Button2.TabIndex = 97
        Button2.Text = "Simpan"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(39, 323)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(924, 193)
        DataGridView1.TabIndex = 96
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(858, 273)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 28)
        Button1.TabIndex = 95
        Button1.Text = "Input"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txjumlah
        ' 
        txjumlah.Location = New Point(856, 199)
        txjumlah.Name = "txjumlah"
        txjumlah.Size = New Size(106, 27)
        txjumlah.TabIndex = 94
        ' 
        ' Label8
        ' 
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(774, 202)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 22)
        Label8.TabIndex = 93
        Label8.Text = "Jumlah : "
        ' 
        ' LBJudul
        ' 
        LBJudul.BorderStyle = BorderStyle.Fixed3D
        LBJudul.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBJudul.Location = New Point(420, 202)
        LBJudul.Name = "LBJudul"
        LBJudul.Size = New Size(322, 22)
        LBJudul.TabIndex = 92
        LBJudul.Text = "LBJudul"
        ' 
        ' Label7
        ' 
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(344, 202)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 22)
        Label7.TabIndex = 91
        Label7.Text = "Judul : "
        ' 
        ' LBTanggalkembali
        ' 
        LBTanggalkembali.BorderStyle = BorderStyle.Fixed3D
        LBTanggalkembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBTanggalkembali.Location = New Point(828, 68)
        LBTanggalkembali.Name = "LBTanggalkembali"
        LBTanggalkembali.Size = New Size(145, 22)
        LBTanggalkembali.TabIndex = 88
        LBTanggalkembali.Text = "LBTanggal"
        ' 
        ' Label12
        ' 
        Label12.BorderStyle = BorderStyle.Fixed3D
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(687, 68)
        Label12.Name = "Label12"
        Label12.Size = New Size(139, 22)
        Label12.TabIndex = 85
        Label12.Text = "Tanggal Kembali : "
        ' 
        ' txkodebuku
        ' 
        txkodebuku.Location = New Point(149, 201)
        txkodebuku.Name = "txkodebuku"
        txkodebuku.Size = New Size(167, 27)
        txkodebuku.TabIndex = 84
        ' 
        ' Label11
        ' 
        Label11.BorderStyle = BorderStyle.Fixed3D
        Label11.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(39, 202)
        Label11.Name = "Label11"
        Label11.Size = New Size(104, 22)
        Label11.TabIndex = 83
        Label11.Text = "Kode Buku : "
        ' 
        ' LBNama
        ' 
        LBNama.BorderStyle = BorderStyle.Fixed3D
        LBNama.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBNama.Location = New Point(370, 108)
        LBNama.Name = "LBNama"
        LBNama.Size = New Size(285, 22)
        LBNama.TabIndex = 79
        LBNama.Text = "LBNama"
        ' 
        ' LBNo
        ' 
        LBNo.BorderStyle = BorderStyle.Fixed3D
        LBNo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBNo.Location = New Point(180, 68)
        LBNo.Name = "LBNo"
        LBNo.Size = New Size(170, 22)
        LBNo.TabIndex = 78
        LBNo.Text = "LBNokembali"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(38, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 22)
        Label3.TabIndex = 75
        Label3.Text = "Kode Anggota : "
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(38, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 22)
        Label2.TabIndex = 73
        Label2.Text = "No Kembali : "
        ' 
        ' LBTelahpinjam
        ' 
        LBTelahpinjam.BorderStyle = BorderStyle.Fixed3D
        LBTelahpinjam.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBTelahpinjam.Location = New Point(488, 68)
        LBTelahpinjam.Name = "LBTelahpinjam"
        LBTelahpinjam.Size = New Size(118, 22)
        LBTelahpinjam.TabIndex = 107
        ' 
        ' Label16
        ' 
        Label16.BorderStyle = BorderStyle.Fixed3D
        Label16.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(370, 68)
        Label16.Name = "Label16"
        Label16.Size = New Size(112, 22)
        Label16.TabIndex = 106
        Label16.Text = "Telah Pinjam : "
        ' 
        ' txkodeanggota
        ' 
        txkodeanggota.Location = New Point(180, 105)
        txkodeanggota.Name = "txkodeanggota"
        txkodeanggota.Size = New Size(170, 27)
        txkodeanggota.TabIndex = 70
        ' 
        ' LBNopinjam
        ' 
        LBNopinjam.BorderStyle = BorderStyle.Fixed3D
        LBNopinjam.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBNopinjam.Location = New Point(128, 238)
        LBNopinjam.Name = "LBNopinjam"
        LBNopinjam.Size = New Size(150, 22)
        LBNopinjam.TabIndex = 110
        LBNopinjam.Text = "LBNopinjam"
        ' 
        ' Label5
        ' 
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(38, 238)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 22)
        Label5.TabIndex = 109
        Label5.Text = "No Pinjam :"
        ' 
        ' LBDenda
        ' 
        LBDenda.BorderStyle = BorderStyle.Fixed3D
        LBDenda.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBDenda.Location = New Point(858, 238)
        LBDenda.Name = "LBDenda"
        LBDenda.Size = New Size(104, 22)
        LBDenda.TabIndex = 112
        LBDenda.Text = "LBDenda"
        ' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(780, 238)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 22)
        Label9.TabIndex = 111
        Label9.Text = "Denda :"
        ' 
        ' LBTotal
        ' 
        LBTotal.BorderStyle = BorderStyle.Fixed3D
        LBTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBTotal.Location = New Point(629, 531)
        LBTotal.Name = "LBTotal"
        LBTotal.Size = New Size(119, 22)
        LBTotal.TabIndex = 114
        ' 
        ' Label13
        ' 
        Label13.BorderStyle = BorderStyle.Fixed3D
        Label13.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(513, 531)
        Label13.Name = "Label13"
        Label13.Size = New Size(110, 22)
        Label13.TabIndex = 113
        Label13.Text = "Total Pinjam : "
        ' 
        ' LBDenda2
        ' 
        LBDenda2.BorderStyle = BorderStyle.Fixed3D
        LBDenda2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBDenda2.Location = New Point(856, 531)
        LBDenda2.Name = "LBDenda2"
        LBDenda2.Size = New Size(104, 22)
        LBDenda2.TabIndex = 116
        LBDenda2.Text = "LBDenda2"
        ' 
        ' Label17
        ' 
        Label17.BorderStyle = BorderStyle.Fixed3D
        Label17.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(766, 531)
        Label17.Name = "Label17"
        Label17.Size = New Size(64, 22)
        Label17.TabIndex = 115
        Label17.Text = "Denda :"
        ' 
        ' LBKembali
        ' 
        LBKembali.BorderStyle = BorderStyle.Fixed3D
        LBKembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBKembali.Location = New Point(858, 596)
        LBKembali.Name = "LBKembali"
        LBKembali.Size = New Size(104, 22)
        LBKembali.TabIndex = 118
        LBKembali.Text = "LBKembali"
        ' 
        ' Label18
        ' 
        Label18.BorderStyle = BorderStyle.Fixed3D
        Label18.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(766, 596)
        Label18.Name = "Label18"
        Label18.Size = New Size(78, 22)
        Label18.TabIndex = 117
        Label18.Text = "Kembali : "
        ' 
        ' Label19
        ' 
        Label19.BorderStyle = BorderStyle.Fixed3D
        Label19.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(766, 564)
        Label19.Name = "Label19"
        Label19.Size = New Size(78, 22)
        Label19.TabIndex = 119
        Label19.Text = "Di Bayar :"
        ' 
        ' txbayar
        ' 
        txbayar.Location = New Point(858, 562)
        txbayar.Name = "txbayar"
        txbayar.Size = New Size(104, 27)
        txbayar.TabIndex = 120
        ' 
        ' LBPetugas
        ' 
        LBPetugas.BorderStyle = BorderStyle.Fixed3D
        LBPetugas.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBPetugas.Location = New Point(828, 140)
        LBPetugas.Name = "LBPetugas"
        LBPetugas.Size = New Size(145, 22)
        LBPetugas.TabIndex = 124
        LBPetugas.Text = "LBPetugas"
        ' 
        ' LBJam
        ' 
        LBJam.BorderStyle = BorderStyle.Fixed3D
        LBJam.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LBJam.Location = New Point(828, 105)
        LBJam.Name = "LBJam"
        LBJam.Size = New Size(145, 22)
        LBJam.TabIndex = 123
        LBJam.Text = "LBJam"
        ' 
        ' Label14
        ' 
        Label14.BorderStyle = BorderStyle.Fixed3D
        Label14.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(687, 140)
        Label14.Name = "Label14"
        Label14.Size = New Size(124, 22)
        Label14.TabIndex = 122
        Label14.Text = "Petugas : "
        ' 
        ' Label20
        ' 
        Label20.BorderStyle = BorderStyle.Fixed3D
        Label20.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label20.Location = New Point(687, 105)
        Label20.Name = "Label20"
        Label20.Size = New Size(124, 22)
        Label20.TabIndex = 121
        Label20.Text = "Jam : "
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(289, 531)
        Button3.Name = "Button3"
        Button3.Size = New Size(104, 36)
        Button3.TabIndex = 125
        Button3.Text = "Tutup"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' FormPengembalian
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSkyBlue
        ClientSize = New Size(999, 808)
        Controls.Add(Button3)
        Controls.Add(LBPetugas)
        Controls.Add(LBJam)
        Controls.Add(Label14)
        Controls.Add(Label20)
        Controls.Add(txbayar)
        Controls.Add(Label19)
        Controls.Add(LBKembali)
        Controls.Add(Label18)
        Controls.Add(LBDenda2)
        Controls.Add(Label17)
        Controls.Add(LBTotal)
        Controls.Add(Label13)
        Controls.Add(LBDenda)
        Controls.Add(Label9)
        Controls.Add(LBNopinjam)
        Controls.Add(Label5)
        Controls.Add(txkodeanggota)
        Controls.Add(LBTelahpinjam)
        Controls.Add(Label16)
        Controls.Add(DataGridView2)
        Controls.Add(LBlama)
        Controls.Add(Label15)
        Controls.Add(LBtanggalpinjam)
        Controls.Add(Label10)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(txjumlah)
        Controls.Add(Label8)
        Controls.Add(LBJudul)
        Controls.Add(Label7)
        Controls.Add(LBTanggalkembali)
        Controls.Add(Label12)
        Controls.Add(txkodebuku)
        Controls.Add(Label11)
        Controls.Add(LBNama)
        Controls.Add(LBNo)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormPengembalian"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormPengembalian"
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents LBlama As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LBtanggalpinjam As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents txjumlah As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LBJudul As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBTanggalkembali As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txkodebuku As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LBNama As Label
    Friend WithEvents LBNo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LBTelahpinjam As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txkodeanggota As TextBox
    Friend WithEvents LBNopinjam As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBDenda As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LBTotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LBDenda2 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LBKembali As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txbayar As TextBox
    Friend WithEvents LBPetugas As Label
    Friend WithEvents LBJam As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Timer1 As Timer
End Class
