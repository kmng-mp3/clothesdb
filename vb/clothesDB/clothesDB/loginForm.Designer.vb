<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.useridTextBox = New System.Windows.Forms.TextBox()
        Me.passwordTextBox = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PW:"
        '
        'useridTextBox
        '
        Me.useridTextBox.Location = New System.Drawing.Point(60, 51)
        Me.useridTextBox.MaxLength = 15
        Me.useridTextBox.Name = "useridTextBox"
        Me.useridTextBox.Size = New System.Drawing.Size(276, 25)
        Me.useridTextBox.TabIndex = 1
        '
        'passwordTextBox
        '
        Me.passwordTextBox.Location = New System.Drawing.Point(60, 98)
        Me.passwordTextBox.MaxLength = 60
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextBox.Size = New System.Drawing.Size(276, 25)
        Me.passwordTextBox.TabIndex = 2
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(355, 50)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(110, 30)
        Me.loginButton.TabIndex = 3
        Me.loginButton.Text = "ログイン"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(355, 96)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(110, 30)
        Me.closeButton.TabIndex = 4
        Me.closeButton.TabStop = False
        Me.closeButton.Text = "キャンセル"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 14)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "clothesDB ログイン画面"
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 147)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.useridTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "loginForm"
        Me.Text = "ログイン画面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents useridTextBox As TextBox
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents loginButton As Button
    Friend WithEvents closeButton As Button
    Friend WithEvents Label3 As Label
End Class
