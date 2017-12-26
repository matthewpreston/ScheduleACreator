Public Class FormAddCat
    Private Sub FormAddCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBTypes.SelectedIndex = 0
        CBEditables.SelectedIndex = 0
    End Sub

    Private Sub BCancelCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCancelCat.Click
        CBTypes.SelectedIndex = 0
        CBEditables.SelectedIndex = 0
        TBTitle.Clear()
        Me.Visible = False
    End Sub

    Private Sub BAddCat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BAddCat.Click
        If TBTitle.Text.ToString() <> "" Then
            FormMain.AddCategory(FormMain.LBTitles.SelectedItem, TBTitle.Text.ToString(), CBTypes.SelectedItem, CBEditables.SelectedItem)
            BCancelCat_Click(sender, e)
        Else
            MessageBox.Show("Please write a title for this category")
        End If
    End Sub
End Class