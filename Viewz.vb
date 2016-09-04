Public Class Viewz
    Public dus = 0
    Private Sub Viewz_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        'MsgBox(Setting.r1)
        If Setting.r1 <> "0" And dus = 0 Then
            e.Cancel = True
            Dim tcmd = xcmd
            Dim tmt = xmt
            If My.Computer.FileSystem.FileExists(tcmd) = True Then
                Kill(tcmd)
            End If
            If My.Computer.FileSystem.FileExists(tmt) = True Then
                Kill(tmt)
            End If
            ChDir(My.Application.Info.DirectoryPath)
            'Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " kill-server", 0, True)
            If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt) = True Then
                My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            'Main.Close()
            End
        Else
            e.Cancel = True
            spp = 0
            Me.Hide()
            Main.Show()
        End If
    End Sub
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Name <> "root" Then
            '  MsgBox(TreeView1.SelectedNode.FullPath.Replace("/", "\"))
            For x = 0 To ListView1.Items.Count - 1
                If ListView1.Items(x).SubItems(3).Text.Trim = TreeView1.SelectedNode.FullPath.Replace("/", "\").Trim Then
                    ListView1.SelectedIndices.Clear()
                    ListView1.SelectedIndices.Add(x)
                    ListView1.Items(x).EnsureVisible()
                End If
            Next
        End If
    End Sub
    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click
        If ListView1.SelectedItems.Count <> 0 Then
            Try
                If TreeView1.ContainsFocus = True Then
                    If TreeView1.SelectedNode Is Nothing Then
                    Else
                        Main.TextBox1.Text = TreeView1.SelectedNode.FullPath.Replace("/", "\")
                    End If
                ElseIf ListView1.ContainsFocus = True Then
                    Main.TextBox1.Text = ListView1.SelectedItems(0).SubItems(3).Text
                End If
                Main.fapp = Main.TextBox1.Text
                Main.setinfo(Main.getmf(Main.fapp, xcmd, xmt))
                Me.Hide()
                If Setting.r1 <> "0" Then
                    dus = 1
                End If
                Main.Show()
            Catch
            End Try
        End If
    End Sub
    Private Sub LargeIconToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LargeIconToolStripMenuItem.Click
        ListView1.View = View.LargeIcon
    End Sub
    Private Sub DetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailsToolStripMenuItem.Click
        ListView1.View = View.Details
        Me.ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        'me.ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
        'me.ListView1.Columns.Item(2).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
        Me.ListView1.Columns.Item(3).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub
    Function xc(ByVal sxs As Boolean)
        On Error Resume Next
        AddToInstallToolStripMenuItem.Visible = sxs
        LoadToolStripMenuItem.Visible = sxs
        OpenToolStripMenuItem.Visible = sxs
        CopyToToolStripMenuItem.Visible = sxs
        MoveToToolStripMenuItem.Visible = sxs
        DeleteToolStripMenuItem.Visible = sxs
        AttributeToolStripMenuItem.Visible = sxs
        ToolStripSeparator1.Visible = sxs
        ToolStripSeparator2.Visible = sxs
        ToolStripSeparator3.Visible = sxs
    End Function
    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If TreeView1.ContainsFocus = True Then
            If TreeView1.SelectedNode.Name = "root" Then
                xc(False)
            Else
                xc(True)
            End If
        ElseIf ListView1.ContainsFocus = True Then
            If ListView1.Items.Count = 0 Then
                xc(False)
            Else
                If ListView1.SelectedItems.Count <> 0 Then
                    xc(True)
                Else
                    xc(False)
                End If
            End If
        End If
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        On Error Resume Next
        If TreeView1.ContainsFocus = True Then
            If TreeView1.SelectedNode.Name = "root" Then
            Else
                Shell("rundll32.exe shell32.dll OpenAs_RunDLL " + TreeView1.SelectedNode.FullPath.Replace("/", "\"), AppWinStyle.NormalFocus)
            End If
        ElseIf ListView1.ContainsFocus = True Then
            Shell("rundll32.exe shell32.dll OpenAs_RunDLL " + ListView1.SelectedItems(0).SubItems(3).Text, AppWinStyle.NormalFocus)
        End If
    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        LoadToolStripMenuItem_Click(sender, e)
    End Sub
    Public Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        If Main.Label3.Text.Trim = "" Then
            Main.Label3.Text = My.Computer.FileSystem.SpecialDirectories.Desktop
        End If
        'Main.addapk(Main.Label3.Text)
        ToolStripComboBox3.Items.Remove(Main.Label3.Text)
        ToolStripComboBox3.Items.Insert(0, Main.Label3.Text)
        ToolStripComboBox3.SelectedIndex = 0
    End Sub
    Private Sub AddToInstallToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToInstallToolStripMenuItem.Click
        If Main.state().ToString.Trim = "device" Then
            Install.ListView1.Items.Clear()
            Install.ImageList1.Images.Clear()
            Install.ListView1.LargeImageList = Install.ImageList1
            Install.ListView1.SmallImageList = Install.ImageList1
            For x = 0 To ListView1.SelectedItems.Count - 1
                Install.ImageList1.Images.Add(ImageList1.Images(ListView1.Items.IndexOf(ListView1.SelectedItems(x))))
                Dim k = Install.ListView1.Items.Add(ListView1.SelectedItems(x).Text, x)
                k.SubItems.Add(ListView1.SelectedItems(x).SubItems(1))
                k.SubItems.Add(ListView1.SelectedItems(x).SubItems(2))
                k.SubItems.Add(ListView1.SelectedItems(x).SubItems(3))
                k.SubItems.Add("None")
            Next
            Install.ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
            'Viewz.ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
            'Viewz.ListView1.Columns.Item(2).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
            'Install.ListView1.Columns.Item(4).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
            Install.ShowDialog()
        Else
            MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
        End If
    End Sub
    Dim xs As New ListView
    Dim rs1 As New ImageList
    'Dim rs2 As New ImageList
    Dim ts As New TreeView
    Dim ls As New ListBox
    Dim lk As String
    Dim inn As Integer
    Dim oca As Integer
    Function vsp(ByVal ft As Integer)
        'MsgBox(xcmd)
        On Error Resume Next
        ToolStripStatusLabel4.Text = ""
        ToolStripStatusLabel3.Enabled = False
        ToolStripStatusLabel2.Enabled = False
        ToolStripDropDownButton2.Enabled = False
        RefreshToolStripMenuItem.Visible = False
        'If ft = 0 Then
        '    'ImageList1.Images.Clear()
        '    'ListView1.Items.Clear()
        '    'TreeView1.Nodes.Clear()
        '    'Me.Close()
        'End If
        ImageList2.Images.Clear()
        For s = 0 To ImageList3.Images.Count - 1
            ImageList2.Images.Add(ImageList3.Images(s))
        Next
        Me.ListView1.Items.Clear()
        Me.ImageList1.Images.Clear()
        Me.TreeView1.Nodes.Clear()
        Me.TreeView1.Nodes.Add("root", Main.Label3.Text)
        rs1.ColorDepth = ImageList1.ColorDepth
        rs1.ImageSize = ImageList1.ImageSize
        For x = 0 To ListView1.Columns.Count - 1
            xs.Columns.Add(ListView1.Columns(x).Text)
        Next
        ts.ImageList = rs1
        xs.LargeImageList = rs1
        xs.SmallImageList = rs1
        xs.Items.Clear()
        rs1.Images.Clear()
        ts.Nodes.Clear()
        ls.Items.Clear()
        'rs2.Images.Clear()
        ts.Nodes.Clear()
        lk = ""
        If ToolStripComboBox2.SelectedIndex = 0 Then
            For x = 0 To Main.ListBox1.Items.Count - 1

                ls.Items.Add(Main.ListBox1.Items(x))
            Next
            GoTo t
        End If
        Dim xy = ft
        If ((ft + 1) * CInt(ToolStripComboBox2.Text)) >= Main.ListBox1.Items.Count - 1 Then
            xy = Main.ListBox1.Items.Count
        Else
            xy = (ft + 1) * CInt(ToolStripComboBox2.Text)
        End If
        'MsgBox((0 + ft * 10) - 1)
        'MsgBox(xy - 1)
        For x = (0 + ft * CInt(ToolStripComboBox2.Text)) To xy - 1
            ls.Items.Add(Main.ListBox1.Items(x))
        Next
t:      lk = Main.Label3.Text
        oca = Setting.rx
        Timer1.Enabled = True
        BackgroundWorker1.RunWorkerAsync()
    End Function
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ui(e.Argument, e.Result)
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        On Error Resume Next
        For x = 0 To rs1.Images.Count - 1
            ImageList1.Images.Add(rs1.Images(x))
            ImageList2.Images.Add(rs1.Images(x))
        Next
        For x = 0 To xs.Items.Count - 1
            Dim k = ListView1.Items.Add(xs.Items(x).Name, xs.Items(x).Text, x)
            k.SubItems.Add(xs.Items(x).SubItems(1).Text)
            k.SubItems.Add(xs.Items(x).SubItems(2).Text)
            k.SubItems.Add(xs.Items(x).SubItems(3).Text)
        Next
        For x = 0 To ts.Nodes.Count - 1
            TreeView1.Nodes(0).Nodes.Add(ts.Nodes(x).Name, ts.Nodes(x).Text, x + 2)
        Next
        Me.ListView1.Columns.Item(0).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        'me.ListView1.Columns.Item(1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
        'me.ListView1.Columns.Item(2).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
        Me.ListView1.Columns.Item(3).AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent)
        TreeView1.ExpandAll()
        'Me.ShowDialog()
        ToolStripProgressBar1.Value = 100
        Timer1.Enabled = False
        ToolStripStatusLabel3.Enabled = True
        ToolStripStatusLabel2.Enabled = True
        ToolStripDropDownButton2.Enabled = True
        If spp = 1 Then
            MsgBox("Stopped!", MsgBoxStyle.Information)
            spp = 0
        End If
        For x = 0 To ToolStrip1.Items.Count - 1
            ToolStrip1.Items(x).Enabled = True
        Next
        RefreshToolStripMenuItem.Visible = True
        StatusStrip1.Enabled = True
    End Sub
    Function ui(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As Long
        On Error Resume Next
        For x = 0 To ls.Items.Count - 1
            MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\res")
            If spp = 1 Then
                GoTo c
            End If
            inn = x
            Dim df = lk + "\" + ls.Items(x).ToString.Replace(lk, "")
            Dim de = Main.getmf(df, xcmd, xmt)
            'MsgBox(xcmd)
            Dim dx = Main.getinfo(de, "label=")
            If oca = "1" And dx.ToString.Trim = "" Then
                GoTo l
            End If
            Dim dy = Main.getinfo(de, "versionName=")
            Dim dz = CStr(CInt(My.Computer.FileSystem.GetFileInfo(df).Length / 1024)) + "KB"
            Dim sp = Main.getinfo(de, "icon=")
            Dim xp = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\res\" + sp.ToString.Replace("/", "\")
            ' MsgBox(sp)
            Shell(My.Resources.x1 + Main.za + My.Resources.x1 + " x -o" + My.Resources.x1 + My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\res" + My.Resources.x1 + " -y " + My.Resources.x1 + df + My.Resources.x1 + " " + My.Resources.x1 + sp + My.Resources.x1, 0, True)
            Dim dqx As New PictureBox
            dqx.WaitOnLoad = True
            dqx.ImageLocation = xp
            If dqx.Image Is Nothing Then
                dqx.Image = dqx.ErrorImage
            End If
            rs1.Images.Add(dqx.Image)
            'rs2.Images.Add(dqx.Image)
            'Kill(xp)
            My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\res", FileIO.DeleteDirectoryOption.DeleteAllContents)
            Dim k = xs.Items.Add(dx)
            k.SubItems.Add(dy)
            k.SubItems.Add(dz)
            k.SubItems.Add(df)
            ts.Nodes.Add("Apk", df.Replace(lk + "\", ""))
            l:  
        Next
c:
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripProgressBar1.Value = ((inn + 1) / ls.Items.Count) * 100
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TreeView1.Nodes.Count <> 0 Then
            If SplitContainer1.Panel1Collapsed = False Then
                SplitContainer1.Panel1Collapsed = True
            Else
                SplitContainer1.Panel1Collapsed = False
            End If
        End If
    End Sub
    Private Sub ToolStripStatusLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel3.Click
        If (ToolStripComboBox1.SelectedIndex - 1) >= 0 Then
            ToolStripComboBox1.SelectedIndex = ToolStripComboBox1.SelectedIndex - 1
        End If
    End Sub
    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click
        If (ToolStripComboBox1.SelectedIndex + 1) <= ToolStripComboBox1.Items.Count - 1 Then
            ToolStripComboBox1.SelectedIndex = ToolStripComboBox1.SelectedIndex + 1
        End If
    End Sub
    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        vsp(ToolStripComboBox1.SelectedIndex)
    End Sub
    Private Sub ToolStripComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox2.SelectedIndexChanged
        If Setting.fis = 1 Then
            Setting.fis = 0
        Else
            vs()
        End If
    End Sub
    Private Sub CopyToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToToolStripMenuItem.Click
        If ListView1.SelectedItems.Count <> 0 Then
            With New FolderBrowserDialog
                .SelectedPath = ""
                .Description = "Choose a path :"
                .ShowNewFolderButton = True
                .ShowDialog()
                If .SelectedPath <> "" Then
                    For x = 0 To ListView1.SelectedItems.Count - 1
                        My.Computer.FileSystem.CopyFile(ListView1.SelectedItems(x).SubItems(3).Text, .SelectedPath + "\" + Main.getlast(ListView1.SelectedItems(x).SubItems(3).Text.Split("\")), FileIO.UIOption.AllDialogs)
                    Next
                End If
            End With
        End If
    End Sub
    Private Sub MoveToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToToolStripMenuItem.Click
        On Error Resume Next
        If ListView1.SelectedItems.Count <> 0 Then
            With New FolderBrowserDialog
                .SelectedPath = ""
                .Description = "Choose a path :"
                .ShowNewFolderButton = True
                .ShowDialog()
                If .SelectedPath <> "" Then
                    For x = 0 To ListView1.SelectedItems.Count - 1
                        Dim xhs = ListView1.SelectedItems(0).Index
                        My.Computer.FileSystem.MoveFile(ListView1.Items(xhs).SubItems(3).Text, .SelectedPath + "\" + Main.getlast(ListView1.Items(xhs).SubItems(3).Text.Split("\")), FileIO.UIOption.AllDialogs)
                        'My.Computer.FileSystem.DeleteFile(ListView1.SelectedItems(x).SubItems(3).Text)
                        If My.Computer.FileSystem.FileExists(ListView1.Items(xhs).SubItems(3).Text) = False Then
                            'ImageList1.Images.RemoveAt(ListView1.Items(xhs).ImageIndex)
                            ListView1.Items.Remove(ListView1.Items(xhs))
                            TreeView1.Nodes(0).Nodes.RemoveAt(xhs)
                        End If
                    Next
                    'vs()
                End If
            End With
        End If
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        On Error Resume Next
        If ListView1.SelectedItems.Count <> 0 Then
            If MsgBox("Do you want to Delete these files ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For x = 0 To ListView1.SelectedItems.Count - 1
                    Dim xhs = ListView1.SelectedItems(0).Index
                    My.Computer.FileSystem.DeleteFile(ListView1.Items(xhs).SubItems(3).Text)
                    If My.Computer.FileSystem.FileExists(ListView1.Items(xhs).SubItems(3).Text) = False Then
                        'ImageList1.Images.RemoveAt(ListView1.Items(xhs).ImageIndex)
                        ListView1.Items.Remove(ListView1.Items(xhs))
                        TreeView1.Nodes(0).Nodes.RemoveAt(xhs)
                    End If
                Next
                'vs()
            End If
        End If
    End Sub
    Private Sub AttributeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttributeToolStripMenuItem.Click
        If ListView1.SelectedItems.Count <> 0 Then
            If ListView1.SelectedIndices.Count = 1 Then
                MsgBox("Label : " + ListView1.SelectedItems(0).SubItems(0).Text + vbCrLf + "Version : " + ListView1.SelectedItems(0).SubItems(1).Text + vbCrLf + "Size : " + ListView1.SelectedItems(0).SubItems(2).Text + vbCrLf + "File : " + ListView1.SelectedItems(0).SubItems(3).Text, MsgBoxStyle.Information, "Attribute")
            Else
                Dim sum As Integer = 0
                For x = 0 To ListView1.SelectedItems.Count - 1
                    sum = sum + CInt(ListView1.SelectedItems(0).SubItems(2).Text.Replace("KB", ""))
                Next
                MsgBox("Selected: " + CStr(ListView1.SelectedIndices.Count).Trim + "/" + CStr(ListView1.Items.Count).Trim + vbCrLf + "Size: " + CStr(sum).Trim + "KB", MsgBoxStyle.Information, "Attribute")
            End If
        End If
    End Sub
    Public Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim fo As New FolderBrowserDialog
        With fo
            .SelectedPath = ""
            .Description = "Choose a path:"
            .ShowNewFolderButton = False
            .ShowDialog()
            If .SelectedPath <> "" Then
                Main.Label3.Text = .SelectedPath
                Main.addapk(Main.Label3.Text)
                ToolStripComboBox3.Items.Remove(Main.Label3.Text)
                ToolStripComboBox3.Items.Insert(0, Main.Label3.Text)
                ToolStripComboBox3.SelectedIndex = 0
                'Me.Text = "Apk Explorer - " + Main.Label3.Text
                'RefreshToolStripMenuItem_Click(Nothing, Nothing)
            End If
        End With
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        RefreshToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        LoadToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        If ListView1.SelectedItems.Count <> 0 Then
            Main.kwd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + (Date.Now.ToString.Replace("/", "_").Replace(":", "_").Trim) + "\"
            Main.shellme("Loading...", My.Resources.x1 + Main.za + My.Resources.x1 + " x -o" + My.Resources.x1 + Main.kwd + My.Resources.x1 + " -y " + My.Resources.x1 + ListView1.SelectedItems(0).SubItems(3).Text + My.Resources.x1, xcmd, xmt)
            Filez.Text = "Apk Editor - " + ListView1.SelectedItems(0).SubItems(3).Text
            Filez.ffapk = ListView1.SelectedItems(0).SubItems(3).Text
            Main.frefresh()
            Me.Hide()
            Filez.ShowDialog()
            Me.Show()
        End If
    End Sub
    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        On Error Resume Next
w:
        If Main.state().ToString.Trim = "device" Then
            Install.ListView1.Items.Clear()
            Install.ImageList1.Images.Clear()
            For x = 0 To ListView1.SelectedItems.Count - 1
                Main.addxapk(ListView1.SelectedItems(x).SubItems(3).Text)
            Next
            Me.Hide()
            Install.ShowDialog()
            Me.Show()
        Else
            MsgBox("1.Please Connect the Android Phone to PC !" + vbCrLf + "2.Confirm you had been opened the USB debugging ! " + vbCrLf + "3.Install the drive files of your Android Phone!" + vbCrLf + "4.Choose you Device!!!", MsgBoxStyle.Information)
            If DC.ShowDialog() = Windows.Forms.DialogResult.OK Then
                GoTo w
            Else
            End If
        End If
    End Sub
    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        OpenToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        CopyToToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        MoveToToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        DeleteToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton16.Click
        If ListView1.SelectedItems.Count <> 0 Then
            If MsgBox("Do you want to ReName these Files ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Hide()
                Main.NotifyIcon1.Icon = Me.Icon
                For x = 0 To ListView1.SelectedItems.Count - 1
                    With Main.NotifyIcon1
                        If ("ReNaming " + ListView1.SelectedItems(x).Text).Length > 64 Then
                            .Text = "ReNaming " + ListView1.SelectedItems(x).Text.Remove(51) + "..."
                        Else
                            .Text = "ReNaming " + ListView1.SelectedItems(x).Text
                        End If
                        .BalloonTipText = "ReNaming " + ListView1.SelectedItems(x).Text
                        .BalloonTipIcon = ToolTipIcon.Info
                        .BalloonTipTitle = "Apk Manager"
                        .ShowBalloonTip(500)
                    End With
                    Dim xls = Main.rnapk(ListView1.SelectedItems(x).SubItems(3).Text)
                    If xls.ToString.Trim = "" Then
                        GoTo z
                    End If
                    If My.Computer.FileSystem.FileExists(Main.ls1(ListView1.SelectedItems(x).SubItems(3).Text, "\") + "\" + xls) = True Then
                        ListView1.SelectedItems(x).SubItems(3).Text = Main.ls1(ListView1.SelectedItems(x).SubItems(3).Text, "\") + "\" + xls
                    End If
                    z:
                Next
                Me.Show()
                Main.NotifyIcon1.Icon = Nothing
                'RefreshToolStripMenuItem_Click(sender, e)
                MsgBox("ReNamed!", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        AttributeToolStripMenuItem_Click(Nothing, Nothing)
    End Sub
    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        Me.Hide()
        dus = 0
        FileD.ShowDialog()
        'MsgBox(Main.WindowState)
        If Setting.r1 <> "0" Then
            If dus = 1 Then
                Main.Show()
            Else
                Me.Show()
            End If
        Else
            Main.Show()
        End If
    End Sub
    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Me.Hide()
        Apps.ShowDialog()
        Me.Show()
    End Sub
    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        Me.Hide()
        Tools.ShowDialog()
        Me.Show()
    End Sub
    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        Me.Hide()
        Setting.ShowDialog()
        Me.Show()
    End Sub
    Dim mlh As String
    Dim xmmtt As String
    Dim xcmd As String
    Dim xmt As String
    Private Sub Viewz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
        xmmtt = Main.xmmtt
        mlh = Main.mlh
        dus = 0
    End Sub
    Private Sub ToolStripComboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox3.SelectedIndexChanged
        If ToolStripComboBox3.Text <> "" Then
            Main.Label3.Text = ToolStripComboBox3.Text
            Main.addapk(Main.Label3.Text)
            vs()
        End If
    End Sub
    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        If ListView1.SelectedItems.Count = ListView1.Items.Count Then
            ListView1.SelectedIndices.Clear()
        Else
            For x = 0 To ListView1.Items.Count - 1
                ListView1.SelectedIndices.Add(x)
            Next
        End If
    End Sub
    Dim spp = 0
    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton17.Click
        If Timer1.Enabled = True Then
            BackgroundWorker1.CancelAsync()
            spp = 1
        Else
            spp = 0
        End If
    End Sub
    Function vs()
        For x = 0 To ToolStrip1.Items.Count - 1
            ToolStrip1.Items(x).Enabled = False
        Next
        RefreshToolStripMenuItem.Visible = False
        ToolStripButton17.Enabled = True
        StatusStrip1.Enabled = False
        On Error Resume Next
        Main.RefreshToolStripMenuItem_Click(Nothing, Nothing)
        Me.Text = "Apk Explorer - " + Main.Label3.Text
        If ToolStripComboBox2.Text = "" Then
            ToolStripComboBox2.SelectedIndex = 1
        Else
            If ToolStripComboBox2.SelectedIndex = 0 Then
                ToolStripComboBox1.Items.Clear()
                ToolStripComboBox1.Items.Add("Page " + CStr(0))
                GoTo c
            End If
        End If
        Dim kc = CInt(Main.ListBox1.Items.Count / CInt(ToolStripComboBox2.Text))
        'MsgBox(kc)
        If kc * 10 >= Main.ListBox1.Items.Count Then
            'MsgBox(kc)
        Else
            If kc * 10 < Main.ListBox1.Items.Count Then
                kc = kc + 1
            End If
        End If
        ToolStripComboBox1.Items.Clear()
        For x = 1 To kc
            ToolStripComboBox1.Items.Add("Page " + CStr(x))
        Next
c:      ToolStripComboBox1.SelectedIndex = 0
        vsp(0)
    End Function
    Private Sub ListView1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragDrop
        Dim xu = (e.Data.GetData(System.Windows.Forms.DataFormats.FileDrop, True))
        If My.Computer.FileSystem.DirectoryExists(xu(0).ToString) = True Then
            If MsgBox("Do you want to open " + xu(0).ToString + " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Main.Label3.Text = xu(0).ToString
                Main.addapk(Main.Label3.Text)
                ToolStripComboBox3.Items.Remove(Main.Label3.Text)
                ToolStripComboBox3.Items.Insert(0, Main.Label3.Text)
                ToolStripComboBox3.SelectedIndex = 0
            End If
        Else
            'MsgBox(xu.length)
            If MsgBox("Do you want to Copy These Apk Files To Here ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For x = 0 To xu.length - 1
                    If My.Computer.FileSystem.FileExists(xu(x).ToString) = True Then
                        If Main.getlast(xu(x).ToString.Split(".")).ToLower.Trim = "apk" Then
                            On Error GoTo s
                            If Main.Label3.Text = "" Then
                                RefreshToolStripMenuItem_Click(Nothing, Nothing)
                            End If
                            My.Computer.FileSystem.CopyFile(xu(x).ToString, Main.Label3.Text + "\" + Main.getlast(xu(x).ToString.Split("\")), FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                        End If
                    End If
                Next
                RefreshToolStripMenuItem_Click(Nothing, Nothing)
            End If
        End If
        Exit Sub
s:      MsgBox("Failured!!!", MsgBoxStyle.Information)
    End Sub
    Private Sub ListView1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragEnter
        e.Effect = DragDropEffects.All
    End Sub
    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        On Error Resume Next
        If ListView1.SelectedItems.Count <> 0 Then
            If ListView1.SelectedIndices.Count = 1 Then
                If ListView1.View = View.LargeIcon Then
                    ToolStripStatusLabel4.Text = "--> Version: " + ListView1.SelectedItems(0).SubItems(1).Text + " | " + "Size: " + ListView1.SelectedItems(0).SubItems(2).Text + " | " + "Path: " + ListView1.SelectedItems(0).SubItems(3).Text
                Else
                    ToolStripStatusLabel4.Text = "Made By GhostGzt(Gentle) In 2012"
                End If
            Else
                Dim sum As Integer = 0
                For x = 0 To ListView1.SelectedItems.Count - 1
                    sum = sum + CInt(ListView1.SelectedItems(0).SubItems(2).Text.Replace("KB", ""))
                Next
                ToolStripStatusLabel4.Text = "Selected: " + CStr(ListView1.SelectedIndices.Count).Trim + "/" + CStr(ListView1.Items.Count).Trim + " | " + "Size: " + CStr(sum).Trim + "KB"
            End If
        Else
            ToolStripStatusLabel4.Text = "Made By GhostGzt(Gentle) In 2012"
        End If
    End Sub
    Private Sub ToolStripButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton18.Click
        Me.Hide()
        AboutBox.ShowDialog()
        Shell(My.Application.Info.DirectoryPath + "\Tools\About.exe" + " " + CStr(CInt((New Random).Next(0, 3))), 1, True)
        ToolStripButton20_Click(Nothing, Nothing)
        Me.Show()
    End Sub
    Private Sub ToolStripButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton19.Click
        Me.Hide()
        DC.ShowDialog()
        Me.Show()
    End Sub

    Public Sub ToolStripButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton20.Click
        On Error Resume Next
        Dim r = MsgBox("如果你觉得这个软件方便有用," + vbCrLf + "请往我的支付宝捐助1块钱以表支持！谢谢！" + vbCrLf + "支付宝: ghostgzt@163.com" + vbCrLf + "Y - 捐助我，打开支付宝！" + vbCrLf + "N - 打开Gentle网站！", MsgBoxStyle.YesNoCancel)
        If r = MsgBoxResult.Yes Then
            Shell("explorer https://www.alipay.com/", AppWinStyle.MaximizedFocus, False)
        Else
            If r = MsgBoxResult.No Then
                Shell("explorer http://ghostgzt.7ta.cn/", AppWinStyle.MaximizedFocus, False)
            End If
        End If
    End Sub
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        ToolStripButton20_Click(Nothing, Nothing)
    End Sub
    'Private Sub ToolStripButton21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton21.Click
    '    On Error Resume Next
    '    Install.ListView1.Items.Clear()
    '    Install.Show()
    '    Install.SKRom推荐ToolStripMenuItem_Click(Nothing, Nothing)

    'End Sub
End Class