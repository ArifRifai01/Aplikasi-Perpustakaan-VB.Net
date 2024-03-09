<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuku
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
        label6 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        txpenerbit = New TextBox()
        txjudul = New TextBox()
        txkode = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label7 = New Label()
        txjumlah = New TextBox()
        txpengarang = New TextBox()
        txtahun = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        label6.Location = New Point(189, 232)
        label6.Name = "label6"
        label6.Size = New Size(64, 20)
        label6.TabIndex = 45
        label6.Text = "Tahun : "
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(627, 322)
        Button4.Name = "Button4"
        Button4.Size = New Size(131, 34)
        Button4.TabIndex = 38
        Button4.Text = "Tutup"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(458, 322)
        Button3.Name = "Button3"
        Button3.Size = New Size(131, 34)
        Button3.TabIndex = 37
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(284, 322)
        Button2.Name = "Button2"
        Button2.Size = New Size(131, 34)
        Button2.TabIndex = 36
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(108, 322)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 34)
        Button1.TabIndex = 35
        Button1.Text = "Input"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txpenerbit
        ' 
        txpenerbit.Location = New Point(317, 183)
        txpenerbit.Multiline = True
        txpenerbit.Name = "txpenerbit"
        txpenerbit.Size = New Size(379, 27)
        txpenerbit.TabIndex = 33
        ' 
        ' txjudul
        ' 
        txjudul.Location = New Point(317, 93)
        txjudul.Name = "txjudul"
        txjudul.Size = New Size(379, 27)
        txjudul.TabIndex = 31
        ' 
        ' txkode
        ' 
        txkode.Location = New Point(317, 50)
        txkode.Name = "txkode"
        txkode.Size = New Size(185, 27)
        txkode.TabIndex = 30
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(189, 186)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 20)
        Label5.TabIndex = 44
        Label5.Text = "Penerbit : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(189, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 20)
        Label4.TabIndex = 43
        Label4.Text = "Pengarang : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(189, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 20)
        Label3.TabIndex = 42
        Label3.Text = "Judul : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(189, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 41
        Label2.Text = "Kode Buku : "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(51, 385)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(786, 223)
        DataGridView1.TabIndex = 40
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(376, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 31)
        Label1.TabIndex = 39
        Label1.Text = "Data Buku"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(189, 279)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 20)
        Label7.TabIndex = 46
        Label7.Text = "Stok : "
        ' 
        ' txjumlah
        ' 
        txjumlah.Location = New Point(317, 276)
        txjumlah.Name = "txjumlah"
        txjumlah.Size = New Size(185, 27)
        txjumlah.TabIndex = 47
        ' 
        ' txpengarang
        ' 
        txpengarang.Location = New Point(317, 137)
        txpengarang.Multiline = True
        txpengarang.Name = "txpengarang"
        txpengarang.Size = New Size(379, 27)
        txpengarang.TabIndex = 48
        ' 
        ' txtahun
        ' 
        txtahun.Location = New Point(317, 229)
        txtahun.Name = "txtahun"
        txtahun.Size = New Size(185, 27)
        txtahun.TabIndex = 34
        ' 
        ' FormBuku
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        ClientSize = New Size(891, 631)
        Controls.Add(txpengarang)
        Controls.Add(txjumlah)
        Controls.Add(Label7)
        Controls.Add(txtahun)
        Controls.Add(label6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txpenerbit)
        Controls.Add(txjudul)
        Controls.Add(txkode)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "FormBuku"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Buku"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txpenerbit As TextBox
    Friend WithEvents txjudul As TextBox
    Friend WithEvents txkode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txjumlah As TextBox
    Friend WithEvents txpengarang As TextBox
    Friend WithEvents txtahun As TextBox
End Class
