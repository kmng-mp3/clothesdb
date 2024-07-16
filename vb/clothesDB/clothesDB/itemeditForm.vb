Public Class itemeditForm
    Private Sub Tbl_itemBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_itemBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_itemBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClothesDBDataSet)

    End Sub

    Private Sub itemeditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_category_sub' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_category_subTableAdapter.Fill(Me.ClothesDBDataSet.tbl_category_sub)
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_category_main' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_category_mainTableAdapter.Fill(Me.ClothesDBDataSet.tbl_category_main)
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_brand' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_brandTableAdapter.Fill(Me.ClothesDBDataSet.tbl_brand)
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_itemTableAdapter.Fill(Me.ClothesDBDataSet.tbl_item)

    End Sub
    Private Sub mainmenuButton_Click(sender As Object, e As EventArgs) Handles mainmenuButton.Click
        mainmenuForm.Show()
        Me.Close()
    End Sub

    Private Sub itemlistButton_Click(sender As Object, e As EventArgs) Handles itemlistButton.Click
        itemlistForm.Show()
        Me.Close()
    End Sub
End Class