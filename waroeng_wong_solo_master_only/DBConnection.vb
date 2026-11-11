Imports MySql.Data.MySqlClient
Imports System.Data

' ============================================================
' MODULE KONEKSI DATABASE - Waroeng Wong Solo
' Pastikan XAMPP / MySQL Server sudah berjalan.
' Sesuaikan Port (3306 atau 3308) dengan setting XAMPP Anda.
' ============================================================
Module DBConnection

    Public strKoneksi As String =
        "Server=localhost;Port=3308;User ID=root;Password=;Database=db_wws_tugas_kelompok;Charset=utf8mb4;Connection Timeout=15;"

    Private _sinkronisasiDilakukan As Boolean = False

    ''' <summary>
    ''' Sinkronisasi awal database: menonaktifkan kue dan memastikan menu inti Wong Solo tersedia
    ''' </summary>
    Private Sub SinkronkanDatabase(koneksi As MySqlConnection)
        If _sinkronisasiDilakukan Then Return
        Try
            ' 1. Nonaktifkan menu lama yang tidak ada di desain (JANGAN nonaktifkan serabi)
            Using cmdKue As New MySqlCommand("UPDATE menu SET is_aktif = 0 WHERE LOWER(nama_menu) LIKE '%kue%' OR nama_menu IN ('Ayam Bakar Wong Solo', 'Bebek Goreng Sambal Ijo', 'Nila Bakar Manis', 'Es Teh Manis', 'Jus Jeruk Peras', 'Tahu Tempe Goreng');", koneksi)
                cmdKue.ExecuteNonQuery()
            End Using

            ' 2. Pastikan kategori dasar sesuai dengan desain (termasuk KAT003 Camilan & Kue)
            Dim sqlKategori As String =
                "INSERT IGNORE INTO kategori_menu (kategori_id, nama_kategori) VALUES " &
                "('KAT001', 'Makanan Utama'), " &
                "('KAT002', 'Sate & Lauk'), " &
                "('KAT003', 'Camilan & Kue'), " &
                "('KAT004', 'Minuman Dingin'), " &
                "('KAT005', 'Minuman Hangat');"
            Using cmdKat As New MySqlCommand(sqlKategori, koneksi)
                cmdKat.ExecuteNonQuery()
            End Using

            ' 3. Pastikan 8 menu khas Wong Solo persis sesuai desain tersedia di database
            Dim sqlMenu As String =
                "INSERT INTO menu (kategori_id, nama_menu, harga, tersedia, is_aktif) " &
                "SELECT 'KAT001', 'Nasi Liwet Solo', 28000, 1, 1 FROM DUAL " &
                "WHERE NOT EXISTS (SELECT 1 FROM menu WHERE LOWER(nama_menu) LIKE '%liwet%') LIMIT 1;" &
                "INSERT INTO menu (kategori_id, nama_menu, harga, tersedia, is_aktif) " &
                "SELECT 'KAT001', 'Selat Solo', 35000, 1, 1 FROM DUAL " &
                "WHERE NOT EXISTS (SELECT 1 FROM menu WHERE LOWER(nama_menu) LIKE '%selat%') LIMIT 1;" &
                "INSERT INTO menu (kategori_id, nama_menu, harga, tersedia, is_aktif) " &
                "SELECT 'KAT001', 'Tengkleng Kambing', 42000, 1, 1 FROM DUAL " &
                "WHERE NOT EXISTS (SELECT 1 FROM menu WHERE LOWER(nama_menu) LIKE '%tengkleng%') LIMIT 1;" &
                "INSERT INTO menu (kategori_id, nama_menu, harga, tersedia, is_aktif) " &
                "SELECT 'KAT002', 'Sate Buntel', 38000, 1, 1 FROM DUAL " &
                "WHERE NOT EXISTS (SELECT 1 FROM menu WHERE LOWER(nama_menu) LIKE '%buntel%') LIMIT 1;" &
                "INSERT INTO menu (kategori_id, nama_menu, harga, tersedia, is_aktif) " &
                "SELECT 'KAT003', 'Serabi Notosuman', 12000, 1, 1 FROM DUAL " &
                "WHERE NOT EXISTS (SELECT 1 FROM menu WHERE LOWER(nama_menu) LIKE '%serabi%') LIMIT 1;" &
                "INSERT INTO menu (kategori_id, nama_menu, harga, tersedia, is_aktif) " &
                "SELECT 'KAT004', 'Es Dawet Telasih', 12000, 1, 1 FROM DUAL " &
                "WHERE NOT EXISTS (SELECT 1 FROM menu WHERE LOWER(nama_menu) LIKE '%dawet%') LIMIT 1;" &
                "INSERT INTO menu (kategori_id, nama_menu, harga, tersedia, is_aktif) " &
                "SELECT 'KAT005', 'Wedang Uwuh', 10000, 1, 1 FROM DUAL " &
                "WHERE NOT EXISTS (SELECT 1 FROM menu WHERE LOWER(nama_menu) LIKE '%uwuh%') LIMIT 1;" &
                "INSERT INTO menu (kategori_id, nama_menu, harga, tersedia, is_aktif) " &
                "SELECT 'KAT005', 'Teh Poci Gula Batu', 8000, 1, 1 FROM DUAL " &
                "WHERE NOT EXISTS (SELECT 1 FROM menu WHERE LOWER(nama_menu) LIKE '%poci%') LIMIT 1;" &
                "UPDATE menu SET is_aktif = 1, tersedia = 1, kategori_id = 'KAT003' WHERE LOWER(nama_menu) LIKE '%serabi%';" &
                "UPDATE menu SET is_aktif = 1, tersedia = 1 WHERE nama_menu IN ('Nasi Liwet Solo', 'Selat Solo', 'Tengkleng Kambing', 'Sate Buntel', 'Es Dawet Telasih', 'Wedang Uwuh', 'Teh Poci Gula Batu');"

            Using cmdM As New MySqlCommand(sqlMenu, koneksi)
                cmdM.ExecuteNonQuery()
            End Using

            _sinkronisasiDilakukan = True
        Catch ex As Exception
            ' Abaikan error sinkronisasi otomatis agar tidak mengganggu operasional utama
        End Try
    End Sub

    ' ----------------------------------------------------------------
    ' BukaKoneksi: Buka koneksi baru dan kembalikan objek MySqlConnection
    ' ----------------------------------------------------------------
    Public Function BukaKoneksi() As MySqlConnection
        Dim koneksi As New MySqlConnection(strKoneksi)
        Try
            koneksi.Open()
            SinkronkanDatabase(koneksi)
            Return koneksi
        Catch ex As MySqlException
            Dim pesanTambahan As String = ""
            If ex.Number = 0 OrElse ex.Number = 1042 Then
                pesanTambahan = vbCrLf & "Pastikan XAMPP / MySQL Server sudah dijalankan."
            End If
            MessageBox.Show(
                "Gagal terhubung ke database MySQL!" & vbCrLf &
                "Detail: " & ex.Message & pesanTambahan,
                "Kesalahan Koneksi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    ' ----------------------------------------------------------------
    ' TutupKoneksi: Tutup dan buang koneksi dengan aman
    ' ----------------------------------------------------------------
    Public Sub TutupKoneksi(ByRef koneksi As MySqlConnection)
        Try
            If koneksi IsNot Nothing Then
                If koneksi.State = ConnectionState.Open Then
                    koneksi.Close()
                End If
                koneksi.Dispose()
                koneksi = Nothing
            End If
        Catch ex As Exception
            Debug.WriteLine("TutupKoneksi Error: " & ex.Message)
        End Try
    End Sub

    ' ----------------------------------------------------------------
    ' AmbilDataTable: Jalankan SELECT dan kembalikan DataTable
    ' ----------------------------------------------------------------
    Public Function AmbilDataTable(sql As String,
                                   ParamArray params() As MySqlParameter) As DataTable
        Dim koneksi As MySqlConnection = BukaKoneksi()
        If koneksi Is Nothing Then Return Nothing

        Dim hasil As New DataTable()
        Try
            Using cmd As New MySqlCommand(sql, koneksi)
                If params IsNot Nothing Then
                    For Each p As MySqlParameter In params
                        cmd.Parameters.Add(p)
                    Next
                End If
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(hasil)
                End Using
            End Using
            Return hasil
        Catch ex As MySqlException
            MessageBox.Show(
                "Gagal mengambil data!" & vbCrLf & "Detail: " & ex.Message,
                "Kesalahan Database",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Return Nothing
        Finally
            TutupKoneksi(koneksi)
        End Try
    End Function

    ' ----------------------------------------------------------------
    ' EksekusiNonQuery: Jalankan INSERT / UPDATE / DELETE
    ' Mengembalikan jumlah baris terpengaruh, -1 jika gagal
    ' ----------------------------------------------------------------
    Public Function EksekusiNonQuery(sql As String,
                                     ParamArray params() As MySqlParameter) As Integer
        Dim koneksi As MySqlConnection = BukaKoneksi()
        If koneksi Is Nothing Then Return -1

        Try
            Using cmd As New MySqlCommand(sql, koneksi)
                If params IsNot Nothing Then
                    For Each p As MySqlParameter In params
                        cmd.Parameters.Add(p)
                    Next
                End If
                Return cmd.ExecuteNonQuery()
            End Using
        Catch ex As MySqlException
            MessageBox.Show(
                TafsirMySqlError(ex),
                "Kesalahan Database",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
            Return -1
        Finally
            TutupKoneksi(koneksi)
        End Try
    End Function

    ' ----------------------------------------------------------------
    ' TafsirMySqlError: Terjemahkan kode error MySQL ke pesan ramah
    ' ----------------------------------------------------------------
    Public Function TafsirMySqlError(ex As MySqlException) As String
        Select Case ex.Number
            Case 1062
                Return "Data gagal disimpan: sudah ada entri yang sama (duplikasi)."
            Case 1451
                Return "Data tidak dapat dihapus karena masih digunakan oleh data lain yang berelasi."
            Case 1452
                Return "Data gagal disimpan: referensi ke data terkait tidak ditemukan."
            Case 1042, 0
                Return "Tidak dapat terhubung ke MySQL. Pastikan XAMPP / MySQL sudah berjalan."
            Case Else
                Return "Kesalahan database (Error " & ex.Number & "):" & vbCrLf & ex.Message
        End Select
    End Function

    ' ----------------------------------------------------------------
    ' HashPassword: SHA-256 untuk menyimpan kata sandi dengan aman
    ' ----------------------------------------------------------------
    Public Function HashPassword(password As String) As String
        Using sha As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()
            Dim bytes() As Byte = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))
            Dim sb As New System.Text.StringBuilder()
            For Each b As Byte In bytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

End Module
