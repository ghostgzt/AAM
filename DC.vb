Public Class DC
    Dim xmmtt As String
    Dim xcmd As String
    Dim xmt As String
    Private Sub DC_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
    End Sub
    Private Sub DC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
        'Start.ShowDialog()
        getstate()
        'ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        'ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        Timer1.Enabled = True
    End Sub
    Function getstate()
        On Error Resume Next
        ListView1.Items.Clear()
        Main.state()
        Dim dfs = Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " devices", xcmd, xmt).ToString.Replace("List of devices attached", "").Split(vbLf)
        For x = 0 To dfs.longlength - 1
            If dfs(x).Trim <> "" Then
                Dim i = ListView1.Items.Add(dfs(x).Substring(0, dfs(x).Length - 8).Trim, 0)
                i.SubItems.Add(dfs(x).Substring(dfs(x).Length - 8, 7).Trim)
            End If
        Next
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListView1.Items.Count <> 0 Then
            If ListView1.SelectedIndices.Count <> 0 Then
                Main.mlh = "-s " + My.Resources.x1 + ListView1.SelectedItems(0).Text + My.Resources.x1
                Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + Main.mlh + " root", 0, True)
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                ListView1.SelectedIndices.Add(0)
            End If
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        getstate()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        Button3_Click(Nothing, Nothing)
    End Sub
    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Connect.Button1.Text = "Connect"
        Connect.ShowDialog()
        getstate()
    End Sub
    Private Sub ADBWirelessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADBWirelessToolStripMenuItem.Click
        If Main.state().ToString.Trim = "device" Then
            Install.ListView1.Items.Clear()
            Main.addxapk(My.Application.Info.DirectoryPath + "\Tools\ADBWL.apk")
            Me.Hide()
            Install.ShowDialog()
            Me.Show()
        Else
            Main.mlh = ""
            MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Connect.Button1.Text = "Disconnect"
        Connect.ShowDialog()
        getstate()
    End Sub
    Private Sub AVDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AVDToolStripMenuItem.Click
        On Error Resume Next
        If My.Computer.FileSystem.FileExists(Main.avd) = False Then
            MsgBox("Please Choose the path of Android Virtual Device Manager!", MsgBoxStyle.Information)
            With New OpenFileDialog
                .FileName = "AVD Manager.exe"
                .Filter = "AVD Manager.exe|AVD Manager.exe"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Main.avd = .FileName
                    My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx")
                    My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx\Apk_Manager")
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Manager", "AVD", Main.avd)
                Else
                    MsgBox("AVD Not Found!!!", MsgBoxStyle.Information)
                End If
            End With
        Else
            Shell(My.Resources.x1 + Main.avd + My.Resources.x1, 1, False)
        End If
    End Sub
    Private Sub FtpModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FtpModeToolStripMenuItem.Click
        Ftp.ShowDialog()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Dim xds As Integer
        xds = -1
        If ListView1.SelectedItems.Count <> 0 Then
            xds = ListView1.SelectedIndices(0)
        End If
        Button2_Click(Nothing, Nothing)
        If xds <> -1 Then
            ListView1.SelectedIndices.Add(xds)
        End If
    End Sub
    Private Sub ADBModToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADBModToolStripMenuItem.Click
        ChDir(My.Application.Info.DirectoryPath + "\Tools")
        Shell("cmd -k" + " " + My.Resources.x1 + Main.adb + My.Resources.x1, 1, False)
        ChDir(My.Application.Info.DirectoryPath)
    End Sub
End Class