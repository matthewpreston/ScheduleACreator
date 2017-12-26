<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddCat
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
        Me.BCancelCat = New System.Windows.Forms.Button
        Me.BAddCat = New System.Windows.Forms.Button
        Me.LTitle = New System.Windows.Forms.Label
        Me.LType = New System.Windows.Forms.Label
        Me.TBTitle = New System.Windows.Forms.TextBox
        Me.CBTypes = New System.Windows.Forms.ComboBox
        Me.CBEditables = New System.Windows.Forms.ComboBox
        Me.LEditable = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BCancelCat
        '
        Me.BCancelCat.Location = New System.Drawing.Point(389, 90)
        Me.BCancelCat.Name = "BCancelCat"
        Me.BCancelCat.Size = New System.Drawing.Size(83, 23)
        Me.BCancelCat.TabIndex = 9
        Me.BCancelCat.Text = "Cancel"
        Me.BCancelCat.UseVisualStyleBackColor = True
        '
        'BAddCat
        '
        Me.BAddCat.Location = New System.Drawing.Point(296, 90)
        Me.BAddCat.Name = "BAddCat"
        Me.BAddCat.Size = New System.Drawing.Size(87, 23)
        Me.BAddCat.TabIndex = 8
        Me.BAddCat.Text = "Add"
        Me.BAddCat.UseVisualStyleBackColor = True
        '
        'LTitle
        '
        Me.LTitle.AutoSize = True
        Me.LTitle.Location = New System.Drawing.Point(16, 13)
        Me.LTitle.Name = "LTitle"
        Me.LTitle.Size = New System.Drawing.Size(30, 13)
        Me.LTitle.TabIndex = 6
        Me.LTitle.Text = "Title:"
        '
        'LType
        '
        Me.LType.AutoSize = True
        Me.LType.Location = New System.Drawing.Point(12, 39)
        Me.LType.Name = "LType"
        Me.LType.Size = New System.Drawing.Size(34, 13)
        Me.LType.TabIndex = 10
        Me.LType.Text = "Type:"
        '
        'TBTitle
        '
        Me.TBTitle.Location = New System.Drawing.Point(48, 10)
        Me.TBTitle.Name = "TBTitle"
        Me.TBTitle.Size = New System.Drawing.Size(424, 20)
        Me.TBTitle.TabIndex = 11
        '
        'CBTypes
        '
        Me.CBTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTypes.FormattingEnabled = True
        Me.CBTypes.Items.AddRange(New Object() {"Multiple", "Single"})
        Me.CBTypes.Location = New System.Drawing.Point(48, 36)
        Me.CBTypes.Name = "CBTypes"
        Me.CBTypes.Size = New System.Drawing.Size(424, 21)
        Me.CBTypes.TabIndex = 12
        '
        'CBEditables
        '
        Me.CBEditables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEditables.FormattingEnabled = True
        Me.CBEditables.Items.AddRange(New Object() {"True", "False"})
        Me.CBEditables.Location = New System.Drawing.Point(48, 63)
        Me.CBEditables.Name = "CBEditables"
        Me.CBEditables.Size = New System.Drawing.Size(424, 21)
        Me.CBEditables.TabIndex = 20
        '
        'LEditable
        '
        Me.LEditable.AutoSize = True
        Me.LEditable.Location = New System.Drawing.Point(-2, 66)
        Me.LEditable.Name = "LEditable"
        Me.LEditable.Size = New System.Drawing.Size(48, 13)
        Me.LEditable.TabIndex = 19
        Me.LEditable.Text = "Editable:"
        '
        'FormAddCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 119)
        Me.Controls.Add(Me.CBEditables)
        Me.Controls.Add(Me.LEditable)
        Me.Controls.Add(Me.CBTypes)
        Me.Controls.Add(Me.TBTitle)
        Me.Controls.Add(Me.LType)
        Me.Controls.Add(Me.BCancelCat)
        Me.Controls.Add(Me.BAddCat)
        Me.Controls.Add(Me.LTitle)
        Me.Name = "FormAddCat"
        Me.Text = "Add Category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BCancelCat As System.Windows.Forms.Button
    Friend WithEvents BAddCat As System.Windows.Forms.Button
    Friend WithEvents LTitle As System.Windows.Forms.Label
    Friend WithEvents LType As System.Windows.Forms.Label
    Friend WithEvents TBTitle As System.Windows.Forms.TextBox
    Friend WithEvents CBTypes As System.Windows.Forms.ComboBox
    Friend WithEvents CBEditables As System.Windows.Forms.ComboBox
    Friend WithEvents LEditable As System.Windows.Forms.Label
End Class
