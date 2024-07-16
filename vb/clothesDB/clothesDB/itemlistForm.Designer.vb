<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class itemlistForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(itemlistForm))
        Me.backmainmenuButton = New System.Windows.Forms.Button()
        Me.Tbl_itemBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_itemBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_itemDataGridView = New System.Windows.Forms.DataGridView()
        Me.itemeditButton = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_itemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClothesDBDataSet = New clothesDB.clothesDBDataSet()
        Me.Tbl_itemTableAdapter = New clothesDB.clothesDBDataSetTableAdapters.tbl_itemTableAdapter()
        Me.TableAdapterManager = New clothesDB.clothesDBDataSetTableAdapters.TableAdapterManager()
        CType(Me.Tbl_itemBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_itemBindingNavigator.SuspendLayout()
        CType(Me.Tbl_itemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_itemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClothesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backmainmenuButton
        '
        Me.backmainmenuButton.Location = New System.Drawing.Point(727, 590)
        Me.backmainmenuButton.Name = "backmainmenuButton"
        Me.backmainmenuButton.Size = New System.Drawing.Size(112, 23)
        Me.backmainmenuButton.TabIndex = 1
        Me.backmainmenuButton.Text = "メインメニュー"
        Me.backmainmenuButton.UseVisualStyleBackColor = True
        '
        'Tbl_itemBindingNavigator
        '
        Me.Tbl_itemBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_itemBindingNavigator.BindingSource = Me.Tbl_itemBindingSource
        Me.Tbl_itemBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_itemBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_itemBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tbl_itemBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_itemBindingNavigatorSaveItem})
        Me.Tbl_itemBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_itemBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_itemBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_itemBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_itemBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_itemBindingNavigator.Name = "Tbl_itemBindingNavigator"
        Me.Tbl_itemBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_itemBindingNavigator.Size = New System.Drawing.Size(1024, 27)
        Me.Tbl_itemBindingNavigator.TabIndex = 2
        Me.Tbl_itemBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 24)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'Tbl_itemBindingNavigatorSaveItem
        '
        Me.Tbl_itemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_itemBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_itemBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_itemBindingNavigatorSaveItem.Name = "Tbl_itemBindingNavigatorSaveItem"
        Me.Tbl_itemBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Tbl_itemBindingNavigatorSaveItem.Text = "データの保存"
        '
        'Tbl_itemDataGridView
        '
        Me.Tbl_itemDataGridView.AutoGenerateColumns = False
        Me.Tbl_itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_itemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Tbl_itemDataGridView.DataSource = Me.Tbl_itemBindingSource
        Me.Tbl_itemDataGridView.Location = New System.Drawing.Point(32, 127)
        Me.Tbl_itemDataGridView.Name = "Tbl_itemDataGridView"
        Me.Tbl_itemDataGridView.RowHeadersWidth = 51
        Me.Tbl_itemDataGridView.RowTemplate.Height = 24
        Me.Tbl_itemDataGridView.Size = New System.Drawing.Size(902, 392)
        Me.Tbl_itemDataGridView.TabIndex = 2
        '
        'itemeditButton
        '
        Me.itemeditButton.Location = New System.Drawing.Point(845, 590)
        Me.itemeditButton.Name = "itemeditButton"
        Me.itemeditButton.Size = New System.Drawing.Size(112, 23)
        Me.itemeditButton.TabIndex = 3
        Me.itemeditButton.Text = "編集"
        Me.itemeditButton.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "item_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "item_id"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "item_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "item_name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "brand_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "brand_id"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "main_category_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "main_category_id"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "sub_category_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "sub_category_id"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "release_year"
        Me.DataGridViewTextBoxColumn6.HeaderText = "release_year"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "quantity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "quantity"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "purchase_price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "purchase_price"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "purchase_date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "purchase_date"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'Tbl_itemBindingSource
        '
        Me.Tbl_itemBindingSource.DataMember = "tbl_item"
        Me.Tbl_itemBindingSource.DataSource = Me.ClothesDBDataSet
        '
        'ClothesDBDataSet
        '
        Me.ClothesDBDataSet.DataSetName = "clothesDBDataSet"
        Me.ClothesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_itemTableAdapter
        '
        Me.Tbl_itemTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_brandTableAdapter = Nothing
        Me.TableAdapterManager.tbl_category_mainTableAdapter = Nothing
        Me.TableAdapterManager.tbl_category_subTableAdapter = Nothing
        Me.TableAdapterManager.tbl_itemTableAdapter = Me.Tbl_itemTableAdapter
        Me.TableAdapterManager.tbl_userTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = clothesDB.clothesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'itemlistForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 644)
        Me.Controls.Add(Me.itemeditButton)
        Me.Controls.Add(Me.Tbl_itemDataGridView)
        Me.Controls.Add(Me.Tbl_itemBindingNavigator)
        Me.Controls.Add(Me.backmainmenuButton)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "itemlistForm"
        Me.Text = "itemlistForm"
        CType(Me.Tbl_itemBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_itemBindingNavigator.ResumeLayout(False)
        Me.Tbl_itemBindingNavigator.PerformLayout()
        CType(Me.Tbl_itemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_itemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClothesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents backmainmenuButton As Button
    Friend WithEvents ClothesDBDataSet As clothesDBDataSet
    Friend WithEvents Tbl_itemBindingSource As BindingSource
    Friend WithEvents Tbl_itemTableAdapter As clothesDBDataSetTableAdapters.tbl_itemTableAdapter
    Friend WithEvents TableAdapterManager As clothesDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_itemBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_itemBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_itemDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents itemeditButton As Button
End Class
