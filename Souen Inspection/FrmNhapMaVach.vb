Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Xml
Public Class FrmNhapMaVach
    Private connection As New SqlConnection("Data Source=WILL-SV;Initial Catalog=Cabledb;Integrated Security=True")
    Private MaVach As String
    Private DuongDanBanVe As String
    Private DuongDanAnhSanPham As String
    Private DuongDanSave As String
    Private xml_doc As Object

    Private Function getDataTable(sqlQuery As String) As DataTable
        Dim dTable As New DataTable
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter(sqlQuery, connection)
        Try
            connection.Open()
            da.Fill(dTable)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connection fail, please check connection string")
        Finally
            connection.Close()
        End Try
        Return dTable

    End Function
    Private Function CheckData(barcode As String)
        Dim sqlQuery As String = String.Format("SELECT 注文番号, 製品番号, 製品名, 手配数量, 社内納期 FROM dbo.作業手配台帳 WHERE (作業手配ID) = '{0}'", barcode)
        Dim dTable As DataTable = getDataTable(sqlQuery)
        Return dTable.Rows.Count > 0
    End Function

    Public Sub FilterData(ValueToSearch As String)
        Dim SearchQuery As String = "SELECT 注文番号, 製品番号, 製品名, 手配数量, 社内納期 FROM dbo.作業手配台帳 WHERE (作業手配ID) ='" & ValueToSearch & "'"
        Dim command1 As New SqlCommand(SearchQuery, connection)
        Dim adapter As New SqlDataAdapter(command1)
        Dim table1 As New DataTable()
        adapter.Fill(table1)
        'Dim SearchQuey2 As String = "select * from KensaDatabase where [図番] = @TenBanVe"
        'Dim command2 As New SqlCommand(SearchQuey2, connection)
        'command2.Parameters.Add("@TenBanVe", SqlDbType.VarChar).Value = table1.Rows(0)(1).ToString()
        'Dim adapter2 As New SqlDataAdapter(command2)
        'Dim table2 As New DataTable()
        'adapter2.Fill(table2)
        Me.Hide()
        FrmManHinhNhapDuLieu.MdiParent = FrmManHinhChinh
        FrmManHinhNhapDuLieu.Show()
        FrmManHinhNhapDuLieu.Activate()

        FrmManHinhNhapDuLieu.txtOrder.Text = table1.Rows(0).Item("注文番号").ToString
        FrmManHinhNhapDuLieu.txtTenBanVe.Text = table1.Rows(0).Item("製品番号").ToString
        FrmManHinhNhapDuLieu.txtTenSanPham.Text = table1.Rows(0).Item("製品名").ToString
        FrmManHinhNhapDuLieu.txtSoLuong.Text = table1.Rows(0).Item("手配数量").ToString
        FrmManHinhNhapDuLieu.txtThoiHan.Text = table1.Rows(0).Item("社内納期").ToString

        Dim DuLieuSanPham = XDocument.Load("C:\Users\Mr La\Videos\111002-01.xml")
        '" & table1.Rows(0).Item("製品番号").ToString&".xml"
        FrmManHinhNhapDuLieu.AxAcroPDF1.src = "C:\Users\Mr La\Music\" & DuLieuSanPham.<information>.<drawing_name>.Value & ""
        FrmManHinhNhapDuLieu.PictureBox1.ImageLocation = "C:\Users\Mr La\Dropbox\ホシザキ電機図面管理\カメラアップロード (Old)\" & DuLieuSanPham.<information>.<picture>.<pic1>.Value & ""
        FrmManHinhNhapDuLieu.PictureBox2.ImageLocation = "C:\Users\Mr La\Dropbox\ホシザキ電機図面管理\カメラアップロード (Old)\" & DuLieuSanPham.<information>.<picture>.<pic2>.Value & ""
        FrmManHinhNhapDuLieu.PictureBox3.ImageLocation = "C:\Users\Mr La\Dropbox\ホシザキ電機図面管理\カメラアップロード (Old)\" & DuLieuSanPham.<information>.<picture>.<pic3>.Value & ""
        FrmManHinhNhapDuLieu.PictureBox4.ImageLocation = "C:\Users\Mr La\Dropbox\ホシザキ電機図面管理\カメラアップロード (Old)\" & DuLieuSanPham.<information>.<picture>.<pic4>.Value & ""
        FrmManHinhNhapDuLieu.PictureBox5.ImageLocation = "C:\Users\Mr La\Dropbox\ホシザキ電機図面管理\カメラアップロード (Old)\" & DuLieuSanPham.<information>.<picture>.<pic5>.Value & ""

        'Do ghi chu vao form
        FrmManHinhNhapDuLieu.txtGhiChu.Text = DuLieuSanPham.<information>.<note>.Value
        ' Do du lieu kich thuoc can kiem tra vao lable

        FrmManHinhNhapDuLieu.lbn1.Text = DuLieuSanPham.<information>.<dimension>.<d1>.Value
        FrmManHinhNhapDuLieu.lbn2.Text = DuLieuSanPham.<information>.<dimension>.<d2>.Value
        FrmManHinhNhapDuLieu.lbn3.Text = DuLieuSanPham.<information>.<dimension>.<d3>.Value
        FrmManHinhNhapDuLieu.lbn4.Text = DuLieuSanPham.<information>.<dimension>.<d4>.Value
        FrmManHinhNhapDuLieu.lbn5.Text = DuLieuSanPham.<information>.<dimension>.<d5>.Value
        FrmManHinhNhapDuLieu.lbn6.Text = DuLieuSanPham.<information>.<dimension>.<d6>.Value
        FrmManHinhNhapDuLieu.lbn7.Text = DuLieuSanPham.<information>.<dimension>.<d7>.Value
        FrmManHinhNhapDuLieu.lbn8.Text = DuLieuSanPham.<information>.<dimension>.<d8>.Value
        FrmManHinhNhapDuLieu.lbn9.Text = DuLieuSanPham.<information>.<dimension>.<d9>.Value
        FrmManHinhNhapDuLieu.lbn10.Text = DuLieuSanPham.<information>.<dimension>.<d10>.Value
        FrmManHinhNhapDuLieu.lbn11.Text = DuLieuSanPham.<information>.<dimension>.<d11>.Value
        FrmManHinhNhapDuLieu.lbn12.Text = DuLieuSanPham.<information>.<dimension>.<d12>.Value
        FrmManHinhNhapDuLieu.lbn13.Text = DuLieuSanPham.<information>.<dimension>.<d13>.Value

        'Do du lieu dung sai vao lable
        FrmManHinhNhapDuLieu.lbnDungSai1.Text = DuLieuSanPham.<information>.<tolerance>.<t1>.Value
        FrmManHinhNhapDuLieu.lbnDungSai2.Text = DuLieuSanPham.<information>.<tolerance>.<t2>.Value
        FrmManHinhNhapDuLieu.lbnDungSai3.Text = DuLieuSanPham.<information>.<tolerance>.<t3>.Value
        FrmManHinhNhapDuLieu.lbnDungSai4.Text = DuLieuSanPham.<information>.<tolerance>.<t4>.Value
        FrmManHinhNhapDuLieu.lbnDungSai5.Text = DuLieuSanPham.<information>.<tolerance>.<t5>.Value
        FrmManHinhNhapDuLieu.lbnDungSai6.Text = DuLieuSanPham.<information>.<tolerance>.<t6>.Value
        FrmManHinhNhapDuLieu.lbnDungSai7.Text = DuLieuSanPham.<information>.<tolerance>.<t7>.Value
        FrmManHinhNhapDuLieu.lbnDungSai8.Text = DuLieuSanPham.<information>.<tolerance>.<t8>.Value
        FrmManHinhNhapDuLieu.lbnDungSai9.Text = DuLieuSanPham.<information>.<tolerance>.<t9>.Value
        FrmManHinhNhapDuLieu.lbnDungSai10.Text = DuLieuSanPham.<information>.<tolerance>.<t10>.Value
        FrmManHinhNhapDuLieu.lbnDungSai11.Text = DuLieuSanPham.<information>.<tolerance>.<t11>.Value
        FrmManHinhNhapDuLieu.lbnDungSai12.Text = DuLieuSanPham.<information>.<tolerance>.<t12>.Value
        FrmManHinhNhapDuLieu.lbnDungSai13.Text = DuLieuSanPham.<information>.<tolerance>.<t13>.Value
        ' Do du lieu dung cu vao lable
        FrmManHinhNhapDuLieu.lbnDungCu1.Text = DuLieuSanPham.<information>.<equipment>.<e1>.Value
        FrmManHinhNhapDuLieu.lbnDungCu2.Text = DuLieuSanPham.<information>.<equipment>.<e2>.Value
        FrmManHinhNhapDuLieu.lbnDungCu3.Text = DuLieuSanPham.<information>.<equipment>.<e3>.Value
        FrmManHinhNhapDuLieu.lbnDungCu4.Text = DuLieuSanPham.<information>.<equipment>.<e4>.Value
        FrmManHinhNhapDuLieu.lbnDungCu5.Text = DuLieuSanPham.<information>.<equipment>.<e5>.Value
        FrmManHinhNhapDuLieu.lbnDungCu6.Text = DuLieuSanPham.<information>.<equipment>.<e6>.Value
        FrmManHinhNhapDuLieu.lbnDungCu7.Text = DuLieuSanPham.<information>.<equipment>.<e7>.Value
        FrmManHinhNhapDuLieu.lbnDungCu8.Text = DuLieuSanPham.<information>.<equipment>.<e8>.Value
        FrmManHinhNhapDuLieu.lbnDungCu9.Text = DuLieuSanPham.<information>.<equipment>.<e9>.Value
        FrmManHinhNhapDuLieu.lbnDungCu10.Text = DuLieuSanPham.<information>.<equipment>.<e10>.Value
        FrmManHinhNhapDuLieu.lbnDungCu11.Text = DuLieuSanPham.<information>.<equipment>.<e11>.Value
        FrmManHinhNhapDuLieu.lbnDungCu12.Text = DuLieuSanPham.<information>.<equipment>.<e12>.Value
        FrmManHinhNhapDuLieu.lbnDungCu13.Text = DuLieuSanPham.<information>.<equipment>.<e13>.Value

        'FrmManHinhNhapDuLieu.DataGridView2.DataSource = table2
    End Sub
    Private Function IsEmty() As Boolean
            Return String.IsNullOrEmpty(Me.txtNhapMaVach.Text)
        End Function

        Private Sub txtNhapMaVach_TextChanged(sender As Object, e As EventArgs) Handles txtNhapMaVach.TextChanged
        MaVach = Mid(txtNhapMaVach.Text, 2, 6)


        If txtNhapMaVach.TextLength = 8 Then

            If CheckData(MaVach) Then
                FilterData(MaVach)
                If IsNumeric(FrmManHinhNhapDuLieu.lbn1.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc1.Enabled = False
                End If
                If IsNumeric(FrmManHinhNhapDuLieu.lbn2.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc2.Enabled = False
                End If
                If IsNumeric(FrmManHinhNhapDuLieu.lbn3.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc3.Enabled = False
                End If
                If IsNumeric(FrmManHinhNhapDuLieu.lbn4.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc4.Enabled = False
                End If
                If IsNumeric(FrmManHinhNhapDuLieu.lbn5.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc5.Enabled = False
                End If
                If IsNumeric(FrmManHinhNhapDuLieu.lbn6.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc6.Enabled = False
                End If
                If IsNumeric(FrmManHinhNhapDuLieu.lbn7.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc7.Enabled = False
                End If
                If IsNumeric(FrmManHinhNhapDuLieu.lbn8.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc8.Enabled = False
                End If
                If IsNumeric(FrmManHinhNhapDuLieu.lbn9.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc9.Enabled = False
                End If
                If IsNumeric(FrmManHinhNhapDuLieu.lbn10.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc10.Enabled = False
                End If
                If IsNumeric(FrmManHinhNhapDuLieu.lbn11.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc11.Enabled = False
                End If
                If IsNumeric(FrmManHinhNhapDuLieu.lbn12.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc12.Enabled = False
                End If
                If IsNumeric(FrmManHinhNhapDuLieu.lbn13.Text) = False Then
                    FrmManHinhNhapDuLieu.txtKichThuoc13.Enabled = False
                End If
            Else
                MsgBox("バーコードを見つけないです。確認して下さい。",, "エラーが発生しました。")

            End If

        End If
    End Sub

        Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If IsEmty() Then
            MessageBox.Show("バーコードはまだ入力しない")
        Else
            If CheckData(MaVach) Then
                FilterData(MaVach)
            Else
                MsgBox("バーコードを見つけないです。確認して下さい。",, "エラーが発生しました。")

            End If
        End If
        End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub FrmNhapMaVach_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Setup = XDocument.Load(My.Application.Info.DirectoryPath & "\setup.xml")
        TextBox1.Text = Setup.<setup>.<Staff>.<Staff1>.Value


    End Sub

   
End Class