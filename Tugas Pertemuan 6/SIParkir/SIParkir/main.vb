Public Class main
    Private Sub txtNamaPelanggan_TextChanged(sender As Object, e As EventArgs) Handles txtNamaPelanggan.TextChanged

    End Sub

    Private Sub AturProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturProfilToolStripMenuItem.Click
        profil.Show()

    End Sub

    Private Sub LanggananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanggananToolStripMenuItem.Click
        langganan.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        laporan.Show()
    End Sub
End Class