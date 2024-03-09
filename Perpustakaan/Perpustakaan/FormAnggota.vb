Imports System.Data.SqlClient

Public Class FormAnggota
    Sub KondisiAwal()
        txkode.Text = ""
        txnama.Text = ""
        cbkelamin.Text = ""
        txalamat.Text = ""
        txtelepon.Text = ""
        txkode.Enabled = False
        txnama.Enabled = False
        cbkelamin.Enabled = False
        txalamat.Enabled = False
        txtelepon.Enabled = False
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Call Koneksi()
        Da = New SqlDataAdapter("select kodeanggota,namaanggota,jeniskelamin,alamat,notelp from tb_anggota", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_anggota")
        DataGridView1.DataSource = (Ds.Tables("tb_anggota"))
        cbkelamin.Items.Clear()
        cbkelamin.Items.Add("Laki - Laki")
        cbkelamin.Items.Add("Perempuan")
    End Sub
    Sub SiapIsi()
        txkode.Enabled = True
        txnama.Enabled = True
        cbkelamin.Enabled = True
        txalamat.Enabled = True
        txtelepon.Enabled = True
    End Sub

    Private Sub FormAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            If txkode.Text = "" Or txnama.Text = "" Or cbkelamin.Text = "" Or txalamat.Text = "" Or txtelepon.Text = "" Then
                MsgBox("Harap Isi Semua!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim SimpanData As String = "insert into tb_anggota values('" & txkode.Text & "','" & txnama.Text & "','" & cbkelamin.Text & "','" & txalamat.Text & "','" & txtelepon.Text & "')"
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
            If txkode.Text = "" Or txnama.Text = "" Or cbkelamin.Text = "" Or txalamat.Text = "" Or txtelepon.Text = "" Then
                MsgBox("Harap Isi Semua!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim EditData As String = "update tb_anggota set namaanggota='" & txnama.Text & "',jeniskelamin='" & cbkelamin.Text & "',alamat='" & txalamat.Text & "',notelp='" & txtelepon.Text & "' where kodeanggota='" & txkode.Text & "'"
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
            If txkode.Text = "" Or txnama.Text = "" Or cbkelamin.Text = "" Or txalamat.Text = "" Or txtelepon.Text = "" Then
                MsgBox("Harap Isi Semua!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim HapusData As String = "delete tb_anggota where kodeanggota='" & txkode.Text & "'"
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
            cmd = New SqlCommand("Select * From tb_anggota where kodeanggota='" & txkode.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                txnama.Text = Dr.Item("namaanggota")
                cbkelamin.Text = Dr.Item("jeniskelamin")
                txalamat.Text = Dr.Item("alamat")
                txtelepon.Text = Dr.Item("notelp")
            Else
                MsgBox("Data Tidak Ada", MsgBoxStyle.Information, "Informasi")
            End If
        End If
    End Sub
End Class