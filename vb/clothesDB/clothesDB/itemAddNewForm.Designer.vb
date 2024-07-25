<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemAddNewForm
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
        Me.components = New System.ComponentModel.Container()
        Dim Item_idLabel As System.Windows.Forms.Label
        Dim Item_nameLabel As System.Windows.Forms.Label
        Dim Brand_idLabel As System.Windows.Forms.Label
        Dim Main_category_idLabel As System.Windows.Forms.Label
        Dim Sub_category_idLabel As System.Windows.Forms.Label
        Dim Release_yearLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Purchase_priceLabel As System.Windows.Forms.Label
        Dim Purchase_dateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(itemAddNewForm))
        Me.itemlistButton = New System.Windows.Forms.Button()
        Me.mainmenuButton = New System.Windows.Forms.Button()
        Me.ClothesDBDataSet = New clothesDB.clothesDBDataSet()
        Me.Tbl_itemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_itemTableAdapter = New clothesDB.clothesDBDataSetTableAdapters.tbl_itemTableAdapter()
        Me.TableAdapterManager = New clothesDB.clothesDBDataSetTableAdapters.TableAdapterManager()
        Me.Tbl_brandTableAdapter = New clothesDB.clothesDBDataSetTableAdapters.tbl_brandTableAdapter()
        Me.Tbl_category_mainTableAdapter = New clothesDB.clothesDBDataSetTableAdapters.tbl_category_mainTableAdapter()
        Me.Tbl_category_subTableAdapter = New clothesDB.clothesDBDataSetTableAdapters.tbl_category_subTableAdapter()
        Me.Tbl_itemBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_itemBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_brandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_category_mainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_category_subBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.データDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveFirstMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovePrevMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveNextMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveLastMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.NewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BackMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Item_idTextBox = New System.Windows.Forms.TextBox()
        Me.Item_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Brand_idComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_brandBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Category_mainComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_category_mainBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Category_subComboBox = New System.Windows.Forms.ComboBox()
        Me.Release_yearTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Purchase_priceTextBox = New System.Windows.Forms.TextBox()
        Me.Purchase_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Item_idLabel = New System.Windows.Forms.Label()
        Item_nameLabel = New System.Windows.Forms.Label()
        Brand_idLabel = New System.Windows.Forms.Label()
        Main_category_idLabel = New System.Windows.Forms.Label()
        Sub_category_idLabel = New System.Windows.Forms.Label()
        Release_yearLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Purchase_priceLabel = New System.Windows.Forms.Label()
        Purchase_dateLabel = New System.Windows.Forms.Label()
        CType(Me.ClothesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_itemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_itemBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_itemBindingNavigator.SuspendLayout()
        CType(Me.Tbl_brandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_category_mainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_category_subBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Tbl_brandBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_category_mainBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Item_idLabel
        '
        Item_idLabel.AutoSize = True
        Item_idLabel.Location = New System.Drawing.Point(31, 96)
        Item_idLabel.Name = "Item_idLabel"
        Item_idLabel.Size = New System.Drawing.Size(52, 15)
        Item_idLabel.TabIndex = 39
        Item_idLabel.Text = "item id:"
        '
        'Item_nameLabel
        '
        Item_nameLabel.AutoSize = True
        Item_nameLabel.Location = New System.Drawing.Point(31, 124)
        Item_nameLabel.Name = "Item_nameLabel"
        Item_nameLabel.Size = New System.Drawing.Size(76, 15)
        Item_nameLabel.TabIndex = 41
        Item_nameLabel.Text = "item name:"
        '
        'Brand_idLabel
        '
        Brand_idLabel.AutoSize = True
        Brand_idLabel.Location = New System.Drawing.Point(31, 152)
        Brand_idLabel.Name = "Brand_idLabel"
        Brand_idLabel.Size = New System.Drawing.Size(59, 15)
        Brand_idLabel.TabIndex = 43
        Brand_idLabel.Text = "brand id:"
        '
        'Main_category_idLabel
        '
        Main_category_idLabel.AutoSize = True
        Main_category_idLabel.Location = New System.Drawing.Point(31, 181)
        Main_category_idLabel.Name = "Main_category_idLabel"
        Main_category_idLabel.Size = New System.Drawing.Size(114, 15)
        Main_category_idLabel.TabIndex = 45
        Main_category_idLabel.Text = "main category id:"
        '
        'Sub_category_idLabel
        '
        Sub_category_idLabel.AutoSize = True
        Sub_category_idLabel.Location = New System.Drawing.Point(31, 210)
        Sub_category_idLabel.Name = "Sub_category_idLabel"
        Sub_category_idLabel.Size = New System.Drawing.Size(107, 15)
        Sub_category_idLabel.TabIndex = 47
        Sub_category_idLabel.Text = "sub category id:"
        '
        'Release_yearLabel
        '
        Release_yearLabel.AutoSize = True
        Release_yearLabel.Location = New System.Drawing.Point(31, 239)
        Release_yearLabel.Name = "Release_yearLabel"
        Release_yearLabel.Size = New System.Drawing.Size(88, 15)
        Release_yearLabel.TabIndex = 49
        Release_yearLabel.Text = "release year:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(31, 267)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(60, 15)
        QuantityLabel.TabIndex = 51
        QuantityLabel.Text = "quantity:"
        '
        'Purchase_priceLabel
        '
        Purchase_priceLabel.AutoSize = True
        Purchase_priceLabel.Location = New System.Drawing.Point(31, 295)
        Purchase_priceLabel.Name = "Purchase_priceLabel"
        Purchase_priceLabel.Size = New System.Drawing.Size(104, 15)
        Purchase_priceLabel.TabIndex = 53
        Purchase_priceLabel.Text = "purchase price:"
        '
        'Purchase_dateLabel
        '
        Purchase_dateLabel.AutoSize = True
        Purchase_dateLabel.Location = New System.Drawing.Point(31, 324)
        Purchase_dateLabel.Name = "Purchase_dateLabel"
        Purchase_dateLabel.Size = New System.Drawing.Size(100, 15)
        Purchase_dateLabel.TabIndex = 55
        Purchase_dateLabel.Text = "purchase date:"
        '
        'itemlistButton
        '
        Me.itemlistButton.Location = New System.Drawing.Point(340, 415)
        Me.itemlistButton.Name = "itemlistButton"
        Me.itemlistButton.Size = New System.Drawing.Size(75, 23)
        Me.itemlistButton.TabIndex = 0
        Me.itemlistButton.Text = "itemlist"
        Me.itemlistButton.UseVisualStyleBackColor = True
        '
        'mainmenuButton
        '
        Me.mainmenuButton.Location = New System.Drawing.Point(238, 415)
        Me.mainmenuButton.Name = "mainmenuButton"
        Me.mainmenuButton.Size = New System.Drawing.Size(96, 23)
        Me.mainmenuButton.TabIndex = 1
        Me.mainmenuButton.Text = "mainmenu"
        Me.mainmenuButton.UseVisualStyleBackColor = True
        '
        'ClothesDBDataSet
        '
        Me.ClothesDBDataSet.DataSetName = "clothesDBDataSet"
        Me.ClothesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_itemBindingSource
        '
        Me.Tbl_itemBindingSource.DataMember = "tbl_item"
        Me.Tbl_itemBindingSource.DataSource = Me.ClothesDBDataSet
        '
        'Tbl_itemTableAdapter
        '
        Me.Tbl_itemTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_brandTableAdapter = Me.Tbl_brandTableAdapter
        Me.TableAdapterManager.tbl_category_mainTableAdapter = Me.Tbl_category_mainTableAdapter
        Me.TableAdapterManager.tbl_category_subTableAdapter = Me.Tbl_category_subTableAdapter
        Me.TableAdapterManager.tbl_itemTableAdapter = Me.Tbl_itemTableAdapter
        Me.TableAdapterManager.tbl_userTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = clothesDB.clothesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_brandTableAdapter
        '
        Me.Tbl_brandTableAdapter.ClearBeforeFill = True
        '
        'Tbl_category_mainTableAdapter
        '
        Me.Tbl_category_mainTableAdapter.ClearBeforeFill = True
        '
        'Tbl_category_subTableAdapter
        '
        Me.Tbl_category_subTableAdapter.ClearBeforeFill = True
        '
        'Tbl_itemBindingNavigator
        '
        Me.Tbl_itemBindingNavigator.AddNewItem = Nothing
        Me.Tbl_itemBindingNavigator.BindingSource = Me.Tbl_itemBindingSource
        Me.Tbl_itemBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_itemBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_itemBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tbl_itemBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_itemBindingNavigatorSaveItem})
        Me.Tbl_itemBindingNavigator.Location = New System.Drawing.Point(0, 28)
        Me.Tbl_itemBindingNavigator.MoveFirstItem = Nothing
        Me.Tbl_itemBindingNavigator.MoveLastItem = Nothing
        Me.Tbl_itemBindingNavigator.MoveNextItem = Nothing
        Me.Tbl_itemBindingNavigator.MovePreviousItem = Nothing
        Me.Tbl_itemBindingNavigator.Name = "Tbl_itemBindingNavigator"
        Me.Tbl_itemBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_itemBindingNavigator.Size = New System.Drawing.Size(427, 27)
        Me.Tbl_itemBindingNavigator.TabIndex = 22
        Me.Tbl_itemBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.ReadOnly = True
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'Tbl_itemBindingNavigatorSaveItem
        '
        Me.Tbl_itemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_itemBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_itemBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_itemBindingNavigatorSaveItem.Name = "Tbl_itemBindingNavigatorSaveItem"
        Me.Tbl_itemBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Tbl_itemBindingNavigatorSaveItem.Text = "データの保存"
        '
        'Tbl_brandBindingSource
        '
        Me.Tbl_brandBindingSource.DataMember = "tbl_brand"
        Me.Tbl_brandBindingSource.DataSource = Me.ClothesDBDataSet
        '
        'Tbl_category_mainBindingSource
        '
        Me.Tbl_category_mainBindingSource.DataMember = "tbl_category_main"
        Me.Tbl_category_mainBindingSource.DataSource = Me.ClothesDBDataSet
        '
        'Tbl_category_subBindingSource
        '
        Me.Tbl_category_subBindingSource.DataMember = "tbl_category_sub"
        Me.Tbl_category_subBindingSource.DataSource = Me.ClothesDBDataSet
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.データDToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(427, 28)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'データDToolStripMenuItem
        '
        Me.データDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveFirstMenuItem, Me.MovePrevMenuItem, Me.MoveNextMenuItem, Me.MoveLastMenuItem, Me.ToolStripSeparator1, Me.NewMenuItem, Me.DeleteMenuItem, Me.SaveMenuItem, Me.ToolStripSeparator2, Me.BackMenuItem})
        Me.データDToolStripMenuItem.Name = "データDToolStripMenuItem"
        Me.データDToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.データDToolStripMenuItem.Text = "データ(&D)"
        '
        'MoveFirstMenuItem
        '
        Me.MoveFirstMenuItem.Name = "MoveFirstMenuItem"
        Me.MoveFirstMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.MoveFirstMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.MoveFirstMenuItem.Text = "最初に移動(&F)"
        '
        'MovePrevMenuItem
        '
        Me.MovePrevMenuItem.Name = "MovePrevMenuItem"
        Me.MovePrevMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.MovePrevMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.MovePrevMenuItem.Text = "前に戻る(&P)"
        '
        'MoveNextMenuItem
        '
        Me.MoveNextMenuItem.Name = "MoveNextMenuItem"
        Me.MoveNextMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.MoveNextMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.MoveNextMenuItem.Text = "次に移動(&N)"
        '
        'MoveLastMenuItem
        '
        Me.MoveLastMenuItem.Name = "MoveLastMenuItem"
        Me.MoveLastMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.MoveLastMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.MoveLastMenuItem.Text = "最後に移動(&L)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(247, 6)
        '
        'NewMenuItem
        '
        Me.NewMenuItem.Name = "NewMenuItem"
        Me.NewMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.NewMenuItem.Text = "新規追加(&A)"
        '
        'DeleteMenuItem
        '
        Me.DeleteMenuItem.Name = "DeleteMenuItem"
        Me.DeleteMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.DeleteMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.DeleteMenuItem.Text = "削除(&D)"
        '
        'SaveMenuItem
        '
        Me.SaveMenuItem.Name = "SaveMenuItem"
        Me.SaveMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.SaveMenuItem.Text = "データの保存(&U)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(247, 6)
        '
        'BackMenuItem
        '
        Me.BackMenuItem.Name = "BackMenuItem"
        Me.BackMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.BackMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.BackMenuItem.Text = "メニューに戻る(&M)"
        '
        'Item_idTextBox
        '
        Me.Item_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_itemBindingSource, "item_id", True))
        Me.Item_idTextBox.Location = New System.Drawing.Point(151, 93)
        Me.Item_idTextBox.Name = "Item_idTextBox"
        Me.Item_idTextBox.ReadOnly = True
        Me.Item_idTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Item_idTextBox.TabIndex = 40
        '
        'Item_nameTextBox
        '
        Me.Item_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_itemBindingSource, "item_name", True))
        Me.Item_nameTextBox.Location = New System.Drawing.Point(151, 121)
        Me.Item_nameTextBox.Name = "Item_nameTextBox"
        Me.Item_nameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Item_nameTextBox.TabIndex = 42
        '
        'Brand_idComboBox
        '
        Me.Brand_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_itemBindingSource, "brand_id", True))
        Me.Brand_idComboBox.DataSource = Me.Tbl_brandBindingSource1
        Me.Brand_idComboBox.DisplayMember = "brand_main"
        Me.Brand_idComboBox.FormattingEnabled = True
        Me.Brand_idComboBox.Location = New System.Drawing.Point(151, 149)
        Me.Brand_idComboBox.Name = "Brand_idComboBox"
        Me.Brand_idComboBox.Size = New System.Drawing.Size(200, 23)
        Me.Brand_idComboBox.TabIndex = 44
        Me.Brand_idComboBox.ValueMember = "brand_id"
        '
        'Tbl_brandBindingSource1
        '
        Me.Tbl_brandBindingSource1.DataMember = "tbl_brand"
        Me.Tbl_brandBindingSource1.DataSource = Me.ClothesDBDataSet
        '
        'Category_mainComboBox
        '
        Me.Category_mainComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_itemBindingSource, "main_category_id", True))
        Me.Category_mainComboBox.FormattingEnabled = True
        Me.Category_mainComboBox.Location = New System.Drawing.Point(151, 178)
        Me.Category_mainComboBox.Name = "Category_mainComboBox"
        Me.Category_mainComboBox.Size = New System.Drawing.Size(200, 23)
        Me.Category_mainComboBox.TabIndex = 46
        '
        'Tbl_category_mainBindingSource1
        '
        Me.Tbl_category_mainBindingSource1.DataMember = "tbl_category_main"
        Me.Tbl_category_mainBindingSource1.DataSource = Me.ClothesDBDataSet
        '
        'Category_subComboBox
        '
        Me.Category_subComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_itemBindingSource, "sub_category_id", True))
        Me.Category_subComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_itemBindingSource, "sub_category_id", True))
        Me.Category_subComboBox.FormattingEnabled = True
        Me.Category_subComboBox.Location = New System.Drawing.Point(151, 207)
        Me.Category_subComboBox.Name = "Category_subComboBox"
        Me.Category_subComboBox.Size = New System.Drawing.Size(200, 23)
        Me.Category_subComboBox.TabIndex = 48
        '
        'Release_yearTextBox
        '
        Me.Release_yearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_itemBindingSource, "release_year", True))
        Me.Release_yearTextBox.Location = New System.Drawing.Point(151, 236)
        Me.Release_yearTextBox.Name = "Release_yearTextBox"
        Me.Release_yearTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Release_yearTextBox.TabIndex = 50
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_itemBindingSource, "quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(151, 264)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(200, 22)
        Me.QuantityTextBox.TabIndex = 52
        '
        'Purchase_priceTextBox
        '
        Me.Purchase_priceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_itemBindingSource, "purchase_price", True))
        Me.Purchase_priceTextBox.Location = New System.Drawing.Point(151, 292)
        Me.Purchase_priceTextBox.Name = "Purchase_priceTextBox"
        Me.Purchase_priceTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Purchase_priceTextBox.TabIndex = 54
        '
        'Purchase_dateDateTimePicker
        '
        Me.Purchase_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_itemBindingSource, "purchase_date", True))
        Me.Purchase_dateDateTimePicker.Location = New System.Drawing.Point(151, 320)
        Me.Purchase_dateDateTimePicker.Name = "Purchase_dateDateTimePicker"
        Me.Purchase_dateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Purchase_dateDateTimePicker.TabIndex = 56
        '
        'itemAddNewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 450)
        Me.ControlBox = False
        Me.Controls.Add(Item_idLabel)
        Me.Controls.Add(Me.Item_idTextBox)
        Me.Controls.Add(Item_nameLabel)
        Me.Controls.Add(Me.Item_nameTextBox)
        Me.Controls.Add(Brand_idLabel)
        Me.Controls.Add(Me.Brand_idComboBox)
        Me.Controls.Add(Main_category_idLabel)
        Me.Controls.Add(Me.Category_mainComboBox)
        Me.Controls.Add(Sub_category_idLabel)
        Me.Controls.Add(Me.Category_subComboBox)
        Me.Controls.Add(Release_yearLabel)
        Me.Controls.Add(Me.Release_yearTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Purchase_priceLabel)
        Me.Controls.Add(Me.Purchase_priceTextBox)
        Me.Controls.Add(Purchase_dateLabel)
        Me.Controls.Add(Me.Purchase_dateDateTimePicker)
        Me.Controls.Add(Me.Tbl_itemBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.mainmenuButton)
        Me.Controls.Add(Me.itemlistButton)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "itemAddNewForm"
        Me.Text = "アイテム登録"
        CType(Me.ClothesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_itemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_itemBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_itemBindingNavigator.ResumeLayout(False)
        Me.Tbl_itemBindingNavigator.PerformLayout()
        CType(Me.Tbl_brandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_category_mainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_category_subBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Tbl_brandBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_category_mainBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents itemlistButton As Button
    Friend WithEvents mainmenuButton As Button
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
    Friend WithEvents Tbl_brandTableAdapter As clothesDBDataSetTableAdapters.tbl_brandTableAdapter
    Friend WithEvents Tbl_brandBindingSource As BindingSource
    Friend WithEvents Tbl_category_mainTableAdapter As clothesDBDataSetTableAdapters.tbl_category_mainTableAdapter
    Friend WithEvents Tbl_category_mainBindingSource As BindingSource
    Friend WithEvents Tbl_category_subTableAdapter As clothesDBDataSetTableAdapters.tbl_category_subTableAdapter
    Friend WithEvents Tbl_category_subBindingSource As BindingSource
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents データDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoveFirstMenuItem As ToolStripMenuItem
    Friend WithEvents MovePrevMenuItem As ToolStripMenuItem
    Friend WithEvents MoveNextMenuItem As ToolStripMenuItem
    Friend WithEvents MoveLastMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NewMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteMenuItem As ToolStripMenuItem
    Friend WithEvents SaveMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BackMenuItem As ToolStripMenuItem
    Friend WithEvents Item_idTextBox As TextBox
    Friend WithEvents Item_nameTextBox As TextBox
    Friend WithEvents Brand_idComboBox As ComboBox
    Friend WithEvents Category_mainComboBox As ComboBox
    Friend WithEvents Category_subComboBox As ComboBox
    Friend WithEvents Release_yearTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Purchase_priceTextBox As TextBox
    Friend WithEvents Purchase_dateDateTimePicker As DateTimePicker
    Friend WithEvents Tbl_brandBindingSource1 As BindingSource
    Friend WithEvents Tbl_category_mainBindingSource1 As BindingSource
End Class
