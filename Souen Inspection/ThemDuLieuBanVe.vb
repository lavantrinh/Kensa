Imports System.Xml
Public Class ThemDuLieuBanVe
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
    Private Sub CreatNode(ByVal pKichthuoc1 As String, ByVal pKichThuoc2 As String, ByVal pKichThuoc3 As String, pKichThuoc4 As String, ByVal pKichThuoc5 As String, ByVal pKichThuoc6 As String, ByVal pKichThuoc7 As String, ByVal pKichThuoc8 As String, ByVal pKichThuoc9 As String, ByVal pKichThuoc10 As String, ByVal pKichThuoc11 As String, ByVal pKichThuoc12 As String, ByVal pKichThuoc13 As String,
                          ByVal pDungSai1 As String, ByVal pDungSai2 As String, ByVal pDungSai3 As String, ByVal pDungSai4 As String, ByVal pDungSai5 As String, ByVal pDungSai6 As String, ByVal pDungsai7 As String, ByVal pDungSai8 As String, ByVal pDungSai9 As String, ByVal pDungSai10 As String, ByVal pDungSai11 As String, ByVal pDungSai12 As String, ByVal pDungSai13 As String,
                          ByVal pDungCu1 As String, ByVal pDungCu2 As String, ByVal pDungCu3 As String, ByVal pDungCu4 As String, ByVal pDungCu5 As String, ByVal pDungCu6 As String, ByVal pDungCu7 As String, ByVal pDungCu8 As String, ByVal pDungCu9 As String, ByVal pDungCu10 As String, ByVal pDungCu11 As String, ByVal pDungCu12 As String, ByVal pDungCu13 As String,
                          ByVal pNote As String, ByVal pDrawing_Filename As String,
                          ByVal writer As XmlTextWriter)

        writer.WriteStartElement("dimension")
        writer.WriteStartElement("d1")
        writer.WriteString(pKichthuoc1)
        writer.WriteEndElement()
        writer.WriteStartElement("d2")
        writer.WriteString(pKichThuoc2)
        writer.WriteEndElement()
        writer.WriteStartElement("d3")
        writer.WriteString(pKichThuoc3)
        writer.WriteEndElement()
        writer.WriteStartElement("d4")
        writer.WriteString(pKichThuoc4)
        writer.WriteEndElement()
        writer.WriteStartElement("d5")
        writer.WriteString(pKichThuoc5)
        writer.WriteEndElement()
        writer.WriteStartElement("d6")
        writer.WriteString(pKichThuoc6)
        writer.WriteEndElement()
        writer.WriteStartElement("d7")
        writer.WriteString(pKichThuoc7)
        writer.WriteEndElement()
        writer.WriteStartElement("d8")
        writer.WriteString(pKichThuoc8)
        writer.WriteEndElement()
        writer.WriteStartElement("d9")
        writer.WriteString(pKichThuoc9)
        writer.WriteEndElement()
        writer.WriteStartElement("d10")
        writer.WriteString(pKichThuoc10)
        writer.WriteEndElement()
        writer.WriteStartElement("d11")
        writer.WriteString(pKichThuoc11)
        writer.WriteEndElement()
        writer.WriteStartElement("d12")
        writer.WriteString(pKichThuoc12)
        writer.WriteEndElement()
        writer.WriteStartElement("d13")
        writer.WriteString(pKichThuoc13)
        writer.WriteEndElement()
        writer.WriteEndElement()

        writer.WriteStartElement("tolerance")
        writer.WriteStartElement("t1")
        writer.WriteString(pDungSai1)
        writer.WriteEndElement()
        writer.WriteStartElement("t2")
        writer.WriteString(pDungSai2)
        writer.WriteEndElement()
        writer.WriteStartElement("t3")
        writer.WriteString(pDungSai3)
        writer.WriteEndElement()
        writer.WriteStartElement("t4")
        writer.WriteString(pDungSai4)
        writer.WriteEndElement()
        writer.WriteStartElement("t5")
        writer.WriteString(pDungSai5)
        writer.WriteEndElement()
        writer.WriteStartElement("t6")
        writer.WriteString(pDungSai6)
        writer.WriteEndElement()
        writer.WriteStartElement("t7")
        writer.WriteString(pDungsai7)
        writer.WriteEndElement()
        writer.WriteStartElement("t8")
        writer.WriteString(pDungSai8)
        writer.WriteEndElement()
        writer.WriteStartElement("t9")
        writer.WriteString(pDungSai9)
        writer.WriteEndElement()
        writer.WriteStartElement("t10")
        writer.WriteString(pDungSai10)
        writer.WriteEndElement()
        writer.WriteStartElement("t11")
        writer.WriteString(pDungSai11)
        writer.WriteEndElement()
        writer.WriteStartElement("t12")
        writer.WriteString(pDungSai12)
        writer.WriteEndElement()
        writer.WriteStartElement("t13")
        writer.WriteString(pDungSai13)
        writer.WriteEndElement()
        writer.WriteEndElement()

        writer.WriteStartElement("equipment")
        writer.WriteStartElement("e1")
        writer.WriteString(pDungCu1)
        writer.WriteEndElement()
        writer.WriteStartElement("e2")
        writer.WriteString(pDungCu2)
        writer.WriteEndElement()
        writer.WriteStartElement("e3")
        writer.WriteString(pDungCu3)
        writer.WriteEndElement()
        writer.WriteStartElement("e4")
        writer.WriteString(pDungCu4)
        writer.WriteEndElement()
        writer.WriteStartElement("e5")
        writer.WriteString(pDungCu5)
        writer.WriteEndElement()
        writer.WriteStartElement("e6")
        writer.WriteString(pDungCu6)
        writer.WriteEndElement()
        writer.WriteStartElement("e7")
        writer.WriteString(pDungCu7)
        writer.WriteEndElement()
        writer.WriteStartElement("e8")
        writer.WriteString(pDungCu8)
        writer.WriteEndElement()
        writer.WriteStartElement("e9")
        writer.WriteString(pDungCu9)
        writer.WriteEndElement()
        writer.WriteStartElement("e10")
        writer.WriteString(pDungCu10)
        writer.WriteEndElement()
        writer.WriteStartElement("e11")
        writer.WriteString(pDungCu11)
        writer.WriteEndElement()
        writer.WriteStartElement("e12")
        writer.WriteString(pDungCu12)
        writer.WriteEndElement()
        writer.WriteStartElement("e13")
        writer.WriteString(pDungCu13)
        writer.WriteEndElement()
        writer.WriteEndElement()

        writer.WriteStartElement("note")
        writer.WriteString(pNote)
        writer.WriteEndElement()


        writer.WriteStartElement("Drawing_Filename")
        writer.WriteString(pDrawing_Filename)
        writer.WriteEndElement()



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim DuongDanFolder = XDocument.Load(My.Application.Info.DirectoryPath & "\setup.xml")
        Dim writer As New XmlTextWriter(DuongDanFolder.<setup>.<SaveFolder>.Value & "\" & txtBanVe.Text & ".xml", System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Information")
        CreatNode(txtNhapKichThuoc1.Text, txtNhapKichThuoc2.Text, txtNhapKichThuoc3.Text, txtNhapKichThuoc4.Text, txtNhapKichThuoc5.Text, txtNhapKichThuoc6.Text, txtNhapKichThuoc7.Text, txtNhapKichThuoc8.Text, txtNhapKichThuoc9.Text, txtNhapKichThuoc10.Text, txtNhapKichThuoc11.Text, txtNhapKichThuoc12.Text, txtNhapKichThuoc13.Text, txtNhapDungSai1.Text, txtNhapDungSai2.Text, txtNhapDungSai3.Text, txtNhapDungSai4.Text, txtNhapDungSai5.Text, txtNhapDungSai6.Text, txtNhapDungSai7.Text, txtNhapDungSai8.Text, txtNhapDungSai9.Text, txtNhapDungSai10.Text, txtNhapDungSai11.Text, txtNhapDungSai12.Text, txtNhapDungSai13.Text, cbbDungCu1.SelectedText, cbbDungCu2.SelectedText, cbbDungCu3.SelectedText, cbbDungCu4.SelectedText, cbbDungCu5.SelectedText, cbbDungCu6.SelectedText, cbbDungCu7.SelectedText, cbbDungCu8.SelectedText, cbbDungCu9.SelectedText, cbbDungCu10.SelectedText, cbbDungCu11.SelectedText, cbbDungCu12.SelectedText, cbbDungCu13.SelectedText, RichTextBox1.Text, txtTenFileBanVe.Text, writer)
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()

        txtBanVe.Text = ""
        txtTenFileBanVe.Text = ""
        txtNhapKichThuoc1.Text = ""
        txtNhapKichThuoc2.Text = ""
        txtNhapKichThuoc3.Text = ""
        txtNhapKichThuoc4.Text = ""
        txtNhapKichThuoc5.Text = ""
        txtNhapKichThuoc6.Text = ""
        txtNhapKichThuoc7.Text = ""
        txtNhapKichThuoc8.Text = ""
        txtNhapKichThuoc9.Text = ""
        txtNhapKichThuoc10.Text = ""
        txtNhapKichThuoc11.Text = ""
        txtNhapKichThuoc12.Text = ""
        txtNhapKichThuoc13.Text = ""

        txtNhapDungSai1.Text = ""
        txtNhapDungSai2.Text = ""
        txtNhapDungSai3.Text = ""
        txtNhapDungSai4.Text = ""
        txtNhapDungSai5.Text = ""
        txtNhapDungSai6.Text = ""
        txtNhapDungSai7.Text = ""
        txtNhapDungSai8.Text = ""
        txtNhapDungSai9.Text = ""
        txtNhapKichThuoc10.Text = ""
        txtNhapKichThuoc11.Text = ""
        txtNhapKichThuoc12.Text = ""
        txtNhapKichThuoc13.Text = ""

        cbbDungCu1.ResetText()
        cbbDungCu2.ResetText()
        cbbDungCu3.ResetText()
        cbbDungCu4.ResetText()
        cbbDungCu5.ResetText()
        cbbDungCu6.ResetText()
        cbbDungCu7.ResetText()
        cbbDungCu8.ResetText()
        cbbDungCu9.ResetText()
        cbbDungCu10.ResetText()
        cbbDungCu11.ResetText()
        cbbDungCu12.ResetText()
        cbbDungCu13.ResetText()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtBanVe.Text = ""
        txtTenFileBanVe.Text = ""
        txtNhapKichThuoc1.Text = ""
        txtNhapKichThuoc2.Text = ""
        txtNhapKichThuoc3.Text = ""
        txtNhapKichThuoc4.Text = ""
        txtNhapKichThuoc5.Text = ""
        txtNhapKichThuoc6.Text = ""
        txtNhapKichThuoc7.Text = ""
        txtNhapKichThuoc8.Text = ""
        txtNhapKichThuoc9.Text = ""
        txtNhapKichThuoc10.Text = ""
        txtNhapKichThuoc11.Text = ""
        txtNhapKichThuoc12.Text = ""
        txtNhapKichThuoc13.Text = ""

        txtNhapDungSai1.Text = ""
        txtNhapDungSai2.Text = ""
        txtNhapDungSai3.Text = ""
        txtNhapDungSai4.Text = ""
        txtNhapDungSai5.Text = ""
        txtNhapDungSai6.Text = ""
        txtNhapDungSai7.Text = ""
        txtNhapDungSai8.Text = ""
        txtNhapDungSai9.Text = ""
        txtNhapKichThuoc10.Text = ""
        txtNhapKichThuoc11.Text = ""
        txtNhapKichThuoc12.Text = ""
        txtNhapKichThuoc13.Text = ""

        cbbDungCu1.ResetText()
        cbbDungCu2.ResetText()
        cbbDungCu3.ResetText()
        cbbDungCu4.ResetText()
        cbbDungCu5.ResetText()
        cbbDungCu6.ResetText()
        cbbDungCu7.ResetText()
        cbbDungCu8.ResetText()
        cbbDungCu9.ResetText()
        cbbDungCu10.ResetText()
        cbbDungCu11.ResetText()
        cbbDungCu12.ResetText()
        cbbDungCu13.ResetText()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtNhapDungSai1.Focus Then
            txtNhapDungSai1.Text = txtNhapDungSai1.Text + "±"

        End If
    End Sub

    Private Sub ThemDuLieuBanVe_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class