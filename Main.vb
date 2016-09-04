﻿Public Class Main
    Public mlh As String
    Dim mlhs As String
    Public fastboot As String = My.Application.Info.DirectoryPath + "\Tools\fastboot.exe"
    Public oemlogo As String = My.Application.Info.DirectoryPath + "\Tools\load_oemlogo"
    Public utf8 As String = My.Application.Info.DirectoryPath + "\Tools\UTF8.exe"
    Public dexopt As String = My.Application.Info.DirectoryPath + "\Tools\dexopt-wrapper"
    Public apktool As String = My.Application.Info.DirectoryPath + "\Tools\apktool.jar"
    Public png As String = My.Application.Info.DirectoryPath + "\Tools\pnglite.exe"
    Public sox As String = My.Application.Info.DirectoryPath + "\Tools\sox.exe"
    Public adb As String = My.Application.Info.DirectoryPath + "\Tools\adb.exe"
    Public bootimg As String = My.Application.Info.DirectoryPath + "\Tools\bootimg.exe"
    Public aapt As String = My.Application.Info.DirectoryPath + "\Tools\aapt.exe"
    Public za As String = My.Application.Info.DirectoryPath + "\Tools\7za.exe"
    Public avd As String = "C:\Users\Administrator\android-sdks\AVD Manager.exe"
    Public java As String = "C:\Program Files (x86)\Java\jre7\bin\java.exe"
    Public signapk As String = My.Application.Info.DirectoryPath + "\Tools"
    Public kwd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\AkpTmp\"
    Public fapp As String = ""
    Dim stauts = "unknown"
    Dim xcmd As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
    Dim xmt As String = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
    Public xmmtt As String
    'Public tsts
    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next
        'If Setting.r1 <> "0" And Viewz.dus = 0 Then
        '    End
        'End If
        If Setting.r1 <> "0" Then
            e.Cancel = True
            Viewz.dus = 0
            Button8_Click(Nothing, Nothing)
        Else
            e.Cancel = False
            'Dim tcmd = Me.xcmd
            'Dim tmt = Me.xmt
            'Kill(tcmd)
            'Kill(tmt)
            MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
            ChDir(My.Application.Info.DirectoryPath)
            'Shell(My.Resources.x1 + adb + My.Resources.x1 + " kill-server", 0, True)
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        'Shell(My.Resources.x1 + adb + My.Resources.x1 + " start-server", 0, True)
        mlhs = mlh
        zzs = 0
        'PictureBox2.Image = My.Resources._ME
        'Viewz.ListView1.BackgroundImage = My.Resources._ME
        If Viewz.dus <> 1 Then
            xmmtt = (Date.Now.ToString.Replace("/", "_").Replace(":", "_").Trim).Replace(" ", "")
            xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
            xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
            MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
            'ChDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt)
            Dim r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx", "Runned", Nothing)
            If r0 <> "000" Then
                If MsgBox("感谢你使用Android App Manager！！！" + vbCrLf + "作者：Gentle" + vbCrLf  + vbCrLf + My.Resources.x2 + vbCrLf + "您是否接受", MsgBoxStyle.YesNo, "第一次运行！") = MsgBoxResult.Yes Then
                    Shell(My.Application.Info.DirectoryPath + "\Ext.idz", 1, True)
                    AboutBox.ShowDialog()
                    Shell(My.Application.Info.DirectoryPath + "\Tools\About.exe" + " " + CStr(CInt((New Random).Next(0, 3))), 1, True)
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx", "Runned", "000")
                Else
                    MsgBox("抱歉！不能为你服务！！！" + vbCrLf + "请以后多多支持！！！", MsgBoxStyle.Information, "Android App Manager")
                    End
                End If
            End If
            If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath + "\Tools") = False Then
                Shell(My.Application.Info.DirectoryPath + "\Ext.idz", 1, True)
            End If
            Setting.fis = 1
            Setting.rd()
            If My.Application.CommandLineArgs.Count = 1 Or My.Application.CommandLineArgs.Count = 2 Then
                If My.Application.CommandLineArgs(0).Trim = "-i" Then
                    Me.Hide()
                    zzs = 1
                    If My.Application.CommandLineArgs.Count = 2 Then
                        If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs(1).Replace(My.Resources.x1, "")) = True Then
                            Install.ImageList1.Images.Clear()
                            addxapk(My.Application.CommandLineArgs(1).Replace(My.Resources.x1, ""))
                        End If
                    End If
                    'MsgBox("")
                    Install.ShowDialog()
                    End
                Else
                    If My.Application.CommandLineArgs(0).Trim = "-a" Then
                        Setting.r1 = "0"
                        'My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\"+ xmmtt , FileIO.DeleteDirectoryOption.DeleteAllContents)
                        'If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\"+ xmmtt ) = True Then
                        '    Shell(My.Resources.x1 + adb + My.Resources.x1 + " " + mlhs + " kill-server", 0, True)
                        '    Shell(My.Resources.x1 + adb + My.Resources.x1 + " " + mlhs + " start-server", 0, True)
                        'End If
                        'MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest")
                        If My.Application.CommandLineArgs.Count = 2 Then
                            If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs(1).Replace(My.Resources.x1, "")) = True Then
                                fapp = My.Application.CommandLineArgs(1).Replace(My.Resources.x1, "")
                                TextBox1.Text = fapp
                                setinfo(getmf(fapp, xcmd, xmt))
                                GoTo p
                            Else
                                GoTo h
                            End If
                        Else
                            GoTo h
                        End If
                    Else
                        If My.Application.CommandLineArgs(0).Trim = "-e" Then
                            Setting.r1 = "1"
                            'My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest", FileIO.DeleteDirectoryOption.DeleteAllContents)
                            'If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest") = True Then
                            '    Shell(My.Resources.x1 + adb + My.Resources.x1 + " " + mlhs + " kill-server", 0, True)
                            '    Shell(My.Resources.x1 + adb + My.Resources.x1 + " " + mlhs + " start-server", 0, True)
                            'End If
                            'MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest")
                            If My.Application.CommandLineArgs.Count = 2 Then
                                If My.Computer.FileSystem.DirectoryExists(My.Application.CommandLineArgs(1).Replace(My.Resources.x1, "")) = True Then
                                    Label3.Text = My.Application.CommandLineArgs(1).Replace(My.Resources.x1, "")
                                    addapk(My.Application.CommandLineArgs(1).Replace(My.Resources.x1, ""))
                                    Viewz.RefreshToolStripMenuItem_Click(Nothing, Nothing)
                                    Viewz.ShowDialog()
                                Else
                                    If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs(1).Replace(My.Resources.x1, "")) = True Then
                                        Label3.Text = ls1(My.Application.CommandLineArgs(1).Replace(My.Resources.x1, ""), "\")
                                        addapk(Label3.Text)
                                        Viewz.RefreshToolStripMenuItem_Click(Nothing, Nothing)
                                        Viewz.ShowDialog()
                                    Else
                                        GoTo j
                                    End If
                                End If
                            Else
                                GoTo j
                            End If
                        Else
                            Start.ShowDialog()
                        End If
                    End If
                End If
            Else
                Start.ShowDialog()
            End If
            'state()
            'My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest", FileIO.DeleteDirectoryOption.DeleteAllContents)
            ''If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest") = True Then
            ''    Shell(My.Resources.x1 + adb + My.Resources.x1+" "+ mlh + " kill-server", 0, True)
            ''    Shell(My.Resources.x1 + adb + My.Resources.x1+" "+ mlh + " start-server", 0, True)
            ''End If
            'MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest")
            'tsts = (Date.Now.ToString.Replace("/", "_").Replace(":", "_").Trim.Replace(" ", "_"))
            ''
            ''My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + tsts, FileIO.DeleteDirectoryOption.DeleteAllContents)
            'MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\" + tsts)
            'xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\" + tsts + "\$1.cmd"
            'xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\" + tsts + "\$1.tmp"
            'MsgBox(xcmd)
            'MsgBox(xmt)
            If My.Application.CommandLineArgs.Count <= 1 Then
                If My.Computer.FileSystem.FileExists(Command().Replace(My.Resources.x1, "")) = True And My.Computer.FileSystem.DirectoryExists(Command().Replace(My.Resources.x1, "")) = False Then
                    GoTo l
                Else
                    If My.Computer.FileSystem.DirectoryExists(Command().Replace(My.Resources.x1, "")) = True Then
                        Setting.r1 = "1"
                        GoTo c
                    End If
                End If
                'MsgBox(Setting.r1)
                If Setting.r1 <> "0" Then
                    'Label3.Text = My.Computer.FileSystem.SpecialDirectories.Desktop
                    'MsgBox(Setting.rc)
c:
                    Me.Hide()
                    If Command.Trim = "" Then
                        'MsgBox(Setting.rc)
a:                      If Setting.rc <> "0" Then
                            Viewz.RefreshToolStripMenuItem_Click(Nothing, Nothing)
                        Else
                            Viewz.ToolStripButton1_Click(Nothing, Nothing)
                        End If
                    Else
                        'MsgBox("")
                        If My.Computer.FileSystem.DirectoryExists(Command().Replace(My.Resources.x1, "")) = True Then
                            Label3.Text = Command().Replace(My.Resources.x1, "")
                            addapk(Command().Replace(My.Resources.x1, ""))
                            Viewz.RefreshToolStripMenuItem_Click(Nothing, Nothing)
                        Else
                            GoTo a
                        End If
                    End If
j:                  Viewz.ShowDialog()
                Else
                    'PictureBox2.Image = Viewz.ListView1.BackgroundImage
                    'MsgBox("")
                    If Command().Trim = "" Then
b:                      Button4_Click(sender, e)
                        If fapp = "" Then
h:                          Button5_Click(sender, e)
                        End If
                    Else
                        If My.Computer.FileSystem.FileExists(Command().Replace(My.Resources.x1, "")) = True Then
l:                          fapp = Command().Replace(My.Resources.x1, "")
                            TextBox1.Text = fapp
                            setinfo(getmf(fapp, xcmd, xmt))
                        Else
                            GoTo b
                        End If
                    End If
                End If
            Else
                Me.Hide()
                Install.ImageList1.Images.Clear()
                For x = 0 To My.Application.CommandLineArgs.Count - 1
                    If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs(x).Replace(My.Resources.x1, "")) = True And getlast(My.Application.CommandLineArgs(x).Replace(My.Resources.x1, "").Trim.Split(".")).ToLower = "apk" Then
                        addxapk(My.Application.CommandLineArgs(x).Replace(My.Resources.x1, ""))
                    End If
                Next
                zzs = 1
                Install.ShowDialog()
            End If
        End If
        'BackgroundWorker1.RunWorkerAsync()
p:      'state()
        'Timer1.Enabled = True
    End Sub
    Public zzs = 0
    Function getmf(ByVal fapk As String, ByVal tcmd As String, ByVal tmt As String)
        If fapk.Trim <> "" Then
            On Error Resume Next
            Dim tx = shellme("", My.Resources.x1 + aapt + My.Resources.x1 + " dump badging " + My.Resources.x1 + fapk + My.Resources.x1, tcmd, tmt)
            'MsgBox(tx)
            Return tx
        End If
    End Function
    Function setinfo(ByVal tx As String)
        On Error Resume Next
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\res")
        Button9.Image = Nothing
        PictureBox1.Image = Nothing
        ImageList1.Images.Clear()
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label2.Text = getinfo(tx, "label=").ToString.Trim + " v" + getinfo(tx, "versionName=").ToString.Trim
        If Label2.Text.Trim = "v" Then
            Label2.Text = ""
        End If
        If My.Computer.FileSystem.FileExists(fapp) = True Then
            Label6.Text = "Size:" + CInt(My.Computer.FileSystem.GetFileInfo(fapp).Length / 1024).ToString + "KB " + " Date:" + My.Computer.FileSystem.GetFileInfo(fapp).CreationTimeUtc.ToString
        Else
            Label6.Text = ""
        End If
        Dim sp = getinfo(tx, "icon=")
        Dim xp = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\res\" + sp.ToString.Replace("/", "\")
        ' MsgBox(sp)
        Shell(My.Resources.x1 + za + My.Resources.x1 + " x -o" + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\res" + My.Resources.x1 + " -y " + My.Resources.x1 + fapp + My.Resources.x1 + " " + My.Resources.x1 + sp + My.Resources.x1, 0, True)
        PictureBox1.WaitOnLoad = True
        PictureBox1.ImageLocation = xp
        ImageList1.Images.Add(PictureBox1.Image)
        Button9.Image = ImageList1.Images(0)
        Kill(xp)
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\res", FileIO.DeleteDirectoryOption.DeleteAllContents)
        'MsgBox(getinfo(tx, "icon="))
        TextBox2.Text = tx
        TextBox3.Text = getpm(fapp)
    End Function
    Function getpm(ByVal fapk As String)
        If fapk.Trim <> "" Then
            On Error Resume Next
            Dim tx As String = shellme("", My.Resources.x1 + aapt + My.Resources.x1 + " dump permissions  " + My.Resources.x1 + fapk + My.Resources.x1, xcmd, xmt)
            'MsgBox(tx)
            Return tx
        End If
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If fapp = "" Then
            Button4_Click(Nothing, Nothing)
        Else
            setinfo(getmf(fapp, xcmd, xmt))
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If fapp = "" Then
            Button4_Click(Nothing, Nothing)
        Else
            getsign(fapp)
        End If
    End Sub
    Function state()
c:      ChDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\")
        On Error Resume Next
        mlhs = mlh
        Dim p1() As Process = Process.GetProcesses()
        Dim tcmm = My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + "\$STCMM$" + xmmtt + ".cmd"
        Dim tstate = My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + "\$State$" + xmmtt + ".tmp"
        Kill(tcmm)
        Kill(tstate)
        'MsgBox(mlhs)
        My.Computer.FileSystem.WriteAllText(tcmm, My.Resources.x1 + adb + My.Resources.x1 + " " + mlhs + " get-state" + " >" + My.Resources.x1 + tstate + My.Resources.x1, False, System.Text.Encoding.Default)
        Shell(tcmm, 0, True)
        'MsgBox(shellme("",My.Resources.x1 + adb + My.Resources.x1 + " " + " -s ?" + " get-state"))
        Dim tx = My.Computer.FileSystem.ReadAllText(tstate, System.Text.Encoding.Default)
        'MsgBox(mlhs)
        If tx.Trim = "" Then
            GoTo g
        End If
        'MsgBox(tx)
        'Kill(tcmm)
        'Kill(tstate)
        stauts = tx
        Dim xcs = mlh.Replace("-s", " -").Trim
        If xcs.Trim <> "" Then
            Apps.Text = "Apps " + xcs
            Me.Text = "Apk Manager " + xcs
            Install.Text = "Install " + xcs
            Tools.Text = "Tools " + xcs
            FileD.Text = "Android Explorer " + xcs
        Else
            Me.Text = "Apk Manager"
            Install.Text = "Install"
            Apps.Text = "Apps"
            Tools.Text = "Tools"
            FileD.Text = "Android Explorer"
        End If
        Kill(tcmm)
        Kill(tstate)
        If tx.ToString.Trim = "unknown" Then
            'Install.Close()
            'FileD.Close()
            'Apps.Close()
            Me.Text = "Apk Manager"
            Install.Text = "Install"
            Apps.Text = "Apps"
            Tools.Text = "Tools"
            FileD.Text = "Android Explorer"
            'MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
        End If
        mlhs = mlh
        Return tx
        Exit Function
g:      Shell(My.Resources.x1 + adb + My.Resources.x1 + " kill-server", 0, True)
        Shell(My.Resources.x1 + adb + My.Resources.x1 + " start-server", 0, True)
        GoTo c
    End Function
    Public Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'If MsgBox("Are you sure to install " + Label2.Text + " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    If CheckBox1.Checked = True Then
        '        getinstall(fapp, 1)
        '    Else
        '        getinstall(fapp, 0)
        '    End If
        'End If
        On Error Resume Next

        If state().ToString.Trim = "device" Then
            Install.ListView1.Items.Clear()
            Install.ImageList1.Images.Clear()
            addxapk(fapp)
            Me.Hide()
            Install.ShowDialog()
            Me.Show()
        Else
            MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
            DC.ShowDialog()

        End If
    End Sub
    Function addxapk(ByVal fapk As String)
        On Error Resume Next
        If fapk.Trim <> "" Then
            Install.ListView1.LargeImageList = Install.ImageList1
            Install.ListView1.SmallImageList = Install.ImageList1
            Dim df = fapk
            Dim de = getmf(df, xcmd, xmt)
            Dim dx = getinfo(de, "label=")
            Dim dy = getinfo(de, "versionName=")
            Dim dz = CStr(CInt(My.Computer.FileSystem.GetFileInfo(df).Length / 1024)) + "KB"
            Dim sp = getinfo(de, "icon=")
            Dim xp = My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\res\" + sp.ToString.Replace("/", "\")
            Shell(My.Resources.x1 + za + My.Resources.x1 + " x -o" + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\res" + My.Resources.x1 + " -y " + My.Resources.x1 + df + My.Resources.x1 + " " + My.Resources.x1 + sp + My.Resources.x1, 0, True)
            Dim dqx As New PictureBox
            dqx.WaitOnLoad = True
            dqx.ImageLocation = xp
            If dqx.Image Is Nothing Then
                dqx.Image = dqx.ErrorImage
            End If
            Install.ImageList1.Images.Add(dqx.Image)
            If dx.ToString.Trim = "" Then
                dx = ls1(getlast(df.Trim.Split("\")), ".")
                dy = "Unknown"
                'dz = CStr(CInt(My.Computer.FileSystem.GetFileInfo(df).Length / 1024)) + "KB"
            End If
            Dim k = Install.ListView1.Items.Add(dx, Install.ImageList1.Images.Count - 1)
            k.SubItems.Add(dy)
            k.SubItems.Add(dz)
            k.SubItems.Add(df)
            k.SubItems.Add("None")
            Install.ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
            'Viewz.ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
            'Viewz.ListView1.Columns.Item(2).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
            'Install.ListView1.Columns.Item(4).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\res", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Function
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim fo As New OpenFileDialog
        With fo
            .FileName = ""
            .Filter = "*.Apk|*.apk|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                TextBox1.Text = .FileName
                fapp = TextBox1.Text
                ' MsgBox("Chaged", MsgBoxStyle.Information)
                setinfo(getmf(fapp, xcmd, xmt))
                Label3.Text = ls1(TextBox1.Text, "\").Trim()
                addapk(Label3.Text)
            End If
        End With
    End Sub
    Function getinfo(ByVal txs As String, ByVal tsz As String)
        On Error Resume Next
        Dim x = 0
        Dim p = 0
        Dim y = 0
        Dim z = 0
        Dim sz = tsz
        Do
            If Mid(txs, x + 1, sz.Length) = sz Then
                p = 1
                ' MsgBox(x)
            End If
            x = x + 1
        Loop Until p = 1 Or x >= txs.Length - 1
        If p = 1 Then
            p = 0
            x = x + sz.Length - 1
            Do
                If Mid(txs, x + 1, 1) = "'" Then
                    p = 1
                    y = x
                    '  MsgBox(x)
                End If
                x = x + 1
            Loop Until p = 1 Or x >= txs.Length - 1
        End If
        If p = 1 Then
            p = 0
            Do
                If Mid(txs, x + 1, 1) = "'" Then
                    p = 1
                    z = x
                    '   MsgBox(x)
                End If
                x = x + 1
            Loop Until p = 1 Or x >= txs.Length - 1
        End If
        If x <> 0 And y <> 0 And z <> 0 Then
            ' MsgBox(txs.Substring(y + 1, z - y - 1))
            Return txs.Substring(y + 1, z - y - 1)
        Else
            Return ""
        End If
    End Function
    Function getsign(ByVal fapk As String)
        On Error Resume Next
        Dim op As New SaveFileDialog
        With op
            .FileName = getlast(fapk.Split("\"))
            .Filter = "*.Apk|*.apk|*.*|*.*"
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                sign(fapk, .FileName, 0)
            End If
        End With
    End Function
    Function sign(ByVal fapk As String, ByVal lapk As String, ByVal nof As Integer)
        If My.Computer.FileSystem.FileExists(java) = False Then
            MsgBox("Please Choose a JRE!", MsgBoxStyle.Information)
            With New OpenFileDialog
                .FileName = "Java.exe"
                .Filter = "Java.exe|Java.exe"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    java = .FileName
                    My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx")
                    My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx\Apk_Manager")
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Manager", "JRE", java)
                Else
                    GoTo d
                End If
            End With
        End If
        On Error Resume Next
        'Dim tcmd = xcmd
        'Kill(tcmd)
        ChDir(signapk)
        If nof = 1 Then
            GoTo g
        End If
        If My.Computer.FileSystem.FileExists(lapk) = True Then
g:          shellme("", My.Resources.x1 + java + My.Resources.x1 + " -jar signapk.jar -w testkey.x509.pem testkey.pk8 " + My.Resources.x1 + fapk + My.Resources.x1 + " " + My.Resources.x1 + lapk + "x" + My.Resources.x1, xcmd, xmt)
            'MsgBox("")
            If nof = 1 Then
                GoTo l
            End If
            If fapk <> lapk Then
                Kill(ls1(lapk, ".") + ".unsign.apk")
                Rename(lapk, ls1(lapk, ".") + ".unsign.apk")
            Else
l:              Kill(lapk)
            End If
            Rename(lapk + "x", lapk)
        Else
            shellme("", My.Resources.x1 + java + My.Resources.x1 + " -jar signapk.jar -w testkey.x509.pem testkey.pk8 " + My.Resources.x1 + fapk + My.Resources.x1 + " " + My.Resources.x1 + lapk + My.Resources.x1, xcmd, xmt)
        End If
        If nof = 0 Then
            MsgBox("Signed to " + vbCrLf + lapk)
        End If
        Return Nothing
        Exit Function
d:      MsgBox("Sign Failured!", MsgBoxStyle.Information)
    End Function
    Private Sub TextBox1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragEnter
        e.Effect = DragDropEffects.All
    End Sub
    Private Sub TextBox1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragDrop
        Dim xu = (e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop, True)(0))
        If getlast(xu.ToString.Split(".")).ToLower.Trim = "apk" Then
            TextBox1.Text = xu
            fapp = TextBox1.Text
            setinfo(getmf(fapp, xcmd, xmt))
        End If
    End Sub
    Function ls1(ByVal str As String, ByVal chr As String)
        Dim xi = ""
        For x = 0 To str.Split(chr).LongLength - 2
            If xi <> "" Then
                xi = xi + chr + str.Split(chr)(x)
            Else
                xi = str.Split(chr)(x)
            End If
        Next
        Return xi
    End Function
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Me.Width < 400 Then ''353
            Label3.Text = (ls1(TextBox1.Text, "\")).Trim
            If Label3.Text = "" Then
                Label3.Text = My.Computer.FileSystem.SpecialDirectories.Desktop
            End If
            addapk(Label3.Text)
            For x = 0 To ListBox1.Items.Count - 1
                If TextBox1.Text.Trim = Label3.Text + "\" + ListBox1.Items(x).ToString.Trim Then
                    ListBox1.SelectedItems.Add(ListBox1.Items(x))
                End If
            Next
            Me.Width = 622
        Else
            Me.Width = 353
        End If
        Me.Left = (My.Computer.Screen.WorkingArea.Width - Me.Width) / 2
    End Sub
    Function addapk(ByVal apkpath As String)
        On Error Resume Next
        ListBox1.Items.Clear()
        Dim r = My.Computer.FileSystem.GetFiles(apkpath, FileIO.SearchOption.SearchTopLevelOnly, "*.apk")
        For x = 0 To r.Count - 1
                ListBox1.Items.Add(r(x).Replace(Label3.Text + "\", ""))
        Next
    End Function
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.Text <> "" Then
            Shell("Rundll32.exe shell32.dll OpenAs_RunDLL " + Label3.Text + "\" + ListBox1.Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        On Error Resume Next
        If ListBox1.Text <> "" Then
            TextBox1.Text = Label3.Text + "\" + ListBox1.Text
            fapp = TextBox1.Text
            setinfo(getmf(fapp, xcmd, xmt))
            Label4.Text = CStr(CInt(My.Computer.FileSystem.GetFileInfo(Label3.Text + "\" + ListBox1.Text).Length / 1024)) + "KB"
        End If
    End Sub
    Public Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim fo As New FolderBrowserDialog
        With fo
            .SelectedPath = ""
            .Description = "Choose a path:"
            .ShowNewFolderButton = False
            .ShowDialog()
            If .SelectedPath <> "" Then
                Label3.Text = .SelectedPath
                addapk(Label3.Text)
            End If
        End With
    End Sub
    Function rnapk(ByVal fapk As String)
        Dim kl As String
        On Error Resume Next
        Dim sl = ""
        Dim ko = getinfo(getmf(fapk, xcmd, xmt), "label=") + " v" + getinfo(getmf(fapk, xcmd, xmt), "versionName=")
        'MsgBox(getmf(fapk))
        If ko.ToString.Trim = "v" Then
            kl = ""
            GoTo a
        End If
        sl = ko + ".apk"
        kl = sl.ToString.Trim.Replace("\", "_").Replace("/", "_").Replace("?", "_").Replace(":", "_").Replace(",", "_")
        If getlast(fapk.Split("\")).ToLower.Trim <> kl.ToString.ToLower.Trim Then
            Dim vk = 1
            While My.Computer.FileSystem.FileExists(ls1(fapk, "\") + "\" + sl.ToString.Trim.Replace("\", "_").Replace("/", "_").Replace("?", "_").Replace(":", "_").Replace(",", "_")) = True
                sl = ko + "(" + CStr(vk) + ")" + ".apk"
                vk = vk + 1
            End While
            kl = sl.ToString.Trim.Replace("\", "_").Replace("/", "_").Replace("?", "_").Replace(":", "_").Replace(",", "_")
            My.Computer.FileSystem.RenameFile(fapk, kl)
        End If
        'MsgBox(kl)
a:      Return kl
    End Function
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        '        On Error GoTo s
        If fapp = "" Then
            Button4_Click(Nothing, Nothing)
        Else
            Dim sl As String = rnapk(fapp)
            If sl.Trim <> "" Then
                MsgBox("Renamed " + vbCrLf + getlast(fapp.Split("\")) + vbCrLf + "To" + vbCrLf + sl)
                TextBox1.Text = ls1(fapp, "\") + "\" + sl
                fapp = TextBox1.Text
            End If
        End If
        Exit Sub
s:
    End Sub
    Public Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        If Label3.Text.Trim = "" Then
            Label3.Text = (ls1(TextBox1.Text, "\")).Trim
            Label3.Text = My.Computer.FileSystem.SpecialDirectories.Desktop
        End If
        addapk(Label3.Text)
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListBox1.SelectedIndices.Count > 0 Then
            ToolStripSeparator2.Visible = True
            SelectAllToolStripMenuItem.Visible = True
            DeleteToolStripMenuItem.Visible = True
            InstallToolStripMenuItem.Visible = True
            ToolStripSeparator2.Visible = True
            ReNameToolStripMenuItem.Visible = True
        Else
            InstallToolStripMenuItem.Visible = False
            ToolStripSeparator2.Visible = False
            SelectAllToolStripMenuItem.Visible = False
            DeleteToolStripMenuItem.Visible = False
            ToolStripSeparator2.Visible = False
            ReNameToolStripMenuItem.Visible = False
        End If
        If ListBox1.Items.Count > 0 Then
            ReNameAllToolStripMenuItem.Visible = True
        Else
            ReNameAllToolStripMenuItem.Visible = False
        End If
    End Sub
    Private Sub ReNameAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReNameAllToolStripMenuItem.Click
        If ListBox1.Items.Count <> 0 Then
            Me.Hide()
            NotifyIcon1.Icon = Me.Icon
            For x = 0 To ListBox1.Items.Count - 1
                With NotifyIcon1
                    If ("ReNaming " + ListBox1.Items(x).ToString).Length > 64 Then
                        .Text = "ReNaming " + ListBox1.Items(x).ToString.Trim.Remove(51) + "..."
                    Else
                        .Text = "ReNaming " + ListBox1.Items(x).ToString.Trim
                    End If
                    .BalloonTipText = "ReNaming " + ListBox1.Items(x).ToString
                    .BalloonTipIcon = ToolTipIcon.Info
                    .BalloonTipTitle = "Apk Manager"
                    .ShowBalloonTip(500)
                End With
                rnapk(Label3.Text + "\" + ListBox1.Items(x).ToString.Trim)
            Next
            Me.Show()
            NotifyIcon1.Icon = Nothing
            RefreshToolStripMenuItem_Click(sender, e)
            MsgBox("ReNamed All " + vbCrLf + Label3.Text)
        End If
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        On Error Resume Next
        If ListBox1.Text <> "" Then
            If MsgBox("Are you sure to delete " + ListBox1.Text + " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For x = 0 To ListBox1.SelectedItems.Count - 1
                    Kill(Label3.Text + "\" + ListBox1.SelectedItems(0).ToString)
                    If My.Computer.FileSystem.FileExists(Label3.Text + "\" + ListBox1.SelectedItems(0).ToString) = False Then
                        ListBox1.Items.Remove(ListBox1.SelectedItems(0).ToString)
                    End If
                Next
                MsgBox("Done!", MsgBoxStyle.Information)
            End If
        End If
        Exit Sub
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        On Error GoTo s
        If Viewz.TreeView1.Nodes(0).Text = Label3.Text And Viewz.ListView1.Items.Count <> 0 And Viewz.ListView1.Items.Count <> 0 Then
            'MsgBox("0")
            Me.Hide()
            Viewz.Show()
            'Me.Show()
        Else
s:
            'MsgBox("1")
            Me.Hide()
            'Viewz.ToolStripComboBox3.Items.Remove(Label3.Text)
            'Viewz.ToolStripComboBox3.Items.Insert(0, Label3.Text)
            'Viewz.ToolStripComboBox3.SelectedIndex = 0
            'Viewz.vs()
            If Label3.Text.Trim = "" Then
                Label3.Text = ls1(TextBox1.Text, "\")
            End If
            Viewz.RefreshToolStripMenuItem_Click(Nothing, Nothing)
            Viewz.Show()
            'Me.Show()
        End If
    End Sub
    Public Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ' MsgBox(sp)
        On Error Resume Next
        If fapp = "" Then
            Button4_Click(Nothing, Nothing)
        Else
            kwd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + (Date.Now.ToString.Replace("/", "_").Replace(":", "_").Trim) + "\"
            shellme("Loading...", My.Resources.x1 + za + My.Resources.x1 + " x -o" + My.Resources.x1 + kwd + My.Resources.x1 + " -y " + My.Resources.x1 + fapp + My.Resources.x1, xcmd, xmt)
            Filez.Text = "Apk Editor - " + fapp
            Filez.ffapk = fapp
            frefresh()
            Me.Hide()
            Filez.ShowDialog()
            Me.Show()
        End If
    End Sub
    Function frefresh()
        On Error Resume Next
        Filez.TreeView1.Nodes.Clear()
        Dim dd = My.Computer.FileSystem.GetDirectories(kwd)
        Dim df = My.Computer.FileSystem.GetFiles(kwd)
        For x = 0 To dd.Count - 1
            Filez.TreeView1.Nodes.Add("0", dd(x).Replace(kwd, ""), 0)
        Next
        For y = 0 To df.Count - 1
            Dim hc = getlast(df(y).Split("."))
            Dim kz = 1
            If hc.ToLower.Trim = "xml" Then
                kz = 2
            Else
                If hc = "png" Or hc = "jpg" Or hc = "bmp" Or hc = "gif" Or hc = "jpeg" Then
                    kz = 3
                Else
                    If hc = "mp3" Or hc = "wav" Or hc = "ogg" Then
                        kz = 4
                    Else
                        If hc = "txt" Then
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
            Filez.TreeView1.Nodes.Add(CStr(kz), df(y).Replace(kwd, ""), kz)
        Next
    End Function
    Public Function getPYChar(ByVal charx As String) As String
        On Error Resume Next
        Dim lChar As Long
        lChar = 65536 + Asc(charx)
        If (lChar >= 45217 And lChar <= 45252) Then getPYChar = "A"
        If (lChar >= 45253 And lChar <= 45760) Then getPYChar = "B"
        If (lChar >= 45761 And lChar <= 46317) Then getPYChar = "C"
        If (lChar >= 46318 And lChar <= 46825) Then getPYChar = "D"
        If (lChar >= 46826 And lChar <= 47009) Then getPYChar = "E"
        If (lChar >= 47010 And lChar <= 47296) Then getPYChar = "F"
        If (lChar >= 47297 And lChar <= 47613) Then getPYChar = "G"
        If (lChar >= 47614 And lChar <= 48118) Then getPYChar = "H"
        If (lChar >= 48119 And lChar <= 49061) Then getPYChar = "J"
        If (lChar >= 49062 And lChar <= 49323) Then getPYChar = "K"
        If (lChar >= 49324 And lChar <= 49895) Then getPYChar = "L"
        If (lChar >= 49896 And lChar <= 50370) Then getPYChar = "M"
        If (lChar >= 50371 And lChar <= 50613) Then getPYChar = "N"
        If (lChar >= 50614 And lChar <= 50621) Then getPYChar = "O"
        If (lChar >= 50622 And lChar <= 50905) Then getPYChar = "P"
        If (lChar >= 50906 And lChar <= 51386) Then getPYChar = "Q"
        If (lChar >= 51387 And lChar <= 51445) Then getPYChar = "R"
        If (lChar >= 51446 And lChar <= 52217) Then getPYChar = "S"
        If (lChar >= 52218 And lChar <= 52697) Then getPYChar = "T"
        If (lChar >= 52698 And lChar <= 52979) Then getPYChar = "W"
        If (lChar >= 52980 And lChar <= 53688) Then getPYChar = "X"
        If (lChar >= 53689 And lChar <= 54480) Then getPYChar = "Y"
        If (lChar >= 54481 And lChar <= 55289) Then getPYChar = "Z"
    End Function
    Public Function getPY(ByVal str As String) As String
        On Error Resume Next
        getPY = ""
        For i = 0 To Len(str) - 1
            Dim xq = getPYChar(Mid(str, i + 1, 1))
            If xq = "" Then
                If Asc(Mid(str, i + 1, 1)) = Asc("-") Or Asc(Mid(str, i + 1, 1)) = 46 Or (Asc(Mid(str, i + 1, 1)) >= 65 And Asc(Mid(str, i + 1, 1)) <= 90) Or (Asc(Mid(str, i + 1, 1)) >= 97 And Asc(Mid(str, i + 1, 1)) <= 122) Or (Asc(Mid(str, i + 1, 1)) >= 48 And Asc(Mid(str, i + 1, 1)) <= 57) Then
                    getPY = getPY & Mid(str, i + 1, 1)
                Else
                    getPY = getPY & "_"
                End If
            Else
                getPY = getPY & xq
            End If
        Next
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Dim mmoc As String
    Dim mcmd As String
    Dim mmt As String
    Public doii As Integer
    Dim mtx As String = ""
    Public mfo As String
    Function shellme(ByVal info As String, ByVal comm As String, ByVal tcmd As String, ByVal tmt As String)
        'MsgBox(tcmd)
        'MsgBox(tcmd)
        'Kill(tcmd)
        'Kill(tmt)
        doii = 0
        If (info).Trim <> "" Then
            mmoc = comm
            mcmd = tcmd
            mmt = tmt
            doii = 1
            mtx = ""
            mfo = info
            With NotifyIcon2
                .Icon = FileD.Icon
                If (info.ToString).Length > 64 Then
                    .Text = info.ToString.Trim.Remove(51) + "..."
                Else
                    .Text = info.ToString.Trim
                End If
                .ContextMenuStrip = Me.ContextMenuStrip2
                .BalloonTipText = info.ToString
                .BalloonTipIcon = ToolTipIcon.Info
                .BalloonTipTitle = "Processing..."
                .ShowBalloonTip(50000)
                BackgroundWorker2.RunWorkerAsync()
                Wait.Text = info
                Wait.runn(-1)
            End With
        Else
            My.Computer.FileSystem.WriteAllText(tcmd, comm + " >" + My.Resources.x1 + tmt + My.Resources.x1, False, System.Text.Encoding.Default)
            'MsgBox(tmt)
            Shell(tcmd, 0, True)
            mtx = My.Computer.FileSystem.ReadAllText(tmt)
        End If
        NotifyIcon2.Icon = Nothing
        Return mtx
    End Function
    Public Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        On Error Resume Next
        'If state().ToString.Trim = "device" Then
        Me.Hide()
        FileD.ShowDialog()
        Me.Show()
        'Else
        '    MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
        'End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ui(e.Argument, e.Result)
    End Sub
    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'MsgBox(Me.Text)
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.Text = "Apk Manager - " + stauts
        If stauts = "unknown" Then
            Install.Close()
            'MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
        End If
    End Sub
    Function ui(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As Long
        On Error Resume Next
        state()
    End Function
    Private Sub InstallToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallToolStripMenuItem.Click
        'If state().ToString.Trim = "device" Then
        Install.ListView1.Items.Clear()
        Install.ImageList1.Images.Clear()
        For x = 0 To ListBox1.SelectedItems.Count - 1
            Install.fjar = 0
            addxapk(Label3.Text + "\" + ListBox1.SelectedItems(x))
        Next
        Install.ShowDialog()
        'Else
        'MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
        'End If
    End Sub
    Private Sub ReNameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReNameToolStripMenuItem.Click
        If ListBox1.SelectedItems.Count <> 0 Then
            If MsgBox("Do you want to ReName these Files ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Hide()
                NotifyIcon1.Icon = Me.Icon
                For x = 0 To ListBox1.SelectedItems.Count - 1
                    With NotifyIcon1
                        If ("ReNaming " + ListBox1.SelectedItems(x).ToString).Length > 64 Then
                            .Text = "ReNaming " + ListBox1.SelectedItems(x).ToString.Remove(51) + "..."
                        Else
                            .Text = "ReNaming " + ListBox1.SelectedItems(x).ToString
                        End If
                        .BalloonTipText = "ReNaming " + ListBox1.SelectedItems(x).ToString
                        .BalloonTipIcon = ToolTipIcon.Info
                        .BalloonTipTitle = "Apk Manager"
                        .ShowBalloonTip(500)
                    End With
                    rnapk(Label3.Text + "\" + ListBox1.SelectedItems(x).ToString.Trim)
                Next
                Me.Show()
                NotifyIcon1.Icon = Nothing
                RefreshToolStripMenuItem_Click(sender, e)
                MsgBox("ReNamed!", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        Install.ListView1.Items.Clear()
        Install.ImageList1.Images.Clear()
        For x = 0 To ListBox1.Items.Count - 1
            Install.fjar = 0
            addxapk(Label3.Text + "\" + ListBox1.Items(x))
        Next
        Install.ShowDialog()
    End Sub
    'Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
    '    If Me.Width < 600 Then ''353
    '        ListBox1.Height = 474
    '        Button8.Top = 186
    '        Label4.Top = 186
    '        Me.Height = 526
    '    Else
    '        ListBox1.Height = 148
    '        Button8.Top = 186
    '        Label4.Top = 186
    '        Me.Height = 236
    '    End If
    '    Me.Top = (My.Computer.Screen.WorkingArea.Height - Me.Height) / 2
    'End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If TextBox2.Visible = False Then
            PictureBox2.Visible = False
            TextBox2.Visible = True
        Else
            PictureBox2.Visible = True
            TextBox2.Visible = False
        End If
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Shell("wscript " + My.Resources.x1 + My.Application.Info.DirectoryPath + "\Tools\QQ.WSF" + My.Resources.x1, 1, False)
    End Sub
    Public Sub CancleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancleToolStripMenuItem.Click
        On Error Resume Next
        If MsgBox("Do you want to Cancle it ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            BackgroundWorker2.CancelAsync()
            If mfo <> "Loading..." And mfo <> "Saving..." Then
                If mfo = "Erasing Recovery..." Or mfo = "Flashing Recovery..." Or mfo = "Updating..." Or mfo = "Erasing userdata And cache..." Or mfo = "Rebooting..." Or mfo = "Reboot In Bootloader Mode" Then
                    MsgBox("This is A Dangerous Action And Can't Be Cancle!!!", MsgBoxStyle.Information)
                    GoTo s
                Else
                    If mfo = "Downloading..." Then
                        Dim myProcesses() As Process
                        Dim myProcess As Process
                        myProcesses = Process.GetProcessesByName("fastboot.exe")
                        For Each myProcess In myProcesses
                            myProcess.Kill()
                        Next
                    Else
                        Shell(My.Resources.x1 + adb + My.Resources.x1 + " kill-server", 0, True)
                        Shell(My.Resources.x1 + adb + My.Resources.x1 + " start-server", 0, True)
                    End If
                End If
            Else
                Dim myProcesses() As Process
                Dim myProcess As Process
                myProcesses = Process.GetProcessesByName("7za.exe")
                For Each myProcess In myProcesses
                    myProcess.Kill()
                Next
            End If
        doii = 0
        End If
        Exit Sub
s:
    End Sub
    Function ul(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As Long
        On Error Resume Next
        My.Computer.FileSystem.WriteAllText(mcmd, mmoc + " >" + My.Resources.x1 + mmt + My.Resources.x1, False, System.Text.Encoding.Default)
        'MsgBox(tmt)
        Shell(mcmd, 0, True)
        mtx = My.Computer.FileSystem.ReadAllText(mmt)
    End Function
    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        ul(e.Argument, e.Result)
    End Sub
    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        doii = 0
    End Sub
    Function getlast(ByVal im As Array)
        Dim dx = im
        Dim dy = dx.LongLength
        Return dx(dy - 1)
    End Function
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Hide()
        AboutBox.ShowDialog()
        Shell(My.Application.Info.DirectoryPath + "\Tools\About.exe" + " " + CStr(CInt((New Random).Next(0, 3))), 1, True)
        Viewz.ToolStripButton20_Click(Nothing, Nothing)
        Me.Show()
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.Hide()
        Apps.ShowDialog()
        Me.Show()
    End Sub
    Private Sub InstallToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallToolStripMenuItem1.Click
        Button3_Click(Nothing, Nothing)
    End Sub
    Private Sub AppsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppsToolStripMenuItem.Click
        Button13_Click(Nothing, Nothing)
    End Sub
    Private Sub ToolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsToolStripMenuItem.Click
        Me.Hide()
        Tools.ShowDialog()
        Me.Show()
    End Sub
    Private Sub DevicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevicesToolStripMenuItem.Click
        Me.Hide()
        DC.ShowDialog()
        Me.Show()
    End Sub
    Private Sub ExplorerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExplorerToolStripMenuItem.Click
        Label3.Text = (ls1(TextBox1.Text, "\")).Trim
        Button8_Click(Nothing, Nothing)
    End Sub
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Button12_Click(Nothing, Nothing)
    End Sub
    Private Sub LogCatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogCatToolStripMenuItem.Click
        On Error Resume Next
        Shell(My.Resources.x1 + adb + My.Resources.x1 + " " + mlh + " logcat", AppWinStyle.NormalFocus, False)
    End Sub
    Private Sub FtpModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FtpModeToolStripMenuItem.Click
        Ftp.ShowDialog()
    End Sub
    Private Sub ADBModToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADBModToolStripMenuItem.Click
        ChDir(My.Application.Info.DirectoryPath + "\Tools")
        Shell("cmd -k" + " " + My.Resources.x1 + adb + My.Resources.x1, 1, False)
        ChDir(My.Application.Info.DirectoryPath)
    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Viewz.ToolStripButton20_Click(Nothing, Nothing)
    End Sub
End Class