Imports System.Data.SqlClient

Public Class FormBuku
    Sub KondisiAwal()
        txkode.Text = ""
        txjudul.Text = ""
        txpengarang.Text = ""
        txpenerbit.Text = ""
        txtahun.Text = ""
        txjumlah.Text = ""
        txkode.Enabled = False
        txjudul.Enabled = False
        txpengarang.Enabled = False
        txpenerbit.Enabled = False
        txtahun.Enabled = False
        txjumlah.Enabled = False
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Call Koneksi()
        Da = New SqlDataAdapter("select * from tb_buku", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_buku")
        DataGridView1.DataSource = (Ds.Tables("tb_buku"))
    End Sub
    Sub SiapIsi()
        txkode.Enabled = True
        txjudul.Enabled = True
        txpengarang.Enabled = True
        txpenerbit.Enabled = True
        txtahun.Enabled = True
        txjumlah.Enabled = True
    End Sub
    Private Sub FormBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
        Else
            If txkode.Text = "" Or txjudul.Text = "" Or txpengarang.Text = "" Or txpenerbit.Text = "" Or txtahun.Text = "" Or txjumlah.Text = "" Then
                MsgBox("Harap Isi Semua!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim SimpanData As String = "insert into tb_buku values('" & txkode.Text & "','" & txjudul.Text & "','" & txpengarang.Text & "','" & txpenerbit.Text & "','" & txtahun.Text & "','" & txjumlah.Text & "')"
                cmd = New SqlCommand(SimpanData, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di Input", MsgBoxStyle.Information, "Informasi")
                Call KondisiAwal()
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
        Else
            If txkode.Text = "" Or txjudul.Text = "" Or txpengarang.Text = "" Or txpenerbit.Text = "" Or txtahun.Text = "" Or txjumlah.Text = "" Then
                MsgBox("Harap Isi Semua!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim EditData As String = "update tb_buku set judulbuku='" & txjudul.Text & "',pengarangbuku='" & txpengarang.Text & "',penerbitbuku='" & txpenerbit.Text & "',tahunbuku='" & txtahun.Text & "' ,stokbuku='" & txjumlah.Text & "'where kodebuku='" & txkode.Text & "'"
                cmd = New SqlCommand(EditData, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di Edit", MsgBoxStyle.Information, "Informasi")
                Call KondisiAwal()
            End If
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "Hapus" Then
            Button3.Text = "Selesai"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
        Else
            If txkode.Text = "" Or txjudul.Text = "" Or txpengarang.Text = "" Or txpenerbit.Text = "" Or txtahun.Text = "" Or txjumlah.Text = "" Then
                MsgBox("Harap Isi Semua!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim HapusData As String = "delete tb_buku where kodebuku='" & txkode.Text & "'"
                cmd = New SqlCommand(HapusData, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
                Call KondisiAwal()
            End If
        End If
    End Sub
    Private Sub txkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txkode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            cmd = New SqlCommand("Select * From tb_buku where kodebuku='" & txkode.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                txjudul.Text = Dr.Item("JudulBuku")
                txpengarang.Text = Dr.Item("pengarangBuku")
                txpenerbit.Text = Dr.Item("PenerbitBuku")
                txtahun.Text = Dr.Item("TahunBuku")
                txjumlah.Text = Dr.Item("StokBuku")
            Else
                MsgBox("Data Tidak Ada", MsgBoxStyle.Information, "Informasi")
            End If
        End If
    End Sub
End Class