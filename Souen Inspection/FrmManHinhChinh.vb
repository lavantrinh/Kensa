Public Class FrmManHinhChinh
    Private Sub FrmManHinhChinh_Load(sender As Object, e As EventArgs) Handles Me.Load
        FrmNhapMaVach.MdiParent = Me
        FrmNhapMaVach.Show()
        FrmNhapMaVach.Activate()
        FrmNhapMaVach.txtNhapMaVach.Select()
    End Sub

    Private Sub 設定ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 設定ToolStripMenuItem.Click
        FrmSetup.MdiParent = Me
        FrmSetup.Show()
        FrmSetup.Activate()
    End Sub

    Private Sub 新図面情報入力ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新図面情報入力ToolStripMenuItem.Click
        ThemDuLieuBanVe.MdiParent = Me
        ThemDuLieuBanVe.Show()
        ThemDuLieuBanVe.Activate()

    End Sub
End Class
