﻿Public Class Lite
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo g
        If CInt(ComboBox1.Text) > 0 And CInt(ComboBox1.Text) <= 256 Then
            Filez.pnglite(Filez.pl, CInt(ComboBox1.Text))
        Else
            ComboBox1.Text = "256"
        End If
        Exit Sub
g:      ComboBox1.Text = "256"
    End Sub
    Private Sub Lite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ComboBox2.Text.Trim = "" Then
            ComboBox2.SelectedIndex = 0
        End If
        If CInt(ComboBox1.Text) = False Then
            ComboBox1.Text = "256"
        Else
            If (CInt(ComboBox1.Text) > 256 Or CInt(ComboBox1.Text) <= 0) Then
                ComboBox1.Text = "256"
            End If
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox2.Text = "0"
        Filez.ogglite(Filez.pl, CInt(ComboBox2.Text))
    End Sub
End Class