<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VOBReader_Main
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
        Me.btnTestA = New System.Windows.Forms.Button
        Me.txtDump = New System.Windows.Forms.TextBox
        Me.txtSector = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.btnExtract_Mthread = New System.Windows.Forms.Button
        Me.pbMain = New System.Windows.Forms.ProgressBar
        Me.btnExtract_1thread = New System.Windows.Forms.Button
        Me.btnExtractOneSector = New System.Windows.Forms.Button
        Me.btnTestB = New System.Windows.Forms.Button
        Me.btnUnlockDrive = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnTestA
        '
        Me.btnTestA.Location = New System.Drawing.Point(12, 182)
        Me.btnTestA.Name = "btnTestA"
        Me.btnTestA.Size = New System.Drawing.Size(104, 23)
        Me.btnTestA.TabIndex = 0
        Me.btnTestA.Text = "Test A"
        Me.btnTestA.UseVisualStyleBackColor = True
        '
        'txtDump
        '
        Me.txtDump.Location = New System.Drawing.Point(122, 71)
        Me.txtDump.Multiline = True
        Me.txtDump.Name = "txtDump"
        Me.txtDump.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDump.Size = New System.Drawing.Size(594, 294)
        Me.txtDump.TabIndex = 1
        '
        'txtSector
        '
        Me.txtSector.Location = New System.Drawing.Point(55, 98)
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Size = New System.Drawing.Size(61, 20)
        Me.txtSector.TabIndex = 4
        Me.txtSector.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Sector"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(12, 14)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(704, 20)
        Me.txtFileName.TabIndex = 7
        Me.txtFileName.Text = "G:\\video_ts\\vts_02_1.vob"
        '
        'btnExtract_Mthread
        '
        Me.btnExtract_Mthread.Location = New System.Drawing.Point(12, 124)
        Me.btnExtract_Mthread.Name = "btnExtract_Mthread"
        Me.btnExtract_Mthread.Size = New System.Drawing.Size(104, 23)
        Me.btnExtract_Mthread.TabIndex = 8
        Me.btnExtract_Mthread.Text = "Extract - M thread"
        Me.btnExtract_Mthread.UseVisualStyleBackColor = True
        '
        'pbMain
        '
        Me.pbMain.Location = New System.Drawing.Point(12, 40)
        Me.pbMain.Name = "pbMain"
        Me.pbMain.Size = New System.Drawing.Size(704, 23)
        Me.pbMain.TabIndex = 9
        '
        'btnExtract_1thread
        '
        Me.btnExtract_1thread.Location = New System.Drawing.Point(12, 153)
        Me.btnExtract_1thread.Name = "btnExtract_1thread"
        Me.btnExtract_1thread.Size = New System.Drawing.Size(104, 23)
        Me.btnExtract_1thread.TabIndex = 10
        Me.btnExtract_1thread.Text = "Extract - 1 thread"
        Me.btnExtract_1thread.UseVisualStyleBackColor = True
        '
        'btnExtractOneSector
        '
        Me.btnExtractOneSector.Location = New System.Drawing.Point(14, 71)
        Me.btnExtractOneSector.Name = "btnExtractOneSector"
        Me.btnExtractOneSector.Size = New System.Drawing.Size(104, 23)
        Me.btnExtractOneSector.TabIndex = 11
        Me.btnExtractOneSector.Text = "Extract 1 Sector"
        Me.btnExtractOneSector.UseVisualStyleBackColor = True
        '
        'btnTestB
        '
        Me.btnTestB.Location = New System.Drawing.Point(12, 211)
        Me.btnTestB.Name = "btnTestB"
        Me.btnTestB.Size = New System.Drawing.Size(104, 23)
        Me.btnTestB.TabIndex = 12
        Me.btnTestB.Text = "Test B"
        Me.btnTestB.UseVisualStyleBackColor = True
        '
        'btnUnlockDrive
        '
        Me.btnUnlockDrive.Location = New System.Drawing.Point(12, 240)
        Me.btnUnlockDrive.Name = "btnUnlockDrive"
        Me.btnUnlockDrive.Size = New System.Drawing.Size(104, 23)
        Me.btnUnlockDrive.TabIndex = 13
        Me.btnUnlockDrive.Text = "Unlock Drive"
        Me.btnUnlockDrive.UseVisualStyleBackColor = True
        '
        'VOBReader_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 372)
        Me.Controls.Add(Me.btnUnlockDrive)
        Me.Controls.Add(Me.btnTestB)
        Me.Controls.Add(Me.btnExtractOneSector)
        Me.Controls.Add(Me.btnExtract_1thread)
        Me.Controls.Add(Me.pbMain)
        Me.Controls.Add(Me.btnExtract_Mthread)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSector)
        Me.Controls.Add(Me.txtDump)
        Me.Controls.Add(Me.btnTestA)
        Me.Name = "VOBReader_Main"
        Me.Text = " VOB Reader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTestA As System.Windows.Forms.Button
    Friend WithEvents txtDump As System.Windows.Forms.TextBox
    Friend WithEvents txtSector As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnExtract_Mthread As System.Windows.Forms.Button
    Friend WithEvents pbMain As System.Windows.Forms.ProgressBar
    Friend WithEvents btnExtract_1thread As System.Windows.Forms.Button
    Friend WithEvents btnExtractOneSector As System.Windows.Forms.Button
    Friend WithEvents btnTestB As System.Windows.Forms.Button
    Friend WithEvents btnUnlockDrive As System.Windows.Forms.Button

End Class
