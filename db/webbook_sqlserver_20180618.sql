CREATE TABLE  [dbo].[tbl_category](
  [id] [int] NOT NULL,
  [name] [nvarchar](100) NOT NULL,
  CONSTRAINT [PK_tbl_category] PRIMARY KEY CLUSTERED ([id] ASC)) ON [PRIMARY]

CREATE TABLE  [dbo].[tbl_isbn_book](
  [id] [int] IDENTITY (1, 1) NOT NULL,
  [isbn] [nvarchar](20) NOT NULL,
  [category_id] [int] NOT NULL,
  [title] [nvarchar](100) NOT NULL,
  [author] [nvarchar](100) NOT NULL,
  [statflg] [int] NOT NULL,
  CONSTRAINT [PK_tbl_isbn_book] PRIMARY KEY CLUSTERED ([id] ASC)) ON [PRIMARY]


CREATE TABLE  [dbo].[tbl_lending] (
  [id] [int] IDENTITY (1, 1) NOT NULL,
  [book_id] [int] NOT NULL,
  [staff_code] [int] NOT NULL,
  [start_date] [datetime] NOT NULL,
  [return_date] [datetime] NULL,
  CONSTRAINT [PK_tbl_lending] PRIMARY KEY CLUSTERED ([id] ASC)) ON [PRIMARY]

INSERT INTO tbl_category VALUES (1, '文学・評論');
INSERT INTO tbl_category VALUES (2, '人文・思想');
INSERT INTO tbl_category VALUES (3, '社会・政治・法律');
INSERT INTO tbl_category VALUES (4, '歴史・地理');
INSERT INTO tbl_category VALUES (5, '科学・テクノロジー');
INSERT INTO tbl_category VALUES (6, '医学・薬学');
INSERT INTO tbl_category VALUES (7, 'コンピュータ・インターネット');
INSERT INTO tbl_category VALUES (8, '暮らし・健康・子育て');
INSERT INTO tbl_category VALUES (9, 'アダルト');

INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('kei000001', 1, '税金はなぜ高いのか', '税博士', 0);
INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('kei000002', 1, '金融のからくり', '利惟哉', 0);
INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('rek000001', 2, '日本の歴史', '足利信長', 0);
INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('rek000002', 2, '米国の歴史', 'グッシュ', 0);
INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('com000001', 3, 'わかりやすいJava', '益田陽一', 0);
INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('com000002', 3, 'DBリファレンス', '戸塚信二', 0);
INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('bun000001', 4, '戦争と試合', 'トルトル', 0);
INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('bun000002', 4, '摘み賭罰', 'ドストアイスキー', 0);
INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('sei000001', 5, '猫と仲良くなるには', '猫田恵美', 0);
INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('sei000002', 5, 'らくちんダイエット', '細区奈留代', 0);
INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('eho000001', 6, 'さんすうができるようになるほん', 'やまもとさや', 0);
INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('eho000002', 6, 'たのしいどうよう', 'ふるたまさあき', 0);
INSERT INTO tbl_isbn_book (isbn, category_id, title, author, statflg) VALUES ('eho000002', 6, 'もふもふテクニック', 'ねこ', 0);
