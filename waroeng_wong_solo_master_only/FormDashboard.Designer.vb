<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        pnlSidebar = New Panel()
        lblAppName = New Label()
        lblAppSub = New Label()
        pnlDivider = New Panel()
        btnNavBeranda = New Button()
        btnNavKategori = New Button()
        btnNavMenu = New Button()
        btnNavPesanan = New Button()
        btnNavPembayaran = New Button()
        btnNavLaporan = New Button()
        pnlSidebarBottom = New Panel()
        lblUserInfo = New Label()
        btnLogout = New Button()
        pnlKonten = New Panel()
        pnlMenuAndalan = New FlowLayoutPanel()
        lblMenuAndalanJudul = New Label()
        pnlQuickCards = New FlowLayoutPanel()
        cardPesanan = New Panel()
        lblCardPesananJudul = New Label()
        lblCardPesananSub = New Label()
        cardBayar = New Panel()
        lblCardBayarJudul = New Label()
        lblCardBayarSub = New Label()
        cardMenu = New Panel()
        lblCardMenuJudul = New Label()
        lblCardMenuSub = New Label()
        cardKategori = New Panel()
        lblCardKatJudul = New Label()
        lblCardKatSub = New Label()
        cardLaporan = New Panel()
        lblCardLapJudul = New Label()
        lblCardLapSub = New Label()
        lblSubSelamatDatang = New Label()
        lblSelamatDatang = New Label()
        pnlAwning = New Panel()
        pnlSidebar.SuspendLayout()
        pnlSidebarBottom.SuspendLayout()
        pnlKonten.SuspendLayout()
        pnlQuickCards.SuspendLayout()
        cardPesanan.SuspendLayout()
        cardBayar.SuspendLayout()
        cardMenu.SuspendLayout()
        cardKategori.SuspendLayout()
        cardLaporan.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        pnlSidebar.Controls.Add(lblAppName)
        pnlSidebar.Controls.Add(lblAppSub)
        pnlSidebar.Controls.Add(pnlDivider)
        pnlSidebar.Controls.Add(btnNavBeranda)
        pnlSidebar.Controls.Add(btnNavKategori)
        pnlSidebar.Controls.Add(btnNavMenu)
        pnlSidebar.Controls.Add(btnNavPesanan)
        pnlSidebar.Controls.Add(btnNavPembayaran)
        pnlSidebar.Controls.Add(btnNavLaporan)
        pnlSidebar.Controls.Add(pnlSidebarBottom)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(260, 840)
        pnlSidebar.TabIndex = 1
        ' 
        ' lblAppName
        ' 
        lblAppName.Font = New Font("Georgia", 13.5F, FontStyle.Bold)
        lblAppName.ForeColor = Color.FromArgb(CByte(196), CByte(98), CByte(45))
        lblAppName.Location = New Point(16, 20)
        lblAppName.Name = "lblAppName"
        lblAppName.Size = New Size(235, 46)
        lblAppName.TabIndex = 0
        lblAppName.Text = "Waroeng Wong Solo"
        lblAppName.TextAlign = ContentAlignment.MiddleLeft
        lblAppName.UseCompatibleTextRendering = True
        ' 
        ' lblAppSub
        ' 
        lblAppSub.Location = New Point(0, 0)
        lblAppSub.Name = "lblAppSub"
        lblAppSub.Size = New Size(1, 1)
        lblAppSub.TabIndex = 1
        ' 
        ' pnlDivider
        ' 
        pnlDivider.BackColor = Color.FromArgb(CByte(80), CByte(50), CByte(30))
        pnlDivider.Location = New Point(16, 76)
        pnlDivider.Name = "pnlDivider"
        pnlDivider.Size = New Size(226, 1)
        pnlDivider.TabIndex = 2
        ' 
        ' btnNavBeranda
        ' 
        btnNavBeranda.BackColor = Color.FromArgb(CByte(196), CByte(98), CByte(45))
        btnNavBeranda.Cursor = Cursors.Hand
        btnNavBeranda.FlatAppearance.BorderSize = 0
        btnNavBeranda.FlatStyle = FlatStyle.Flat
        btnNavBeranda.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnNavBeranda.ForeColor = Color.White
        btnNavBeranda.Location = New Point(10, 90)
        btnNavBeranda.Name = "btnNavBeranda"
        btnNavBeranda.Padding = New Padding(16, 0, 0, 0)
        btnNavBeranda.Size = New Size(240, 46)
        btnNavBeranda.TabIndex = 3
        btnNavBeranda.Text = "  Beranda"
        btnNavBeranda.TextAlign = ContentAlignment.MiddleLeft
        btnNavBeranda.UseVisualStyleBackColor = False
        ' 
        ' btnNavKategori
        ' 
        btnNavKategori.BackColor = Color.Transparent
        btnNavKategori.Cursor = Cursors.Hand
        btnNavKategori.FlatAppearance.BorderSize = 0
        btnNavKategori.FlatStyle = FlatStyle.Flat
        btnNavKategori.Font = New Font("Segoe UI", 9.5F)
        btnNavKategori.ForeColor = Color.FromArgb(CByte(200), CByte(180), CByte(160))
        btnNavKategori.Location = New Point(10, 148)
        btnNavKategori.Name = "btnNavKategori"
        btnNavKategori.Padding = New Padding(16, 0, 0, 0)
        btnNavKategori.Size = New Size(240, 44)
        btnNavKategori.TabIndex = 4
        btnNavKategori.Text = "  Master Kategori Menu"
        btnNavKategori.TextAlign = ContentAlignment.MiddleLeft
        btnNavKategori.UseVisualStyleBackColor = False
        ' 
        ' btnNavMenu
        ' 
        btnNavMenu.BackColor = Color.Transparent
        btnNavMenu.Cursor = Cursors.Hand
        btnNavMenu.FlatAppearance.BorderSize = 0
        btnNavMenu.FlatStyle = FlatStyle.Flat
        btnNavMenu.Font = New Font("Segoe UI", 9.5F)
        btnNavMenu.ForeColor = Color.FromArgb(CByte(200), CByte(180), CByte(160))
        btnNavMenu.Location = New Point(10, 194)
        btnNavMenu.Name = "btnNavMenu"
        btnNavMenu.Padding = New Padding(16, 0, 0, 0)
        btnNavMenu.Size = New Size(240, 44)
        btnNavMenu.TabIndex = 5
        btnNavMenu.Text = "  Master Data Menu"
        btnNavMenu.TextAlign = ContentAlignment.MiddleLeft
        btnNavMenu.UseVisualStyleBackColor = False
        ' 
        ' btnNavPesanan
        ' 
        btnNavPesanan.BackColor = Color.Transparent
        btnNavPesanan.Cursor = Cursors.Hand
        btnNavPesanan.FlatAppearance.BorderSize = 0
        btnNavPesanan.FlatStyle = FlatStyle.Flat
        btnNavPesanan.Font = New Font("Segoe UI", 9.5F)
        btnNavPesanan.ForeColor = Color.FromArgb(CByte(200), CByte(180), CByte(160))
        btnNavPesanan.Location = New Point(10, 240)
        btnNavPesanan.Name = "btnNavPesanan"
        btnNavPesanan.Padding = New Padding(16, 0, 0, 0)
        btnNavPesanan.Size = New Size(240, 44)
        btnNavPesanan.TabIndex = 6
        btnNavPesanan.Text = "  Transaksi Pesanan"
        btnNavPesanan.TextAlign = ContentAlignment.MiddleLeft
        btnNavPesanan.UseVisualStyleBackColor = False
        ' 
        ' btnNavPembayaran
        ' 
        btnNavPembayaran.BackColor = Color.Transparent
        btnNavPembayaran.Cursor = Cursors.Hand
        btnNavPembayaran.FlatAppearance.BorderSize = 0
        btnNavPembayaran.FlatStyle = FlatStyle.Flat
        btnNavPembayaran.Font = New Font("Segoe UI", 9.5F)
        btnNavPembayaran.ForeColor = Color.FromArgb(CByte(200), CByte(180), CByte(160))
        btnNavPembayaran.Location = New Point(10, 286)
        btnNavPembayaran.Name = "btnNavPembayaran"
        btnNavPembayaran.Padding = New Padding(16, 0, 0, 0)
        btnNavPembayaran.Size = New Size(240, 44)
        btnNavPembayaran.TabIndex = 7
        btnNavPembayaran.Text = "  Kasir Pembayaran"
        btnNavPembayaran.TextAlign = ContentAlignment.MiddleLeft
        btnNavPembayaran.UseVisualStyleBackColor = False
        ' 
        ' btnNavLaporan
        ' 
        btnNavLaporan.BackColor = Color.Transparent
        btnNavLaporan.Cursor = Cursors.Hand
        btnNavLaporan.FlatAppearance.BorderSize = 0
        btnNavLaporan.FlatStyle = FlatStyle.Flat
        btnNavLaporan.Font = New Font("Segoe UI", 9.5F)
        btnNavLaporan.ForeColor = Color.FromArgb(CByte(200), CByte(180), CByte(160))
        btnNavLaporan.Location = New Point(10, 332)
        btnNavLaporan.Name = "btnNavLaporan"
        btnNavLaporan.Padding = New Padding(16, 0, 0, 0)
        btnNavLaporan.Size = New Size(240, 44)
        btnNavLaporan.TabIndex = 8
        btnNavLaporan.Text = "  Laporan Penjualan"
        btnNavLaporan.TextAlign = ContentAlignment.MiddleLeft
        btnNavLaporan.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarBottom
        ' 
        pnlSidebarBottom.BackColor = Color.FromArgb(CByte(30), CByte(15), CByte(8))
        pnlSidebarBottom.Controls.Add(lblUserInfo)
        pnlSidebarBottom.Controls.Add(btnLogout)
        pnlSidebarBottom.Dock = DockStyle.Bottom
        pnlSidebarBottom.Location = New Point(0, 750)
        pnlSidebarBottom.Name = "pnlSidebarBottom"
        pnlSidebarBottom.Size = New Size(260, 90)
        pnlSidebarBottom.TabIndex = 9
        ' 
        ' lblUserInfo
        ' 
        lblUserInfo.Font = New Font("Segoe UI", 8.5F)
        lblUserInfo.ForeColor = Color.FromArgb(CByte(170), CByte(150), CByte(130))
        lblUserInfo.Location = New Point(12, 6)
        lblUserInfo.Name = "lblUserInfo"
        lblUserInfo.Size = New Size(240, 30)
        lblUserInfo.TabIndex = 0
        lblUserInfo.Text = "Memuat..."
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(60), CByte(35), CByte(20))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderColor = Color.FromArgb(CByte(196), CByte(98), CByte(45))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnLogout.ForeColor = Color.FromArgb(CByte(196), CByte(98), CByte(45))
        btnLogout.Location = New Point(16, 46)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(226, 36)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Keluar / Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlKonten
        ' 
        pnlKonten.AutoScroll = True
        pnlKonten.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(232))
        pnlKonten.Controls.Add(pnlMenuAndalan)
        pnlKonten.Controls.Add(lblMenuAndalanJudul)
        pnlKonten.Controls.Add(pnlQuickCards)
        pnlKonten.Controls.Add(lblSubSelamatDatang)
        pnlKonten.Controls.Add(lblSelamatDatang)
        pnlKonten.Controls.Add(pnlAwning)
        pnlKonten.Dock = DockStyle.Fill
        pnlKonten.Location = New Point(260, 0)
        pnlKonten.Name = "pnlKonten"
        pnlKonten.Size = New Size(1180, 840)
        pnlKonten.TabIndex = 0
        ' 
        ' pnlMenuAndalan
        ' 
        pnlMenuAndalan.Location = New Point(32, 268)
        pnlMenuAndalan.Name = "pnlMenuAndalan"
        pnlMenuAndalan.Size = New Size(1120, 520)
        pnlMenuAndalan.TabIndex = 0
        ' 
        ' lblMenuAndalanJudul
        ' 
        lblMenuAndalanJudul.Font = New Font("Georgia", 17.0F, FontStyle.Bold)
        lblMenuAndalanJudul.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        lblMenuAndalanJudul.Location = New Point(32, 225)
        lblMenuAndalanJudul.Name = "lblMenuAndalanJudul"
        lblMenuAndalanJudul.Size = New Size(1000, 34)
        lblMenuAndalanJudul.TabIndex = 1
        lblMenuAndalanJudul.Text = "Menu Andalan Warung"
        ' 
        ' pnlQuickCards
        ' 
        pnlQuickCards.Controls.Add(cardPesanan)
        pnlQuickCards.Controls.Add(cardBayar)
        pnlQuickCards.Controls.Add(cardMenu)
        pnlQuickCards.Controls.Add(cardKategori)
        pnlQuickCards.Controls.Add(cardLaporan)
        pnlQuickCards.Location = New Point(32, 115)
        pnlQuickCards.Name = "pnlQuickCards"
        pnlQuickCards.Size = New Size(1120, 95)
        pnlQuickCards.TabIndex = 2
        ' 
        ' cardPesanan
        ' 
        cardPesanan.BackColor = Color.White
        cardPesanan.Controls.Add(lblCardPesananJudul)
        cardPesanan.Controls.Add(lblCardPesananSub)
        cardPesanan.Cursor = Cursors.Hand
        cardPesanan.Location = New Point(0, 0)
        cardPesanan.Margin = New Padding(0, 0, 12, 0)
        cardPesanan.Name = "cardPesanan"
        cardPesanan.Size = New Size(210, 86)
        cardPesanan.TabIndex = 0
        ' 
        ' lblCardPesananJudul
        ' 
        lblCardPesananJudul.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCardPesananJudul.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        lblCardPesananJudul.Location = New Point(12, 16)
        lblCardPesananJudul.Name = "lblCardPesananJudul"
        lblCardPesananJudul.Size = New Size(185, 24)
        lblCardPesananJudul.TabIndex = 0
        lblCardPesananJudul.Text = "Transaksi Pesanan"
        ' 
        ' lblCardPesananSub
        ' 
        lblCardPesananSub.Font = New Font("Segoe UI", 8.5F)
        lblCardPesananSub.ForeColor = Color.Gray
        lblCardPesananSub.Location = New Point(12, 42)
        lblCardPesananSub.Name = "lblCardPesananSub"
        lblCardPesananSub.Size = New Size(185, 22)
        lblCardPesananSub.TabIndex = 1
        lblCardPesananSub.Text = "Dine-in & Take-away"
        ' 
        ' cardBayar
        ' 
        cardBayar.BackColor = Color.White
        cardBayar.Controls.Add(lblCardBayarJudul)
        cardBayar.Controls.Add(lblCardBayarSub)
        cardBayar.Cursor = Cursors.Hand
        cardBayar.Location = New Point(222, 0)
        cardBayar.Margin = New Padding(0, 0, 12, 0)
        cardBayar.Name = "cardBayar"
        cardBayar.Size = New Size(210, 86)
        cardBayar.TabIndex = 1
        ' 
        ' lblCardBayarJudul
        ' 
        lblCardBayarJudul.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCardBayarJudul.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        lblCardBayarJudul.Location = New Point(12, 16)
        lblCardBayarJudul.Name = "lblCardBayarJudul"
        lblCardBayarJudul.Size = New Size(185, 24)
        lblCardBayarJudul.TabIndex = 0
        lblCardBayarJudul.Text = "Kasir Pembayaran"
        ' 
        ' lblCardBayarSub
        ' 
        lblCardBayarSub.Font = New Font("Segoe UI", 8.5F)
        lblCardBayarSub.ForeColor = Color.Gray
        lblCardBayarSub.Location = New Point(12, 42)
        lblCardBayarSub.Name = "lblCardBayarSub"
        lblCardBayarSub.Size = New Size(185, 22)
        lblCardBayarSub.TabIndex = 1
        lblCardBayarSub.Text = "Tunai & Transfer"
        ' 
        ' cardMenu
        ' 
        cardMenu.BackColor = Color.White
        cardMenu.Controls.Add(lblCardMenuJudul)
        cardMenu.Controls.Add(lblCardMenuSub)
        cardMenu.Cursor = Cursors.Hand
        cardMenu.Location = New Point(444, 0)
        cardMenu.Margin = New Padding(0, 0, 12, 0)
        cardMenu.Name = "cardMenu"
        cardMenu.Size = New Size(210, 86)
        cardMenu.TabIndex = 2
        ' 
        ' lblCardMenuJudul
        ' 
        lblCardMenuJudul.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCardMenuJudul.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        lblCardMenuJudul.Location = New Point(12, 16)
        lblCardMenuJudul.Name = "lblCardMenuJudul"
        lblCardMenuJudul.Size = New Size(185, 24)
        lblCardMenuJudul.TabIndex = 0
        lblCardMenuJudul.Text = "Data Menu"
        ' 
        ' lblCardMenuSub
        ' 
        lblCardMenuSub.Font = New Font("Segoe UI", 8.5F)
        lblCardMenuSub.ForeColor = Color.Gray
        lblCardMenuSub.Location = New Point(12, 42)
        lblCardMenuSub.Name = "lblCardMenuSub"
        lblCardMenuSub.Size = New Size(185, 22)
        lblCardMenuSub.TabIndex = 1
        lblCardMenuSub.Text = "Menu & harga"
        ' 
        ' cardKategori
        ' 
        cardKategori.BackColor = Color.White
        cardKategori.Controls.Add(lblCardKatJudul)
        cardKategori.Controls.Add(lblCardKatSub)
        cardKategori.Cursor = Cursors.Hand
        cardKategori.Location = New Point(666, 0)
        cardKategori.Margin = New Padding(0, 0, 12, 0)
        cardKategori.Name = "cardKategori"
        cardKategori.Size = New Size(210, 86)
        cardKategori.TabIndex = 3
        ' 
        ' lblCardKatJudul
        ' 
        lblCardKatJudul.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCardKatJudul.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        lblCardKatJudul.Location = New Point(12, 16)
        lblCardKatJudul.Name = "lblCardKatJudul"
        lblCardKatJudul.Size = New Size(185, 24)
        lblCardKatJudul.TabIndex = 0
        lblCardKatJudul.Text = "Kategori Hidangan"
        ' 
        ' lblCardKatSub
        ' 
        lblCardKatSub.Font = New Font("Segoe UI", 8.5F)
        lblCardKatSub.ForeColor = Color.Gray
        lblCardKatSub.Location = New Point(12, 42)
        lblCardKatSub.Name = "lblCardKatSub"
        lblCardKatSub.Size = New Size(185, 22)
        lblCardKatSub.TabIndex = 1
        lblCardKatSub.Text = "Jenis hidangan"
        ' 
        ' cardLaporan
        ' 
        cardLaporan.BackColor = Color.White
        cardLaporan.Controls.Add(lblCardLapJudul)
        cardLaporan.Controls.Add(lblCardLapSub)
        cardLaporan.Cursor = Cursors.Hand
        cardLaporan.Location = New Point(888, 0)
        cardLaporan.Margin = New Padding(0, 0, 12, 0)
        cardLaporan.Name = "cardLaporan"
        cardLaporan.Size = New Size(210, 86)
        cardLaporan.TabIndex = 4
        ' 
        ' lblCardLapJudul
        ' 
        lblCardLapJudul.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblCardLapJudul.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        lblCardLapJudul.Location = New Point(12, 16)
        lblCardLapJudul.Name = "lblCardLapJudul"
        lblCardLapJudul.Size = New Size(185, 24)
        lblCardLapJudul.TabIndex = 0
        lblCardLapJudul.Text = "Laporan Penjualan"
        ' 
        ' lblCardLapSub
        ' 
        lblCardLapSub.Font = New Font("Segoe UI", 8.5F)
        lblCardLapSub.ForeColor = Color.Gray
        lblCardLapSub.Location = New Point(12, 42)
        lblCardLapSub.Name = "lblCardLapSub"
        lblCardLapSub.Size = New Size(185, 22)
        lblCardLapSub.TabIndex = 1
        lblCardLapSub.Text = "Rekap & ekspor CSV"
        ' 
        ' lblSubSelamatDatang
        ' 
        lblSubSelamatDatang.Font = New Font("Georgia", 24.0F, FontStyle.Bold)
        lblSubSelamatDatang.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        lblSubSelamatDatang.Location = New Point(32, 58)
        lblSubSelamatDatang.Name = "lblSubSelamatDatang"
        lblSubSelamatDatang.Size = New Size(1000, 52)
        lblSubSelamatDatang.TabIndex = 3
        lblSubSelamatDatang.Text = "Admin Waroeng"
        lblSubSelamatDatang.UseCompatibleTextRendering = True
        ' 
        ' lblSelamatDatang
        ' 
        lblSelamatDatang.Font = New Font("Segoe UI", 10.5F)
        lblSelamatDatang.ForeColor = Color.FromArgb(CByte(100), CByte(90), CByte(80))
        lblSelamatDatang.Location = New Point(32, 32)
        lblSelamatDatang.Name = "lblSelamatDatang"
        lblSelamatDatang.Size = New Size(1000, 28)
        lblSelamatDatang.TabIndex = 4
        lblSelamatDatang.Text = "Selamat datang kembali,"
        lblSelamatDatang.UseCompatibleTextRendering = True
        ' 
        ' pnlAwning
        ' 
        pnlAwning.Dock = DockStyle.Top
        pnlAwning.Location = New Point(0, 0)
        pnlAwning.Name = "pnlAwning"
        pnlAwning.Size = New Size(1180, 16)
        pnlAwning.TabIndex = 5
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1440, 840)
        Controls.Add(pnlKonten)
        Controls.Add(pnlSidebar)
        MinimumSize = New Size(1300, 760)
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormDashboard — Waroeng Wong Solo"
        pnlSidebar.ResumeLayout(False)
        pnlSidebarBottom.ResumeLayout(False)
        pnlKonten.ResumeLayout(False)
        pnlQuickCards.ResumeLayout(False)
        cardPesanan.ResumeLayout(False)
        cardBayar.ResumeLayout(False)
        cardMenu.ResumeLayout(False)
        cardKategori.ResumeLayout(False)
        cardLaporan.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents lblAppName As System.Windows.Forms.Label
    Friend WithEvents lblAppSub As System.Windows.Forms.Label
    Friend WithEvents pnlDivider As System.Windows.Forms.Panel
    Friend WithEvents btnNavBeranda As System.Windows.Forms.Button
    Friend WithEvents btnNavKategori As System.Windows.Forms.Button
    Friend WithEvents btnNavMenu As System.Windows.Forms.Button
    Friend WithEvents btnNavPesanan As System.Windows.Forms.Button
    Friend WithEvents btnNavPembayaran As System.Windows.Forms.Button
    Friend WithEvents btnNavLaporan As System.Windows.Forms.Button
    Friend WithEvents pnlSidebarBottom As System.Windows.Forms.Panel
    Friend WithEvents lblUserInfo As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents pnlKonten As System.Windows.Forms.Panel
    Friend WithEvents pnlAwning As System.Windows.Forms.Panel
    Friend WithEvents lblSelamatDatang As System.Windows.Forms.Label
    Friend WithEvents lblSubSelamatDatang As System.Windows.Forms.Label
    Friend WithEvents pnlQuickCards As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cardPesanan As System.Windows.Forms.Panel
    Friend WithEvents lblCardPesananJudul As System.Windows.Forms.Label
    Friend WithEvents lblCardPesananSub As System.Windows.Forms.Label
    Friend WithEvents cardBayar As System.Windows.Forms.Panel
    Friend WithEvents lblCardBayarJudul As System.Windows.Forms.Label
    Friend WithEvents lblCardBayarSub As System.Windows.Forms.Label
    Friend WithEvents cardMenu As System.Windows.Forms.Panel
    Friend WithEvents lblCardMenuJudul As System.Windows.Forms.Label
    Friend WithEvents lblCardMenuSub As System.Windows.Forms.Label
    Friend WithEvents cardKategori As System.Windows.Forms.Panel
    Friend WithEvents lblCardKatJudul As System.Windows.Forms.Label
    Friend WithEvents lblCardKatSub As System.Windows.Forms.Label
    Friend WithEvents cardLaporan As System.Windows.Forms.Panel
    Friend WithEvents lblCardLapJudul As System.Windows.Forms.Label
    Friend WithEvents lblCardLapSub As System.Windows.Forms.Label
    Friend WithEvents lblMenuAndalanJudul As System.Windows.Forms.Label
    Friend WithEvents pnlMenuAndalan As System.Windows.Forms.FlowLayoutPanel

End Class
