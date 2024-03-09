<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Label2 = New Label()
        Label3 = New Label()
        txkode = New TextBox()
        txpass = New TextBox()
        Login = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(276, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 31)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(71, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 20)
        Label2.TabIndex = 1
        Label2.Text = "Kode Petugas : "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(71, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password : "
        ' 
        ' txkode
        ' 
        txkode.Location = New Point(215, 132)
        txkode.Name = "txkode"
        txkode.Size = New Size(252, 27)
        txkode.TabIndex = 3
        ' 
        ' txpass
        ' 
        txpass.Location = New Point(215, 180)
        txpass.Name = "txpass"
        txpass.Size = New Size(252, 27)
        txpass.TabIndex = 4
        ' 
        ' Login
        ' 
        Login.Location = New Point(218, 252)
        Login.Name = "Login"
        Login.Size = New Size(116, 41)
        Login.TabIndex = 5
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(351, 252)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 41)
        Button2.TabIndex = 6
        Button2.Text = "Keluar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(632, 366)
        Controls.Add(Button2)
        Controls.Add(Login)
        Controls.Add(txpass)
        Controls.Add(txkode)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormLogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txkode As TextBox
    Friend WithEvents txpass As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents Button2 As Button
End Class
