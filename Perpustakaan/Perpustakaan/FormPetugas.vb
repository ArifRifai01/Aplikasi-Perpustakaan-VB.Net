Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.Arm

Public Class FormPetugas
    Sub KondisiAwal()
        txkode.Text = ""
        txnama.Text = ""
        txpass.Text = ""
        cblevel.Text = ""
        Call Koneksi()
        Da = New SqlDataAdapter("select kodepetugas,namapetugas,levelpetugas from tb_petugas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_petugas")
        DataGridView1.DataSource = (Ds.Tables("tb_petugas"))
        cblevel.Items.Clear()
        cblevel.Items.Add("Admin")
        cblevel.Items.Add("Petugas")
    End Sub

    Private Sub FormPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        txkode.MaxLength = 4
        txnama.MaxLength = 30
        txpass.MaxLength = 20

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txkode.Text = "" Or txnama.Text = "" Or txpass.Text = "" Or cblevel.Text = "" Then
            MsgBox("Harap Isi Semua!", MsgBoxStyle.Information, "Informasi")
        Else
            Call Koneksi()
            Dim SimpanData As String = "insert into tb_petugas values('" & txkode.Text & "','" & txnama.Text & "','" & txpass.Text & "','" & cblevel.Text & "')"
            cmd = New SqlCommand(SimpanData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Input", MsgBoxStyle.Information, "Informasi")
            Call KondisiAwal()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txkode.Text = "" Or txnama.Text = "" Or txpass.Text = "" Or cblevel.Text = "" Then
            MsgBox("Harap Isi Semua!", MsgBoxStyle.Information, "Informasi")
        Else
            Call Koneksi()
            Dim EditData As String = "update tb_petugas set namapetugas='" & txnama.Text & "',passwordpetugas='" & txpass.Text & "',levelpetugas='" & cblevel.Text & "' where kodepetugas='" & txkode.Text & "'"
            cmd = New SqlCommand(EditData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Edit", MsgBoxStyle.Information, "Informasi")
            Call KondisiAwal()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txkode.Text = "" Or txnama.Text = "" Or txpass.Text = "" Or cblevel.Text = "" Then
            MsgBox("Harap Isi Semua!", MsgBoxStyle.Information, "Informasi")
        Else
            Call Koneksi()
            Dim HapusData As String = "delete tb_petugas where kodepetugas='" & txkode.Text & "'"
            cmd = New SqlCommand(HapusData, Conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub txkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txkode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            cmd = New SqlCommand("Select * From tb_petugas where kodepetugas='" & txkode.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                txnama.Text = Dr.Item("NamaPetugas")
                txpass.Text = Dr.Item("PasswordPetugas")
                cblevel.Text = Dr.Item("LevelPetugas")
            Else
                MsgBox("Data Tidak Ada", MsgBoxStyle.Information, "Informasi")
            End If
        End If
    End Sub
End Class