<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlAwning = New Panel()
        pnlLatar = New Panel()
        lblBrandTagline = New Label()
        lblBrandNama = New Label()
        lblBrandSistem = New Label()
        flpFoodIcons = New FlowLayoutPanel()
        pnlKanan = New Panel()
        pnlKartu = New Panel()
        lblVersi = New Label()
        btnLogin = New Button()
        chkTampilPassword = New CheckBox()
        txtPassword = New TextBox()
        lblPassword = New Label()
        txtUsername = New TextBox()
        lblUsername = New Label()
        lblSubjudul = New Label()
        lblJudul = New Label()
        pnlLatar.SuspendLayout()
        pnlKanan.SuspendLayout()
        pnlKartu.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlAwning
        ' 
        pnlAwning.Dock = DockStyle.Top
        pnlAwning.Location = New Point(0, 0)
        pnlAwning.Name = "pnlAwning"
        pnlAwning.Size = New Size(1300, 16)
        pnlAwning.TabIndex = 2
        ' 
        ' pnlLatar
        ' 
        pnlLatar.BackColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        pnlLatar.Controls.Add(lblBrandTagline)
        pnlLatar.Controls.Add(lblBrandNama)
        pnlLatar.Controls.Add(lblBrandSistem)
        pnlLatar.Controls.Add(flpFoodIcons)
        pnlLatar.Dock = DockStyle.Left
        pnlLatar.Location = New Point(0, 16)
        pnlLatar.Name = "pnlLatar"
        pnlLatar.Padding = New Padding(40, 24, 40, 24)
        pnlLatar.Size = New Size(700, 724)
        pnlLatar.TabIndex = 1
        ' 
        ' lblBrandTagline
        ' 
        lblBrandTagline.Font = New Font("Segoe UI", 11.0F)
        lblBrandTagline.ForeColor = Color.FromArgb(CByte(190), CByte(175), CByte(160))
        lblBrandTagline.Location = New Point(40, 520)
        lblBrandTagline.Name = "lblBrandTagline"
        lblBrandTagline.Size = New Size(620, 36)
        lblBrandTagline.TabIndex = 0
        lblBrandTagline.Text = "Cita rasa Solo asli, dicatat rapi dari meja hingga kasir."
        ' 
        ' lblBrandNama
        ' 
        lblBrandNama.Font = New Font("Georgia", 34.0F, FontStyle.Bold)
        lblBrandNama.ForeColor = Color.FromArgb(CByte(245), CByte(240), CByte(232))
        lblBrandNama.Location = New Point(40, 340)
        lblBrandNama.Name = "lblBrandNama"
        lblBrandNama.Size = New Size(620, 165)
        lblBrandNama.TabIndex = 1
        lblBrandNama.Text = "Waroeng" & vbCrLf & "Wong Solo"
        lblBrandNama.UseCompatibleTextRendering = True
        ' 
        ' lblBrandSistem
        ' 
        lblBrandSistem.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblBrandSistem.ForeColor = Color.FromArgb(CByte(196), CByte(98), CByte(45))
        lblBrandSistem.Location = New Point(40, 310)
        lblBrandSistem.Name = "lblBrandSistem"
        lblBrandSistem.Size = New Size(620, 26)
        lblBrandSistem.TabIndex = 2
        lblBrandSistem.Text = "SISTEM PEMESANAN WARUNG"
        ' 
        ' flpFoodIcons
        ' 
        flpFoodIcons.BackColor = Color.Transparent
        flpFoodIcons.Location = New Point(40, 36)
        flpFoodIcons.Name = "flpFoodIcons"
        flpFoodIcons.Size = New Size(620, 160
                                     )
        flpFoodIcons.TabIndex = 3
        ' 
        ' pnlKanan
        ' 
        pnlKanan.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(232))
        pnlKanan.Controls.Add(pnlKartu)
        pnlKanan.Dock = DockStyle.Fill
        pnlKanan.Location = New Point(700, 16)
        pnlKanan.Name = "pnlKanan"
        pnlKanan.Size = New Size(600, 724)
        pnlKanan.TabIndex = 0
        ' 
        ' pnlKartu
        ' 
        pnlKartu.BackColor = Color.White
        pnlKartu.Controls.Add(lblVersi)
        pnlKartu.Controls.Add(btnLogin)
        pnlKartu.Controls.Add(chkTampilPassword)
        pnlKartu.Controls.Add(txtPassword)
        pnlKartu.Controls.Add(lblPassword)
        pnlKartu.Controls.Add(txtUsername)
        pnlKartu.Controls.Add(lblUsername)
        pnlKartu.Controls.Add(lblSubjudul)
        pnlKartu.Controls.Add(lblJudul)
        pnlKartu.Location = New Point(80, 70)
        pnlKartu.Name = "pnlKartu"
        pnlKartu.Padding = New Padding(36)
        pnlKartu.Size = New Size(440, 540)
        pnlKartu.TabIndex = 0
        ' 
        ' lblVersi
        ' 
        lblVersi.Font = New Font("Segoe UI", 8.0F)
        lblVersi.ForeColor = Color.FromArgb(CByte(160), CByte(150), CByte(140))
        lblVersi.Location = New Point(36, 400)
        lblVersi.Name = "lblVersi"
        lblVersi.Size = New Size(368, 22)
        lblVersi.TabIndex = 0

        lblVersi.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(196), CByte(98), CByte(45))
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(36, 320)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(368, 52)
        btnLogin.TabIndex = 1
        btnLogin.Text = "MASUK"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' chkTampilPassword
        ' 
        chkTampilPassword.Font = New Font("Segoe UI", 9.5F)
        chkTampilPassword.ForeColor = Color.FromArgb(CByte(110), CByte(100), CByte(90))
        chkTampilPassword.Location = New Point(36, 274)
        chkTampilPassword.Name = "chkTampilPassword"
        chkTampilPassword.Size = New Size(220, 26)
        chkTampilPassword.TabIndex = 2
        chkTampilPassword.Text = "Tampilkan kata sandi"
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 11.0F)
        txtPassword.Location = New Point(36, 226)
        txtPassword.MaxLength = 100
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "•"c
        txtPassword.Size = New Size(368, 32)
        txtPassword.TabIndex = 3
        ' 
        ' lblPassword
        ' 
        lblPassword.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        lblPassword.Location = New Point(36, 202)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(368, 20)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 11.0F)
        txtUsername.Location = New Point(36, 152)
        txtUsername.MaxLength = 50
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(368, 32)
        txtUsername.TabIndex = 5
        ' 
        ' lblUsername
        ' 
        lblUsername.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        lblUsername.Location = New Point(36, 128)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(368, 20)
        lblUsername.TabIndex = 6
        lblUsername.Text = "Username"
        ' 
        ' lblSubjudul
        ' 
        lblSubjudul.Font = New Font("Segoe UI", 10.0F)
        lblSubjudul.ForeColor = Color.FromArgb(CByte(110), CByte(100), CByte(90))
        lblSubjudul.Location = New Point(36, 88)
        lblSubjudul.Name = "lblSubjudul"
        lblSubjudul.Size = New Size(368, 26)
        lblSubjudul.TabIndex = 7
        lblSubjudul.Text = "Masuk sebagai Admin atau Kasir."
        ' 
        ' lblJudul
        ' 
        lblJudul.Font = New Font("Georgia", 24.0F, FontStyle.Bold)
        lblJudul.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        lblJudul.Location = New Point(36, 28)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(368, 54)
        lblJudul.TabIndex = 8
        lblJudul.Text = "Sugeng Rawuh"
        lblJudul.UseCompatibleTextRendering = True
        ' 
        ' FormLogin
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1300, 740)
        Controls.Add(pnlKanan)
        Controls.Add(pnlLatar)
        Controls.Add(pnlAwning)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormLogin — Waroeng Wong Solo"
        pnlLatar.ResumeLayout(False)
        pnlKanan.ResumeLayout(False)
        pnlKartu.ResumeLayout(False)
        pnlKartu.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlAwning As System.Windows.Forms.Panel
    Friend WithEvents pnlLatar As System.Windows.Forms.Panel
    Friend WithEvents flpFoodIcons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblBrandSistem As System.Windows.Forms.Label
    Friend WithEvents lblBrandNama As System.Windows.Forms.Label
    Friend WithEvents lblBrandTagline As System.Windows.Forms.Label
    Friend WithEvents pnlKanan As System.Windows.Forms.Panel
    Friend WithEvents pnlKartu As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblSubjudul As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents chkTampilPassword As System.Windows.Forms.CheckBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblVersi As System.Windows.Forms.Label

End Class