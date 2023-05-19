Imports SMT.Common.Media.DataParsing.VOB
Imports System.Text

Public Class VOBParse_Form

    Private VOB As cVOB
    Private IsParsingVOB As Boolean = False

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            Dim ofd As New OpenFileDialog
            ofd.Filter = "VOB|*.vob"
            ofd.FilterIndex = 0
            ofd.InitialDirectory = "E:\MEDIA\SDDVD\TWO_TOWERS_NTSC_R1_D2\VIDEO_TS" '"E:\MEDIA\SDDVD\" 
            ofd.Multiselect = False
            ofd.Title = "Select VOB"
            If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtVOB.Text = ofd.FileName
            End If
        Catch ex As Exception
            MsgBox("Problem with Select VOB. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Try
            If Me.txtVOB.Text = "" Then
                MsgBox("Select a VOB")
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor
            IsParsingVOB = True

            Me.txtPackInfo.Text = ""

            Dim ticks1 As UInt64 = DateTime.Now.Ticks
            VOB = New cVOB(Me.txtVOB.Text)
            Dim ticks2 As UInt64 = DateTime.Now.Ticks
            Dim ts As New TimeSpan(ticks2 - ticks1)
            'Debug.WriteLine("processing duration: " & ts.Seconds)
            Me.lblPerf.Text = ts.Seconds

            Me.dgPacks.AutoGenerateColumns = False
            Me.dgPacks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.dgPacks.AllowUserToOrderColumns = False
            Me.dgPacks.AllowUserToResizeColumns = False
            Me.dgPacks.AllowUserToResizeRows = False

            Dim column As DataGridViewColumn = New DataGridViewTextBoxColumn
            column.DataPropertyName = "PackNumber"
            column.Name = "Pack"
            column.Width = 45
            Me.dgPacks.Columns.Add(column)

            column = New DataGridViewTextBoxColumn
            column.DataPropertyName = "Type"
            column.Name = "Type"
            column.Width = 65
            Me.dgPacks.Columns.Add(column)

            column = New DataGridViewTextBoxColumn
            column.DataPropertyName = "Offset"
            column.Name = "Offset"
            column.Width = 60
            Me.dgPacks.Columns.Add(column)

            Me.dgPacks.DataSource = VOB.Packs

            Me.lblPackCount.Text = VOB.Packs.Count

            IsParsingVOB = False
            Me.Cursor = Cursors.Default
            DisplayPackInfo(0)

        Catch ex As Exception
            MsgBox("Problem with Run(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgPacks_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPacks.SelectionChanged
        Try
            If IsParsingVOB Then Exit Sub
            DisplayPackInfo(Me.dgPacks.SelectedRows(0).Index)
        Catch ex As Exception
            MsgBox("Problem with selection changed. Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplayPackInfo(ByVal PackNum As UInt32)
        Try
            Me.txtPackInfo.Text = ""
            VOB.PopulatePackData(VOB.Packs(PackNum))
            Me.txtPackInfo.Text = VOB.Packs(PackNum).ToString
        Catch ex As Exception
            MsgBox("Problem with DisplayPackInfo(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub llExtractSP0_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llExtractSP0.LinkClicked
        Try
            Dim SE As New cSubpictureExtractor()
            Dim ExportedCount As Integer = SE.ExtractSubStream(Me.txtVOB.Text, 0, "C:\Temp\Subpictures\")
            MsgBox("Exported " & ExportedCount & " subpictures")
        Catch ex As Exception
            MsgBox("Problem with Extract SP0. Error: " & ex.Message)
        End Try
    End Sub

End Class

Public Class cDataGridNoActiveCellColumn
    Inherits DataGridTextBoxColumn
    Private SelectedRow As Integer
    'Fields
    'Constructors
    'Events
    'Methods
    Public Sub New()
        'Warning: Implementation not found
    End Sub
    Protected Overloads Overrides Sub Edit(ByVal source As CurrencyManager, ByVal rowNum As Integer, ByVal bounds As Rectangle, ByVal [readOnly] As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)
        'make sure selectedrow is valid
        If (SelectedRow > -1) And (SelectedRow < source.List.Count + 1) Then
            Me.DataGridTableStyle.DataGrid.UnSelect(SelectedRow)
        End If
        SelectedRow = rowNum
        Me.DataGridTableStyle.DataGrid.Select(SelectedRow)

    End Sub
End Class
