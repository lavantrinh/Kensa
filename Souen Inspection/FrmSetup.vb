Imports System.IO
Imports System.Xml
Public Class FrmSetup
    Public i As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If

    End Sub

    Private Sub FrmSetup_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim DuongDanFolder = XDocument.Load(My.Application.Info.DirectoryPath & "\setup.xml")
        TextBox1.Text = DuongDanFolder.<setup>.<DrawingFolder>.Value
        TextBox2.Text = DuongDanFolder.<setup>.<PictureFolder>.Value
        TextBox3.Text = DuongDanFolder.<setup>.<SaveFolder>.Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click, Button6.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox3.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyXML As New XmlDocument()
        MyXML.Load(My.Application.Info.DirectoryPath & "\setup.xml")
        Dim DuongDanBanVeLNode1 As XmlNode = MyXML.SelectSingleNode("/setup/DrawingFolder")
        Dim DuongDanAnhSanPHamNode2 As XmlNode = MyXML.SelectSingleNode("/setup/PictureFolder")
        Dim DuongDanSave As XmlNode = MyXML.SelectSingleNode("/setup/SaveFolder")
        'luu duong dan moi
        DuongDanBanVeLNode1.ChildNodes(0).InnerText = TextBox1.Text
        DuongDanAnhSanPHamNode2.ChildNodes(0).InnerText = TextBox2.Text
        DuongDanSave.ChildNodes(0).InnerText = TextBox3.Text
        MyXML.Save(My.Application.Info.DirectoryPath & "\setup.xml")
        Me.Hide()
    End Sub
End Class