Public Class Form1

    ' Event for btnClear and mnuClear
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNote.Text = ""
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        txtNote.Text = ""
    End Sub

    ' Event for btnSave and mnuSave
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dlgSaveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If dlgSaveFile.ShowDialog() = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(dlgSaveFile.FileName, txtNote.Text, False)
            MessageBox.Show("Note saved successfully", "Save Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        dlgSaveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If dlgSaveFile.ShowDialog() = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(dlgSaveFile.FileName, txtNote.Text, False)
            MessageBox.Show("Note saved successfully", "Save Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Event for btnOpen and mnuOpen
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        dlgOpenFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If dlgOpenFile.ShowDialog() = DialogResult.OK Then
            txtNote.Text = My.Computer.FileSystem.ReadAllText(dlgOpenFile.FileName)
        End If
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        dlgOpenFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If dlgOpenFile.ShowDialog() = DialogResult.OK Then
            txtNote.Text = My.Computer.FileSystem.ReadAllText(dlgOpenFile.FileName)
        End If
    End Sub

    ' Event for mnuExit
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    ' Event for mnuAbout
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MessageBox.Show("Note Application" & vbCrLf & "Version 1.0" & vbCrLf & "Author: AxoGM", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
