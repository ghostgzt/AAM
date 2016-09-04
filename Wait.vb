Public Class Wait
    Dim sse As Integer
    Function runn(ByVal sec As Integer)
        On Error Resume Next
        If sec <> -1 Then
            Me.Text = "Syncing..."
            Timer1.Interval = sec
            Timer1.Enabled = True
            Timer2.Interval = 800
            Timer2.Enabled = True
            sse = sec / 1000
        Else
            Timer1.Enabled = False
            Timer2.Interval = 1000
            Timer2.Enabled = True
            sse = -1
        End If
        Me.ShowDialog()
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = 100
        Label1.Text = "100%"
        Timer1.Enabled = False
        Me.Close()
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        On Error GoTo k
        If sse <> -1 Then
            If ProgressBar1.Value < 100 Then
                ProgressBar1.Value = ProgressBar1.Value + (100 / sse)
                Label1.Text = CStr(ProgressBar1.Value) + "%"
            Else
k:              ProgressBar1.Value = 100
                Label1.Text = "100%"
                Timer2.Enabled = False
            End If
        Else
            If Main.doii = 0 Then
                Timer2.Enabled = False
                ProgressBar1.Value = 100
                Label1.Text = "100%"
                Me.Close()
            Else
                If ProgressBar1.Value < 80 Then
                    Timer2.Interval = 1000
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    Label1.Text = CStr(ProgressBar1.Value) + "%"
                Else
                    If ProgressBar1.Value < 98 Then
                        Timer2.Interval = 5000
                        ProgressBar1.Value = ProgressBar1.Value + 1
                        Label1.Text = CStr(ProgressBar1.Value) + "%"
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Wait_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        On Error Resume Next
        'MsgBox(sse)
        If sse <> -1 Then
            If Timer1.Enabled = True Then
                If e.CloseReason = CloseReason.UserClosing Then
                    If MsgBox("Are you sure Cancle ? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        If ProgressBar1.Value = 100 Then
                            e.Cancel = False
                        Else
                            e.Cancel = True
                        End If
                    Else
                        e.Cancel = False
                        Timer1.Enabled = False
                    End If
                Else
                    e.Cancel = False
                    Timer1.Enabled = False
                End If
            End If
        Else
            If Main.doii = 1 Then
                If e.CloseReason = CloseReason.UserClosing Then
                    If MsgBox("Are you sure Cancle ? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        e.Cancel = True
                    Else
                        If Main.mfo <> "Loading..." And Main.mfo <> "Saving..." Then
                            If Main.mfo = "Erasing Recovery..." Or Main.mfo = "Flashing Recovery..." Or Main.mfo = "Updating..." Or Main.mfo = "Erasing userdata And cache..." Or Main.mfo = "Rebooting..." Or Main.mfo = "Reboot In Bootloader Mode" Then
                                MsgBox("This is A Dangerous Action And Can't Be Cancle!!!", MsgBoxStyle.Information)
                                GoTo s
                            Else
                                If Main.mfo = "Downloading..." Then
                                    Dim myProcesses() As Process
                                    Dim myProcess As Process
                                    myProcesses = Process.GetProcessesByName("fastboot.exe")
                                    For Each myProcess In myProcesses
                                        myProcess.Kill()
                                    Next
                                Else
                                    Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " kill-server", 0, True)
                                    Shell(My.Resources.x1 + Main.adb + My.Resources.x1 + " start-server", 0, True)
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
                        Main.doii = 0
                        Main.BackgroundWorker2.CancelAsync()
                        e.Cancel = False
                    End If
                Else
                    e.Cancel = False
                End If
            Else
                e.Cancel = False
            End If
        End If
        Exit Sub
s:      e.Cancel = True
    End Sub
    Private Sub Wait_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ProgressBar1.Value = 0
        Label1.Text = "0%"
    End Sub
End Class