Public Class Code
    Function uncomp(ByVal fapk As String, ByVal out As String)
        On Error Resume Next
        Dim tcmd = xcmd
        'Kill(tcmd)
        ChDir(Main.signapk)
        My.Computer.FileSystem.WriteAllText(tcmd, My.Resources.x1 + Main.java + My.Resources.x1 + " -jar " + My.Resources.x1 + Main.apktool + My.Resources.x1 + " d -d -f " + My.Resources.x1 + fapk + My.Resources.x1 + " " + My.Resources.x1 + out + My.Resources.x1, False, System.Text.Encoding.Default)
        Shell(tcmd, 0, True)
        'Kill(tcmd)
    End Function
    Function comp(ByVal oapk As String, ByVal imp As String)
        On Error Resume Next
        Dim tcmd = xcmd
        'Kill(tcmd)
        ChDir(Main.signapk)
        My.Computer.FileSystem.WriteAllText(tcmd, My.Resources.x1 + Main.java + My.Resources.x1 + " -jar " + My.Resources.x1 + Main.apktool + My.Resources.x1 + " b -d -f " + My.Resources.x1 + imp + My.Resources.x1 + " " + My.Resources.x1 + oapk + My.Resources.x1, False, System.Text.Encoding.Default)
        Shell(tcmd, 0, True)
        'Kill(tcmd)
    End Function
    Dim tmi = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + Main.getinfo(Main.getmf(Main.fapp, xcmd, xmt), "name=") + "_UnCompiled"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        With New FolderBrowserDialog
            .SelectedPath = ""
            .Description = "Please Choose the Path:"
            .ShowNewFolderButton = True
            .ShowDialog()
            If .SelectedPath <> "" Then
                uncomp(Filez.ffapk, .SelectedPath + "\" + Main.getinfo(Main.getmf(Filez.ffapk, xcmd, xmt), "name=") + "_UnCompiled")
                MsgBox("Done!", MsgBoxStyle.Information)
                'read(tmi, 0)
            End If
        End With
    End Sub
    Function read(ByVal path As String, ByVal nof As Integer)
        On Error Resume Next
        Dim xb As TreeNode
        If nof = 0 Then
            xb = TreeView1.TopNode
        Else
            xb = TreeView1.SelectedNode
        End If
        xb.Nodes.Clear()
        Dim dd = My.Computer.FileSystem.GetDirectories(path)
        Dim df = My.Computer.FileSystem.GetFiles(path)
        For x = 0 To dd.Count - 1
            xb.Nodes.Add("0", dd(x).Replace(path + "\", ""), 0)
        Next
        For y = 0 To df.Count - 1
            Dim hc = Main.getlast(df(y).ToLower.Split("."))
            Dim kz = 1
            If hc.ToLower.Trim = "xml" Then
                kz = 2
            Else
                If hc = "png" Or hc = "jpg" Or hc = "bmp" Or hc = "gif" Then
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
            xb.Nodes.Add(CStr(kz), df(y).Replace(path + "\", ""), kz)
        Next
        xb.Expand()
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'With New FolderBrowserDialog
        '    .SelectedPath = ""
        '    .ShowNewFolderButton = True
        '    .ShowDialog()
        '    Dim kxe = .SelectedPath
        '    If .SelectedPath <> "" Then
        With New SaveFileDialog
            .FileName = ""
            .Filter = "*.Apk|*.apk|*.*|*.*"
            .ShowDialog()
            If .FileName <> "" Then
                comp(.FileName, tmi)
                If My.Computer.FileSystem.FileExists(.FileName) = True Then
                    If MsgBox("Do you want to sign it ? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Main.sign(.FileName, .FileName, 0)
                    End If
                Else
                    MsgBox("Done!", MsgBoxStyle.Information)
                End If
            End If
        End With
        '    End If
        'End With
    End Sub
    Private Sub Code_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        My.Computer.FileSystem.DeleteDirectory(tmi, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Sub
    Dim xmmtt As String
    Dim xcmd As String
    Dim xmt As String
    Private Sub Code_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        tmi = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\" + Main.getinfo(Main.getmf(Filez.ffapk, xcmd, xmt), "name=") + "_UnCompiled"
        MkDir(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt)
        'MsgBox(tmi)
        TreeView1.Nodes.Clear()
        TreeView1.ImageList = Filez.ImageList1
        TreeView1.SelectedImageIndex = 7
        TreeView1.Nodes.Add("x", Main.getinfo(Main.getmf(Filez.ffapk, xcmd, xmt), "name="), 0)
        My.Computer.FileSystem.DeleteDirectory(tmi, FileIO.DeleteDirectoryOption.DeleteAllContents)
        If My.Computer.FileSystem.FileExists(Main.java) = False Then
            MsgBox("Please Choose a JRE!", MsgBoxStyle.Information)
            With New OpenFileDialog
                .FileName = "Java.exe"
                .Filter = "Java.exe|Java.exe"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Main.java = .FileName
                    My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx")
                    My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx\Apk_Manager")
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Manager", "JRE", Main.java)
                Else
                    MsgBox("Failured!", MsgBoxStyle.Information)
                    Me.Close()
                End If
            End With
        End If
        uncomp(Filez.ffapk, tmi)
        read(tmi, 0)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Shell("explorer " + My.Resources.x1 + tmi + My.Resources.x1, 1)
    End Sub
    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        read(tmi + TreeView1.SelectedNode.FullPath.Replace(TreeView1.SelectedNode.FullPath.Split("\")(0), ""), 1)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TreeView1.SelectedNode Is Nothing Then
        Else
            If TreeView1.SelectedNode.Name <> "0" And TreeView1.SelectedNode.Name <> "x" Then
                Shell("Rundll32.exe url.dll, FileProtocolHandler " + tmi + TreeView1.SelectedNode.FullPath.Replace(TreeView1.SelectedNode.FullPath.Split("\")(0), ""), AppWinStyle.NormalFocus)
            End If
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Code_Load(Nothing, Nothing)
    End Sub
    Private Sub TreeView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView1.DoubleClick
        Button4_Click(Nothing, Nothing)
    End Sub
End Class