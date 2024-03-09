<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnggota
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
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        cbkelamin = New ComboBox()
        txalamat = New TextBox()
        txnama = New TextBox()
        txkode = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        label6 = New Label()
        txtelepon = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(567, 294)
        Button4.Name = "Button4"
        Button4.Size = New Size(131, 34)
        Button4.TabIndex = 9
        Button4.Text = "Tutup"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(398, 294)
        Button3.Name = "Button3"
        Button3.Size = New Size(131, 34)
        Button3.TabIndex = 8
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(224, 294)
        Button2.Name = "Button2"
        Button2.Size = New Size(131, 34)
        Button2.TabIndex = 7
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(48, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 34)
        Button1.TabIndex = 6
        Button1.Text = "Input"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cbkelamin
        ' 
        cbkelamin.FormattingEnabled = True
        cbkelamin.Location = New Point(274, 132)
        cbkelamin.Name = "cbkelamin"
        cbkelamin.Size = New Size(312, 28)
        cbkelamin.TabIndex = 3
        ' 
        ' txalamat
        ' 
        txalamat.Location = New Point(274, 178)
        txalamat.Multiline = True
        txalamat.Name = "txalamat"
        txalamat.Size = New Size(312, 54)
        txalamat.TabIndex = 4
        ' 
        ' txnama
        ' 
        txnama.Location = New Point(274, 88)
        txnama.Name = "txnama"
        txnama.Size = New Size(312, 27)
        txnama.TabIndex = 2
        ' 
        ' txkode
        ' 
        txkode.Location = New Point(274, 45)
        txkode.Name = "txkode"
        txkode.Size = New Size(312, 27)
        txkode.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(146, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 20
        Label5.Text = "Alamat : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(146, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 20)
        Label4.TabIndex = 19
        Label4.Text = "Jenis Kelamin : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(146, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 18
        Label3.Text = "Nama : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(146, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 20)
        Label2.TabIndex = 17
        Label2.Text = "Kode Anggota : "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(48, 354)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(650, 195)
        DataGridView1.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(294, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 31)
        Label1.TabIndex = 15
        Label1.Text = "Data Anggota"
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        label6.Location = New Point(146, 248)
        label6.Name = "label6"
        label6.Size = New Size(101, 20)
        label6.TabIndex = 29
        label6.Text = "No Telepon : "
        ' 
        ' txtelepon
        ' 
        txtelepon.Location = New Point(274, 245)
        txtelepon.Name = "txtelepon"
        txtelepon.Size = New Size(312, 27)
        txtelepon.TabIndex = 5
        ' 
        ' FormAnggota
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        ClientSize = New Size(748, 567)
        Controls.Add(txtelepon)
        Controls.Add(label6)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(cbkelamin)
        Controls.Add(txalamat)
        Controls.Add(txnama)
        Controls.Add(txkode)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "FormAnggota"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormAnggota"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cbkelamin As ComboBox
    Friend WithEvents txalamat As TextBox
    Friend WithEvents txnama As TextBox
    Friend WithEvents txkode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents label6 As Label
    Friend WithEvents txtelepon As TextBox
End Class
