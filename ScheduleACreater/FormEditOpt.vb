Public Class FormEditOpt
    Public OldOpt As String

    Private Sub BCancelOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelOpt.Click
        TBEditOpt.Clear()
        Me.Visible = False
    End Sub

    Private Sub BApplyOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BApplyOpt.Click
        If TBEditOpt.Text.ToString() <> "" Then
            FormMain.EditOption(FormMain.LBTitles.SelectedItem, FormMain.LBCategories.SelectedItem, OldOpt, TBEditOpt.Text.ToString())
            BCancelOpt_Click(sender, e)
        Else
            MessageBox.Show("Please input an option.")
        End If
    End Sub
End Class