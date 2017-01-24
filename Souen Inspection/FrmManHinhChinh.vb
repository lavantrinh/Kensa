Public Class FrmManHinhChinh
    Private Sub FrmManHinhChinh_Load(sender As Object, e As EventArgs) Handles Me.Load
        FrmNhapMaVach.MdiParent = Me
        FrmNhapMaVach.Show()
        FrmNhapMaVach.Activate()
        FrmNhapMaVach.txtNhapMaVach.Select()
    End Sub
End Class
