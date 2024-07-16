Public Class mainmenuForm
    ' ログアウトボタンクリック時の動作
    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click

        If MsgBox("ログアウトしてログイン画面に戻りますか？", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) = MsgBoxResult.Yes Then
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    ' アイテムリストボタンクリック時の動作
    Private Sub itemlistviewButton_Click(sender As Object, e As EventArgs) Handles itemlistviewButton.Click
        itemlistForm.Show()
        Me.Close()
    End Sub

    Private Sub itemeditButton_Click(sender As Object, e As EventArgs) Handles itemeditButton.Click
        itemeditForm.Show()
        Me.Close()
    End Sub
End Class