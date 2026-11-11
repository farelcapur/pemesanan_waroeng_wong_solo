' ============================================================
' MODULE SESI PENGGUNA - Waroeng Wong Solo
' Menyimpan informasi pengguna yang sedang aktif (login)
' ============================================================
Module SessionManager

    Public LoggedInUserID As Long = 0
    Public LoggedInUsername As String = ""
    Public LoggedInRole As String = ""

    ' Bersihkan sesi (dipanggil saat Logout)
    Public Sub ClearSession()
        LoggedInUserID = 0
        LoggedInUsername = ""
        LoggedInRole = ""
    End Sub

    Public Function IsAdmin() As Boolean
        Return LoggedInRole.ToUpper() = "ADMIN"
    End Function

    Public Function IsKasir() As Boolean
        Return LoggedInRole.ToUpper() = "KASIR"
    End Function

End Module

