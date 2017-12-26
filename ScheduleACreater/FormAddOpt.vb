Public Class FormAddOpt

    Private Sub BCancelOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelOpt.Click
        TBAddOpt.Clear()
        Me.Visible = False
    End Sub

    Private Sub BAddOpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAddOpt.Click
        If TBAddOpt.Text.ToString() <> "" Then
            FormMain.AddOption(FormMain.LBTitles.SelectedItem, FormMain.LBCategories.SelectedItem, TBAddOpt.Text.ToString())
            BCancelOpt_Click(sender, e)
        Else
            MessageBox.Show("Please input an option.")
        End If
    End Sub
End Class