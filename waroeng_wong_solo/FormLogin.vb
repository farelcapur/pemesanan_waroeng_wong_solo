Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil prosedur dari DBConnection.vb
        BukaKoneksi()

        ' Jika status koneksi terbuka, tampilkan pesan sukses sementara
        If conn.State = ConnectionState.Open Then
            MsgBox("Koneksi ke db_wws_tugas_kelompok Berhasil!", MsgBoxStyle.Information, "Sukses")
            TutupKoneksi() ' Segera tutup kembali untuk menghemat resource memori
        End If
    End Sub
End Class