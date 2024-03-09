Imports System.Data.SqlClient
Public Class FormPengembalian
    Sub KondisiAwal()
        txkodeanggota.Text = ""
        txjumlah.Text = ""
        txkodebuku.Text = ""
        txbayar.Text = ""
        LBJudul.Text = ""
        LBNopinjam.Text = ""
        LBtanggalpinjam.Text = ""
        LBDenda.Text = ""
        LBlama.Text = ""
        LBNama.Text = ""
        LBPetugas.Text = Beranda.SNama.Text
        LBDenda2.Text = ""
        LBKembali.Text = ""
        LBTelahpinjam.Text = ""
    End Sub
    Sub KondisiAwal2()
        txjumlah.Text = ""
        txkodebuku.Text = ""
        txbayar.Text = ""
        LBJudul.Text = ""
        LBNopinjam.Text = ""
        LBtanggalpinjam.Text = ""
        LBDenda.Text = ""
        LBlama.Text = ""
        LBPetugas.Text = Beranda.SNama.Text
        LBDenda2.Text = ""
        LBKembali.Text = ""
    End Sub
    Sub Tabel()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode Buku")
        DataGridView1.Columns.Add("Nomor", "Nomor Pinjam")
        DataGridView1.Columns.Add("Judul", "Judul Buku")
        DataGridView1.Columns.Add("Jumlah", "Jumlah Pinjam")
        DataGridView1.Columns.Add("Tanggal", "Tanggal Pinjam")
        DataGridView1.Columns.Add("Lama", "Lama Pinjam")
        DataGridView1.Columns.Add("Denda", "Denda")
        DataGridView1.Columns(0).Width = 90
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 90
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 90
    End Sub
    Sub Tabel2()
        DataGridView2.Columns.Clear()
        DataGridView2.Columns.Add("Kode", "Kode Buku")
        DataGridView2.Columns.Add("Judul", "Judul Buku")
        DataGridView2.Columns.Add("Jumlah", "Jumlah Buku")
    End Sub
    Sub NoOtomatis()
        Call Koneksi()
        cmd = New SqlCommand("Select * from tb_kembali where nokembali in (select max(nokembali) from tb_kembali )", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Not Dr.HasRows Then
            UrutanKode = "KBL" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Dr.GetString(0), 9) + 1
            UrutanKode = "KBL" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBNo.Text = UrutanKode
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Call KondisiAwal()
        DataGridView2.Columns.Clear()

    End Sub
    Private Sub FormPengembalian_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Koneksi()
        Call NoOtomatis()
        LBTanggalkembali.Text = Today.ToString("dd-MM-yyyy")
    End Sub
    Private Sub FormPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call KondisiAwal()
        Call Tabel()
        Call NoOtomatis()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBJam.Text = TimeOfDay

    End Sub
    Sub Pinjaman()
        Call Koneksi()
        Da = New SqlDataAdapter("Select tb_buku.kodebuku,judulbuku,jumlahbuku from tb_anggota,tb_pinjam,tb_buku,tb_detailpinjam where tb_buku.kodebuku = tb_detailpinjam.kodebuku and tb_pinjam.nopinjam=tb_detailpinjam.nopinjam and tb_anggota.kodeanggota = tb_pinjam.kodeanggota and tb_anggota.kodeanggota = '" & txkodeanggota.Text & "' and tb_detailpinjam.jumlahbuku>0 ", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        DataGridView2.DataSource = Ds.Tables("Detail")
        DataGridView2.ReadOnly = True
    End Sub
    Sub CariData()
        Call Koneksi()
        cmd = New SqlCommand("Select * from tb_anggota where kodeanggota ='" & txkodeanggota.Text & "'", Conn)
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            LBNama.Text = Dr!NamaAnggota
            Call Koneksi()
            cmd = New SqlCommand("Select kodeanggota from tb_pinjam where kodeanggota  ='" & txkodeanggota.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Call Koneksi()
                cmd = New SqlCommand("Select Sum(jumlahpinjam) as Ketemu from tb_pinjam where kodeanggota  ='" & txkodeanggota.Text & "'", Conn)
                Dr = cmd.ExecuteReader
                Dr.Read()
                LBTelahpinjam.Text = Dr.Item(0)
                Call Pinjaman()

            End If
        End If
    End Sub
    Private Sub txkodeanggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txkodeanggota.KeyPress
        If e.KeyChar = Chr(13) Then
            Call CariData()
        End If
    End Sub

    Private Sub txkodebuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txkodebuku.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            cmd = New SqlCommand("Select distinct tb_buku.kodebuku,tb_detailpinjam.nopinjam,judulbuku,jumlahbuku,tanggalpinjam from tb_anggota,tb_pinjam,tb_buku,tb_detailpinjam where tb_buku.kodebuku = tb_detailpinjam.kodebuku and tb_pinjam.nopinjam = tb_detailpinjam.nopinjam and tb_anggota.kodeanggota = tb_pinjam.kodeanggota and tb_anggota.kodeanggota = '" & txkodeanggota.Text & "' and tb_detailpinjam.kodebuku = '" & txkodebuku.Text & "' and tb_detailpinjam.jumlahbuku>0", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                MsgBox("Kode buku tidak ada", MsgBoxStyle.Information, "Informasi")
            Else
                LBNopinjam.Text = Dr.Item(1)
                LBJudul.Text = Dr.Item(2)
                LBtanggalpinjam.Text = Dr.Item(4)
                txjumlah.Text = Dr.Item(3)
                LBlama.Text = DateDiff(DateInterval.Day, Dr.Item(4), Today())
                If LBlama.Text > 5 Then
                    LBDenda.Text = Val((LBlama.Text) - 5) * 1000
                Else
                    LBDenda.Text = 0
                End If
            End If
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call KondisiAwal()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Add(New String() {txkodebuku.Text, LBNopinjam.Text, LBJudul.Text, txjumlah.Text, LBtanggalpinjam.Text, LBlama.Text, LBDenda.Text})
        Call Hapus()
        Call TotalDenda()
        Call TotalKembali()
    End Sub
    Sub Hapus()
        txkodebuku.Text = ""
        LBNopinjam.Text = ""
        LBJudul.Text = ""
        LBtanggalpinjam.Text = ""
        txjumlah.Text = ""
        LBlama.Text = ""
        LBDenda.Text = ""
    End Sub
    Sub TotalDenda()
        Dim total As Integer = 0
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            total += Val(DataGridView1.Rows(I).Cells(6).Value)
            LBDenda2.Text = total
        Next
    End Sub
    Sub TotalKembali()
        Dim total As Integer = 0
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            total += Val(DataGridView1.Rows(I).Cells(3).Value)
            LBTotal.Text = total
        Next
    End Sub
    Private Sub txbayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txbayar.Text) < Val(LBDenda2.Text) Then
                MsgBox("Pembayaran Kurang")
                txbayar.Focus()
            ElseIf Val(txbayar.text) = Val(LBDenda2.Text) Then
                LBKembali.Text = 0
                Button2.Focus()
            Else
                LBKembali.Text = Val(LBDenda2.Text) - Val(txbayar.Text)
                Button2.Focus()
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txkodeanggota.Text = "" Or LBDenda2.Text = "" Or LBKembali.Text = "" Then
            MsgBox("Transaksi tidak ada", MsgBoxStyle.Information, "Informasi")
        Else
            Call Koneksi()
            Dim tglsql As String
            tglsql = Format(Today)
            Dim KembaliBuku As String = "insert into tb_kembali values ('" & LBNo.Text & "','" & tglsql & "','" & LBTotal.Text & "','" & LBDenda2.Text & "','" & txbayar.Text & "','" & LBKembali.Text & "','" & txkodeanggota.Text & "','" & Beranda.SKode.Text & "')"
            cmd = New SqlCommand(KembaliBuku, Conn)
            cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call Koneksi()
                Dim SimpanDetail As String = "Insert into tb_detailkembali values ( '" & LBNo.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "','" & DataGridView1.Rows(Baris).Cells(3).Value & "' )"
                cmd = New SqlCommand(SimpanDetail, Conn)
                cmd.ExecuteNonQuery()

                'updatebuku
                Call Koneksi()
                cmd = New SqlCommand("Select * from tb_buku where kodebuku ='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Dr = cmd.ExecuteReader
                Dr.Read()
                Call Koneksi()
                Dim updatebuku As String = "Update tb_buku set stokbuku ='" & Dr.Item("StokBuku") + DataGridView1.Rows(Baris).Cells(3).Value & "' where KodeBuku='" & DataGridView1.Rows(Baris).Cells(0).Value & "' "
                cmd = New SqlCommand(updatebuku, Conn)
                cmd.ExecuteNonQuery()

                'updatedetailpinjam
                Call Koneksi()
                cmd = New SqlCommand("select jumlahbuku from tb_detailpinjam where kodebuku ='" & DataGridView1.Rows(Baris).Cells(0).Value & "' and nopinjam='" & DataGridView1.Rows(Baris).Cells(1).Value & "' ", Conn)
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Call Koneksi()
                    Dim Updatedetailpinjam As String = "update tb_detailpinjam set jumlahbuku = '" & Dr.Item(0) - DataGridView1.Rows(Baris).Cells(3).Value & "' where kodebuku= '" & DataGridView1.Rows(Baris).Cells(0).Value & "' and nopinjam = '" & DataGridView1.Rows(Baris).Cells(1).Value & "' "
                    cmd = New SqlCommand(Updatedetailpinjam, Conn)
                    cmd.ExecuteNonQuery()
                End If

                'update total pinjam 
                Call Koneksi()
                cmd = New SqlCommand("select jumlahpinjam from tb_pinjam where nopinjam = '" & DataGridView1.Rows(Baris).Cells(1).Value & "'", Conn)
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    Call Koneksi()
                    Dim updatepinjam As String = "update tb_pinjam set jumlahpinjam = '" & Dr.Item(0) - DataGridView1.Rows(Baris).Cells(3).Value & "' where nopinjam = '" & DataGridView1.Rows(Baris).Cells(1).Value & "' "
                    cmd = New SqlCommand(updatepinjam, Conn)
                    cmd.ExecuteNonQuery()
                End If
            Next
            Call KondisiAwal()
            Call NoOtomatis()
            DataGridView1.Columns.Clear()
            DataGridView2.Columns.Clear()
            MsgBox("Transaksi Berhasil di Simpan", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub
End Class