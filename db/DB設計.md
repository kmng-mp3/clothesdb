# DB設計(SQL Server使用)

- 服をDBに登録、編集、閲覧する
- 服はカテゴリ分けして管理
    - ブランド名、半袖Tシャツ/長袖Tシャツなど服のタイプ
    - 服は所持/未所持を管理
        - 所持フラグではなく、所持個数で管理する
        - これらを利用してDB内で絞り込み検索ができる

# 手書き草案
## DB設計（MVP段階）
- 基本的にはNULLを許容しない。**許容するものは必ずNULL許容の旨明記**
### 必要なテーブル
#### 服: tbl_item
- 服1種類ごとに1レコード

#### ブランド名: tbl_brand
- ブランド名をbrand_main、ブランドのラインをbrand_sub
    - 例: brand_main: COMME des GARCONS brand_sub: PLAY COMME des GARCONS

#### カテゴリ: tbl_category_main
- 大カテゴリ
- - 例: TOPS

#### カテゴリ: tbl_category_sub
- 小カテゴリ
    - 例: T-Shirts

#### ユーザー: tbl_user
- PWをハッシュ化して管理
    - Bcrypt使用
    - ローカルで動かすから必須ではないが、練習のため

# ChatGPTによる修正とテーブル作成
## クエリ
```sql
-- 服テーブル
CREATE TABLE tbl_item (
    item_id INT IDENTITY(1,1) PRIMARY KEY,
    item_name VARCHAR(100) NOT NULL,
    brand_id INT NOT NULL,
    main_category_id INT NOT NULL,
    sub_category_id INT NOT NULL,
    release_year INT NULL,
    quantity INT NOT NULL,
    purchase_price DECIMAL(10, 0)NOT NULL,
    purchase_date DATE,
    FOREIGN KEY (brand_id) REFERENCES tbl_brand(brand_id),
    FOREIGN KEY (main_category_id) REFERENCES tbl_category_main(main_category_id),
    FOREIGN KEY (sub_category_id) REFERENCES tbl_category_sub(sub_category_id)
);

-- ブランドテーブル
CREATE TABLE tbl_brand (
    brand_id INT IDENTITY(1,1) PRIMARY KEY,
    brand_main VARCHAR(50) NOT NULL,
    brand_sub VARCHAR(50) NULL
);

-- メインカテゴリテーブル
CREATE TABLE tbl_category_main (
    main_category_id INT IDENTITY(1,1) PRIMARY KEY,
    category_main VARCHAR(50) NOT NULL
);

-- サブカテゴリテーブル
CREATE TABLE tbl_category_sub (
    sub_category_id INT IDENTITY(1,1) PRIMARY KEY,
    category_sub VARCHAR(50) NOT NULL,
    main_category_id INT NOT NULL,
    FOREIGN KEY (main_category_id) REFERENCES tbl_category_main(main_category_id)
);

-- ユーザーテーブル
CREATE TABLE tbl_user (
    user_id VARCHAR(15) PRIMARY KEY,
    displayname VARCHAR(30) NOT NULL,
    is_admin BOOLEAN NOT NULL DEFAULT FALSE
);

-- インデックスの追加
CREATE INDEX idx_item_name ON tbl_item(item_name);
CREATE INDEX idx_brand_id ON tbl_item(brand_id);
CREATE INDEX idx_main_category_id ON tbl_item(main_category_id);
CREATE INDEX idx_sub_category_id ON tbl_item(sub_category_id);
```