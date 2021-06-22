Imports System.ComponentModel
Imports System.Windows.Forms

Public Class OptionsDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FontDialog1.Font = My.Settings.TextFont
        If FontDialog1.ShowDialog = DialogResult.OK Then
            My.Settings.TextFont = FontDialog1.Font
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FolderBrowserDialog1.SelectedPath = TextBox1.Text
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If Not IO.Directory.Exists(TextBox1.Text) Then
            TextBox1.SelectAll()
            e.Cancel = True
            ToolTip1.Show("Must provide a valid path", TextBox1, 10)
            Button2.PerformClick()
        End If
    End Sub
End Class
