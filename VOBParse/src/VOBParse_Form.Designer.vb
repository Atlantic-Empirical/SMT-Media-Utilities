<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VOBParse_Form
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
        Me.txtVOB = New System.Windows.Forms.TextBox
        Me.btnRun = New System.Windows.Forms.Button
        Me.txtPackInfo = New System.Windows.Forms.TextBox
        Me.lblPackCount = New System.Windows.Forms.Label
        Me.dgPacks = New System.Windows.Forms.DataGridView
        Me.lblPerf = New System.Windows.Forms.Label
        Me.llExtractSP0 = New System.Windows.Forms.LinkLabel
        CType(Me.dgPacks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(517, 10)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtVOB
        '
        Me.txtVOB.Location = New System.Drawing.Point(12, 12)
        Me.txtVOB.Name = "txtVOB"
        Me.txtVOB.Size = New System.Drawing.Size(503, 20)
        Me.txtVOB.TabIndex = 1
        Me.txtVOB.Text = "E:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS\VTS_01_0.VOB"
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(12, 38)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(580, 29)
        Me.btnRun.TabIndex = 0
        Me.btnRun.Text = "RUN"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'txtPackInfo
        '
        Me.txtPackInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPackInfo.Location = New System.Drawing.Point(203, 73)
        Me.txtPackInfo.Multiline = True
        Me.txtPackInfo.Name = "txtPackInfo"
        Me.txtPackInfo.ReadOnly = True
        Me.txtPackInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPackInfo.Size = New System.Drawing.Size(389, 294)
        Me.txtPackInfo.TabIndex = 4
        '
        'lblPackCount
        '
        Me.lblPackCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPackCount.AutoSize = True
        Me.lblPackCount.Location = New System.Drawing.Point(13, 354)
        Me.lblPackCount.Name = "lblPackCount"
        Me.lblPackCount.Size = New System.Drawing.Size(13, 13)
        Me.lblPackCount.TabIndex = 5
        Me.lblPackCount.Text = "[]"
        '
        'dgPacks
        '
        Me.dgPacks.AllowUserToAddRows = False
        Me.dgPacks.AllowUserToDeleteRows = False
        Me.dgPacks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgPacks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPacks.Location = New System.Drawing.Point(5, 73)
        Me.dgPacks.Name = "dgPacks"
        Me.dgPacks.ReadOnly = True
        Me.dgPacks.RowHeadersVisible = False
        Me.dgPacks.Size = New System.Drawing.Size(192, 278)
        Me.dgPacks.TabIndex = 6
        '
        'lblPerf
        '
        Me.lblPerf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPerf.AutoSize = True
        Me.lblPerf.Location = New System.Drawing.Point(165, 354)
        Me.lblPerf.Name = "lblPerf"
        Me.lblPerf.Size = New System.Drawing.Size(13, 13)
        Me.lblPerf.TabIndex = 7
        Me.lblPerf.Text = "[]"
        '
        'llExtractSP0
        '
        Me.llExtractSP0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.llExtractSP0.AutoSize = True
        Me.llExtractSP0.Location = New System.Drawing.Point(93, 354)
        Me.llExtractSP0.Name = "llExtractSP0"
        Me.llExtractSP0.Size = New System.Drawing.Size(66, 13)
        Me.llExtractSP0.TabIndex = 8
        Me.llExtractSP0.TabStop = True
        Me.llExtractSP0.Text = "Extract SP 0"
        '
        'VOBParse_Form
        '
        Me.AcceptButton = Me.btnRun
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 376)
        Me.Controls.Add(Me.llExtractSP0)
        Me.Controls.Add(Me.lblPerf)
        Me.Controls.Add(Me.dgPacks)
        Me.Controls.Add(Me.lblPackCount)
        Me.Controls.Add(Me.txtPackInfo)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.txtVOB)
        Me.Controls.Add(Me.btnBrowse)
        Me.Name = "VOBParse_Form"
        Me.Text = "SMT VOB Parse"
        CType(Me.dgPacks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtVOB As System.Windows.Forms.TextBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents txtPackInfo As System.Windows.Forms.TextBox
    Friend WithEvents lblPackCount As System.Windows.Forms.Label
    Friend WithEvents dgPacks As System.Windows.Forms.DataGridView
    Friend WithEvents lblPerf As System.Windows.Forms.Label
    Friend WithEvents llExtractSP0 As System.Windows.Forms.LinkLabel

End Class
