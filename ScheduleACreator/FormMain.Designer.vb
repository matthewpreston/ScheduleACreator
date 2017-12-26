<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.TBValue = New System.Windows.Forms.TextBox
        Me.LFileName = New System.Windows.Forms.Label
        Me.TBFile = New System.Windows.Forms.TextBox
        Me.BBrowse = New System.Windows.Forms.Button
        Me.BOpen = New System.Windows.Forms.Button
        Me.LTitles = New System.Windows.Forms.Label
        Me.WBPreview = New System.Windows.Forms.WebBrowser
        Me.SCAll = New System.Windows.Forms.SplitContainer
        Me.SCContents = New System.Windows.Forms.SplitContainer
        Me.SCTV = New System.Windows.Forms.SplitContainer
        Me.LBTitles = New System.Windows.Forms.ListBox
        Me.BCreate = New System.Windows.Forms.Button
        Me.BSaveOpts = New System.Windows.Forms.Button
        Me.BPreview = New System.Windows.Forms.Button
        Me.BRmvOpt = New System.Windows.Forms.Button
        Me.BEditOpt = New System.Windows.Forms.Button
        Me.BRmvCat = New System.Windows.Forms.Button
        Me.BAddOpt = New System.Windows.Forms.Button
        Me.BAddCat = New System.Windows.Forms.Button
        Me.CLBItems = New System.Windows.Forms.CheckedListBox
        Me.LBCategories = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LValue = New System.Windows.Forms.Label
        Me.SCAll.Panel1.SuspendLayout()
        Me.SCAll.Panel2.SuspendLayout()
        Me.SCAll.SuspendLayout()
        Me.SCContents.Panel1.SuspendLayout()
        Me.SCContents.Panel2.SuspendLayout()
        Me.SCContents.SuspendLayout()
        Me.SCTV.Panel1.SuspendLayout()
        Me.SCTV.Panel2.SuspendLayout()
        Me.SCTV.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBValue
        '
        Me.TBValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TBValue.Location = New System.Drawing.Point(0, 0)
        Me.TBValue.Multiline = True
        Me.TBValue.Name = "TBValue"
        Me.TBValue.Size = New System.Drawing.Size(432, 233)
        Me.TBValue.TabIndex = 1
        '
        'LFileName
        '
        Me.LFileName.AutoSize = True
        Me.LFileName.Location = New System.Drawing.Point(15, 9)
        Me.LFileName.Name = "LFileName"
        Me.LFileName.Size = New System.Drawing.Size(57, 13)
        Me.LFileName.TabIndex = 2
        Me.LFileName.Text = "File Name:"
        '
        'TBFile
        '
        Me.TBFile.Location = New System.Drawing.Point(78, 6)
        Me.TBFile.Name = "TBFile"
        Me.TBFile.Size = New System.Drawing.Size(235, 20)
        Me.TBFile.TabIndex = 3
        '
        'BBrowse
        '
        Me.BBrowse.Location = New System.Drawing.Point(400, 4)
        Me.BBrowse.Name = "BBrowse"
        Me.BBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BBrowse.TabIndex = 4
        Me.BBrowse.Text = "Browse"
        Me.BBrowse.UseVisualStyleBackColor = True
        '
        'BOpen
        '
        Me.BOpen.Location = New System.Drawing.Point(319, 4)
        Me.BOpen.Name = "BOpen"
        Me.BOpen.Size = New System.Drawing.Size(75, 23)
        Me.BOpen.TabIndex = 5
        Me.BOpen.Text = "Open"
        Me.BOpen.UseVisualStyleBackColor = True
        '
        'LTitles
        '
        Me.LTitles.AutoSize = True
        Me.LTitles.Location = New System.Drawing.Point(15, 29)
        Me.LTitles.Name = "LTitles"
        Me.LTitles.Size = New System.Drawing.Size(35, 13)
        Me.LTitles.TabIndex = 7
        Me.LTitles.Text = "Titles:"
        '
        'WBPreview
        '
        Me.WBPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WBPreview.Location = New System.Drawing.Point(0, 0)
        Me.WBPreview.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WBPreview.Name = "WBPreview"
        Me.WBPreview.Size = New System.Drawing.Size(467, 498)
        Me.WBPreview.TabIndex = 8
        '
        'SCAll
        '
        Me.SCAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SCAll.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SCAll.Location = New System.Drawing.Point(0, 49)
        Me.SCAll.Name = "SCAll"
        '
        'SCAll.Panel1
        '
        Me.SCAll.Panel1.Controls.Add(Me.SCContents)
        '
        'SCAll.Panel2
        '
        Me.SCAll.Panel2.Controls.Add(Me.WBPreview)
        Me.SCAll.Size = New System.Drawing.Size(1027, 502)
        Me.SCAll.SplitterDistance = 552
        Me.SCAll.TabIndex = 9
        '
        'SCContents
        '
        Me.SCContents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SCContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SCContents.Location = New System.Drawing.Point(0, 0)
        Me.SCContents.Name = "SCContents"
        Me.SCContents.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SCContents.Panel1
        '
        Me.SCContents.Panel1.Controls.Add(Me.SCTV)
        '
        'SCContents.Panel2
        '
        Me.SCContents.Panel2.Controls.Add(Me.BCreate)
        Me.SCContents.Panel2.Controls.Add(Me.BSaveOpts)
        Me.SCContents.Panel2.Controls.Add(Me.BPreview)
        Me.SCContents.Panel2.Controls.Add(Me.BRmvOpt)
        Me.SCContents.Panel2.Controls.Add(Me.BEditOpt)
        Me.SCContents.Panel2.Controls.Add(Me.BRmvCat)
        Me.SCContents.Panel2.Controls.Add(Me.BAddOpt)
        Me.SCContents.Panel2.Controls.Add(Me.BAddCat)
        Me.SCContents.Panel2.Controls.Add(Me.CLBItems)
        Me.SCContents.Panel2.Controls.Add(Me.LBCategories)
        Me.SCContents.Panel2.Controls.Add(Me.Label1)
        Me.SCContents.Size = New System.Drawing.Size(552, 502)
        Me.SCContents.SplitterDistance = 237
        Me.SCContents.TabIndex = 6
        '
        'SCTV
        '
        Me.SCTV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SCTV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SCTV.Location = New System.Drawing.Point(0, 0)
        Me.SCTV.Name = "SCTV"
        '
        'SCTV.Panel1
        '
        Me.SCTV.Panel1.Controls.Add(Me.LBTitles)
        '
        'SCTV.Panel2
        '
        Me.SCTV.Panel2.Controls.Add(Me.TBValue)
        Me.SCTV.Size = New System.Drawing.Size(552, 237)
        Me.SCTV.SplitterDistance = 112
        Me.SCTV.TabIndex = 0
        '
        'LBTitles
        '
        Me.LBTitles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBTitles.FormattingEnabled = True
        Me.LBTitles.Location = New System.Drawing.Point(0, 0)
        Me.LBTitles.Name = "LBTitles"
        Me.LBTitles.Size = New System.Drawing.Size(108, 225)
        Me.LBTitles.TabIndex = 7
        '
        'BCreate
        '
        Me.BCreate.Location = New System.Drawing.Point(450, 233)
        Me.BCreate.Name = "BCreate"
        Me.BCreate.Size = New System.Drawing.Size(95, 25)
        Me.BCreate.TabIndex = 12
        Me.BCreate.Text = "Create"
        Me.BCreate.UseVisualStyleBackColor = True
        '
        'BSaveOpts
        '
        Me.BSaveOpts.Location = New System.Drawing.Point(116, 233)
        Me.BSaveOpts.Name = "BSaveOpts"
        Me.BSaveOpts.Size = New System.Drawing.Size(95, 25)
        Me.BSaveOpts.TabIndex = 11
        Me.BSaveOpts.Text = "Save Options"
        Me.BSaveOpts.UseVisualStyleBackColor = True
        '
        'BPreview
        '
        Me.BPreview.Location = New System.Drawing.Point(450, 205)
        Me.BPreview.Name = "BPreview"
        Me.BPreview.Size = New System.Drawing.Size(95, 25)
        Me.BPreview.TabIndex = 10
        Me.BPreview.Text = "Preview"
        Me.BPreview.UseVisualStyleBackColor = True
        '
        'BRmvOpt
        '
        Me.BRmvOpt.Location = New System.Drawing.Point(317, 205)
        Me.BRmvOpt.Name = "BRmvOpt"
        Me.BRmvOpt.Size = New System.Drawing.Size(95, 25)
        Me.BRmvOpt.TabIndex = 9
        Me.BRmvOpt.Text = "Remove Option"
        Me.BRmvOpt.UseVisualStyleBackColor = True
        '
        'BEditOpt
        '
        Me.BEditOpt.Location = New System.Drawing.Point(217, 205)
        Me.BEditOpt.Name = "BEditOpt"
        Me.BEditOpt.Size = New System.Drawing.Size(95, 25)
        Me.BEditOpt.TabIndex = 8
        Me.BEditOpt.Text = "Edit Option"
        Me.BEditOpt.UseVisualStyleBackColor = True
        '
        'BRmvCat
        '
        Me.BRmvCat.Location = New System.Drawing.Point(5, 233)
        Me.BRmvCat.Name = "BRmvCat"
        Me.BRmvCat.Size = New System.Drawing.Size(103, 24)
        Me.BRmvCat.TabIndex = 7
        Me.BRmvCat.Text = "Remove Category"
        Me.BRmvCat.UseVisualStyleBackColor = True
        '
        'BAddOpt
        '
        Me.BAddOpt.Location = New System.Drawing.Point(116, 205)
        Me.BAddOpt.Name = "BAddOpt"
        Me.BAddOpt.Size = New System.Drawing.Size(95, 25)
        Me.BAddOpt.TabIndex = 5
        Me.BAddOpt.Text = "Add Option"
        Me.BAddOpt.UseVisualStyleBackColor = True
        '
        'BAddCat
        '
        Me.BAddCat.Location = New System.Drawing.Point(5, 207)
        Me.BAddCat.Name = "BAddCat"
        Me.BAddCat.Size = New System.Drawing.Size(103, 24)
        Me.BAddCat.TabIndex = 4
        Me.BAddCat.Text = "Add Category"
        Me.BAddCat.UseVisualStyleBackColor = True
        '
        'CLBItems
        '
        Me.CLBItems.CheckOnClick = True
        Me.CLBItems.FormattingEnabled = True
        Me.CLBItems.Location = New System.Drawing.Point(116, 16)
        Me.CLBItems.Name = "CLBItems"
        Me.CLBItems.Size = New System.Drawing.Size(429, 184)
        Me.CLBItems.TabIndex = 2
        '
        'LBCategories
        '
        Me.LBCategories.FormattingEnabled = True
        Me.LBCategories.Location = New System.Drawing.Point(-2, 16)
        Me.LBCategories.Name = "LBCategories"
        Me.LBCategories.Size = New System.Drawing.Size(110, 186)
        Me.LBCategories.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Categories:"
        '
        'LValue
        '
        Me.LValue.AutoSize = True
        Me.LValue.Location = New System.Drawing.Point(167, 29)
        Me.LValue.Name = "LValue"
        Me.LValue.Size = New System.Drawing.Size(37, 13)
        Me.LValue.TabIndex = 2
        Me.LValue.Text = "Value:"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 551)
        Me.Controls.Add(Me.SCAll)
        Me.Controls.Add(Me.LValue)
        Me.Controls.Add(Me.LTitles)
        Me.Controls.Add(Me.LFileName)
        Me.Controls.Add(Me.TBFile)
        Me.Controls.Add(Me.BOpen)
        Me.Controls.Add(Me.BBrowse)
        Me.Name = "FormMain"
        Me.Text = "Schedule A Creater"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SCAll.Panel1.ResumeLayout(False)
        Me.SCAll.Panel2.ResumeLayout(False)
        Me.SCAll.ResumeLayout(False)
        Me.SCContents.Panel1.ResumeLayout(False)
        Me.SCContents.Panel2.ResumeLayout(False)
        Me.SCContents.Panel2.PerformLayout()
        Me.SCContents.ResumeLayout(False)
        Me.SCTV.Panel1.ResumeLayout(False)
        Me.SCTV.Panel2.ResumeLayout(False)
        Me.SCTV.Panel2.PerformLayout()
        Me.SCTV.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBValue As System.Windows.Forms.TextBox
    Friend WithEvents LFileName As System.Windows.Forms.Label
    Friend WithEvents TBFile As System.Windows.Forms.TextBox
    Friend WithEvents BBrowse As System.Windows.Forms.Button
    Friend WithEvents BOpen As System.Windows.Forms.Button
    Friend WithEvents LTitles As System.Windows.Forms.Label
    Friend WithEvents WBPreview As System.Windows.Forms.WebBrowser
    Friend WithEvents SCAll As System.Windows.Forms.SplitContainer
    Friend WithEvents LBTitles As System.Windows.Forms.ListBox
    Friend WithEvents SCContents As System.Windows.Forms.SplitContainer
    Friend WithEvents SCTV As System.Windows.Forms.SplitContainer
    Friend WithEvents LValue As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBCategories As System.Windows.Forms.ListBox
    Friend WithEvents CLBItems As System.Windows.Forms.CheckedListBox
    Friend WithEvents BAddOpt As System.Windows.Forms.Button
    Friend WithEvents BAddCat As System.Windows.Forms.Button
    Friend WithEvents BPreview As System.Windows.Forms.Button
    Friend WithEvents BRmvOpt As System.Windows.Forms.Button
    Friend WithEvents BEditOpt As System.Windows.Forms.Button
    Friend WithEvents BRmvCat As System.Windows.Forms.Button
    Friend WithEvents BSaveOpts As System.Windows.Forms.Button
    Friend WithEvents BCreate As System.Windows.Forms.Button

End Class
