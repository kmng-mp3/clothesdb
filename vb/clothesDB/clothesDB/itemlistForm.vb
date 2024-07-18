Public Class itemlistForm
    Function escape_string(src As String) As String
        Dim s As String = src

        s = s.Replace("[", "[[]")
        s = s.Replace("%", "[%]")
        s = s.Replace("_", "[_]")
        Return s
    End Function

    Private Sub itemlistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_category_main' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_category_mainTableAdapter.Fill(Me.ClothesDBDataSet.tbl_category_main)
        'TODO: このコード行はデータを 'ClothesDBDataSet.clothesdb_listview' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Clothesdb_listviewTableAdapter.Fill(Me.ClothesDBDataSet.clothesdb_listview)
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_itemTableAdapter.Fill(Me.ClothesDBDataSet.tbl_item)
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_itemTableAdapter.Fill(Me.ClothesDBDataSet.tbl_item)
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_itemTableAdapter.Fill(Me.ClothesDBDataSet.tbl_item)

        Using connection As New SqlClient.SqlConnection(My.Settings.clothesDBConnectionString)
            ' データコマンドを作成
            Using command As SqlClient.SqlCommand = connection.CreateCommand()
                ' コネクションを開く
                connection.Open()

                ' SQLクエリの定義
                command.CommandText = "SELECT category_main FROM tbl_category_main ORDER BY main_category_id"

                ' データリーダーを使用してデータを読み取る
                Using dr As SqlClient.SqlDataReader = command.ExecuteReader()
                    ' コンボボックスをクリア
                    Category_mainComboBox.Items.Clear()

                    ' 各コンボボックスの設定
                    ' 先頭に（すべて）を追加
                    Category_mainComboBox.Items.Add("（すべて）")

                    ' データをコンボボックスに追加
                    While dr.Read()
                        Category_mainComboBox.Items.Add(dr("category_main").ToString())
                    End While

                    ' コンボボックスの規定の設定
                    Category_mainComboBox.SelectedIndex = 0
                End Using
            End Using
        End Using

    End Sub


    Private Sub backmainmenuButton_Click(sender As Object, e As EventArgs) Handles backmainmenuButton.Click
        mainmenuForm.Show()
        Me.Close()
    End Sub

    Private Sub itemeditButton_Click(sender As Object, e As EventArgs) Handles itemeditButton.Click
        itemeditForm.Show()
        Me.Close()
    End Sub



    Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click

        ' コネクションを指定
        Using connection As New SqlClient.SqlConnection(My.Settings.clothesDBConnectionString)
            ' データコマンドを作成
            Using command As SqlClient.SqlCommand = connection.CreateCommand()

                ' コネクションを開く
                connection.Open()

                ' SQLクエリの定義
                Dim sql As String = "SELECT * FROM clothesdb_listview WHERE 1=1"

                ' item_nameの条件を追加
                If Not String.IsNullOrEmpty(ItemNameTextBox.Text) Then
                    sql &= " AND item_name LIKE '%" & escape_string(ItemNameTextBox.Text) & "%'"
                End If

                ' brand_mainの条件を追加
                If Not String.IsNullOrEmpty(BrandMainTextBox.Text) Then
                    sql &= " AND brand_main LIKE '%" & escape_string(BrandMainTextBox.Text) & "%'"
                End If

                ' category_mainの条件を追加、コンボボックスで選択
                If Category_mainComboBox.Text <> "（すべて）" AndAlso Not String.IsNullOrEmpty(Category_mainComboBox.Text) Then
                    sql &= " AND category_main = @categorymain"
                    command.Parameters.Add("@categorymain", SqlDbType.VarChar).Value = Category_mainComboBox.Text
                End If

                ' release_yearの条件を追加
                If Not String.IsNullOrEmpty(ReleaseYearStartTextBox.Text) AndAlso Not String.IsNullOrEmpty(ReleaseYearEndTextBox.Text) Then
                    sql &= " AND release_year BETWEEN @releaseyear1 AND @releaseyear2"
                    command.Parameters.Add("@releaseyear1", SqlDbType.Int).Value = Convert.ToInt32(ReleaseYearStartTextBox.Text)
                    command.Parameters.Add("@releaseyear2", SqlDbType.Int).Value = Convert.ToInt32(ReleaseYearEndTextBox.Text)
                End If

                ' quantityの条件を追加 完全一致だけどBETWEENで範囲指定にすることも検討して良いと思う
                If Not String.IsNullOrEmpty(QuantityTextBox.Text) Then
                    sql &= " AND quantity = @quantity"
                    command.Parameters.Add("@quantity", SqlDbType.Int).Value = Convert.ToInt32(QuantityTextBox.Text)
                End If

                ' purchase_priceの条件を追加
                If Not String.IsNullOrEmpty(PriceMinTextBox.Text) AndAlso Not String.IsNullOrEmpty(PriceMaxTextBox.Text) Then
                    sql &= " AND purchase_price BETWEEN @pricemin AND @pricemax"
                    command.Parameters.Add("@pricemin", SqlDbType.Int).Value = Convert.ToInt32(PriceMinTextBox.Text)
                    command.Parameters.Add("@pricemax", SqlDbType.Int).Value = Convert.ToInt32(PriceMaxTextBox.Text)
                End If

                ' purchase_dateの条件を追加
                If Not String.IsNullOrEmpty(PurchaseDatePastTextBox.Text) AndAlso Not String.IsNullOrEmpty(PurchaseDateThenTextBox.Text) Then
                    Dim pastDate As DateTime
                    Dim thenDate As DateTime
                    If DateTime.TryParseExact(PurchaseDatePastTextBox.Text, "yyyy/MM/dd", Nothing, Globalization.DateTimeStyles.None, pastDate) AndAlso DateTime.TryParseExact(PurchaseDateThenTextBox.Text, "yyyy/MM/dd", Nothing, Globalization.DateTimeStyles.None, thenDate) Then
                        sql &= " AND purchase_date BETWEEN @pastdate AND @thendate"
                        command.Parameters.Add("@pastdate", SqlDbType.Date).Value = pastDate
                        command.Parameters.Add("@thendate", SqlDbType.Date).Value = thenDate
                    Else
                        ' 日付形式が正しくない場合はエラーメッセージを表示
                        MessageBox.Show("日付形式が正しくありません。YYYY/MM/DD形式で入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End If

                command.CommandText = sql

                Using dr As SqlClient.SqlDataReader = command.ExecuteReader()
                    ' DataTableの作成
                    Dim dt As New DataTable()
                    dt.Load(dr)

                    ' DataGridViewのデータソースを設定
                    Clothesdb_listviewDataGridView.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

End Class