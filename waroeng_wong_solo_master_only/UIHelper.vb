Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms

Public Module UIHelper

    Private _imageCache As New Dictionary(Of String, Image)(StringComparer.OrdinalIgnoreCase)

    ''' <summary>
    ''' Menggambar strip tenda kotak-kotak marun-putih khas Waroeng Wong Solo secara aman
    ''' </summary>
    Public Sub GambarTendaAwning(sender As Object, e As PaintEventArgs)
        Try
            Dim ctrl = TryCast(sender, Control)
            If ctrl Is Nothing OrElse ctrl.Width <= 0 Then Return

            Dim g = e.Graphics
            Dim w As Integer = 24
            Dim h As Integer = ctrl.Height
            If h <= 0 Then h = 16

            Using brushMarun As New SolidBrush(Color.FromArgb(139, 26, 26)),
                  brushPutih As New SolidBrush(Color.White)
                Dim isMarun As Boolean = True
                For x As Integer = 0 To ctrl.Width Step w
                    Dim b = If(isMarun, brushMarun, brushPutih)
                    g.FillRectangle(b, x, 0, w, h)
                    isMarun = Not isMarun
                Next
            End Using
        Catch ex As Exception
            ' Mencegah crash jika terjadi masalah GDI+
        End Try
    End Sub

    ''' <summary>
    ''' Mengambil aset gambar ikon menu dari folder Resources/Icons berdasarkan kata kunci atau nama menu
    ''' Dijamin selalu mengembalikan objek Image (memiliki fallback grafis jika file tidak ditemukan)
    ''' </summary>
    Public Function GetMenuIcon(namaMenuOrKey As String) As Image
        If String.IsNullOrWhiteSpace(namaMenuOrKey) Then namaMenuOrKey = "nasi_liwet"

        Dim textLower As String = namaMenuOrKey.Trim().ToLower()
        Dim iconKey As String = "nasi_liwet"

        ' Pencocokan nama menu ke file ikon yang tersedia
        If textLower.Contains("liwet") OrElse textLower.Contains("nasi") Then
            iconKey = "nasi_liwet"
        ElseIf textLower.Contains("selat") Then
            iconKey = "selat_solo"
        ElseIf textLower.Contains("tengkleng") OrElse textLower.Contains("kambing") Then
            iconKey = "tengkleng"
        ElseIf textLower.Contains("buntel") OrElse textLower.Contains("sate") OrElse
               textLower.Contains("ayam") OrElse textLower.Contains("bebek") OrElse
               textLower.Contains("nila") OrElse textLower.Contains("tahu") OrElse
               textLower.Contains("tempe") OrElse textLower.Contains("lauk") Then
            iconKey = "sate_buntel"
        ElseIf textLower.Contains("dawet") OrElse textLower.Contains("es") OrElse textLower.Contains("dingin") Then
            iconKey = "es_dawet"
        ElseIf textLower.Contains("uwuh") OrElse textLower.Contains("wedang") OrElse textLower.Contains("hangat") Then
            iconKey = "wedang_uwuh"
        ElseIf textLower.Contains("poci") OrElse textLower.Contains("teh") OrElse
               textLower.Contains("jus") OrElse textLower.Contains("jeruk") OrElse
               textLower.Contains("minum") Then
            iconKey = "teh_poci"
        ElseIf textLower.Contains("serabi") Then
            iconKey = "serabi"
        Else
            iconKey = textLower.Replace(" ", "_")
        End If

        ' Gunakan cache jika sudah pernah dimuat
        If _imageCache.ContainsKey(iconKey) AndAlso _imageCache(iconKey) IsNot Nothing Then
            Return _imageCache(iconKey)
        End If

        ' Cari file di berbagai kemungkinan direktori
        Dim fileNames() As String = {iconKey & ".png", iconKey & ".jpg"}
        Dim searchDirs() As String = {
            Path.Combine(Application.StartupPath, "Resources", "Icons"),
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Icons"),
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Resources", "Icons"),
            "d:\Kuliah Farel\semester 3\pemograman dektop\tugas 4\waroeng_wong_solo\waroeng_wong_solo\Resources\Icons"
        }

        For Each dirPath In searchDirs
            If Directory.Exists(dirPath) Then
                For Each fn In fileNames
                    Dim fullPath As String = Path.Combine(dirPath, fn)
                    If File.Exists(fullPath) Then
                        Try
                            ' Buka via MemoryStream agar file disk tidak terkunci
                            Dim bytes() As Byte = File.ReadAllBytes(fullPath)
                            Using ms As New MemoryStream(bytes)
                                Dim img As Image = Image.FromStream(ms)
                                Dim cloneImg As New Bitmap(img)
                                _imageCache(iconKey) = cloneImg
                                Return cloneImg
                            End Using
                        Catch
                        End Try
                    End If
                Next
            End If
        Next

        ' Fallback Grafis jika file belum tersedia di disk
        Dim fallbackBmp = BuatIkonFallback(namaMenuOrKey, iconKey)
        _imageCache(iconKey) = fallbackBmp
        Return fallbackBmp
    End Function

    ''' <summary>
    ''' Membuat gambar ikon fallback berkualitas tinggi dengan gaya visual Waroeng Wong Solo
    ''' </summary>
    Private Function BuatIkonFallback(judul As String, iconKey As String) As Image
        Dim bmp As New Bitmap(200, 120)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.Clear(Color.FromArgb(248, 242, 235))

            ' Background plate
            Using brushPlate As New SolidBrush(Color.FromArgb(235, 222, 206))
                g.FillEllipse(brushPlate, 30, 15, 140, 90)
            End Using

            ' Border plate
            Using penPlate As New Pen(Color.FromArgb(196, 98, 45), 2)
                g.DrawEllipse(penPlate, 30, 15, 140, 90)
            End Using

            ' Simbol/Inisial
            Dim simbol As String = "🍲"
            If iconKey.Contains("es") OrElse iconKey.Contains("dawet") Then
                simbol = "🍧"
            ElseIf iconKey.Contains("teh") OrElse iconKey.Contains("uwuh") OrElse iconKey.Contains("poci") Then
                simbol = "☕"
            ElseIf iconKey.Contains("sate") OrElse iconKey.Contains("buntel") Then
                simbol = "🍢"
            End If

            Using fSimbol As New Font("Segoe UI Emoji", 26, FontStyle.Regular)
                Dim sf As New StringFormat() With {
                    .Alignment = StringAlignment.Center,
                    .LineAlignment = StringAlignment.Center
                }
                g.DrawString(simbol, fSimbol, Brushes.Black, New RectangleF(0, 20, 200, 50), sf)
            End Using

            ' Teks nama pendek di bawah
            Using fTeks As New Font("Segoe UI", 9.0!, FontStyle.Bold),
                  brushTeks As New SolidBrush(Color.FromArgb(44, 24, 16))
                Dim sfTeks As New StringFormat() With {
                    .Alignment = StringAlignment.Center,
                    .LineAlignment = StringAlignment.Center
                }
                Dim displayNama As String = If(judul.Length > 20, judul.Substring(0, 18) & "...", judul)
                g.DrawString(displayNama, fTeks, brushTeks, New RectangleF(10, 78, 180, 30), sfTeks)
            End Using
        End Using
        Return bmp
    End Function

End Module