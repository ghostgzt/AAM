Public Class Tools
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With New OpenFileDialog
            .Multiselect = True
            .FileName = ""
            .Filter = "*.PNG;*.JPG;*.BMP;*.JPEG|*.PNG;*.JPG;*.BMP;*.JPEG|*.*|*.*"
            .ShowDialog()
            If .FileNames.longlength <> 0 Then
                For x = 0 To .FileNames.longlength - 1
                    If ComboBox1.SelectedIndex = 0 Or (ComboBox1.SelectedIndex = 1 And TabControl2.SelectedIndex = 0) Then
                        ListBox1.Items.Add(.FileNames(x))
                    Else
                        If TabControl2.SelectedIndex = 1 Then
                            ListBox2.Items.Add(.FileNames(x))
                        End If
                    End If
                Next
            End If
        End With
    End Sub
    Dim dx As Integer
    Dim bx As Integer
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If ListBox1.Items.Count <> 0 Then
            dx = 0
            bx = ListBox1.Items.Count
            Timer1.Interval = 100
            kxs = 0
            If Timer1.Enabled = False Then
                'MsgBox((NumericUpDown5.Value / (((ListBox1.Items.Count + ListBox2.Items.Count) / NumericUpDown5.Value) * 1000)))
                Timer1.Interval = ((((ListBox1.Items.Count + ListBox2.Items.Count) / NumericUpDown5.Value) * 1000)) / (ListBox1.Items.Count + ListBox2.Items.Count)
                Timer1.Enabled = True
                Button6.Text = "Stop"
            Else
                Timer1.Enabled = False
                Button6.Text = "Play"
            End If
        End If
    End Sub
    Dim kxs = 0
    Dim oxx = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error GoTo d
        If dx <= bx - 1 Then
            If kxs = 0 Then
                PictureBox2.ImageLocation = ListBox1.Items(dx)
            Else
                PictureBox2.ImageLocation = ListBox2.Items(dx)
            End If
            If dx = bx - 1 Then
                If kxs = 0 Then
                    GoTo s
                Else
                    GoTo d
                End If
            End If
            dx = dx + 1
        Else
            'If kxs = 0 Then
            '    PictureBox2.ImageLocation = ListBox1.Items(dx)
            'Else
            '    PictureBox2.ImageLocation = ListBox2.Items(dx)
            'End If
            GoTo s
        End If
        Exit Sub
s:
        If ComboBox1.SelectedIndex = 0 Then
d:
            If ListBox1.Items.Count <> 0 Then
                dx = 0
                bx = ListBox1.Items.Count
                PictureBox2.ImageLocation = ListBox1.Items(0)
            Else
                Timer1.Enabled = False
                Button6.Text = "Play"
            End If
            kxs = 0
        Else
            If ListBox2.Items.Count <> 0 Then
                dx = 0
                bx = ListBox2.Items.Count
                PictureBox2.ImageLocation = ListBox2.Items(0)
            Else
                'If CheckBox1.Checked = False Then
                Timer1.Enabled = False
                Button6.Text = "Play"
                'Else
                'Button6_Click(Nothing, Nothing)
                'Button6_Click(Nothing, Nothing)
                'End If
            End If
            kxs = 1
        End If
    End Sub
    Dim zz As String
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        With New OpenFileDialog
            .FileName = ""
            .Filter = "*.PNG;*.JPG;*.BMP;*.JPEG|*.PNG;*.JPG;*.BMP;*.JPEG|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                PictureBox1.Image = Nothing
                zz = .FileName
                PictureBox1.ImageLocation = .FileName
                CheckBox2_CheckedChanged(Nothing, Nothing)
            End If
        End With
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        With New FolderBrowserDialog
            .SelectedPath = ""
            .ShowNewFolderButton = True
            .Description = "Choose a path:"
            .ShowDialog()
            If .SelectedPath <> "" Then
                Dim xy As New Bitmap(Image.FromFile(zz), CInt(NumericUpDown1.Value), CInt(NumericUpDown2.Value))
                xy.Save(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\tmp.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                Shell(My.Resources.x1 + Main.bootimg + My.Resources.x1 + " --repack-565 " + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\tmp.jpg" + My.Resources.x1 + " " + My.Resources.x1 + .SelectedPath + "\oemlogo.mbn" + My.Resources.x1, 0, True)
                xy.Dispose()
                Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\tmp.jpg")
                Kill(.SelectedPath + "\oemlogo.raw")
                MsgBox("Done!", MsgBoxStyle.Information)
            End If
        End With
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        On Error Resume Next
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        PictureBox2.Image = Nothing
        My.Computer.FileSystem.DeleteDirectory(kx, FileIO.DeleteDirectoryOption.DeleteAllContents)
        My.Computer.FileSystem.DeleteDirectory(gx, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ComboBox1.SelectedIndex = 0 Or (ComboBox1.SelectedIndex = 1 And TabControl2.SelectedIndex = 0) Then
            If ListBox1.Items.Count <> 0 Then
                For x = 0 To ListBox1.SelectedItems.Count - 1
                    ListBox1.Items.Remove(ListBox1.SelectedItems(0))
                Next
            End If
        Else
            If TabControl2.SelectedIndex = 1 Then
                If ListBox2.Items.Count <> 0 Then
                    For x = 0 To ListBox2.SelectedItems.Count - 1
                        ListBox2.Items.Remove(ListBox2.SelectedItems(0))
                    Next
                End If
            End If
        End If
    End Sub
    Private Sub InsertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertToolStripMenuItem.Click
        Dim lx
        If ListBox1.Focused = True Then
            lx = ListBox1
        Else
            lx = ListBox2
        End If
        If ListBox1.SelectedItems.Count <> 0 Then
            With New OpenFileDialog
                .Multiselect = True
                .FileName = ""
                .Filter = "*.PNG;*.JPG;*.BMP;*.JPEG|*.PNG;*.JPG;*.BMP;*.JPEG|*.*|*.*"
                .ShowDialog()
                If .FileNames.LongLength <> 0 Then
                    For x = 0 To .FileNames.LongLength - 1
                        If .FileNames(x).Trim <> "" Then
                            lx.Items.Insert(lx.Items.IndexOf(lx.SelectedItems(0)), .FileNames(x))
                        End If
                    Next
                End If
            End With
        End If
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim lx
        If ListBox1.Focused = True Then
            lx = ListBox1
        Else
            lx = ListBox2
        End If
        If lx.SelectedItems.longlength <> 0 Then
            Button4_Click(Nothing, Nothing)
        End If
    End Sub
    Dim kx = My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\SSTmp"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        Dim m = MsgBox("Do you want to get it from Device or Local ?" + vbCrLf + "Y - Device" + vbCrLf + "N - Local" + vbCrLf + "C - Cancle", MsgBoxStyle.YesNoCancel)
        If m = MsgBoxResult.No Then
            With New OpenFileDialog
                .FileName = ""
                .Filter = "*.zip|*.zip|*.*|*.*"
                .ShowDialog()
                If .FileName <> "" Then
                    Button5_Click(Nothing, Nothing)
                    My.Computer.FileSystem.DeleteDirectory(kx, FileIO.DeleteDirectoryOption.DeleteAllContents)
                    Shell(My.Resources.x1 + Main.za + My.Resources.x1 + " x -o" + My.Resources.x1 + kx + My.Resources.x1 + " -y " + My.Resources.x1 + .FileName + My.Resources.x1, 0, True)
                    Dim qxz = My.Computer.FileSystem.ReadAllText(kx + "\desc.txt").Replace(vbCrLf, vbLf).Split(vbLf)(0).Split(" ")
                    NumericUpDown4.Value = CInt(qxz(0))
                    NumericUpDown3.Value = CInt(qxz(1))
                    NumericUpDown5.Value = CInt(qxz(2))
                    'MsgBox(My.Computer.FileSystem.ReadAllText(kx + "\desc.txt").Split(vbLf)(0).Split(" ")(0))
                    If ComboBox1.SelectedIndex = 0 Then
                        Dim r = My.Computer.FileSystem.GetFiles(kx, FileIO.SearchOption.SearchAllSubDirectories, "*.png")
                        Dim k = My.Computer.FileSystem.GetFiles(kx, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                        For x = 0 To r.Count - 1
                            ListBox1.Items.Add(r(x))
                        Next
                        For y = 0 To k.Count - 1
                            ListBox1.Items.Add(k(y))
                        Next
                    Else
                        Dim h = My.Computer.FileSystem.GetDirectories(kx)
                        For x = 0 To h.Count - 1
                            If Main.getlast(h(x).Trim.ToLower.Split("\")) = "part1" Then
                                Dim r = My.Computer.FileSystem.GetFiles(kx + "\part1", FileIO.SearchOption.SearchAllSubDirectories, "*.png")
                                Dim k = My.Computer.FileSystem.GetFiles(kx + "\part1", FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                                For v = 0 To r.Count - 1
                                    ListBox2.Items.Add(r(v))
                                Next
                                For y = 0 To k.Count - 1
                                    ListBox2.Items.Add(k(y))
                                Next
                            Else
                                Dim r = My.Computer.FileSystem.GetFiles(kx + "\" + Main.getlast(h(x).Split("\")), FileIO.SearchOption.SearchAllSubDirectories, "*.png")
                                Dim k = My.Computer.FileSystem.GetFiles(kx + "\" + Main.getlast(h(x).Split("\")), FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                                For v = 0 To r.Count - 1
                                    ListBox1.Items.Add(r(v))
                                Next
                                For y = 0 To k.Count - 1
                                    ListBox1.Items.Add(k(y))
                                Next
                            End If
                        Next
                    End If
                End If
            End With
        Else
            If m = MsgBoxResult.Yes Then
                If Main.state().ToString.Trim = "device" Then
                    Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw /system", 0, True)
                    Button5_Click(Nothing, Nothing)
                    Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\$boot$.zip")
                    Main.shellme("Opening...", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + ComboBox3.Text + "/bootanimation.zip" + My.Resources.x1 + " " + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\$boot$.zip" + My.Resources.x1, xcmd, xmt)
                    Shell(My.Resources.x1 + Main.za + My.Resources.x1 + " x -o" + My.Resources.x1 + kx + My.Resources.x1 + " -y " + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\$boot$.zip" + My.Resources.x1, 0, True)
                    If ComboBox1.SelectedIndex = 0 Then
                        Dim r = My.Computer.FileSystem.GetFiles(kx, FileIO.SearchOption.SearchAllSubDirectories, "*.png")
                        Dim k = My.Computer.FileSystem.GetFiles(kx, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                        For x = 0 To r.Count - 1
                            ListBox1.Items.Add(r(x))
                        Next
                        For y = 0 To k.Count - 1
                            ListBox1.Items.Add(k(y))
                        Next
                    Else
                        Dim h = My.Computer.FileSystem.GetDirectories(kx)
                        For x = 0 To h.Count - 1
                            If Main.getlast(h(x).Trim.ToLower.Split("\")) = "part1" Then
                                Dim r = My.Computer.FileSystem.GetFiles(kx + "\part1", FileIO.SearchOption.SearchAllSubDirectories, "*.png")
                                Dim k = My.Computer.FileSystem.GetFiles(kx + "\part1", FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                                For v = 0 To r.Count - 1
                                    ListBox2.Items.Add(r(v))
                                Next
                                For y = 0 To k.Count - 1
                                    ListBox2.Items.Add(k(y))
                                Next
                            Else
                                Dim r = My.Computer.FileSystem.GetFiles(kx + "\" + Main.getlast(h(x).Split("\")), FileIO.SearchOption.SearchAllSubDirectories, "*.png")
                                Dim k = My.Computer.FileSystem.GetFiles(kx + "\" + Main.getlast(h(x).Split("\")), FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                                For v = 0 To r.Count - 1
                                    ListBox1.Items.Add(r(v))
                                Next
                                For y = 0 To k.Count - 1
                                    ListBox1.Items.Add(k(y))
                                Next
                            End If
                        Next
                    End If
                Else
                    MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
                    DC.ShowDialog()
                    mlh = Main.mlh
                End If
            End If
        End If
    End Sub
    Function SY()
        On Error Resume Next
        Dim lx
        If ListBox1.Focused = True Then
            lx = ListBox1
        Else
            lx = ListBox2
        End If
        Dim qian As String
        Dim huo As String
        If lx.Items.IndexOf(lx.SelectedItems(0)) > 0 Then
            huo = lx.SelectedItems(0)
            Dim t = lx.SelectedItems(0)
            qian = lx.Items(lx.Items.IndexOf(t) - 1)
            lx.Items(lx.Items.IndexOf(t)) = qian
            t = lx.SelectedItems(0)
            lx.Items(lx.Items.IndexOf(t)) = huo
            lx.ClearSelected()
            lx.SetSelected(lx.Items.IndexOf(t) - 1, True)
        End If
    End Function
    Function XY()
        On Error Resume Next
        Dim lx
        If ListBox1.Focused = True Then
            lx = ListBox1
        Else
            lx = ListBox2
        End If
        Dim qian As String
        Dim huo As String
        If lx.Items.IndexOf(lx.SelectedItems(0)) < lx.Items.Count - 1 Then
            huo = lx.SelectedItems(0)
            Dim t = lx.SelectedItems(0)
            qian = lx.Items(lx.Items.IndexOf(t) + 1)
            lx.Items(lx.Items.IndexOf(t) + 1) = huo
            t = lx.SelectedItems(0)
            'MsgBox(lx.Items.IndexOf(t))
            lx.Items(lx.Items.IndexOf(t)) = qian
            lx.ClearSelected()
            lx.SetSelected(lx.Items.IndexOf(t), True)
        End If
    End Function
    Private Sub UpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpToolStripMenuItem.Click
        SY()
    End Sub
    Private Sub DownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownToolStripMenuItem.Click
        XY()
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Dim lx As ListBox
        If ListBox1.Focused = True Then
            lx = ListBox1
        Else
            lx = ListBox2
        End If
        If lx.SelectedItems.Count <> 0 Then
            ToolStripSeparator1.Visible = True
            ToolStripSeparator2.Visible = True
            SetSizeToolStripMenuItem.Visible = True
            InsertToolStripMenuItem.Visible = True
            If lx.Items.IndexOf(lx.SelectedItems(0)) = 0 Then
                UpToolStripMenuItem.Visible = False
                DownToolStripMenuItem.Visible = True
            Else
                If lx.Items.IndexOf(lx.SelectedItems(0)) = lx.Items.Count - 1 Then
                    UpToolStripMenuItem.Visible = True
                    DownToolStripMenuItem.Visible = False
                Else
                    UpToolStripMenuItem.Visible = True
                    DownToolStripMenuItem.Visible = True
                End If
            End If
            DeleteToolStripMenuItem.Visible = True
        Else
            ToolStripSeparator1.Visible = False
            ToolStripSeparator2.Visible = False
            InsertToolStripMenuItem.Visible = False
            SetSizeToolStripMenuItem.Visible = False
            UpToolStripMenuItem.Visible = False
            DownToolStripMenuItem.Visible = False
            DeleteToolStripMenuItem.Visible = False
        End If
    End Sub
    Dim gx = My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\SSOutput"
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If ListBox1.Items.Count <> 0 Then
            Dim pk = "0"
            If CheckBox1.Checked = True Then
                pk = "0"
            Else
                pk = "1"
            End If
            On Error Resume Next
            Dim m = MsgBox("Do you want to save it to Device or Local ?" + vbCrLf + "Y - Device" + vbCrLf + "N - Local" + vbCrLf + "C - Cancle", MsgBoxStyle.YesNoCancel)
            If m = MsgBoxResult.No Then
                With New SaveFileDialog
                    .FileName = "bootanimation.zip"
                    .Filter = "*.zip|*.zip|*.*|*.*"
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        My.Computer.FileSystem.DeleteDirectory(gx, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        For x = 0 To ListBox1.Items.Count - 1
                            Dim ji = Image.FromFile(ListBox1.Items(x))
                            'ji.SaveAdd()
                            Dim xy As New Bitmap(ji, CInt(NumericUpDown4.Value), CInt(NumericUpDown3.Value))
                            'xy = ji
                            MkDir(gx + "\part0")
                            xy.Save(gx + "\part0" + "\Fuck" + hx(x) + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                            xy.Dispose()
                        Next
                        If ComboBox1.SelectedIndex = 1 Then
                            For x = 0 To ListBox2.Items.Count - 1
                                Dim ji = Image.FromFile(ListBox2.Items(x))
                                'ji.SaveAdd()
                                Dim xy As New Bitmap(ji, CInt(NumericUpDown4.Value), CInt(NumericUpDown3.Value))
                                'xy = ji
                                MkDir(gx + "\part1")
                                xy.Save(gx + "\part1" + "\Fuck" + hx(x) + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                                xy.Dispose()
                            Next
                        End If
                        If ComboBox1.SelectedIndex = 0 Then
                            My.Computer.FileSystem.WriteAllText(gx + "\desc.txt", CStr(NumericUpDown4.Value).Trim + " " + CStr(NumericUpDown3.Value).Trim + " " + CStr(NumericUpDown5.Value).Trim + vbCrLf + "p " + pk + " 0 part0" + vbCrLf, False, System.Text.Encoding.Default)
                        Else
                            My.Computer.FileSystem.WriteAllText(gx + "\desc.txt", CStr(NumericUpDown4.Value).Trim + " " + CStr(NumericUpDown3.Value).Trim + " " + CStr(NumericUpDown5.Value).Trim + vbCrLf + "p 1 0 part0" + vbCrLf + "p " + pk + " 0 part1" + vbCrLf, False, System.Text.Encoding.Default)
                        End If
                        Main.shellme("Saving...", My.Resources.x1 + Main.za + My.Resources.x1 + " a -tzip " + My.Resources.x1 + .FileName + My.Resources.x1 + " " + My.Resources.x1 + gx + "\*" + My.Resources.x1 + " -mx0", xcmd, xmt)
                        My.Computer.FileSystem.DeleteDirectory(gx, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        MsgBox("Done!", MsgBoxStyle.Information)
                    End If
                End With
            Else
                If m = MsgBoxResult.Yes Then
                    If Main.state().ToString.Trim = "device" Then
                        Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw /system", 0, True)
                        Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\$boot$.zip")
                        My.Computer.FileSystem.DeleteDirectory(gx, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        For x = 0 To ListBox1.Items.Count - 1
                            Dim xy As New Bitmap(Image.FromFile(ListBox1.Items(x)), CInt(NumericUpDown4.Value), CInt(NumericUpDown3.Value))
                            MkDir(gx + "\part0")
                            xy.Save(gx + "\part0" + "\fuck" + hx(x) + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                            xy.Dispose()
                        Next
                        If ComboBox1.SelectedIndex = 1 Then
                            For x = 0 To ListBox2.Items.Count - 1
                                Dim ji = Image.FromFile(ListBox2.Items(x))
                                'ji.SaveAdd()
                                Dim xy As New Bitmap(ji, CInt(NumericUpDown4.Value), CInt(NumericUpDown3.Value))
                                'xy = ji
                                MkDir(gx + "\part1")
                                xy.Save(gx + "\part1" + "\Fuck" + hx(x) + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                                xy.Dispose()
                            Next
                        End If
                        If ComboBox1.SelectedIndex = 0 Then
                            My.Computer.FileSystem.WriteAllText(gx + "\desc.txt", CStr(NumericUpDown4.Value).Trim + " " + CStr(NumericUpDown3.Value).Trim + " " + CStr(NumericUpDown5.Value).Trim + vbCrLf + "p " + pk + " 0 part0" + vbCrLf, False, System.Text.Encoding.Default)
                        Else
                            My.Computer.FileSystem.WriteAllText(gx + "\desc.txt", CStr(NumericUpDown4.Value).Trim + " " + CStr(NumericUpDown3.Value).Trim + " " + CStr(NumericUpDown5.Value).Trim + vbCrLf + "p 1 0 part0" + vbCrLf + "p " + pk + " 0 part1" + vbCrLf, False, System.Text.Encoding.Default)
                        End If
                        Dim tcmd = xcmd
                        My.Computer.FileSystem.WriteAllText(tcmd, My.Resources.x1 + Main.za + My.Resources.x1 + " a -tzip " + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\$boot$.zip" + My.Resources.x1 + " " + My.Resources.x1 + gx + "\*" + My.Resources.x1 + " -mx0", False, System.Text.Encoding.Default)
                        Shell(tcmd, 0, True)
                        My.Computer.FileSystem.DeleteDirectory(gx, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        Kill(tcmd)
                        Main.shellme("Bootanimation Saving...", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\$boot$.zip" + My.Resources.x1 + " " + My.Resources.x1 + ComboBox3.Text + "/bootanimation.zip" + My.Resources.x1, xcmd, xmt)
                        MsgBox("Done!", MsgBoxStyle.Information)
                    Else
                        MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
                        DC.ShowDialog()
                        mlh = Main.mlh
                    End If
                End If
            End If
        End If
    End Sub
    Function hx(ByVal num As Integer)
        Dim kk As String = CStr(num).Trim
        If CStr(num).Trim.Length < 4 Then
            For x = CStr(num).Trim.Length To 4
                kk = "0" + kk
            Next
        End If
        Return kk
    End Function
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Button8_Click(Nothing, Nothing)
    End Sub
    Private Sub Tools_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
        Button6.Text = "Play"
    End Sub
    Dim mlh As String
    Dim xmmtt As String
    Dim xcmd As String
    Dim xmt As String
    Private Sub Tools_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        kx = My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\SSTmp"
        gx = My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\SSOutput"
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
        mlh = Main.mlh
        ComboBox1.SelectedIndex = 1
    End Sub
    Private Sub ListBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        On Error Resume Next
        PictureBox2.Image = Nothing
        PictureBox2.ImageLocation = ListBox1.Text
        Timer1.Enabled = False
        Button6.Text = "Play"
        If IsNothing(PictureBox2.Image) = False Then
            Label7.Text = CStr(PictureBox2.Image.Width) + "*" + CStr(PictureBox2.Image.Height)
        Else
            Label7.Text = ""
        End If
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        PictureBox2.Image = Nothing
        PictureBox2.ImageLocation = ListBox2.Text
        Timer1.Enabled = False
        Button6.Text = "Play"
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            ListBox2.Enabled = False
            TabControl2.SelectedIndex = 0
        Else
            ListBox2.Enabled = True
            TabControl2.SelectedIndex = 0
        End If
    End Sub
    Private Sub SetSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetSizeToolStripMenuItem.Click
        If PictureBox2.Image Is Nothing Or PictureBox2.Image Is PictureBox2.ErrorImage Then
        Else
            NumericUpDown4.Value = PictureBox2.Image.Width
            NumericUpDown3.Value = PictureBox2.Image.Height
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If IsNothing(PictureBox1.Image) = False Then
            If CheckBox2.Checked = True Then
                NumericUpDown1.Value = PictureBox1.Image.Width
                NumericUpDown2.Value = PictureBox1.Image.Height
            End If
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'MsgBox(("/" + ComboBox2.Text.Split("/")(1)).Trim.Replace("//", "/"))
        On Error Resume Next
        If Main.state().ToString.Trim = "device" Then
            If PictureBox1.Image Is Nothing Then
            Else
                ChDir(Main.signapk)
                Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\oemlogo.mbn")
                Dim xy As New Bitmap(CInt(NumericUpDown1.Value), CInt(NumericUpDown2.Value))
                If My.Computer.FileSystem.FileExists(zz) = True Then
                    xy = Image.FromFile(zz)
                    xy.Save(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\tmp.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                    If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\tmp.jpg") = True Then
                        Shell(My.Resources.x1 + Main.bootimg + My.Resources.x1 + " --repack-565 " + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\tmp.jpg" + My.Resources.x1 + " " + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\oemlogo.mbn" + My.Resources.x1, 0, True)
                        xy.Dispose()
                        Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\tmp.jpg")
                        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\oemlogo.mbn") = True Then
                            Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell mount -o remount,rw " + My.Resources.x1 + ("/" + ComboBox2.Text.Split("/")(1)).Trim.Replace("//", "/") + My.Resources.x1, 0, True)
                            'Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " mount -o remount,rw /system", 0, True)
                            Main.shellme("Logo Saving...", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\oemlogo.mbn" + My.Resources.x1 + " " + My.Resources.x1 + (ComboBox2.Text + "/oemlogo.mbn").Replace("//", "/") + My.Resources.x1, xcmd, xmt)
                            Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " push " + My.Resources.x1 + Main.oemlogo + My.Resources.x1 + " " + "/data/local/tmp/load_oemlogo" + vbCrLf + My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell chmod 777 " + "/data/local/tmp/load_oemlogo", xcmd, xmt)
                            Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell rm " + My.Resources.x1 + "/data/load_oemlogo.txt" + My.Resources.x1, xcmd, xmt)
                            Dim sde = Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " shell /data/local/tmp/load_oemlogo", xcmd, xmt).ToString.Replace(vbCrLf, "").Trim
                            If sde = "" Then
                                sde = "Done!"
                            End If
                            MsgBox(sde, MsgBoxStyle.Information, "Result")
                            Kill(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\load_oemlogo.txt")
                            Main.shellme("", My.Resources.x1 + Main.adb + My.Resources.x1 + " " + mlh + " pull " + My.Resources.x1 + "/data/load_oemlogo.txt" + My.Resources.x1 + " " + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\load_oemlogo.txt" + My.Resources.x1, xcmd, xmt)
                            TextBox1.Text = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\load_oemlogo.txt", System.Text.Encoding.Default)
                            If TextBox1.Text.Trim <> "" Then
                                TextBox1.Visible = True
                            Else
                                TextBox1.Visible = False
                            End If
                        Else
                            GoTo v
                        End If
                    Else
v:                      MsgBox("Failured!", MsgBoxStyle.Information)
                    End If
                Else
                    GoTo v
                End If
            End If
        Else
            MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
            DC.ShowDialog()
            mlh = Main.mlh
        End If
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
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
        kx = My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\SSTmp"
        gx = My.Computer.FileSystem.SpecialDirectories.Temp + "\ApkTest\" + xmmtt + "\SSOutput"
    End Function
    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text.Trim = "" Then
            ComboBox3.SelectedIndex = 0
        End If
    End Sub
End Class