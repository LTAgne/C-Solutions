-- ##########################
-- PAIR EXERCISES
-- ##########################

-- Write queries to return the following:
-- Make the following changes in the "world" database.

-- 1. Add Superman's hometown, Smallville, Kansas to the city table. The 
-- countrycode is 'USA', and population of 45001. (Yes, I looked it up on 
-- Wikipedia.)

	INSERT INTO city(id, name, countrycode, district, population)
	VALUES (4080, 'Smallville', 'USA', 'Kansas', 45001);

-- 2. Add Kryptonese to the countrylanguage table. Kryptonese is spoken by 0.0001
-- percentage of the 'USA' population.

	-- ### POSTGRES ###
	INSERT INTO countrylanguage(countrycode, language, isofficial, percentage)
	VALUES ('USA', 'Kryptonese', false, 0.0001);

	-- ### SQL SERVER ###
	INSERT INTO countrylanguage(countrycode, language, isofficial, percentage)
	VALUES('USA', 'Kryptonese', 0, 0.0001);

-- 3. After heated debate, "Kryptonese" was renamed to "Krypto-babble", change 
-- the appropriate record accordingly.

	UPDATE countrylanguage
	SET language = 'Krypto-babble'
	WHERE language = 'Kryptonese';

-- 4. Set the US captial to Smallville, Kansas in the country table.

	UPDATE country
	SET capital = 4080
	WHERE code = 'USA';

-- 5. Delete Smallville, Kansas from the city table. (Did it succeed? Why?)

	DELETE FROM city
	WHERE id = 4080;

	-- This DELETE statement fails because the "capital" column of the country 
	-- table is a foreign key constraint

-- 6. Return the US captial to Washington.

	UPDATE country
	SET capital = 3813
	WHERE code = 'USA';

-- 7. Delete Smallville, Kansas from the city table. (Did it succeed? Why?)

	DELETE FROM city
	WHERE id = 4080;

	-- It works this time because there are no foreign key references to 
	-- this row

-- 8. Reverse the "is the official language" setting for all languages where the
-- country's year of independence is within the range of 1800 and 1972 
-- (exclusive). 
-- (590 rows affected)

	UPDATE countrylanguage
	SET isofficial = NOT isofficial
	WHERE countrycode IN 
	(
		SELECT code 
		FROM country
		WHERE indepyear BETWEEN 1801 AND 1971
	);

-- 9. Convert population so it is expressed in 1,000s for all cities. (Round to
-- the nearest integer value greater than 0.)
-- (4068 rows affected)

	UPDATE city
	SET population = ceiling(population / 1000)
	WHERE population > 0;

-- 10. Assuming a country's surfacearea is expressed in miles, convert it to 
-- meters for all countries where French is spoken by more than 20% of the 
-- population.
-- (7 rows affected)

	UPDATE country
	SET surfacearea = surfacearea * 1609.344
	WHERE code IN 
	(
		SELECT countrycode
		FROM countrylanguage
		WHERE language = 'French' AND percentage >= 20
	);

-- ##########################
-- INDIVIDUAL EXERCISES
-- ##########################

-- The following changes are applied to the "pagila" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

	INSERT INTO actor(first_name, last_name)
	VALUES ('HAMPTON', 'AVENUE');
	INSERT INTO actor(first_name, last_name)
	VALUES ('LISA', 'BYWAY');

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in 
-- ancient Greece", to the film table. The movie was released in 2008 in English. 
-- Since its an epic, the run length is 3hrs and 18mins. There are no special 
-- features, the film speaks for itself, and doesn't need any gimmicks.	

	INSERT INTO film(title, description, release_year, language_id, length)
	VALUES ('EUCLIDEAN PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1, 198);

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly 
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

	INSERT INTO film_actor(actor_id, film_id)
	VALUES (201, 1001);
	INSERT INTO film_actor(actor_id, film_id)
	VALUES (202, 1001);

-- 4. Add Mathmagical to the category table.

	INSERT INTO category(name)
	VALUES ('Mathmagical');

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI", 
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

	INSERT INTO film_category(film_id, category_id)
	VALUES (1001, 17);
	INSERT INTO film_category(film_id, category_id)
	VALUES (274, 17);
	INSERT INTO film_category(film_id, category_id)
	VALUES (494, 17);
	INSERT INTO film_category(film_id, category_id)
	VALUES (714, 17);
	INSERT INTO film_category(film_id, category_id)
	VALUES (996, 17);
	
-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films 
-- accordingly.
-- (5 rows affected)

	UPDATE film
	SET rating = 'G'
	WHERE code IN 
	(
		SELECT film_id 
		FROM film_category
		WHERE category_id = 17
	);
	
-- 7. Add a copy of "Euclidean PI" to all the stores.

	INSERT INTO inventory(film_id, store_id)
	VALUES (1001, 1);
	INSERT INTO inventory(film_id, store_id)
	VALUES (1001, 2);
	
-- 8. The Feds have stepped in and have impounded all copies of the pirated film, 
-- "Euclidean PI". The film has been seized from all stores, and needs to be 
-- deleted from the film table. Delete "Euclidean PI" from the film table. 
-- (Did it succeed? Why?)

	DELETE FROM film
	WHERE film_id = 1001;

	-- This DELETE statement fails because the "film_id" column of the film_actor 
	-- table is a foreign key constraint

-- 9. Delete Mathmagical from the category table. 
-- (Did it succeed? Why?)

	DELETE FROM category
	WHERE category_id = 17;

	-- This DELETE statement fails because the "category_id" column of the film_category 
	-- table is a foreign key constraint

-- 10. Delete all links to Mathmagical in the film_category tale. 
-- (Did it succeed? Why?)

	DELETE FROM film_category
	WHERE category_id = 17;

	-- THis DELETE statement succeeded since there were no comflicting constraints.
	-- All 5 rows added earlier were deleted.

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI". 
-- (Did either deletes succeed? Why?)

	DELETE FROM category
	WHERE category_id = 17;

	-- This DELETE succeeded since the category_id column constraint on file_category
	-- had been removed.

	DELETE FROM film
	WHERE film_id = 1001;

	-- This DELETE statement failed once again because the "film_id" column of 
	-- the film_actor table is a foreign key constraint.

-- 12. Check database metadata to determine all constraints of the film id, and 
-- describe any remaining adjustments needed before the film "Euclidean PI" can 
-- be removed from the film table.

	The film_category table has a foreign key constraint on film_id which may 
	prevent the film from being removed.
	The inventory table has a similar constraint on film_id, and may keep the
	film fron being deleted.
	So, "Euclidean PI" cannot be deleted from the film table until all 
	references to its film_id are gone from from both the film_category and 
	inventory tables.
