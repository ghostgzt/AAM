﻿Public Class FileD
    Dim filetmp As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\FileTmp\"
    Function getkz(ByVal kzx As String)
        Dim kz = 1
        Dim hc = Main.getlast(kzx.Split(".")).ToLower.Trim
        If hc = "xml" Then
            kz = 2
        Else
            If hc = "png" Or hc = "jpg" Or hc = "bmp" Or hc = "gif" Or hc = "jpeg" Then
                kz = 3
            Else
                If hc = "mp3" Or hc = "wav" Or hc = "ogg" Then
                    kz = 4
                Else
                    If hc = "txt" Or hc = "rc" Or hc = "sh" Or hc = "prop" Or hc = "conf" Or hc = "kl" Then
                        kz = 5
                    Else
                        If hc = "html" Or hc = "htm" Or hc = "mht" Then
                            kz = 6
                        Else
                            If hc = "apk" Then
                                kz = 8
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Return kz
    End Function
    Dim xmmtt As String
    Dim xcmd As String
    Dim xmt As String
    Function getone(ByVal path As String)
        'On Error Resume Next
        path = My.Resources.x1 + path + My.Resources.x1
        'My.Computer.FileSystem.WriteAllText("C:\123.txt", convert_UTF8(".") + ".tmd", False, System.Text.Encoding.UTF8)
        'Shell(My.Resources.x1 + Main.utf8 + My.Resources.x1 + " " + My.Resources.x1 + tcmd + My.Resources.x1, 0, True)
        'My.Computer.FileSystem.WriteAllText(tcmd, My.Computer.FileSystem.ReadAllText(tcmd, System.Text.Encoding.Default).Replace("?", ""), False, System.Text.Encoding.Default)
        'MsgBox(My.Computer.FileSystem.ReadAllText(tcmd, System.Text.Encoding.Default))
        Dim tcmd = xcmd
        Dim tmt = xmt
        My.Computer.FileSystem.WriteAllText(tcmd, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell ls -a " + path + " >" + My.Resources.x1 + tmt + My.Resources.x1, False, System.Text.Encoding.Default)
        Shell(tcmd, 0, True)
        Dim tx As String = My.Computer.FileSystem.ReadAllText(tmt)
        'Kill(tcmd)
        'Kill(tmt)
        'MsgBox(tx)
        Return tx
    End Function
    Dim ccof
    Dim cpath
    Dim cst
    Dim ox As New ListBox
    Dim tpn As Integer
    Function add(ByVal path As String, ByVal cof As Integer)
        On Error Resume Next
        dx = ""
        Dim tx = getone(path).ToString
        If cof = 0 Then
            TreeView1.TopNode.Nodes.Clear()
        Else
            TreeView1.SelectedNode.Nodes.Clear()
        End If
        tx = tx.Replace("       ", "  ")
        tx = tx.Replace("      ", "  ")
        tx = tx.Replace("     ", "  ")
        tx = tx.Replace("    ", "  ")
        tx = tx.Replace("   ", "  ")
        tx = tx.Replace("  ", vbCrLf)
        'tx = tx.ToString.Replace(vbCr, "")
        tx = tx.ToString.Replace(vbCrLf + vbCrLf + vbCrLf, vbCrLf)
        tx = tx.ToString.Replace(vbCrLf + vbCrLf, vbCrLf)
        'MsgBox(tx)
        'MsgBox(path)
        'Shell(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " kill-server", 0, True)
        'Shell(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " start-server", 0, True)
        Dim st = tx + vbCrLf
        'Dim xx = st.ToString.Split(vbCrLf)
        TreeView1.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        ccof = cof
        cpath = path
        cst = st
        xxx = 0
        Main.NotifyIcon1.Icon = Me.Icon
        ox.Items.Clear()
        Timer1.Enabled = True
        tpn = TreeView1.TopNode.Nodes.Count
        BackgroundWorker1.RunWorkerAsync()
        'With New NotifyIcon
        '    .Icon = Me.Icon
        '    For x = 0 To xx.Count - 1
        '        Dim qx = xx(x).Trim.Replace(vbCrLf, "")
        '        If qx <> "" Then
        '            If ("Scaning " + qx.ToString).Length > 64 Then
        '                .Text = "Scaning " + qx.ToString.Trim.Remove(51) + "..."
        '            Else
        '                .Text = "Scaning " + qx.ToString.Trim
        '            End If
        '            .BalloonTipText = "Scaning " + qx.ToString
        '            .BalloonTipIcon = ToolTipIcon.Info
        '            .BalloonTipTitle = "Andorid Explorer"
        '            .ShowBalloonTip(500)
        '            'MsgBox(bx) 
        '            Dim bx = getone(path + "/" + qx).ToString.Trim
        '            If bx <> "" And bx <> path + "/" + qx.Trim Then
        '                If cof = 0 Then
        '                    TreeView1.TopNode.Nodes.Add("Dir", qx, 0)
        '                Else
        '                    If bx.Trim.Replace("No such file or directory", "").Length = bx.Trim.Length And bx.Trim.Replace("Syntax error:", "").Length = bx.Trim.Length Then
        '                        'MsgBox(qx)
        '                        TreeView1.SelectedNode.Nodes.Add("Dir", qx, 0)
        '                    Else
        '                        'MsgBox(Main.getPY(qx))
        '                        TreeView1.SelectedNode.Nodes.Add("xFile", qx, 7)
        '                    End If
        '                End If
        '            Else
        '                If bx = path + "/" + qx.Trim Then
        '                    If cof = 0 Then
        '                        TreeView1.TopNode.Nodes.Add("File", qx, 1)
        '                    Else
        '                        TreeView1.SelectedNode.Nodes.Add("File", qx, getkz(qx))
        '                    End If
        '                Else
        '                    If bx = "" Then
        '                        If cof = 0 Then
        '                            TreeView1.TopNode.Nodes.Add("Kdir", qx, 9)
        '                        Else
        '                            TreeView1.SelectedNode.Nodes.Add("Kdir", qx, 9)
        '                        End If
        '                    Else
        '                        MsgBox(qx)
        '                    End If
        '                End If
        '            End If
        '        End If
        '    Next
        '    .Icon = Nothing
        'End With
        'If cof = 0 Then
        '    TreeView1.TopNode.Expand()
        'Else
        '    TreeView1.SelectedNode.Expand()
        'End If
        'Kill(tcmd)
        'Kill(tmt)
        'For x = 0 To tx.Length - 1
        '    If Mid(st, x + 1, 2) = vbCrLf Then
        '        Dim z = x - y
        '        MsgBox(x)
        '        'MsgBox(y)
        '        'MsgBox(z)
        '        'MsgBox(st.Substring(y, z))
        '        'xt = st.Remove(x).Remove(0, y).Replace(vbCrLf, "")
        '        'MsgBox(xt.Split(vbCrLf)(0))
        '        'MsgBox(st.Remove(x).Remove(0, y).Replace(vbCrLf, ""))
        '        'If getone(path + "/" + xt.Split(vbCrLf)(0).Trim.Split(" ")(0)).ToString.Trim <> "" Then
        '        '    MsgBox(xt.Split(vbCrLf)(0).Trim.Split(" ")(0))
        '        'Else
        '        '    MsgBox("dir")
        '        'End If
        '        'If Main.ls1(xt.Split(vbCrLf)(0).Remove(0, (xt.Split(vbCrLf)(0).Split(" ")(0).Length)).Trim, " ").ToString.Trim <> "" Then
        '        '    If (getone(path + "/" + Main.ls1(xt.Split(vbCrLf)(0).Remove(0, (xt.Split(vbCrLf)(0).Split(" ")(0).Length)).Trim, " "))).ToString.Trim <> "" Then
        '        '        MsgBox(Main.ls1(xt.Split(vbCrLf)(0).Remove(0, (xt.Split(vbCrLf)(0).Split(" ")(0).Length)).Trim, " "))
        '        '    Else
        '        '        MsgBox("dir")
        '        '    End If
        '        '    '
        '        'End If
        '        'If (getone(path + "/" + xt.Split(vbCrLf)(0).Trim.Split(" ")(xt.Split(vbCrLf)(0).Trim.Split(" ").Count - 1))).ToString.Trim <> "" Then
        '        '    MsgBox(xt.Split(vbCrLf)(0).Trim.Split(" ")(xt.Split(vbCrLf)(0).Trim.Split(" ").Count - 1))
        '        'Else
        '        '    MsgBox("dir")
        '        'End If
        '        y = x
        '        'st = st.Remove(0, x)
        '    End If
        'Next
    End Function
    Dim xxx = 0
    Private Sub FileD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        If TreeView1.Enabled = False Then
            Dim r = MsgBox("Do you want to stop the Scan Or you want to Exit ?" + vbCrLf + "Y - Scan" + vbCrLf + "N - Exit", MsgBoxStyle.YesNoCancel)
            If r = MsgBoxResult.Yes Then
                e.Cancel = True
                BackgroundWorker1.CancelAsync()
                xxx = 1
                TreeView1.SelectedNode.Nodes.Clear()
            Else
                If r = MsgBoxResult.No Then
                    xxx = 1
                Else
                    e.Cancel = True
                End If
            End If
        Else
            xxx = 1
        End If
        'My.Computer.FileSystem.DeleteDirectory(filetmp, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Sub
    Private Sub FileD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
w:      'xxx = 0
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        filetmp = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\FileTmp\"
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
        mlh = Main.mlh
        If Main.state().ToString.Trim = "device" Then
        Else
            GoTo d
        End If
        If TreeView1.SelectedNode.ImageIndex <> 8 Then
            WebBrowser1.Url = Nothing
            WebBrowser1.Visible = False
            SplitContainer6.Visible = False
            TextBox1.Text = ""
            TreeView1.Nodes.Clear()
            TreeView1.Nodes.Add("z", "Android", 10)
            add("/", 0)
            ToolStripComboBox1.SelectedItem = ToolStripComboBox1.Items(3)
        End If
        'Shell(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " kill-server", 0, True)
        'Shell(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " start-server", 0, True)
        Exit Sub
d:
        Main.mlh = ""
        MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
        'MsgBox(r)
        If DC.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GoTo w
        Else
            mlh = Main.mlh
            'Me.Show()
            Me.Close()
        End If
    End Sub
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        On Error Resume Next
        WebBrowser1.Url = Nothing
        WebBrowser1.Visible = False
        SplitContainer6.Visible = False
        TextBox1.Text = ""
        ContextMenuStrip1_Opening(Nothing, Nothing)
        If TreeView1.SelectedNode.Level = 0 Then
            Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw /system ", 0, True)
            Dim ru = Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell cat /proc/cpuinfo ", xcmd, xmt).ToString.Replace(vbCrLf, "").Replace(vbLf, vbLf).Trim
            Dim rm = Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell cat /proc/meminfo ", xcmd, xmt).ToString.Replace(vbCrLf, "").Replace(vbLf, vbLf).Trim
            Dim rv = Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell cat /proc/version ", xcmd, xmt).ToString.Replace(vbCrLf, "").Replace(vbLf, vbLf).Trim
            My.Computer.FileSystem.WriteAllText(xmt, ru + vbCrLf + vbCrLf + rm + vbCrLf + vbCrLf + rv, False, System.Text.Encoding.Default)
            WebBrowser1.Visible = True
            WebBrowser1.Url = New Uri(xmt)
        End If
    End Sub
    'Function convert_UTF8(ByVal str As String) As String
    '    Dim byt() As Byte = System.Text.Encoding.GetEncoding("Gb2312").GetBytes(str)
    '    Return System.Text.Encoding.UTF8.GetString(byt)
    'End Function
    Function ee()
        Dim te = System.Text.Encoding.Default
        If ToolStripComboBox1.SelectedItem = ToolStripComboBox1.Items(0) Then
            te = System.Text.Encoding.Default
        End If
        If ToolStripComboBox1.SelectedItem = ToolStripComboBox1.Items(1) Then
            te = System.Text.Encoding.ASCII
        End If
        If ToolStripComboBox1.SelectedItem = ToolStripComboBox1.Items(2) Then
            te = System.Text.Encoding.Unicode
        End If
        If ToolStripComboBox1.SelectedItem = ToolStripComboBox1.Items(3) Then
            te = System.Text.Encoding.UTF8
        End If
        Return te
    End Function
    Private Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        On Error Resume Next
        If TreeView1.SelectedNode.Name = "Dir" Or TreeView1.SelectedNode.Name = "Kdir" Then
            ChDir(Main.signapk)
            'MsgBox(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " mount -o remount,rw " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1)
            Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1 + " ", 0, True)
            'Main.shellme("",My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " mount -o remount,rw " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, xcmd, xmt)
            add(TreeView1.SelectedNode.FullPath.Replace("Android", ""), 1)
        Else
            If TreeView1.SelectedNode.Name = "File" Then
                My.Computer.FileSystem.DeleteDirectory(filetmp, FileIO.DeleteDirectoryOption.DeleteAllContents)
                MkDir(filetmp)
                If TreeView1.SelectedNode.ImageIndex = 5 Then
                    WebBrowser1.Url = Nothing
                    TextBox1.Text = ""
                    WebBrowser1.Visible = False
                    SplitContainer6.Visible = True
                    Dim tcmd = xcmd
                    Dim tmt = xmt
                    Kill(tcmd)
                    Kill(tmt)
                    My.Computer.FileSystem.WriteAllText(tcmd, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1 + " " + My.Resources.x1 + filetmp + TreeView1.SelectedNode.Text + My.Resources.x1, False, System.Text.Encoding.Default)
                    Shell(tcmd, 0, True)
                    Dim tx As String = My.Computer.FileSystem.ReadAllText(filetmp + TreeView1.SelectedNode.Text, ee)
                    TextBox1.Text = tx.Replace(vbLf, vbCrLf)
                    Kill(tcmd)
                Else
                    If TreeView1.SelectedNode.ImageIndex = 8 Then
                        Main.shellme("Pulling " + TreeView1.SelectedNode.FullPath.Replace("Android", ""), My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1 + " " + My.Resources.x1 + filetmp + TreeView1.SelectedNode.Text + My.Resources.x1, xcmd, xmt)
                        If My.Computer.FileSystem.FileExists(filetmp + TreeView1.SelectedNode.Text) = True Then
                            Me.Hide()
                            Main.fapp = filetmp + TreeView1.SelectedNode.Text
                            Main.TextBox1.Text = Main.fapp
                            Main.setinfo(Main.getmf(Main.fapp, xcmd, xmt))
                            'MsgBox(Setting.r1)
                            If Setting.r1 <> "0" Then
                                Viewz.dus = 1
                            Else
                                Viewz.dus = 0
                            End If
                            Main.Show()
                        End If
                    Else
                        '    If TreeView1.SelectedNode.ImageIndex = 3 or Then
                        WebBrowser1.Url = Nothing
                        TextBox1.Text = ""
                        WebBrowser1.Visible = True
                        SplitContainer6.Visible = False
                        'Dim kx = (My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " pull " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1 + " " + My.Resources.x1 + tmt + "" + My.Resources.x1)
                        'My.Computer.FileSystem.WriteAllText("C:\123.cmd", kx, False, System.Text.Encoding.UTF8)
                        'My.Computer.Clipboard.SetText(convert_UTF8(kx))
                        Main.shellme("Pulling " + TreeView1.SelectedNode.FullPath.Replace("Android", ""), My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1 + " " + My.Resources.x1 + filetmp + TreeView1.SelectedNode.Text + My.Resources.x1, xcmd, xmt)
                        'Shell(My.Resources.x1 + Main.utf8 + My.Resources.x1 + " " + My.Resources.x1 + tcmd + My.Resources.x1, 0, True)
                        WebBrowser1.Visible = True
                        'PictureBox1.WaitOnLoad = True
                        'PictureBox1.ImageLocation = tmt
                        WebBrowser1.Url = New Uri(filetmp + TreeView1.SelectedNode.Text)
                        'Kill(tmt)
                        '    End If
                    End If
                End If
            Else
                If TreeView1.SelectedNode.Name = "z" Then
                    WebBrowser1.Url = Nothing
                    WebBrowser1.Visible = False
                    SplitContainer6.Visible = False
                    TextBox1.Text = ""
                    TreeView1.Nodes.Clear()
                    TreeView1.Nodes.Add("z", "Android", 10)
                    add("/", 0)
                End If
            End If
        End If
    End Sub
    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Dim tx As String = My.Computer.FileSystem.ReadAllText(filetmp + TreeView1.SelectedNode.Text, ee)
        TextBox1.Text = tx.Replace(vbLf, vbCrLf)
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        FileD_Load(Nothing, Nothing)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CommandToolStripMenuItem_Click(Nothing, Nothing)
        'On Error Resume Next
        'Dim tcmd = xcmd
        'Dim tmt = xmt
        'Kill(tcmd)
        'Kill(tmt)
        'My.Computer.FileSystem.WriteAllText(tcmd, My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell ls /data/data  " + My.Resources.x1 + ">" + My.Resources.x1 + tmt + My.Resources.x1, False, System.Text.Encoding.Default)
        'Shell(tcmd, 0, True)
        'Dim tx As String = My.Computer.FileSystem.ReadAllText(tmt)
        'Kill(tcmd)
        'Kill(tmt)
        'MsgBox(tx)
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        Me.Enabled = False
        Label1.Text = "Processing..." + vbCrLf + TreeView1.SelectedNode.FullPath.Replace("Android", "")
        Label1.Visible = True
        Main.shellme("Pulling " + TreeView1.SelectedNode.FullPath.Replace("Android", ""), My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1 + " " + My.Resources.x1 + filetmp + TreeView1.SelectedNode.Text + My.Resources.x1, xcmd, xmt)
        Me.Enabled = True
        Label1.Text = ""
        Label1.Visible = False
        If Main.getlast(TreeView1.SelectedNode.Text.Split(".")).Trim.ToLower = "apk" Then
            Me.Hide()
            Main.fapp = filetmp + TreeView1.SelectedNode.Text
            Main.TextBox1.Text = Main.fapp
            Main.setinfo(Main.getmf(Main.fapp, xcmd, xmt))
            Main.ShowDialog()
        Else
            Shell("Rundll32.exe url.dll, FileProtocolHandler " + filetmp + TreeView1.SelectedNode.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If TreeView1.Nodes.Count = 0 Then
            AddToolStripMenuItem.Visible = False
            Button3.Enabled = False
            CopyToToolStripMenuItem.Visible = False
            GetAllPowerToolStripMenuItem.Visible = False
            Button4.Enabled = False
            ChangeToolStripMenuItem.Visible = False
            OpenToolStripMenuItem.Visible = False
            ToolStripSeparator2.Visible = False
            'ToolStripSeparator3.Visible = False
            ToolStripSeparator4.Visible = False
        Else
            If TreeView1.SelectedNode Is Nothing Then
                CopyToToolStripMenuItem.Visible = False
                GetAllPowerToolStripMenuItem.Visible = False
                Button4.Enabled = False
                ChangeToolStripMenuItem.Visible = False
                OpenToolStripMenuItem.Visible = False
                ToolStripSeparator2.Visible = False
                'ToolStripSeparator3.Visible = False
                ToolStripSeparator4.Visible = False
            Else
                If TreeView1.SelectedNode.Level = 0 Or TreeView1.SelectedNode.Name = "xFile" Then
                    AddToolStripMenuItem.Visible = False
                    Button3.Enabled = False
                    MkDirToolStripMenuItem.Visible = False
                    CopyToToolStripMenuItem.Visible = False
                    GetAllPowerToolStripMenuItem.Visible = False
                    Button4.Enabled = False
                    ChangeToolStripMenuItem.Visible = False
                    OpenToolStripMenuItem.Visible = False
                    ToolStripSeparator2.Visible = False
                    ToolStripSeparator1.Visible = False
                    ToolStripSeparator4.Visible = False
                Else
                    If TreeView1.SelectedNode.Name <> "xFile" Then
                        Button3.Enabled = True
                        AddToolStripMenuItem.Visible = True
                        MkDirToolStripMenuItem.Visible = True
                        CopyToToolStripMenuItem.Visible = True
                        Button4.Enabled = True
                        ToolStripSeparator4.Visible = True
                        ToolStripSeparator1.Visible = True
                        If TreeView1.SelectedNode.Name = "File" Then
                            Button3.Enabled = False
                            AddToolStripMenuItem.Visible = False
                            MkDirToolStripMenuItem.Visible = False
                            ToolStripSeparator2.Visible = True
                            OpenToolStripMenuItem.Visible = True
                        Else
                            Button3.Enabled = True
                            AddToolStripMenuItem.Visible = True
                            MkDirToolStripMenuItem.Visible = True
                            OpenToolStripMenuItem.Visible = False
                            ToolStripSeparator2.Visible = False
                        End If
                    Else
                        Button3.Enabled = False
                        AddToolStripMenuItem.Visible = False
                        MkDirToolStripMenuItem.Visible = False
                        GetAllPowerToolStripMenuItem.Visible = False
                        CopyToToolStripMenuItem.Visible = False
                        ChangeToolStripMenuItem.Visible = False
                        'ChangeToolStripMenuItem.Visible = False
                        Button4.Enabled = False
                        OpenToolStripMenuItem.Visible = False
                        ToolStripSeparator2.Visible = False
                        ToolStripSeparator1.Visible = False
                        ToolStripSeparator4.Visible = False
                    End If
                    If TreeView1.SelectedNode.Level > 1 Then
                        ToolStripSeparator1.Visible = True
                        'If TreeView1.SelectedNode.Name = "xFile" Then
                        'ChangeToolStripMenuItem.Visible = False
                        'Else
                        ChangeToolStripMenuItem.Visible = True
                        GetAllPowerToolStripMenuItem.Visible = True
                        'End If
                        DeleteToolStripMenuItem.Visible = True
                    Else
                        If TreeView1.SelectedNode.Name = "File" Then
                            ToolStripSeparator1.Visible = False
                        Else
                            ToolStripSeparator1.Visible = True
                        End If
                        GetAllPowerToolStripMenuItem.Visible = False
                        ChangeToolStripMenuItem.Visible = False
                        DeleteToolStripMenuItem.Visible = False
                    End If
                End If
                'If TreeView1.SelectedNode.Text.Split("."))        .Trim.ToLower = "png" Or TreeView1.SelectedNode.Text.Split("."))        .Trim.ToLower = "ogg" Then
                '    LiteToolStripMenuItem.Visible = True
                'Else
                '    LiteToolStripMenuItem.Visible = False
                'End If
            End If
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AddToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub CopyToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToToolStripMenuItem.Click
        On Error Resume Next
        Me.Enabled = False
        Label1.Text = "Processing..." + vbCrLf + TreeView1.SelectedNode.FullPath.Replace("Android", "")
        Label1.Visible = True
        If TreeView1.SelectedNode.Name = "File" Then
            With New SaveFileDialog
                .FileName = TreeView1.SelectedNode.Text
                .Filter = "*.*|*.*"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Main.shellme("Saving " + TreeView1.SelectedNode.FullPath.Replace("Android", ""), My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1 + " " + My.Resources.x1 + .FileName + My.Resources.x1, xcmd, xmt)
                    If My.Computer.FileSystem.FileExists(.FileName) = True Then
                        MsgBox("Succeed!" + vbCrLf + "Saved to " + vbCrLf + .FileName, MsgBoxStyle.Information)
                    Else
                        MsgBox("Failure!", MsgBoxStyle.Information)
                    End If
                End If
            End With
        Else
            With New FolderBrowserDialog
                .SelectedPath = ""
                .ShowNewFolderButton = True
                .Description = "Choose a path:"
                .ShowDialog()
                If .SelectedPath <> "" Then
                    Main.shellme("Saving " + TreeView1.SelectedNode.FullPath.Replace("Android", ""), My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1 + " " + My.Resources.x1 + .SelectedPath + "\" + TreeView1.SelectedNode.Text + My.Resources.x1, xcmd, xmt)
                    If My.Computer.FileSystem.DirectoryExists(.SelectedPath + "\" + TreeView1.SelectedNode.Text) = True Then
                        MsgBox("Succeed!" + vbCrLf + "Saved to " + vbCrLf + .SelectedPath + "\" + TreeView1.SelectedNode.Text, MsgBoxStyle.Information)
                    Else
                        MsgBox("Failure!", MsgBoxStyle.Information)
                    End If
                End If
            End With
        End If
        Me.Enabled = True
        Label1.Text = ""
        Label1.Visible = False
    End Sub
    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        On Error Resume Next
        Me.Enabled = False
        Label1.Text = "Processing..." + vbCrLf + TreeView1.SelectedNode.FullPath.Replace("Android", "")
        Label1.Visible = True
        Dim pp = ""
        If TreeView1.SelectedNode.Level = "0" Then
            'MsgBox("0")
        Else
            'MsgBox("1")
            'If (TreeView1.SelectedNode.Level = "1" And TreeView1.SelectedNode.Name = "Dir") Or (TreeView1.SelectedNode.Level = "1" And TreeView1.SelectedNode.Name = "Kdir") Then
            pp = TreeView1.SelectedNode.FullPath.Replace("Android", "")
            'Else
            'If (TreeView1.SelectedNode.Level <> "1" And TreeView1.SelectedNode.Name = "Dir") Or (TreeView1.SelectedNode.Level <> "1" And TreeView1.SelectedNode.Name = "Kdir") Then
            '    pp = TreeView1.SelectedNode.FullPath.Replace("Android", "")
            'Else
            '    pp = TreeView1.SelectedNode.FullPath.Replace("Android", "")
            'End If
            'End If
            'If My.Computer.FileSystem.FileExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True Then
            '    If TreeView1.SelectedNode.Level <> 0 Then
            '        pp = Main.kwd + Main.ls1(TreeView1.SelectedNode.FullPath.Replace("/", "\"), "\")
            '    Else
            '        pp = Main.kwd
            '    End If
            'Else
            '    GoTo r
            'End If
        End If
        'add()
        Dim r = MsgBox("Do you want to add Directory or Files" + vbCrLf + "Y - Directory" + vbCrLf + "N - Files", MsgBoxStyle.YesNoCancel)
        If r = MsgBoxResult.Yes Then
            With New FolderBrowserDialog
                .SelectedPath = ""
                .Description = "Choose a Directory:"
                .ShowNewFolderButton = True
                .ShowDialog()
                If .SelectedPath <> "" Then
                    If My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.*").Count <> 0 Then
                        Main.shellme("Adding " + pp + "/" + Main.getPY(Main.getlast(.SelectedPath.Split("\"))), My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + .SelectedPath + My.Resources.x1 + " " + My.Resources.x1 + pp + "/" + Main.getPY(Main.getlast(.SelectedPath.Split("\"))) + My.Resources.x1, xcmd, xmt)
                        GoTo k
                    Else
                        MsgBox("This is an empty Directory!", MsgBoxStyle.Information)
                    End If
                End If
            End With
        Else
            If r = MsgBoxResult.No Then
                With New OpenFileDialog
                    .Multiselect = True
                    .FileName = ""
                    .Filter = "*.*|*.*"
                    .ShowDialog()
                    If .FileNames.longlength <> 0 Then
                        For x = 0 To .FileNames.longlength - 1
                            Main.shellme("Adding " + pp + "/" + Main.getPY(Main.getlast(.FileNames(x).Split("\"))), My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + .FileNames(x) + My.Resources.x1 + " " + My.Resources.x1 + pp + "/" + Main.getPY(Main.getlast(.FileNames(x).Split("\"))) + My.Resources.x1, xcmd, xmt)
                        Next
                        GoTo k
                    End If
                End With
            End If
        End If
        Me.Enabled = True
        Label1.Text = ""
        Label1.Visible = False
        Exit Sub
k:
        'If TreeView1.SelectedNode.Level <> 1 Then
        '    TreeView1.SelectedNode.ImageIndex = 0
        Me.Enabled = True
        Label1.Text = ""
        Label1.Visible = False
        '    'TreeView1.SelectedNode = TreeView1.SelectedNode.Parent
        TreeView1_DoubleClick(Nothing, Nothing)
        'Else
        '    FileD_Load(Nothing, Nothing)
        '    'TreeView1.SelectedNode.Expand()
        'End If
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        On Error Resume Next
        Me.Enabled = False
        Label1.Text = "Processing..." + vbCrLf + TreeView1.SelectedNode.FullPath.Replace("Android", "")
        Label1.Visible = True
        If TreeView1.SelectedNode.Level > 1 Then
            If MsgBox("Do you want to Delete " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1 + " ?", MsgBoxStyle.YesNo) = vbYes Then
                If TreeView1.SelectedNode.Name = "File" Then
                    Main.shellme("Deleting " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, xcmd, xmt)
                    'My.Computer.Clipboard.SetText(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell rm " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1)
                Else
                    If TreeView1.SelectedNode.Name = "Dir" Or TreeView1.SelectedNode.Name = "Kdir" Then
                        Main.shellme("Deleting " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + "/*" + My.Resources.x1, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + "/*" + My.Resources.x1, xcmd, xmt)
                        'My.Computer.Clipboard.SetText(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell rm " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1)
                        Main.shellme("Deleting " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rmdir " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, xcmd, xmt)
                        'My.Computer.Clipboard.SetText(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell rm " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1)
                    End If
                End If
                'If TreeView1.SelectedNode.Level <> 1 Then
                '    'TreeView1.SelectedNode.ImageIndex = 0
                '    TreeView1.SelectedNode = TreeView1.SelectedNode.Parent
                Me.Enabled = True
                Label1.Text = ""
                Label1.Visible = False
                TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                'TreeView1.SelectedNode = TreeView1.SelectedNode.Parent
                'TreeView1_DoubleClick(Nothing, Nothing)
                'Else
                '    FileD_Load(Nothing, Nothing)
                '    'TreeView1.SelectedNode.Expand()
                'End If
            End If
        End If
    End Sub
    Private Sub MkDirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MkDirToolStripMenuItem.Click
        On Error Resume Next
        Me.Enabled = False
        Label1.Text = "Processing..." + vbCrLf + TreeView1.SelectedNode.FullPath.Replace("Android", "")
        Label1.Visible = True
        Dim sll = Main.getPY(InputBox("Please input A Name:", "MkDir").Trim)
        If sll <> "" Then
            Main.shellme("MkDiring", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mkdir " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + "/" + sll + My.Resources.x1, xcmd, xmt)
            TreeView1_DoubleClick(Nothing, Nothing)
        End If
        'My.Computer.Clipboard.SetText(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " mkdir " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + "/" + Main.getPY(InputBox("Please input A Name:", "MkDir")) + My.Resources.x1)
        'If TreeView1.SelectedNode.Level <> 1 Then
        '    TreeView1.SelectedNode.ImageIndex = 0
        Me.Enabled = True
        Label1.Text = ""
        Label1.Visible = False
        '    'TreeView1.SelectedNode = TreeView1.SelectedNode.Parent
        'Else
        '    FileD_Load(Nothing, Nothing)
        '    'TreeView1.SelectedNode.Expand()
        'End If
    End Sub
    Private Sub ReplaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceToolStripMenuItem.Click
        On Error Resume Next
        Me.Enabled = False
        Label1.Text = "Processing..." + vbCrLf + TreeView1.SelectedNode.FullPath.Replace("Android", "")
        Label1.Visible = True
        If TreeView1.SelectedNode.Level > 1 Then
            If TreeView1.SelectedNode.Name = "File" Then
                With New OpenFileDialog
                    .FileName = ""
                    .Filter = "*.*|*.*"
                    .ShowDialog()
                    If .FileName <> "" Then
                        Main.shellme("Replacing " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, xcmd, xmt)
                        'My.Computer.Clipboard.SetText(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell rm " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1)
                        For x = 0 To .FileNames.longlength - 1
                            Main.shellme("Replacing " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + .FileName + My.Resources.x1 + " " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, xcmd, xmt)
                        Next
                        GoTo k
                    End If
                End With
            Else
                If TreeView1.SelectedNode.Name = "Dir" Or TreeView1.SelectedNode.Name = "Kdir" Then
                    With New FolderBrowserDialog
                        .SelectedPath = ""
                        .Description = "Choose a Directory:"
                        .ShowNewFolderButton = True
                        .ShowDialog()
                        If .SelectedPath <> "" Then
                            If My.Computer.FileSystem.GetFiles(.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.*").Count <> 0 Then
                                Main.shellme("Replacing " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + "/*" + My.Resources.x1, xcmd, xmt)
                                'My.Computer.Clipboard.SetText(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell rm " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1)
                                Main.shellme("Replacing " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rmdir " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, xcmd, xmt)
                                'My.Computer.Clipboard.SetText(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell rm " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1)
                                Main.shellme("Replacing " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + .SelectedPath + My.Resources.x1 + " " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, xcmd, xmt)
                                GoTo k
                            Else
                                MsgBox("This is an empty Directory!", MsgBoxStyle.Information)
                            End If
                        End If
                    End With
                End If
            End If
        End If
        Me.Enabled = True
        Label1.Text = ""
        Label1.Visible = False
        Exit Sub
k:
        Me.Enabled = True
        Label1.Text = ""
        Label1.Visible = False
        'If TreeView1.SelectedNode.Level <> 1 Then
        '    'TreeView1.SelectedNode.ImageIndex = 0
        'TreeView1.SelectedNode = TreeView1.SelectedNode.Parent
        ''TreeView1.SelectedNode = TreeView1.SelectedNode.PrevNode
        'TreeView1_DoubleClick(Nothing, Nothing)
        'Else
        '    FileD_Load(Nothing, Nothing)
        '    'TreeView1.SelectedNode.Expand()
        'End If
    End Sub
    Private Sub AttributeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttributeToolStripMenuItem.Click
        On Error Resume Next
        Dim r = "ls -l " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1
        If TreeView1.SelectedNode Is TreeView1.TopNode Then
            Dim tx = Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " get-serialno", xcmd, xmt)
            'My.Computer.Clipboard.SetText(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell rm " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1)
            MsgBox("Android: " + tx + "Path: /" + vbCrLf + Main.shellme("Running ", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell ls -l", xcmd, xmt).ToString.Replace(vbCrLf, ""), MsgBoxStyle.Information)
        Else
            If TreeView1.SelectedNode.Name = "Dir" Or TreeView1.SelectedNode.Name = "Kdir" Then
                MsgBox("Dir: " + TreeView1.SelectedNode.Text + vbCrLf + "Path: " + TreeView1.SelectedNode.FullPath.Replace("Android", "") + vbCrLf + Main.shellme("Running " + r.Trim, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell " + r.Trim, xcmd, xmt).ToString.Replace(vbCrLf, ""), MsgBoxStyle.Information)
            Else
                MsgBox("File: " + TreeView1.SelectedNode.Text + vbCrLf + "Path: " + TreeView1.SelectedNode.FullPath.Replace("Android", "") + vbCrLf + Main.shellme("Running " + r.Trim, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell " + r.Trim, xcmd, xmt).ToString.Replace(vbCrLf, ""), MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        On Error Resume Next
        Dim tcmd = xcmd
        Dim tmt = xmt
        Kill(tcmd)
        Kill(tmt)
        My.Computer.FileSystem.WriteAllText(tcmd, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1 + " " + My.Resources.x1 + filetmp + TreeView1.SelectedNode.Text + My.Resources.x1, False, System.Text.Encoding.Default)
        Shell(tcmd, 0, True)
        Dim tx As String = My.Computer.FileSystem.ReadAllText(filetmp + TreeView1.SelectedNode.Text, ee)
        TextBox1.Text = tx.Replace(vbLf, vbCrLf)
        Kill(tcmd)
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        With New SaveFileDialog
            .FileName = TreeView1.SelectedNode.Text
            .Filter = "*.*|*.*"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Computer.FileSystem.WriteAllText(.FileName, TextBox1.Text, False, ee)
                If ee() Is System.Text.Encoding.UTF8 Then
                    Shell(My.Resources.x1 + My.Application.Info.DirectoryPath + "\Tools\UTF8.exe" + My.Resources.x1 + " " + My.Resources.x1 + .FileName + My.Resources.x1, 0, True)
                End If
                MsgBox("Done!", MsgBoxStyle.Information)
            End If
        End With
    End Sub
    Dim mlh As String
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        On Error Resume Next
        My.Computer.FileSystem.WriteAllText(filetmp + TreeView1.SelectedNode.Text, TextBox1.Text, False, ee)
        If ee() Is System.Text.Encoding.UTF8 Then
            Shell(My.Resources.x1 + My.Application.Info.DirectoryPath + "\Tools\UTF8.exe" + My.Resources.x1 + " " + My.Resources.x1 + filetmp + TreeView1.SelectedNode.Text + My.Resources.x1, 0, True)
        End If
        Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + filetmp + TreeView1.SelectedNode.Text + My.Resources.x1 + " " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, xcmd, xmt)
        MsgBox("Done!", MsgBoxStyle.Information)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CopyToToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Apps.ShowDialog()
        Me.Show()
    End Sub
    Dim dx
    Function ui(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As Long
        On Error Resume Next
        If cst.ToString.Replace(vbCrLf, "").Trim = "" And tpn = 0 Then
            Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " kill-server", 0, True)
            Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " start-server", 0, True)
        End If
        Dim cxx = cst.ToString.Split(vbCrLf)
        For x = 0 To cxx.longlength - 1
            If xxx = 1 Then
                GoTo c
            End If
            Dim qx = cxx(x).Trim.Replace(vbCrLf, "").Replace("//", "/")
            If qx.Trim <> "" And qx.Trim <> "." And qx.Trim <> ".." Then
                'MsgBox(qx)
                dx = qx
                'MsgBox(bx) 
                Dim bx = getone(cpath + "/" + qx).ToString.Trim
                If bx <> "" And bx <> cpath + "/" + qx.Trim And bx.Trim <> ".   .." Then
                    If ccof = 0 Then
                        'TreeView1.TopNode.Nodes.Add("Dir", qx, 0)
                        ox.Items.Add("0" + "*" + "Dir" + "*" + qx + "*" + "0")
                    Else
                        If bx.Trim.Replace("No such file or directory", "").Length = bx.Trim.Length And bx.Trim.Replace("Syntax error:", "").Length = bx.Trim.Length Then
                            'MsgBox(qx)
                            'TreeView1.SelectedNode.Nodes.Add("Dir", qx, 0)
                            ox.Items.Add("1" + "*" + "Dir" + "*" + qx + "*" + "0")
                        Else
                            'MsgBox(Main.getPY(qx))
                            'TreeView1.SelectedNode.Nodes.Add("xFile", qx, 7)
                            ox.Items.Add("1" + "*" + "xFile" + "*" + qx + "*" + "7")
                        End If
                    End If
                Else
                    If bx = cpath + "/" + qx.Trim Then
                        If ccof = 0 Then
                            'TreeView1.TopNode.Nodes.Add("File", qx, 1)
                            ox.Items.Add("0" + "*" + "File" + "*" + qx + "*" + "1")
                        Else
                            'TreeView1.SelectedNode.Nodes.Add("File", qx, getkz(qx))
                            ox.Items.Add("1" + "*" + "File" + "*" + qx + "*" + CStr(getkz(qx)).Trim)
                        End If
                    Else
                        If bx.Trim = "" Or bx.Trim = ".   .." Then
                            If ccof = 0 Then
                                'TreeView1.TopNode.Nodes.Add("Kdir", qx, 9)
                                ox.Items.Add("0" + "*" + "Kdir" + "*" + qx + "*" + "9")
                            Else
                                'TreeView1.SelectedNode.Nodes.Add("Kdir", qx, 9)
                                ox.Items.Add("1" + "*" + "Kdir" + "*" + qx + "*" + "9")
                            End If
                        Else
                            MsgBox(qx)
                        End If
                    End If
                End If
            End If
        Next
c:
    End Function
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ui(e.Argument, e.Result)
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        On Error Resume Next
        For x = 0 To ox.Items.Count - 1
            Dim y = ox.Items(x).ToString.Trim.Split("*")
            Dim y1 = y(0)
            Dim y2 = y(1)
            Dim y3 = y(2)
            Dim y4 = y(3)
            If CInt(y1) = 0 Then
                TreeView1.TopNode.Nodes.Add(y2, y3, CInt(y4))
            Else
                TreeView1.SelectedNode.Nodes.Add(y2, y3, CInt(y4))
            End If
        Next
        If ccof = 0 Then
            TreeView1.TopNode.Expand()
        Else
            If TreeView1.SelectedNode.Name = "Dir" Then
                If TreeView1.SelectedNode.Nodes.Count = 0 Then
                    TreeView1.SelectedNode.Name = "Kdir"
                    TreeView1.SelectedNode.ImageIndex = 9
                End If
            Else
                If TreeView1.SelectedNode.Name = "Kdir" Then
                    If TreeView1.SelectedNode.Nodes.Count <> 0 Then
                        TreeView1.SelectedNode.Name = "Dir"
                        TreeView1.SelectedNode.ImageIndex = 0
                    End If
                End If
            End If
            TreeView1.Refresh()
            TreeView1.SelectedNode.Expand()
        End If
        TreeView1.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        ContextMenuStrip1_Opening(Nothing, Nothing)
        Main.NotifyIcon1.Icon = Nothing
        Timer1.Enabled = False
        Dim tcmd = xcmd
        Dim tmt = xmt
        Kill(tcmd)
        Kill(tmt)
        If xxx = 1 Then
            TreeView1.SelectedNode.Nodes.Clear()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        If ("Scaning " + dx.ToString).Length > 64 Then
            Main.NotifyIcon1.Text = "Scaning " + dx.ToString.Trim.Remove(51) + "..."
        Else
            Main.NotifyIcon1.Text = "Scaning " + dx.ToString.Trim
        End If
        Main.NotifyIcon1.BalloonTipText = "Scaning " + dx.ToString
        Main.NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
        Main.NotifyIcon1.BalloonTipTitle = "Andorid Explorer"
        Main.NotifyIcon1.ShowBalloonTip(500)
    End Sub
    Private Sub CommandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandToolStripMenuItem.Click
        On Error GoTo a
        Dim dfs As String
        If TreeView1.SelectedNode Is TreeView1.TopNode Then
            dfs = "free"
        Else
            dfs = "ls -l " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1
        End If
a:      Dim r = InputBox("Please Write Some Android Phone Command" + vbCrLf + "(Such as 'free'):", "Android Command", dfs)
        If r.Trim <> "" Then
            Dim u = Main.shellme("Running " + r.Trim, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell " + r.Trim, xcmd, xmt).ToString.Replace(vbCrLf, "")
            If u = "" Then
                u = "Done!"
            End If
            MsgBox(u, MsgBoxStyle.Information, "Result")
        End If
    End Sub
    Private Sub GetAllPowerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetAllPowerToolStripMenuItem.Click
        Dim r = Main.shellme("Getting All Power...", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell chmod 777 " + My.Resources.x1 + TreeView1.SelectedNode.FullPath.Replace("Android", "") + My.Resources.x1, xcmd, xmt).ToString.Replace(vbCrLf, "")
        If r = "" Then
            r = "Done!"
        End If
        MsgBox(r, MsgBoxStyle.Information, "Result")
    End Sub
    Private Sub FtpModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FtpModeToolStripMenuItem.Click
        Ftp.ShowDialog()
    End Sub
    Private Sub DevicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevicesToolStripMenuItem.Click
        dcc()
    End Sub
    Function dcc()
        On Error Resume Next
        Main.mlh = ""
        Dim xk = DC.ShowDialog()
        mlh = Main.mlh
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
        filetmp = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\FileTmp\"
        If xk = Windows.Forms.DialogResult.OK Then
            RefreshToolStripMenuItem_Click(Nothing, Nothing)
        End If
    End Function
    Private Sub ToolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsToolStripMenuItem.Click
        Me.Hide()
        Tools.ShowDialog()
        Me.Show()
    End Sub
    Private Sub LogCatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogCatToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " logcat", AppWinStyle.NormalFocus, False)
    End Sub
End Class