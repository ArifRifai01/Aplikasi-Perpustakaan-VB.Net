Imports System.Data.SqlClient
Public Class FormPeminjaman
    Sub KondisiAwal()
        Call NoOtomatis()
        Call KodeAnggota()
        Call Kolom()
        LBNama.Text = ""
        LBAlamat.Text = ""
        LBTelepon.Text = ""
        LBJudul.Text = ""
        LBPengarang.Text = ""
        LBTahun.Text = ""
        LBTotal.Text = "0"
        cbkode.Text = ""
        LBPetugas.Text = Beranda.SNama.Text
        DataGridView2.Columns.Clear()
        LBTelahpinjam.Text = ""

    End Sub
    Private Sub FormPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        LBTanggal.Text = Today.ToString("dd-MM-yyyy")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBJam.Text = TimeOfDay
    End Sub
    Sub NoOtomatis()
        Call Koneksi()
        cmd = New SqlCommand("Select * from tb_pinjam where nopinjam in (select max(nopinjam) from tb_pinjam )", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Dr.GetString(0), 9) + 1
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBNo.Text = UrutanKode
    End Sub
    Sub KodeAnggota()
        Call Koneksi()
        cbkode.Items.Clear()
        cmd = New SqlCommand("select * from tb_anggota ", Conn)
        Dr = cmd.ExecuteReader
        Do While Dr.Read
            cbkode.Items.Add(Dr.Item(0))
        Loop
    End Sub
    Private Sub cbkode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbkode.SelectedIndexChanged
        Call Koneksi()
        cmd = New SqlCommand("Select * from tb_anggota where kodeanggota='" & cbkode.Text & "'", Conn)
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            LBNama.Text = Dr!NamaAnggota
            LBAlamat.Text = Dr!Alamat
            LBTelepon.Text = Dr!Notelp
            Call CekPinjaman()
        End If
    End Sub
    Sub Kolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode Buku")
        DataGridView1.Columns.Add("Judul", "Judul Buku")
        DataGridView1.Columns.Add("Pengarang", "Pengarang")
        DataGridView1.Columns.Add("Tahun", "Tahun")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
    End Sub

    Private Sub txkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txkode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            cmd = New SqlCommand("Select * from tb_buku where kodebuku='" & txkode.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                MsgBox("Data Buku tidak ada", MsgBoxStyle.Information, "Informasi")
            Else
                txkode.Text = Dr.Item("kodebuku")
                LBJudul.Text = Dr.Item("judulbuku")
                LBPengarang.Text = Dr.Item("pengarangbuku")
                LBTahun.Text = Dr.Item("tahunbuku")
                txjumlah.Enabled = True
                txjumlah.Text = "1"
            End If
        End If
    End Sub
    Sub TotalBuku()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(4).Value
            LBTotal.Text = HitungItem
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(LBTelahpinjam.Text) + Val(LBTotal.Text) >= 5 Or Val(LBTotal.Text) + Val(txjumlah.Text) > 5 Then
            MsgBox("Buku yang dipinjam melebihi batas", MsgBoxStyle.Information, "Informasi")
        Else
            If LBJudul.Text = "" Or txjumlah.Text = "" Then
                MsgBox("silahkan masukan kode buku", MsgBoxStyle.Information, "Informasi")
            Else
                DataGridView1.Rows.Add(New String() {txkode.Text, LBJudul.Text, LBPengarang.Text, LBTahun.Text, txjumlah.Text})
                txkode.Text = ""
                LBJudul.Text = ""
                LBPengarang.Text = ""
                LBTahun.Text = ""
                txjumlah.Text = ""
                Call TotalBuku()
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If LBNama.Text = "" Or Label4.Text = " " Then
            MsgBox("Transaksi tidak ada", MsgBoxStyle.Information, "Informasi")
        Else
            Call Koneksi()
            Dim tglsql As String
            tglsql = Format(Today, "yyyy-MM-dd")
            Dim PinjamBuku As String = "insert into tb_pinjam values ('" & LBNo.Text & "','" & tglsql & "','" & LBJam.Text & "','" & cbkode.Text & "','" & LBTotal.Text & "','" & LBTotal.Text & "','" & Beranda.SKode.Text & "')"
            cmd = New SqlCommand(PinjamBuku, Conn)
            cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call Koneksi()
                Dim SimpanDetail As String = "Insert into tb_detailpinjam values ( '" & LBNo.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "' )"
                cmd = New SqlCommand(SimpanDetail, Conn)
                cmd.ExecuteNonQuery()
                Call Koneksi()
                cmd = New SqlCommand("Select * from tb_buku where kodebuku ='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Dr = cmd.ExecuteReader
                Dr.Read()
                Call Koneksi()
                Dim KurangStok As String = "Update tb_buku set stokbuku ='" & Dr.Item("StokBuku") - DataGridView1.Rows(Baris).Cells(4).Value & "' where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "' "
                cmd = New SqlCommand(KurangStok, Conn)
                cmd.ExecuteNonQuery()
            Next
            Call KondisiAwal()
            MsgBox("Transaksi Berhasil di Simpan", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub

    Sub CekPinjaman()
        Call Koneksi()
        Da = New SqlDataAdapter("Select tb_buku.kodebuku,jumlahbuku from tb_anggota,tb_pinjam,tb_buku,tb_detailpinjam where tb_buku.kodebuku=tb_detailpinjam.kodebuku And tb_pinjam.nopinjam=tb_detailpinjam.nopinjam And tb_anggota.kodeanggota=tb_pinjam.kodeanggota And tb_anggota.kodeanggota='" & cbkode.Text & "' And tb_detailpinjam.jumlahbuku>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        DataGridView2.DataSource = Ds.Tables("Detail")
        LBTelahpinjam.Text = DataGridView2.Rows.Count - 1
        DataGridView2.ReadOnly = True
    End Sub

    Private Sub FormPeminjaman_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call KondisiAwal()

    End Sub
End Class