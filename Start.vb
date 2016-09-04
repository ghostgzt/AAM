Public NotInheritable Class Start
    Private Sub Start_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
        Timer2.Enabled = False
        Dim kx = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\SSTmp"
        My.Computer.FileSystem.DeleteDirectory(kx, FileIO.DeleteDirectoryOption.DeleteAllContents)
    End Sub
    'TODO: 可轻松将此窗体设置为应用程序的初始屏幕，方法是转到
    '  “项目设计器”的“应用程序”选项卡(“项目”菜单下的“属性”)。
    Dim xmmtt As String
    Dim xcmd As String
    Dim xmt As String
    Private Sub Start_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next
        '根据应用程序的程序集信息在运行时设置对话框文本。  
        xmmtt = Main.xmmtt
        xcmd = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.cmd"
        xmt = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\$1.tmp"
        ''TODO: 在项目属性对话框(“项目”菜单下)中的“应用程序”面板
        ''  中自定义应用程序的程序集信息。 
        BackgroundWorker1.RunWorkerAsync()
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath + "\Tools\Start.idz")
        rss()
        Timer1.Enabled = True
        ''应用程序标题
        'If My.Application.Info.Title <> "" Then
        '    ApplicationTitle.Text = My.Application.Info.Title
        'Else
        '    '若应用程序标题丢失，则使用不带扩展名的应用程序名
        '    ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If
        ''使用在设计时作为格式字符串设置到 Version 控件中的文本格式化版本信息。
        ''  以便根据需要进行有效的本地化。
        ''  使用以下代码，将 Version 控件的设计时文本 
        ''  更改为“Version {0}.{1:00}.{2}.{3}”或类似格式，将内部版本和修订信息包括在内。
        ''  有关更多信息，请参阅帮助中的 String.Format()。
        ''
        ''版权信息
        'Copyright.Text = My.Application.Info.Copyright
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer2.Enabled = False
        Me.Close()
    End Sub
    Dim lx As New ListBox
    Dim xx As Integer
    Dim zz As Integer
    Function rss()
        On Error Resume Next
        lx.Items.Clear()
        Dim kx = My.Computer.FileSystem.SpecialDirectories.Temp + "\APKTest\" + xmmtt + "\SSTmp"
        My.Computer.FileSystem.DeleteDirectory(kx, FileIO.DeleteDirectoryOption.DeleteAllContents)
        MkDir(kx)
        Dim tcmd = xcmd
        Kill(tcmd)
        Shell(My.Resources.x1 + Main.za + My.Resources.x1 + " x -o" + My.Resources.x1 + kx + My.Resources.x1 + " -y " + My.Resources.x1 + My.Application.Info.DirectoryPath + "\Tools\bootanimation.zip" + My.Resources.x1, 0, True)
        Kill(tcmd)
        Dim r = My.Computer.FileSystem.GetFiles(kx, FileIO.SearchOption.SearchAllSubDirectories, "*.png")
        Dim k = My.Computer.FileSystem.GetFiles(kx, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
        For x = 0 To r.Count - 1
            lx.Items.Add(r(x))
        Next
        For y = 0 To k.Count - 1
            lx.Items.Add(k(y))
        Next
        xx = 0
        zz = lx.Items.Count - 1
        Timer2.Enabled = True
    End Function
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error Resume Next
        If xx + 1 < zz Then
            Me.BackgroundImage = Image.FromFile(lx.Items(xx + 1))
            Me.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone)
            PictureBox1.Image = Image.FromFile(lx.Items(xx + 1))
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            xx = xx + 1
        Else
            xx = 0
        End If
    End Sub
    Function ui(ByVal worker As System.ComponentModel.BackgroundWorker, ByVal e As System.ComponentModel.DoWorkEventArgs) As Long
        On Error Resume Next
        'MsgBox(mlhs)
        Main.state()
    End Function
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ui(e.Argument, e.Result)
    End Sub
End Class