Public Class itemlistForm
    Private Sub Tbl_itemBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_itemBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClothesDBDataSet)

    End Sub

    Private Sub itemlistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_itemTableAdapter.Fill(Me.ClothesDBDataSet.tbl_item)
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_itemTableAdapter.Fill(Me.ClothesDBDataSet.tbl_item)
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_itemTableAdapter.Fill(Me.ClothesDBDataSet.tbl_item)

    End Sub

    Private Sub Tbl_itemBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_itemBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClothesDBDataSet)

    End Sub

    Private Sub Tbl_itemBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles Tbl_itemBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_itemBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClothesDBDataSet)

    End Sub

    Private Sub backmainmenuButton_Click(sender As Object, e As EventArgs) Handles backmainmenuButton.Click
        mainmenuForm.Show()
        Me.Close()
    End Sub

    Private Sub itemeditButton_Click(sender As Object, e As EventArgs) Handles itemeditButton.Click
        itemeditForm.Show()
        Me.Close()
    End Sub
End Class