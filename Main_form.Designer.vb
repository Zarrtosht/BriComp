<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Material1")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Material2")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Material3")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Materials", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Steel")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Concrete")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cross section1", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Steel")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Concrete")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cross section2", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Steel")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Concrete")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cross section3", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cross sections", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode10, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Permanent")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Variable")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Loads", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cross section1")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Material1")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1", New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cross section2 ")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Material2")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2", New System.Windows.Forms.TreeNode() {TreeNode21, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cross section3")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Material3")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("3", New System.Windows.Forms.TreeNode() {TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Segments", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode23, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Concrete casting")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Launching")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Construction ", New System.Windows.Forms.TreeNode() {TreeNode28, TreeNode29})
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Structure", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode27, TreeNode30})
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3 (0.88)")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4 (0.92)")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5 (0.95)")
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node6 (0.98)")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Segment1 (0.98)", New System.Windows.Forms.TreeNode() {TreeNode32, TreeNode33, TreeNode34, TreeNode35})
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node7")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node8")
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node9")
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node10")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Segment2 (0.89)", New System.Windows.Forms.TreeNode() {TreeNode37, TreeNode38, TreeNode39, TreeNode40})
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node11")
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node12")
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node13")
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node14")
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Segment3 (0.97)", New System.Windows.Forms.TreeNode() {TreeNode42, TreeNode43, TreeNode44, TreeNode45})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_form))
        Me.CMSmat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddMat = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSsteel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddSteel = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.modelTab = New System.Windows.Forms.TabPage()
        Me.Tree = New System.Windows.Forms.TreeView()
        Me.resultsTab = New System.Windows.Forms.TabPage()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.HejToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripProgressBar2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalysisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMSmat.SuspendLayout()
        Me.CMSsteel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.modelTab.SuspendLayout()
        Me.resultsTab.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CMSmat
        '
        Me.CMSmat.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMSmat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMat})
        Me.CMSmat.Name = "ContextMenuStrip1"
        Me.CMSmat.Size = New System.Drawing.Size(107, 28)
        '
        'AddMat
        '
        Me.AddMat.Name = "AddMat"
        Me.AddMat.Size = New System.Drawing.Size(106, 24)
        Me.AddMat.Text = "Add"
        '
        'CMSsteel
        '
        Me.CMSsteel.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMSsteel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSteel})
        Me.CMSsteel.Name = "ContextMenuStrip1"
        Me.CMSsteel.Size = New System.Drawing.Size(107, 28)
        '
        'AddSteel
        '
        Me.AddSteel.Name = "AddSteel"
        Me.AddSteel.Size = New System.Drawing.Size(106, 24)
        Me.AddSteel.Text = "Add"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.modelTab)
        Me.TabControl1.Controls.Add(Me.resultsTab)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(216, 331)
        Me.TabControl1.TabIndex = 4
        '
        'modelTab
        '
        Me.modelTab.BackColor = System.Drawing.SystemColors.Control
        Me.modelTab.Controls.Add(Me.Tree)
        Me.modelTab.Location = New System.Drawing.Point(4, 25)
        Me.modelTab.Name = "modelTab"
        Me.modelTab.Padding = New System.Windows.Forms.Padding(3)
        Me.modelTab.Size = New System.Drawing.Size(208, 302)
        Me.modelTab.TabIndex = 0
        Me.modelTab.Text = "Model"
        '
        'Tree
        '
        Me.Tree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tree.Location = New System.Drawing.Point(3, 3)
        Me.Tree.Margin = New System.Windows.Forms.Padding(10)
        Me.Tree.Name = "Tree"
        TreeNode1.Name = "Node11"
        TreeNode1.Text = "Material1"
        TreeNode2.Name = "Node12"
        TreeNode2.Text = "Material2"
        TreeNode3.Name = "Node13"
        TreeNode3.Text = "Material3"
        TreeNode4.Checked = True
        TreeNode4.ContextMenuStrip = Me.CMSmat
        TreeNode4.Name = "MaterialsNode"
        TreeNode4.Text = "Materials"
        TreeNode5.ContextMenuStrip = Me.CMSsteel
        TreeNode5.Name = "SteelNode"
        TreeNode5.Text = "Steel"
        TreeNode6.Name = "ConcreteNode"
        TreeNode6.Text = "Concrete"
        TreeNode7.Name = "Node0"
        TreeNode7.Text = "Cross section1"
        TreeNode8.Name = "Node2"
        TreeNode8.Text = "Steel"
        TreeNode9.Name = "Node3"
        TreeNode9.Text = "Concrete"
        TreeNode10.Name = "Node1"
        TreeNode10.Text = "Cross section2"
        TreeNode11.Name = "Node5"
        TreeNode11.Text = "Steel"
        TreeNode12.Name = "Node6"
        TreeNode12.Text = "Concrete"
        TreeNode13.Name = "Node4"
        TreeNode13.Text = "Cross section3"
        TreeNode14.Name = "SectionsNode"
        TreeNode14.Text = "Cross sections"
        TreeNode15.Name = "Node6"
        TreeNode15.Text = "Permanent"
        TreeNode16.Name = "Node7"
        TreeNode16.Text = "Variable"
        TreeNode17.Name = "Node3"
        TreeNode17.Text = "Loads"
        TreeNode18.Name = "Node3"
        TreeNode18.Text = "Cross section1"
        TreeNode19.Name = "Node14"
        TreeNode19.Text = "Material1"
        TreeNode20.Name = "Node0"
        TreeNode20.Text = "1"
        TreeNode21.Name = "Node4"
        TreeNode21.Text = "Cross section2 "
        TreeNode22.Name = "Node15"
        TreeNode22.Text = "Material2"
        TreeNode23.Name = "Node1"
        TreeNode23.Text = "2"
        TreeNode24.Name = "Node5"
        TreeNode24.Text = "Cross section3"
        TreeNode25.Name = "Node16"
        TreeNode25.Text = "Material3"
        TreeNode26.Name = "Node2"
        TreeNode26.Text = "3"
        TreeNode27.Name = "Segments"
        TreeNode27.Text = "Segments"
        TreeNode28.Name = "Node9"
        TreeNode28.Text = "Concrete casting"
        TreeNode29.Name = "Node10"
        TreeNode29.Text = "Launching"
        TreeNode30.Name = "Node8"
        TreeNode30.Text = "Construction "
        TreeNode31.Name = "StructureNode"
        TreeNode31.Text = "Structure"
        Me.Tree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode14, TreeNode31})
        Me.Tree.Size = New System.Drawing.Size(202, 296)
        Me.Tree.TabIndex = 3
        '
        'resultsTab
        '
        Me.resultsTab.BackColor = System.Drawing.SystemColors.Control
        Me.resultsTab.Controls.Add(Me.TreeView1)
        Me.resultsTab.Location = New System.Drawing.Point(4, 25)
        Me.resultsTab.Name = "resultsTab"
        Me.resultsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.resultsTab.Size = New System.Drawing.Size(208, 302)
        Me.resultsTab.TabIndex = 1
        Me.resultsTab.Text = "Results"
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(3, 3)
        Me.TreeView1.Name = "TreeView1"
        TreeNode32.Name = "Node3"
        TreeNode32.Text = "Node3 (0.88)"
        TreeNode33.Name = "Node4"
        TreeNode33.Text = "Node4 (0.92)"
        TreeNode34.Name = "Node5"
        TreeNode34.Text = "Node5 (0.95)"
        TreeNode35.Name = "Node6"
        TreeNode35.Text = "Node6 (0.98)"
        TreeNode36.Name = "Node0"
        TreeNode36.Text = "Segment1 (0.98)"
        TreeNode37.Name = "Node7"
        TreeNode37.Text = "Node7"
        TreeNode38.Name = "Node8"
        TreeNode38.Text = "Node8"
        TreeNode39.Name = "Node9"
        TreeNode39.Text = "Node9"
        TreeNode40.Name = "Node10"
        TreeNode40.Text = "Node10"
        TreeNode41.Name = "Node1"
        TreeNode41.Text = "Segment2 (0.89)"
        TreeNode42.Name = "Node11"
        TreeNode42.Text = "Node11"
        TreeNode43.Name = "Node12"
        TreeNode43.Text = "Node12"
        TreeNode44.Name = "Node13"
        TreeNode44.Text = "Node13"
        TreeNode45.Name = "Node14"
        TreeNode45.Text = "Node14"
        TreeNode46.Name = "Node2"
        TreeNode46.Text = "Segment3 (0.97)"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode36, TreeNode41, TreeNode46})
        Me.TreeView1.Size = New System.Drawing.Size(202, 296)
        Me.TreeView1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 31)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1017, 461)
        Me.SplitContainer1.SplitterDistance = 331
        Me.SplitContainer1.TabIndex = 5
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabControl1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ToolStripContainer1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1017, 331)
        Me.SplitContainer2.SplitterDistance = 216
        Me.SplitContainer2.TabIndex = 0
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl2)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(797, 303)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(797, 331)
        Me.ToolStripContainer1.TabIndex = 8
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        Me.ToolStripContainer1.TopToolStripPanel.ImeMode = System.Windows.Forms.ImeMode.[On]
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(797, 303)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(789, 274)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(789, 274)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripSplitButton2, Me.ToolStripComboBox2, Me.ToolStripProgressBar2})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(363, 28)
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(24, 25)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(24, 25)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(24, 25)
        Me.ToolStripButton6.Text = "ToolStripButton6"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(24, 25)
        Me.ToolStripButton7.Text = "ToolStripButton7"
        '
        'ToolStripSplitButton2
        '
        Me.ToolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HejToolStripMenuItem})
        Me.ToolStripSplitButton2.Image = CType(resources.GetObject("ToolStripSplitButton2.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton2.Name = "ToolStripSplitButton2"
        Me.ToolStripSplitButton2.Size = New System.Drawing.Size(39, 25)
        Me.ToolStripSplitButton2.Text = "ToolStripSplitButton2"
        '
        'HejToolStripMenuItem
        '
        Me.HejToolStripMenuItem.Name = "HejToolStripMenuItem"
        Me.HejToolStripMenuItem.Size = New System.Drawing.Size(104, 26)
        Me.HejToolStripMenuItem.Text = "hej"
        '
        'ToolStripComboBox2
        '
        Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
        Me.ToolStripComboBox2.Size = New System.Drawing.Size(121, 28)
        '
        'ToolStripProgressBar2
        '
        Me.ToolStripProgressBar2.Name = "ToolStripProgressBar2"
        Me.ToolStripProgressBar2.Size = New System.Drawing.Size(100, 25)
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(1017, 126)
        Me.TextBox1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.AnalysisToolStripMenuItem, Me.RunToolStripMenuItem, Me.ToolStripMenuItem9})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(272, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.tsExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(220, 26)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'tsExit
        '
        Me.tsExit.Name = "tsExit"
        Me.tsExit.Size = New System.Drawing.Size(220, 26)
        Me.tsExit.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(220, 26)
        Me.ToolStripMenuItem3.Text = "ToolStripMenuItem3"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(220, 26)
        Me.ToolStripMenuItem4.Text = "ToolStripMenuItem4"
        '
        'AnalysisToolStripMenuItem
        '
        Me.AnalysisToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.AnalysisToolStripMenuItem.Name = "AnalysisToolStripMenuItem"
        Me.AnalysisToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.AnalysisToolStripMenuItem.Text = "Analysis"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(220, 26)
        Me.ToolStripMenuItem5.Text = "ToolStripMenuItem5"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(220, 26)
        Me.ToolStripMenuItem6.Text = "ToolStripMenuItem6"
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem8})
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.RunToolStripMenuItem.Text = "Run"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(220, 26)
        Me.ToolStripMenuItem7.Text = "ToolStripMenuItem7"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(220, 26)
        Me.ToolStripMenuItem8.Text = "ToolStripMenuItem8"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem10, Me.ToolStripMenuItem11})
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(53, 24)
        Me.ToolStripMenuItem9.Text = "Help"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(228, 26)
        Me.ToolStripMenuItem10.Text = "ToolStripMenuItem10"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(228, 26)
        Me.ToolStripMenuItem11.Text = "ToolStripMenuItem11"
        '
        'Main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 504)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main_form"
        Me.Text = "Main"
        Me.CMSmat.ResumeLayout(False)
        Me.CMSsteel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.modelTab.ResumeLayout(False)
        Me.resultsTab.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Tree As TreeView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents modelTab As TabPage
    Friend WithEvents resultsTab As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tsExit As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnalysisToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents CMSmat As ContextMenuStrip
    Friend WithEvents AddMat As ToolStripMenuItem
    Friend WithEvents CMSsteel As ContextMenuStrip
    Friend WithEvents AddSteel As ToolStripMenuItem
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripSplitButton2 As ToolStripSplitButton
    Friend WithEvents ToolStripComboBox2 As ToolStripComboBox
    Friend WithEvents ToolStripProgressBar2 As ToolStripProgressBar
    Friend WithEvents HejToolStripMenuItem As ToolStripMenuItem
End Class
