Imports System.IO
Imports System.Net.WebRequestMethods
Imports System.Reflection.Emit
Imports File = System.IO.File

Public Class Form1



    Private Function FormatFileSize(ByVal FileSizeBytes As Long) As String
        Dim sizeTypes() As String = {"b", "Kb", "Mb", "Gb"}
        Dim Len As Decimal = FileSizeBytes
        Dim sizeType As Integer = 0
        Do While Len > 1024
            Len = Decimal.Round(Len / 1024, 2)
            sizeType += 1
            If sizeType >= sizeTypes.Length - 1 Then Exit Do
        Loop
        Dim Resp As String = Len.ToString & " " & sizeTypes(sizeType)
        Return Resp
    End Function


    Private Sub GetFiles(ByVal PathName As String)
        Dim LItem As ListViewItem
        lvFile.Items.Clear()
        lvFile.BeginUpdate()

        For Each nFile As String In Directory.GetFiles(PathName, txtExtension.Text.Trim)

            Dim sExtension As String = Path.GetExtension(nFile)
            sExtension = sExtension.ToLower
            Dim f As FileInfo = New FileInfo(nFile)

            If (f.Attributes And FileAttributes.Hidden) = False Then
                Dim att As String = f.Attributes.ToString
                Dim size As String = f.Length.ToString
                Dim dibuat As String = f.CreationTime.ToString
                Dim akses As String = f.LastAccessTime.ToString
                Dim modi As String = f.LastWriteTime.ToString

                LItem = New ListViewItem()
                Dim iconForFile As Icon = SystemIcons.WinLogo
                If Not (ImageList1.Images.ContainsKey(sExtension)) Then
                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(nFile)
                    ImageList1.Images.Add(sExtension, iconForFile)
                End If

                With LItem
                    .SubItems(0).Text = Path.GetFileNameWithoutExtension(nFile)
                    .SubItems.Add(sExtension)
                    .SubItems.Add(FormatFileSize(size))
                    .SubItems.Add(modi)
                    .SubItems.Add(akses)
                    .SubItems.Add(dibuat)
                    .SubItems.Add(att)
                    .SubItems.Add(nFile)
                    .ImageKey = sExtension
                    .Tag = Path.Combine(PathName, nFile)
                End With
                lvFile.Items.Add(LItem)
            End If
        Next
        lvFile.EndUpdate()
        For i As Integer = 0 To lvFile.Columns.Count - 1
            lvFile.Columns(i).Width = -2
        Next
    End Sub


    Private Sub GetFiles2(ByVal PathName As String)
        Dim LItem As ListViewItem
        lvFile.Items.Clear()
        lvFile.BeginUpdate()
        Try
            With ToolStripProgressBar1
                .Maximum = My.Computer.FileSystem.GetFiles(PathName).Count
                .Minimum = 0
                .Step = 1
                .Value = 1
            End With
        Catch ua As UnauthorizedAccessException
        Catch ex As Exception
        End Try
        Try

            For Each nFile As String In Directory.GetFiles(PathName, txtExtension.Text, SearchOption.AllDirectories)
                If nFile.ToLower.Contains(cbFind.Text.ToLower) Then
                    ToolStripProgressBar1.PerformStep()

                    Dim sExtension As String = Path.GetExtension(nFile)
                    sExtension = sExtension.ToLower
                    Dim f As FileInfo = New FileInfo(nFile)
                    If (f.Attributes And FileAttributes.Hidden) = False Then
                        Dim att As String = f.Attributes.ToString
                        Dim size As String = f.Length.ToString
                        Dim dibuat As String = f.CreationTime.ToString
                        Dim akses As String = f.LastAccessTime.ToString
                        Dim modi As String = f.LastWriteTime.ToString
                        LItem = New ListViewItem()
                        Dim iconForFile As Icon = SystemIcons.WinLogo
                        If Not (ImageList1.Images.ContainsKey(sExtension)) Then
                            iconForFile =
                            System.Drawing.Icon.ExtractAssociatedIcon(nFile)
                            ImageList1.Images.Add(sExtension, iconForFile)
                        End If
                        With LItem
                            .SubItems(0).Text =
                            Path.GetFileNameWithoutExtension(nFile)
                            .SubItems.Add(sExtension)
                            .SubItems.Add(FormatFileSize(size))
                            .SubItems.Add(modi)
                            .SubItems.Add(akses)
                            .SubItems.Add(dibuat)
                            .SubItems.Add(att)
                            .SubItems.Add(nFile)
                            .ImageKey = sExtension
                            .Tag = Path.Combine(PathName, nFile)
                        End With
                        lvFile.Items.Add(LItem)
                    End If
                End If
            Next nFile
        Catch ua As UnauthorizedAccessException
            ToolStripProgressBar1.PerformStep()
        Catch ex As Exception
            ToolStripProgressBar1.PerformStep()
        End Try
        lvFile.EndUpdate()
        For i As Integer = 0 To lvFile.Columns.Count - 1
            lvFile.Columns(i).Width = -2
        Next
    End Sub

    Private Sub GetFolders(ByVal PathName As TreeNode)
        Dim di As DirectoryInfo
        PathName.Nodes.Clear()
        di = New DirectoryInfo(PathName.Tag)
        Try
            For Each nFolder As DirectoryInfo In di.GetDirectories()
                Dim tNode As New TreeNode()
                With tNode
                    .ImageIndex = 1
                    .SelectedImageIndex = 1
                    .Tag = nFolder.FullName
                    .Text = nFolder.Name.ToString()
                    .Nodes.Add("")
                End With
                di = New DirectoryInfo(tNode.Tag)
                If (di.Attributes And FileAttributes.Hidden) = False Then
                    PathName.Nodes.Add(tNode)
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub


    Private Sub GetDrives()

        tvDrive.Nodes.Clear()
        For Each Drive In DriveInfo.GetDrives

            If (Drive.IsReady) Then
                Dim dName As String = Drive.VolumeLabel
                If String.IsNullOrEmpty(dName) Then
                    dName = Drive.Name
                End If

                Dim tNode As New TreeNode()

                With tNode
                    .ImageIndex = 0
                    .SelectedImageIndex = 0
                    .Text = dName
                    .Nodes.Add("")
                    .Tag = Drive.Name
                End With
                Call tvDrive.Nodes.Add(tNode)
            End If
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDrives()
        For i As Integer = 0 To lvFile.Columns.Count - 1
            lvFile.Columns(i).Width = -2
        Next

        For Each curDrive As DriveInfo In My.Computer.FileSystem.Drives
            If curDrive.DriveType = DriveType.Fixed Then
                Dim theFreeSpace As Long = curDrive.AvailableFreeSpace
                Label3.Text &= curDrive.VolumeLabel & " (" & curDrive.Name & ") Free " & FormatFileSize(theFreeSpace) & " - " & curDrive.DriveFormat & vbCrLf
            End If
        Next
    End Sub

    Private Sub tvDrive_BeforeExpand(sender As System.Object, e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tvDrive.BeforeExpand
        GetFolders(e.Node)
    End Sub

    Private Sub tvDrive_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvDrive.AfterSelect
        Dim tNode As TreeNode = tvDrive.SelectedNode
        GetFiles(e.Node.Tag)
        ToolStripProgressBar1.Value = 0
        ToolStripStatusLabel1.Text = e.Node.Tag
    End Sub



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If ToolStripStatusLabel1.Text <> "Ready" And My.Computer.FileSystem.DirectoryExists(ToolStripStatusLabel1.Text) Then
            GetFiles2(ToolStripStatusLabel1.Text)
            ToolStripProgressBar1.Value = ToolStripProgressBar1.Maximum
        Else
            MsgBox("Please select a drive/directory first from Tree View on the left side")
        End If
    End Sub

    Private Sub lvFile_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lvFile.DoubleClick
        If lvFile.SelectedItems.Count = 1 Then
            Process.Start(lvFile.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("File Finder v1.0" & vbCrLf & "Created by: Imanuel" & vbCrLf & "Enjoy it!", MsgBoxStyle.Information, "About")
    End Sub


    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If lvFile.SelectedItems.Count = 1 Then
            Process.Start(lvFile.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        If lvFile.SelectedItems.Count = 1 Then
            Process.Start("explorer.exe", "/select," & lvFile.SelectedItems(0).Tag)
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        If lvFile.SelectedItems.Count = 1 Then
            Clipboard.SetText(lvFile.SelectedItems(0).Tag)
            MsgBox("Copied Successfully!")
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        If lvFile.SelectedItems.Count = 1 Then
            Clipboard.SetText(Path.GetDirectoryName(lvFile.SelectedItems(0).Tag))
            MsgBox("Copied Successfully!")
        End If
    End Sub

    Private Sub RefreshFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshFolderToolStripMenuItem.Click
        GetDrives()
        For i As Integer = 0 To lvFile.Columns.Count - 1
            lvFile.Columns(i).Width = -2
        Next
    End Sub

    Private Sub txtExtension_Leave(sender As System.Object, e As System.EventArgs) Handles txtExtension.Leave
        If ToolStripStatusLabel1.Text <> "Ready" Then
            GetFiles(ToolStripStatusLabel1.Text)
            ToolStripProgressBar1.Value = 0
        End If
    End Sub

    Private Sub ExportFileListToTextFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportFileListToTextFileToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog
        sfd.DefaultExt = "*.txt"
        sfd.FileName = "Export.txt"
        sfd.Filter = "Text File (*.txt) | *.txt"

        If sfd.ShowDialog = DialogResult.OK Then
            Using writer As New StreamWriter(sfd.FileName)
                writer.Write("Name,Extension,File Size,Last Modified,Last Accessed,File Created,Attributes,Full Path")
                writer.WriteLine()
                For Each item As ListViewItem In lvFile.Items
                    For index = 0 To item.SubItems.Count - 1
                        If index > 0 Then
                            writer.Write(",")
                        End If
                        writer.Write(item.SubItems(index).Text)
                    Next
                    writer.WriteLine()
                Next
            End Using
        End If
    End Sub


    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        If lvFile.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvFile.SelectedItems(0)
            Dim filePath As String = selectedItem.Tag.ToString()

            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus file:" & vbCrLf & filePath, "Konfirmasi Hapus File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Try
                    File.Delete(filePath)

                    lvFile.Items.Remove(selectedItem)

                    MessageBox.Show("File berhasil dihapus.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Gagal menghapus file: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        If lvFile.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvFile.SelectedItems(0)
            Dim oldFilePath As String = selectedItem.Tag.ToString()
            Dim oldFileName As String = Path.GetFileName(oldFilePath)

            Dim newFileName As String = InputBox("Masukkan nama file baru:", "Ganti Nama File", oldFileName)

            If Not String.IsNullOrWhiteSpace(newFileName) AndAlso newFileName <> oldFileName Then
                Try
                    Dim newFilePath As String = Path.Combine(Path.GetDirectoryName(oldFilePath), newFileName)

                    File.Move(oldFilePath, newFilePath)

                    selectedItem.SubItems(0).Text = Path.GetFileNameWithoutExtension(newFileName)
                    selectedItem.SubItems(2).Text = Path.GetExtension(newFileName)
                    selectedItem.SubItems(7).Text = newFilePath
                    selectedItem.Tag = newFilePath

                    MessageBox.Show("File berhasil diganti nama.", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    MessageBox.Show("Gagal mengganti nama file: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

End Class
