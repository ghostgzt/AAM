Public Class Loading
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        On Error Resume Next
        Label5.Text = Main.getlast(Filez.ffx.Trim.Split("\"))
        If Filez.rrx = 0 Then
            ProgressBar1.Value = 0
            Label2.Text = "0%"
        Else
            If Filez.rrx = 50 Then
                ProgressBar1.Value = 50
                Label2.Text = "50%"
            Else
                If Filez.rrx = 100 Then
                    ProgressBar1.Value = 100
                    Label2.Text = "100%"
                Else
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    Label2.Text = CStr(ProgressBar1.Value) + "%"
                End If
            End If
        End If
        ProgressBar2.Value = (Filez.ppx / Filez.ddx) * 100
        Label4.Text = CStr(ProgressBar2.Value) + "%"
    End Sub
    Private Sub Loading_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Timer1.Enabled = True Then
            If MsgBox("Do you want to Stop it ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Filez.spp = 1
                Timer1.Enabled = False
            Else
                e.Cancel = True
            End If
        End If
        Label5.Text = ""
    End Sub
    Private Sub Loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class