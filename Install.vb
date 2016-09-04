Public Class Install
    Dim tpl = ""
    Dim libb = My.Computer.FileSystem.SpecialDirectories.Temp + "\ALib"
    Dim odex = My.Computer.FileSystem.SpecialDirectories.Temp + "\ODEX"
    Dim insapp = Main.fapp
    Dim inslog = ""
    Dim innums As Integer = 0
    Dim innum As Integer = 0
    Dim insp As Integer = 0
    Dim lx As New ListBox
    Dim dx As New ListBox
    Dim ck1
    Dim ck2
    Dim ck3
    Dim ck4
    Dim co1
    Dim co2
    Dim co3
    Dim co2t
    Dim co3t
    Dim numv
    Dim fs
    Dim imagex As New ImageList
    Dim ist As String
    Dim xst As String
    Function ins(ByVal fsx As Integer)
        'On Error Resume Next
        If ListView1.Items.Count > 0 Then
            Dim kx As String
            If ListView1.Items.Count = 1 Then
                kx = "Are you sure to install " + ListView1.Items(0).Text + " ?"
            Else
                kx = "Do you want to Install These Apps to your Android Drive ? "
            End If
            PictureBox1.Image = Nothing
            Label10.Text = ""
            Label9.Text = ""
            ProgressBar1.Value = 0
            ProgressBar2.Value = 0
            If MsgBox(kx, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If Main.state().ToString.Trim = "device" Then
                Else
                    Main.mlh = ""
                    MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
                    If DC.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        mlh = Main.mlh
                        xmmtt = Main.xmmtt
                        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
                        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
                        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
                        libb = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\ALib"
                        odex = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\ODEX"
                    Else
                        GoTo c
                    End If
                End If
                'MsgBox("")
                lx.Items.Clear()
                innums = ListView1.Items.Count
                ListView1.Items(0).EnsureVisible()
                ListView1.SelectedIndices.Clear()
                ListView1.SelectedIndices.Add(0)
                snw = 0
                insp = 0
                inslog = "Result:"
                dx.Items.Clear()
                ck1 = CheckBox1.Checked
                ck2 = CheckBox2.Checked
                ck3 = CheckBox3.Checked
                ck4 = CheckBox4.Checked
                co1 = ComboBox1.SelectedIndex
                co2 = ComboBox2.SelectedIndex
                co2t = ComboBox2.Text
                co3 = ComboBox3.SelectedIndex
                co3t = ComboBox3.Text
                numv = NumericUpDown1.Value
                fs = fsx
                For x = 0 To innums - 1
                    lx.Items.Add(ListView1.Items(x).SubItems(3).Text)
                Next
                imagex.ColorDepth = imagex.ColorDepth
                imagex.ImageSize = ImageList1.ImageSize
                imagex.Images.Clear()
                For x = 0 To ListView1.Items.Count - 1
                    imagex.Images.Add(ImageList1.Images(ListView1.Items(x).ImageIndex))
                Next

                'MsgBox("")
                'For y = 0 To lx.Items.Count - 1
                '    MsgBox(lx.Items(y))
                'Next
                For x = 0 To ListView1.Items.Count - 1
                    ListView1.Items(x).SubItems(4).Text = "None"
                Next
                If fs = 2 Or fs = 3 Then
                    Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + Main.dexopt + My.Resources.x1 + " " + "/data/local/tmp/dexopt-wrapper" + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell chmod 777 " + "/data/local/tmp/dexopt-wrapper", xcmd, xmt)
                End If
                ListView1.Enabled = False
                Panel3.Visible = True
                Timer1.Enabled = True
                cx = 0
                If fsx = 0 Then
                    If CheckBox1.Checked = True Then
                        ist = "SDCard"
                    Else
                        ist = "Data/App"
                    End If
                    xst = "Nomal_Install"
                Else
                    ist = ComboBox2.Text
                    If fsx = 1 Then

                        xst = "Lib_Install"
                    Else
                        If fsx = 2 Then
                            xst = "Odex_Install"
                        Else

                            If fsx = 3 Then
                                xst = "Lite_Install"
                            Else
                                If fsx = 4 Then
                                    xst = "Push_Install"
                                End If
                                End If
                        End If
                    End If
                End If
                Label12.Text = xst
                Label14.Text = ist
                If fjar = 1 Then
                    Label12.Text = "Odex_Framework"
                    Label14.Text = "/System/framework"
                End If
                    BackgroundWorker1.RunWorkerAsync()
                    '    For x = 0 To ListView1.Items.Count - 1
                    '        innum = x
                    '        insp = 0
                    '        insapp = lx(x)
                    '        'MsgBox(insapp)
                    '        If fs = 0 Then
                    '            inslog = inslog + vbCrLf + "----------------------" + vbCrLf + insapp + vbCrLf + ni()
                    '        Else
                    '            If fs = 1 Then
                    '                inslog = inslog + vbCrLf + "----------------------" + vbCrLf + insapp + vbCrLf + li()
                    '            Else
                    '                If fs = 2 Then
                    '                    inslog = inslog + vbCrLf + "----------------------" + vbCrLf + insapp + vbCrLf + oi()
                    '                Else
                    '                    If fs = 3 Then
                    '                        inslog = inslog + vbCrLf + "----------------------" + vbCrLf + insapp + vbCrLf + lii()
                    '                    Else
                    '                        If fs = 4 Then
                    '                            inslog = inslog + vbCrLf + "----------------------" + vbCrLf + insapp + vbCrLf + pi()
                    '                        End If
                    '                    End If
                    '                End If
                    '            End If
                    '        End If
                    '    Next
                    '    MsgBox(inslog)
                End If
            Else
                MsgBox("Please Choose Some App To Install!", MsgBoxStyle.Information)
                AddToolStripMenuItem_Click(Nothing, Nothing)
            End If
            Return Nothing
            Exit Function
c:
            mlh = Main.mlh
            Me.Close()
            Return Nothing
    End Function
    Dim cx As Integer
    Function ui(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs)
        On Error Resume Next
        For x = 0 To innums - 1
            If cx = 1 Then
                GoTo d
            End If
            innum = x
            insp = 0
            insapp = lx.Items(x)
            'For d = 0 To lx.Count - 1
            '    MsgBox(lx(d))
            'Next
            'MsgBox(insapp)
            If fs = 0 Then
                Dim vv = ni()
                inslog = inslog + vbCrLf + "----------------------" + vbCrLf + insapp + vbCrLf + vv
                dx.Items.Add(vv)
            Else
                If fs = 1 Then
                    Dim vv = li()
                    inslog = inslog + vbCrLf + "----------------------" + vbCrLf + insapp + vbCrLf + vv
                    dx.Items.Add(vv)
                Else
                    If fs = 2 Then
                        Dim vv = oi()
                        inslog = inslog + vbCrLf + "----------------------" + vbCrLf + insapp + vbCrLf + vv
                        dx.Items.Add(vv)
                    Else
                        If fs = 3 Then
                            Dim vv = lii()
                            inslog = inslog + vbCrLf + "----------------------" + vbCrLf + insapp + vbCrLf + vv
                            dx.Items.Add(vv)
                        Else
                            If fs = 4 Then
                                Dim vv = pi()
                                inslog = inslog + vbCrLf + "----------------------" + vbCrLf + insapp + vbCrLf + vv
                                dx.Items.Add(vv)
                            End If
                        End If
                    End If
                End If
            End If
        Next
d:
    End Function
    Function pi()
        Return pis(insapp)
    End Function
    Function ni()
        If ck1 = True Then
            Return getinstall(insapp, 1)
        Else
            Return getinstall(insapp, 0)
        End If
    End Function
    Function li()
        On Error Resume Next
        Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " root", 0, True)
        If innums > 1 Then
            If ck4 = True Then
                GoTo u
            Else
                If My.Computer.FileSystem.DirectoryExists(Main.ls1(insapp, "\") + "\lib") = True Then
                    GoTo k
                Else
                    GoTo u
                End If
            End If
        End If
        If My.Computer.FileSystem.DirectoryExists(Main.ls1(insapp, "\") + "\lib") = True Then
            If My.Computer.FileSystem.GetFiles(Main.ls1(insapp, "\") + "\lib", FileIO.SearchOption.SearchAllSubDirectories, "*").Count <> 0 Then
                Dim r = MsgBox("Do you want to take Lib from Apk or Local ?" + vbCrLf + "Y - Apk" + vbCrLf + "N - Local" + vbCrLf + "C - Cancle", MsgBoxStyle.YesNoCancel)
                If r = MsgBoxResult.Yes Then
                    GoTo u
                Else
k:                  If co2 = 0 Then
                        lbi(insapp, Main.ls1(insapp, "\") + "\lib\" + co3t, 0, 0)
                    Else
                        Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw /system ", 0, True)
                        lbi(insapp, Main.ls1(insapp, "\") + "\lib\" + co3t, 1, 0)
                    End If
                    Return ("Done!")
                End If
            Else
                GoTo u
            End If
        Else
            GoTo u
        End If
        Exit Function
u:
        Dim tx As String = Main.shellme("", My.Resources.x1 + Main.za + My.Resources.x1 + " l " + My.Resources.x1 + insapp + My.Resources.x1, xcmd, xmt)
        If tx.Length <> tx.Replace("classes.dex", "").Length Then
            If tx.Length <> tx.Replace(" lib" + "\", "").Length Then
                Dim qx = lbs(insapp, 1, 0)
                If co2 = 0 Then
                    lbi(qx, libb + "\lib", 0, 1)
                Else
                    Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw /system ", xcmd, xmt)
                    lbi(qx, libb + "\lib", 1, 1)
                End If
                Return ("Done!")
            Else
                Return ("This App has not Lib!!!" + vbCrLf + "Please Choose Other Way To Install!")
            End If
        Else
            Return ("This App has not Dex!!!" + vbCrLf + "Please Choose Other Way To Install!")
        End If
    End Function
    Function oi()
        Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " root", xcmd, xmt)
        Dim tx As String = Main.shellme("", My.Resources.x1 + Main.za + My.Resources.x1 + " l " + My.Resources.x1 + insapp + My.Resources.x1, xcmd, xmt)
        ' MsgBox(bx)
        If tx.Length <> tx.Replace("classes.dex", "").Length Then
            Dim bx = obs(insapp, 1, 0)
            If tx.Length <> tx.Replace("lib" + "\", "").Length Then
                GoTo x
            End If
            'MsgBox(tx)
            If co2 = 0 Then
                obi(insapp, bx, 0, 1, 0)
            Else
                Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw /system ", 0, True)
                obi(insapp, bx, 1, 1, 0)
            End If
            Return ("Done!")
        Else
            If fjar = 1 Then
                GoTo d
            End If
            If ListView1.Items.Count > 1 Then
                If ck4 = True Then
                    GoTo d
                Else
                    If My.Computer.FileSystem.FileExists(Main.ls1(insapp, ".") + ".odex") = True Then
                        GoTo k
                    Else
                        GoTo d
                    End If
                End If
            End If
            If My.Computer.FileSystem.FileExists(Main.ls1(insapp, ".") + ".odex") = True Then
                Dim r = MsgBox("Do you want to take Odex from Local ?", MsgBoxStyle.YesNo)
                If r = MsgBoxResult.Yes Then
k:
                    Dim re = ""
                    If co1 = 0 Then
                        Dim tp = Main.getinfo(Main.getmf(insapp, xcmd, xmt), "label=")
                        re = Main.getPY(tp.Replace(" ", "_")) + ".apk"
                    Else
                        If co1 = 2 Then
                            re = Main.getPY(Main.getlast(insapp.ToString.Split("\")).Replace(" ", "_"))
                        Else
                            If co1 = 1 Then
                                Dim tp = Main.getinfo(Main.getmf(insapp, xcmd, xmt), "name=")
                                re = tp + "-1.apk"
                            End If
                        End If
                    End If
                    'MsgBox(re)
                    'My.Computer.Clipboard.SetText(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " push " + My.Resources.x1 + insapp + My.Resources.x1 + " " + "/data/app/" + re + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " push " + My.Resources.x1 + Main.ls1(insapp, ".") + ".odex" + My.Resources.x1 + " " + "/data/app/" + Main.ls1(re, ".") + ".odex")
                    If ck2 = True Then
                        Main.shellme("", (My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell pm uninstall -k " + Main.getinfo(Main.getmf(insapp, xcmd, xmt), "name=")), xcmd, xmt)
                    Else
                        Main.shellme("", (My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " uninstall " + Main.getinfo(Main.getmf(insapp, xcmd, xmt), "name=")), xcmd, xmt)
                    End If
                    If co2 = 1 Then
                        Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw /system ", xcmd, xmt)
                    End If
                    Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + insapp + My.Resources.x1 + " " + "/" + co2t + "/" + re + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + Main.ls1(insapp, ".") + ".odex" + My.Resources.x1 + " " + "/" + co2t + "/" + Main.ls1(re, ".") + ".odex", xcmd, xmt)
                    Return ("Done!")
                Else
                    Return ("This App has not Dex!!!" + vbCrLf + "Please Choose Other Way To Install!")
                End If
            Else
d:              Return ("This App has not Dex!!!" + vbCrLf + "Please Choose Other Way To Install!")
            End If
        End If
        Exit Function
x:      Return ("This App has Lib!!!" + vbCrLf + "Please Choose Other Way To Install!")
    End Function
    Function lii()
        Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " root", 0, True)
        On Error Resume Next
        Dim tx As String = Main.shellme("", My.Resources.x1 + Main.za + My.Resources.x1 + " l " + My.Resources.x1 + insapp + My.Resources.x1, xcmd, xmt)
        If tx.Length <> tx.Replace(" lib" + "\", "").Length Then
            Dim qx = lbs(insapp, 0, 1)
            If co2 = 0 Then
                lbi(qx, libb + "\lib", 0, 1)
            Else
                Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o mount -o remount,rw /system,rw /system ", 0, True)
                lbi(qx, libb + "\lib", 1, 1)
            End If
        Else
            If tx.Length <> tx.Replace("classes.dex", "").Length Then
                lbs(insapp, 0, 1)
            Else
                GoTo k
            End If
        End If
        My.Computer.FileSystem.DeleteDirectory(libb, FileIO.DeleteDirectoryOption.DeleteAllContents)
        tx = Main.shellme("", My.Resources.x1 + Main.za + My.Resources.x1 + " l " + My.Resources.x1 + insapp + My.Resources.x1, xcmd, xmt)
        If tx.Length <> tx.Replace("classes.dex", "").Length Then
            Dim bx = obs(insapp, 1, 1)
            If co2 = 0 Then
                obi(insapp, bx, 0, 1, 1)
            Else
                Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw /system ", 0, True)
                obi(insapp, bx, 1, 1, 1)
            End If
            Return ("Done!")
        Else
k:          Return ("This App has not Dex!!!" + vbCrLf + "Please Choose Other Way To Install!")
        End If
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ins(2)
    End Sub
    Function pis(ByVal fapk As String)
        On Error Resume Next
        Dim re = ""
        If co1 = 0 Then
            Dim tp = Main.getinfo(Main.getmf(fapk, xcmd, xmt), "label=")
            re = Main.getPY(tp.Replace(" ", "_")) + ".apk"
        Else
            If co1 = 2 Then
s:              re = Main.getPY(Main.getlast(fapk.Split("\")).Replace(" ", "_"))
            Else
                If co1 = 1 Then
                    Dim tp = Main.getinfo(Main.getmf(fapk, xcmd, xmt), "name=")
                    re = tp + "-1.apk"
                End If
            End If
        End If
        If re.ToString.Trim = "" Then
            GoTo s
        End If
        insp = 30
        If fjar = 1 Then
            GoTo a
        End If
        If ck2 = True Then
            Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell pm uninstall -k " + Main.getinfo(Main.getmf(fapk, xcmd, xmt), "name="), 0, True)
        Else
            Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " uninstall " + Main.getinfo(Main.getmf(fapk, xcmd, xmt), "name="), 0, True)
        End If
        insp = 60
a:      Dim ml As String
        If fjar = 1 Then
            Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o mount -o remount,rw /system,rw /system ", 0, True)
            ml = "/system/framework/"
            GoTo b
        End If
        If co2 = 0 Then
            ml = "/data/app/"
        Else
            Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o mount -o remount,rw /system,rw /system ", 0, True)
            ml = "/system/app/"
        End If
b:      insp = 80
        Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + fapk + My.Resources.x1 + " " + ml + re, xcmd, xmt)
        insp = 100
        Return "Done!"
    End Function
    Function obs(ByVal fapk As String, ByVal don As Integer, ByVal tpp As Integer)
        On Error Resume Next
        Main.shellme("", (My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " root"), xcmd, xmt)
        My.Computer.FileSystem.DeleteDirectory(odex, FileIO.DeleteDirectoryOption.DeleteAllContents)
        MkDir(odex)
        insp = 30
        Dim kwd
        If tpp = 1 Then
            kwd = tpl
        Else
            kwd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + (Date.Now.ToString.Replace("/", "_").Replace(":", "_").Trim) + "\"
        End If
        insp = 40
        Main.shellme("", My.Resources.x1 + Main.za + My.Resources.x1 + " x -o" + My.Resources.x1 + kwd + My.Resources.x1 + " -y " + My.Resources.x1 + fapk + My.Resources.x1, xcmd, xmt)
        If My.Computer.FileSystem.FileExists(kwd + "classes.dex") = False Then
            GoTo q
        End If
        Kill(kwd + "classes.dex")
        If don = 1 Then
            My.Computer.FileSystem.DeleteDirectory(kwd + "\" + "lib", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        Main.shellme("", My.Resources.x1 + Main.za + My.Resources.x1 + " a -tzip " + My.Resources.x1 + odex + "\odex.apk" + My.Resources.x1 + " " + My.Resources.x1 + kwd + "*" + My.Resources.x1 + " -mx" + CStr(mx), xcmd, xmt)
        'MsgBox(ComboBox4.SelectedIndex)
        'MsgBox(mx)
        My.Computer.FileSystem.DeleteDirectory(kwd, FileIO.DeleteDirectoryOption.DeleteAllContents)
        insp = 50
        Return odex + "\odex.apk"
        Exit Function
q:      Return "0"
    End Function
    Public fjar = 0
    Function obi(ByVal fapk As String, ByVal oapk As String, ByVal sod As Integer, ByVal don As Integer, ByVal kz As Integer)
        Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " root", 0, True)
        If fapk.Trim <> "" Then
            On Error Resume Next
            Dim ml As String
            If fjar = 1 Then
                ml = "/system/framework/"
                GoTo c
            End If
            If sod = 0 Then
                ml = "/data/app/"
            Else
                ml = "/system/app/"
            End If
            'Dim p1() As Process = Process.GetProcesses()
            'Dim Id As Integer = 1000
            'Dim isExist As Boolean = False
            'For i As Integer = 0 To p1.Length - 1
            '    If p1(i).ProcessName = "adb" Then
            '        MsgBox(p1(i).ProcessName)
            '        p1(i).Close()
            '    End If
            'Next
c:          insp = 50
            Dim re = ""
            If fjar = 1 Then
                re = Main.getPY(Main.getlast(fapk.Split("\")).Replace(" ", "_"))
                GoTo g
            End If
            If co1 = 0 Then
                Dim tp = Main.getinfo(Main.getmf(fapk, xcmd, xmt), "label=")
                re = Main.getPY(tp.Replace(" ", "_")) + ".apk"
            Else
                If co1 = 2 Then
s:                  re = Main.getPY(Main.getlast(fapk.Split("\")).Replace(" ", "_"))
                Else
                    If co1 = 1 Then
                        Dim tp = Main.getinfo(Main.getmf(fapk, xcmd, xmt), "name=")
                        re = tp + "-1.apk"
                    End If
                End If
            End If
            If re.ToString.Trim = "" Then
                GoTo s
            End If
            'MsgBox(re)
            If kz = 0 Then
                If ck2 = True Then
                    Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell pm uninstall -k " + Main.getinfo(Main.getmf(fapk, xcmd, xmt), "name="), xcmd, xmt)
                Else
                    Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " uninstall " + Main.getinfo(Main.getmf(fapk, xcmd, xmt), "name="), xcmd, xmt)
                End If
g:              Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + Main.ls1(ml + re, ".") + ".odex", 0, True)
            End If
            insp = 60
            ' MsgBox(re)
            '  MsgBox(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " push " + My.Resources.x1 + Main.dexopt + My.Resources.x1 + " " + "/data/local/tmp/dexopt-wrapper" + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " push " + My.Resources.x1 + fapk + My.Resources.x1 + " " + ml + fapk.Split("\")(fapk.Split("\").Count - 1).Replace(" ", "_") + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell " + "/data/local/tmp/" + "dexopt-wrapper " + ml + fapk.Split("\")(fapk.Split("\").Count - 1).Replace(" ", "_") + " " + Main.ls1(ml + fapk.Split("\")(fapk.Split("\").Count - 1).Replace(" ", "_"), ".") + ".odex" + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " push " + My.Resources.x1 + oapk + My.Resources.x1 + " " + ml + fapk.Split("\")(fapk.Split("\").Count - 1).Replace(" ", "_"))
            If fjar = 1 Then
                Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + fapk + My.Resources.x1 + " " + ml + re + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell " + "/data/local/tmp/" + "dexopt-wrapper " + ml + re + " " + Main.ls1(ml + re, ".") + ".odex" + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + oapk + My.Resources.x1 + " " + ml + re + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + "/data/dalvik-cache/" + "system@framework@" + re + "@classes.dex", xcmd, xmt)
                GoTo v
            End If
            Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + fapk + My.Resources.x1 + " " + ml + re + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell " + "/data/local/tmp/" + "dexopt-wrapper " + ml + re + " " + Main.ls1(ml + re, ".") + ".odex" + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + oapk + My.Resources.x1 + " " + ml + re + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + "/data/dalvik-cache/" + "data@app@" + re + "@classes.dex", xcmd, xmt)
            'Dim tx As String = My.Computer.FileSystem.ReadAllText(tmt)
v:          insp = 80
            'Kill(tmt)
            'MsgBox(tx)
            If don = 1 Then
                Kill(oapk)
                My.Computer.FileSystem.DeleteDirectory(odex, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            insp = 100
            Return ""
        End If
    End Function
    Function lbs(ByVal fapk As String, ByVal don As Integer, ByVal tpp As Integer)
        Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " root", 0, True)
        On Error Resume Next
        My.Computer.FileSystem.DeleteDirectory(libb, FileIO.DeleteDirectoryOption.DeleteAllContents)
        MkDir(libb)
        insp = 30
        Dim kwd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + (Date.Now.ToString.Replace("/", "_").Replace(":", "_").Trim) + "\"
        If tpp = 1 Then
            tpl = kwd
        Else
            tpl = ""
        End If
        Main.shellme("", My.Resources.x1 + Main.za + My.Resources.x1 + " x -o" + My.Resources.x1 + kwd + My.Resources.x1 + " -y " + My.Resources.x1 + fapk + My.Resources.x1, xcmd, xmt)
        insp = 40
        My.Computer.FileSystem.DeleteDirectory(libb + "\lib", FileIO.DeleteDirectoryOption.DeleteAllContents)
        If (co3t.ToString.Trim = ComboBox3.Items(1).ToString.Trim And My.Computer.FileSystem.DirectoryExists(kwd + "lib" + "\" + ComboBox3.Items(1).ToString.Trim) = False) Or (co3t.ToString.Trim = ComboBox3.Items(2).ToString.Trim And My.Computer.FileSystem.DirectoryExists(kwd + "lib" + "\" + ComboBox3.Items(2).ToString.Trim) = False) And My.Computer.FileSystem.DirectoryExists(kwd + "lib" + "\" + ComboBox3.Items(0).ToString.Trim) = True Then
            My.Computer.FileSystem.MoveDirectory(kwd + "lib" + "\" + ComboBox3.Items(0).ToString.Trim, libb + "\lib", True)
        Else
            My.Computer.FileSystem.MoveDirectory(kwd + "lib" + "\" + co3t, libb + "\lib", True)
        End If
        My.Computer.FileSystem.DeleteDirectory(kwd + "lib", FileIO.DeleteDirectoryOption.DeleteAllContents)
        Main.shellme("", My.Resources.x1 + Main.za + My.Resources.x1 + " a -tzip " + My.Resources.x1 + libb + "\" + Main.getlast(fapk.Split("\")).Replace(" ", "_") + My.Resources.x1 + " " + My.Resources.x1 + kwd + "*" + My.Resources.x1 + " -mx" + CStr(mx), xcmd, xmt)
        If don = 1 Then
            My.Computer.FileSystem.DeleteDirectory(kwd, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        insp = 50
        Return libb + "\" + Main.getlast(fapk.Split("\")).Replace(" ", "_")
    End Function
    Function lbi(ByVal oapk As String, ByVal lb As String, ByVal sod As String, ByVal don As Integer)
        'Shell(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " pull " + "/data/data/" + la + " " + My.Resources.x1 + "C:\123" + My.Resources.x1, 0, True)
        Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " root", 0, True)
        If oapk.Trim <> "" Then
            If My.Computer.FileSystem.DirectoryExists(lb) = True Then
                On Error Resume Next
                Dim ml As String
                If sod = 0 Then
                    ml = "/data/app/"
                Else
                    ml = "/system/app/"
                End If
                Dim la = Main.getinfo(Main.getmf(oapk, xcmd, xmt), "name=")
                'My.Computer.Clipboard.SetText(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " push " + My.Resources.x1 + lb + My.Resources.x1 + " " + "/data/data/" + la + "/lib")
                'MsgBox(la)
                'MsgBox(lb)
                'MsgBox(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " push " + My.Resources.x1 + oapk + My.Resources.x1 + " " + ml + oapk.Split("\")(oapk.Split("\").Count - 1).Replace(" ", "_") + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell " + "busybox " + "mkdir /data/data/" + la + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " push " + My.Resources.x1 + lb + My.Resources.x1 + " " + "/data/data/" + la + "/lib" + " >" + tmt)
                Dim re = ""
                If co1 = 0 Then
                    Dim tp = Main.getinfo(Main.getmf(oapk, xcmd, xmt), "label=")
                    re = Main.getPY(tp.Replace(" ", "_")) + ".apk"
                Else
                    If co1 = 2 Then
s:                      re = Main.getPY(Main.getlast(oapk.Split("\")).Replace(" ", "_"))
                    Else
                        If co1 = 1 Then
                            Dim tp = Main.getinfo(Main.getmf(oapk, xcmd, xmt), "name=")
                            re = Main.getPY(tp.Replace(" ", "_")) + "-1.apk"
                        End If
                    End If
                End If
                If re.ToString.Trim = "" Then
                    GoTo s
                End If
                If ck2 = True Then
                    Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell pm uninstall -k " + la, 0, True)
                Else
                    Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " uninstall " + la, 0, True)
                End If
                Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + Main.ls1(ml + re, ".") + ".odex", 0, True)
                ' MsgBox(re)
                Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + oapk + My.Resources.x1 + " " + ml + re, xcmd, xmt)
                If sod = 0 Then
                    Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + "/data/data/" + la + "/lib", xcmd, xmt)
                End If
                insp = 60
                'Dim tx As String = My.Computer.FileSystem.ReadAllText(tmt)
                'Kill(tmt)
                If sod = 0 Then
                    'Dim ko = My.Computer.FileSystem.GetFiles(lb)
                    'MsgBox(ko.Count)
                    If numv <> 0 Then
                        Wait.runn(CInt(numv) * 1000)
                    Else
                        Dim ti = My.Computer.FileSystem.GetFileInfo(insapp).Length
                        'MsgBox((3 + ti.Count / 5))
                        Wait.runn((ti / (800 * 1024) + 3) * 1000)
                    End If
                End If
                'MsgBox(tx)
                'My.Computer.FileSystem.WriteAllText(tcmd, My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell rm " + "/data/data/" + la + "/lib", False, System.Text.Encoding.Default)
                'If sod = 0 Then
                '    Shell(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " push " + My.Resources.x1 + lb + My.Resources.x1 + " " + "/data/data/" + la + "/lib")
                'End If
                'Shell(tcmd, 0, True)
                'Dim p1() As Process = Process.GetProcesses()
                'For i As Integer = 0 To p1.Length - 1
                '    If p1(i).ProcessName = "adb" Then
                '        'MsgBox(p1(i).ProcessName)
                '        p1(i).Close()
                '    End If
                'Next
                If sod = 0 Then
                    Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + "/data/data/" + la + "/lib", xcmd, xmt)
                End If
                If sod = 0 Then
                    Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + lb + My.Resources.x1 + " " + "/data/data/" + la + "/lib", xcmd, xmt)
                    'Shell(My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " push " + My.Resources.x1 + lb + My.Resources.x1 + " " + "/data/data/" + la + "/libs", 0, True)
                Else
                    Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + lb + My.Resources.x1 + " " + "/system/lib", xcmd, xmt)
                End If
                insp = 80
                If don = 1 Then
                    Kill(oapk)
                    My.Computer.FileSystem.DeleteDirectory(libb, FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                insp = 100
                Return ""
            Else
                Button1_Click(Nothing, Nothing)
            End If
        End If
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ins(1)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ins(0)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ins(3)
    End Sub
    Function getinstall(ByVal fapk As String, ByVal dos As Integer)
        If fapk.Trim <> "" Then
            On Error Resume Next
            Dim txx As String = Main.shellme("", My.Resources.x1 + Main.za + My.Resources.x1 + " l " + My.Resources.x1 + insapp + My.Resources.x1, xcmd, xmt)
            insp = 30
            ' MsgBox(bx)
            'If txx.Length <> txx.Replace("classes.dex", "").Length Then
            If ck3 = True Then

                Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell pm uninstall -k " + Main.getinfo(Main.getmf(fapk, xcmd, xmt), "name="), xcmd, xmt)
            Else
                Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " uninstall " + Main.getinfo(Main.getmf(fapk, xcmd, xmt), "name="), xcmd, xmt)


            End If
            insp = 60
            Dim tx As String
            Dim xfapk = fapk
            If Main.getPY(fapk).Trim <> fapk.Trim Then
                Dim xfaa = Main.getPY(Main.getlast(fapk.Split("\")).Trim)
                Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\" + xfaa)
                My.Computer.FileSystem.CopyFile(fapk, My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\" + xfaa, FileIO.UIOption.AllDialogs)
                If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\" + xfaa) = True Then
                    xfapk = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\" + xfaa
                End If
                ' MsgBox(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\" + xfaa)
            End If
            If dos = 1 Then
                tx = Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " install -s " + My.Resources.x1 + xfapk + My.Resources.x1, xcmd, xmt)
            Else
                tx = Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " install " + My.Resources.x1 + xfapk + My.Resources.x1, xcmd, xmt)
            End If

            insp = 80
            'MsgBox(My.Resources.x1 + adb + My.Resources.x1+" "+ mlh + " install " + My.Resources.x1 + fapk + My.Resources.x1 + " >" + tmt)
            If tx.Trim = "" Then
                Return "Failure!"
            Else
                Return (tx.Replace(vbCrLf, "*").Split("*")(tx.Replace(vbCrLf, "*").Split("*").LongLength - 2)).Replace(vbCrLf, "")
            End If
            'Kill(tcmd)
            'Kill(tmt)
            'My.Computer.Clipboard.SetText(tx)
            'Return tx
            'Else
            '    Return ("This App has not Dex!!!" + vbCrLf + "Please Choose Other Way To Install!")
            'End If
            insp = 100
        End If
    End Function
    Dim mlh As String
    Private Sub Install_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        If Timer1.Enabled = True Then
            If MsgBox("Are you sure Cancle the Install ? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                e.Cancel = True
            Else
                If MsgBox("Are you want to stop it at once ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " kill-server", 0, True)
                    Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " start-server", 0, True)
                End If
                BackgroundWorker1.CancelAsync()
                Timer1.Enabled = False
                cx = 1
            End If
        End If
        If Main.zzs = 1 Then
            MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
            ChDir(My.Application.Info.DirectoryPath)
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt, FileIO.DeleteDirectoryOption.DeleteAllContents)
            'RmDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
            'Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " kill-server", 0, True)
            End
        End If
    End Sub
    Dim xmmtt As String
    Dim xcmd As String
    Dim xmt As String
    Private Sub Install_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
w:      mlh = Main.mlh
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
        libb = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\ALib"
        odex = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\ODEX"
        If ComboBox1.Text = "" Then
            ComboBox1.SelectedIndex = 0
            ComboBox2.SelectedIndex = 0
            ComboBox3.SelectedIndex = 0
            ComboBox4.SelectedIndex = 9
        End If
        Panel3.Visible = False
        ListView1.Enabled = True
        If Main.state().ToString.Trim = "device" Then
        Else
            Main.mlh = ""
            MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
            If DC.ShowDialog() = Windows.Forms.DialogResult.OK Then
                GoTo w
            Else
                mlh = Main.mlh
                Me.Close()
            End If
        End If
        'BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ins(4)
    End Sub
    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        If fjar = 0 Then
            With New OpenFileDialog
                .Multiselect = True
                .FileName = ""
                .Filter = "*.Apk|*.apk|*.*|*.*"
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    For x = 0 To .FileNames.longlength - 1
                        fjar = 0
                        Main.addxapk(.FileNames(x))
                    Next
                End If
            End With
        Else
            With New OpenFileDialog
                .FileName = ""
                .Filter = "*.Jar|*.jar"
                .Multiselect = True
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    For x = 0 To .FileNames.longlength - 1
                        Main.addxapk(.FileNames(x))
                    Next
                End If
            End With
        End If
    End Sub
    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ListView1.Items.Clear()
        ImageList1.Images.Clear()
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        On Error Resume Next
        Dim xk As Integer = 0
        xk = (ListView1.Items.IndexOf(ListView1.SelectedItems(0)))
        ListView1.Items.RemoveAt(xk)
        'ImageList1.Images.RemoveAt(xk)
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If ListView1.Items.Count <> 0 Then
            If ListView1.SelectedIndices.Count = 0 Then
                DeleteToolStripMenuItem.Visible = False
                RunToolStripMenuItem.Visible = False
                ToolStripSeparator1.Visible = False
            Else
                DeleteToolStripMenuItem.Visible = True
                If ListView1.SelectedIndices.Count = 1 Then
                    If ListView1.SelectedItems(0).SubItems(4).Text = "Done!" Or ListView1.SelectedItems(0).SubItems(4).Text = "Success" Then
                        RunToolStripMenuItem.Visible = True
                        ToolStripSeparator1.Visible = True
                    Else
                        RunToolStripMenuItem.Visible = False
                        ToolStripSeparator1.Visible = False
                    End If
                Else
                    RunToolStripMenuItem.Visible = False
                    ToolStripSeparator1.Visible = False
                End If
            End If
            ClearToolStripMenuItem.Visible = True
        Else
            ToolStripSeparator1.Visible = False
            RunToolStripMenuItem.Visible = False
            DeleteToolStripMenuItem.Visible = False
            ClearToolStripMenuItem.Visible = False
        End If
        If fjar = 1 Then
            RunToolStripMenuItem.Visible = False
            ToolStripSeparator1.Visible = False
        End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ui(e.Argument, e.Result)
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        On Error Resume Next
        Timer1.Enabled = False
        ProgressBar1.Value = 100
        ProgressBar2.Value = 100
        For x = 0 To dx.Items.Count - 1
            ListView1.Items(x).SubItems(4).Text = dx.Items(x).ToString.Trim
        Next
        Me.Hide()
        If cx <> 1 Then
            If ListView1.Items.Count = 1 And fjar = 0 Then
                If ListView1.Items(0).SubItems(4).Text = "Done!" Or ListView1.Items(0).SubItems(4).Text = "Success" Then
                    If MsgBox("Do you want to Run this App now ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Dim mx = Main.getmf(ListView1.Items(0).SubItems(3).Text, xcmd, xmt)
                        Dim zl = Main.getinfo(mx, "package: name=")
                        Dim ma = Main.getinfo(mx, "launchable-activity: name=")
                        If zl.ToString.Trim <> "" And ma.ToString.Trim <> "" Then
                            Dim r = Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell am start -n " + zl + "/" + ma, xcmd, xmt).ToString.Trim
                            If r = "" Then
                                r = "Done!"
                            End If
                            MsgBox(r, MsgBoxStyle.Information)
                        Else
                            MsgBox("Not Activity To Run!!!", MsgBoxStyle.Information)
                        End If
                    End If
                Else
                    MsgBox(inslog, MsgBoxStyle.Information)
                End If
            Else
                If MsgBox("Are you want to look the Install log ?", MsgBoxStyle.YesNo, "Install Result") = MsgBoxResult.Yes Then
                    My.Computer.FileSystem.WriteAllText(xmt, inslog, False)
                    Shell("notepad " + xmt, AppWinStyle.MaximizedFocus, False)
                End If
            End If
        Else
            MsgBox("Stopped!", MsgBoxStyle.Information)
        End If
        Me.Show()
        Panel3.Visible = False
        ListView1.Enabled = True
    End Sub
    Dim snw As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        'If ProgressBar1.Value < 75 Then
        '    insp = insp + 0.1
        'End If
        ListView1.Items(innum).EnsureVisible()
        If innum <> snw Then
            ListView1.SelectedIndices.Clear()
            ListView1.SelectedIndices.Add(innum)
            snw = ListView1.SelectedItems(0).Index
            'PictureBox1.Image = Nothing
            'PictureBox1.WaitOnLoad = False
        End If
        PictureBox1.Image = imagex.Images(innum)
        Label10.Text = ListView1.SelectedItems(0).Text
        Label9.Text = ListView1.SelectedItems(0).SubItems(1).Text
        ProgressBar1.Value = insp
        ProgressBar2.Value = innum / innums * 100 + CInt(insp / innums)
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If (ListView1.SelectedItems(0).SubItems(4).Text = "Done!" Or ListView1.SelectedItems(0).SubItems(4).Text = "Success") And fjar = 0 Then
            Dim mx = Main.getmf(ListView1.SelectedItems(0).SubItems(3).Text, xcmd, xmt)
            Dim zl = Main.getinfo(mx, "package: name=")
            Dim ma = Main.getinfo(mx, "launchable-activity: name=")
            If zl.ToString.Trim <> "" And ma.ToString.Trim <> "" Then
                MsgBox(Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell am start -n " + zl + "/" + ma, xcmd, xmt), MsgBoxStyle.Information)
            Else
                MsgBox("Not Activity To Run!!!", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Private Sub ListView1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragDrop
        On Error Resume Next
        Dim xu = (e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop, True))
        For x = 0 To xu.longlength - 1
            If Main.getlast(xu(x).ToString.Split(".")).ToLower.Trim = "apk" Then
                Main.addxapk(xu(x))
            End If
        Next
    End Sub
    Private Sub ListView1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragEnter
        e.Effect = DragDropEffects.All
    End Sub
    Dim mx As Integer = 9
    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        mx = ComboBox4.SelectedIndex
    End Sub
    Private Sub RunToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripMenuItem.Click
        ListView1_DoubleClick(Nothing, Nothing)
    End Sub
    Private Sub DevicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevicesToolStripMenuItem.Click
        dcc()
    End Sub
    Function dcc()
        On Error Resume Next
        Main.mlh = ""
        DC.ShowDialog()
        mlh = Main.mlh
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
        libb = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\ALib"
        odex = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\ODEX"
    End Function
    Private Sub AppsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppsToolStripMenuItem.Click
        Me.Hide()
        Apps.Button3.Visible = False
        Apps.ShowDialog()
        Apps.Button3.Visible = True
        Me.Show()
    End Sub
    'Public Sub SKRom推荐ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    On Error Resume Next
    '    ListView1.Items.Clear()
    '    Dim dfs = My.Computer.FileSystem.GetFiles(My.Application.Info.DirectoryPath + "\SK_ROM", FileIO.SearchOption.SearchAllSubDirectories, "*.apk")
    '    For x = 0 To dfs.Count - 1
    '        fjar = 0
    '        Main.addxapk(dfs(x))
    '    Next
    'End Sub
End Class