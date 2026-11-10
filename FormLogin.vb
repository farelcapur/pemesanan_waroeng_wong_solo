Imports MySql.Data.MySqlClient

Public Class FormLogin

    ' ============================================================
    ' FORM LOGIN - Waroeng Wong Solo
    ' Autentikasi dengan validasi SHA-256 & Role-based Access
    ' ============================================================

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set Enter = tombol Login
        Me.AcceptButton = btnLogin

        ' Fokus ke kolom username saat form dibuka
        txtUsername.Select()

        ' Pastikan sesi bersih
        SessionManager.ClearSession()

        ' Muat ikon makanan di sisi kiri
        MuatGaleriIkon()
    End Sub

    Private Sub pnlAwning_Paint(sender As Object, e As PaintEventArgs) Handles pnlAwning.Paint
        UIHelper.GambarTendaAwning(sender, e)
    End Sub

    Private Sub MuatGaleriIkon()
        flpFoodIcons.SuspendLayout()
        flpFoodIcons.Controls.Clear()

        Dim ikonMakanan() As Tuple(Of String, Color) = {
            Tuple.Create("nasi_liwet", Color.FromArgb(252, 230, 189)),
            Tuple.Create("selat_solo", Color.FromArgb(237, 224, 212)),
            Tuple.Create("tengkleng", Color.FromArgb(232, 213, 181)),
            Tuple.Create("sate_buntel", Color.FromArgb(236, 220, 201)),
            Tuple.Create("es_dawet", Color.FromArgb(216, 236, 225)),
            Tuple.Create("wedang_uwuh", Color.FromArgb(248, 220, 218)),
            Tuple.Create("teh_poci", Color.FromArgb(232, 218, 203))
        }

        For Each item In ikonMakanan
            Dim p As New Panel()
            p.Size = New Size(140, 110)
            p.BackColor = item.Item2
            p.Margin = New Padding(0, 0, 12, 12)

            Dim pb As New PictureBox()
            pb.Dock = DockStyle.Fill
            pb.SizeMode = PictureBoxSizeMode.Zoom
            pb.BackColor = Color.Transparent
            pb.Image = UIHelper.GetMenuIcon(item.Item1)

            p.Controls.Add(pb)
            flpFoodIcons.Controls.Add(p)
        Next
        flpFoodIcons.ResumeLayout()
    End Sub

    ' ----------------------------------------------------------------
    ' Event: Checkbox tampilkan/sembunyikan kata sandi
    ' ----------------------------------------------------------------
    Private Sub chkTampilPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkTampilPassword.CheckedChanged
        If chkTampilPassword.Checked Then
            txtPassword.PasswordChar = Nothing
        Else
            txtPassword.PasswordChar = "*"c
        End If
    End Sub

    ' ----------------------------------------------------------------
    ' Event: Tombol Login
    ' ----------------------------------------------------------------
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' ---- Validasi input tidak boleh kosong ----
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Username tidak boleh kosong!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Kata sandi tidak boleh kosong!", "Validasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        ' ---- Hash kata sandi menggunakan SHA-256 ----
        Dim hashKataSandi As String = HashPassword(txtPassword.Text.Trim())

        ' ---- Query ke database ----
        Dim sql As String =
            "SELECT user_id, username, role, is_aktif " &
            "FROM users " &
            "WHERE username = @username AND password_hash = @hash " &
            "LIMIT 1"

        Dim paramUsername As New MySqlParameter("@username", MySqlDbType.VarChar, 50)
        paramUsername.Value = txtUsername.Text.Trim()

        Dim paramHash As New MySqlParameter("@hash", MySqlDbType.VarChar, 255)
        paramHash.Value = hashKataSandi

        Dim dtHasil As DataTable = AmbilDataTable(sql, paramUsername, paramHash)

        If dtHasil Is Nothing Then
            ' Error koneksi sudah ditampilkan di AmbilDataTable
            Return
        End If

        If dtHasil.Rows.Count = 0 Then
            ' Kredensial tidak cocok
            MessageBox.Show("Username atau kata sandi salah!" & vbCrLf &
                            "Periksa kembali dan coba lagi.",
                            "Login Gagal",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtPassword.Clear()
            txtPassword.Focus()
            Return
        End If

        Dim baris As DataRow = dtHasil.Rows(0)

        ' Cek apakah akun aktif
        If Convert.ToInt32(baris("is_aktif")) = 0 Then
            MessageBox.Show("Akun Anda tidak aktif. Hubungi Administrator.",
                            "Akun Nonaktif",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Stop)
            Return
        End If

        ' ---- Simpan sesi pengguna ----
        SessionManager.LoggedInUserID = Convert.ToInt64(baris("user_id"))
        SessionManager.LoggedInUsername = baris("username").ToString()
        SessionManager.LoggedInRole = baris("role").ToString()

        ' ---- Buka Dashboard dan sembunyikan Login ----
        Dim dashboard As New FormDashboard()
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub pnlLatar_Paint(sender As Object, e As PaintEventArgs) Handles pnlLatar.Paint

    End Sub

    Private Sub flpFoodIcons_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub flpFoodIcons_Paint_1(sender As Object, e As PaintEventArgs) Handles flpFoodIcons.Paint

    End Sub
End Class
