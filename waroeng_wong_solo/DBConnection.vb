Imports MySql.Data.MySqlClient

Module DBConnection
    ' Variabel publik agar bisa diakses dari semua Form
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public rd As MySqlDataReader
    Public dt As DataTable

    ' Pastikan nama database sesuai dengan script SQL final: db_wws_tugas_kelompok
    ' Jika MySQL kamu menggunakan password (misal root/root), tambahkan di Password=
    Public strKoneksi As String = "Server=localhost;Port=3308;User ID=root;Password=;Database=db_wws_tugas_kelompok;"

    ' Sub-rutin untuk membuka koneksi dengan aman
    Public Sub BukaKoneksi()
        Try
            If conn Is Nothing OrElse conn.State = ConnectionState.Closed Then
                conn = New MySqlConnection(strKoneksi)
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Gagal terhubung ke database MySQL. Pastikan XAMPP menyala." & vbCrLf & "Detail: " & ex.Message, MsgBoxStyle.Critical, "Koneksi Error")
        End Try
    End Sub

    ' Sub-rutin untuk menutup koneksi 
    Public Sub TutupKoneksi()
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox("Gagal menutup koneksi: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Module