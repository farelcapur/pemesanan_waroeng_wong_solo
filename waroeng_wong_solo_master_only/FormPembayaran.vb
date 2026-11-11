Public Class FormPembayaran
    Inherits Form

    Public Sub New()
        Me.Text = "Pembayaran - Fitur Belum Tersedia"
        Me.Size = New Size(600, 400)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 240, 232)

        Dim lbl As New Label()
        lbl.Text = "Modul Pembayaran" & vbCrLf & "(Fitur tahap selanjutnya / di luar scope Master Form)"
        lbl.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
        lbl.ForeColor = Color.FromArgb(44, 24, 16)
        lbl.Dock = DockStyle.Fill
        lbl.TextAlign = ContentAlignment.MiddleCenter
        Me.Controls.Add(lbl)
    End Sub
End Class
