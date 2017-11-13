DROP TABLE order_items;
DROP TABLE products;
DROP TABLE orders;


CREATE TABLE products (
	product_id INT identity(1,1) PRIMARY KEY,
	name VARCHAR(256) NOT NULL,
	description TEXT NOT NULL,
	price NUMERIC (4,2) NOT NULL,
	image_name VARCHAR(128) NOT NULL
);

CREATE TABLE orders (
	order_id INT identity(1,1) PRIMARY KEY,
	customer_name VARCHAR(128) NOT NULL,
	street_address1 VARCHAR(128) NOT NULL,
	street_address2 VARCHAR(128),
	city VARCHAR(64) NOT NULL,
	state CHAR(2) NOT NULL,
	zip_code CHAR(5) NOT NULL
);

CREATE TABLE order_items (
	order_id INT NOT NULL,
	product_id INT NOT NULL,
	quantity INT NOT NULL,
	CONSTRAINT fk_order_item_order_id FOREIGN KEY(order_id) REFERENCES orders(order_id),
	CONSTRAINT fk_order_item_product_id FOREIGN KEY(product_id) REFERENCES products(product_id)
);

INSERT INTO products(name, description, price, image_name)
VALUES ('Coffee Mug', 'Staying up late to take in the wonders of the solar system can make a geek a little sluggish in the morning. This awesome mug is just what you need to perk up in the morning with your caffeinatened beverage of choice!', 9.99, 'ssg_mug.png' );

INSERT INTO products(name, description, price, image_name)
VALUES ('SOLAR SYSTEM: A Visual Exploration of the Planets, Moons, and Other Heavenly Bodies that Orbit Our Sun', 'This beautiful book presents a new and fascinating way to experience our planetary neighborhood. With hundreds of stunning photographs and graphics, as well as fascinating text by the award-winning writer and broadcaster, Marcus Chown, Solar System takes us on a whirlwind tour of the planets, dwarf planets, moons and asteroids that orbit our sun.', 29.95, 'solarsystem_book.png' );

INSERT INTO products(name, description, price, image_name)
VALUES ('Geek T-Shirt', 'Get your geek on (literally!) in this stylish T-Shirt! 100% cotton, pre-shrunk, one size fits some.', 19.99, 'geek_tshirt.png' );

INSERT INTO products(name, description, price, image_name)
VALUES ('Celestial Buddies Sun Moon Earth Plush Set with Solar System Chart', 'Celestial Buddies is an original line of plush characters each personifying a celestial body occupying our heavens. Each character comes with a tag showing the actual object it personifies and some fun facts to give the toy educational value. This collection contains the 3 celestial buddies we are most aware of - the sun (9 inches), moon (5 inches) and Earth (6 inches). Also included is a chart of the Solar System, to help your child identify where the buddies are located in our universe.', 72.78, 'planet_toys.png' );