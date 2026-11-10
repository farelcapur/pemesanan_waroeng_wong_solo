Imports MySql.Data.MySqlClient

Public Class FormDashboard

    ' ============================================================
    ' FORM DASHBOARD - Waroeng Wong Solo
    ' Navigasi Utama, Ringkasan Operasional, & Role-Based Access (RBAC)
    ' ============================================================

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fallback aman jika form dijalankan langsung tanpa melalui FormLogin
        If String.IsNullOrEmpty(SessionManager.LoggedInRole) Then
            SessionManager.LoggedInUserID = 1
            SessionManager.LoggedInUsername = "admin1"
            SessionManager.LoggedInRole = "ADMIN"
        End If

        ' Tampilkan identitas pengguna di sidebar
        lblUserInfo.Text = "👤 " & SessionManager.LoggedInUsername & " (" & SessionManager.LoggedInRole & ")"

        ' Sambutan personal sesuai mockup desain
        lblSelamatDatang.Text = "Selamat datang kembali,"
        lblSubSelamatDatang.Text = If(SessionManager.IsKasir(), "Kasir Waroeng", "Admin Waroeng")

        ' Terapkan pembatasan hak akses berdasarkan Peran
        TerapkanHakAkses()

        ' Pasang event klik pada kartu pintas
        HubungkanKlikKartu()

        ' Muat katalog menu andalan
        MuatMenuAndalan()
    End Sub

    Private Sub pnlAwning_Paint(sender As Object, e As PaintEventArgs) Handles pnlAwning.Paint
        UIHelper.GambarTendaAwning(sender, e)
    End Sub

    Private Sub MuatMenuAndalan()
        pnlMenuAndalan.SuspendLayout()
        pnlMenuAndalan.Controls.Clear()

        Dim coklatTua As Color = Color.FromArgb(44, 24, 16)
        Dim oranyeBurnt As Color = Color.FromArgb(196, 98, 45)

        Dim menuList() As Tuple(Of String, String, String, Color) = {
            Tuple.Create("Nasi Liwet Solo", "Rp 28.000", "nasi_liwet", Color.FromArgb(252, 230, 189)),
            Tuple.Create("Selat Solo", "Rp 35.000", "selat_solo", Color.FromArgb(237, 224, 212)),
            Tuple.Create("Sate Buntel", "Rp 38.000", "sate_buntel", Color.FromArgb(236, 220, 201)),
            Tuple.Create("Tengkleng Kambing", "Rp 42.000", "tengkleng", Color.FromArgb(232, 213, 181)),
            Tuple.Create("Serabi Notosuman", "Rp 12.000", "serabi", Color.FromArgb(252, 230, 189)),
            Tuple.Create("Es Dawet Telasih", "Rp 12.000", "es_dawet", Color.FromArgb(216, 236, 225)),
            Tuple.Create("Wedang Uwuh", "Rp 10.000", "wedang_uwuh", Color.FromArgb(248, 220, 218)),
            Tuple.Create("Teh Poci Gula Batu", "Rp 8.000", "teh_poci", Color.FromArgb(232, 218, 203))
        }

        For Each item In menuList
            Dim p As New Panel()
            p.Size = New Size(260, 215)
            p.BackColor = Color.White
            p.Margin = New Padding(0, 0, 14, 18)

            Dim imgBox As New PictureBox()
            imgBox.Size = New Size(236, 120)
            imgBox.Location = New Point(12, 12)
            imgBox.SizeMode = PictureBoxSizeMode.Zoom
            imgBox.BackColor = item.Item4
            imgBox.Image = UIHelper.GetMenuIcon(item.Item3)

            Dim lblNama As New Label()
            lblNama.Text = item.Item1
            lblNama.Font = New Font("Segoe UI", 10.5!, FontStyle.Bold)
            lblNama.ForeColor = coklatTua
            lblNama.Location = New Point(12, 145)
            lblNama.Size = New Size(236, 26)
            lblNama.UseCompatibleTextRendering = True

            Dim lblHarga As New Label()
            lblHarga.Text = item.Item2
            lblHarga.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
            lblHarga.ForeColor = oranyeBurnt
            lblHarga.Location = New Point(12, 175)
            lblHarga.Size = New Size(236, 24)
            lblHarga.UseCompatibleTextRendering = True

            p.Controls.Add(imgBox)
            p.Controls.Add(lblNama)
            p.Controls.Add(lblHarga)

            AddHandler p.Paint, Sub(s, pe)
                                    Dim curPanel = DirectCast(s, Panel)
                                    Using penBiasa As New Pen(Color.FromArgb(232, 224, 215), 1)
                                        pe.Graphics.DrawRectangle(penBiasa, 0, 0, curPanel.Width - 1, curPanel.Height - 1)
                                    End Using
                                End Sub
            pnlMenuAndalan.Controls.Add(p)
        Next
        pnlMenuAndalan.ResumeLayout()
    End Sub

    Private Sub HubungkanKlikKartu()
        Dim hubungkanSub = Sub(c As Control, targetHandler As EventHandler)
                               AddHandler c.Click, targetHandler
                               For Each anak As Control In c.Controls
                                   AddHandler anak.Click, targetHandler
                               Next
                           End Sub

        hubungkanSub(cardPesanan, AddressOf btnNavPesanan_Click)
        hubungkanSub(cardBayar, AddressOf btnNavPembayaran_Click)
        hubungkanSub(cardMenu, AddressOf btnNavMenu_Click)

        If Not SessionManager.IsKasir() Then
            hubungkanSub(cardKategori, AddressOf btnNavKategori_Click)
            hubungkanSub(cardLaporan, AddressOf btnNavLaporan_Click)
        Else
            cardKategori.Enabled = False
            cardLaporan.Enabled = False
        End If
    End Sub

    ' ----------------------------------------------------------------
    ' TerapkanHakAkses: Pengaturan hak akses berbasis peran (RBAC)
    ' ----------------------------------------------------------------
    Private Sub TerapkanHakAkses()
        If SessionManager.IsKasir() Then
            ' KASIR: Hanya mengurus transaksi dan kasir pembayaran
            btnNavKategori.Enabled = False
            btnNavKategori.ForeColor = System.Drawing.Color.FromArgb(120, 100, 90)
            btnNavKategori.Text = "  🔒  Master Kategori"

            btnNavLaporan.Enabled = False
            btnNavLaporan.ForeColor = System.Drawing.Color.FromArgb(120, 100, 90)
            btnNavLaporan.Text = "  🔒  Laporan"

            btnNavMenu.Text = "  Master Data Menu"
        Else
            ' ADMIN: Akses penuh
            btnNavKategori.Enabled = True
            btnNavKategori.ForeColor = System.Drawing.Color.FromArgb(200, 180, 160)
            btnNavKategori.Text = "  Master Kategori Menu"

            btnNavLaporan.Enabled = True
            btnNavLaporan.ForeColor = System.Drawing.Color.FromArgb(200, 180, 160)
            btnNavLaporan.Text = "  Laporan Penjualan"

            btnNavMenu.Text = "  Master Data Menu"
        End If
    End Sub

    Public Sub MuatRingkasanDashboard()
        ' Method dipertahankan agar pemanggilan kembali dari form anak tetap kompatibel
    End Sub

    ' ================================================================
    ' NAVIGASI KE FORM LAIN (Dashboard ditutup sementara, lalu muncul lagi saat kembali)
    ' ================================================================

    ' 1. Navigasi: Form Master Kategori Menu
    Private Sub btnNavKategori_Click(sender As Object, e As EventArgs) Handles btnNavKategori.Click
        Me.Hide()
        Using frm As New FormKategoriMenu()
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
        End Using
        Me.Show()
    End Sub

    ' 2. Navigasi: Form Master Data Menu
    Private Sub btnNavMenu_Click(sender As Object, e As EventArgs) Handles btnNavMenu.Click
        Me.Hide()
        Using frm As New FormMenu()
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
        End Using
        Me.Show()
    End Sub

    ' 3. Navigasi: Form Transaksi Pemesanan
    Private Sub btnNavPesanan_Click(sender As Object, e As EventArgs) Handles btnNavPesanan.Click
        Me.Hide()
        Using frm As New FormPesanan()
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
        End Using
        Me.Show()
    End Sub

    ' 4. Navigasi: Form Kasir Pembayaran
    Private Sub btnNavPembayaran_Click(sender As Object, e As EventArgs) Handles btnNavPembayaran.Click
        Me.Hide()
        Using frm As New FormPembayaran()
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
        End Using
        Me.Show()
    End Sub

    ' 5. Navigasi: Form Laporan Penjualan
    Private Sub btnNavLaporan_Click(sender As Object, e As EventArgs) Handles btnNavLaporan.Click
        Me.Hide()
        Using frm As New FormLaporan()
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
        End Using
        Me.Show()
    End Sub

    ' ================================================================
    ' LOGOUT & EXIT
    ' ================================================================
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim konfirmasi As DialogResult =
            MessageBox.Show(
                "Apakah Anda yakin ingin keluar dari akun ini?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            SessionManager.ClearSession()

            ' Cari dan buka kembali FormLogin
            Dim loginDitemukan As Boolean = False
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is FormLogin Then
                    CType(frm, FormLogin).txtPassword.Clear()
                    frm.Show()
                    loginDitemukan = True
                    Exit For
                End If
            Next

            If Not loginDitemukan Then
                Dim frmBaru As New FormLogin()
                frmBaru.Show()
            End If

            Me.Close()
        End If
    End Sub

    ' Saat Dashboard ditutup lewat tombol [X], jika belum logout, tutup seluruh aplikasi
    Private Sub FormDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If String.IsNullOrEmpty(SessionManager.LoggedInUsername) Then
            ' User melakukan logout, biarkan FormLogin tetap terbuka
            Return
        End If

        ' Jika ditutup langsung tanpa logout, hentikan seluruh proses aplikasi
        Application.Exit()
    End Sub

    Private Sub lblCardMenuSub_Click(sender As Object, e As EventArgs) Handles lblCardMenuSub.Click

    End Sub

    Private Sub lblCardMenuJudul_Click(sender As Object, e As EventArgs) Handles lblCardMenuJudul.Click

    End Sub
End Class