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
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_itemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClothesDBDataSet = New clothesDB.clothesDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_itemBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.itemeditButton = New System.Windows.Forms.Button()
        Me.Tbl_itemTableAdapter = New clothesDB.clothesDBDataSetTableAdapters.tbl_itemTableAdapter()
        Me.TableAdapterManager = New clothesDB.clothesDBDataSetTableAdapters.TableAdapterManager()
        Me.Clothesdb_listviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clothesdb_listviewTableAdapter = New clothesDB.clothesDBDataSetTableAdapters.clothesdb_listviewTableAdapter()
        Me.Clothesdb_listviewDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReleaseYearStartTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReleaseYearEndTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FilterButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BrandMainTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tbl_category_mainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_category_mainTableAdapter = New clothesDB.clothesDBDataSetTableAdapters.tbl_category_mainTableAdapter()
        Me.Category_mainComboBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PriceMaxTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PriceMinTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PurchaseDatePastTextBox = New System.Windows.Forms.TextBox()
        Me.PurchaseDateThenTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.Tbl_itemBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_itemBindingNavigator.SuspendLayout()
        CType(Me.Tbl_itemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClothesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clothesdb_listviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clothesdb_listviewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_category_mainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'backmainmenuButton
        '
        Me.backmainmenuButton.Location = New System.Drawing.Point(727, 609)
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
        Me.Tbl_itemBindingNavigator.Size = New System.Drawing.Size(1040, 27)
        Me.Tbl_itemBindingNavigator.TabIndex = 2
        Me.Tbl_itemBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 24)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Tbl_itemBindingNavigatorSaveItem
        '
        Me.Tbl_itemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_itemBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_itemBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_itemBindingNavigatorSaveItem.Name = "Tbl_itemBindingNavigatorSaveItem"
        Me.Tbl_itemBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Tbl_itemBindingNavigatorSaveItem.Text = "データの保存"
        '
        'itemeditButton
        '
        Me.itemeditButton.Location = New System.Drawing.Point(891, 609)
        Me.itemeditButton.Name = "itemeditButton"
        Me.itemeditButton.Size = New System.Drawing.Size(112, 23)
        Me.itemeditButton.TabIndex = 3
        Me.itemeditButton.Text = "編集"
        Me.itemeditButton.UseVisualStyleBackColor = True
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
        'Clothesdb_listviewBindingSource
        '
        Me.Clothesdb_listviewBindingSource.DataMember = "clothesdb_listview"
        Me.Clothesdb_listviewBindingSource.DataSource = Me.ClothesDBDataSet
        '
        'Clothesdb_listviewTableAdapter
        '
        Me.Clothesdb_listviewTableAdapter.ClearBeforeFill = True
        '
        'Clothesdb_listviewDataGridView
        '
        Me.Clothesdb_listviewDataGridView.AutoGenerateColumns = False
        Me.Clothesdb_listviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Clothesdb_listviewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn1})
        Me.Clothesdb_listviewDataGridView.DataSource = Me.Clothesdb_listviewBindingSource
        Me.Clothesdb_listviewDataGridView.Location = New System.Drawing.Point(12, 192)
        Me.Clothesdb_listviewDataGridView.Name = "Clothesdb_listviewDataGridView"
        Me.Clothesdb_listviewDataGridView.RowHeadersWidth = 51
        Me.Clothesdb_listviewDataGridView.RowTemplate.Height = 24
        Me.Clothesdb_listviewDataGridView.Size = New System.Drawing.Size(1008, 411)
        Me.Clothesdb_listviewDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "item_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "アイテム名"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "brand_main"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ブランド名"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "category_main"
        Me.DataGridViewTextBoxColumn4.HeaderText = "大カテゴリ"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "category_sub"
        Me.DataGridViewTextBoxColumn5.HeaderText = "小カテゴリ"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "release_year"
        Me.DataGridViewTextBoxColumn6.HeaderText = "発売年"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "quantity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "所持数"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "purchase_price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "購入時金額"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "purchase_date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "購入日"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 125
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "item_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "アイテムID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "発売年:"
        '
        'ReleaseYearStartTextBox
        '
        Me.ReleaseYearStartTextBox.Location = New System.Drawing.Point(403, 28)
        Me.ReleaseYearStartTextBox.MaxLength = 4
        Me.ReleaseYearStartTextBox.Name = "ReleaseYearStartTextBox"
        Me.ReleaseYearStartTextBox.Size = New System.Drawing.Size(56, 22)
        Me.ReleaseYearStartTextBox.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(465, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "～"
        '
        'ReleaseYearEndTextBox
        '
        Me.ReleaseYearEndTextBox.Location = New System.Drawing.Point(493, 28)
        Me.ReleaseYearEndTextBox.MaxLength = 4
        Me.ReleaseYearEndTextBox.Name = "ReleaseYearEndTextBox"
        Me.ReleaseYearEndTextBox.Size = New System.Drawing.Size(56, 22)
        Me.ReleaseYearEndTextBox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(555, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "年"
        '
        'FilterButton
        '
        Me.FilterButton.Location = New System.Drawing.Point(802, 106)
        Me.FilterButton.Name = "FilterButton"
        Me.FilterButton.Size = New System.Drawing.Size(155, 67)
        Me.FilterButton.TabIndex = 11
        Me.FilterButton.Text = "フィルター実行"
        Me.FilterButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "アイテム名:"
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.Location = New System.Drawing.Point(88, 28)
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(190, 22)
        Me.ItemNameTextBox.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ブランド名:"
        '
        'BrandMainTextBox
        '
        Me.BrandMainTextBox.Location = New System.Drawing.Point(88, 61)
        Me.BrandMainTextBox.Name = "BrandMainTextBox"
        Me.BrandMainTextBox.Size = New System.Drawing.Size(190, 22)
        Me.BrandMainTextBox.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "大カテゴリ:"
        '
        'Tbl_category_mainBindingSource
        '
        Me.Tbl_category_mainBindingSource.DataMember = "tbl_category_main"
        Me.Tbl_category_mainBindingSource.DataSource = Me.ClothesDBDataSet
        '
        'Tbl_category_mainTableAdapter
        '
        Me.Tbl_category_mainTableAdapter.ClearBeforeFill = True
        '
        'Category_mainComboBox
        '
        Me.Category_mainComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_category_mainBindingSource, "category_main", True))
        Me.Category_mainComboBox.FormattingEnabled = True
        Me.Category_mainComboBox.Location = New System.Drawing.Point(88, 94)
        Me.Category_mainComboBox.Name = "Category_mainComboBox"
        Me.Category_mainComboBox.Size = New System.Drawing.Size(190, 23)
        Me.Category_mainComboBox.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(342, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "所持数:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(403, 61)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(79, 22)
        Me.QuantityTextBox.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(312, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 15)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "購入時金額:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(601, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 15)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "円"
        '
        'PriceMaxTextBox
        '
        Me.PriceMaxTextBox.Location = New System.Drawing.Point(516, 94)
        Me.PriceMaxTextBox.MaxLength = 8
        Me.PriceMaxTextBox.Name = "PriceMaxTextBox"
        Me.PriceMaxTextBox.Size = New System.Drawing.Size(79, 22)
        Me.PriceMaxTextBox.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(488, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "～"
        '
        'PriceMinTextBox
        '
        Me.PriceMinTextBox.Location = New System.Drawing.Point(403, 94)
        Me.PriceMinTextBox.MaxLength = 8
        Me.PriceMinTextBox.Name = "PriceMinTextBox"
        Me.PriceMinTextBox.Size = New System.Drawing.Size(79, 22)
        Me.PriceMinTextBox.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(312, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 15)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "購入年月日:"
        '
        'PurchaseDatePastTextBox
        '
        Me.PurchaseDatePastTextBox.Location = New System.Drawing.Point(403, 129)
        Me.PurchaseDatePastTextBox.MaxLength = 10
        Me.PurchaseDatePastTextBox.Name = "PurchaseDatePastTextBox"
        Me.PurchaseDatePastTextBox.Size = New System.Drawing.Size(107, 22)
        Me.PurchaseDatePastTextBox.TabIndex = 27
        Me.PurchaseDatePastTextBox.Text = "YYYY/MM/DD"
        '
        'PurchaseDateThenTextBox
        '
        Me.PurchaseDateThenTextBox.Location = New System.Drawing.Point(544, 129)
        Me.PurchaseDateThenTextBox.MaxLength = 10
        Me.PurchaseDateThenTextBox.Name = "PurchaseDateThenTextBox"
        Me.PurchaseDateThenTextBox.Size = New System.Drawing.Size(107, 22)
        Me.PurchaseDateThenTextBox.TabIndex = 28
        Me.PurchaseDateThenTextBox.Text = "YYYY/MM/DD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(516, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 15)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "～"
        '
        'itemlistForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1040, 652)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PurchaseDateThenTextBox)
        Me.Controls.Add(Me.PurchaseDatePastTextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PriceMaxTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PriceMinTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Category_mainComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BrandMainTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ItemNameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FilterButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReleaseYearEndTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReleaseYearStartTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Clothesdb_listviewDataGridView)
        Me.Controls.Add(Me.itemeditButton)
        Me.Controls.Add(Me.Tbl_itemBindingNavigator)
        Me.Controls.Add(Me.backmainmenuButton)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "itemlistForm"
        Me.Text = "itemlistForm"
        CType(Me.Tbl_itemBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_itemBindingNavigator.ResumeLayout(False)
        Me.Tbl_itemBindingNavigator.PerformLayout()
        CType(Me.Tbl_itemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClothesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clothesdb_listviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clothesdb_listviewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_category_mainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents itemeditButton As Button
    Friend WithEvents Clothesdb_listviewBindingSource As BindingSource
    Friend WithEvents Clothesdb_listviewTableAdapter As clothesDBDataSetTableAdapters.clothesdb_listviewTableAdapter
    Friend WithEvents Clothesdb_listviewDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents ReleaseYearStartTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ReleaseYearEndTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FilterButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ItemNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BrandMainTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Tbl_category_mainBindingSource As BindingSource
    Friend WithEvents Tbl_category_mainTableAdapter As clothesDBDataSetTableAdapters.tbl_category_mainTableAdapter
    Friend WithEvents Category_mainComboBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PriceMaxTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PriceMinTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PurchaseDatePastTextBox As TextBox
    Friend WithEvents PurchaseDateThenTextBox As TextBox
    Friend WithEvents Label12 As Label
End Class
