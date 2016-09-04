Public Class Apps
    Dim xmmtt As String
    Dim xcmd As String
    Dim xmt As String
    Private Sub Apps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
w:      mlh = Main.mlh
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
        filetmp = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\FileTmp\"
        Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw /system ", 0, True)
        'MsgBox(mlh)
        'MsgBox(Main.state().ToString.Trim)
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
        TabControl1.SelectedIndex = 0
        ListBox1.Items.Clear()
        Dim tx = getone("/data/data")
        tx = tx.Replace("       ", "  ")
        tx = tx.Replace("      ", "  ")
        tx = tx.Replace("     ", "  ")
        tx = tx.Replace("    ", "  ")
        tx = tx.Replace("   ", "  ")
        tx = tx.Replace("  ", vbCrLf)
        tx = tx.ToString.Replace(vbCrLf + vbCrLf + vbCrLf, vbCrLf)
        tx = tx.ToString.Replace(vbCrLf + vbCrLf, vbCrLf)
        Dim st = tx + vbCrLf
        Dim xs = st.ToString.Split(vbCrLf)
        For x = 0 To xs.longlength - 1
            If xs(x).Replace(vbCrLf, "").Trim <> "" Then
                ListBox1.Items.Add(xs(x).Replace(vbCrLf, "").Trim)
            End If
        Next
        If ListBox1.Items.Count = 1 And ListBox1.Items(0).ToString.Trim = "/data/data" Then
            TabControl1.SelectedIndex = 0
            ListBox1.Items.Clear()
            tx = getone("/sd-ext/data")
            tx = tx.Replace("       ", "  ")
            tx = tx.Replace("      ", "  ")
            tx = tx.Replace("     ", "  ")
            tx = tx.Replace("    ", "  ")
            tx = tx.Replace("   ", "  ")
            tx = tx.Replace("  ", vbCrLf)
            tx = tx.ToString.Replace(vbCrLf + vbCrLf + vbCrLf, vbCrLf)
            tx = tx.ToString.Replace(vbCrLf + vbCrLf, vbCrLf)
            st = tx + vbCrLf
            xs = st.ToString.Split(vbCrLf)
            For x = 0 To xs.LongLength - 1
                If xs(x).Replace(vbCrLf, "").Trim <> "" And xs(x).Replace(vbCrLf, "").Trim <> "ls: /sd-ext/data: No such file or directory" Then
                    ListBox1.Items.Add(xs(x).Replace(vbCrLf, "").Trim)
                End If
            Next
        End If
    End Sub
    Function getone(ByVal path As String)
        path = My.Resources.x1 + path + My.Resources.x1
        Return Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell ls " + path, xcmd, xmt)
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Apps_Load(Nothing, Nothing)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Install.ComboBox1.Text = ""
        Install.ShowDialog()
        Apps_Load(Nothing, Nothing)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        If ListBox1.SelectedItems.Count <> 0 Then
            TabControl1.TabPages(0).Enabled = False
            Dim pp = ""
            If ListBox1.SelectedItems.Count = 1 Then
                pp = "Do you want to uninstall " + ListBox1.Text + " ?"
            Else
                pp = "Do you want to uninstall Applications ?"
            End If

            Dim r = MsgBox(pp, MsgBoxStyle.YesNo)

            If r = MsgBoxResult.Yes Then
                Dim tx = "Uninstalled "
                For x = 0 To ListBox1.SelectedItems.Count - 1
                    tx = tx + vbCrLf + "-------------------------------" + vbCrLf + ListBox1.SelectedItems(x) + vbCrLf + Main.shellme("Uninstalling " + ListBox1.Text, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " uninstall " + ListBox1.SelectedItems(x).Replace(vbCrLf, vbLf).Replace(vbLf, "").Trim, xcmd, xmt).ToString.Replace(vbCrLf, "")
                Next
                Apps_Load(Nothing, Nothing)

                MsgBox(tx, MsgBoxStyle.Information)

            End If
            TabControl1.TabPages(0).Enabled = True
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        On Error Resume Next
        If ComboBox1.Text <> "" Then
            ListBox2.Items.Clear()
            ilx1.Items.Clear()
            ilx2.Items.Clear()
            Dim tx = getone(ComboBox1.Text)
            tx = tx.Replace("       ", "  ")
            tx = tx.Replace("      ", "  ")
            tx = tx.Replace("     ", "  ")
            tx = tx.Replace("    ", "  ")
            tx = tx.Replace("   ", "  ")
            tx = tx.Replace("  ", vbCrLf)
            tx = tx.ToString.Replace(vbCrLf + vbCrLf + vbCrLf, vbCrLf)
            tx = tx.ToString.Replace(vbCrLf + vbCrLf, vbCrLf)
            Dim st = tx + vbCrLf
            Dim xs = st.ToString.Split(vbCrLf)
            For x = 0 To xs.longlength - 1
                If xs(x).Replace(vbCrLf, "").Trim <> "" And (Main.getlast(xs(x).Replace(vbCrLf, "").Trim.Split(".")).Trim.ToLower = "apk" Or Main.getlast(xs(x).Replace(vbCrLf, "").Trim.Split(".")).Trim.ToLower = "jar") Then
                    If ComboBox1.SelectedIndex = 2 And Main.getlast(xs(x).Replace(vbCrLf, "").Trim.Split(".")).Trim.ToLower = "apk" Then
                        GoTo q
                    End If
                    ListBox2.Items.Add(xs(x).Replace(vbCrLf, "").Trim)
q:                  ilx1.Items.Add(xs(x).Replace(vbCrLf, "").Trim)
                Else
                    If xs(x).Replace(vbCrLf, "").Trim <> "" Then
                        ilx2.Items.Add(xs(x).Replace(vbCrLf, "").Trim)
                    End If
                End If
            Next
        Else
            ComboBox1.SelectedIndex = 0
        End If
        If ComboBox1.SelectedIndex = 0 And ListBox2.Items.Count = 0 Then
            ListBox2.Items.Clear()
            ilx1.Items.Clear()
            ilx2.Items.Clear()
            Dim tx = getone("/sd-ext/app")
            tx = tx.Replace("       ", "  ")
            tx = tx.Replace("      ", "  ")
            tx = tx.Replace("     ", "  ")
            tx = tx.Replace("    ", "  ")
            tx = tx.Replace("   ", "  ")
            tx = tx.Replace("  ", vbCrLf)
            tx = tx.ToString.Replace(vbCrLf + vbCrLf + vbCrLf, vbCrLf)
            tx = tx.ToString.Replace(vbCrLf + vbCrLf, vbCrLf)
            Dim st = tx + vbCrLf
            Dim xs = st.ToString.Split(vbCrLf)
            For x = 0 To xs.LongLength - 1
                If xs(x).Replace(vbCrLf, "").Trim <> "" And (Main.getlast(xs(x).Replace(vbCrLf, "").Trim.Split(".")).Trim.ToLower = "apk" Or Main.getlast(xs(x).Replace(vbCrLf, "").Trim.Split(".")).Trim.ToLower = "jar") Then
                    If ComboBox1.SelectedIndex = 2 And Main.getlast(xs(x).Replace(vbCrLf, "").Trim.Split(".")).Trim.ToLower = "apk" Then
                        GoTo qx
                    End If
                    ListBox2.Items.Add(xs(x).Replace(vbCrLf, "").Trim)
qx:                 ilx1.Items.Add(xs(x).Replace(vbCrLf, "").Trim)
                Else
                    If xs(x).Replace(vbCrLf, "").Trim <> "" Then
                        ilx2.Items.Add(xs(x).Replace(vbCrLf, "").Trim)
                    End If
                End If
            Next
        End If
        If ComboBox1.SelectedIndex = 2 And ListBox2.Items.Count <> 0 Then
            fodexs("android.test.runner.jar")
            fodexs("javax.obex.jar")
            fodexs("bouncycastle.jar")
            fodexs("bmgr.jar")
            fodexs("monkey.jar")
            fodexs("core-junit.jar")
            fodexs("services.jar")
            fodexs("android.policy.jar")
            fodexs("framework.jar")
            fodexs("ext.jar")
            fodexs("bouncycastle.jar")
            fodexs("core.jar")
        End If
        If ComboBox1.SelectedIndex = 2 Then
            Button7.Visible = True
        Else
            Button7.Visible = False
        End If
    End Sub
    Function fodexs(ByVal ss As String)
        On Error Resume Next
        Dim cxc As Integer = ListBox2.Items.Count
        ListBox2.Items.Remove(ss)
        If cxc <> ListBox2.Items.Count Then
            ListBox2.Items.Insert(0, ss)
        End If
    End Function
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Apps_Load(Nothing, Nothing)
        Else
            ComboBox1_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub
    Dim ilx2 As New ListBox
    Dim ilx1 As New ListBox
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
        'ilx2.Items.Clear()
        Dim logs = ""
        'For x = 0 To ListBox2.Items.Count - 1
        '    If ListBox2.Items(x).ToString.Split("."))        .Trim.ToLower = "apk" Or ListBox2.Items(x).ToString.Split("."))        .Trim.ToLower = "jar" Then
        '        ilx1.Items.Add(ListBox2.Items(x))
        '    Else
        '        If ListBox2.Items(x).ToString.Split("."))        .Trim.ToLower = "odex" Then
        '            'MsgBox(ListBox2.Items(x).ToString)
        '            ilx2.Items.Add(ListBox2.Items(x))
        '        End If
        '    End If
        'Next
        If ilx2.Items.Count <> 0 Then
            For x = 0 To ilx2.Items.Count - 1
                Dim ois = Main.ls1(ilx2.Items(x), ".")
                'MsgBox(ois)
                If ilx1.Items.Count <> 0 Then
                    Dim yui = 0
                    For y = 0 To ilx1.Items.Count - 1
                        If Main.ls1(ilx1.Items(y), ".") = ois Then
                            yui = 1
                        End If
                    Next
                    If yui = 0 Then
                        logs = logs + vbCrLf + (ilx2.Items(x))
                    End If
                Else
                    logs = logs + vbCrLf + (ilx2.Items(x))
                End If
            Next
            If logs.Replace(vbCrLf, "").Trim <> "" And logs.Trim.Replace("No such file or directory", "") = logs.Trim Then

                If MsgBox("Do you want to Clean these Unwanted Odex Files ?" + logs, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim xde = logs.Split(vbCrLf)
                    For x = 0 To xde.LongLength - 1
                        If xde(x).ToString.Trim <> "" Then
                            Main.shellme("Cleaning " + xde(x).ToString.Trim, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + ComboBox1.Text + "/" + xde(x).Replace(vbCrLf, "").Trim, xcmd, xmt)
                        End If
                    Next
                    ComboBox1_SelectedIndexChanged(Nothing, Nothing)
                    MsgBox("Done!", MsgBoxStyle.Information)
                End If

            End If
        End If
    End Sub
    Dim filetmp As String
    Dim mlh As String
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListBox2.Items.Count <> 0 Then
            TabControl1.TabPages(1).Enabled = False
            On Error Resume Next
            Install.ListView1.Items.Clear()
            'MsgBox(ComboBox1.SelectedIndex)
            If ComboBox1.SelectedIndex = 0 Then
                Install.ComboBox1.SelectedIndex = 0
                Install.ComboBox2.SelectedIndex = 0
            Else
                If ComboBox1.SelectedIndex = 1 Then
                    Install.ComboBox1.SelectedIndex = 2
                    Install.ComboBox2.SelectedIndex = 1
                Else
                    Install.ComboBox1.SelectedIndex = 2
                End If
            End If
            If ComboBox1.SelectedIndex <> 2 Then
                If ListBox2.SelectedItems.Count <> 0 Then
                    My.Computer.FileSystem.DeleteDirectory(filetmp, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(filetmp)
                    Install.ImageList1.Images.Clear()
                    For x = 0 To ListBox2.SelectedItems.Count - 1
                        If Main.getlast(ListBox2.SelectedItems(x).ToString.Split(".")).Trim.ToLower = "apk" Then
                            Main.shellme("Pulling " + ListBox2.SelectedItems(x).ToString, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + ComboBox1.Text + "/" + ListBox2.SelectedItems(x) + My.Resources.x1 + " " + My.Resources.x1 + filetmp + ListBox2.SelectedItems(x) + My.Resources.x1, xcmd, xmt)
                            Install.fjar = 0
                            Main.addxapk(filetmp + ListBox2.SelectedItems(x))
                        End If
                    Next
                    Install.ShowDialog()
                Else

                    If MsgBox("Do you want to Odex All the Files ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.DeleteDirectory(filetmp, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.CreateDirectory(filetmp)
                        Install.ImageList1.Images.Clear()
                        For x = 0 To ListBox2.Items.Count - 1
                            If Main.getlast(ListBox2.Items(x).ToString.Split(".")).Trim.ToLower = "apk" Then
                                Main.shellme("Pulling " + ListBox2.Items(x).ToString, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + ComboBox1.Text + "/" + ListBox2.Items(x) + My.Resources.x1 + " " + My.Resources.x1 + filetmp + ListBox2.Items(x) + My.Resources.x1, xcmd, xmt)
                                Install.fjar = 0
                                Main.addxapk(filetmp + ListBox2.Items(x))
                            End If
                        Next
                    Else
                        GoTo y
                    End If

                    Install.ShowDialog()
                End If
            Else
                'If MsgBox("Do you want to Odex these Files ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If ListBox2.SelectedItems.Count = 0 Then

                    If MsgBox("[Warning: This is A Dangerous Action!!!]" + vbCrLf + "Do you want to Odex All the Files ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        My.Computer.FileSystem.DeleteDirectory(filetmp, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        My.Computer.FileSystem.CreateDirectory(filetmp)
                        Install.ImageList1.Images.Clear()
                        For x = 0 To ListBox2.Items.Count - 1
                            If Main.getlast(ListBox2.Items(x).ToString.Split(".")).Trim.ToLower = "jar" Then
                                Main.shellme("Pulling " + ListBox2.Items(x).ToString, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + ComboBox1.Text + "/" + ListBox2.Items(x) + My.Resources.x1 + " " + My.Resources.x1 + filetmp + ListBox2.Items(x) + My.Resources.x1, xcmd, xmt)
                                Main.addxapk(filetmp + ListBox2.Items(x))
                                'Main.shellme("",My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell cp " + ComboBox1.Text + "/" + ListBox2.Items(x) + " " + "/data/tmp/" + ListBox2.Items(x))
                                'Main.shellme("",My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell " + "/data/local/tmp/" + "dexopt-wrapper " + "/data/tmp/" + ListBox2.Items(x) + " " + Main.ls1("/data/tmp/" + ListBox2.Items(x), ".") + ".odex" + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell rm " + "/system/dalvik-cache/" + "system@framework@" + ListBox2.Items(x) + "@classes.dex" + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell rm " + "/cache/dalvik-cache/" + "system@framework@" + ListBox2.Items(x) + "@classes.dex")
                                'MsgBox("")
                                'Main.shellme("",My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " pull " + My.Resources.x1 + ComboBox1.Text + "/" + ListBox2.Items(x) + My.Resources.x1 + " " + My.Resources.x1 + filetmp + ListBox2.Items(x) + My.Resources.x1)
                                'Dim kwd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + (Date.Now.ToString.Replace("/", "_").Replace(":", "_").Trim) + "\"
                                'Main.shellme("",My.Resources.x1 + Main.za + My.Resources.x1 + " x -o" + My.Resources.x1 + kwd + My.Resources.x1 + " -y " + My.Resources.x1 + (filetmp + ListBox2.Items(x)) + My.Resources.x1)
                                'Kill(kwd + "classes.dex")
                                'Main.shellme("",My.Resources.x1 + Main.za + My.Resources.x1 + " a -tzip " + My.Resources.x1 + (filetmp + ListBox2.Items(x)) + My.Resources.x1 + " " + My.Resources.x1 + kwd + "*" + My.Resources.x1 + " -mx9")
                                'My.Computer.FileSystem.DeleteDirectory(kwd, FileIO.DeleteDirectoryOption.DeleteAllContents)
                                'Main.shellme("",My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " push " + My.Resources.x1 + (filetmp + ListBox2.Items(x)) + My.Resources.x1 + " " + ComboBox1.Text + "/" + ListBox2.Items(x))
                                'MsgBox("Done!", MsgBoxStyle.Information)
                            End If
                        Next
                    Else
                        GoTo y
                    End If

                Else
                    My.Computer.FileSystem.DeleteDirectory(filetmp, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.CreateDirectory(filetmp)
                    Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + Main.dexopt + My.Resources.x1 + " " + "/data/local/tmp/dexopt-wrapper", xcmd, xmt)
                    Install.ImageList1.Images.Clear()
                    For x = 0 To ListBox2.SelectedItems.Count - 1
                        If Main.getlast(ListBox2.SelectedItems(x).ToString.Split(".")).Trim.ToLower = "jar" Then
                            Main.shellme("Pulling " + ListBox2.SelectedItems(x).ToString, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + ComboBox1.Text + "/" + ListBox2.SelectedItems(x) + My.Resources.x1 + " " + My.Resources.x1 + filetmp + ListBox2.SelectedItems(x) + My.Resources.x1, xcmd, xmt)
                            Main.addxapk(filetmp + ListBox2.SelectedItems(x))
                            'Main.shellme("",My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell cp " + ComboBox1.Text + "/" + ListBox2.SelectedItems(x) + " " + "/data/tmp/" + ListBox2.SelectedItems(x) + ".apk")
                            'Main.shellme("",My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell " + "/data/local/tmp/" + "dexopt-wrapper " + "/data/tmp/" + ListBox2.SelectedItems(x) + ".apk" + " " + "/data/tmp/" + ListBox2.SelectedItems(x) + ".odex" + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell rm " + "/system/dalvik-cache/" + "system@framework@" + ListBox2.SelectedItems(x) + "@classes.dex" + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " shell rm " + "/cache/dalvik-cache/" + "system@framework@" + ListBox2.SelectedItems(x) + "@classes.dex")
                            'MsgBox("")
                            'Main.shellme("",My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " pull " + My.Resources.x1 + ComboBox1.Text + "/" + ListBox2.SelectedItems(x) + My.Resources.x1 + " " + My.Resources.x1 + filetmp + ListBox2.SelectedItems(x) + My.Resources.x1)
                            'Dim kwd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + (Date.Now.ToString.Replace("/", "_").Replace(":", "_").Trim) + "\"
                            'Main.shellme("",My.Resources.x1 + Main.za + My.Resources.x1 + " x -o" + My.Resources.x1 + kwd + My.Resources.x1 + " -y " + My.Resources.x1 + (filetmp + ListBox2.SelectedItems(x)) + My.Resources.x1)
                            'Kill(kwd + "classes.dex")
                            'Kill((filetmp + ListBox2.SelectedItems(x)))
                            'Main.shellme("",My.Resources.x1 + Main.za + My.Resources.x1 + " a -tzip " + My.Resources.x1 + (filetmp + ListBox2.SelectedItems(x)) + My.Resources.x1 + " " + My.Resources.x1 + kwd + "*" + My.Resources.x1 + " -mx9")
                            'MsgBox("")
                            'Main.shellme("",My.Resources.x1 + Main.adb + My.Resources.x1+" "+ mlh + " push " + My.Resources.x1 + (filetmp + ListBox2.SelectedItems(x)) + My.Resources.x1 + " " + ComboBox1.Text + "/" + ListBox2.SelectedItems(x))
                            'My.Computer.FileSystem.DeleteDirectory(kwd, FileIO.DeleteDirectoryOption.DeleteAllContents)
                            'MsgBox("Done!", MsgBoxStyle.Information)
                        End If
                    Next
                End If
                fx()
            End If
            ComboBox1_SelectedIndexChanged(Nothing, Nothing)
y:          TabControl1.TabPages(1).Enabled = True
        End If
    End Sub
    Function fx()
        On Error Resume Next
        Install.Button1.Enabled = False
        Install.Button2.Enabled = False
        Install.Button4.Enabled = False
        'Install.Button5.Enabled = False
        Install.ComboBox1.Enabled = False
        Install.ComboBox2.Enabled = False
        Install.ComboBox3.Enabled = False
        Install.CheckBox1.Enabled = False
        Install.CheckBox3.Enabled = False
        Install.CheckBox2.Enabled = False
        Install.CheckBox4.Enabled = False
        Install.NumericUpDown1.Enabled = False
        'Install.AddToolStripMenuItem.Enabled = False
        Install.fjar = 1
        Install.ComboBox1.SelectedIndex = 2
        Install.ComboBox2.Items.Add("system/framework")
        Install.ComboBox2.SelectedIndex = 2
        Install.ShowDialog()
        Install.ComboBox2.SelectedIndex = 0
        Install.ComboBox2.Items.Remove("system/framework")
        Install.fjar = 0
        Install.ListView1.Items.Clear()
        Install.Button1.Enabled = True
        Install.Button2.Enabled = True
        Install.Button4.Enabled = True
        'Install.Button5.Enabled = True
        Install.ComboBox1.Enabled = True
        Install.ComboBox2.Enabled = True
        Install.ComboBox3.Enabled = True
        Install.CheckBox1.Enabled = True
        Install.CheckBox3.Enabled = True
        Install.CheckBox2.Enabled = True
        Install.CheckBox4.Enabled = True
        Install.NumericUpDown1.Enabled = True
        'Install.AddToolStripMenuItem.Enabled = True
    End Function
    Function cl(ByVal cache As String, ByVal xc As String)
        On Error Resume Next
        ComboBox1_SelectedIndexChanged(Nothing, Nothing)
        Dim ilx1 As New ListBox
        Dim ilx2 As New ListBox
        ilx1.Items.Clear()
        ilx2.Items.Clear()
        Dim tx = getone(cache)
        tx = tx.Replace("       ", "  ")
        tx = tx.Replace("      ", "  ")
        tx = tx.Replace("     ", "  ")
        tx = tx.Replace("    ", "  ")
        tx = tx.Replace("   ", "  ")
        tx = tx.Replace("  ", vbCrLf)
        tx = tx.ToString.Replace(vbCrLf + vbCrLf + vbCrLf, vbCrLf)
        tx = tx.ToString.Replace(vbCrLf + vbCrLf, vbCrLf)
        Dim st = tx + vbCrLf
        Dim xs = st.ToString.Split(vbCrLf)
        For x = 0 To xs.longlength - 1
            If xs(x).Replace(vbCrLf, "").Trim <> "" Then
                'MsgBox(xs(x).ToString.Replace(vbCrLf, "").Trim.Substring(0, xc.Length))
                If Main.getlast(xs(x).ToString.Split(".")).Trim.ToLower = "dex" And xs(x).ToString.Replace(vbCrLf, "").Trim.Substring(0, xc.Length) = xc Then
                    ilx2.Items.Add(xs(x).Replace(vbCrLf, "").Trim)
                End If
            End If
        Next
        Dim logs = ""
        For x = 0 To ListBox2.Items.Count - 1
            If Main.getlast(ListBox2.Items(x).ToString.Split(".")).Trim.ToLower = "apk" Or Main.getlast(ListBox2.Items(x).ToString.Split(".")).Trim.ToLower = "jar" Then
                ilx1.Items.Add(ListBox2.Items(x))
            End If
        Next
        If ilx2.Items.Count <> 0 Then
            Dim txv = getone(ComboBox1.Text)
            txv = txv.Replace("       ", "  ")
            txv = txv.Replace("      ", "  ")
            txv = txv.Replace("     ", "  ")
            txv = txv.Replace("    ", "  ")
            txv = txv.Replace("   ", "  ")
            txv = txv.Replace("  ", vbCrLf)
            txv = txv.ToString.Replace(vbCrLf + vbCrLf + vbCrLf, vbCrLf)
            txv = txv.ToString.Replace(vbCrLf + vbCrLf, vbCrLf)
            For x = 0 To ilx2.Items.Count - 1
                Dim ois = ilx2.Items(x)
                If ilx1.Items.Count <> 0 Then
                    Dim yui = 0
                    For y = 0 To ilx1.Items.Count - 1
                        If xc + ilx1.Items(y) + "@classes.dex" = ois Then
                            If txv.ToString.Replace(vbCrLf + Main.ls1(ilx1.Items(y) + vbCrLf, ".") + ".odex", "") = txv Then
                                yui = 1
                            End If
                        End If
                    Next
                    If yui = 0 Then
                        logs = logs + vbCrLf + (ilx2.Items(x))
                    End If
                Else
                    logs = logs + vbCrLf + (ilx2.Items(x))
                End If
            Next
            If logs.Replace(vbCrLf, "").Trim <> "" Then

                If MsgBox("Do you want to Clean these Unwanted Dex Files ?" + logs, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim xde = logs.Split(vbCrLf)
                    For x = 0 To xde.LongLength - 1
                        If xde(x).ToString.Trim <> "" Then
                            Main.shellme("Cleaning " + xde(x).ToString.Trim, My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + cache + "/" + xde(x).Replace(vbCrLf, "").Trim, xcmd, xmt)
                        End If
                    Next
                    ComboBox1_SelectedIndexChanged(Nothing, Nothing)
                    MsgBox("Done!", MsgBoxStyle.Information)
                End If

            End If
        End If
    End Function
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ComboBox1.SelectedIndex = 0 Then
            cl("/data/dalvik-cache", "data@app@")
            cl("/sd-ext/dalvik-cache", "data@app@")
        Else
            If ComboBox1.SelectedIndex = 1 Then
                cl("/data/dalvik-cache", "system@app@")
                cl("/cache/dalvik-cache", "system@app@")
            Else
                cl("/data/dalvik-cache", "system@framework@")
                cl("/cache/dalvik-cache", "system@framework@")
            End If
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        With New OpenFileDialog
            .FileName = ""
            .Filter = "*.Jar|*.jar"
            .Multiselect = True
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                Install.ListView1.Items.Clear()
                Install.ImageList1.Images.Clear()
                For x = 0 To .FileNames.longlength - 1
                    Main.addxapk(.FileNames(x))
                Next
                fx()
                ComboBox1_SelectedIndexChanged(Nothing, Nothing)
            End If
        End With
    End Sub
    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.DoubleClick
        Button1_Click(Nothing, Nothing)
    End Sub
    Private Sub ListBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox2.DoubleClick
        Button4_Click(Nothing, Nothing)
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        If MsgBox("Are you sure reboot in Recovery Mode?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Main.shellme("Reboot In Recovery Mode", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " reboot recovery", xcmd, xmt)
        End If

    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        If MsgBox("Are you sure reboot in Bootloader Mode?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Main.shellme("Reboot In Bootloader Mode", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " reboot bootloader", xcmd, xmt)
        End If

    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        If MsgBox("Are you sure reboot in Nomal Mode?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Main.shellme("Reboot In Nomal Mode", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " reboot -n", xcmd, xmt)
        End If

    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        If MsgBox("Are you sure Shutdown Android?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Main.shellme("Shutdown", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " reboot -p", xcmd, xmt)
        End If

    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        On Error Resume Next
        If ListBox1.SelectedItems.Count <> 0 Then
            Run.TextBox1.Text = ListBox1.SelectedItems(0).ToString.Trim
            Run.TextBox2.Text = ""
        Else
            Run.TextBox1.Text = ""
            Run.TextBox2.Text = ""
        End If
        Me.Hide()
        Run.ShowDialog()
        Me.Show()
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
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
            Button2_Click(Nothing, Nothing)
        End If
    End Function
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        On Error Resume Next
        With New OpenFileDialog
            .FileName = ""
            .Filter = "Recovery.img|Recovery.img|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                If Main.state().ToString.Trim = "device" Then
                    Main.shellme("Reboot In Bootloader Mode", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " reboot bootloader", xcmd, xmt)
                    Dim r = Main.shellme("Downloading...", My.Resources.x1 + Main.fastboot + My.Resources.x1 + " " + mlh + " boot " + My.Resources.x1 + .FileName + My.Resources.x1, xcmd, xmt).ToString.Trim
                    If r = "" Then
                        r = "Done!"
                    End If

                    MsgBox(r, MsgBoxStyle.Information)

                Else
                    Main.mlh = ""

                    MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)

                    If DC.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        mlh = Main.mlh
                        xmmtt = Main.xmmtt
                        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
                        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
                        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
                        filetmp = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\FileTmp\"
                        Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw /system ", 0, True)
                    Else
                        mlh = Main.mlh
                        Me.Close()
                    End If
                End If
            End If
        End With
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        On Error Resume Next
        Dim r = InputBox("Please Write Some FastBoot Command:", "FastBoot CommandLine [Warning: This is A Dangerous Action]", "")
        If r.Trim <> "" Then
            Kill(xcmd)
            My.Computer.FileSystem.WriteAllText(xcmd, "@ECHO off" + vbCrLf + My.Resources.x1 + Main.fastboot + My.Resources.x1 + " " + mlh + " " + r.Trim + vbCrLf + "pause", False, System.Text.Encoding.Default)
            Shell(xcmd, 1, False)
        End If
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        On Error Resume Next
        With New OpenFileDialog
            .FileName = ""
            .Filter = "Recovery.img|Recovery.img|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then

                If MsgBox("Are you sure that you want to Flash Recovery ?", MsgBoxStyle.YesNo, "Flash Recovery [Warning: This is A Dangerous Action]") = MsgBoxResult.Yes Then
                    If Main.state().ToString.Trim = "device" Then
                        Main.shellme("Reboot In Bootloader Mode", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " reboot bootloader", xcmd, xmt)
                        Main.shellme("Erasing Recovery...", My.Resources.x1 + Main.fastboot + My.Resources.x1 + " " + mlh + " erase recovery ", xcmd, xmt)
                        Dim r = Main.shellme("Flashing Recovery...", My.Resources.x1 + Main.fastboot + My.Resources.x1 + " " + mlh + " flash recovery " + My.Resources.x1 + .FileName + My.Resources.x1, xcmd, xmt).ToString.Trim
                        If r = "" Then
                            r = "Done!"
                        End If
                        Main.shellme("Rebooting...", My.Resources.x1 + Main.fastboot + My.Resources.x1 + " " + mlh + " reboot ", xcmd, xmt)
                    Else
                        Main.mlh = ""
                        MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
                        If DC.ShowDialog() = Windows.Forms.DialogResult.OK Then
                            mlh = Main.mlh
                            xmmtt = Main.xmmtt
                            xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
                            xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
                            MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
                            filetmp = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\FileTmp\"
                            Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw /system ", 0, True)
                        Else
                            mlh = Main.mlh
                            Me.Close()
                        End If
                    End If
                End If

            End If
        End With
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        On Error Resume Next
        With New OpenFileDialog
            .FileName = ""
            .Filter = "update.zip|update.zip|*.zip|*.zip"
            .ShowDialog()
            If .FileName <> "" Then

                If MsgBox("Are you sure that you want to Flash Device ?", MsgBoxStyle.YesNo, "Flash Device [Warning: This is A Dangerous Action]") = MsgBoxResult.Yes Then
                    Dim k = MsgBox("Are you want to erase userdata and cache ? ", MsgBoxStyle.YesNoCancel)
                    Dim wipe As Boolean = False
                    If k = MsgBoxResult.Cancel Then
                        GoTo s
                    Else
                        If k = MsgBoxResult.Yes Then
                            wipe = True
                        Else
                            wipe = False
                        End If
                    End If
                    If Main.state().ToString.Trim = "device" Then
                        Main.shellme("Reboot In Bootloader Mode", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " reboot bootloader", xcmd, xmt)
                        If wipe = True Then
                            Main.shellme("Erasing userdata And cache...", My.Resources.x1 + Main.fastboot + My.Resources.x1 + " " + mlh + " -w ", xcmd, xmt)
                        End If
                        Dim r = Main.shellme("Updating...", My.Resources.x1 + Main.fastboot + My.Resources.x1 + " " + mlh + " update " + My.Resources.x1 + .FileName + My.Resources.x1, xcmd, xmt).ToString.Trim
                        If r = "" Then
                            r = "Done!"
                        End If
                        Main.shellme("Rebooting...", My.Resources.x1 + Main.fastboot + My.Resources.x1 + " " + mlh + " reboot ", xcmd, xmt)
                        MsgBox(r, MsgBoxStyle.Information)
                    Else
                        Main.mlh = ""
                        MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
                        If DC.ShowDialog() = Windows.Forms.DialogResult.OK Then
                            mlh = Main.mlh
                            xmmtt = Main.xmmtt
                            xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
                            xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
                            MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
                            filetmp = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\FileTmp\"
                            Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw /system ", 0, True)
                        Else
                            mlh = Main.mlh
                            Me.Close()
                        End If
                    End If
                End If

            End If
        End With
s:
    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        On Error Resume Next
        Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " logcat", AppWinStyle.NormalFocus, False)
    End Sub
End Class