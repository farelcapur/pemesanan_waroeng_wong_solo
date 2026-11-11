Imports MySql.Data.MySqlClient

Public Class FormKategoriMenu

    ' ============================================================
    ' FORM MASTER KATEGORI MENU - Waroeng Wong Solo
    ' CRUD: Tambah, Lihat, Ubah, Hapus Kategori Menu
    ' Relasi: Tabel Induk untuk FormMenu (1:N)
    ' ============================================================

    ' Status mode edit form
    Private _modeEdit As Boolean = False
    Private _dtSumber As DataTable = Nothing ' DataTable asli untuk fitur pencarian

    ' ================================================================
    ' INISIALISASI FORM
    ' ================================================================
    Private Sub FormKategoriMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KonfigurasiGrid()
        MuatDataKategori()
        GenerateKodeBerikutnya()
        SetModeTambah()
        MuatKartuKategori()
    End Sub

    Private Sub pnlAwning_Paint(sender As Object, e As PaintEventArgs) Handles pnlAwning.Paint
        UIHelper.GambarTendaAwning(sender, e)
    End Sub

    Private Sub MuatKartuKategori()
        flpKartuKategori.SuspendLayout()
        flpKartuKategori.Controls.Clear()

        Dim coklatTua As Color = Color.FromArgb(44, 24, 16)
        Dim oranyeBurnt As Color = Color.FromArgb(196, 98, 45)

        Dim katList() As Tuple(Of String, String, String, Color) = {
            Tuple.Create("Makanan Utama", "KAT001", "nasi_liwet", Color.FromArgb(252, 230, 189)),
            Tuple.Create("Sate & Lauk", "KAT002", "sate_buntel", Color.FromArgb(236, 220, 201)),
            Tuple.Create("Camilan & Kue", "KAT003", "serabi", Color.FromArgb(252, 230, 189)),
            Tuple.Create("Minuman Dingin", "KAT004", "es_dawet", Color.FromArgb(216, 236, 225)),
            Tuple.Create("Minuman Hangat", "KAT005", "wedang_uwuh", Color.FromArgb(248, 220, 218))
        }

        For Each k In katList
            Dim p As New Panel()
            p.Size = New Size(215, 130)
            p.BackColor = Color.FromArgb(250, 248, 245)
            p.Margin = New Padding(0, 0, 14, 0)
            p.BorderStyle = BorderStyle.FixedSingle
            p.Cursor = Cursors.Hand

            Dim boxImg As New PictureBox()
            boxImg.Size = New Size(195, 68)
            boxImg.Location = New Point(9, 8)
            boxImg.SizeMode = PictureBoxSizeMode.Zoom
            boxImg.BackColor = k.Item4
            boxImg.Image = UIHelper.GetMenuIcon(k.Item3)

            Dim lblKName As New Label()
            lblKName.Text = k.Item1
            lblKName.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
            lblKName.ForeColor = coklatTua
            lblKName.Location = New Point(8, 80)
            lblKName.Size = New Size(198, 22)

            Dim lblKCode As New Label()
            lblKCode.Text = k.Item2
            lblKCode.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
            lblKCode.ForeColor = oranyeBurnt
            lblKCode.Location = New Point(8, 104)
            lblKCode.Size = New Size(198, 18)

            p.Controls.Add(boxImg)
            p.Controls.Add(lblKName)
            p.Controls.Add(lblKCode)

            Dim klikHandler As EventHandler = Sub(s, ev)
                                                  txtCari.Text = k.Item1
                                              End Sub
            AddHandler p.Click, klikHandler
            For Each child As Control In p.Controls
                AddHandler child.Click, klikHandler
            Next

            flpKartuKategori.Controls.Add(p)
        Next
        flpKartuKategori.ResumeLayout()
    End Sub

    ' ----------------------------------------------------------------
    ' KonfigurasiGrid: Atur tampilan DataGridView
    ' ----------------------------------------------------------------
    Private Sub KonfigurasiGrid()
        ' Style header - Coklat Tua #2C1810
        dgvKategori.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 24, 16)
        dgvKategori.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgvKategori.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        dgvKategori.EnableHeadersVisualStyles = False

        ' Style baris alternatif krem
        dgvKategori.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(252, 246, 238)

        ' Style baris terpilih
        dgvKategori.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(248, 225, 205)
        dgvKategori.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(44, 24, 16)
        dgvKategori.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        dgvKategori.RowTemplate.Height = 44
    End Sub

    ' ================================================================
    ' DATA: Muat dan Tampilkan
    ' ================================================================
    Private Sub MuatDataKategori()
        Dim sql As String =
            "SELECT k.kategori_id AS 'ID', " &
            "       k.nama_kategori AS 'Nama Kategori', " &
            "       COUNT(m.menu_id) AS 'Jumlah Menu' " &
            "FROM kategori_menu k " &
            "LEFT JOIN menu m ON k.kategori_id = m.kategori_id AND m.is_aktif = 1 " &
            "GROUP BY k.kategori_id, k.nama_kategori " &
            "ORDER BY k.kategori_id ASC"

        _dtSumber = AmbilDataTable(sql)

        If _dtSumber IsNot Nothing Then
            dgvKategori.DataSource = _dtSumber

            ' Hapus kolom gambar jika ada agar tabel hanya berisi ID, Nama Kategori, Jumlah Menu
            If dgvKategori.Columns.Contains("colIcon") Then
                dgvKategori.Columns.Remove("colIcon")
            End If

            If dgvKategori.Columns.Contains("ID") Then
                dgvKategori.Columns("ID").Width = 120
                dgvKategori.Columns("ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgvKategori.Columns("ID").DefaultCellStyle.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
            End If

            If dgvKategori.Columns.Contains("Jumlah Menu") Then
                dgvKategori.Columns("Jumlah Menu").Width = 140
                dgvKategori.Columns("Jumlah Menu").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            lblStatusBar.Text = "Total data: " & _dtSumber.Rows.Count & " kategori."
        Else
            lblStatusBar.Text = "Gagal memuat data."
        End If
    End Sub

    ' ----------------------------------------------------------------
    ' GenerateKodeBerikutnya: Auto-generate kode KATxxx berikutnya
    ' ----------------------------------------------------------------
    Private Sub GenerateKodeBerikutnya()
        Dim sql As String =
            "SELECT COALESCE(MAX(CAST(SUBSTRING(kategori_id, 4) AS UNSIGNED)), 0) + 1 " &
            "AS nomor_berikutnya FROM kategori_menu"

        Dim dt As DataTable = AmbilDataTable(sql)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Dim nomor As Integer = Convert.ToInt32(dt.Rows(0)(0))
            txtKodeKategori.Text = "KAT" & nomor.ToString("D3")
        Else
            txtKodeKategori.Text = "KAT001"
        End If
    End Sub

    ' ================================================================
    ' MODE FORM
    ' ================================================================
    Private Sub SetModeTambah()
        _modeEdit = False
        txtNamaKategori.Clear()
        txtNamaKategori.Focus()
        GenerateKodeBerikutnya()

        ' Aktifkan Simpan, nonaktifkan Ubah & Hapus
        btnSimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False

        lblStatusBar.Text = "Mode: Tambah Kategori Baru."
    End Sub

    Private Sub SetModeEdit()
        _modeEdit = True
        ' Nonaktifkan Simpan, aktifkan Ubah & Hapus
        btnSimpan.Enabled = False
        btnUbah.Enabled = True
        btnHapus.Enabled = True

        lblStatusBar.Text = "Mode: Edit Kategori [" & txtKodeKategori.Text & "]. Ubah data lalu klik Ubah."
    End Sub

    ' ================================================================
    ' EVENT: DataGridView - Klik baris untuk edit
    ' ================================================================
    Private Sub dgvKategori_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKategori.CellClick
        If e.RowIndex < 0 Then Return
        If dgvKategori.Rows.Count = 0 Then Return

        Try
            Dim baris As DataGridViewRow = dgvKategori.Rows(e.RowIndex)
            ' Menggunakan nama kolom langsung agar nilai tidak tertukar atau salah membaca kolom gambar
            If baris.Cells("ID").Value IsNot Nothing Then
                txtKodeKategori.Text = baris.Cells("ID").Value.ToString()
            End If
            If baris.Cells("Nama Kategori").Value IsNot Nothing Then
                txtNamaKategori.Text = baris.Cells("Nama Kategori").Value.ToString()
            End If
            SetModeEdit()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data baris: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' ================================================================
    ' EVENT: Pencarian Real-time
    ' ================================================================
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If _dtSumber Is Nothing Then Return

        Dim kataCari As String = txtCari.Text.Trim().ToLower()
        If String.IsNullOrEmpty(kataCari) Then
            dgvKategori.DataSource = _dtSumber
            Return
        End If

        ' Filter menggunakan LINQ pada DataTable
        Dim dvFilter As New DataView(_dtSumber)
        dvFilter.RowFilter = "CONVERT([Nama Kategori], System.String) LIKE '%" & kataCari & "%'"
        dgvKategori.DataSource = dvFilter.ToTable()
        lblStatusBar.Text = "Ditemukan: " & dgvKategori.Rows.Count & " kategori."
    End Sub

    ' ================================================================
    ' CRUD: SIMPAN (Insert)
    ' ================================================================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' --- Validasi ---
        If String.IsNullOrWhiteSpace(txtNamaKategori.Text) Then
            MessageBox.Show("Nama kategori tidak boleh kosong!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaKategori.Focus()
            Return
        End If

        If txtNamaKategori.Text.Trim().Length < 3 Then
            MessageBox.Show("Nama kategori minimal 3 karakter!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaKategori.Focus()
            Return
        End If

        ' --- Eksekusi INSERT ---
        Dim sql As String =
            "INSERT INTO kategori_menu (kategori_id, nama_kategori) VALUES (@id, @nama)"

        Dim hasil As Integer = EksekusiNonQuery(
            sql,
            New MySqlParameter("@id", MySqlDbType.VarChar, 10) With {.Value = txtKodeKategori.Text.Trim()},
            New MySqlParameter("@nama", MySqlDbType.VarChar, 50) With {.Value = txtNamaKategori.Text.Trim()}
        )

        If hasil > 0 Then
            MessageBox.Show("Kategori [" & txtNamaKategori.Text.Trim() & "] berhasil disimpan!",
                            "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MuatDataKategori()
            SetModeTambah()
        End If
    End Sub

    ' ================================================================
    ' CRUD: UBAH (Update)
    ' ================================================================
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If String.IsNullOrWhiteSpace(txtNamaKategori.Text) Then
            MessageBox.Show("Nama kategori tidak boleh kosong!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaKategori.Focus()
            Return
        End If

        Dim konfirmasi As DialogResult =
            MessageBox.Show(
                "Ubah nama kategori [" & txtKodeKategori.Text & "] menjadi:" & vbCrLf &
                """" & txtNamaKategori.Text.Trim() & """?",
                "Konfirmasi Perubahan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

        If konfirmasi <> DialogResult.Yes Then Return

        Dim sql As String =
            "UPDATE kategori_menu SET nama_kategori = @nama WHERE kategori_id = @id"

        Dim hasil As Integer = EksekusiNonQuery(
            sql,
            New MySqlParameter("@nama", MySqlDbType.VarChar, 50) With {.Value = txtNamaKategori.Text.Trim()},
            New MySqlParameter("@id", MySqlDbType.VarChar, 10) With {.Value = txtKodeKategori.Text.Trim()}
        )

        If hasil > 0 Then
            MessageBox.Show("Kategori berhasil diperbarui!", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            MuatDataKategori()
            SetModeTambah()
        End If
    End Sub

    ' ================================================================
    ' CRUD: HAPUS (Delete) - dengan validasi FK
    ' ================================================================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        ' Cek apakah kategori ini masih dipakai di tabel menu (FK protection)
        Dim sqlCek As String =
            "SELECT COUNT(*) FROM menu WHERE kategori_id = @id"

        Dim dtCek As DataTable = AmbilDataTable(
            sqlCek,
            New MySqlParameter("@id", MySqlDbType.VarChar, 10) With {.Value = txtKodeKategori.Text.Trim()}
        )

        If dtCek IsNot Nothing Then
            Dim jumlahRelasi As Integer = Convert.ToInt32(dtCek.Rows(0)(0))
            If jumlahRelasi > 0 Then
                MessageBox.Show(
                    "Kategori [" & txtKodeKategori.Text & "] tidak dapat dihapus!" & vbCrLf &
                    "Kategori ini masih digunakan oleh " & jumlahRelasi & " data menu." & vbCrLf &
                    "Hapus atau pindahkan data menu terkait terlebih dahulu.",
                    "Tidak Dapat Dihapus",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)
                Return
            End If
        End If

        ' Konfirmasi penghapusan
        Dim konfirmasi As DialogResult =
            MessageBox.Show(
                "Yakin ingin menghapus kategori [" & txtKodeKategori.Text & "] - " &
                txtNamaKategori.Text & "?" & vbCrLf & "Tindakan ini tidak dapat dibatalkan!",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

        If konfirmasi <> DialogResult.Yes Then Return

        Dim sql As String = "DELETE FROM kategori_menu WHERE kategori_id = @id"
        Dim hasil As Integer = EksekusiNonQuery(
            sql,
            New MySqlParameter("@id", MySqlDbType.VarChar, 10) With {.Value = txtKodeKategori.Text.Trim()}
        )

        If hasil > 0 Then
            MessageBox.Show("Kategori berhasil dihapus.", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            MuatDataKategori()
            SetModeTambah()
        End If
    End Sub

    ' ================================================================
    ' EVENT: Tombol Batal / Reset
    ' ================================================================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        SetModeTambah()
        txtCari.Clear()
        MuatDataKategori()
    End Sub

    ' ================================================================
    ' EVENT: Tombol Kembali ke Dashboard
    ' ================================================================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

End Class
