<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddOpt
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
        Me.LAddOpt = New System.Windows.Forms.Label
        Me.TBAddOpt = New System.Windows.Forms.TextBox
        Me.BAddOpt = New System.Windows.Forms.Button
        Me.BCancelOpt = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'LAddOpt
        '
        Me.LAddOpt.AutoSize = True
        Me.LAddOpt.Location = New System.Drawing.Point(12, 9)
        Me.LAddOpt.Name = "LAddOpt"
        Me.LAddOpt.Size = New System.Drawing.Size(63, 13)
        Me.LAddOpt.TabIndex = 2
        Me.LAddOpt.Text = "New Option"
        '
        'TBAddOpt
        '
        Me.TBAddOpt.Location = New System.Drawing.Point(15, 25)
        Me.TBAddOpt.Multiline = True
        Me.TBAddOpt.Name = "TBAddOpt"
        Me.TBAddOpt.Size = New System.Drawing.Size(457, 145)
        Me.TBAddOpt.TabIndex = 3
        '
        'BAddOpt
        '
        Me.BAddOpt.Location = New System.Drawing.Point(296, 176)
        Me.BAddOpt.Name = "BAddOpt"
        Me.BAddOpt.Size = New System.Drawing.Size(87, 23)
        Me.BAddOpt.TabIndex = 4
        Me.BAddOpt.Text = "Add"
        Me.BAddOpt.UseVisualStyleBackColor = True
        '
        'BCancelOpt
        '
        Me.BCancelOpt.Location = New System.Drawing.Point(389, 176)
        Me.BCancelOpt.Name = "BCancelOpt"
        Me.BCancelOpt.Size = New System.Drawing.Size(83, 23)
        Me.BCancelOpt.TabIndex = 5
        Me.BCancelOpt.Text = "Cancel"
        Me.BCancelOpt.UseVisualStyleBackColor = True
        '
        'FormAddOpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 211)
        Me.Controls.Add(Me.BCancelOpt)
        Me.Controls.Add(Me.BAddOpt)
        Me.Controls.Add(Me.TBAddOpt)
        Me.Controls.Add(Me.LAddOpt)
        Me.Name = "FormAddOpt"
        Me.Text = "Add Option"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LAddOpt As System.Windows.Forms.Label
    Friend WithEvents TBAddOpt As System.Windows.Forms.TextBox
    Friend WithEvents BAddOpt As System.Windows.Forms.Button
    Friend WithEvents BCancelOpt As System.Windows.Forms.Button
End Class
