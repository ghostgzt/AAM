<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form
    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer
    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    	Me.components = New System.ComponentModel.Container()
    	Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
    	Me.Button1 = New System.Windows.Forms.Button()
    	Me.Button2 = New System.Windows.Forms.Button()
    	Me.Button3 = New System.Windows.Forms.Button()
    	Me.Button4 = New System.Windows.Forms.Button()
    	Me.TextBox1 = New System.Windows.Forms.TextBox()
    	Me.Label1 = New System.Windows.Forms.Label()
    	Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    	Me.Label2 = New System.Windows.Forms.Label()
    	Me.TextBox2 = New System.Windows.Forms.TextBox()
    	Me.TextBox3 = New System.Windows.Forms.TextBox()
    	Me.Button5 = New System.Windows.Forms.Button()
    	Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    	Me.InstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    	Me.ReNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ReNameAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    	Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.Button7 = New System.Windows.Forms.Button()
    	Me.Panel1 = New System.Windows.Forms.Panel()
    	Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    	Me.InstallToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    	Me.AppsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.DevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ExplorerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    	Me.LogCatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.FtpModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ADBModToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.Label5 = New System.Windows.Forms.Label()
    	Me.Label6 = New System.Windows.Forms.Label()
    	Me.Button13 = New System.Windows.Forms.Button()
    	Me.Button12 = New System.Windows.Forms.Button()
    	Me.Button11 = New System.Windows.Forms.Button()
    	Me.Button10 = New System.Windows.Forms.Button()
    	Me.Button9 = New System.Windows.Forms.Button()
    	Me.PictureBox2 = New System.Windows.Forms.PictureBox()
    	Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
    	Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    	Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    	Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
    	Me.Label4 = New System.Windows.Forms.Label()
    	Me.Button8 = New System.Windows.Forms.Button()
    	Me.ListBox1 = New System.Windows.Forms.ListBox()
    	Me.Button6 = New System.Windows.Forms.Button()
    	Me.Label3 = New System.Windows.Forms.TextBox()
    	Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    	Me.NotifyIcon2 = New System.Windows.Forms.NotifyIcon(Me.components)
    	Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    	Me.CancleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
    	CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
    	Me.ContextMenuStrip1.SuspendLayout
    	Me.Panel1.SuspendLayout
    	Me.ContextMenuStrip3.SuspendLayout
    	CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).BeginInit
    	Me.ContextMenuStrip2.SuspendLayout
    	Me.SuspendLayout
    	'
    	'Button1
    	'
    	Me.Button1.Location = New System.Drawing.Point(14, 62)
    	Me.Button1.Name = "Button1"
    	Me.Button1.Size = New System.Drawing.Size(75, 23)
    	Me.Button1.TabIndex = 0
    	Me.Button1.Text = "Refresh"
    	Me.Button1.UseVisualStyleBackColor = true
    	'
    	'Button2
    	'
    	Me.Button2.Location = New System.Drawing.Point(176, 62)
    	Me.Button2.Name = "Button2"
    	Me.Button2.Size = New System.Drawing.Size(75, 23)
    	Me.Button2.TabIndex = 1
    	Me.Button2.Text = "SignApk"
    	Me.Button2.UseVisualStyleBackColor = true
    	'
    	'Button3
    	'
    	Me.Button3.Location = New System.Drawing.Point(257, 62)
    	Me.Button3.Name = "Button3"
    	Me.Button3.Size = New System.Drawing.Size(75, 23)
    	Me.Button3.TabIndex = 2
    	Me.Button3.Text = "Install"
    	Me.Button3.UseVisualStyleBackColor = true
    	'
    	'Button4
    	'
    	Me.Button4.Location = New System.Drawing.Point(257, 35)
    	Me.Button4.Name = "Button4"
    	Me.Button4.Size = New System.Drawing.Size(75, 23)
    	Me.Button4.TabIndex = 3
    	Me.Button4.Text = "Change"
    	Me.Button4.UseVisualStyleBackColor = true
    	'
    	'TextBox1
    	'
    	Me.TextBox1.AllowDrop = true
    	Me.TextBox1.Location = New System.Drawing.Point(14, 35)
    	Me.TextBox1.Name = "TextBox1"
    	Me.TextBox1.ReadOnly = true
    	Me.TextBox1.Size = New System.Drawing.Size(237, 21)
    	Me.TextBox1.TabIndex = 4
    	'
    	'Label1
    	'
    	Me.Label1.AutoSize = true
    	Me.Label1.Location = New System.Drawing.Point(12, 14)
    	Me.Label1.Name = "Label1"
    	Me.Label1.Size = New System.Drawing.Size(35, 12)
    	Me.Label1.TabIndex = 5
    	Me.Label1.Text = "Path:"
    	'
    	'PictureBox1
    	'
    	Me.PictureBox1.Location = New System.Drawing.Point(14, 103)
    	Me.PictureBox1.Name = "PictureBox1"
    	Me.PictureBox1.Size = New System.Drawing.Size(96, 95)
    	Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    	Me.PictureBox1.TabIndex = 6
    	Me.PictureBox1.TabStop = false
    	'
    	'Label2
    	'
    	Me.Label2.AutoSize = true
    	Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    	Me.Label2.Location = New System.Drawing.Point(116, 106)
    	Me.Label2.Name = "Label2"
    	Me.Label2.Size = New System.Drawing.Size(2, 14)
    	Me.Label2.TabIndex = 7
    	'
    	'TextBox2
    	'
    	Me.TextBox2.BackColor = System.Drawing.Color.White
    	Me.TextBox2.Location = New System.Drawing.Point(0, 204)
    	Me.TextBox2.Multiline = true
    	Me.TextBox2.Name = "TextBox2"
    	Me.TextBox2.ReadOnly = true
    	Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    	Me.TextBox2.Size = New System.Drawing.Size(342, 276)
    	Me.TextBox2.TabIndex = 8
    	Me.TextBox2.Visible = false
    	'
    	'TextBox3
    	'
    	Me.TextBox3.BackColor = System.Drawing.Color.White
    	Me.TextBox3.Location = New System.Drawing.Point(116, 135)
    	Me.TextBox3.Multiline = true
    	Me.TextBox3.Name = "TextBox3"
    	Me.TextBox3.ReadOnly = true
    	Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    	Me.TextBox3.Size = New System.Drawing.Size(221, 63)
    	Me.TextBox3.TabIndex = 9
    	'
    	'Button5
    	'
    	Me.Button5.Dock = System.Windows.Forms.DockStyle.Right
    	Me.Button5.Location = New System.Drawing.Point(342, 0)
    	Me.Button5.Name = "Button5"
    	Me.Button5.Size = New System.Drawing.Size(5, 498)
    	Me.Button5.TabIndex = 10
    	Me.Button5.UseVisualStyleBackColor = true
    	'
    	'ContextMenuStrip1
    	'
    	Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstallToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator2, Me.ReNameToolStripMenuItem, Me.ReNameAllToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator3, Me.DeleteToolStripMenuItem})
    	Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    	Me.ContextMenuStrip1.Size = New System.Drawing.Size(145, 148)
    	'
    	'InstallToolStripMenuItem
    	'
    	Me.InstallToolStripMenuItem.Name = "InstallToolStripMenuItem"
    	Me.InstallToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
    	Me.InstallToolStripMenuItem.Text = "Install"
    	'
    	'SelectAllToolStripMenuItem
    	'
    	Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
    	Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
    	Me.SelectAllToolStripMenuItem.Text = "Install All"
    	'
    	'ToolStripSeparator2
    	'
    	Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    	Me.ToolStripSeparator2.Size = New System.Drawing.Size(141, 6)
    	'
    	'ReNameToolStripMenuItem
    	'
    	Me.ReNameToolStripMenuItem.Name = "ReNameToolStripMenuItem"
    	Me.ReNameToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
    	Me.ReNameToolStripMenuItem.Text = "ReName"
    	'
    	'ReNameAllToolStripMenuItem
    	'
    	Me.ReNameAllToolStripMenuItem.Name = "ReNameAllToolStripMenuItem"
    	Me.ReNameAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
    	Me.ReNameAllToolStripMenuItem.Text = "ReName All"
    	'
    	'RefreshToolStripMenuItem
    	'
    	Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
    	Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
    	Me.RefreshToolStripMenuItem.Text = "Refresh"
    	'
    	'ToolStripSeparator3
    	'
    	Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    	Me.ToolStripSeparator3.Size = New System.Drawing.Size(141, 6)
    	'
    	'DeleteToolStripMenuItem
    	'
    	Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
    	Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
    	Me.DeleteToolStripMenuItem.Text = "Delete"
    	'
    	'Button7
    	'
    	Me.Button7.Location = New System.Drawing.Point(95, 62)
    	Me.Button7.Name = "Button7"
    	Me.Button7.Size = New System.Drawing.Size(75, 23)
    	Me.Button7.TabIndex = 14
    	Me.Button7.Text = "ReName"
    	Me.Button7.UseVisualStyleBackColor = true
    	'
    	'Panel1
    	'
    	Me.Panel1.ContextMenuStrip = Me.ContextMenuStrip3
    	Me.Panel1.Controls.Add(Me.Label5)
    	Me.Panel1.Controls.Add(Me.Label6)
    	Me.Panel1.Controls.Add(Me.Button13)
    	Me.Panel1.Controls.Add(Me.Button12)
    	Me.Panel1.Controls.Add(Me.Button11)
    	Me.Panel1.Controls.Add(Me.Button10)
    	Me.Panel1.Controls.Add(Me.Button9)
    	Me.Panel1.Controls.Add(Me.Label1)
    	Me.Panel1.Controls.Add(Me.Button7)
    	Me.Panel1.Controls.Add(Me.Button1)
    	Me.Panel1.Controls.Add(Me.Button2)
    	Me.Panel1.Controls.Add(Me.Button3)
    	Me.Panel1.Controls.Add(Me.Button4)
    	Me.Panel1.Controls.Add(Me.TextBox3)
    	Me.Panel1.Controls.Add(Me.TextBox1)
    	Me.Panel1.Controls.Add(Me.TextBox2)
    	Me.Panel1.Controls.Add(Me.PictureBox1)
    	Me.Panel1.Controls.Add(Me.Label2)
    	Me.Panel1.Controls.Add(Me.PictureBox2)
    	Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
    	Me.Panel1.Location = New System.Drawing.Point(0, 0)
    	Me.Panel1.Name = "Panel1"
    	Me.Panel1.Size = New System.Drawing.Size(345, 498)
    	Me.Panel1.TabIndex = 17
    	'
    	'ContextMenuStrip3
    	'
    	Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstallToolStripMenuItem1, Me.AppsToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.DevicesToolStripMenuItem, Me.ExplorerToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripSeparator1, Me.LogCatToolStripMenuItem, Me.FtpModeToolStripMenuItem, Me.ADBModToolStripMenuItem})
    	Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
    	Me.ContextMenuStrip3.Size = New System.Drawing.Size(135, 208)
    	'
    	'InstallToolStripMenuItem1
    	'
    	Me.InstallToolStripMenuItem1.Name = "InstallToolStripMenuItem1"
    	Me.InstallToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
    	Me.InstallToolStripMenuItem1.Text = "Install"
    	'
    	'AppsToolStripMenuItem
    	'
    	Me.AppsToolStripMenuItem.Name = "AppsToolStripMenuItem"
    	Me.AppsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
    	Me.AppsToolStripMenuItem.Text = "Apps"
    	'
    	'ToolsToolStripMenuItem
    	'
    	Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
    	Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
    	Me.ToolsToolStripMenuItem.Text = "Tools"
    	'
    	'DevicesToolStripMenuItem
    	'
    	Me.DevicesToolStripMenuItem.Name = "DevicesToolStripMenuItem"
    	Me.DevicesToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
    	Me.DevicesToolStripMenuItem.Text = "Devices"
    	'
    	'ExplorerToolStripMenuItem
    	'
    	Me.ExplorerToolStripMenuItem.Name = "ExplorerToolStripMenuItem"
    	Me.ExplorerToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
    	Me.ExplorerToolStripMenuItem.Text = "Explorer"
    	'
    	'AboutToolStripMenuItem
    	'
    	Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
    	Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
    	Me.AboutToolStripMenuItem.Text = "About"
    	'
    	'ToolStripSeparator1
    	'
    	Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    	Me.ToolStripSeparator1.Size = New System.Drawing.Size(131, 6)
    	'
    	'LogCatToolStripMenuItem
    	'
    	Me.LogCatToolStripMenuItem.Name = "LogCatToolStripMenuItem"
    	Me.LogCatToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
    	Me.LogCatToolStripMenuItem.Text = "LogCat"
    	'
    	'FtpModeToolStripMenuItem
    	'
    	Me.FtpModeToolStripMenuItem.Name = "FtpModeToolStripMenuItem"
    	Me.FtpModeToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
    	Me.FtpModeToolStripMenuItem.Text = "Ftp_Mode"
    	'
    	'ADBModToolStripMenuItem
    	'
    	Me.ADBModToolStripMenuItem.Name = "ADBModToolStripMenuItem"
    	Me.ADBModToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
    	Me.ADBModToolStripMenuItem.Text = "ADB_Mod"
    	'
    	'Label5
    	'
    	Me.Label5.BackColor = System.Drawing.Color.Black
    	Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
    	Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
    	Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134,Byte))
    	Me.Label5.ForeColor = System.Drawing.Color.White
    	Me.Label5.Location = New System.Drawing.Point(0, 482)
    	Me.Label5.Name = "Label5"
    	Me.Label5.Size = New System.Drawing.Size(345, 16)
    	Me.Label5.TabIndex = 25
    	Me.Label5.Text = "若觉此软件方便有用,请往我的支付宝（ghostgzt@163.com）捐助1块钱"
    	'
    	'Label6
    	'
    	Me.Label6.AutoSize = true
    	Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    	Me.Label6.Location = New System.Drawing.Point(116, 120)
    	Me.Label6.Name = "Label6"
    	Me.Label6.Size = New System.Drawing.Size(2, 14)
    	Me.Label6.TabIndex = 24
    	'
    	'Button13
    	'
    	Me.Button13.Location = New System.Drawing.Point(95, 6)
    	Me.Button13.Name = "Button13"
    	Me.Button13.Size = New System.Drawing.Size(75, 23)
    	Me.Button13.TabIndex = 20
    	Me.Button13.Text = "Apps"
    	Me.Button13.UseVisualStyleBackColor = true
    	'
    	'Button12
    	'
    	Me.Button12.Location = New System.Drawing.Point(176, 6)
    	Me.Button12.Name = "Button12"
    	Me.Button12.Size = New System.Drawing.Size(75, 23)
    	Me.Button12.TabIndex = 22
    	Me.Button12.Text = "About"
    	Me.Button12.UseVisualStyleBackColor = true
    	'
    	'Button11
    	'
    	Me.Button11.Location = New System.Drawing.Point(0, 199)
    	Me.Button11.Name = "Button11"
    	Me.Button11.Size = New System.Drawing.Size(343, 5)
    	Me.Button11.TabIndex = 20
    	Me.Button11.Text = "Button11"
    	Me.Button11.UseVisualStyleBackColor = true
    	'
    	'Button10
    	'
    	Me.Button10.Location = New System.Drawing.Point(257, 6)
    	Me.Button10.Name = "Button10"
    	Me.Button10.Size = New System.Drawing.Size(75, 23)
    	Me.Button10.TabIndex = 19
    	Me.Button10.Text = "Device"
    	Me.Button10.UseVisualStyleBackColor = true
    	'
    	'Button9
    	'
    	Me.Button9.BackColor = System.Drawing.Color.Transparent
    	Me.Button9.Location = New System.Drawing.Point(14, 103)
    	Me.Button9.Name = "Button9"
    	Me.Button9.Size = New System.Drawing.Size(96, 95)
    	Me.Button9.TabIndex = 19
    	Me.Button9.UseVisualStyleBackColor = false
    	'
    	'PictureBox2
    	'
    	Me.PictureBox2.BackColor = System.Drawing.Color.Black
    	Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    	Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
    	Me.PictureBox2.Location = New System.Drawing.Point(0, 204)
    	Me.PictureBox2.Name = "PictureBox2"
    	Me.PictureBox2.Size = New System.Drawing.Size(343, 276)
    	Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    	Me.PictureBox2.TabIndex = 21
    	Me.PictureBox2.TabStop = false
    	Me.ToolTip1.SetToolTip(Me.PictureBox2, "Q Me !")
    	Me.PictureBox2.WaitOnLoad = true
    	'
    	'NotifyIcon1
    	'
    	Me.NotifyIcon1.Text = "NotifyIcon1"
    	Me.NotifyIcon1.Visible = true
    	'
    	'ImageList1
    	'
    	Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
    	Me.ImageList1.ImageSize = New System.Drawing.Size(64, 64)
    	Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    	'
    	'Timer1
    	'
    	Me.Timer1.Interval = 3000
    	'
    	'BackgroundWorker1
    	'
    	Me.BackgroundWorker1.WorkerReportsProgress = true
    	Me.BackgroundWorker1.WorkerSupportsCancellation = true
    	'
    	'Label4
    	'
    	Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    	Me.Label4.Location = New System.Drawing.Point(353, 474)
    	Me.Label4.Name = "Label4"
    	Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    	Me.Label4.Size = New System.Drawing.Size(253, 15)
    	Me.Label4.TabIndex = 16
    	'
    	'Button8
    	'
    	Me.Button8.Image = CType(resources.GetObject("Button8.Image"),System.Drawing.Image)
    	Me.Button8.Location = New System.Drawing.Point(353, 474)
    	Me.Button8.Name = "Button8"
    	Me.Button8.Size = New System.Drawing.Size(15, 15)
    	Me.Button8.TabIndex = 18
    	Me.Button8.UseVisualStyleBackColor = true
    	'
    	'ListBox1
    	'
    	Me.ListBox1.ContextMenuStrip = Me.ContextMenuStrip1
    	Me.ListBox1.FormattingEnabled = true
    	Me.ListBox1.HorizontalScrollbar = true
    	Me.ListBox1.ItemHeight = 12
    	Me.ListBox1.Location = New System.Drawing.Point(353, 38)
    	Me.ListBox1.Name = "ListBox1"
    	Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
    	Me.ListBox1.Size = New System.Drawing.Size(253, 436)
    	Me.ListBox1.TabIndex = 11
    	'
    	'Button6
    	'
    	Me.Button6.Location = New System.Drawing.Point(548, 9)
    	Me.Button6.Name = "Button6"
    	Me.Button6.Size = New System.Drawing.Size(57, 23)
    	Me.Button6.TabIndex = 12
    	Me.Button6.Text = "Path"
    	Me.Button6.UseVisualStyleBackColor = true
    	'
    	'Label3
    	'
    	Me.Label3.AllowDrop = true
    	Me.Label3.Location = New System.Drawing.Point(353, 10)
    	Me.Label3.Name = "Label3"
    	Me.Label3.ReadOnly = true
    	Me.Label3.Size = New System.Drawing.Size(189, 21)
    	Me.Label3.TabIndex = 19
    	'
    	'NotifyIcon2
    	'
    	Me.NotifyIcon2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
    	Me.NotifyIcon2.ContextMenuStrip = Me.ContextMenuStrip2
    	Me.NotifyIcon2.Text = "Processing..."
    	Me.NotifyIcon2.Visible = true
    	'
    	'ContextMenuStrip2
    	'
    	Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CancleToolStripMenuItem})
    	Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
    	Me.ContextMenuStrip2.Size = New System.Drawing.Size(115, 26)
    	'
    	'CancleToolStripMenuItem
    	'
    	Me.CancleToolStripMenuItem.Name = "CancleToolStripMenuItem"
    	Me.CancleToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
    	Me.CancleToolStripMenuItem.Text = "Cancle"
    	'
    	'Main
    	'
    	Me.AcceptButton = Me.Button12
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(347, 498)
    	Me.Controls.Add(Me.Label3)
    	Me.Controls.Add(Me.ListBox1)
    	Me.Controls.Add(Me.Button8)
    	Me.Controls.Add(Me.Label4)
    	Me.Controls.Add(Me.Button6)
    	Me.Controls.Add(Me.Button5)
    	Me.Controls.Add(Me.Panel1)
    	Me.DoubleBuffered = true
    	Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    	Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    	Me.MaximizeBox = false
    	Me.Name = "Main"
    	Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    	Me.Text = "Apk Manager"
    	CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
    	Me.ContextMenuStrip1.ResumeLayout(false)
    	Me.Panel1.ResumeLayout(false)
    	Me.Panel1.PerformLayout
    	Me.ContextMenuStrip3.ResumeLayout(false)
    	CType(Me.PictureBox2,System.ComponentModel.ISupportInitialize).EndInit
    	Me.ContextMenuStrip2.ResumeLayout(false)
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ReNameAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents InstallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ReNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NotifyIcon2 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CancleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AppsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogCatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FtpModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstallToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExplorerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ADBModToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class