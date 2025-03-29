create table product
(
	MaSP nvarchar(15) primary key,
	TenSP nvarchar(50),
	MaLoaiSP nvarchar(15),
	KichThuoc nvarchar(15),
	NgaySX date,
	Photo image,
	MoTaSP nvarchar(100)
);
create table product_catalog
(
	MaLoaiSP nvarchar(15) primary key,
	TenLoaiSP nvarchar(50),
	MoTaLoaiSP nvarchar(100),
	CONSTRAINT FK_product_catalog FOREIGN KEY (MaLoaiSP) REFERENCES product(MaLoaiSP)
);