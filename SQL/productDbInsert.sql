USE ProductDb
GO

SELECT * FROM dbo.Products
INSERT INTO dbo.Products(ProductName,ProductCode,ReleaseDate,Description,Price,StarRating,ImageUrl) VALUES('Leaf Rake','GDN-0011','March 19, 2016','Leaf rake with 48-inch wooden handle.',19.95, 3.2,'http://openclipart.org/image/300px/svg_to_png/26215/Anonymous_Leaf_Rake.png');
INSERT INTO dbo.Products(ProductName,ProductCode,ReleaseDate,Description,Price,StarRating,ImageUrl) VALUES('Garden Cart','GDN-0023','March 18, 2016','15 gallon capacity rolling garden cart',32.99, 4.2,'http://openclipart.org/image/300px/svg_to_png/58471/garden_cart.png');
INSERT INTO dbo.Products(ProductName,ProductCode,ReleaseDate,Description,Price,StarRating,ImageUrl) VALUES('Hammer','TBX-0048','May 15, 2016','15-inch steel blade hand saw',11.55, 3.7,'http://openclipart.org/image/300px/svg_to_png/73/rejon_Hammer.png');
INSERT INTO dbo.Products(ProductName,ProductCode,ReleaseDate,Description,Price,StarRating,ImageUrl) VALUES('Saw','TBX-0022','March 19, 2016','Leaf rake with 48-inch wooden handle.',19.95, 3.2,'http://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png');
INSERT INTO dbo.Products(ProductName,ProductCode,ReleaseDate,Description,Price,StarRating,ImageUrl) VALUES('Video Game Controller','GMG-0042','October 15, 2015','Standard two-button video game controller',35.95, 4.6,'http://openclipart.org/image/300px/svg_to_png/120337/xbox-controller_01.png');

