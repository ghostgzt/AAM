<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewz
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
    	Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viewz))
    	Me.TreeView1 = New System.Windows.Forms.TreeView()
    	Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
    	Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.AddToInstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    	Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    	Me.CopyToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.MoveToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    	Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.AttributeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
    	Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    	Me.ListView1 = New System.Windows.Forms.ListView()
    	Me.C1 = New System.Windows.Forms.ColumnHeader()
    	Me.C2 = New System.Windows.Forms.ColumnHeader()
    	Me.C3 = New System.Windows.Forms.ColumnHeader()
    	Me.C4 = New System.Windows.Forms.ColumnHeader()
    	Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    	Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
    	Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    	Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
    	Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
    	Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
    	Me.LargeIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
    	Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
    	Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
    	Me.ViewInPagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    	Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox()
    	Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
    	Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
    	Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    	Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton17 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
    	Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
    	Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
    	Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
    	Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
    	Me.ToolStripComboBox3 = New System.Windows.Forms.ToolStripComboBox()
    	Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
    	Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
    	Me.ToolStripButton20 = New System.Windows.Forms.ToolStripButton()
    	Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
    	Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
    	Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    	Me.Button1 = New System.Windows.Forms.Button()
    	Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
    	Me.ContextMenuStrip1.SuspendLayout
    	Me.SplitContainer1.Panel1.SuspendLayout
    	Me.SplitContainer1.Panel2.SuspendLayout
    	Me.SplitContainer1.SuspendLayout
    	Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout
    	Me.ToolStripContainer1.ContentPanel.SuspendLayout
    	Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout
    	Me.ToolStripContainer1.SuspendLayout
    	Me.StatusStrip1.SuspendLayout
    	Me.ToolStrip1.SuspendLayout
    	Me.SuspendLayout
    	'
    	'TreeView1
    	'
    	Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip1
    	Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.TreeView1.FullRowSelect = true
    	Me.TreeView1.HideSelection = false
    	Me.TreeView1.ImageIndex = 0
    	Me.TreeView1.ImageList = Me.ImageList2
    	Me.TreeView1.Location = New System.Drawing.Point(0, 0)
    	Me.TreeView1.Name = "TreeView1"
    	Me.TreeView1.SelectedImageIndex = 1
    	Me.TreeView1.ShowLines = false
    	Me.TreeView1.Size = New System.Drawing.Size(207, 100)
    	Me.TreeView1.StateImageList = Me.ImageList1
    	Me.TreeView1.TabIndex = 0
    	'
    	'ContextMenuStrip1
    	'
    	Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.AddToInstallToolStripMenuItem, Me.ToolStripSeparator1, Me.OpenToolStripMenuItem, Me.ToolStripSeparator2, Me.CopyToToolStripMenuItem, Me.MoveToToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator3, Me.RefreshToolStripMenuItem, Me.AttributeToolStripMenuItem})
    	Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
    	Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 198)
    	'
    	'LoadToolStripMenuItem
    	'
    	Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
    	Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.LoadToolStripMenuItem.Text = "Load"
    	'
    	'AddToInstallToolStripMenuItem
    	'
    	Me.AddToInstallToolStripMenuItem.Name = "AddToInstallToolStripMenuItem"
    	Me.AddToInstallToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.AddToInstallToolStripMenuItem.Text = "Install"
    	'
    	'ToolStripSeparator1
    	'
    	Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    	Me.ToolStripSeparator1.Size = New System.Drawing.Size(123, 6)
    	'
    	'OpenToolStripMenuItem
    	'
    	Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
    	Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.OpenToolStripMenuItem.Text = "Open"
    	'
    	'ToolStripSeparator2
    	'
    	Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    	Me.ToolStripSeparator2.Size = New System.Drawing.Size(123, 6)
    	'
    	'CopyToToolStripMenuItem
    	'
    	Me.CopyToToolStripMenuItem.Name = "CopyToToolStripMenuItem"
    	Me.CopyToToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.CopyToToolStripMenuItem.Text = "CopyTo"
    	'
    	'MoveToToolStripMenuItem
    	'
    	Me.MoveToToolStripMenuItem.Name = "MoveToToolStripMenuItem"
    	Me.MoveToToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.MoveToToolStripMenuItem.Text = "MoveTo"
    	'
    	'DeleteToolStripMenuItem
    	'
    	Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
    	Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.DeleteToolStripMenuItem.Text = "Delete"
    	'
    	'ToolStripSeparator3
    	'
    	Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    	Me.ToolStripSeparator3.Size = New System.Drawing.Size(123, 6)
    	'
    	'RefreshToolStripMenuItem
    	'
    	Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
    	Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.RefreshToolStripMenuItem.Text = "Refresh"
    	'
    	'AttributeToolStripMenuItem
    	'
    	Me.AttributeToolStripMenuItem.Name = "AttributeToolStripMenuItem"
    	Me.AttributeToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
    	Me.AttributeToolStripMenuItem.Text = "Attribute"
    	'
    	'ImageList2
    	'
    	Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"),System.Windows.Forms.ImageListStreamer)
    	Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
    	Me.ImageList2.Images.SetKeyName(0, "system.backup.root.computer.ico")
    	Me.ImageList2.Images.SetKeyName(1, "shortcur_icon.ico")
    	'
    	'ImageList1
    	'
    	Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
    	Me.ImageList1.ImageSize = New System.Drawing.Size(48, 48)
    	Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    	'
    	'ListView1
    	'
    	Me.ListView1.AllowDrop = true
    	Me.ListView1.BackgroundImageTiled = true
    	Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.C1, Me.C2, Me.C3, Me.C4})
    	Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
    	Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.ListView1.FullRowSelect = true
    	Me.ListView1.HideSelection = false
    	Me.ListView1.LargeImageList = Me.ImageList1
    	Me.ListView1.Location = New System.Drawing.Point(0, 0)
    	Me.ListView1.Name = "ListView1"
    	Me.ListView1.Size = New System.Drawing.Size(804, 603)
    	Me.ListView1.SmallImageList = Me.ImageList1
    	Me.ListView1.TabIndex = 1
    	Me.ListView1.UseCompatibleStateImageBehavior = false
    	Me.ListView1.View = System.Windows.Forms.View.Details
    	'
    	'C1
    	'
    	Me.C1.Text = "File"
    	'
    	'C2
    	'
    	Me.C2.Text = "Version"
    	'
    	'C3
    	'
    	Me.C3.Text = "Size"
    	'
    	'C4
    	'
    	Me.C4.Text = "Path"
    	'
    	'SplitContainer1
    	'
    	Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
    	Me.SplitContainer1.Name = "SplitContainer1"
    	'
    	'SplitContainer1.Panel1
    	'
    	Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
    	Me.SplitContainer1.Panel1Collapsed = true
    	'
    	'SplitContainer1.Panel2
    	'
    	Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStripContainer1)
    	Me.SplitContainer1.Size = New System.Drawing.Size(804, 650)
    	Me.SplitContainer1.SplitterDistance = 207
    	Me.SplitContainer1.TabIndex = 2
    	'
    	'ToolStripContainer1
    	'
    	'
    	'ToolStripContainer1.BottomToolStripPanel
    	'
    	Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip1)
    	'
    	'ToolStripContainer1.ContentPanel
    	'
    	Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ListView1)
    	Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(804, 603)
    	Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    	Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
    	Me.ToolStripContainer1.Name = "ToolStripContainer1"
    	Me.ToolStripContainer1.Size = New System.Drawing.Size(804, 650)
    	Me.ToolStripContainer1.TabIndex = 3
    	Me.ToolStripContainer1.Text = "ToolStripContainer1"
    	'
    	'ToolStripContainer1.TopToolStripPanel
    	'
    	Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
    	'
    	'StatusStrip1
    	'
    	Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
    	Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1, Me.ToolStripDropDownButton1, Me.ToolStripStatusLabel2, Me.ToolStripDropDownButton2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
    	Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
    	Me.StatusStrip1.Name = "StatusStrip1"
    	Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    	Me.StatusStrip1.Size = New System.Drawing.Size(804, 22)
    	Me.StatusStrip1.TabIndex = 2
    	Me.StatusStrip1.Text = "StatusStrip1"
    	'
    	'ToolStripProgressBar1
    	'
    	Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
    	Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
    	'
    	'ToolStripStatusLabel1
    	'
    	Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
    	Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(53, 17)
    	Me.ToolStripStatusLabel1.Text = "Process"
    	'
    	'ToolStripDropDownButton1
    	'
    	Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LargeIconToolStripMenuItem, Me.DetailsToolStripMenuItem})
    	Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"),System.Drawing.Image)
    	Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
    	Me.ToolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
    	Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 20)
    	Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
    	Me.ToolStripDropDownButton1.ToolTipText = "View"
    	'
    	'LargeIconToolStripMenuItem
    	'
    	Me.LargeIconToolStripMenuItem.Name = "LargeIconToolStripMenuItem"
    	Me.LargeIconToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
    	Me.LargeIconToolStripMenuItem.Text = "LargeIcon"
    	'
    	'DetailsToolStripMenuItem
    	'
    	Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
    	Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
    	Me.DetailsToolStripMenuItem.Text = "Details"
    	'
    	'ToolStripStatusLabel2
    	'
    	Me.ToolStripStatusLabel2.IsLink = true
    	Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
    	Me.ToolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
    	Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(44, 17)
    	Me.ToolStripStatusLabel2.Text = "Next>"
    	'
    	'ToolStripDropDownButton2
    	'
    	Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1, Me.ViewInPagesToolStripMenuItem})
    	Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"),System.Drawing.Image)
    	Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
    	Me.ToolStripDropDownButton2.RightToLeft = System.Windows.Forms.RightToLeft.No
    	Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(29, 20)
    	Me.ToolStripDropDownButton2.Text = "Pages"
    	'
    	'ToolStripComboBox1
    	'
    	Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    	Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
    	Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 25)
    	'
    	'ViewInPagesToolStripMenuItem
    	'
    	Me.ViewInPagesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox2})
    	Me.ViewInPagesToolStripMenuItem.Name = "ViewInPagesToolStripMenuItem"
    	Me.ViewInPagesToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
    	Me.ViewInPagesToolStripMenuItem.Text = "ViewInPages"
    	'
    	'ToolStripComboBox2
    	'
    	Me.ToolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    	Me.ToolStripComboBox2.Items.AddRange(New Object() {"0", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100"})
    	Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
    	Me.ToolStripComboBox2.Size = New System.Drawing.Size(121, 25)
    	'
    	'ToolStripStatusLabel3
    	'
    	Me.ToolStripStatusLabel3.IsLink = true
    	Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
    	Me.ToolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
    	Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(44, 17)
    	Me.ToolStripStatusLabel3.Text = "<Last "
    	'
    	'ToolStripStatusLabel4
    	'
    	Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
    	Me.ToolStripStatusLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
    	Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 17)
    	'
    	'ToolStrip1
    	'
    	Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
    	Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    	Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton17, Me.ToolStripSeparator4, Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripButton9, Me.ToolStripButton16, Me.ToolStripSeparator5, Me.ToolStripButton10, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton15, Me.ToolStripSeparator6, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripButton13, Me.ToolStripSeparator7, Me.ToolStripButton14, Me.ToolStripButton19, Me.ToolStripSeparator8, Me.ToolStripComboBox3, Me.ToolStripSeparator9, Me.ToolStripButton18, Me.ToolStripSeparator10, Me.ToolStripButton20, Me.ToolStripLabel1})
    	Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
    	Me.ToolStrip1.Name = "ToolStrip1"
    	Me.ToolStrip1.Size = New System.Drawing.Size(801, 25)
    	Me.ToolStrip1.TabIndex = 0
    	'
    	'ToolStripButton1
    	'
    	Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
    	Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton1.Name = "ToolStripButton1"
    	Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton1.Text = "Path"
    	'
    	'ToolStripButton2
    	'
    	Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
    	Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton2.Name = "ToolStripButton2"
    	Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton2.Text = "Refresh"
    	'
    	'ToolStripButton17
    	'
    	Me.ToolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton17.Image = CType(resources.GetObject("ToolStripButton17.Image"),System.Drawing.Image)
    	Me.ToolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton17.Name = "ToolStripButton17"
    	Me.ToolStripButton17.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton17.Text = "Stop"
    	'
    	'ToolStripSeparator4
    	'
    	Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
    	Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
    	'
    	'ToolStripButton7
    	'
    	Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"),System.Drawing.Image)
    	Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton7.Name = "ToolStripButton7"
    	Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton7.Text = "Load"
    	'
    	'ToolStripButton8
    	'
    	Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"),System.Drawing.Image)
    	Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton8.Name = "ToolStripButton8"
    	Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton8.Text = "Edit"
    	Me.ToolStripButton8.ToolTipText = "Edit"
    	'
    	'ToolStripButton9
    	'
    	Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"),System.Drawing.Image)
    	Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton9.Name = "ToolStripButton9"
    	Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton9.Text = "Install"
    	'
    	'ToolStripButton16
    	'
    	Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"),System.Drawing.Image)
    	Me.ToolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton16.Name = "ToolStripButton16"
    	Me.ToolStripButton16.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton16.Text = "ReName"
    	'
    	'ToolStripSeparator5
    	'
    	Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
    	Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
    	'
    	'ToolStripButton10
    	'
    	Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"),System.Drawing.Image)
    	Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton10.Name = "ToolStripButton10"
    	Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton10.Text = "Open"
    	'
    	'ToolStripButton3
    	'
    	Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"),System.Drawing.Image)
    	Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton3.Name = "ToolStripButton3"
    	Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton3.Text = "CopyTo"
    	'
    	'ToolStripButton4
    	'
    	Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"),System.Drawing.Image)
    	Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton4.Name = "ToolStripButton4"
    	Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton4.Text = "MoveTo"
    	'
    	'ToolStripButton5
    	'
    	Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"),System.Drawing.Image)
    	Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton5.Name = "ToolStripButton5"
    	Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton5.Text = "Delete"
    	'
    	'ToolStripButton6
    	'
    	Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"),System.Drawing.Image)
    	Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton6.Name = "ToolStripButton6"
    	Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton6.Text = "SelectAll"
    	'
    	'ToolStripButton15
    	'
    	Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"),System.Drawing.Image)
    	Me.ToolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton15.Name = "ToolStripButton15"
    	Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton15.Text = "Attribute"
    	'
    	'ToolStripSeparator6
    	'
    	Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
    	Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
    	'
    	'ToolStripButton11
    	'
    	Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"),System.Drawing.Image)
    	Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton11.Name = "ToolStripButton11"
    	Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton11.Text = "Android Explorer"
    	'
    	'ToolStripButton12
    	'
    	Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"),System.Drawing.Image)
    	Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton12.Name = "ToolStripButton12"
    	Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton12.Text = "Apps"
    	'
    	'ToolStripButton13
    	'
    	Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"),System.Drawing.Image)
    	Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton13.Name = "ToolStripButton13"
    	Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton13.Text = "Tools"
    	'
    	'ToolStripSeparator7
    	'
    	Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
    	Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
    	'
    	'ToolStripButton14
    	'
    	Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"),System.Drawing.Image)
    	Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton14.Name = "ToolStripButton14"
    	Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton14.Text = "Setting"
    	'
    	'ToolStripButton19
    	'
    	Me.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton19.Image = CType(resources.GetObject("ToolStripButton19.Image"),System.Drawing.Image)
    	Me.ToolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton19.Name = "ToolStripButton19"
    	Me.ToolStripButton19.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton19.Text = "Devices"
    	'
    	'ToolStripSeparator8
    	'
    	Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
    	Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
    	'
    	'ToolStripComboBox3
    	'
    	Me.ToolStripComboBox3.AutoToolTip = true
    	Me.ToolStripComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    	Me.ToolStripComboBox3.DropDownWidth = 300
    	Me.ToolStripComboBox3.MaxDropDownItems = 100
    	Me.ToolStripComboBox3.Name = "ToolStripComboBox3"
    	Me.ToolStripComboBox3.Size = New System.Drawing.Size(121, 25)
    	'
    	'ToolStripSeparator9
    	'
    	Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
    	Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
    	'
    	'ToolStripButton18
    	'
    	Me.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"),System.Drawing.Image)
    	Me.ToolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton18.Name = "ToolStripButton18"
    	Me.ToolStripButton18.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton18.Text = "About(Made By Gentle)"
    	'
    	'ToolStripSeparator10
    	'
    	Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
    	Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
    	'
    	'ToolStripButton20
    	'
    	Me.ToolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    	Me.ToolStripButton20.Image = CType(resources.GetObject("ToolStripButton20.Image"),System.Drawing.Image)
    	Me.ToolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta
    	Me.ToolStripButton20.Name = "ToolStripButton20"
    	Me.ToolStripButton20.Size = New System.Drawing.Size(23, 22)
    	Me.ToolStripButton20.Text = "Support"
    	'
    	'ToolStripLabel1
    	'
    	Me.ToolStripLabel1.Name = "ToolStripLabel1"
    	Me.ToolStripLabel1.Size = New System.Drawing.Size(454, 17)
    	Me.ToolStripLabel1.Text = "若觉此软件方便有用,请往我的支付宝（ghostgzt@163.com）捐助1块钱以表支持！"
    	'
    	'BackgroundWorker1
    	'
    	Me.BackgroundWorker1.WorkerReportsProgress = true
    	Me.BackgroundWorker1.WorkerSupportsCancellation = true
    	'
    	'Button1
    	'
    	Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
    	Me.Button1.Location = New System.Drawing.Point(0, 0)
    	Me.Button1.Name = "Button1"
    	Me.Button1.Size = New System.Drawing.Size(5, 650)
    	Me.Button1.TabIndex = 3
    	Me.Button1.UseVisualStyleBackColor = true
    	'
    	'ImageList3
    	'
    	Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"),System.Windows.Forms.ImageListStreamer)
    	Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
    	Me.ImageList3.Images.SetKeyName(0, "system.backup.root.computer.ico")
    	Me.ImageList3.Images.SetKeyName(1, "shortcur_icon.ico")
    	'
    	'Viewz
    	'
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 12!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(804, 650)
    	Me.Controls.Add(Me.Button1)
    	Me.Controls.Add(Me.SplitContainer1)
    	Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
    	Me.Name = "Viewz"
    	Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    	Me.Text = "Apk Explorer"
    	Me.ContextMenuStrip1.ResumeLayout(false)
    	Me.SplitContainer1.Panel1.ResumeLayout(false)
    	Me.SplitContainer1.Panel2.ResumeLayout(false)
    	Me.SplitContainer1.ResumeLayout(false)
    	Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(false)
    	Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout
    	Me.ToolStripContainer1.ContentPanel.ResumeLayout(false)
    	Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(false)
    	Me.ToolStripContainer1.TopToolStripPanel.PerformLayout
    	Me.ToolStripContainer1.ResumeLayout(false)
    	Me.ToolStripContainer1.PerformLayout
    	Me.StatusStrip1.ResumeLayout(false)
    	Me.StatusStrip1.PerformLayout
    	Me.ToolStrip1.ResumeLayout(false)
    	Me.ToolStrip1.PerformLayout
    	Me.ResumeLayout(false)
    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents C1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents C2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents C3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents C4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AttributeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents LargeIconToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents AddToInstallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripDropDownButton2 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ViewInPagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox2 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripComboBox3 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton16 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton17 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripButton18 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton19 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton20 As System.Windows.Forms.ToolStripButton
End Class