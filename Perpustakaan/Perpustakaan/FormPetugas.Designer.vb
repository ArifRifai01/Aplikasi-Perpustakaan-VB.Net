<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPetugas
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
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txkode = New TextBox()
        txnama = New TextBox()
        txpass = New TextBox()
        cblevel = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(288, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 31)
        Label1.TabIndex = 1
        Label1.Text = "Data Petugas"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(42, 336)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(650, 201)
        DataGridView1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(140, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 20)
        Label2.TabIndex = 3
        Label2.Text = "Kode Petugas : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(140, 118)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 4
        Label3.Text = "Nama : "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(140, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 20)
        Label4.TabIndex = 5
        Label4.Text = "Password : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(140, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 6
        Label5.Text = "Level : "
        ' 
        ' txkode
        ' 
        txkode.Location = New Point(268, 72)
        txkode.Name = "txkode"
        txkode.Size = New Size(312, 27)
        txkode.TabIndex = 7
        ' 
        ' txnama
        ' 
        txnama.Location = New Point(268, 115)
        txnama.Name = "txnama"
        txnama.Size = New Size(312, 27)
        txnama.TabIndex = 8
        ' 
        ' txpass
        ' 
        txpass.Location = New Point(268, 159)
        txpass.Name = "txpass"
        txpass.Size = New Size(312, 27)
        txpass.TabIndex = 9
        ' 
        ' cblevel
        ' 
        cblevel.FormattingEnabled = True
        cblevel.Location = New Point(268, 205)
        cblevel.Name = "cblevel"
        cblevel.Size = New Size(312, 28)
        cblevel.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(42, 263)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 34)
        Button1.TabIndex = 11
        Button1.Text = "Input"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(218, 263)
        Button2.Name = "Button2"
        Button2.Size = New Size(131, 34)
        Button2.TabIndex = 12
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(392, 263)
        Button3.Name = "Button3"
        Button3.Size = New Size(131, 34)
        Button3.TabIndex = 13
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(561, 263)
        Button4.Name = "Button4"
        Button4.Size = New Size(131, 34)
        Button4.TabIndex = 14
        Button4.Text = "Tutup"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' FormPetugas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        ClientSize = New Size(738, 565)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(cblevel)
        Controls.Add(txpass)
        Controls.Add(txnama)
        Controls.Add(txkode)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "FormPetugas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormPetugas"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txkode As TextBox
    Friend WithEvents txnama As TextBox
    Friend WithEvents txpass As TextBox
    Friend WithEvents cblevel As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
