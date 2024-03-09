Imports Microsoft.VisualBasic.Logging

Public Class Beranda
    Sub kosong()
        SKode.Text = "-"
        SNama.Text = "-"
        SLevel.Text = "-"
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()
    End Sub
    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.Show()
    End Sub
    Private Sub Beranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
        STanggal.Text = Today.ToString("dd/MM/yyyy")
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MsgBox("Yakin Akan Logout?", vbYesNo, "Informasi") = vbYes Then
            Call Terkunci()
            Call kosong()
        End If
    End Sub
    Private Sub PegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem.Click
        FormPetugas.ShowDialog()
    End Sub
    Private Sub AnggotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnggotaToolStripMenuItem.Click
        FormAnggota.ShowDialog()
    End Sub
    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        FormBuku.ShowDialog()
    End Sub
    Private Sub PeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeminjamanToolStripMenuItem.Click
        FormPeminjaman.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SJam.Text = TimeOfDay
    End Sub
    Private Sub PengembalianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengembalianToolStripMenuItem.Click
        FormPengembalian.ShowDialog()

    End Sub

    Private Sub LaporanPeminjamanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPeminjamanToolStripMenuItem.Click
        FormHistoryPeminjaman.ShowDialog()
    End Sub

    Private Sub LaporanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem1.Click
        FormHistoryPengembalian.ShowDialog()

    End Sub
End Class
