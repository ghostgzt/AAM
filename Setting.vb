Public Class Setting
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TabControl1.SelectedIndex = 0
        rd()
    End Sub
    Dim ori As String
    Public r1 As String
    Public r2 As String
    Public r3 As String
    Public r4 As String
    Public r5 As String
    Public r6 As String
    Public r7 As String
    Public r8 As String
    Public r9 As String
    Public r0 As String
    Public ra As String
    Public rb As String
    Public rx As String
    Public rc As String
    Public rv As String
    Public fis As Integer
    Function rd()
        On Error Resume Next
        ori = r1
        My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx")
        My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx\Apk_Explorer")
        r1 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Explorer", "Run", Nothing)
        'r1 = "1"
        If r1 = "0" Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If
        If r1.Trim = "" Then
            r1 = "1"
        End If
        r2 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Explorer", "View", Nothing)
        If r2 = "1" Then
            CheckBox2.Checked = True
            Viewz.ListView1.View = View.LargeIcon
        Else
            CheckBox2.Checked = False
            Viewz.ListView1.View = View.Details
        End If
        r3 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Explorer", "VPages", Nothing)
        ComboBox1.SelectedIndex = 1
        'Viewz.ToolStripComboBox2.SelectedIndex = 1
        If r3.Trim <> "" Then
            ComboBox1.SelectedIndex = CInt(r3.Trim)
            Viewz.ToolStripComboBox2.SelectedIndex = CInt(r3.Trim)
        Else
            ComboBox1.SelectedIndex = 1
            Viewz.ToolStripComboBox2.SelectedIndex = 1
        End If
        rx = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Explorer", "OCA", Nothing)
        If rx = "1" Then
            CheckBox3.Checked = True
        Else
            CheckBox3.Checked = False
        End If
        rc = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Explorer", "DHP", Nothing)
        'rc = "1"
        If rc = "0" Then
            CheckBox5.Checked = False
        Else
            CheckBox5.Checked = True
        End If
        If rc.Trim = "" Then
            rc = "1"
        End If
        My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx\Install")
        r4 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Install", "Gzip", Nothing)
        ComboBox4.SelectedIndex = 9
        If r4.Trim <> "" Then
            ComboBox4.SelectedIndex = CInt(r4.Trim)
            Install.ComboBox4.SelectedIndex = CInt(r4.Trim)
        Else
            Install.ComboBox4.SelectedIndex = 9
            ComboBox4.SelectedIndex = 9
        End If
        r5 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Install", "Name", Nothing)
        ComboBox5.SelectedIndex = 1
        If r5.Trim <> "" Then
            ComboBox5.SelectedIndex = CInt(r5.Trim)
            Install.ComboBox1.SelectedIndex = CInt(r5.Trim)
        Else
            ComboBox5.SelectedIndex = 1
            Install.ComboBox1.SelectedIndex = 1
        End If
        r6 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Install", "Lib", Nothing)
        ComboBox3.SelectedIndex = 0
        If r6.Trim <> "" Then
            ComboBox3.SelectedIndex = CInt(r6.Trim)
            Install.ComboBox3.SelectedIndex = CInt(r6.Trim)
        Else
            ComboBox3.SelectedIndex = 0
            Install.ComboBox3.SelectedIndex = 0
        End If
        r7 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Install", "InsTo", Nothing)
        ComboBox2.SelectedIndex = 0
        If r7.Trim <> "" Then
            ComboBox2.SelectedIndex = CInt(r7.Trim)
            Install.ComboBox2.SelectedIndex = CInt(r7.Trim)
        Else
            ComboBox2.SelectedIndex = 0
            Install.ComboBox2.SelectedIndex = 0
        End If
        r8 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Install", "WT", Nothing)
        NumericUpDown1.Value = 0
        If r8.Trim <> "" Then
            NumericUpDown1.Value = CInt(r8.Trim)
            Install.NumericUpDown1.Value = CInt(r8.Trim)
        Else
            NumericUpDown1.Value = 0
            Install.NumericUpDown1.Value = 0
        End If
        r9 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Install", "AF", Nothing)
        If r9.Trim = "1" Then
            CheckBox4.Checked = True
            Install.CheckBox4.Checked = True
        Else
            CheckBox4.Checked = False
            Install.CheckBox4.Checked = False
        End If
        My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx\Lite")
        r0 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Lite", "PC", Nothing)
        ComboBox6.Text = "256"
        If r0.Trim <> "" Then
            ComboBox6.Text = r0.Trim
            Lite.ComboBox1.Text = r0.Trim
        Else
            ComboBox6.Text = "256"
            Lite.ComboBox1.Text = "256"
        End If
        ra = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Lite", "OQ", Nothing)
        ComboBox7.SelectedIndex = 0
        If ra.Trim <> "" Then
            ComboBox7.SelectedIndex = CInt(ra.Trim)
            Lite.ComboBox2.SelectedIndex = CInt(ra.Trim)
        Else
            ComboBox7.SelectedIndex = 0
            Lite.ComboBox2.SelectedIndex = 0
        End If
        My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx\Apk_Manager")
        rb = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Manager", "JRE", Nothing)
        TextBox1.Text = Main.java
        If rb.Trim <> "" Then
            TextBox1.Text = rb.Trim
            Main.java = rb.Trim
        End If
        rv = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Manager", "AVD", Nothing)
        TextBox2.Text = Main.avd
        If rv.Trim <> "" Then
            TextBox2.Text = rv.Trim
            Main.avd = rv.Trim
        End If
        If IsNothing(ori) = False Then
            r1 = ori
        End If
    End Function
    Function se(ByVal mode As Integer)
        On Error Resume Next
        My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx")
        If mode = 0 Then
            My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx\Apk_Explorer")
            Dim xc1 = "1"
            If CheckBox1.Checked = True Then
                xc1 = "1"
            Else
                xc1 = "0"
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Explorer", "Run", xc1)
            Dim xc2 = "0"
            If CheckBox2.Checked = True Then
                xc2 = "1"
            Else
                xc2 = "0"
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Explorer", "View", xc2)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Explorer", "VPages", CStr(ComboBox1.SelectedIndex).Trim)
            Dim xcx = "0"
            If CheckBox3.Checked = True Then
                xcx = "1"
            Else
                xcx = "0"
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Explorer", "OCA", xcx)
            Dim xcy = "0"
            If CheckBox5.Checked = True Then
                xcy = "1"
            Else
                xcy = "0"
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Explorer", "DHP", xcy)
            MsgBox("Apk Expleror had been saved!", MsgBoxStyle.Information)
        End If
        If mode = 1 Then
            My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx\Install")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Install", "Gzip", CStr(ComboBox4.SelectedIndex).Trim)
            
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Install", "Name", CStr(ComboBox5.SelectedIndex).Trim)
            
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Install", "Lib", CStr(ComboBox3.SelectedIndex))
           
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Install", "InsTo", CStr(ComboBox2.SelectedIndex).Trim)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Install", "WT", CStr(NumericUpDown1.Value).Trim)
            Dim xc3 = "1"
            If CheckBox4.Checked = True Then
                xc3 = "1"
            Else
                xc3 = "0"
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Install", "AF", xc3)
            MsgBox("Install had been saved!", MsgBoxStyle.Information)
        End If
        If mode = 2 Then
            My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx\Lite")
            Dim xc4 = "256"
            If CInt(ComboBox6.Text.Trim) Then
                xc4 = ComboBox6.Text.Trim
            End If
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Lite", "PC", xc4)
           
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Lite", "OQ", CStr(ComboBox7.SelectedIndex).Trim)
            MsgBox("Lite had been saved!", MsgBoxStyle.Information)
        End If
        If mode = 3 Then
            My.Computer.Registry.CurrentUser.CreateSubKey("software\ApkEx\Apk_Manager")
            If My.Computer.FileSystem.FileExists(TextBox1.Text) = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Manager", "JRE", TextBox1.Text)
            End If
            If My.Computer.FileSystem.FileExists(TextBox2.Text) = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\software\ApkEx\Apk_Manager", "AVD", TextBox2.Text)
            End If
            MsgBox("Apk_Manager had been saved!", MsgBoxStyle.Information)
        End If
        If mode + 1 <= TabControl1.TabPages.Count - 1 Then
            TabControl1.SelectedIndex = mode + 1
        Else
            MsgBox("Please Reboot!", MsgBoxStyle.Information)
        End If
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        se(0)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        se(1)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        se(2)
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        se(3)
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        With New OpenFileDialog
            .FileName = "Java.exe"
            .Filter = "Java.exe|Java.exe"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = .FileName
            End If
        End With
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
       Shell(My.Resources.x1 + My.Application.Info.DirectoryPath + "\" + My.Application.Info.AssemblyName + ".exe" + My.Resources.x1 + " " + Main.Label3.Text, 1, False)
        ChDir(My.Application.Info.DirectoryPath)
        My.Computer.FileSystem.DeleteDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + Main.xmmtt, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End
    End Sub
    Function xapk()
        On Error Resume Next
        My.Computer.Registry.ClassesRoot.CreateSubKey(".apk")
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\.apk", "", "apkfile")
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\apkfile\shell\open\command", "", My.Resources.x1 + My.Application.Info.DirectoryPath + "\" + My.Application.Info.AssemblyName + ".exe" + My.Resources.x1 + " -a  " + My.Resources.x1 + "%1" + My.Resources.x1)
        My.Computer.Registry.SetValue("HKEY_CLASSES_ROOT\apkfile\DefaultIcon", "", My.Resources.x1 + My.Application.Info.DirectoryPath + "\" + My.Application.Info.AssemblyName + ".exe" + My.Resources.x1 + ",0")
    End Function
    Function xape()
        On Error Resume Next
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Classes\Directory\shell\ApkEx")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Classes\Directory\shell\ApkEx\command")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Directory\shell\ApkEx\command", "", My.Resources.x1 + My.Application.Info.DirectoryPath + "\" + My.Application.Info.AssemblyName + ".exe" + My.Resources.x1 + " " + My.Resources.x1 + "%1" + My.Resources.x1)
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Classes\Drive\shell\ApkEx")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Classes\Drive\shell\ApkEx\command")
        My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Classes\Drive\shell\ApkEx\command", "", My.Resources.x1 + My.Application.Info.DirectoryPath + "\" + My.Application.Info.AssemblyName + ".exe" + My.Resources.x1 + " " + My.Resources.x1 + "%1" + My.Resources.x1)
    End Function
    Function dape()
        On Error Resume Next
        My.Computer.Registry.LocalMachine.DeleteSubKey("SOFTWARE\Classes\Directory\shell\ApkEx\command")
        My.Computer.Registry.LocalMachine.DeleteSubKey("SOFTWARE\Classes\Directory\shell\ApkEx")
        My.Computer.Registry.LocalMachine.DeleteSubKey("SOFTWARE\Classes\Drive\shell\ApkEx\command")
        My.Computer.Registry.LocalMachine.DeleteSubKey("SOFTWARE\Classes\Drive\shell\ApkEx")
    End Function
    Function dapk()
        On Error Resume Next
        My.Computer.Registry.ClassesRoot.DeleteSubKey(".apk")
        My.Computer.Registry.ClassesRoot.DeleteSubKey("apkfile")
    End Function
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        xape()
        xapk()
        MsgBox("Done!", MsgBoxStyle.Information)
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        dape()
        dapk()
        MsgBox("Done!", MsgBoxStyle.Information)
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        With New OpenFileDialog
            .FileName = "AVD Manager.exe"
            .Filter = "AVD Manager.exe|AVD Manager.exe"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox2.Text = .FileName
            End If
        End With
    End Sub
End Class