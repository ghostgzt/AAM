﻿Public NotInheritable Class AboutBox
    Private Sub AboutBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        'AboutMe.Show()
        Me.Close()
    End Sub
    Private Sub AboutBox_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
    End Sub
    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim rx = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", Nothing)
        If rx.ToString.ToLower.Replace("windows 7", "").Trim <> rx.ToString.ToLower.Trim Then
            Shell(My.Application.Info.DirectoryPath + "\Tools\OOBEPlayer.exe", AppWinStyle.MaximizedFocus, True)
        Else
            Shell(My.Resources.x1 + My.Application.Info.DirectoryPath + "\Tools\MPLAYER.EXE" + My.Resources.x1 + " -fs -framedrop " + My.Resources.x1 + My.Application.Info.DirectoryPath + "\Tools\FullScreen.wmv" + My.Resources.x1, AppWinStyle.MaximizedFocus, True)
        End If
        'AxWindowsMediaPlayer1.URL = My.Application.Info.DirectoryPath + "\About.avi"
        ' 设置此窗体的标题。
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("关于 {0}", ApplicationTitle)
        ' 初始化“关于”对话框显示的所有文字。
        ' TODO: 在项目的“应用程序”窗格中自定义此应用程序的程序集信息 
        '    属性对话框(在“项目”菜单下)。
        'Me.LabelProductName.Text = My.Application.Info.ProductName
        'Me.LabelVersion.Text = String.Format("版本 {0}", My.Application.Info.Version.ToString)
        'Me.LabelCopyright.Text = My.Application.Info.Copyright
        'Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        'Me.TextBoxDescription.Text = My.Application.Info.Description
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.Opacity > 0 Then
            Me.Opacity = Me.Opacity - 0.01
        Else
            'AboutMe.Show()

            Me.Close()
        End If
    End Sub
End Class