<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nip = New System.Windows.Forms.ComboBox()
        Me.nama = New System.Windows.Forms.ComboBox()
        Me.golongan = New System.Windows.Forms.ComboBox()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.gaji = New System.Windows.Forms.TextBox()
        Me.tkeluarga = New System.Windows.Forms.TextBox()
        Me.tgaji = New System.Windows.Forms.TextBox()
        Me.btnproses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(54, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(54, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Golongan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gaji"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tun.j Keluarga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Gaji"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(305, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 36)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Pengajian"
        '
        'nip
        '
        Me.nip.FormattingEnabled = True
        Me.nip.Location = New System.Drawing.Point(174, 56)
        Me.nip.Name = "nip"
        Me.nip.Size = New System.Drawing.Size(121, 21)
        Me.nip.TabIndex = 8
        '
        'nama
        '
        Me.nama.FormattingEnabled = True
        Me.nama.Location = New System.Drawing.Point(174, 88)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(121, 21)
        Me.nama.TabIndex = 9
        '
        'golongan
        '
        Me.golongan.FormattingEnabled = True
        Me.golongan.Location = New System.Drawing.Point(174, 119)
        Me.golongan.Name = "golongan"
        Me.golongan.Size = New System.Drawing.Size(121, 21)
        Me.golongan.TabIndex = 10
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Location = New System.Drawing.Point(174, 180)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(121, 21)
        Me.status.TabIndex = 11
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(235, 295)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 13
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(345, 295)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnkeluar.TabIndex = 14
        Me.btnkeluar.Text = "KELUAR"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'gaji
        '
        Me.gaji.Location = New System.Drawing.Point(174, 154)
        Me.gaji.Name = "gaji"
        Me.gaji.Size = New System.Drawing.Size(121, 20)
        Me.gaji.TabIndex = 18
        '
        'tkeluarga
        '
        Me.tkeluarga.Location = New System.Drawing.Point(174, 206)
        Me.tkeluarga.Name = "tkeluarga"
        Me.tkeluarga.Size = New System.Drawing.Size(121, 20)
        Me.tkeluarga.TabIndex = 19
        '
        'tgaji
        '
        Me.tgaji.Location = New System.Drawing.Point(174, 236)
        Me.tgaji.Name = "tgaji"
        Me.tgaji.Size = New System.Drawing.Size(121, 20)
        Me.tgaji.TabIndex = 20
        '
        'btnproses
        '
        Me.btnproses.Location = New System.Drawing.Point(137, 295)
        Me.btnproses.Name = "btnproses"
        Me.btnproses.Size = New System.Drawing.Size(75, 23)
        Me.btnproses.TabIndex = 21
        Me.btnproses.Text = "PROSES"
        Me.btnproses.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnproses)
        Me.Controls.Add(Me.tgaji)
        Me.Controls.Add(Me.tkeluarga)
        Me.Controls.Add(Me.gaji)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.golongan)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.nip)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents nip As ComboBox
    Friend WithEvents nama As ComboBox
    Friend WithEvents golongan As ComboBox
    Friend WithEvents status As ComboBox
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnkeluar As Button
    Friend WithEvents gaji As TextBox
    Friend WithEvents tkeluarga As TextBox
    Friend WithEvents tgaji As TextBox
    Friend WithEvents btnproses As Button
End Class
