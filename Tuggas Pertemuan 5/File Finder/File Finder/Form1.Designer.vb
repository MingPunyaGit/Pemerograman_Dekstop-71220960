<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripProgressBar1 = New ToolStripProgressBar()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExportFileListToTextFileToolStripMenuItem = New ToolStripMenuItem()
        RefreshFolderToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripSeparator()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ImageList1 = New ImageList(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        ToolStripMenuItem6 = New ToolStripMenuItem()
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        RenameToolStripMenuItem = New ToolStripMenuItem()
        lblFind = New Label()
        cbFind = New ComboBox()
        txtExtension = New TextBox()
        btnSearch = New Button()
        SplitContainer1 = New SplitContainer()
        Label3 = New Label()
        lvFile = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        Label1 = New Label()
        lblInfo = New Label()
        tvDrive = New TreeView()
        StatusStrip1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripProgressBar1})
        StatusStrip1.Location = New Point(0, 339)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 12, 0)
        StatusStrip1.Size = New Size(884, 22)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(781, 17)
        ToolStripStatusLabel1.Spring = True
        ToolStripStatusLabel1.Text = "Ready"
        ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ToolStripProgressBar1
        ' 
        ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        ToolStripProgressBar1.Size = New Size(88, 16)
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(884, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExportFileListToTextFileToolStripMenuItem, RefreshFolderToolStripMenuItem, ToolStripMenuItem1, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ExportFileListToTextFileToolStripMenuItem
        ' 
        ExportFileListToTextFileToolStripMenuItem.Name = "ExportFileListToTextFileToolStripMenuItem"
        ExportFileListToTextFileToolStripMenuItem.Size = New Size(209, 22)
        ExportFileListToTextFileToolStripMenuItem.Text = "Export File List to Text File"
        ' 
        ' RefreshFolderToolStripMenuItem
        ' 
        RefreshFolderToolStripMenuItem.Name = "RefreshFolderToolStripMenuItem"
        RefreshFolderToolStripMenuItem.Size = New Size(209, 22)
        RefreshFolderToolStripMenuItem.Text = "Refresh Folder"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(206, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(209, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, ToolStripMenuItem2, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(107, 22)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(104, 6)
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(107, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drive.png")
        ImageList1.Images.SetKeyName(1, "folder.png")
        ImageList1.Images.SetKeyName(2, "file.png")
        ImageList1.Images.SetKeyName(3, "exe.png")
        ImageList1.Images.SetKeyName(4, "image.png")
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripMenuItem3, ToolStripMenuItem4, ToolStripMenuItem5, ToolStripMenuItem6, DeleteToolStripMenuItem, RenameToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(235, 136)
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(234, 22)
        ToolStripMenuItem3.Text = "Open/Execute File"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(234, 22)
        ToolStripMenuItem4.Text = "Open and Select File in Folder "
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(234, 22)
        ToolStripMenuItem5.Text = "Copy Full Path to Clipboard "
        ' 
        ' ToolStripMenuItem6
        ' 
        ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        ToolStripMenuItem6.Size = New Size(234, 22)
        ToolStripMenuItem6.Text = "Copy Folder Path to Clipboard"
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.Size = New Size(234, 22)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' RenameToolStripMenuItem
        ' 
        RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        RenameToolStripMenuItem.Size = New Size(234, 22)
        RenameToolStripMenuItem.Text = "Rename"
        ' 
        ' lblFind
        ' 
        lblFind.AutoSize = True
        lblFind.Location = New Point(18, 24)
        lblFind.Name = "lblFind"
        lblFind.Size = New Size(33, 15)
        lblFind.TabIndex = 3
        lblFind.Text = "Find:"
        ' 
        ' cbFind
        ' 
        cbFind.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbFind.AutoCompleteSource = AutoCompleteSource.FileSystem
        cbFind.FormattingEnabled = True
        cbFind.Location = New Point(57, 21)
        cbFind.Margin = New Padding(3, 2, 3, 2)
        cbFind.Name = "cbFind"
        cbFind.Size = New Size(512, 23)
        cbFind.TabIndex = 4
        ' 
        ' txtExtension
        ' 
        txtExtension.Location = New Point(575, 21)
        txtExtension.Margin = New Padding(3, 2, 3, 2)
        txtExtension.Name = "txtExtension"
        txtExtension.Size = New Size(46, 23)
        txtExtension.TabIndex = 5
        txtExtension.Text = "*.* "
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(638, 24)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(82, 22)
        btnSearch.TabIndex = 6
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(10, 23)
        SplitContainer1.Margin = New Padding(3, 2, 3, 2)
        SplitContainer1.Name = "SplitContainer1"
        SplitContainer1.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(cbFind)
        SplitContainer1.Panel1.Controls.Add(btnSearch)
        SplitContainer1.Panel1.Controls.Add(txtExtension)
        SplitContainer1.Panel1.Controls.Add(lblFind)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Label3)
        SplitContainer1.Panel2.Controls.Add(lvFile)
        SplitContainer1.Panel2.Controls.Add(Label1)
        SplitContainer1.Panel2.Controls.Add(lblInfo)
        SplitContainer1.Panel2.Controls.Add(tvDrive)
        SplitContainer1.Size = New Size(801, 321)
        SplitContainer1.SplitterDistance = 71
        SplitContainer1.SplitterWidth = 3
        SplitContainer1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 4
        Label3.Text = "Label3"
        ' 
        ' lvFile
        ' 
        lvFile.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9})
        lvFile.ContextMenuStrip = ContextMenuStrip1
        lvFile.GridLines = True
        lvFile.Location = New Point(313, 2)
        lvFile.Margin = New Padding(3, 2, 3, 2)
        lvFile.Name = "lvFile"
        lvFile.Size = New Size(488, 245)
        lvFile.SmallImageList = ImageList1
        lvFile.TabIndex = 3
        lvFile.UseCompatibleStateImageBehavior = False
        lvFile.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Name"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Extension"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "File Size"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Last Modified"
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Last Accessed"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Created Date"
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Attributes"
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Full Path"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(4, 164)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 2
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInfo.Location = New Point(10, 148)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(121, 15)
        lblInfo.TabIndex = 1
        lblInfo.Text = "Free Fixed Disk Info:"
        ' 
        ' tvDrive
        ' 
        tvDrive.ImageIndex = 0
        tvDrive.ImageList = ImageList1
        tvDrive.Location = New Point(3, 2)
        tvDrive.Margin = New Padding(3, 2, 3, 2)
        tvDrive.Name = "tvDrive"
        tvDrive.SelectedImageIndex = 0
        tvDrive.Size = New Size(304, 144)
        tvDrive.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(884, 361)
        Controls.Add(SplitContainer1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FileFinder"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportFileListToTextFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents lblFind As Label
    Friend WithEvents cbFind As ComboBox
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lvFile As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents Label3 As Label
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem

End Class
