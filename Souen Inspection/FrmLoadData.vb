Imports CrystalActiveXReportViewerLib13
Imports System.Xml
Public Class FrmLoadData
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim DuongDanFolder = XDocument.Load(My.Application.Info.DirectoryPath & "\setup.xml")
        Dim NguoiKiemDuyet As String
        NguoiKiemDuyet = DuongDanFolder.<setup>.<Staff>.<NguoiDuyet>.Value
        Dim report As New CrystalReport2
        report.SetParameterValue("RTenSanPham", FrmManHinhNhapDuLieu.txtTenSanPham.Text)
        report.SetParameterValue("RTenBanVe", FrmManHinhNhapDuLieu.txtTenBanVe.Text)
        report.SetParameterValue("RThoiHan", FrmManHinhNhapDuLieu.txtThoiHan.Text)
        report.SetParameterValue("RSoLuong", FrmManHinhNhapDuLieu.txtSoLuong.Text)
        report.SetParameterValue("RNgayKiemTra", Date.Today)
        report.SetParameterValue("RSoLuongKiemTra", "1")

        report.SetParameterValue("RKichThuoc1", FrmManHinhNhapDuLieu.lbn11.Text)
        report.SetParameterValue("RKichThuoc2", FrmManHinhNhapDuLieu.lbn2.Text)
        report.SetParameterValue("RKichThuoc3", FrmManHinhNhapDuLieu.lbn3.Text)
        report.SetParameterValue("RKichThuoc4", FrmManHinhNhapDuLieu.lbn4.Text)
        report.SetParameterValue("RKichThuoc5", FrmManHinhNhapDuLieu.lbn5.Text)
        report.SetParameterValue("RKichThuoc6", FrmManHinhNhapDuLieu.lbn6.Text)
        report.SetParameterValue("RKichThuoc7", FrmManHinhNhapDuLieu.lbn7.Text)
        report.SetParameterValue("RKichThuoc8", FrmManHinhNhapDuLieu.lbn8.Text)
        report.SetParameterValue("RKichThuoc9", FrmManHinhNhapDuLieu.lbn9.Text)
        report.SetParameterValue("RKichThuoc10", FrmManHinhNhapDuLieu.lbn10.Text)
        report.SetParameterValue("RKichThuoc11", FrmManHinhNhapDuLieu.lbn11.Text)
        report.SetParameterValue("RKichThuoc12", FrmManHinhNhapDuLieu.lbn12.Text)
        report.SetParameterValue("RKichThuoc13", FrmManHinhNhapDuLieu.lbn13.Text)

        report.SetParameterValue("RDungSai1", FrmManHinhNhapDuLieu.lbnDungSai1.Text)
        report.SetParameterValue("RDungSai2", FrmManHinhNhapDuLieu.lbnDungSai2.Text)
        report.SetParameterValue("RDungSai3", FrmManHinhNhapDuLieu.lbnDungSai3.Text)
        report.SetParameterValue("RDungSai4", FrmManHinhNhapDuLieu.lbnDungSai4.Text)
        report.SetParameterValue("RDungSai5", FrmManHinhNhapDuLieu.lbnDungSai5.Text)
        report.SetParameterValue("RDungSai6", FrmManHinhNhapDuLieu.lbnDungSai6.Text)
        report.SetParameterValue("RDungSai7", FrmManHinhNhapDuLieu.lbnDungSai7.Text)
        report.SetParameterValue("RDungSai8", FrmManHinhNhapDuLieu.lbnDungSai8.Text)
        report.SetParameterValue("RDungSai9", FrmManHinhNhapDuLieu.lbnDungSai9.Text)
        report.SetParameterValue("RDungSai10", FrmManHinhNhapDuLieu.lbnDungSai10.Text)
        report.SetParameterValue("RDungSai11", FrmManHinhNhapDuLieu.lbnDungSai11.Text)
        report.SetParameterValue("RDungSai12", FrmManHinhNhapDuLieu.lbnDungSai12.Text)
        report.SetParameterValue("RDungSai13", FrmManHinhNhapDuLieu.lbnDungSai13.Text)

        report.SetParameterValue("RKichThuocDoDuoc1", FrmManHinhNhapDuLieu.txtKichThuoc1.Text)
        report.SetParameterValue("RKichThuocDoDuoc2", FrmManHinhNhapDuLieu.txtKichThuoc2.Text)
        report.SetParameterValue("RKichThuocDoDuoc3", FrmManHinhNhapDuLieu.txtKichThuoc3.Text)
        report.SetParameterValue("RKichThuocDoDuoc4", FrmManHinhNhapDuLieu.txtKichThuoc4.Text)
        report.SetParameterValue("RKichThuocDoDuoc5", FrmManHinhNhapDuLieu.txtKichThuoc5.Text)
        report.SetParameterValue("RKichThuocDoDuoc6", FrmManHinhNhapDuLieu.txtKichThuoc6.Text)
        report.SetParameterValue("RKichThuocDoDuoc7", FrmManHinhNhapDuLieu.txtKichThuoc7.Text)
        report.SetParameterValue("RKichThuocDoDuoc8", FrmManHinhNhapDuLieu.txtKichThuoc8.Text)
        report.SetParameterValue("RKichThuocDoDuoc9", FrmManHinhNhapDuLieu.txtKichThuoc9.Text)
        report.SetParameterValue("RKichThuocDoDuoc10", FrmManHinhNhapDuLieu.txtKichThuoc10.Text)
        report.SetParameterValue("RKichThuocDoDuoc11", FrmManHinhNhapDuLieu.txtKichThuoc11.Text)
        report.SetParameterValue("RKichThuocDoDuoc12", FrmManHinhNhapDuLieu.txtKichThuoc12.Text)
        report.SetParameterValue("RKichThuocDoDuoc13", FrmManHinhNhapDuLieu.txtKichThuoc13.Text)

        report.SetParameterValue("RDungCu1", FrmManHinhNhapDuLieu.lbnDungCu1.Text)
        report.SetParameterValue("RDungCu2", FrmManHinhNhapDuLieu.lbnDungCu2.Text)
        report.SetParameterValue("RDungCu3", FrmManHinhNhapDuLieu.lbnDungCu3.Text)
        report.SetParameterValue("RDungCu4", FrmManHinhNhapDuLieu.lbnDungCu4.Text)
        report.SetParameterValue("RDungCu5", FrmManHinhNhapDuLieu.lbnDungCu5.Text)
        report.SetParameterValue("RDungCu6", FrmManHinhNhapDuLieu.lbnDungCu6.Text)
        report.SetParameterValue("RDungCu7", FrmManHinhNhapDuLieu.lbnDungCu7.Text)
        report.SetParameterValue("RDungCu8", FrmManHinhNhapDuLieu.lbnDungCu8.Text)
        report.SetParameterValue("RDungCu9", FrmManHinhNhapDuLieu.lbnDungCu9.Text)
        report.SetParameterValue("RDungCu10", FrmManHinhNhapDuLieu.lbnDungCu10.Text)
        report.SetParameterValue("RDungCu11", FrmManHinhNhapDuLieu.lbnDungCu11.Text)
        report.SetParameterValue("RDungCu12", FrmManHinhNhapDuLieu.lbnDungCu12.Text)
        report.SetParameterValue("RDungCu13", FrmManHinhNhapDuLieu.lbnDungCu13.Text)

        report.SetParameterValue("RNguoiKiemTra1", FrmNhapMaVach.TextBox1.Text)
        report.SetParameterValue("RNguoiKiemTra2", NguoiKiemDuyet)
        report.SetParameterValue("RNguoiKiemTra3", NguoiKiemDuyet)
        report.SetParameterValue("RGhiChu", FrmManHinhNhapDuLieu.txtGhiChu.Text)
        report.SetParameterValue("RNoiDungThayDoi", "")
        report.SetParameterValue("ROk", "合格")
        report.SetParameterValue("RNG", "")
        report.SetParameterValue("RLoaiSan Pham", "")
        If FrmManHinhNhapDuLieu.lbn1.Text = "" Then
            report.SetParameterValue("RKetQua1", "")
        Else
            report.SetParameterValue("RKetQua1", "合格")
        End If

        If FrmManHinhNhapDuLieu.lbn2.Text = "" Then
            report.SetParameterValue("RKetQua2", "")
        Else
            report.SetParameterValue("RKetQua2", "合格")
        End If

        If FrmManHinhNhapDuLieu.lbn3.Text = "" Then
            report.SetParameterValue("RKetQua3", "")
        Else
            report.SetParameterValue("RKetQua3", "合格")
        End If

        If FrmManHinhNhapDuLieu.lbn4.Text = "" Then
            report.SetParameterValue("RKetQua4", "")
        Else
            report.SetParameterValue("RKetQua4", "合格")
        End If

        If FrmManHinhNhapDuLieu.lbn5.Text = "" Then
            report.SetParameterValue("RKetQua5", "")
        Else
            report.SetParameterValue("RKetQua5", "合格")
        End If

        If FrmManHinhNhapDuLieu.lbn6.Text = "" Then
            report.SetParameterValue("RKetQua6", "")
        Else
            report.SetParameterValue("RKetQua6", "合格")
        End If

        If FrmManHinhNhapDuLieu.lbn7.Text = "" Then
            report.SetParameterValue("RKetQua7", "")
        Else
            report.SetParameterValue("RKetQua7", "合格")
        End If

        If FrmManHinhNhapDuLieu.lbn8.Text = "" Then
            report.SetParameterValue("RKetQua8", "")
        Else
            report.SetParameterValue("RKetQua8", "合格")
        End If

        If FrmManHinhNhapDuLieu.lbn9.Text = "" Then
            report.SetParameterValue("RKetQua9", "")
        Else
            report.SetParameterValue("RKetQua9", "合格")
        End If

        If FrmManHinhNhapDuLieu.lbn10.Text = "" Then
            report.SetParameterValue("RKetQua10", "")
        Else
            report.SetParameterValue("RKetQua10", "合格")
        End If

        If FrmManHinhNhapDuLieu.lbn11.Text = "" Then
            report.SetParameterValue("RKetQua11", "")
        Else
            report.SetParameterValue("RKetQua11", "合格")
        End If

        If FrmManHinhNhapDuLieu.lbn12.Text = "" Then
            report.SetParameterValue("RKetQua12", "")
        Else
            report.SetParameterValue("RKetQua12", "合格")
        End If

        If FrmManHinhNhapDuLieu.lbn13.Text = "" Then
            report.SetParameterValue("RKetQua13", "")
        Else
            report.SetParameterValue("RKetQua13", "合格")
        End If

        report.SetParameterValue("RKiemTraToanBo1", "")
        report.SetParameterValue("RKiemTraToanBo2", "")
        report.SetParameterValue("RKiemTraToanBo3", "")
        report.SetParameterValue("RKiemTraToanBo4", "")
        report.SetParameterValue("RKiemTraToanBo5", "")
        report.SetParameterValue("RKiemTraToanBo6", "")
        report.SetParameterValue("RKiemTraToanBo7", "")
        report.SetParameterValue("RKiemTraToanBo8", "")
        report.SetParameterValue("RKiemTraToanBo9", "")
        report.SetParameterValue("RKiemTraToanBo10", "")
        report.SetParameterValue("RKiemTraToanBo11", "")
        report.SetParameterValue("RKiemTraToanBo12", "")
        report.SetParameterValue("RKiemTraToanBo13", "")

        report.SetParameterValue("RKetQua2-1", "")
        report.SetParameterValue("RKetQua2-2", "")
        report.SetParameterValue("RKetQua2-3", "")
        report.SetParameterValue("RKetQua2-4", "")
        report.SetParameterValue("RKetQua2-5", "")
        report.SetParameterValue("RKetQua2-6", "")
        report.SetParameterValue("RKetQua2-7", "")
        report.SetParameterValue("RKetQua2-8", "")
        report.SetParameterValue("RKetQua2-9", "")
        report.SetParameterValue("RKetQua2-10", "")
        report.SetParameterValue("RKetQua2-11", "")
        report.SetParameterValue("RKetQua2-12", "")
        report.SetParameterValue("RKetQua2-13", "")
        report.SetParameterValue("RKetQuaTong", "")
        CrystalReportViewer1.ReportSource = report
    End Sub

    Private Sub FrmLoadData_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class