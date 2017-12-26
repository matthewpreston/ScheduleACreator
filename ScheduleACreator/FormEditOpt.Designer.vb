<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditOpt
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
        Me.BCancelOpt = New System.Windows.Forms.Button
        Me.BApplyOpt = New System.Windows.Forms.Button
        Me.TBEditOpt = New System.Windows.Forms.TextBox
        Me.LEditOpt = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BCancelOpt
        '
        Me.BCancelOpt.Location = New System.Drawing.Point(389, 177)
        Me.BCancelOpt.Name = "BCancelOpt"
        Me.BCancelOpt.Size = New System.Drawing.Size(83, 23)
        Me.BCancelOpt.TabIndex = 9
        Me.BCancelOpt.Text = "Cancel"
        Me.BCancelOpt.UseVisualStyleBackColor = True
        '
        'BApplyOpt
        '
        Me.BApplyOpt.Location = New System.Drawing.Point(296, 177)
        Me.BApplyOpt.Name = "BApplyOpt"
        Me.BApplyOpt.Size = New System.Drawing.Size(87, 23)
        Me.BApplyOpt.TabIndex = 8
        Me.BApplyOpt.Text = "Apply"
        Me.BApplyOpt.UseVisualStyleBackColor = True
        '
        'TBEditOpt
        '
        Me.TBEditOpt.Location = New System.Drawing.Point(15, 26)
        Me.TBEditOpt.Multiline = True
        Me.TBEditOpt.Name = "TBEditOpt"
        Me.TBEditOpt.Size = New System.Drawing.Size(457, 145)
        Me.TBEditOpt.TabIndex = 7
        '
        'LEditOpt
        '
        Me.LEditOpt.AutoSize = True
        Me.LEditOpt.Location = New System.Drawing.Point(12, 10)
        Me.LEditOpt.Name = "LEditOpt"
        Me.LEditOpt.Size = New System.Drawing.Size(59, 13)
        Me.LEditOpt.TabIndex = 6
        Me.LEditOpt.Text = "Edit Option"
        '
        'FormEditOpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 211)
        Me.Controls.Add(Me.BCancelOpt)
        Me.Controls.Add(Me.BApplyOpt)
        Me.Controls.Add(Me.TBEditOpt)
        Me.Controls.Add(Me.LEditOpt)
        Me.Name = "FormEditOpt"
        Me.Text = "Edit Option"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BCancelOpt As System.Windows.Forms.Button
    Friend WithEvents BApplyOpt As System.Windows.Forms.Button
    Friend WithEvents TBEditOpt As System.Windows.Forms.TextBox
    Friend WithEvents LEditOpt As System.Windows.Forms.Label
End Class
