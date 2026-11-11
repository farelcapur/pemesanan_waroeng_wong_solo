<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblJudul = New Label()
        lblSubjudul = New Label()
        btnKembali = New Button()
        pnlAwning = New Panel()
        pnlUtama = New Panel()
        pnlDaftarCard = New Panel()
        dgvMenu = New DataGridView()
        pnlFilterBar = New FlowLayoutPanel()
        btnFilterSemua = New Button()
        btnFilterMakanan = New Button()
        btnFilterSate = New Button()
        btnFilterMinuman = New Button()
        lblFilter = New Label()
        cmbFilterKategori = New ComboBox()
        pnlInputCard = New Panel()
        pnlFotoBox = New Panel()
        pbFotoMenu = New PictureBox()
        btnPilihFoto = New Button()
        lblIDMenu = New Label()
        txtIDMenu = New TextBox()
        lblKategori = New Label()
        cmbKategori = New ComboBox()
        lblNamaMenu = New Label()
        txtNamaMenu = New TextBox()
        lblHarga = New Label()
        numHarga = New NumericUpDown()
        chkTersedia = New CheckBox()
        chkAktif = New CheckBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        lblFotoPlaceholder = New Label()
        lblStatusBar = New Label()
        pnlHeader.SuspendLayout()
        pnlUtama.SuspendLayout()
        pnlDaftarCard.SuspendLayout()
        CType(dgvMenu, ComponentModel.ISupportInitialize).BeginInit()
        pnlFilterBar.SuspendLayout()
        pnlInputCard.SuspendLayout()
        pnlFotoBox.SuspendLayout()
        CType(pbFotoMenu, ComponentModel.ISupportInitialize).BeginInit()
        CType(numHarga, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Controls.Add(lblSubjudul)
        pnlHeader.Controls.Add(btnKembali)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1400, 70)
        pnlHeader.TabIndex = 3
        ' 
        ' lblJudul
        ' 
        lblJudul.Font = New Font("Georgia", 16F, FontStyle.Bold)
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(24, 12)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(450, 26)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Master Data Menu"
        ' 
        ' lblSubjudul
        ' 
        lblSubjudul.Font = New Font("Segoe UI", 9.5F)
        lblSubjudul.ForeColor = Color.FromArgb(CByte(200), CByte(160), CByte(140))
        lblSubjudul.Location = New Point(25, 40)
        lblSubjudul.Name = "lblSubjudul"
        lblSubjudul.Size = New Size(450, 20)
        lblSubjudul.TabIndex = 1
        lblSubjudul.Text = "Menu berelasi dengan kategori, lengkap dengan foto"
        ' 
        ' btnKembali
        ' 
        btnKembali.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnKembali.BackColor = Color.FromArgb(CByte(50), CByte(30), CByte(20))
        btnKembali.Cursor = Cursors.Hand
        btnKembali.FlatAppearance.BorderColor = Color.FromArgb(CByte(196), CByte(98), CByte(45))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnKembali.ForeColor = Color.FromArgb(CByte(230), CByte(150), CByte(90))
        btnKembali.Location = New Point(2170, 16)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(185, 38)
        btnKembali.TabIndex = 2
        btnKembali.Text = "Kembali ke Dashboard"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' pnlAwning
        ' 
        pnlAwning.Dock = DockStyle.Top
        pnlAwning.Location = New Point(0, 70)
        pnlAwning.Name = "pnlAwning"
        pnlAwning.Size = New Size(1400, 16)
        pnlAwning.TabIndex = 2
        ' 
        ' pnlUtama
        ' 
        pnlUtama.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(232))
        pnlUtama.Controls.Add(pnlDaftarCard)
        pnlUtama.Controls.Add(pnlInputCard)
        pnlUtama.Dock = DockStyle.Fill
        pnlUtama.Location = New Point(0, 86)
        pnlUtama.Name = "pnlUtama"
        pnlUtama.Padding = New Padding(24)
        pnlUtama.Size = New Size(1400, 686)
        pnlUtama.TabIndex = 0
        ' 
        ' pnlDaftarCard
        ' 
        pnlDaftarCard.BackColor = Color.White
        pnlDaftarCard.Controls.Add(dgvMenu)
        pnlDaftarCard.Controls.Add(pnlFilterBar)
        pnlDaftarCard.Dock = DockStyle.Right
        pnlDaftarCard.Location = New Point(396, 24)
        pnlDaftarCard.Name = "pnlDaftarCard"
        pnlDaftarCard.Padding = New Padding(16)
        pnlDaftarCard.Size = New Size(980, 638)
        pnlDaftarCard.TabIndex = 0
        ' 
        ' dgvMenu
        ' 
        dgvMenu.AllowUserToAddRows = False
        dgvMenu.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(252), CByte(246), CByte(238))
        dgvMenu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMenu.BackgroundColor = Color.White
        dgvMenu.BorderStyle = BorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvMenu.ColumnHeadersHeight = 44
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.5F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(248), CByte(225), CByte(205))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvMenu.DefaultCellStyle = DataGridViewCellStyle3
        dgvMenu.Dock = DockStyle.Fill
        dgvMenu.EnableHeadersVisualStyles = False
        dgvMenu.Location = New Point(16, 68)
        dgvMenu.MultiSelect = False
        dgvMenu.Name = "dgvMenu"
        dgvMenu.ReadOnly = True
        dgvMenu.RowHeadersVisible = False
        dgvMenu.RowHeadersWidth = 51
        dgvMenu.RowTemplate.Height = 42
        dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMenu.Size = New Size(948, 554)
        dgvMenu.TabIndex = 0
        ' 
        ' pnlFilterBar
        ' 
        pnlFilterBar.Controls.Add(btnFilterSemua)
        pnlFilterBar.Controls.Add(btnFilterMakanan)
        pnlFilterBar.Controls.Add(btnFilterSate)
        pnlFilterBar.Controls.Add(btnFilterMinuman)
        pnlFilterBar.Controls.Add(lblFilter)
        pnlFilterBar.Controls.Add(cmbFilterKategori)
        pnlFilterBar.Dock = DockStyle.Top
        pnlFilterBar.Location = New Point(16, 16)
        pnlFilterBar.Name = "pnlFilterBar"
        pnlFilterBar.Size = New Size(948, 52)
        pnlFilterBar.TabIndex = 1
        ' 
        ' btnFilterSemua
        ' 
        btnFilterSemua.AutoSize = True
        btnFilterSemua.BackColor = Color.FromArgb(CByte(139), CByte(26), CByte(26))
        btnFilterSemua.Cursor = Cursors.Hand
        btnFilterSemua.FlatAppearance.BorderSize = 0
        btnFilterSemua.FlatStyle = FlatStyle.Flat
        btnFilterSemua.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnFilterSemua.ForeColor = Color.White
        btnFilterSemua.Location = New Point(0, 0)
        btnFilterSemua.Margin = New Padding(0, 0, 10, 0)
        btnFilterSemua.Name = "btnFilterSemua"
        btnFilterSemua.Size = New Size(75, 36)
        btnFilterSemua.TabIndex = 0
        btnFilterSemua.Text = "Semua"
        btnFilterSemua.UseVisualStyleBackColor = False
        ' 
        ' btnFilterMakanan
        ' 
        btnFilterMakanan.AutoSize = True
        btnFilterMakanan.BackColor = Color.White
        btnFilterMakanan.Cursor = Cursors.Hand
        btnFilterMakanan.FlatAppearance.BorderColor = Color.FromArgb(CByte(210), CByte(200), CByte(190))
        btnFilterMakanan.FlatStyle = FlatStyle.Flat
        btnFilterMakanan.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnFilterMakanan.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        btnFilterMakanan.Location = New Point(85, 0)
        btnFilterMakanan.Margin = New Padding(0, 0, 10, 0)
        btnFilterMakanan.Name = "btnFilterMakanan"
        btnFilterMakanan.Size = New Size(148, 36)
        btnFilterMakanan.TabIndex = 1
        btnFilterMakanan.Text = "Makanan Utama"
        btnFilterMakanan.UseVisualStyleBackColor = False
        ' 
        ' btnFilterSate
        ' 
        btnFilterSate.AutoSize = True
        btnFilterSate.BackColor = Color.White
        btnFilterSate.Cursor = Cursors.Hand
        btnFilterSate.FlatAppearance.BorderColor = Color.FromArgb(CByte(210), CByte(200), CByte(190))
        btnFilterSate.FlatStyle = FlatStyle.Flat
        btnFilterSate.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnFilterSate.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        btnFilterSate.Location = New Point(243, 0)
        btnFilterSate.Margin = New Padding(0, 0, 10, 0)
        btnFilterSate.Name = "btnFilterSate"
        btnFilterSate.Size = New Size(99, 36)
        btnFilterSate.TabIndex = 2
        btnFilterSate.Text = "Sate & Lauk"
        btnFilterSate.UseVisualStyleBackColor = False
        ' 
        ' btnFilterMinuman
        ' 
        btnFilterMinuman.AutoSize = True
        btnFilterMinuman.BackColor = Color.White
        btnFilterMinuman.Cursor = Cursors.Hand
        btnFilterMinuman.FlatAppearance.BorderColor = Color.FromArgb(CByte(210), CByte(200), CByte(190))
        btnFilterMinuman.FlatStyle = FlatStyle.Flat
        btnFilterMinuman.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnFilterMinuman.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        btnFilterMinuman.Location = New Point(352, 0)
        btnFilterMinuman.Margin = New Padding(0, 0, 10, 0)
        btnFilterMinuman.Name = "btnFilterMinuman"
        btnFilterMinuman.Size = New Size(96, 36)
        btnFilterMinuman.TabIndex = 3
        btnFilterMinuman.Text = "Minuman"
        btnFilterMinuman.UseVisualStyleBackColor = False
        ' 
        ' lblFilter
        ' 
        lblFilter.Font = New Font("Segoe UI", 9F)
        lblFilter.Location = New Point(461, 0)
        lblFilter.Name = "lblFilter"
        lblFilter.Size = New Size(100, 23)
        lblFilter.TabIndex = 4
        lblFilter.Text = "Filter:"
        lblFilter.Visible = False
        ' 
        ' cmbFilterKategori
        ' 
        cmbFilterKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFilterKategori.Location = New Point(567, 3)
        cmbFilterKategori.Name = "cmbFilterKategori"
        cmbFilterKategori.Size = New Size(150, 28)
        cmbFilterKategori.TabIndex = 5
        cmbFilterKategori.Visible = False
        ' 
        ' pnlInputCard
        ' 
        pnlInputCard.BackColor = Color.White
        pnlInputCard.Controls.Add(pnlFotoBox)
        pnlInputCard.Controls.Add(btnPilihFoto)
        pnlInputCard.Controls.Add(lblIDMenu)
        pnlInputCard.Controls.Add(txtIDMenu)
        pnlInputCard.Controls.Add(lblKategori)
        pnlInputCard.Controls.Add(cmbKategori)
        pnlInputCard.Controls.Add(lblNamaMenu)
        pnlInputCard.Controls.Add(txtNamaMenu)
        pnlInputCard.Controls.Add(lblHarga)
        pnlInputCard.Controls.Add(numHarga)
        pnlInputCard.Controls.Add(chkTersedia)
        pnlInputCard.Controls.Add(chkAktif)
        pnlInputCard.Controls.Add(btnSimpan)
        pnlInputCard.Controls.Add(btnUbah)
        pnlInputCard.Controls.Add(btnHapus)
        pnlInputCard.Controls.Add(btnBatal)
        pnlInputCard.Location = New Point(24, 24)
        pnlInputCard.Name = "pnlInputCard"
        pnlInputCard.Size = New Size(350, 660)
        pnlInputCard.TabIndex = 1
        ' 
        ' pnlFotoBox
        ' 
        pnlFotoBox.BackColor = Color.FromArgb(CByte(254), CByte(237), CByte(204))
        pnlFotoBox.Controls.Add(pbFotoMenu)
        pnlFotoBox.Location = New Point(110, 16)
        pnlFotoBox.Name = "pnlFotoBox"
        pnlFotoBox.Size = New Size(100, 100)
        pnlFotoBox.TabIndex = 0
        ' 
        ' pbFotoMenu
        ' 
        pbFotoMenu.Dock = DockStyle.Fill
        pbFotoMenu.Location = New Point(0, 0)
        pbFotoMenu.Name = "pbFotoMenu"
        pbFotoMenu.Size = New Size(100, 100)
        pbFotoMenu.SizeMode = PictureBoxSizeMode.Zoom
        pbFotoMenu.TabIndex = 0
        pbFotoMenu.TabStop = False
        ' 
        ' btnPilihFoto
        ' 
        btnPilihFoto.BackColor = Color.White
        btnPilihFoto.Cursor = Cursors.Hand
        btnPilihFoto.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(190), CByte(180))
        btnPilihFoto.FlatStyle = FlatStyle.Flat
        btnPilihFoto.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnPilihFoto.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        btnPilihFoto.Location = New Point(20, 126)
        btnPilihFoto.Name = "btnPilihFoto"
        btnPilihFoto.Size = New Size(280, 32)
        btnPilihFoto.TabIndex = 1
        btnPilihFoto.Text = "Pilih Foto Menu"
        btnPilihFoto.UseVisualStyleBackColor = False
        ' 
        ' lblIDMenu
        ' 
        lblIDMenu.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblIDMenu.ForeColor = Color.FromArgb(CByte(70), CByte(60), CByte(50))
        lblIDMenu.Location = New Point(20, 168)
        lblIDMenu.Name = "lblIDMenu"
        lblIDMenu.Size = New Size(280, 18)
        lblIDMenu.TabIndex = 2
        lblIDMenu.Text = "Kode Menu"
        ' 
        ' txtIDMenu
        ' 
        txtIDMenu.BackColor = Color.FromArgb(CByte(238), CByte(235), CByte(230))
        txtIDMenu.BorderStyle = BorderStyle.FixedSingle
        txtIDMenu.Font = New Font("Segoe UI", 10F)
        txtIDMenu.Location = New Point(20, 188)
        txtIDMenu.Name = "txtIDMenu"
        txtIDMenu.ReadOnly = True
        txtIDMenu.Size = New Size(280, 30)
        txtIDMenu.TabIndex = 3
        ' 
        ' lblKategori
        ' 
        lblKategori.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblKategori.ForeColor = Color.FromArgb(CByte(70), CByte(60), CByte(50))
        lblKategori.Location = New Point(20, 222)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(280, 18)
        lblKategori.TabIndex = 4
        lblKategori.Text = "Kategori"
        ' 
        ' cmbKategori
        ' 
        cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKategori.Font = New Font("Segoe UI", 10F)
        cmbKategori.Location = New Point(20, 242)
        cmbKategori.Name = "cmbKategori"
        cmbKategori.Size = New Size(280, 31)
        cmbKategori.TabIndex = 5
        ' 
        ' lblNamaMenu
        ' 
        lblNamaMenu.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNamaMenu.ForeColor = Color.FromArgb(CByte(70), CByte(60), CByte(50))
        lblNamaMenu.Location = New Point(20, 278)
        lblNamaMenu.Name = "lblNamaMenu"
        lblNamaMenu.Size = New Size(280, 18)
        lblNamaMenu.TabIndex = 6
        lblNamaMenu.Text = "Nama Menu"
        ' 
        ' txtNamaMenu
        ' 
        txtNamaMenu.BorderStyle = BorderStyle.FixedSingle
        txtNamaMenu.Font = New Font("Segoe UI", 10F)
        txtNamaMenu.Location = New Point(20, 298)
        txtNamaMenu.MaxLength = 100
        txtNamaMenu.Name = "txtNamaMenu"
        txtNamaMenu.Size = New Size(280, 30)
        txtNamaMenu.TabIndex = 7
        ' 
        ' lblHarga
        ' 
        lblHarga.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblHarga.ForeColor = Color.FromArgb(CByte(70), CByte(60), CByte(50))
        lblHarga.Location = New Point(20, 332)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(280, 18)
        lblHarga.TabIndex = 8
        lblHarga.Text = "Harga (Rp)"
        ' 
        ' numHarga
        ' 
        numHarga.Font = New Font("Segoe UI", 10F)
        numHarga.Location = New Point(20, 352)
        numHarga.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        numHarga.Name = "numHarga"
        numHarga.Size = New Size(280, 30)
        numHarga.TabIndex = 9
        numHarga.ThousandsSeparator = True
        ' 
        ' chkTersedia
        ' 
        chkTersedia.Checked = True
        chkTersedia.CheckState = CheckState.Checked
        chkTersedia.Font = New Font("Segoe UI", 9F)
        chkTersedia.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        chkTersedia.Location = New Point(20, 388)
        chkTersedia.Name = "chkTersedia"
        chkTersedia.Size = New Size(280, 24)
        chkTersedia.TabIndex = 10
        chkTersedia.Text = "Menu tersedia"
        ' 
        ' chkAktif
        ' 
        chkAktif.Checked = True
        chkAktif.CheckState = CheckState.Checked
        chkAktif.Location = New Point(20, 412)
        chkAktif.Name = "chkAktif"
        chkAktif.Size = New Size(104, 24)
        chkAktif.TabIndex = 11
        chkAktif.Text = "Katalog Aktif"
        chkAktif.Visible = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(196), CByte(98), CByte(45))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(20, 430)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(134, 40)
        btnSimpan.TabIndex = 12
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.White
        btnUbah.Cursor = Cursors.Hand
        btnUbah.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(190), CByte(180))
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnUbah.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        btnUbah.Location = New Point(166, 430)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(134, 40)
        btnUbah.TabIndex = 13
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(178), CByte(34), CByte(34))
        btnHapus.Cursor = Cursors.Hand
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(20, 480)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(134, 40)
        btnHapus.TabIndex = 14
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.White
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderColor = Color.FromArgb(CByte(200), CByte(190), CByte(180))
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnBatal.ForeColor = Color.FromArgb(CByte(44), CByte(24), CByte(16))
        btnBatal.Location = New Point(166, 480)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(134, 40)
        btnBatal.TabIndex = 15
        btnBatal.Text = "Bersihkan"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' lblFotoPlaceholder
        ' 
        lblFotoPlaceholder.Location = New Point(0, 0)
        lblFotoPlaceholder.Name = "lblFotoPlaceholder"
        lblFotoPlaceholder.Size = New Size(100, 23)
        lblFotoPlaceholder.TabIndex = 0
        ' 
        ' lblStatusBar
        ' 
        lblStatusBar.BackColor = Color.FromArgb(CByte(240), CByte(235), CByte(225))
        lblStatusBar.Dock = DockStyle.Bottom
        lblStatusBar.Font = New Font("Segoe UI", 9F)
        lblStatusBar.ForeColor = Color.DimGray
        lblStatusBar.Location = New Point(0, 772)
        lblStatusBar.Name = "lblStatusBar"
        lblStatusBar.Padding = New Padding(12, 0, 0, 0)
        lblStatusBar.Size = New Size(1400, 28)
        lblStatusBar.TabIndex = 1
        lblStatusBar.Text = "Siap."
        lblStatusBar.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FormMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1400, 800)
        Controls.Add(pnlUtama)
        Controls.Add(lblStatusBar)
        Controls.Add(pnlAwning)
        Controls.Add(pnlHeader)
        MinimumSize = New Size(1280, 720)
        Name = "FormMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormMenu — Waroeng Wong Solo"
        pnlHeader.ResumeLayout(False)
        pnlUtama.ResumeLayout(False)
        pnlDaftarCard.ResumeLayout(False)
        CType(dgvMenu, ComponentModel.ISupportInitialize).EndInit()
        pnlFilterBar.ResumeLayout(False)
        pnlFilterBar.PerformLayout()
        pnlInputCard.ResumeLayout(False)
        pnlInputCard.PerformLayout()
        pnlFotoBox.ResumeLayout(False)
        CType(pbFotoMenu, ComponentModel.ISupportInitialize).EndInit()
        CType(numHarga, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlAwning As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblSubjudul As System.Windows.Forms.Label
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents pnlUtama As System.Windows.Forms.Panel
    Friend WithEvents pnlInputCard As System.Windows.Forms.Panel
    Friend WithEvents pnlFotoBox As System.Windows.Forms.Panel
    Friend WithEvents pbFotoMenu As System.Windows.Forms.PictureBox
    Friend WithEvents lblFotoPlaceholder As System.Windows.Forms.Label
    Friend WithEvents btnPilihFoto As System.Windows.Forms.Button
    Friend WithEvents lblIDMenu As System.Windows.Forms.Label
    Friend WithEvents txtIDMenu As System.Windows.Forms.TextBox
    Friend WithEvents lblKategori As System.Windows.Forms.Label
    Friend WithEvents cmbKategori As System.Windows.Forms.ComboBox
    Friend WithEvents lblNamaMenu As System.Windows.Forms.Label
    Friend WithEvents txtNamaMenu As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents numHarga As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkTersedia As System.Windows.Forms.CheckBox
    Friend WithEvents chkAktif As System.Windows.Forms.CheckBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents pnlDaftarCard As System.Windows.Forms.Panel
    Friend WithEvents pnlFilterBar As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnFilterSemua As System.Windows.Forms.Button
    Friend WithEvents btnFilterMakanan As System.Windows.Forms.Button
    Friend WithEvents btnFilterSate As System.Windows.Forms.Button
    Friend WithEvents btnFilterMinuman As System.Windows.Forms.Button
    Friend WithEvents cmbFilterKategori As System.Windows.Forms.ComboBox
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents dgvMenu As System.Windows.Forms.DataGridView
    Friend WithEvents lblStatusBar As System.Windows.Forms.Label

End Class