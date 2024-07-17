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

            ' コネクションを開く
            connection.Open()

            ' データコマンドを定義
            Using command As New SqlClient.SqlCommand(sql, connection)

                ' データリーダー作成
                Dim dr As SqlClient.SqlDataReader = command.ExecuteReader()

                ' 該当するユーザーIDが存在するか確認
                If dr.Read() Then
                    ' ---------------------ここからBCrypt使用時のコード------------------------
                    'Dim storedHash As String = dr("password_hash").ToString()

                    'If BCrypt.Net.BCrypt.Verify(passwordTextBox.Text, storedHash) Then

                    ' ---------------------ここまでBCrypt使用時のコード------------------------

                    ' ------------------------ここから通常時のコード-----------------------------
                    ' PW確認
                    If RTrim(dr("password_hash")) = passwordTextBox.Text Then
                        ' ------------------------ここまで通常時のコード-----------------------------

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

                        MsgBox("ユーザーIDかPWに誤りがあります")
                    End If
                Else
                    ' ユーザーIDが存在しない時
                    MsgBox("ユーザーIDかPWに誤りがあります")
                End If

                ' データリーダーを閉じる
                dr.Close()

                ' コネクションを閉じる
                connection.Close()
            End Using
        End Using

    End Sub
End Class
