<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKategoriMenu
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlAwning = New System.Windows.Forms.Panel()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblSubjudul = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.pnlUtama = New System.Windows.Forms.Panel()
        Me.pnlInputCard = New System.Windows.Forms.Panel()
        Me.lblHeaderInput = New System.Windows.Forms.Label()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.txtKodeKategori = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNamaKategori = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.pnlKanan = New System.Windows.Forms.Panel()
        Me.pnlPreviewKategori = New System.Windows.Forms.Panel()
        Me.lblPilihKategoriJudul = New System.Windows.Forms.Label()
        Me.flpKartuKategori = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlGridCard = New System.Windows.Forms.Panel()
        Me.pnlCari = New System.Windows.Forms.Panel()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.dgvKategori = New System.Windows.Forms.DataGridView()
        Me.lblStatusBar = New System.Windows.Forms.Label()

        Me.pnlHeader.SuspendLayout()
        Me.pnlUtama.SuspendLayout()
        Me.pnlInputCard.SuspendLayout()
        Me.pnlKanan.SuspendLayout()
        Me.pnlPreviewKategori.SuspendLayout()
        Me.pnlGridCard.SuspendLayout()
        Me.pnlCari.SuspendLayout()
        CType(Me.dgvKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        Dim coklatTua As System.Drawing.Color = System.Drawing.Color.FromArgb(44, 24, 16)
        Dim krem As System.Drawing.Color = System.Drawing.Color.FromArgb(245, 240, 232)
        Dim oranyeBurnt As System.Drawing.Color = System.Drawing.Color.FromArgb(196, 98, 45)
        Dim merahHapus As System.Drawing.Color = System.Drawing.Color.FromArgb(178, 34, 34)

        ' ================================================================
        ' pnlHeader — Coklat tua #2C1810
        ' ================================================================
        Me.pnlHeader.BackColor = coklatTua
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 70
        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Controls.Add(Me.lblSubjudul)
        Me.pnlHeader.Controls.Add(Me.btnKembali)

        Me.lblJudul.Text = "Master Kategori Menu"
        Me.lblJudul.Font = New System.Drawing.Font("Georgia", 16, System.Drawing.FontStyle.Bold)
        Me.lblJudul.ForeColor = Color.White
        Me.lblJudul.Location = New System.Drawing.Point(24, 12)
        Me.lblJudul.Size = New System.Drawing.Size(400, 26)

        Me.lblSubjudul.Text = "Kelola kategori makanan dan minuman"
        Me.lblSubjudul.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSubjudul.ForeColor = Color.FromArgb(200, 160, 140)
        Me.lblSubjudul.Location = New System.Drawing.Point(25, 40)
        Me.lblSubjudul.Size = New System.Drawing.Size(400, 20)

        Me.btnKembali.Text = "Kembali ke Dashboard"
        Me.btnKembali.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnKembali.BackColor = System.Drawing.Color.FromArgb(50, 30, 20)
        Me.btnKembali.ForeColor = Color.FromArgb(230, 150, 90)
        Me.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKembali.FlatAppearance.BorderColor = Color.FromArgb(196, 98, 45)
        Me.btnKembali.FlatAppearance.BorderSize = 1
        Me.btnKembali.Size = New System.Drawing.Size(185, 38)
        Me.btnKembali.Location = New System.Drawing.Point(920, 16)
        Me.btnKembali.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand

        ' ================================================================
        ' pnlAwning — Strip Tenda Marun-Putih di Bawah Header
        ' ================================================================
        Me.pnlAwning.Dock = DockStyle.Top
        Me.pnlAwning.Height = 16

        ' ================================================================
        ' pnlUtama — Background Krem
        ' ================================================================
        Me.pnlUtama.BackColor = krem
        Me.pnlUtama.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUtama.Padding = New System.Windows.Forms.Padding(24)
        Me.pnlUtama.Controls.Add(Me.pnlKanan)
        Me.pnlUtama.Controls.Add(Me.pnlInputCard)

        ' ================================================================
        ' pnlInputCard (Kiri) — Putih dengan rounded card styling
        ' ================================================================
        Me.pnlInputCard.BackColor = System.Drawing.Color.White
        Me.pnlInputCard.Size = New System.Drawing.Size(320, 480)
        Me.pnlInputCard.Location = New System.Drawing.Point(24, 24)
        Me.pnlInputCard.Controls.Add(Me.lblHeaderInput)
        Me.pnlInputCard.Controls.Add(Me.lblKode)
        Me.pnlInputCard.Controls.Add(Me.txtKodeKategori)
        Me.pnlInputCard.Controls.Add(Me.lblNama)
        Me.pnlInputCard.Controls.Add(Me.txtNamaKategori)
        Me.pnlInputCard.Controls.Add(Me.btnSimpan)
        Me.pnlInputCard.Controls.Add(Me.btnUbah)
        Me.pnlInputCard.Controls.Add(Me.btnHapus)
        Me.pnlInputCard.Controls.Add(Me.btnBatal)

        Me.lblHeaderInput.Text = "Data Kategori"
        Me.lblHeaderInput.Font = New System.Drawing.Font("Georgia", 13, System.Drawing.FontStyle.Bold)
        Me.lblHeaderInput.ForeColor = coklatTua
        Me.lblHeaderInput.Location = New System.Drawing.Point(20, 20)
        Me.lblHeaderInput.Size = New System.Drawing.Size(280, 26)

        Me.lblKode.Text = "ID Kategori"
        Me.lblKode.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblKode.ForeColor = Color.FromArgb(70, 60, 50)
        Me.lblKode.Location = New System.Drawing.Point(20, 65)
        Me.lblKode.Size = New System.Drawing.Size(280, 20)

        Me.txtKodeKategori.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtKodeKategori.ReadOnly = True
        Me.txtKodeKategori.BackColor = Color.FromArgb(238, 235, 230)
        Me.txtKodeKategori.BorderStyle = BorderStyle.FixedSingle
        Me.txtKodeKategori.Size = New System.Drawing.Size(280, 32)
        Me.txtKodeKategori.Location = New System.Drawing.Point(20, 88)

        Me.lblNama.Text = "Nama Kategori"
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblNama.ForeColor = Color.FromArgb(70, 60, 50)
        Me.lblNama.Location = New System.Drawing.Point(20, 140)
        Me.lblNama.Size = New System.Drawing.Size(280, 20)

        Me.txtNamaKategori.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.txtNamaKategori.MaxLength = 50
        Me.txtNamaKategori.BorderStyle = BorderStyle.FixedSingle
        Me.txtNamaKategori.Size = New System.Drawing.Size(280, 32)
        Me.txtNamaKategori.Location = New System.Drawing.Point(20, 163)

        ' Tombol Simpan — Oranye Burnt
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.BackColor = oranyeBurnt
        Me.btnSimpan.ForeColor = Color.White
        Me.btnSimpan.FlatStyle = FlatStyle.Flat
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Size = New System.Drawing.Size(134, 42)
        Me.btnSimpan.Location = New System.Drawing.Point(20, 225)
        Me.btnSimpan.Cursor = Cursors.Hand

        ' Tombol Ubah — Putih Garis Tepi
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnUbah.BackColor = Color.White
        Me.btnUbah.ForeColor = coklatTua
        Me.btnUbah.FlatStyle = FlatStyle.Flat
        Me.btnUbah.FlatAppearance.BorderColor = Color.FromArgb(200, 190, 180)
        Me.btnUbah.FlatAppearance.BorderSize = 1
        Me.btnUbah.Size = New System.Drawing.Size(134, 42)
        Me.btnUbah.Location = New System.Drawing.Point(166, 225)
        Me.btnUbah.Cursor = Cursors.Hand

        ' Tombol Hapus — Merah
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnHapus.BackColor = merahHapus
        Me.btnHapus.ForeColor = Color.White
        Me.btnHapus.FlatStyle = FlatStyle.Flat
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.Size = New System.Drawing.Size(134, 42)
        Me.btnHapus.Location = New System.Drawing.Point(20, 278)
        Me.btnHapus.Cursor = Cursors.Hand

        ' Tombol Bersihkan / Batal — Putih Garis Tepi
        Me.btnBatal.Text = "Bersihkan"
        Me.btnBatal.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnBatal.BackColor = Color.White
        Me.btnBatal.ForeColor = coklatTua
        Me.btnBatal.FlatStyle = FlatStyle.Flat
        Me.btnBatal.FlatAppearance.BorderColor = Color.FromArgb(200, 190, 180)
        Me.btnBatal.FlatAppearance.BorderSize = 1
        Me.btnBatal.Size = New System.Drawing.Size(134, 42)
        Me.btnBatal.Location = New System.Drawing.Point(166, 278)
        Me.btnBatal.Cursor = Cursors.Hand

        ' ================================================================
        ' pnlKanan — Kartu Kategori & DataGridView (Kanvas Luas)
        ' ================================================================
        Me.pnlKanan.Dock = DockStyle.Right
        Me.pnlKanan.Size = New System.Drawing.Size(960, 640)
        Me.pnlKanan.Controls.Add(Me.pnlGridCard)
        Me.pnlKanan.Controls.Add(Me.pnlPreviewKategori)

        ' Kartu Preview Kategori di Atas (Luas & Tidak Terpotong)
        Me.pnlPreviewKategori.BackColor = Color.White
        Me.pnlPreviewKategori.Size = New System.Drawing.Size(960, 195)
        Me.pnlPreviewKategori.Dock = DockStyle.Top
        Me.pnlPreviewKategori.Padding = New Padding(16, 12, 16, 12)
        Me.pnlPreviewKategori.Controls.Add(Me.lblPilihKategoriJudul)
        Me.pnlPreviewKategori.Controls.Add(Me.flpKartuKategori)

        Me.lblPilihKategoriJudul.Text = "Pilih Kategori"
        Me.lblPilihKategoriJudul.Font = New Font("Georgia", 13, FontStyle.Bold)
        Me.lblPilihKategoriJudul.ForeColor = coklatTua
        Me.lblPilihKategoriJudul.Location = New Point(16, 10)
        Me.lblPilihKategoriJudul.Size = New Size(300, 24)

        Me.flpKartuKategori.Location = New Point(16, 38)
        Me.flpKartuKategori.Size = New Size(920, 145)

        ' Panel Grid di Bawah
        Me.pnlGridCard.BackColor = Color.White
        Me.pnlGridCard.Dock = DockStyle.Fill
        Me.pnlGridCard.Padding = New Padding(16)
        Me.pnlGridCard.Location = New Point(0, 190)
        Me.pnlGridCard.Controls.Add(Me.dgvKategori)
        Me.pnlGridCard.Controls.Add(Me.pnlCari)

        ' Cari
        Me.pnlCari.Dock = DockStyle.Top
        Me.pnlCari.Height = 36
        Me.pnlCari.Controls.Add(Me.lblCari)
        Me.pnlCari.Controls.Add(Me.txtCari)

        Me.lblCari.Text = "Cari Kategori:"
        Me.lblCari.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.lblCari.ForeColor = coklatTua
        Me.lblCari.Location = New Point(0, 6)
        Me.lblCari.Size = New Size(100, 24)

        Me.txtCari.Font = New Font("Segoe UI", 9.5!)
        Me.txtCari.Size = New Size(260, 28)
        Me.txtCari.Location = New Point(105, 4)
        Me.txtCari.BorderStyle = BorderStyle.FixedSingle

        ' DataGridView
        Me.dgvKategori.AllowUserToAddRows = False
        Me.dgvKategori.AllowUserToDeleteRows = False
        Me.dgvKategori.ReadOnly = True
        Me.dgvKategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvKategori.MultiSelect = False
        Me.dgvKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKategori.BackgroundColor = Color.White
        Me.dgvKategori.BorderStyle = BorderStyle.None
        Me.dgvKategori.RowHeadersVisible = False
        Me.dgvKategori.ColumnHeadersHeight = 40
        Me.dgvKategori.RowTemplate.Height = 36
        Me.dgvKategori.Dock = DockStyle.Fill

        ' Style DataGridView
        Me.dgvKategori.ColumnHeadersDefaultCellStyle.BackColor = coklatTua
        Me.dgvKategori.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvKategori.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.5!, FontStyle.Bold)
        Me.dgvKategori.EnableHeadersVisualStyles = False
        Me.dgvKategori.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(252, 246, 238)
        Me.dgvKategori.DefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 225, 205)
        Me.dgvKategori.DefaultCellStyle.SelectionForeColor = coklatTua

        ' Status bar
        Me.lblStatusBar.Text = "Siap."
        Me.lblStatusBar.Font = New Font("Segoe UI", 8.5!)
        Me.lblStatusBar.ForeColor = Color.DimGray
        Me.lblStatusBar.BackColor = Color.FromArgb(240, 235, 225)
        Me.lblStatusBar.Dock = DockStyle.Bottom
        Me.lblStatusBar.Height = 26
        Me.lblStatusBar.TextAlign = ContentAlignment.MiddleLeft
        Me.lblStatusBar.Padding = New Padding(12, 0, 0, 0)

        ' Form (Kanvas Luas & Bebas Terpotong)
        Me.AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1380, 780)
        Me.Controls.Add(Me.pnlUtama)
        Me.Controls.Add(Me.lblStatusBar)
        Me.Controls.Add(Me.pnlAwning)
        Me.Controls.Add(Me.pnlHeader)
        Me.MinimumSize = New Size(1280, 720)
        Me.Name = "FormKategoriMenu"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "FormKategoriMenu — Waroeng Wong Solo"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlUtama.ResumeLayout(False)
        Me.pnlInputCard.ResumeLayout(False)
        Me.pnlInputCard.PerformLayout()
        Me.pnlKanan.ResumeLayout(False)
        Me.pnlPreviewKategori.ResumeLayout(False)
        Me.pnlGridCard.ResumeLayout(False)
        Me.pnlCari.ResumeLayout(False)
        Me.pnlCari.PerformLayout()
        CType(Me.dgvKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlAwning As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblSubjudul As System.Windows.Forms.Label
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents pnlUtama As System.Windows.Forms.Panel
    Friend WithEvents pnlInputCard As System.Windows.Forms.Panel
    Friend WithEvents lblHeaderInput As System.Windows.Forms.Label
    Friend WithEvents lblKode As System.Windows.Forms.Label
    Friend WithEvents txtKodeKategori As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNamaKategori As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents pnlKanan As System.Windows.Forms.Panel
    Friend WithEvents pnlPreviewKategori As System.Windows.Forms.Panel
    Friend WithEvents lblPilihKategoriJudul As System.Windows.Forms.Label
    Friend WithEvents flpKartuKategori As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlGridCard As System.Windows.Forms.Panel
    Friend WithEvents pnlCari As System.Windows.Forms.Panel
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents dgvKategori As System.Windows.Forms.DataGridView
    Friend WithEvents lblStatusBar As System.Windows.Forms.Label

End Class