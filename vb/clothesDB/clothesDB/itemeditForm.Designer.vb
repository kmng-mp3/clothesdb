﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemeditForm
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
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MainMenuButton
        '
        Me.MainMenuButton.Location = New System.Drawing.Point(662, 384)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(126, 54)
        Me.MainMenuButton.TabIndex = 0
        Me.MainMenuButton.Text = "メインメニュー"
        Me.MainMenuButton.UseVisualStyleBackColor = True
        '
        'itemeditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MainMenuButton)
        Me.Name = "itemeditForm"
        Me.Text = "itemeditForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainMenuButton As Button
End Class
