<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.rtbDump = New System.Windows.Forms.RichTextBox
        Me.btnStop = New System.Windows.Forms.Button
        Me.btnStart = New System.Windows.Forms.Button
        Me.txtBytesToCount = New System.Windows.Forms.TextBox
        Me.lblByteCount = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(449, 10)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(12, 12)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(431, 20)
        Me.txtPath.TabIndex = 1
        Me.txtPath.Text = "F:\MEDIA\SD\VTS_04_1_unfaithful_macrovision_NEW_NEW.m2v"
        '
        'rtbDump
        '
        Me.rtbDump.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbDump.Location = New System.Drawing.Point(12, 38)
        Me.rtbDump.Name = "rtbDump"
        Me.rtbDump.Size = New System.Drawing.Size(1304, 474)
        Me.rtbDump.TabIndex = 2
        Me.rtbDump.Text = ""
        Me.rtbDump.WordWrap = False
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(600, 10)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(65, 23)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(530, 10)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(65, 23)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'txtBytesToCount
        '
        Me.txtBytesToCount.Location = New System.Drawing.Point(12, 523)
        Me.txtBytesToCount.Name = "txtBytesToCount"
        Me.txtBytesToCount.Size = New System.Drawing.Size(264, 20)
        Me.txtBytesToCount.TabIndex = 5
        '
        'lblByteCount
        '
        Me.lblByteCount.AutoSize = True
        Me.lblByteCount.Location = New System.Drawing.Point(282, 526)
        Me.lblByteCount.Name = "lblByteCount"
        Me.lblByteCount.Size = New System.Drawing.Size(13, 13)
        Me.lblByteCount.TabIndex = 6
        Me.lblByteCount.Text = "[]"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 555)
        Me.Controls.Add(Me.lblByteCount)
        Me.Controls.Add(Me.txtBytesToCount)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.rtbDump)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnBrowse)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents rtbDump As System.Windows.Forms.RichTextBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txtBytesToCount As System.Windows.Forms.TextBox
    Friend WithEvents lblByteCount As System.Windows.Forms.Label

End Class
