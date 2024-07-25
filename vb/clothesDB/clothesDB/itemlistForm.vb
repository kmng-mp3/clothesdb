Public Class itemlistForm

    Function escape_string(src As String) As String
        Dim s As String = src

        s = s.Replace("[", "[[]")
        s = s.Replace("%", "[%]")
        s = s.Replace("_", "[_]")
        Return s
    End Function

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        InitializeCategoryMainComboBox()
    End Sub

    Private Sub InitializeCategoryMainComboBox()
        Using connection As New SqlClient.SqlConnection(My.Settings.clothesDBConnectionString)
            ' データコマンドを作成
            Using command As SqlClient.SqlCommand = connection.CreateCommand()
                ' コネクションを開く
                connection.Open()

                ' SQLクエリの定義
                command.CommandText = "SELECT category_main FROM tbl_category_main ORDER BY main_category_id"

                ' データリーダーを使用してデータを読み取る
                Using dr As SqlClient.SqlDataReader = command.ExecuteReader()

                    ' 先頭に（すべて）を追加
                    Category_mainComboBox.Items.Add("（すべて）")

                    ' データをコンボボックスに追加
                    While dr.Read()
                        Category_mainComboBox.Items.Add(dr("category_main").ToString())
                    End While

                    connection.Close()
                End Using
            End Using
        End Using
    End Sub

    Private Sub Category_mainComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Category_mainComboBox.SelectedIndexChanged
        If Category_mainComboBox.SelectedItem Is Nothing OrElse Category_mainComboBox.SelectedItem.ToString() = "（すべて）" Then
            ' '（すべて）'が選択された場合、小カテゴリを無効化
            Category_subComboBox.Enabled = False
            Category_subComboBox.Items.Clear()
        Else
            ' 小カテゴリを有効化
            Category_subComboBox.Enabled = True
            UpdateCategorySubComboBox(Category_mainComboBox.SelectedItem.ToString())
        End If
    End Sub

    Private Sub UpdateCategorySubComboBox(category_main As String)
        ' Category_subComboBoxをクリア
        Category_subComboBox.Items.Clear()
        Category_subComboBox.Items.Add("（すべて）") ' '（すべて）'オプションを追加

        ' category_mainに対応するcategory_subのリストを取得してCategory_subComboBoxに追加
        Using connection As New SqlClient.SqlConnection(My.Settings.clothesDBConnectionString)
            Dim command As New SqlClient.SqlCommand("SELECT category_sub FROM tbl_category_sub WHERE main_category_id = (SELECT main_category_id FROM tbl_category_main WHERE category_main = @category_main) ORDER BY sub_category_id", connection)
            command.Parameters.Add("@category_main", SqlDbType.VarChar).Value = category_main
            connection.Open()
            Dim reader As SqlClient.SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Category_subComboBox.Items.Add(reader("category_sub").ToString())
            End While
            connection.Close()

            ' コンボボックスの規定の設定
            Category_subComboBox.SelectedIndex = 0
        End Using
    End Sub


    Private Sub itemlistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_category_sub' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_category_subTableAdapter.Fill(Me.ClothesDBDataSet.tbl_category_sub)
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

        ' コンボボックスの規定の設定
        Category_mainComboBox.SelectedIndex = 0

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

        ' CheckEditData関数を呼び出し、エラーメッセージを取得
        Dim errorMessage As String = CheckEditData()

        ' エラーメッセージがある場合はメッセージボックスを表示し、処理を中断
        If Not String.IsNullOrEmpty(errorMessage) Then
            MessageBox.Show(errorMessage, "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

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

                ' category_mainの条件を追加
                If Category_mainComboBox.Text <> "（すべて）" AndAlso Not String.IsNullOrEmpty(Category_mainComboBox.Text) Then
                    sql &= " AND category_main = @categorymain"
                    command.Parameters.Add("@categorymain", SqlDbType.VarChar).Value = Category_mainComboBox.Text
                End If

                ' category_subの条件を追加
                If Category_subComboBox.Text <> "（すべて）" AndAlso Not String.IsNullOrEmpty(Category_subComboBox.Text) Then
                    sql &= " AND category_sub = @categorysub"
                    command.Parameters.Add("@categorysub", SqlDbType.VarChar).Value = Category_subComboBox.Text
                End If

                ' release_yearの条件を追加
                If Not String.IsNullOrEmpty(ReleaseYearStartTextBox.Text) AndAlso Not String.IsNullOrEmpty(ReleaseYearEndTextBox.Text) Then
                    sql &= " AND release_year BETWEEN @releaseyear1 AND @releaseyear2"
                    command.Parameters.Add("@releaseyear1", SqlDbType.Int).Value = Convert.ToInt32(ReleaseYearStartTextBox.Text)
                        command.Parameters.Add("@releaseyear2", SqlDbType.Int).Value = Convert.ToInt32(ReleaseYearEndTextBox.Text)
                    End If

                ' quantityの条件を追加 完全一致だけどBETWEENで範囲指定にすることも検討して良いと思う
                If Not String.IsNullOrEmpty(QuantityTextBox.Text) AndAlso IsValidInteger(QuantityTextBox.Text) Then
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
                    sql &= " AND purchase_date BETWEEN @pastdate AND @thendate"
                    command.Parameters.Add("@pastdate", SqlDbType.Date).Value = Convert.ToDateTime(PurchaseDatePastTextBox.Text)
                    command.Parameters.Add("@thendate", SqlDbType.Date).Value = Convert.ToDateTime(PurchaseDateThenTextBox.Text)
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

    ' エラーチェック
    Private Function CheckEditData() As String
        Dim errorMessage As String = String.Empty

        ' リリース年のチェック
        If Not String.IsNullOrEmpty(ReleaseYearStartTextBox.Text) AndAlso Not IsValidYearDigitInteger(ReleaseYearStartTextBox.Text) Then
            errorMessage &= "リリース年は4桁の整数で入力してください。" & vbCrLf
        End If
        If Not String.IsNullOrEmpty(ReleaseYearEndTextBox.Text) AndAlso Not IsValidYearDigitInteger(ReleaseYearEndTextBox.Text) Then
            errorMessage &= "リリース年は4桁の整数で入力してください。" & vbCrLf
        End If

        ' 所持数のチェック
        If Not String.IsNullOrEmpty(QuantityTextBox.Text) AndAlso Not IsValidInteger(QuantityTextBox.Text) Then
            errorMessage &= "個数は整数で入力してください。" & vbCrLf
        End If

        ' 金額のチェック
        If Not String.IsNullOrEmpty(PriceMinTextBox.Text) AndAlso Not IsValidInteger(PriceMinTextBox.Text) Then
            errorMessage &= "金額は整数で入力してください。" & vbCrLf
        End If
        If Not String.IsNullOrEmpty(PriceMaxTextBox.Text) AndAlso Not IsValidInteger(PriceMaxTextBox.Text) Then
            errorMessage &= "金額は整数で入力してください。" & vbCrLf
        End If

        ' PurchaseDatePastTextBoxのチェック
        If Not String.IsNullOrEmpty(PurchaseDatePastTextBox.Text) AndAlso Not IsValidDate(PurchaseDatePastTextBox.Text) Then
            errorMessage &= "購入日はYYYY/MM/DD形式の日付を入力してください。" & vbCrLf
        End If

        ' PurchaseDateThenTextBoxのチェック
        If Not String.IsNullOrEmpty(PurchaseDateThenTextBox.Text) AndAlso Not IsValidDate(PurchaseDateThenTextBox.Text) Then
            errorMessage &= "購入日はYYYY/MM/DD形式の日付を入力してください。" & vbCrLf
        End If

        Return errorMessage
    End Function

    ' 年のエラーチェック機能
    Private Function IsValidYearDigitInteger(value As String) As Boolean
        Dim tempInt As Integer
        Return Integer.TryParse(value, tempInt) AndAlso value.Length = 4
    End Function

    ' 整数のエラーチェック機能
    Private Function IsValidInteger(value As String) As Boolean
        Dim tempInt As Integer
        Return Integer.TryParse(value, tempInt)
    End Function

    ' 日付のエラーチェック機能
    Private Function IsValidDate(dateStr As String) As Boolean
        Dim tempDate As DateTime
        Return DateTime.TryParseExact(dateStr, "yyyy/MM/dd", Nothing, Globalization.DateTimeStyles.None, tempDate)
    End Function

End Class