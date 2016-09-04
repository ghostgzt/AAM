Public Class Filez
    Public pl
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        'MsgBox(TreeView1.SelectedNode.Level)
        On Error Resume Next
        'MsgBox(TreeView1.SelectedNode.Index())
        PictureBox1.Image = Nothing
        PictureBox1.Visible = False
        WebBrowser1.Url = Nothing
        WebBrowser1.Visible = False
        If (TreeView1.SelectedNode.Name) = "0" Then
            'MsgBox(TreeView1.SelectedNode.FullPath)
            ToolStripStatusLabel1.Text = ""
            ToolStripStatusLabel2.Text = ""
            StatusStrip1.Visible = False
            'MsgBox(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"))
            Dim dxq = My.Computer.FileSystem.GetDirectories(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"))
            Dim dfq = My.Computer.FileSystem.GetFiles(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"))
            TreeView1.SelectedNode.Nodes.Clear()
            For x = 0 To dxq.Count - 1
                TreeView1.SelectedNode.Nodes.Add("0", Main.getlast(dxq(x).Split("\")), 0)
            Next
            For x = 0 To dfq.Count - 1
                Dim hc = Main.getlast(dfq(x).ToLower.Split("."))
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
                TreeView1.SelectedNode.Nodes.Add(CStr(kz), Main.getlast(dfq(x).Split("\")), kz)
            Next
        Else
            StatusStrip1.Visible = True
            ToolStripStatusLabel2.Text = "File Type: " + Main.getlast(TreeView1.SelectedNode.Text.Split(".")).ToUpper
            ToolStripStatusLabel1.Text = "File Size: " + CStr(CInt(My.Computer.FileSystem.GetFileInfo(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")).Length / 1024)) + "KB"
            If TreeView1.SelectedNode.Name = "3" Then
                PictureBox1.Visible = True
                WebBrowser1.Visible = False
                PictureBox1.ImageLocation = (Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"))
            ElseIf TreeView1.SelectedNode.Name = "6" Or TreeView1.SelectedNode.Name = "5" Then
                WebBrowser1.Visible = True
                PictureBox1.Visible = False
                Dim xfs As New Uri(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"))
                WebBrowser1.Url = xfs
            End If
        End If
    End Sub
    Dim xcsw = 0
    Private Sub Filez_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        PictureBox1.Image = Nothing
        PictureBox1.Visible = False
        WebBrowser1.Url = Nothing
        WebBrowser1.Visible = False
        If xcsw = 0 Then
            Dim r = MsgBox("Do you want to save it before you leave ? ", MsgBoxStyle.YesNoCancel)
            If r = MsgBoxResult.Yes Then
                e.Cancel = True
                Button4_Click(Nothing, Nothing)
                spp = 0
                My.Computer.FileSystem.DeleteDirectory(Main.kwd, FileIO.DeleteDirectoryOption.DeleteAllContents)
                e.Cancel = False
                'GoTo a
            Else
                If r = MsgBoxResult.No Then
g:                  spp = 0
                    My.Computer.FileSystem.DeleteDirectory(Main.kwd, FileIO.DeleteDirectoryOption.DeleteAllContents)
                Else
                    e.Cancel = True
                End If
            End If
        Else
            GoTo g
        End If
        Exit Sub
        'a:      Me.Close()
    End Sub
    Function saveit(ByVal mode As Integer, ByVal fapk As String, ByVal nof As Integer)
        On Error Resume Next
        With New SaveFileDialog
            If nof = 1 Then
                .FileName = fapk
                GoTo k
            End If
            .FileName = Main.getlast(fapk.Split("\"))
            .Filter = "*.Apk|*.apk|*.*|*.*"
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
k:
                If nof = 1 Then
                    GoTo l
                End If
                ' ChDir(Main.za)
                If mode = 1 Then
                    My.Computer.FileSystem.DeleteDirectory(Main.ls1(.FileName, ".") + "\lib", FileIO.DeleteDirectoryOption.DeleteAllContents)
                    My.Computer.FileSystem.MoveDirectory(Main.kwd + "lib", Main.ls1(.FileName, ".") + "\lib", True)
                    .FileName = Main.ls1(.FileName, ".") + "\" + Main.getlast(.FileName.Split("\"))
                End If
                If My.Computer.FileSystem.FileExists(.FileName) = True Then
                    Main.shellme("Saving...", My.Resources.x1 + Main.za + My.Resources.x1 + " a -tzip " + My.Resources.x1 + .FileName + "x" + My.Resources.x1 + " " + My.Resources.x1 + Main.kwd + "*" + My.Resources.x1 + " -mx9", xcmd, xmt)
                    Kill(Main.ls1(.FileName, ".") + ".unchange.apk")
                    Rename(.FileName, Main.ls1(.FileName, ".") + ".unchange.apk")
                    Rename(.FileName + "x", .FileName)
                Else
l:                  Main.shellme("Saving...", My.Resources.x1 + Main.za + My.Resources.x1 + " a -tzip " + My.Resources.x1 + .FileName + My.Resources.x1 + " " + My.Resources.x1 + Main.kwd + "*" + My.Resources.x1 + " -mx9", xcmd, xmt)
                End If
                'If nof = 0 Then
                If MsgBox("Saved to " + vbCrLf + .FileName + vbCrLf + "Do you want to Sign this Apk ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Main.sign(.FileName, .FileName, 1)
                    Kill(Main.ls1(.FileName, ".") + ".unchange.apk")
                    MsgBox("Signed to" + vbCrLf + .FileName, MsgBoxStyle.Information)
                End If
                'End If
                xcsw = 1
                If mode = 1 Then
                    Me.Close()
                End If
            End If
        End With
    End Function
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If My.Computer.FileSystem.DirectoryExists(Main.kwd + "lib") = True Then
            Dim r = MsgBox("Do you want to TakeLibSave ?" + vbCrLf + "Y - Normal" + vbCrLf + "N - TakeLibSave" + vbCrLf + "C - Cancle", MsgBoxStyle.YesNoCancel)
            If r = MsgBoxResult.No Then
                saveit(1, ffapk, 0)
            ElseIf r = MsgBoxResult.Yes Then
                saveit(0, ffapk, 0)
            End If
        Else
            saveit(0, ffapk, 0)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        Dim apktmp = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\AkpTmp\"
        My.Computer.FileSystem.DeleteDirectory(apktmp, FileIO.DeleteDirectoryOption.DeleteAllContents)
        MkDir(apktmp)
        Dim nn = apktmp + Main.getlast(ffapk.Split("\"))
        'MsgBox(nn)
        saveit(0, nn, 1)
        'Main.sign(nn, nn, 1)
        Install.ListView1.Items.Clear()
        Install.ImageList1.Images.Clear()
        Install.fjar = 0
        Main.addxapk(nn)
        Install.ShowDialog()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        pl = Main.kwd
        xz = 0
        Lite.TabControl1.SelectedIndex = 0
        Lite.ShowDialog()
    End Sub
    Dim cpath
    Dim css
    Function pnglite(ByVal path As String, ByVal ss As Integer)
        On Error Resume Next
        cpath = path
        css = ss
        Lite.Close()
        BackgroundWorker1.RunWorkerAsync()
        Loading.ShowDialog()
    End Function
    Function ogglite(ByVal path As String, ByVal ss As Integer)
        On Error Resume Next
        cpath = path
        css = ss
        Lite.Close()
        BackgroundWorker2.RunWorkerAsync()
        Loading.ShowDialog()
    End Function
    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        On Error Resume Next
        If TreeView1.SelectedNode.Text <> "" Then
            If MsgBox("Do you want to Clear " + vbCrLf + Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If My.Computer.FileSystem.FileExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True And TreeView1.SelectedNode.Name <> "0" Then
                    Kill(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"))
                    My.Computer.FileSystem.WriteAllBytes(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), Nothing, False)
                Else
                    If My.Computer.FileSystem.DirectoryExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True And TreeView1.SelectedNode.Name = "0" Then
                        Dim gi = My.Computer.FileSystem.GetFiles(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"))
                        For x = 0 To gi.Count - 1
                            Kill(gi(x))
                            My.Computer.FileSystem.WriteAllBytes(gi(x), Nothing, False)
                        Next
                    End If
                End If
            End If
            If TreeView1.SelectedNode.Level <> 0 Then
                TreeView1.SelectedNode = TreeView1.SelectedNode.Parent
            Else
                Main.frefresh()
            End If
        End If
    End Sub
    Private Sub ReplaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceToolStripMenuItem.Click
        On Error Resume Next
        If TreeView1.SelectedNode.Text <> "" Then
            If My.Computer.FileSystem.FileExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True And TreeView1.SelectedNode.Name <> "0" Then
                Dim op As New OpenFileDialog
                With op
                    .FileName = ""
                    .Filter = "*.*|*.*"
                    .ShowDialog()
                    If .FileName <> "" Then
                        If MsgBox("Do you want to Replace " + vbCrLf + Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Kill(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"))
                            My.Computer.FileSystem.CopyFile(.FileName, Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), True)
                        End If
                    End If
                End With
            Else
                If My.Computer.FileSystem.DirectoryExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True And TreeView1.SelectedNode.Name = "0" Then
                    With New FolderBrowserDialog
                        .SelectedPath = ""
                        .Description = "Choose the Folder:"
                        .ShowNewFolderButton = False
                        .ShowDialog()
                        If .SelectedPath <> "" Then
                            My.Computer.FileSystem.DeleteDirectory(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), FileIO.DeleteDirectoryOption.DeleteAllContents)
                            My.Computer.FileSystem.CopyDirectory(.SelectedPath, Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), True)
                        End If
                    End With
                End If
            End If
            If TreeView1.SelectedNode.Level <> 0 Then
                TreeView1.SelectedNode = TreeView1.SelectedNode.Parent
            Else
                Main.frefresh()
            End If
        End If
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        On Error Resume Next
        If TreeView1.SelectedNode.Text <> "" Then
            If MsgBox("Do you want to Delete " + vbCrLf + Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If TreeView1.SelectedNode.Name = "0" Then
                    My.Computer.FileSystem.DeleteDirectory(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), FileIO.DeleteDirectoryOption.DeleteAllContents)
                    'If My.Computer.FileSystem.DirectoryExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = False Then
                    '    TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                    'End If
                Else
                    Kill(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"))
                    'If My.Computer.FileSystem.FileExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = False Then
                    '    TreeView1.Nodes.Remove(TreeView1.SelectedNode)
                    'End If
                End If
                If TreeView1.SelectedNode.Level <> 0 Then
                    TreeView1.SelectedNode = TreeView1.SelectedNode.Parent
                Else
                    Main.frefresh()
                End If
                'TreeView1.Nodes.Clear()
                'Main.frefresh()
            End If
        End If
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Main.frefresh()
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Shell("Rundll32.exe url.dll, FileProtocolHandler " + Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), AppWinStyle.NormalFocus)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Code.ShowDialog()
    End Sub
    Dim xz As Integer
    Private Sub LiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiteToolStripMenuItem.Click
        If My.Computer.FileSystem.DirectoryExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True And TreeView1.SelectedNode.Name = "0" Then
            pl = Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")
            xz = 0
            Lite.TabControl1.SelectedIndex = 0
            Lite.ShowDialog()
        Else
            If My.Computer.FileSystem.FileExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True Then
                pl = Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")
                xz = 1
                If Main.getlast(TreeView1.SelectedNode.FullPath.Replace("/", "\").Trim.Split(".")).Trim.ToLower = "png" Then
                    Lite.TabControl1.SelectedIndex = 0
                Else
                    Lite.TabControl1.SelectedIndex = 1
                End If
                Lite.ShowDialog()
            End If
        End If
    End Sub
    Dim pp As String
    Function add()
        On Error Resume Next
        Dim rq = MsgBox("Do you want to add Files or Directory ?" + vbCrLf + "Y - Files" + vbCrLf + "N - Directory" + vbCrLf + "C - Cancle", MsgBoxStyle.YesNoCancel)
        If rq = MsgBoxResult.Yes Then
            With New OpenFileDialog
                .FileName = ""
                .Multiselect = True
                .Filter = "*.*|*.*"
                .ShowDialog()
                If .FileNames.longlength <> 0 Then
                    For x = 0 To .FileNames.longlength - 1
                        My.Computer.FileSystem.CopyFile(.FileNames(x), pp + "\" + Main.getlast(.FileNames(x).Split("\")))
                    Next
                    If TreeView1.SelectedNode.Level <> 0 Then
                        TreeView1.SelectedNode = TreeView1.SelectedNode.Parent
                    Else
                        Main.frefresh()
                        'TreeView1.SelectedNode.Expand()
                    End If
                    MsgBox("Done!", vbInformation)
                End If
            End With
        Else
            If rq = MsgBoxResult.No Then
                With New FolderBrowserDialog
                    .SelectedPath = ""
                    .ShowNewFolderButton = False
                    .Description = "Choose a Directory"
                    .ShowDialog()
                    If .SelectedPath <> "" Then
                        My.Computer.FileSystem.CopyDirectory(.SelectedPath, pp + "\" + Main.getlast(.SelectedPath.Split("\")))
                        If TreeView1.SelectedNode.Level <> 0 Then
                            TreeView1.SelectedNode = TreeView1.SelectedNode.Parent
                        Else
                            Main.frefresh()
                            'TreeView1.SelectedNode.Expand()
                        End If
                        MsgBox("Done!", vbInformation)
                    End If
                End With
            End If
        End If
    End Function
    Private Sub AddHereToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddHereToolStripMenuItem.Click
        On Error Resume Next
        If My.Computer.FileSystem.DirectoryExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True And TreeView1.SelectedNode.Name = "0" Then
            pp = Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")
        Else
            If My.Computer.FileSystem.FileExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True Then
                If TreeView1.SelectedNode.Level <> 0 Then
                    pp = Main.kwd + Main.ls1(TreeView1.SelectedNode.FullPath.Replace("/", "\"), "\")
                Else
                    pp = Main.kwd
                End If
            Else
                GoTo r
            End If
        End If
        add()
        Exit Sub
r:
        If TreeView1.SelectedNode.Level <> 0 Then
            TreeView1.SelectedNode = TreeView1.SelectedNode.Parent
        Else
            Main.frefresh()
            'TreeView1.SelectedNode.Expand()
        End If
    End Sub
    Private Sub AddRootToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRootToolStripMenuItem.Click
        On Error Resume Next
        Dim xsa = 0
        If TreeView1.Nodes.Count = 0 Then
            xsa = 1
        End If
        pp = Main.kwd
        add()
        If xsa = 1 Then
            Main.frefresh()
            'TreeView1.SelectedNode.Expand()
        End If
    End Sub
    Private Sub ContextMenuStrip1_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If TreeView1.Nodes.Count = 0 Then
            CopyToToolStripMenuItem.Visible = False
            MoveToToolStripMenuItem.Visible = False
            ChangeToolStripMenuItem.Visible = False
            AddHereToolStripMenuItem.Visible = False
            OpenToolStripMenuItem.Visible = False
            ToolStripSeparator2.Visible = False
            ToolStripSeparator3.Visible = False
            ToolStripSeparator4.Visible = False
        Else
            If TreeView1.SelectedNode Is Nothing Then
                CopyToToolStripMenuItem.Visible = False
                MoveToToolStripMenuItem.Visible = False
                ChangeToolStripMenuItem.Visible = False
                AddHereToolStripMenuItem.Visible = False
                OpenToolStripMenuItem.Visible = False
                ToolStripSeparator2.Visible = False
                ToolStripSeparator3.Visible = False
                ToolStripSeparator4.Visible = False
            Else
                CopyToToolStripMenuItem.Visible = True
                MoveToToolStripMenuItem.Visible = True
                ChangeToolStripMenuItem.Visible = True
                AddHereToolStripMenuItem.Visible = True
                ToolStripSeparator4.Visible = True
                ToolStripSeparator3.Visible = True
                If TreeView1.SelectedNode.Name <> "0" Then
                    ToolStripSeparator2.Visible = True
                    OpenToolStripMenuItem.Visible = True
                Else
                    OpenToolStripMenuItem.Visible = False
                    ToolStripSeparator2.Visible = False
                End If
                If Main.getlast(TreeView1.SelectedNode.Text.Split(".")).Trim.ToLower = "png" Or Main.getlast(TreeView1.SelectedNode.Text.Split(".")).Trim.ToLower = "ogg" Or TreeView1.SelectedNode.Name = "0" Then
                    LiteToolStripMenuItem.Visible = True
                Else
                    LiteToolStripMenuItem.Visible = False
                End If
            End If
        End If
    End Sub
    Private Sub ExploreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExploreToolStripMenuItem.Click
        Shell("explorer " + Main.kwd, 1)
    End Sub
    Private Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        If TreeView1.SelectedNode.Name <> "0" Then
            OpenToolStripMenuItem_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub CopyToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToToolStripMenuItem.Click
        On Error Resume Next
        If TreeView1.SelectedNode.Text <> "" Then
            If My.Computer.FileSystem.FileExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True And TreeView1.SelectedNode.Name <> "0" Then
                Dim op As New SaveFileDialog
                With op
                    .FileName = TreeView1.SelectedNode.Text
                    .Filter = "*.*|*.*"
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        My.Computer.FileSystem.CopyFile(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), .FileName, FileIO.UIOption.AllDialogs)
                    End If
                End With
            Else
                If My.Computer.FileSystem.DirectoryExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True And TreeView1.SelectedNode.Name = "0" Then
                    With New FolderBrowserDialog
                        .SelectedPath = ""
                        .Description = "Choose the Folder:"
                        .ShowNewFolderButton = False
                        .ShowDialog()
                        If .SelectedPath <> "" Then
                            My.Computer.FileSystem.CopyDirectory(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), .SelectedPath, FileIO.UIOption.AllDialogs)
                        End If
                    End With
                End If
            End If
            MsgBox("Done!", vbInformation)
        End If
    End Sub
    Private Sub MoveToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoveToToolStripMenuItem.Click
        On Error Resume Next
        If TreeView1.SelectedNode.Text <> "" Then
            If My.Computer.FileSystem.FileExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True And TreeView1.SelectedNode.Name <> "0" Then
                Dim op As New SaveFileDialog
                With op
                    .FileName = TreeView1.SelectedNode.Text
                    .Filter = "*.*|*.*"
                    If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                        My.Computer.FileSystem.MoveFile(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), .FileName, FileIO.UIOption.AllDialogs)
                    End If
                End With
            Else
                If My.Computer.FileSystem.DirectoryExists(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\")) = True And TreeView1.SelectedNode.Name = "0" Then
                    With New FolderBrowserDialog
                        .SelectedPath = ""
                        .Description = "Choose the Folder:"
                        .ShowNewFolderButton = False
                        .ShowDialog()
                        If .SelectedPath <> "" Then
                            My.Computer.FileSystem.MoveDirectory(Main.kwd + TreeView1.SelectedNode.FullPath.Replace("/", "\"), .SelectedPath, FileIO.UIOption.AllDialogs)
                        End If
                    End With
                End If
            End If
            If TreeView1.SelectedNode.Level <> 0 Then
                TreeView1.SelectedNode = TreeView1.SelectedNode.Parent
            Else
                Main.frefresh()
            End If
            MsgBox("Done!", vbInformation)
        End If
    End Sub
    Public ppx As Integer
    Public ddx As Integer
    Public rrx As Integer
    Public ffx As String
    Function ui(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As Long
        On Error Resume Next
        Dim tcmd = xcmd
        ppx = 0
        ffx = ""
        'On Error Resume Next
        If xz = 0 Then
            Dim r = My.Computer.FileSystem.GetFiles(cpath, FileIO.SearchOption.SearchAllSubDirectories, "*.png")
            ddx = r.Count
            For x = 0 To r.Count - 1
                ffx = r(x)
                ppx = x
                rrx = 0
                'Kill(tcmd)
                ' ChDir(Main.za)
                If spp = 1 Then
                    GoTo o
                End If
                My.Computer.FileSystem.WriteAllText(tcmd, My.Resources.x1 + Main.png + My.Resources.x1 + " -force -ordered -nofloyd -nofs " + CStr(css) + " " + My.Resources.x1 + r(x) + My.Resources.x1, False, System.Text.Encoding.Default)
                Shell(tcmd, 0, True)
                rrx = 50
                If My.Computer.FileSystem.FileExists(Main.ls1(r(x), ".") + "-or8" + ".png") = True Then
                    My.Computer.FileSystem.MoveFile(Main.ls1(r(x), ".") + "-or8" + ".png", r(x), True)
                    '  Rename(.FileName + "x", .FileName)
                End If
                Kill(tcmd)
                ppx = x
                rrx = 100
            Next
            crr = CStr(r.Count) + " Pngs Haved Been Lited!"
        Else
            ffx = pl
            ppx = 0
            rrx = 0
            ddx = 1
            My.Computer.FileSystem.WriteAllText(tcmd, My.Resources.x1 + Main.png + My.Resources.x1 + " -force -ordered -nofloyd -nofs " + CStr(css) + " " + My.Resources.x1 + pl + My.Resources.x1, False, System.Text.Encoding.Default)
            Shell(tcmd, 0, True)
            If My.Computer.FileSystem.FileExists(Main.ls1(pl, ".") + "-or8" + ".png") = True Then
                My.Computer.FileSystem.MoveFile(Main.ls1(pl, ".") + "-or8" + ".png", pl, True)
                '  Rename(.FileName + "x", .FileName)
                'MsgBox(pl.ToString.Split("\"))        , MsgBoxStyle.Information)
            End If
            Kill(tcmd)
            ppx = 1
            rrx = 100
            crr = Main.getlast(pl.ToString.Split("\")) + " Haved Been Lited!"
o:      End If
    End Function
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ui(e.Argument, e.Result)
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Loading.Timer1.Enabled = False
        Loading.ProgressBar1.Value = 100
        Loading.ProgressBar2.Value = 100
        Loading.Label2.Text = "100%"
        Loading.Label4.Text = "100%"
        If spp = 1 Then
            crr = "Stopped!"
        End If
        spp = 0
        MsgBox(crr, MsgBoxStyle.Information)
        Loading.Close()
    End Sub
    Dim crr
    Function uii(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As Long
        Dim tcmd = xcmd
        On Error Resume Next
        ppx = 0
        ffx = ""
        If xz = 0 Then
            Dim r = My.Computer.FileSystem.GetFiles(cpath, FileIO.SearchOption.SearchAllSubDirectories, "*.ogg")
            ddx = r.Count
            For x = 0 To r.Count - 1
                ffx = r(x)
                ppx = x
                rrx = 0
                If spp = 1 Then
                    GoTo o
                End If
                'Kill(tcmd)
                ' ChDir(Main.za)
                rrx = 50
                My.Computer.FileSystem.WriteAllText(tcmd, My.Resources.x1 + Main.sox + My.Resources.x1 + " " + My.Resources.x1 + r(x) + My.Resources.x1 + " -C " + CStr(css) + " " + My.Resources.x1 + r(x) + My.Resources.x1, False, System.Text.Encoding.Default)
                Shell(tcmd, 0, True)
                Kill(tcmd)
                rrx = 100
                ppx = x
            Next
            crr = CStr(r.Count) + " Oggs Haved Been Lited!"
        Else
            ffx = pl
            ppx = 0
            rrx = 0
            ddx = 1
            My.Computer.FileSystem.WriteAllText(tcmd, My.Resources.x1 + Main.sox + My.Resources.x1 + " " + My.Resources.x1 + pl + My.Resources.x1 + " -C " + CStr(css) + " " + My.Resources.x1 + pl + My.Resources.x1, False, System.Text.Encoding.Default)
            Shell(tcmd, 0, True)
            Kill(tcmd)
            rrx = 100
            ppx = 1
            crr = Main.getlast(pl.ToString.Split("\")) + " Haved Been Lited!"
o:      End If
    End Function
    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        uii(e.Argument, e.Result)
    End Sub
    Public spp = 0
    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        Loading.Timer1.Enabled = False
        Loading.ProgressBar1.Value = 100
        Loading.ProgressBar2.Value = 100
        Loading.Label2.Text = "100%"
        Loading.Label4.Text = "100%"
        If spp = 1 Then
            crr = "Stopped!"
        End If
        spp = 0
        MsgBox(crr, MsgBoxStyle.Information)
        Loading.Close()
    End Sub
    Dim xmmtt As String
    Dim xcmd As String
    Dim xmt As String
    Public ffapk As String
    Private Sub Filez_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
        spp = 0
    End Sub
End Class