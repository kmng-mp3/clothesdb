Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class itemAddNewForm

    Private skipConfirm As Boolean = False
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' 新規行に移動
        Tbl_itemBindingSource.AddNew()

        ' アイテム名にフォーカス
        Item_nameTextBox.Select()

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
        If Category_mainComboBox.SelectedItem Is Nothing Then
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

    Private Sub itemAddNewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_category_sub' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        '   Me.Tbl_category_subTableAdapter.Fill(Me.ClothesDBDataSet.tbl_category_sub)
        '   'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_category_main' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_category_mainTableAdapter.Fill(Me.ClothesDBDataSet.tbl_category_main)
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_brand' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.Tbl_brandTableAdapter.Fill(Me.ClothesDBDataSet.tbl_brand)
        'TODO: このコード行はデータを 'ClothesDBDataSet.tbl_item' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        '   Me.Tbl_itemTableAdapter.Fill(Me.ClothesDBDataSet.tbl_item)
    End Sub

    ' ストリップメニューの動作
    Private Sub MoveFirstMenuItem_Click(sender As Object, e As EventArgs) Handles MoveFirstMenuItem.Click
        BindingNavigatorMoveFirstItem.PerformClick()
    End Sub

    Private Sub MovePrevMenuItem_Click(sender As Object, e As EventArgs) Handles MovePrevMenuItem.Click
        BindingNavigatorMovePreviousItem.PerformClick()
    End Sub

    Private Sub MoveNextMenuItem_Click(sender As Object, e As EventArgs) Handles MoveNextMenuItem.Click
        BindingNavigatorMoveNextItem.PerformClick()
    End Sub

    Private Sub MoveLastMenuItem_Click(sender As Object, e As EventArgs) Handles MoveLastMenuItem.Click
        BindingNavigatorMoveLastItem.PerformClick()
    End Sub

    Private Sub NewMenuItem_Click(sender As Object, e As EventArgs) Handles NewMenuItem.Click
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub DeleteMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteMenuItem.Click
        BindingNavigatorDeleteItem.PerformClick()
    End Sub

    Private Sub SaveMenuItem_Click(sender As Object, e As EventArgs) Handles SaveMenuItem.Click
        BindingNavigatorAddNewItem.PerformClick()
    End Sub

    Private Sub BackMenuItem_Click(sender As Object, e As EventArgs) Handles BackMenuItem.Click
        mainmenuForm.Show()
        Me.Close()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        ' 最初に移動ボタンの処理
        If Not CheckEditData() Then Return

        Tbl_itemBindingSource.MoveFirst()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        ' 前に移動ボタンの処理
        If Not CheckEditData() Then Return

        Tbl_itemBindingSource.MovePrevious()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        ' 次に移動ボタンの処理
        If Not CheckEditData() Then Return

        Tbl_itemBindingSource.MoveNext()
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        ' 最後に移動ボタンの処理
        If Not CheckEditData() Then Return

        Tbl_itemBindingSource.MoveLast()
    End Sub

    ' mainmenuButtonのクリックイベント
    Private Sub mainmenuButton_Click(sender As Object, e As EventArgs) Handles mainmenuButton.Click
        If ConfirmClose() Then
            ' フラグを設定してフォームを閉じる
            skipConfirm = True
            mainmenuForm.Show()
            Me.Close()
        End If
    End Sub

    ' itemlistButtonのクリックイベント
    Private Sub itemlistButton_Click(sender As Object, e As EventArgs) Handles itemlistButton.Click
        If ConfirmClose() Then
            ' フラグを設定してフォームを閉じる
            skipConfirm = True
            itemlistForm.Show()
            Me.Close()
        End If
    End Sub

    Private Function CheckEditData() As Boolean
        ' カレント行が存在しない場合には何もせず戻る
        If Tbl_itemBindingSource.Current Is Nothing Then Return True

        ' ここからデータ検査
        ' アイテム名
        With Item_nameTextBox
            If .Text = "" Then
                MsgBox("アイテム名は必ず入力してください")
                .Select()
                Return False
            End If

            If Not CheckMaxLengthUnicode("item_name", .Text) Then
                MsgBox("アイテム名は100文字以内で入力してください")
                .Select()
                Return False
            End If
        End With

        ' ブランド名
        With Brand_idComboBox
            If .Text = "" Then
                MsgBox("ブランド名は必ず選択してください")
                .Select()
                Return False
            End If
        End With

        ' 大カテゴリ
        With Category_mainComboBox
            If .Text = "" Then
                MsgBox("大カテゴリは必ず選択してください")
                .Select()
                Return False
            End If
        End With

        ' 小カテゴリ
        With Category_subComboBox
            If .Text = "" Then
                MsgBox("小カテゴリは必ず選択してください")
                .Select()
                Return False
            End If
        End With

        ' リリース年
        With Release_yearTextBox
            If Not System.Text.RegularExpressions.Regex.IsMatch(.Text, "^\d{4}$") Then
                MsgBox("リリース年は4桁の整数を入力してください")
                .Select()
                Return False
            End If
        End With

        ' 所持数
        With QuantityTextBox
            If .Text = "" Then
                MsgBox("所持数を入力してください" & vbCrLf & "持っていない場合は 0 と入力してください")
                .Select()
                Return False
            End If
            Dim quantity As Integer
            If Not Integer.TryParse(.Text, quantity) Then
                MsgBox("所持数は整数を入力してください")
                .Select()
                Return False
            End If
        End With

        ' 購入時金額
        With Purchase_priceTextBox
            If .Text = "" Then
                MsgBox("購入時金額を入力してください" & vbCrLf & "無料で入手した場合は 0 と入力してください" & vbCrLf & "わからない場合は大体の値段、または 0 と入力することをお勧めします")
                .Select()
                Return False
            End If
            If Not System.Text.RegularExpressions.Regex.IsMatch(.Text, "^\d{1,10}$") Then
                MsgBox("購入時金額は、10桁までの整数を入力してください（日本円を前提としています）")
                .Select()
                Return False
            End If
        End With

        Try
            ' 編集中の場合があるため、変更内容を保存する
            Tbl_itemBindingSource.EndEdit()
        Catch ex As Exception
            ' エラーが発生した場合
            MsgBox("データの保存が失敗しました" & vbCrLf & vbCrLf & ex.Message)
            Return False
        End Try

        ' 成功時
        Return True
    End Function

    ' サイズチェックUnicode版（指定された列のサイズと文字列の比較）
    Private Function CheckMaxLengthUnicode(fieldname As String, value As String) As Boolean
        ' データセットから列の情報を読み取る
        Dim column As DataColumn = ClothesDBDataSet.tbl_item.Columns(fieldname)
        ' 文字列を取得する
        Dim length As Integer = value.Length

        ' 指定された文字列を超えたときエラーを返す
        If length > column.MaxLength Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        ' データの検査と編集中のデータの登録（エラーのときには処理を終了）
        If Not CheckEditData() Then Return

        ' 新規行に移動
        Tbl_itemBindingSource.AddNew()

        ' アイテム名にフォーカス
        Item_nameTextBox.Select()
    End Sub

    Private Sub Tbl_itemBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_itemBindingNavigatorSaveItem.Click
        ' データの検査と編集中のデータの登録（エラーのときには処理を終了）
        If Not CheckEditData() Then Return

        ' データセットが更新されていない時には、処理を実行しません
        If Not ClothesDBDataSet.HasChanges() Then Return

        If MsgBox("これまでの修正内容をデータベースに保存しますか？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                ' データセットのtbl_itemを更新する
                Tbl_itemTableAdapter.Update(ClothesDBDataSet.tbl_item)

                MsgBox("データベースに登録しました")
            Catch ex As Exception
                ' 失敗した場合
                MsgBox("データの保存が失敗しました" & vbCrLf & vbCrLf & ex.Message)
            End Try
        End If
    End Sub

    Private Function ConfirmClose() As Boolean
        ' フォームを閉じて良いか確認メッセージを表示
        Dim result As DialogResult = MsgBox("保存処理を実行していない場合には、作業内容がクリアされてしまいます。" & vbCrLf & vbCrLf & "このままフォームを閉じてよろしいですか？", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2)

        ' ユーザーが はい を選択したらTrueを返す
        If result = DialogResult.Yes Then
            Return True
        End If

        ' いいえ はFalse
        Return False
    End Function

    ' フォームの閉じるイベント
    Private Sub itemeditForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' フラグが設定されている場合は確認をスキップ
        If Not skipConfirm Then
            e.Cancel = Not ConfirmClose()
        End If
    End Sub



End Class

