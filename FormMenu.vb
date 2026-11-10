Imports MySql.Data.MySqlClient

Public Class FormMenu

    ' ============================================================
    ' FORM MASTER MENU - Waroeng Wong Solo
    ' CRUD: Tambah, Lihat, Ubah, Hapus Data Menu
    ' Relasi: Tabel Anak berelasi ke kategori_menu (FK)
    ' ============================================================

    Private _modeEdit As Boolean = False
    Private _dtSumber As DataTable = Nothing

    ' ================================================================
    ' INISIALISASI FORM
    ' ================================================================
    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KonfigurasiGrid()
        MuatKategoriKeComboBox()
        MuatDataMenu()
        SetModeTambah()
        pbFotoMenu.Image = UIHelper.GetMenuIcon("nasi_liwet")
    End Sub

    Private Sub pnlAwning_Paint(sender As Object, e As PaintEventArgs) Handles pnlAwning.Paint
        UIHelper.GambarTendaAwning(sender, e)
    End Sub

    ' ----------------------------------------------------------------
    ' KonfigurasiGrid: Atur tampilan DataGridView
    ' ----------------------------------------------------------------
    Private Sub KonfigurasiGrid()
        dgvMenu.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(44, 24, 16)
        dgvMenu.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        dgvMenu.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        dgvMenu.EnableHeadersVisualStyles = False
        dgvMenu.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(252, 246, 238)
        dgvMenu.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(248, 225, 205)
        dgvMenu.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(44, 24, 16)
        dgvMenu.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        dgvMenu.RowTemplate.Height = 44
    End Sub

    ' ================================================================
    ' DATA
    ' ================================================================
    Private Sub MuatKategoriKeComboBox()
        Dim sql As String = "SELECT kategori_id, nama_kategori FROM kategori_menu ORDER BY nama_kategori ASC"
        Dim dtKat As DataTable = AmbilDataTable(sql)

        If dtKat IsNot Nothing AndAlso dtKat.Rows.Count > 0 Then
            cmbKategori.DataSource = dtKat
            cmbKategori.DisplayMember = "nama_kategori"
            cmbKategori.ValueMember = "kategori_id"
            cmbKategori.SelectedIndex = -1
        Else
            MessageBox.Show(
                "Belum ada data kategori!" & vbCrLf &
                "Silakan isi data kategori terlebih dahulu di Form Kategori Menu.",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)
        End If

        ' Juga muat ke ComboBox filter
        Dim dtKatFilter As New DataTable()
        dtKatFilter.Columns.Add("kategori_id", GetType(String))
        dtKatFilter.Columns.Add("nama_kategori", GetType(String))
        dtKatFilter.Rows.Add("", "Semua Kategori")

        If dtKat IsNot Nothing Then
            For Each r As DataRow In dtKat.Rows
                dtKatFilter.Rows.Add(r("kategori_id"), r("nama_kategori"))
            Next
        End If

        cmbFilterKategori.DataSource = dtKatFilter
        cmbFilterKategori.DisplayMember = "nama_kategori"
        cmbFilterKategori.ValueMember = "kategori_id"
        cmbFilterKategori.SelectedIndex = 0
    End Sub

    Private Sub MuatDataMenu(Optional filterKategori As String = "")
        Dim sql As String =
            "SELECT m.menu_id AS 'ID', k.nama_kategori AS 'Kategori', " &
            "       m.nama_menu AS 'Nama Menu', " &
            "       FORMAT(m.harga, 0, 'id_ID') AS 'Harga (Rp)', " &
            "       CASE WHEN m.tersedia = 1 THEN '✔ Tersedia' ELSE '✘ Habis' END AS 'Ketersediaan', " &
            "       CASE WHEN m.is_aktif = 1 THEN '✔ Aktif' ELSE '✘ Nonaktif' END AS 'Status', " &
            "       m.harga AS harga_asli, m.tersedia, m.is_aktif, m.kategori_id " &
            "FROM menu m " &
            "JOIN kategori_menu k ON m.kategori_id = k.kategori_id"

        If Not String.IsNullOrEmpty(filterKategori) Then
            sql &= " WHERE m.kategori_id = @kat"
        End If
        sql &= " ORDER BY k.nama_kategori, m.nama_menu"

        Dim params() As MySqlParameter = Nothing
        If Not String.IsNullOrEmpty(filterKategori) Then
            params = {New MySqlParameter("@kat", MySqlDbType.VarChar, 10) With {.Value = filterKategori}}
        End If

        _dtSumber = If(params IsNot Nothing, AmbilDataTable(sql, params), AmbilDataTable(sql))

        If _dtSumber IsNot Nothing Then
            dgvMenu.DataSource = _dtSumber

            ' Tambahkan kolom thumbnail ikon jika belum ada
            If Not dgvMenu.Columns.Contains("colIcon") Then
                Dim colImg As New DataGridViewImageColumn()
                colImg.Name = "colIcon"
                colImg.HeaderText = ""
                colImg.ImageLayout = DataGridViewImageCellLayout.Zoom
                colImg.Width = 50
                dgvMenu.Columns.Insert(0, colImg)
            End If

            ' Isi ikon tiap menu sesuai gambar
            For Each row As DataGridViewRow In dgvMenu.Rows
                If row.Cells("Nama Menu").Value IsNot Nothing Then
                    Dim nMenu As String = row.Cells("Nama Menu").Value.ToString()
                    row.Cells("colIcon").Value = UIHelper.GetMenuIcon(nMenu)
                End If
            Next

            ' Sembunyikan kolom teknis (tidak untuk ditampilkan)
            If dgvMenu.Columns.Contains("harga_asli") Then dgvMenu.Columns("harga_asli").Visible = False
            If dgvMenu.Columns.Contains("tersedia") Then dgvMenu.Columns("tersedia").Visible = False
            If dgvMenu.Columns.Contains("is_aktif") Then dgvMenu.Columns("is_aktif").Visible = False
            If dgvMenu.Columns.Contains("kategori_id") Then dgvMenu.Columns("kategori_id").Visible = False

            lblStatusBar.Text = "Total menu: " & _dtSumber.Rows.Count & " item."
        Else
            lblStatusBar.Text = "Gagal memuat data menu."
        End If
    End Sub

    ' ================================================================
    ' MODE FORM
    ' ================================================================
    Private Sub SetModeTambah()
        _modeEdit = False
        txtIDMenu.Clear()
        txtNamaMenu.Clear()
        numHarga.Value = 0
        chkTersedia.Checked = True
        chkAktif.Checked = True
        If cmbKategori.Items.Count > 0 Then cmbKategori.SelectedIndex = 0
        txtNamaMenu.Focus()

        btnSimpan.Enabled = True
        btnUbah.Enabled = False
        btnHapus.Enabled = False

        lblStatusBar.Text = "Mode: Tambah Menu Baru."
    End Sub

    Private Sub SetModeEdit()
        _modeEdit = True
        btnSimpan.Enabled = False
        btnUbah.Enabled = True
        btnHapus.Enabled = True
        lblStatusBar.Text = "Mode: Edit Menu [ID: " & txtIDMenu.Text & "]. Ubah data lalu klik Ubah."
    End Sub

    ' ================================================================
    ' EVENT: DataGridView - Klik baris
    ' ================================================================
    Private Sub dgvMenu_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellClick
        If e.RowIndex < 0 Then Return
        If dgvMenu.Rows.Count = 0 Then Return

        Try
            Dim baris As DataGridViewRow = dgvMenu.Rows(e.RowIndex)
            txtIDMenu.Text = baris.Cells("ID").Value.ToString()
            txtNamaMenu.Text = baris.Cells("Nama Menu").Value.ToString()
            numHarga.Value = Convert.ToDecimal(baris.Cells("harga_asli").Value)
            chkTersedia.Checked = Convert.ToInt32(baris.Cells("tersedia").Value) = 1
            chkAktif.Checked = Convert.ToInt32(baris.Cells("is_aktif").Value) = 1

            ' Set ComboBox ke kategori yang sesuai
            Dim katID As String = baris.Cells("kategori_id").Value.ToString()
            For i As Integer = 0 To cmbKategori.Items.Count - 1
                Dim dr As DataRow = CType(cmbKategori.Items(i), DataRowView).Row
                If dr("kategori_id").ToString() = katID Then
                    cmbKategori.SelectedIndex = i
                    Exit For
                End If
            Next

            ' Update foto menu berdasarkan nama item
            Dim namaMenu As String = txtNamaMenu.Text.ToLower()
            If namaMenu.Contains("liwet") Then
                pbFotoMenu.Image = UIHelper.GetMenuIcon("nasi_liwet")
            ElseIf namaMenu.Contains("selat") Then
                pbFotoMenu.Image = UIHelper.GetMenuIcon("selat_solo")
            ElseIf namaMenu.Contains("tengkleng") Then
                pbFotoMenu.Image = UIHelper.GetMenuIcon("tengkleng")
            ElseIf namaMenu.Contains("buntel") OrElse namaMenu.Contains("sate") Then
                pbFotoMenu.Image = UIHelper.GetMenuIcon("sate_buntel")
            ElseIf namaMenu.Contains("serabi") Then
                pbFotoMenu.Image = UIHelper.GetMenuIcon("serabi")
            ElseIf namaMenu.Contains("dawet") Then
                pbFotoMenu.Image = UIHelper.GetMenuIcon("es_dawet")
            ElseIf namaMenu.Contains("uwuh") Then
                pbFotoMenu.Image = UIHelper.GetMenuIcon("wedang_uwuh")
            ElseIf namaMenu.Contains("teh") Then
                pbFotoMenu.Image = UIHelper.GetMenuIcon("teh_poci")
            End If

            SetModeEdit()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnPilihFoto_Click(sender As Object, e As EventArgs) Handles btnPilihFoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Pilih Foto Menu"
            ofd.Filter = "File Gambar (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    pbFotoMenu.Image = Image.FromFile(ofd.FileName)
                Catch ex As Exception
                    MessageBox.Show("Gagal memuat gambar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
        End Using
    End Sub

    ' ================================================================
    ' EVENT: Filter ComboBox Kategori
    ' ================================================================
    Private Sub cmbFilterKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterKategori.SelectedIndexChanged
        If cmbFilterKategori.SelectedValue IsNot Nothing Then
            Dim filterID As String = cmbFilterKategori.SelectedValue.ToString()
            MuatDataMenu(filterID)
        End If
    End Sub

    ' ================================================================
    ' VALIDASI INPUT
    ' ================================================================
    Private Function ValidasiInput() As Boolean
        If cmbKategori.SelectedValue Is Nothing OrElse
           String.IsNullOrEmpty(cmbKategori.SelectedValue.ToString()) Then
            MessageBox.Show("Pilih kategori menu terlebih dahulu!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbKategori.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtNamaMenu.Text) Then
            MessageBox.Show("Nama menu tidak boleh kosong!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaMenu.Focus()
            Return False
        End If

        If txtNamaMenu.Text.Trim().Length < 3 Then
            MessageBox.Show("Nama menu minimal 3 karakter!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNamaMenu.Focus()
            Return False
        End If

        If numHarga.Value <= 0 Then
            MessageBox.Show("Harga menu harus lebih dari 0!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            numHarga.Focus()
            Return False
        End If

        Return True
    End Function

    ' ================================================================
    ' CRUD: SIMPAN (Insert)
    ' ================================================================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput() Then Return

        Dim sql As String =
            "INSERT INTO menu (kategori_id, nama_menu, harga, tersedia, is_aktif) " &
            "VALUES (@kat, @nama, @harga, @tersedia, @aktif)"

        Dim hasil As Integer = EksekusiNonQuery(
            sql,
            New MySqlParameter("@kat", MySqlDbType.VarChar, 10) With {.Value = cmbKategori.SelectedValue.ToString()},
            New MySqlParameter("@nama", MySqlDbType.VarChar, 100) With {.Value = txtNamaMenu.Text.Trim()},
            New MySqlParameter("@harga", MySqlDbType.Decimal) With {.Value = numHarga.Value},
            New MySqlParameter("@tersedia", MySqlDbType.TinyBlob) With {.Value = If(chkTersedia.Checked, 1, 0)},
            New MySqlParameter("@aktif", MySqlDbType.TinyBlob) With {.Value = If(chkAktif.Checked, 1, 0)}
        )

        If hasil > 0 Then
            MessageBox.Show("Menu [" & txtNamaMenu.Text.Trim() & "] berhasil disimpan!",
                            "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MuatDataMenu()
            SetModeTambah()
        End If
    End Sub

    ' ================================================================
    ' CRUD: UBAH (Update)
    ' ================================================================
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If Not ValidasiInput() Then Return

        Dim konfirmasi As DialogResult =
            MessageBox.Show(
                "Ubah data menu [" & txtNamaMenu.Text.Trim() & "]?",
                "Konfirmasi Perubahan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

        If konfirmasi <> DialogResult.Yes Then Return

        Dim sql As String =
            "UPDATE menu SET kategori_id = @kat, nama_menu = @nama, harga = @harga, " &
            "tersedia = @tersedia, is_aktif = @aktif " &
            "WHERE menu_id = @id"

        Dim hasil As Integer = EksekusiNonQuery(
            sql,
            New MySqlParameter("@kat", MySqlDbType.VarChar, 10) With {.Value = cmbKategori.SelectedValue.ToString()},
            New MySqlParameter("@nama", MySqlDbType.VarChar, 100) With {.Value = txtNamaMenu.Text.Trim()},
            New MySqlParameter("@harga", MySqlDbType.Decimal) With {.Value = numHarga.Value},
            New MySqlParameter("@tersedia", MySqlDbType.TinyBlob) With {.Value = If(chkTersedia.Checked, 1, 0)},
            New MySqlParameter("@aktif", MySqlDbType.TinyBlob) With {.Value = If(chkAktif.Checked, 1, 0)},
            New MySqlParameter("@id", MySqlDbType.Int64) With {.Value = Convert.ToInt64(txtIDMenu.Text)}
        )

        If hasil > 0 Then
            MessageBox.Show("Data menu berhasil diperbarui!", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            MuatDataMenu()
            SetModeTambah()
        End If
    End Sub

    ' ================================================================
    ' CRUD: HAPUS (Delete)
    ' ================================================================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        ' Cek apakah menu sedang ada di detail pesanan
        Dim sqlCek As String =
            "SELECT COUNT(*) FROM detail_pesanan WHERE menu_id = @id"

        Dim dtCek As DataTable = AmbilDataTable(
            sqlCek,
            New MySqlParameter("@id", MySqlDbType.Int64) With {.Value = Convert.ToInt64(txtIDMenu.Text)}
        )

        If dtCek IsNot Nothing Then
            Dim jumlah As Integer = Convert.ToInt32(dtCek.Rows(0)(0))
            If jumlah > 0 Then
                MessageBox.Show(
                    "Menu ini tidak dapat dihapus!" & vbCrLf &
                    "Menu sudah tercatat dalam " & jumlah & " transaksi." & vbCrLf &
                    "Nonaktifkan menu ini daripada menghapusnya.",
                    "Tidak Dapat Dihapus",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)
                Return
            End If
        End If

        Dim konfirmasi As DialogResult =
            MessageBox.Show(
                "Yakin hapus menu [" & txtNamaMenu.Text & "]?" & vbCrLf &
                "Tindakan ini tidak dapat dibatalkan!",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

        If konfirmasi <> DialogResult.Yes Then Return

        Dim sql As String = "DELETE FROM menu WHERE menu_id = @id"
        Dim hasil As Integer = EksekusiNonQuery(
            sql,
            New MySqlParameter("@id", MySqlDbType.Int64) With {.Value = Convert.ToInt64(txtIDMenu.Text)}
        )

        If hasil > 0 Then
            MessageBox.Show("Menu berhasil dihapus.", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            MuatDataMenu()
            SetModeTambah()
        End If
    End Sub

    ' ================================================================
    ' EVENT: Batal/Reset
    ' ================================================================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        SetModeTambah()
        MuatDataMenu()
        cmbFilterKategori.SelectedIndex = 0
    End Sub

    ' ================================================================
    ' EVENT: Filter Pill Buttons
    ' ================================================================
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilterSemua.Click, btnFilterMakanan.Click, btnFilterSate.Click, btnFilterMinuman.Click
        Dim b = DirectCast(sender, Button)
        For Each ctrl As Control In pnlFilterBar.Controls
            If TypeOf ctrl Is Button Then
                DirectCast(ctrl, Button).BackColor = Color.White
                DirectCast(ctrl, Button).ForeColor = Color.FromArgb(44, 24, 16)
                DirectCast(ctrl, Button).FlatAppearance.BorderSize = 1
            End If
        Next
        b.BackColor = Color.FromArgb(139, 26, 26)
        b.ForeColor = Color.White
        b.FlatAppearance.BorderSize = 0

        If _dtSumber Is Nothing Then Return
        If b.Text = "Semua" Then
            _dtSumber.DefaultView.RowFilter = ""
        Else
            _dtSumber.DefaultView.RowFilter = "[Kategori] LIKE '%" & b.Text.Replace("'", "''") & "%'"
        End If
    End Sub

    ' ================================================================
    ' EVENT: Tombol Kembali ke Dashboard
    ' ================================================================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub dgvMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMenu.CellContentClick

    End Sub
End Class
