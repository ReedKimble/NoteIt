<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(242, 216)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(268, 63)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(6, 7)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(122, 49)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(140, 7)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(122, 49)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.CheckBox1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox2, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LinkLabel1, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 2, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(16, 18)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(494, 185)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AutoSave"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label1, "Auto save current note when closing the program")
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Default Save Folder"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label2, "The folder where notes are saved unless using Save As or opening an existing note" &
        "")
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Filename Format"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label3, "The date/time format for the file name - MUST be a valid date/time format string " &
        "and must result in a valid file name")
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Note Text Font"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Label4, "The font used for the note text box")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = Global.NoteIt.My.MySettings.Default.AutoSave
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.NoteIt.My.MySettings.Default, "AutoSave", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(191, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(22, 21)
        Me.CheckBox1.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Auto save current note when closing the program")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.NoteIt.My.MySettings.Default, "DefaultSaveFolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(191, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 34)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = Global.NoteIt.My.MySettings.Default.DefaultSaveFolder
        Me.ToolTip1.SetToolTip(Me.TextBox1, "The folder where notes are saved unless using Save As or opening an existing note" &
        "")
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.NoteIt.My.MySettings.Default, "FilenameFormat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Location = New System.Drawing.Point(191, 75)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(188, 34)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = Global.NoteIt.My.MySettings.Default.FilenameFormat
        Me.ToolTip1.SetToolTip(Me.TextBox2, "The date/time format for the file name - MUST be a valid date/time format string " &
        "and must result in a valid file name")
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.NoteIt.My.MySettings.Default, "TextFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Label5.Font = Global.NoteIt.My.MySettings.Default.TextFont
        Me.Label5.Location = New System.Drawing.Point(191, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 72)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Example note Text 123"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label5, "An example of the font used for the note text box")
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(392, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Edit..."
        Me.ToolTip1.SetToolTip(Me.Button1, "Modify the font used for the note text box")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(403, 78)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(70, 28)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "(more)"
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "Open a browser to view detailed date/time format string information")
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.AutoSize = True
        Me.Button2.Location = New System.Drawing.Point(390, 31)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 38)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Browse..."
        Me.ToolTip1.SetToolTip(Me.Button2, "Modify the font used for the note text box")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OptionsDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(531, 295)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
