-- 初期設定クエリ

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
    displayname VARCHAR(30) NOT NULL
);

-- 服テーブル
CREATE TABLE tbl_item (
    item_id INT IDENTITY(1,1) PRIMARY KEY,
    item_name VARCHAR(100) NOT NULL,
    brand_id INT NOT NULL,
    main_category_id INT NOT NULL,
    sub_category_id INT NOT NULL,
    release_year INT NULL,
    owned_flag BIT NOT NULL,
    FOREIGN KEY (brand_id) REFERENCES tbl_brand(brand_id),
    FOREIGN KEY (main_category_id) REFERENCES tbl_category_main(main_category_id),
    FOREIGN KEY (sub_category_id) REFERENCES tbl_category_sub(sub_category_id)
);

-- インデックスの追加
CREATE INDEX idx_item_name ON tbl_item(item_name);
CREATE INDEX idx_brand_id ON tbl_item(brand_id);
CREATE INDEX idx_main_category_id ON tbl_item(main_category_id);
CREATE INDEX idx_sub_category_id ON tbl_item(sub_category_id);

-- カテゴリメインテーブルに挿入するクエリ
INSERT INTO tbl_category_main (category_main) VALUES
('TOPS'),
('JACKET/OUTER'),
('PANTS'),
('ALL-IN-ONE'),
('SKIRT'),
('DRESS'),
('FOOTWEAR'),
('LEG WEAR'),
('UNDERWEAR/SWIMWEAR'),
('HEAD GEAR'),
('EYEWEAR'),
('BAG'),
('ACCESSORIES'),
('JEWELRY'),
('TECH');

-- カテゴリサブテーブルに挿入するクエリ
INSERT INTO tbl_category_sub (category_sub, main_category_id) VALUES
('T-Shirt', 1),
('Shirt/Blouse', 1),
('Polo', 1),
('Sweatshirt', 1),
('Hooded Sweatshirt', 1),
('Vest', 1),
('Cardigan/Bolero', 1),
('Emsamble', 1),
('Tank-top', 1),
('Tube-top', 1),
('Packed Tee', 1),
('Other Tops', 1),
('Tailored Jacket', 2),
('Denim Jacket', 2),
('Down Jacket/Coat', 2),
('Duffle Coat', 2),
('Riders Jacket', 2),
('Blouson', 2),
('Military Jacket/MA-1', 2),
('Trench Coat', 2),
('Chester Coat', 2),
('Mouton Jacket/Coat', 2),
('Nylon Jacket/Coat', 2),
('Mountain Jacket/Parka', 2),
('Varsity Jacket', 2),
('Souvenir Jacket', 2),
('Coverall Jacket', 2),
('Poncho', 2),
('Rain Coat', 2),
('Other Jacket/Outer', 2),
('Denim Pants', 3),
('Cargo Pants', 3),
('Chino Pants', 3),
('Sweatpants', 3),
('Slacks/Trousers', 3),
('Other Pants', 3),
('Skirt', 5),
('Denim Skirt', 5),
('Other Skirt', 5),
('Sneakers', 7),
('Sandals/Slides', 7),
('Pump/Court Shoes', 7),
('Boots', 7),
('Dress Shoes', 7),
('Loafers', 7),
('Deck Shoes/Moccasins', 7),
('Rain Shoes/Boots', 7),
('Shoes Accessories', 7),
('Shoe Care', 7),
('Other Footwears', 7),
('Socks', 8),
('Tights', 8),
('Stockings', 8),
('Leggings', 8),
('Leg Warmers', 8),
('Other Leg Wear', 8),
('Trunks', 9),
('Briefs', 9),
('Bra', 9),
('Panties', 9),
('Bikini', 9),
('Swim Trunks', 9),
('Other Underwear', 9),
('Other Swimwear', 9),
('Cap', 10),
('Hat', 10),
('Beanie/Knit Cap', 10),
('Beret', 10),
('Hunting Cap', 10),
('Visor', 10),
('Other Head gear', 10),
('Glasses', 11),
('Sunglasses', 11),
('Goggles', 11),
('Other Eyewear', 11),
('Shoulder Bag', 12),
('Tote Bag', 12),
('Backpack', 12),
('Duffle Bag', 12),
('Waist Bag', 12),
('Handbag', 12),
('Clutch Bag', 12),
('Messenger Bag', 12),
('Suitcase', 12),
('Basket', 12),
('Tech Bag', 12),
('Other Bag', 12),
('Belt', 13),
('Suspenders', 13),
('Gloves', 13),
('Scarf', 13),
('Mask', 13),
('Tie', 13),
('Arm Sleeves', 13),
('Earmuffs', 13),
('Detachable Collar', 13),
('Other Accessory', 13),
('Bracelet', 14),
('Earring', 14),
('Necklace', 14),
('Pendant', 14),
('Ring', 14),
('Pierce', 14),
('Other Jewelry', 14),
('Phone Case', 15),
('Smartphone', 15),
('Flip Phone', 15),
('Desktop PC', 15),
('Laptop', 15),
('Earphone/Headphone', 15),
('Earphone/Headphone Case', 15),
('Other Tech', 15);
