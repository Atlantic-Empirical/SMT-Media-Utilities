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
        Me.btnParse = New System.Windows.Forms.Button
        Me.txtCmd = New System.Windows.Forms.TextBox
        Me.txtOutput = New System.Windows.Forms.TextBox
        Me.btnDebug = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnParse
        '
        Me.btnParse.Location = New System.Drawing.Point(109, 38)
        Me.btnParse.Name = "btnParse"
        Me.btnParse.Size = New System.Drawing.Size(75, 23)
        Me.btnParse.TabIndex = 0
        Me.btnParse.Text = "Parse"
        Me.btnParse.UseVisualStyleBackColor = True
        '
        'txtCmd
        '
        Me.txtCmd.Location = New System.Drawing.Point(12, 12)
        Me.txtCmd.Name = "txtCmd"
        Me.txtCmd.Size = New System.Drawing.Size(172, 20)
        Me.txtCmd.TabIndex = 1
        Me.txtCmd.Text = "BF DF FF F4 8C 00 0D 04"
        Me.txtCmd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 67)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(475, 20)
        Me.txtOutput.TabIndex = 2
        '
        'btnDebug
        '
        Me.btnDebug.Location = New System.Drawing.Point(412, 9)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(75, 23)
        Me.btnDebug.TabIndex = 3
        Me.btnDebug.Text = "Debug"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 99)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtCmd)
        Me.Controls.Add(Me.btnParse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "DVD Cmd Parser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnParse As System.Windows.Forms.Button
    Friend WithEvents txtCmd As System.Windows.Forms.TextBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnDebug As System.Windows.Forms.Button

End Class
