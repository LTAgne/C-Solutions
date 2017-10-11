CREATE TABLE customer
(
	custno int,
	cust_name varchar(200),
	cust_street varchar(200),
	cust_city varchar(200),
	cust_prov varchar(200),
	cust_postalcode varchar(10),
	cust_phone char(11),

	primary key (cust_name)
);

CREATE TABLE customer_art
(
	custno int,
	art_code int,
	purchase_date datetime,
	price money,

	primary key (custno, art_code, purchase_date)
);

CREATE TABLE art
(
	art_code int,
	art_title varchar(200),
	artist_id int
);

CREATE TABLE artist
(
	artist_id int,
	artist_firstname varchar(200),
	artist_lastname varchar(200),

	primary key (artist_id)
);

ALTER TABLE art
ADD FOREIGN  KEY (artist_id) REFERENCES artist(artist_id);