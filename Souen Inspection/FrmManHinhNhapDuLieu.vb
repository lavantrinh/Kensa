Imports System.Xml
Imports System.IO
Public Class FrmManHinhNhapDuLieu
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim DuLieuSanPham = XDocument.Load("C:\Users\Mr La\Videos\111002-01.xml")
        Process.Start("C:\Users\Mr La\Dropbox\ホシザキ電機図面管理\カメラアップロード (Old)\" & DuLieuSanPham.<information>.<picture>.<pic1>.Value & "")
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtKichThuoc1.Text = ""
        txtKichThuoc2.Text = ""
        txtKichThuoc3.Text = ""
        txtKichThuoc4.Text = ""
        txtKichThuoc5.Text = ""
        txtKichThuoc6.Text = ""
        txtKichThuoc7.Text = ""
        txtKichThuoc8.Text = ""
        txtKichThuoc9.Text = ""
        txtKichThuoc10.Text = ""
        txtKichThuoc11.Text = ""
        txtKichThuoc12.Text = ""
        txtKichThuoc13.Text = ""
    End Sub
    Private Sub createNode(ByVal pDate As String, ByVal pProductName As String,
                           ByVal pOrderNo As String, ByVal pDrawing As String, ByVal pProducName As String,
                           ByVal pQuality As String, ByVal pDeadline As String, ByVal pDimension1 As String, ByVal pDimension2 As String, ByVal pDimension3 As String,
                           ByVal pDimension4 As String, ByVal pDimension5 As String, ByVal pDimension6 As String, ByVal pDimension7 As String, ByVal pDimension8 As String,
                           ByVal pDimension9 As String, ByVal pDimension10 As String, ByVal pDimension11 As String, ByVal pDimension12 As String, ByVal pDimension13 As String,
                           ByVal writer As XmlTextWriter)
        writer.WriteStartElement("Inspection")
        writer.WriteStartElement("Date")
        writer.WriteString(pDate)
        writer.WriteEndElement()
        writer.WriteStartElement("Staff")
        writer.WriteString(pProductName)
        writer.WriteEndElement()
        writer.WriteStartElement("OrderNo")
        writer.WriteString(pOrderNo)
        writer.WriteEndElement()
        writer.WriteStartElement("Drawing")
        writer.WriteString(pDrawing)
        writer.WriteEndElement()
        writer.WriteStartElement("ProductName")
        writer.WriteString(pProductName)
        writer.WriteEndElement()
        writer.WriteStartElement("Quality")
        writer.WriteString(pQuality)
        writer.WriteEndElement()
        writer.WriteStartElement("Deadline")
        writer.WriteString(pDeadline)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension1")
        writer.WriteString(pDimension1)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension2")
        writer.WriteString(pDimension2)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension3")
        writer.WriteString(pDimension3)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension4")
        writer.WriteString(pDimension4)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension5")
        writer.WriteString(pDimension5)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension6")
        writer.WriteString(pDimension6)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension7")
        writer.WriteString(pDimension7)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension8")
        writer.WriteString(pDimension8)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension9")
        writer.WriteString(pDimension9)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension10")
        writer.WriteString(pDimension10)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension11")
        writer.WriteString(pDimension11)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension12")
        writer.WriteString(pDimension12)
        writer.WriteEndElement()
        writer.WriteStartElement("Dimension13")
        writer.WriteString(pDimension13)
        writer.WriteEndElement()

    End Sub

    Private Sub btbHoanThanh_Click(sender As Object, e As EventArgs) Handles btbHoanThanh.Click
        Dim DuongDanFolder = XDocument.Load(My.Application.Info.DirectoryPath & "\setup.xml")


        Dim writer As New XmlTextWriter(DuongDanFolder.<setup>.<SaveFolder>.Value & "\" & txtOrder.Text & "_" & txtTenBanVe.Text & "_" & Mid(txtThoiHan.Text, 1, 2) & "_" & Mid(txtThoiHan.Text, 4, 2) & "_" & Mid(txtThoiHan.Text, 7, 4) & ".xml", System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Information")
        Dim staff As String
        staff = FrmNhapMaVach.TextBox1.Text
        createNode(Date.Today, staff, txtOrder.Text, txtTenBanVe.Text, txtTenSanPham.Text, txtSoLuong.Text, txtThoiHan.Text, txtKichThuoc1.Text, txtKichThuoc2.Text, txtKichThuoc3.Text, txtKichThuoc4.Text, txtKichThuoc5.Text, txtKichThuoc6.Text, txtKichThuoc7.Text, txtKichThuoc8.Text, txtKichThuoc9.Text, txtKichThuoc10.Text, txtKichThuoc11.Text, txtKichThuoc12.Text, txtKichThuoc13.Text, writer)
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()



    End Sub

    Private Sub txtKichThuoc1_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc1.TextChanged
        If IsNumeric(lbn1.Text) = True Then
            If IsNumeric(txtKichThuoc1.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai1.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn1.Text) + Val(Mid(lbnDungSai1.Text, 2, 4)))
            dungsai2 = Val(Val(lbn1.Text) - Val(Mid(lbnDungSai1.Text, 2, 4)))
        End If
        If Mid(lbnDungSai1.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn1.Text) + Val(Mid(lbnDungSai1.Text, 2, 4)))
            dungsai2 = Val(lbn1.Text)
        End If
        If Mid(lbnDungSai1.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn1.Text)
            dungsai2 = Val(Val(lbn1.Text) - Val(Mid(lbnDungSai1.Text, 2, 4)))
        End If
        If IsNumeric(lbn1.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc1.Text) And Val(txtKichThuoc1.Text) <= dungsai1 Then
                CheckBox1.Text = ""
                CheckBox1.Text = "OK"
                CheckBox1.Checked = True
                CheckBox1.BackColor = Color.Green
            Else
                CheckBox1.Checked = False
                CheckBox1.Text = "NG"
                CheckBox1.BackColor = Color.Red

            End If
        End If

    End Sub
    Private Sub txtKichThuoc2_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc2.TextChanged
        If IsNumeric(lbn2.Text) = True Then
            If IsNumeric(txtKichThuoc2.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai2.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn2.Text) + Val(Mid(lbnDungSai2.Text, 2, 4)))
            dungsai2 = Val(Val(lbn2.Text) - Val(Mid(lbnDungSai2.Text, 2, 4)))
        End If
        If Mid(lbnDungSai2.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn2.Text) + Val(Mid(lbnDungSai2.Text, 2, 4)))
            dungsai2 = Val(lbn2.Text)
        End If
        If Mid(lbnDungSai2.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn2.Text)
            dungsai2 = Val(Val(lbn2.Text) - Val(Mid(lbnDungSai2.Text, 2, 4)))
        End If
        If IsNumeric(lbn2.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc2.Text) And Val(txtKichThuoc2.Text) <= dungsai1 Then
                CheckBox2.Text = ""
                CheckBox2.Text = "OK"
                CheckBox2.Checked = True
                CheckBox2.BackColor = Color.Green
            Else
                CheckBox2.Checked = False
                CheckBox2.Text = "NG"
                CheckBox2.BackColor = Color.Red
            End If
        End If

    End Sub

    Private Sub txtKichThuoc3_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc3.TextChanged
        If IsNumeric(lbn3.Text) = True Then
            If IsNumeric(txtKichThuoc3.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai3.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn3.Text) + Val(Mid(lbnDungSai3.Text, 2, 4)))
            dungsai2 = Val(Val(lbn3.Text) - Val(Mid(lbnDungSai3.Text, 2, 4)))
        End If
        If Mid(lbnDungSai3.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn3.Text) + Val(Mid(lbnDungSai3.Text, 2, 4)))
            dungsai2 = Val(lbn3.Text)
        End If
        If Mid(lbnDungSai3.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn3.Text)
            dungsai2 = Val(Val(lbn3.Text) - Val(Mid(lbnDungSai3.Text, 2, 4)))
        End If
        If IsNumeric(lbn3.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc3.Text) And Val(txtKichThuoc3.Text) <= dungsai1 Then
                CheckBox3.Text = ""
                CheckBox3.Text = "OK"
                CheckBox3.Checked = True
                CheckBox3.BackColor = Color.Green
            Else
                CheckBox3.Checked = False
                CheckBox3.Text = "NG"
                CheckBox3.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtKichThuoc4_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc4.TextChanged
        If IsNumeric(lbn4.Text) = True Then
            If IsNumeric(txtKichThuoc4.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai4.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn4.Text) + Val(Mid(lbnDungSai4.Text, 2, 4)))
            dungsai2 = Val(Val(lbn4.Text) - Val(Mid(lbnDungSai4.Text, 2, 4)))
        End If
        If Mid(lbnDungSai4.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn4.Text) + Val(Mid(lbnDungSai4.Text, 2, 4)))
            dungsai2 = Val(lbn4.Text)
        End If
        If Mid(lbnDungSai4.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn4.Text)
            dungsai2 = Val(Val(lbn4.Text) - Val(Mid(lbnDungSai4.Text, 2, 4)))
        End If
        If IsNumeric(lbn4.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc4.Text) And Val(txtKichThuoc4.Text) <= dungsai1 Then
                CheckBox4.Text = ""
                CheckBox4.Text = "OK"
                CheckBox4.Checked = True
                CheckBox4.BackColor = Color.Green
            Else
                CheckBox4.Checked = False
                CheckBox4.Text = "NG"
                CheckBox4.BackColor = Color.Red
            End If
        End If

    End Sub

    Private Sub txtKichThuoc5_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc5.TextChanged
        If IsNumeric(lbn5.Text) = True Then
            If IsNumeric(txtKichThuoc5.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai5.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn5.Text) + Val(Mid(lbnDungSai5.Text, 2, 4)))
            dungsai2 = Val(Val(lbn5.Text) - Val(Mid(lbnDungSai5.Text, 2, 4)))
        End If
        If Mid(lbnDungSai5.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn5.Text) + Val(Mid(lbnDungSai5.Text, 2, 4)))
            dungsai2 = Val(lbn5.Text)
        End If
        If Mid(lbnDungSai5.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn5.Text)
            dungsai2 = Val(Val(lbn5.Text) - Val(Mid(lbnDungSai5.Text, 2, 4)))
        End If
        If IsNumeric(lbn5.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc5.Text) And Val(txtKichThuoc5.Text) <= dungsai1 Then
                CheckBox5.Text = ""
                CheckBox5.Text = "OK"
                CheckBox5.Checked = True
                CheckBox5.BackColor = Color.Green
            Else
                CheckBox5.Checked = False
                CheckBox5.Text = "NG"
                CheckBox5.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtKichThuoc6_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc6.TextChanged
        If IsNumeric(lbn6.Text) = True Then
            If IsNumeric(txtKichThuoc6.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai6.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn6.Text) + Val(Mid(lbnDungSai6.Text, 2, 4)))
            dungsai2 = Val(Val(lbn6.Text) - Val(Mid(lbnDungSai6.Text, 2, 4)))
        End If
        If Mid(lbnDungSai6.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn6.Text) + Val(Mid(lbnDungSai6.Text, 2, 4)))
            dungsai2 = Val(lbn6.Text)
        End If
        If Mid(lbnDungSai6.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn6.Text)
            dungsai2 = Val(Val(lbn6.Text) - Val(Mid(lbnDungSai6.Text, 2, 4)))
        End If
        If IsNumeric(lbn6.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc6.Text) And Val(txtKichThuoc6.Text) <= dungsai1 Then
                CheckBox6.Text = ""
                CheckBox6.Text = "OK"
                CheckBox6.Checked = True
                CheckBox6.BackColor = Color.Green
            Else
                CheckBox6.Checked = False
                CheckBox6.Text = "NG"
                CheckBox6.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtKichThuoc7_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc7.TextChanged
        If IsNumeric(lbn7.Text) = True Then
            If IsNumeric(txtKichThuoc7.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai7.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn7.Text) + Val(Mid(lbnDungSai7.Text, 2, 4)))
            dungsai2 = Val(Val(lbn7.Text) - Val(Mid(lbnDungSai7.Text, 2, 4)))
        End If
        If Mid(lbnDungSai7.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn7.Text) + Val(Mid(lbnDungSai7.Text, 2, 4)))
            dungsai2 = Val(lbn7.Text)
        End If
        If Mid(lbnDungSai7.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn7.Text)
            dungsai2 = Val(Val(lbn7.Text) - Val(Mid(lbnDungSai7.Text, 2, 4)))
        End If
        If IsNumeric(lbn7.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc7.Text) And Val(txtKichThuoc7.Text) <= dungsai1 Then
                CheckBox7.Text = ""
                CheckBox7.Text = "OK"
                CheckBox7.Checked = True
                CheckBox7.BackColor = Color.Green
            Else
                CheckBox7.Checked = False
                CheckBox7.Text = "NG"
                CheckBox7.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtKichThuoc8_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc8.TextChanged
        If IsNumeric(lbn8.Text) = True Then
            If IsNumeric(txtKichThuoc8.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai8.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn8.Text) + Val(Mid(lbnDungSai8.Text, 2, 4)))
            dungsai2 = Val(Val(lbn8.Text) - Val(Mid(lbnDungSai8.Text, 2, 4)))
        End If
        If Mid(lbnDungSai8.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn8.Text) + Val(Mid(lbnDungSai8.Text, 2, 4)))
            dungsai2 = Val(lbn8.Text)
        End If
        If Mid(lbnDungSai8.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn8.Text)
            dungsai2 = Val(Val(lbn8.Text) - Val(Mid(lbnDungSai8.Text, 2, 4)))
        End If
        If IsNumeric(lbn8.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc8.Text) And Val(txtKichThuoc8.Text) <= dungsai1 Then
                CheckBox8.Text = ""
                CheckBox8.Text = "OK"
                CheckBox8.Checked = True
                CheckBox8.BackColor = Color.Green
            Else
                CheckBox8.Checked = False
                CheckBox8.Text = "NG"
                CheckBox8.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtKichThuoc9_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc9.TextChanged
        If IsNumeric(lbn9.Text) = True Then
            If IsNumeric(txtKichThuoc9.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai9.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn9.Text) + Val(Mid(lbnDungSai9.Text, 2, 4)))
            dungsai2 = Val(Val(lbn9.Text) - Val(Mid(lbnDungSai9.Text, 2, 4)))
        End If
        If Mid(lbnDungSai9.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn9.Text) + Val(Mid(lbnDungSai9.Text, 2, 4)))
            dungsai2 = Val(lbn9.Text)
        End If
        If Mid(lbnDungSai9.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn9.Text)
            dungsai2 = Val(Val(lbn9.Text) - Val(Mid(lbnDungSai9.Text, 2, 4)))
        End If
        If IsNumeric(lbn9.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc9.Text) And Val(txtKichThuoc9.Text) <= dungsai1 Then
                CheckBox9.Text = ""
                CheckBox9.Text = "OK"
                CheckBox9.Checked = True
                CheckBox9.BackColor = Color.Green
            Else
                CheckBox9.Checked = False
                CheckBox9.Text = "NG"
                CheckBox9.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtKichThuoc10_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc10.TextChanged
        If IsNumeric(lbn10.Text) = True Then
            If IsNumeric(txtKichThuoc10.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai10.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn10.Text) + Val(Mid(lbnDungSai10.Text, 2, 4)))
            dungsai2 = Val(Val(lbn10.Text) - Val(Mid(lbnDungSai10.Text, 2, 4)))
        End If
        If Mid(lbnDungSai10.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn10.Text) + Val(Mid(lbnDungSai10.Text, 2, 4)))
            dungsai2 = Val(lbn10.Text)
        End If
        If Mid(lbnDungSai10.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn10.Text)
            dungsai2 = Val(Val(lbn10.Text) - Val(Mid(lbnDungSai10.Text, 2, 4)))
        End If
        If IsNumeric(lbn10.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc10.Text) And Val(txtKichThuoc10.Text) <= dungsai1 Then
                CheckBox10.Text = ""
                CheckBox10.Text = "OK"
                CheckBox10.Checked = True
                CheckBox10.BackColor = Color.Green
            Else
                CheckBox10.Checked = False
                CheckBox10.Text = "NG"
                CheckBox10.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtKichThuoc11_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc11.TextChanged
        If IsNumeric(lbn11.Text) = True Then
            If IsNumeric(txtKichThuoc11.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai11.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn11.Text) + Val(Mid(lbnDungSai11.Text, 2, 4)))
            dungsai2 = Val(Val(lbn11.Text) - Val(Mid(lbnDungSai11.Text, 2, 4)))
        End If
        If Mid(lbnDungSai11.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn11.Text) + Val(Mid(lbnDungSai11.Text, 2, 4)))
            dungsai2 = Val(lbn11.Text)
        End If
        If Mid(lbnDungSai11.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn11.Text)
            dungsai2 = Val(Val(lbn11.Text) - Val(Mid(lbnDungSai11.Text, 2, 4)))
        End If
        If IsNumeric(lbn11.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc11.Text) And Val(txtKichThuoc11.Text) <= dungsai1 Then
                CheckBox11.Text = ""
                CheckBox11.Text = "OK"
                CheckBox11.Checked = True
                CheckBox11.BackColor = Color.Green
            Else
                CheckBox11.Checked = False
                CheckBox11.Text = "NG"
                CheckBox11.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtKichThuoc12_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc12.TextChanged
        If IsNumeric(lbn12.Text) = True Then
            If IsNumeric(txtKichThuoc12.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai12.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn12.Text) + Val(Mid(lbnDungSai12.Text, 2, 4)))
            dungsai2 = Val(Val(lbn12.Text) - Val(Mid(lbnDungSai12.Text, 2, 4)))
        End If
        If Mid(lbnDungSai12.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn12.Text) + Val(Mid(lbnDungSai12.Text, 2, 4)))
            dungsai2 = Val(lbn12.Text)
        End If
        If Mid(lbnDungSai12.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn12.Text)
            dungsai2 = Val(Val(lbn12.Text) - Val(Mid(lbnDungSai12.Text, 2, 4)))
        End If
        If IsNumeric(lbn12.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc12.Text) And Val(txtKichThuoc12.Text) <= dungsai1 Then
                CheckBox12.Text = ""
                CheckBox12.Text = "OK"
                CheckBox12.Checked = True
                CheckBox12.BackColor = Color.Green
            Else
                CheckBox12.Checked = False
                CheckBox12.Text = "NG"
                CheckBox12.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtKichThuoc13_TextChanged(sender As Object, e As EventArgs) Handles txtKichThuoc13.TextChanged
        If IsNumeric(lbn13.Text) = True Then
            If IsNumeric(txtKichThuoc13.Text) = False Then
                MsgBox("記入した情報を確認してください")
            End If
        End If
        Dim dungsai1 As Double
        Dim dungsai2 As Double
        If Mid(lbnDungSai13.Text, 1, 1) = "±" Then
            dungsai1 = Val(Val(lbn13.Text) + Val(Mid(lbnDungSai13.Text, 2, 4)))
            dungsai2 = Val(Val(lbn13.Text) - Val(Mid(lbnDungSai13.Text, 2, 4)))
        End If
        If Mid(lbnDungSai13.Text, 1, 1) = "+" Then
            dungsai1 = Val(Val(lbn13.Text) + Val(Mid(lbnDungSai13.Text, 2, 4)))
            dungsai2 = Val(lbn13.Text)
        End If
        If Mid(lbnDungSai13.Text, 1, 1) = "-" Then
            dungsai1 = Val(lbn13.Text)
            dungsai2 = Val(Val(lbn13.Text) - Val(Mid(lbnDungSai13.Text, 2, 4)))
        End If
        If IsNumeric(lbn13.Text) = True Then
            If dungsai2 <= Val(txtKichThuoc13.Text) And Val(txtKichThuoc13.Text) <= dungsai1 Then
                CheckBox13.Text = ""
                CheckBox13.Text = "OK"
                CheckBox13.Checked = True
                CheckBox13.BackColor = Color.Green
            Else
                CheckBox13.Checked = False
                CheckBox13.Text = "NG"
                CheckBox13.BackColor = Color.Red
            End If
        End If
    End Sub
    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        CheckBox1.Text = "OK"
        CheckBox1.BackColor = Color.Green
    End Sub
    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        CheckBox2.Text = "OK"
        CheckBox2.BackColor = Color.Green
    End Sub
    Private Sub CheckBox3_Click(sender As Object, e As EventArgs) Handles CheckBox3.Click
        CheckBox3.Text = "OK"
        CheckBox3.BackColor = Color.Green
    End Sub
    Private Sub CheckBox4_Click(sender As Object, e As EventArgs) Handles CheckBox4.Click
        CheckBox4.Text = "OK"
        CheckBox4.BackColor = Color.Green
    End Sub
    Private Sub CheckBox5_Click(sender As Object, e As EventArgs) Handles CheckBox5.Click
        CheckBox5.Text = "OK"
        CheckBox5.BackColor = Color.Green
    End Sub
    Private Sub CheckBox6_Click(sender As Object, e As EventArgs) Handles CheckBox6.Click
        CheckBox6.Text = "OK"
        CheckBox6.BackColor = Color.Green
    End Sub
    Private Sub CheckBox7_Click(sender As Object, e As EventArgs) Handles CheckBox7.Click
        CheckBox7.Text = "OK"
        CheckBox7.BackColor = Color.Green
    End Sub
    Private Sub CheckBox8_Click(sender As Object, e As EventArgs) Handles CheckBox8.Click
        CheckBox8.Text = "OK"
        CheckBox8.BackColor = Color.Green
    End Sub
    Private Sub CheckBox9_Click(sender As Object, e As EventArgs) Handles CheckBox9.Click
        CheckBox9.Text = "OK"
        CheckBox9.BackColor = Color.Green
    End Sub
    Private Sub CheckBox10_Click(sender As Object, e As EventArgs) Handles CheckBox10.Click
        CheckBox10.Text = "OK"
        CheckBox10.BackColor = Color.Green
    End Sub
    Private Sub CheckBox11_Click(sender As Object, e As EventArgs) Handles CheckBox11.Click
        CheckBox11.Text = "OK"
        CheckBox11.BackColor = Color.Green
    End Sub
    Private Sub CheckBox12_Click(sender As Object, e As EventArgs) Handles CheckBox12.Click
        CheckBox12.Text = "OK"
        CheckBox12.BackColor = Color.Green
    End Sub
    Private Sub CheckBox13_Click(sender As Object, e As EventArgs) Handles CheckBox13.Click
        CheckBox13.Text = "OK"
        CheckBox13.BackColor = Color.Green
    End Sub

    Private Sub btnInKetQua_Click(sender As Object, e As EventArgs) Handles btnInKetQua.Click
        FrmLoadData.MdiParent = FrmManHinhChinh
        FrmLoadData.Show()
        FrmLoadData.Activate()


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        
    End Sub
End Class