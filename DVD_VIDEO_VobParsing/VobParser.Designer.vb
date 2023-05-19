<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VobParser
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
        Me.btnGetFS = New System.Windows.Forms.Button
        Me.txtOffset = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'btnParse
        '
        Me.btnParse.Location = New System.Drawing.Point(12, 12)
        Me.btnParse.Name = "btnParse"
        Me.btnParse.Size = New System.Drawing.Size(75, 23)
        Me.btnParse.TabIndex = 0
        Me.btnParse.Text = "Parse"
        Me.btnParse.UseVisualStyleBackColor = True
        '
        'btnGetFS
        '
        Me.btnGetFS.Location = New System.Drawing.Point(118, 44)
        Me.btnGetFS.Name = "btnGetFS"
        Me.btnGetFS.Size = New System.Drawing.Size(75, 23)
        Me.btnGetFS.TabIndex = 1
        Me.btnGetFS.Text = "Get FS"
        Me.btnGetFS.UseVisualStyleBackColor = True
        '
        'txtOffset
        '
        Me.txtOffset.Location = New System.Drawing.Point(12, 46)
        Me.txtOffset.Name = "txtOffset"
        Me.txtOffset.Size = New System.Drawing.Size(100, 20)
        Me.txtOffset.TabIndex = 2
        Me.txtOffset.Text = "0"
        '
        'VobParser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.txtOffset)
        Me.Controls.Add(Me.btnGetFS)
        Me.Controls.Add(Me.btnParse)
        Me.Name = "VobParser"
        Me.Text = "VOB Parser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnParse As System.Windows.Forms.Button
    Friend WithEvents btnGetFS As System.Windows.Forms.Button
    Friend WithEvents txtOffset As System.Windows.Forms.TextBox

End Class
