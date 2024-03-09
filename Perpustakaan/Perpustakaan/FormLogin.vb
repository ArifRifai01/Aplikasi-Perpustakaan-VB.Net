Imports System.Data.SqlClient
Imports System.Runtime.Intrinsics.Arm

Public Class FormLogin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Call Koneksi()
        cmd = New SqlCommand("Select * From tb_petugas where kodepetugas = '" & txkode.Text & "' and passwordpetugas = '" & txpass.Text & "'", Conn)
        Dr = cmd.ExecuteReader
        Dr.Read()
        If Dr.HasRows Then
            MsgBox("Login Berhasil!", MsgBoxStyle.Information, "Informasi")
            Me.Close()
            Call BukaKunci()
            Beranda.SKode.Text = Dr!kodepetugas
            Beranda.SNama.Text = Dr!namapetugas
            Beranda.SLevel.Text = Dr!levelpetugas
        Else
            MsgBox("Kode pegawai atau password salah!", MsgBoxStyle.Information, "Informasi")
        End If
    End Sub
    Sub BukaKunci()
        Beranda.LoginToolStripMenuItem.Enabled = False
        Beranda.LogoutToolStripMenuItem.Enabled = True
        Beranda.MasterToolStripMenuItem.Enabled = True
        Beranda.TransaksiToolStripMenuItem.Enabled = True
        Beranda.LaporanToolStripMenuItem.Enabled = True
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txkode.Text = "P001"
        txpass.Text = "12345"
        txpass.PasswordChar = "*"
    End Sub
End Class