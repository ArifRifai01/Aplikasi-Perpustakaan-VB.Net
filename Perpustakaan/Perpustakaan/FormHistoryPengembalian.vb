Imports System.Data.SqlClient

Public Class FormHistoryPengembalian
    Private Sub FormHistoryPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        'Call CariData()
        'txkodeanggota.Text = ""
        Call tampildata()

    End Sub
    'Sub CariData()
    '    Call Koneksi()
    '    cmd = New SqlCommand("select * from tb_kembali where kodeanggota = '" & txkodeanggota.Text & "' ", Conn)
    '    Dr = cmd.ExecuteReader
    '    DataGridView1.Rows.Clear()
    '    Do While Dr.Read = True
    '        ' Menggunakan fungsi Format untuk merubah format tanggal
    '        Dim tanggalkembali As Date = Dr.Item("tanggalkembali")
    '        Dim tanggalFormatted As String = Format(tanggalkembali, "dd/MM/yyyy")

    '        DataGridView1.Rows.Add(Dr.Item("nokembali"), tanggalFormatted, Dr.Item("totalkembali"), Dr.Item("denda"), Dr.Item("kodeanggota"), Dr.Item("kodepetugas"))
    '    Loop
    'End Sub
    'Private Sub txkodeanggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txkodeanggota.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        Call Koneksi()
    '        Da = New SqlDataAdapter("select * from tb_kembali where kodeanggota = '" & txkodeanggota.Text & "' ", Conn)
    '        Ds = New DataSet
    '        Da.Fill(Ds.Tables("tb_kembali"))
    '        DataGridView1.DataSource = (Ds.Tables("tb_kembali"))
    '        DataGridView1.ReadOnly = True
    '        If Not Dr.HasRows Then
    '            MsgBox("Tidak Ada Data Ditemukan", MsgBoxStyle.Information, "Informasi")
    '        End If
    '    End If
    'End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
    Sub tampildata()
        Call Koneksi()
        Da = New SqlDataAdapter("Select nokembali,tanggalkembali,totalkembali,denda,kodeanggota,kodepetugas from tb_kembali", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tb_kembali")
        DataGridView1.DataSource = (Ds.Tables("tb_kembali"))
        DataGridView1.ReadOnly = True
    End Sub
End Class