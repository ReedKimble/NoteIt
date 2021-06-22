Public Class Form1
    Private hasChanges As Boolean = False
    Private currentFileName As String = String.Empty
    Private localPath As String = Nothing

    Private Sub CheckSave()
        If hasChanges Then
            Try
                IO.File.WriteAllText(MakePath(localPath), RichTextBox1.Text)
                hasChanges = False
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Saving Note", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function MakePath(savePath As String) As String
        If String.IsNullOrEmpty(savePath) Then
            savePath = My.Settings.DefaultSaveFolder
        End If
        Return IO.Path.Combine(savePath, currentFileName)
    End Function

    Private Sub NewFile()
        CheckSave()
        currentFileName = Now.ToString(My.Settings.FilenameFormat) & ".txt"
        localPath = Nothing
        RichTextBox1.Clear()
        hasChanges = False
        UpdateTitle()
    End Sub

    Private Sub OpenFile()
        CheckSave()
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                RichTextBox1.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
                currentFileName = IO.Path.GetFileName(OpenFileDialog1.FileName)
                localPath = IO.Path.GetDirectoryName(OpenFileDialog1.FileName)
                hasChanges = False
                UpdateTitle()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Opening Note", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SaveFileAs()
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                IO.File.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text)
                currentFileName = IO.Path.GetFileName(SaveFileDialog1.FileName)
                localPath = IO.Path.GetDirectoryName(SaveFileDialog1.FileName)
                hasChanges = False
                UpdateTitle()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Saving Note", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub UpdateStatus()
        Dim lineCount = RichTextBox1.Lines.Count
        Dim textLength = RichTextBox1.TextLength
        Dim currentChar = RichTextBox1.SelectionStart
        Dim currentLine = RichTextBox1.GetLineFromCharIndex(currentChar)
        Dim currentPos = RichTextBox1.GetPositionFromCharIndex(currentChar)
        ToolStripStatusLabel1.Text = $"Char: {currentChar}/{textLength}, Line: {currentLine}/{lineCount}, Position: {currentPos}"
    End Sub

    Private Sub UpdateTitle()
        Me.Text = "NoteIt - " & currentFileName
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NewFile()
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        NewFile()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFile()
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        OpenFile()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        CheckSave()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        CheckSave()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileAs()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CutToolStripButton_Click(sender As Object, e As EventArgs) Handles CutToolStripButton.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Try
            Using dlg As New OptionsDialog
                Dim autoSave As Boolean = My.Settings.AutoSave
                Dim defaultSaveFolder As String = My.Settings.DefaultSaveFolder
                Dim filenameFormat As String = My.Settings.FilenameFormat
                Dim textFont As Font = My.Settings.TextFont

                If dlg.ShowDialog = DialogResult.OK Then
                    My.Settings.Save()
                Else
                    My.Settings.AutoSave = autoSave
                    My.Settings.DefaultSaveFolder = defaultSaveFolder
                    My.Settings.FilenameFormat = filenameFormat
                    My.Settings.TextFont = textFont
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Something's Gone Horribly Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CustomizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomizeToolStripMenuItem.Click
        FileMenuToolStrip.GripStyle = If(CustomizeToolStripMenuItem.Checked, ToolStripGripStyle.Visible, ToolStripGripStyle.Hidden)
        StatusStrip1.GripStyle = FileMenuToolStrip.GripStyle
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(My.Settings.DefaultSaveFolder) Then
            My.Settings.DefaultSaveFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            My.Settings.Save()
        End If
        Me.Size = My.Settings.WindowSize
        If My.Application.CommandLineArgs.Count > 0 Then
            Dim didOpen As Boolean = False
            For i = 0 To My.Application.CommandLineArgs.Count - 1
                Dim openPath = My.Application.CommandLineArgs.Item(i)
                If IO.File.Exists(openPath) Then
                    If didOpen Then
                        Process.Start(My.Application.Info.DirectoryPath, String.Join(" ", My.Application.CommandLineArgs.Skip(i)))
                        Exit For
                    End If
                    RichTextBox1.Text = IO.File.ReadAllText(openPath)
                    currentFileName = IO.Path.GetFileName(openPath)
                    localPath = IO.Path.GetDirectoryName(openPath)
                    hasChanges = False
                    didOpen = True
                End If
            Next
        Else
            NewFile()
        End If
        UpdateTitle()
        UpdateStatus()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If My.Settings.AutoSave Then CheckSave()
        My.Settings.WindowSize = Me.Size
        My.Settings.Save()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        hasChanges = RichTextBox1.TextLength > 0
        UpdateStatus()
    End Sub
End Class
