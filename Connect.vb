Public Class Connect
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim <> "" And TextBox2.Text.Trim <> "" Then
            Dim xcom = " connect "
            If Button1.Text = "Connect" Then
                xcom = " connect "
            Else
                xcom = " disconnect "
            End If
            Dim r = Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + xcom + TextBox1.Text + ":" + TextBox2.Text, xcmd, xmt).ToString.Trim
            If r = "" Then
                r = "Done!"
            End If
            MsgBox(r, MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub
    Dim xmmtt As String
    Dim xcmd As String
    Dim xmt As String
    Private Sub Connect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class