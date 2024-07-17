Imports BCrypt.Net
Public Class loginForm

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub


    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim sql As String

        ' コネクションを指定
        Using connection As New SqlClient.SqlConnection(
        My.Settings.clothesDBConnectionString)

            ' SQLステートメント指定
            sql = "SELECT password_hash, is_admin FROM tbl_user WHERE user_id='" & useridTextBox.Text.Replace("'", "''") & "'"

            ' 指定したSQLでデータコマンドを定義する
            Using command As New SqlClient.SqlCommand(sql, connection)

                ' コネクションを開く
                connection.Open()

                ' データリーダー作成
                Dim dr As SqlClient.SqlDataReader = command.ExecuteReader()

                ' 該当するユーザーIDが存在するか確認
                If dr.Read() Then

                    ' ------------- ここからBCrypt導入時のコード --------------
                    ' drから受け取った値を文字列に変換してstoredHashに代入
                    ' Dim storedHash As String = dr("password_hash").ToString() 
                    ' PW確認(BCrypt使用)
                    ' If BCrypt.Net.BCrypt.Verify(passwordTextBox.Text, storedHash) Then
                    ' ------------- ここまでBCrypt導入後のコード --------------

                    ' ------------- ここから通常のログインコード --------------
                    ' PW確認
                    If RTrim(dr("password_hash")) = passwordTextBox.Text Then
                        ' ------------- ここまで通常のログインコード --------------

                        ' -----------------PW認証成功時の処理 -----------------

                        ' Public変数に管理者フラグをセットする
                        If IsDBNull(dr("is_admin")) OrElse Not dr("is_admin") Then
                            AdminFlag = False
                        Else
                            AdminFlag = True
                        End If

                        ' メインメニューの表示とログインフォームの終了
                        Dim frm_mn As New mainmenuForm
                        frm_mn.Show()
                        Me.Close()
                    Else

                        '----------------- PW認証失敗時の処理 -----------------

                        MsgBox("PWに誤りがあります") ' 実装時は"ユーザーIDかPWに誤りがあります"に変更
                    End If
                Else
                    ' ユーザーIDが存在しない時
                    MsgBox("ユーザーIDに誤りがあります") ' 実装時は"ユーザーIDかPWに誤りがあります"に変更
                End If

                ' データリーダーを閉じる
                dr.Close()

                ' コネクションを閉じる
                connection.Close()
            End Using
        End Using
    End Sub
End Class
