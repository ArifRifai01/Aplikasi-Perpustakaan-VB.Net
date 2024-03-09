Imports System.Data.SqlClient
Public Class FormHistoryPeminjaman
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
    'Sub CariData()
    '    Call Koneksi()
    '    cmd = New SqlCommand("select * from tb_pinjam where kodeanggota = '" & txkodeanggota.Text & "' ", Conn)
    '    Dr = cmd.ExecuteReader
    '    DataGridView1.Rows.Clear()
    '    Do While Dr.Read = True
    '        ' Menggunakan fungsi Format untuk merubah format tanggal
    '        Dim tanggalPinjam As Date = Dr.Item("tanggalpinjam")
    '        Dim tanggalFormatted As String = Format(tanggalPinjam, "dd/MM/yyyy")

    '        DataGridView1.Rows.Add(Dr.Item("nopinjam"), tanggalFormatted, Dr.Item("jampinjam"), Dr.Item("kodeanggota"), Dr.Item("itempinjam"), Dr.Item("kodepetugas"))
    '    Loop
    'End Sub
    'Private Sub txkodeanggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txkodeanggota.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        Call CariData()
    '        If Not Dr.HasRows Then
    '            MsgBox("Tidak Ada Data Ditemukan", MsgBoxStyle.Information, "Informasi")
    '        End If
    '    End If
    'End Sub

    Private Sub FormHistoryPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        'Call CariData()
        Call tampildata()

    End Sub
    Sub tampildata()
        Call Koneksi()
        Da = New SqlDataAdapter("select nopinjam,tanggalpinjam,jampinjam,kodeanggota,itempinjam,kodepetugas from tb_pinjam", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_pinjam")
        DataGridView1.DataSource = (Ds.Tables("tb_pinjam"))
        DataGridView1.ReadOnly = True

    End Sub
End Class