﻿Public Class Ftp
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        If TextBox1.Text.Trim <> "" And TextBox2.Text.Trim <> "" And TextBox3.Text.Trim <> "" And TextBox4.Text.Trim <> "" Then
            Shell("explorer " + "ftp://" + TextBox4.Text + ":" + TextBox3.Text + "@" + TextBox1.Text + ":" + TextBox2.Text, 1, False)
            Me.Close()
        Else
            If TextBox1.Text.Trim <> "" And TextBox2.Text.Trim <> "" Then
                Shell("explorer " + "ftp://" + TextBox1.Text + ":" + TextBox2.Text, 1, False)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class