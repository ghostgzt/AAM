﻿Public Class Run
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim zl = TextBox1.Text
        Dim ma = TextBox2.Text
        If zl.ToString.Trim <> "" And ma.ToString.Trim <> "" Then
            Dim r = Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell am start -n " + zl + "/" + ma, xcmd, xmt).ToString.Trim
            If r = "" Then
                r = "Done!"
            End If
            MsgBox(r, MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox("Not Activity To Run!!!", MsgBoxStyle.Information)
        End If
    End Sub
    Dim xmmtt As String
    Dim xcmd As String
    Dim xmt As String
    Dim mlh As String
    Private Sub Run_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        mlh = Main.mlh
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class