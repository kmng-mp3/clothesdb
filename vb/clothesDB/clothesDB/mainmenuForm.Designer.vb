<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainmenuForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.itemeditButton = New System.Windows.Forms.Button()
        Me.itemlistviewButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.userinfoButton = New System.Windows.Forms.Button()
        Me.brandeditButton = New System.Windows.Forms.Button()
        Me.ategoryeditButton = New System.Windows.Forms.Button()
        Me.logoutButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.itemAddNewButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "clothesDB メインメニュー画面"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.itemAddNewButton)
        Me.Panel1.Controls.Add(Me.itemeditButton)
        Me.Panel1.Controls.Add(Me.itemlistviewButton)
        Me.Panel1.Location = New System.Drawing.Point(20, 76)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 360)
        Me.Panel1.TabIndex = 1
        '
        'itemeditButton
        '
        Me.itemeditButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.itemeditButton.Location = New System.Drawing.Point(4, 121)
        Me.itemeditButton.Margin = New System.Windows.Forms.Padding(4)
        Me.itemeditButton.Name = "itemeditButton"
        Me.itemeditButton.Size = New System.Drawing.Size(259, 110)
        Me.itemeditButton.TabIndex = 4
        Me.itemeditButton.Text = "アイテム編集"
        Me.itemeditButton.UseVisualStyleBackColor = True
        '
        'itemlistviewButton
        '
        Me.itemlistviewButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.itemlistviewButton.Location = New System.Drawing.Point(4, 4)
        Me.itemlistviewButton.Margin = New System.Windows.Forms.Padding(4)
        Me.itemlistviewButton.Name = "itemlistviewButton"
        Me.itemlistviewButton.Size = New System.Drawing.Size(259, 110)
        Me.itemlistviewButton.TabIndex = 3
        Me.itemlistviewButton.Text = "アイテムリスト"
        Me.itemlistviewButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.userinfoButton)
        Me.Panel3.Controls.Add(Me.brandeditButton)
        Me.Panel3.Controls.Add(Me.ategoryeditButton)
        Me.Panel3.Location = New System.Drawing.Point(295, 76)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(267, 360)
        Me.Panel3.TabIndex = 2
        '
        'userinfoButton
        '
        Me.userinfoButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.userinfoButton.Location = New System.Drawing.Point(4, 239)
        Me.userinfoButton.Margin = New System.Windows.Forms.Padding(4)
        Me.userinfoButton.Name = "userinfoButton"
        Me.userinfoButton.Size = New System.Drawing.Size(259, 110)
        Me.userinfoButton.TabIndex = 7
        Me.userinfoButton.Text = "ユーザー情報編集"
        Me.userinfoButton.UseVisualStyleBackColor = True
        '
        'brandeditButton
        '
        Me.brandeditButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.brandeditButton.Location = New System.Drawing.Point(4, 121)
        Me.brandeditButton.Margin = New System.Windows.Forms.Padding(4)
        Me.brandeditButton.Name = "brandeditButton"
        Me.brandeditButton.Size = New System.Drawing.Size(259, 110)
        Me.brandeditButton.TabIndex = 6
        Me.brandeditButton.Text = "ブランド編集"
        Me.brandeditButton.UseVisualStyleBackColor = True
        '
        'ategoryeditButton
        '
        Me.ategoryeditButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ategoryeditButton.Location = New System.Drawing.Point(4, 4)
        Me.ategoryeditButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ategoryeditButton.Name = "ategoryeditButton"
        Me.ategoryeditButton.Size = New System.Drawing.Size(259, 110)
        Me.ategoryeditButton.TabIndex = 5
        Me.ategoryeditButton.Text = "カテゴリ編集"
        Me.ategoryeditButton.UseVisualStyleBackColor = True
        '
        'logoutButton
        '
        Me.logoutButton.Location = New System.Drawing.Point(461, 445)
        Me.logoutButton.Margin = New System.Windows.Forms.Padding(4)
        Me.logoutButton.Name = "logoutButton"
        Me.logoutButton.Size = New System.Drawing.Size(100, 29)
        Me.logoutButton.TabIndex = 3
        Me.logoutButton.Text = "ログアウト"
        Me.logoutButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(361, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "管理者向けメニュー"
        '
        'itemAddNewButton
        '
        Me.itemAddNewButton.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.itemAddNewButton.Location = New System.Drawing.Point(4, 239)
        Me.itemAddNewButton.Margin = New System.Windows.Forms.Padding(4)
        Me.itemAddNewButton.Name = "itemAddNewButton"
        Me.itemAddNewButton.Size = New System.Drawing.Size(259, 110)
        Me.itemAddNewButton.TabIndex = 5
        Me.itemAddNewButton.Text = "アイテム登録"
        Me.itemAddNewButton.UseVisualStyleBackColor = True
        '
        'mainmenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 485)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.logoutButton)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mainmenuForm"
        Me.Text = "メインメニュー - clothesDB"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents itemlistviewButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents userinfoButton As Button
    Friend WithEvents brandeditButton As Button
    Friend WithEvents ategoryeditButton As Button
    Friend WithEvents logoutButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents itemeditButton As Button
    Friend WithEvents itemAddNewButton As Button
End Class
