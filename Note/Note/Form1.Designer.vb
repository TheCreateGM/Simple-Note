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
        mnuMain = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        mnuClear = New ToolStripMenuItem()
        mnuSave = New ToolStripMenuItem()
        mnuOpen = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        mnuAbout = New ToolStripMenuItem()
        txtNote = New TextBox()
        btnClear = New Button()
        btnSave = New Button()
        btnOpen = New Button()
        dlgSaveFile = New SaveFileDialog()
        dlgOpenFile = New OpenFileDialog()
        mnuMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuMain
        ' 
        mnuMain.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem})
        mnuMain.Location = New Point(0, 0)
        mnuMain.Name = "mnuMain"
        mnuMain.Size = New Size(584, 24)
        mnuMain.TabIndex = 0
        mnuMain.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuClear, mnuSave, mnuOpen, mnuExit})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' mnuClear
        ' 
        mnuClear.Name = "mnuClear"
        mnuClear.Size = New Size(180, 22)
        mnuClear.Text = "Clear"
        ' 
        ' mnuSave
        ' 
        mnuSave.Name = "mnuSave"
        mnuSave.Size = New Size(180, 22)
        mnuSave.Text = "Save"
        ' 
        ' mnuOpen
        ' 
        mnuOpen.Name = "mnuOpen"
        mnuOpen.Size = New Size(180, 22)
        mnuOpen.Text = "Open"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(180, 22)
        mnuExit.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuAbout})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "&Edit"
        ' 
        ' mnuAbout
        ' 
        mnuAbout.Name = "mnuAbout"
        mnuAbout.Size = New Size(107, 22)
        mnuAbout.Text = "About"
        ' 
        ' txtNote
        ' 
        txtNote.Location = New Point(0, 27)
        txtNote.Multiline = True
        txtNote.Name = "txtNote"
        txtNote.ScrollBars = ScrollBars.Vertical
        txtNote.Size = New Size(584, 294)
        txtNote.TabIndex = 1
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(12, 327)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 2
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(250, 327)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnOpen
        ' 
        btnOpen.Location = New Point(497, 327)
        btnOpen.Name = "btnOpen"
        btnOpen.Size = New Size(75, 23)
        btnOpen.TabIndex = 4
        btnOpen.Text = "Open"
        btnOpen.UseVisualStyleBackColor = True
        ' 
        ' dlgOpenFile
        ' 
        dlgOpenFile.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 361)
        Controls.Add(btnOpen)
        Controls.Add(btnSave)
        Controls.Add(btnClear)
        Controls.Add(txtNote)
        Controls.Add(mnuMain)
        MainMenuStrip = mnuMain
        Name = "Form1"
        Text = "Simple Note App"
        mnuMain.ResumeLayout(False)
        mnuMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtNote As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents dlgSaveFile As SaveFileDialog
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem

End Class
