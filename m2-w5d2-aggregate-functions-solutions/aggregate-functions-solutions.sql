-- The following queries utilize the "world" database.
-- Write queries for the following problems. 
-- Notes:
--   GNP is expressed in units of one million US Dollars
--   The value immediately after the problem statement is the expected number 
--   of rows that should be returned by the query.

-- 1. The name and state plus population of all cities in states that border Ohio 
-- (i.e. cities located in Pennsylvania, West Virginia, Kentucky, Indiana, and 
-- Michigan).  
-- The name and state should be returned as a single column called 
-- name_and_state and should contain values such as ‘Detroit, Michigan’.  
-- The results should be ordered alphabetically by state name and then by city 
-- name. 
-- (19 rows)

-- PostgreSQL
	SELECT (name || ', ' || district) AS name_and_state
	FROM city 
	WHERE district='Pennsylvania' OR district='West Virginia' OR district='Kentucky' OR district='Indiana' OR district='Michigan' 
	ORDER BY district, name;

-- SQL Server
	SELECT (name + ', ' + district) AS name_and_state 
	FROM city 
	WHERE district='Pennsylvania' OR district='West Virginia' OR district='Kentucky' OR district='Indiana' OR district='Michigan' 
	ORDER BY district, name;

-- 2. The name, country code, and region of all countries in Africa.  The name and
-- country code should be returned as a single column named country_and_code 
-- and should contain values such as ‘Angola (AGO)’ 
-- (58 rows)

-- PostgreSQL
	SELECT (name || ' (' || code || ')') AS country_and_code
	FROM country 
	WHERE continent = 'Africa'
	ORDER BY name, code;

-- SQL Server
	SELECT (name + ' (' + code + ')') AS country_and_code
	FROM country 
	WHERE continent = 'Africa'
	ORDER BY name, code;

-- 3. The per capita GNP (i.e. GNP mulitplied by 1000000 then divided by population) of all countries in the 
-- world sorted from highest to lowest. Recall: GNP is expressed in units of one million US Dollars 
-- (highest per captia GNP in world: 37459.26)

	SELECT ((gnp * 1000000) / population) AS per_capita_gnp, name 
	FROM country 
	WHERE population != 0 
	ORDER BY per_capita_gnp DESC;

-- 4. The average life expectancy of countries in South America.
-- (average life expectancy in South America: 70.9461)

	SELECT AVG(lifeexpectancy) AS avg_life_expectancy
	FROM country 
	WHERE continent = 'South America';
	
-- 5. The sum of the population of all cities in California.
-- (total population of all cities in California: 16716706)

	SELECT SUM(population) AS total_population
	FROM city 
	WHERE countrycode = 'USA' AND district='California';
	
-- 6. The sum of the population of all cities in China.
-- (totol population of all cities in China: 175953614)

	SELECT SUM(population) AS total_population
	FROM city 
	WHERE countrycode = 'CHN';

-- 7. The maximum population of all countries in the world.
-- (total population of all countries in world: 1277558000)

	SELECT MAX(population) AS largest_country_population
	FROM country;

-- 8. The maximum population of all cities in the world.
-- (largest city population in world: 10500000)

	SELECT MAX(population) AS largest_city_population
	FROM city;

-- 9. The maximum population of all cities in Australia.
-- (largest city population in Australia: 3276207)

	SELECT MAX(population) AS largest_australia_population
	FROM city
	WHERE countrycode='AUS';

-- 10. The minimum population of all countries in the world.
-- (smallest_country_population in world: 50)

	SELECT MIN(population) AS smallest_country_population
	FROM country
	WHERE population != 0;

-- 11. The average population of cities in the United States.
-- (avgerage city population in USA: 286955.3795)

	SELECT AVG(population) AS avg_usa_population
	FROM city
	WHERE countrycode = 'USA';
	 
-- 12. The average population of cities in China.
-- (average city population in China: 484720.6997 approx.)

	SELECT AVG(population) AS avg_china_population
	FROM city
	WHERE countrycode = 'CHN';

-- 13. The surface area of each continent ordered from highest to lowest.
-- (largest continental surface area: 31881000, "Asia")

	SELECT SUM(surfacearea) AS total_surfacearea, continent
	FROM country
	GROUP BY continent
	ORDER BY total_surfacearea DESC;
	
-- 14. The highest population density (population divided by surface area) of all 
-- countries in the world. 
-- (highest population density in world: 26277.7777)

	SELECT MAX(population / surfacearea) AS population_density
	FROM country
	WHERE population != 0;
	
-- 15. The population density and life expectancy of the top ten countries with the 
-- highest life expectancies in descending order. 
-- (highest life expectancies in world: 83.5, 166.6666, "Andorra")

	SELECT lifeexpectancy, (population / surfacearea) AS population_density, name
	FROM country
	WHERE population != 0 AND lifeexpectancy IS NOT NULL
	ORDER BY lifeexpectancy DESC
	LIMIT 10;

-- 16. The difference between the previous and current GNP of all the countries in 
-- the world ordered by the absolute value of the difference. Display both 
-- difference and absolute difference.
-- (smallest difference: 1.00, 1.00, "Ecuador")

	SELECT (gnp - gnpold) AS difference, ABS(gnp - gnpold) AS abs_difference, name
	FROM country
	ORDER BY abs_difference;
	
-- 17. The average population of cities in each country (hint: use city.countrycode)
-- ordered from highest to lowest.
-- (highest avg population: 4017733.0000, "SGP")

	SELECT AVG(population) AS avg_population, countrycode
	FROM city
	GROUP BY countrycode
	ORDER BY avg_population DESC;
	
-- 18. The count of cities in each state in the USA, ordered by state name.
-- (45 rows)

	SELECT COUNT(name), district
	FROM city
	WHERE countrycode = 'USA'
	GROUP BY district
	ORDER BY district;
	
-- 19. The count of countries on each continent, ordered from highest to lowest.
-- (highest count: 58, "Africa")

	SELECT COUNT(name) as count_countries, continent
	FROM country
	GROUP BY continent
	ORDER BY count_countries DESC;
	
-- 20. The count of cities in each country ordered from highest to lowest.
-- (largest number of  cities ib a country: 363, "CHN")

	SELECT COUNT(name) AS city_count, countrycode
	FROM city
	GROUP BY countrycode
	ORDER BY city_count DESC;
	
-- 21. The population of the largest city in each country ordered from highest to 
-- lowest.
-- (largest city population in world: 10500000, "IND")

	SELECT MAX(population) AS city_population, countrycode
	FROM city
	GROUP BY countrycode
	ORDER BY city_population DESC;

-- 22. The average, minimum, and maximum non-null life expectancy of each continent 
-- ordered from lowest to highest average life expectancy. 
-- (lowest average life expectancy: 52.5719, 37.2, 76.8, "Africa")

	SELECT AVG(lifeexpectancy) AS avg_lifeexpectancy, MIN(lifeexpectancy) AS min_lifeexpectancy, MAX(lifeexpectancy) AS max_lifeexpectancy, continent
	FROM country
	WHERE lifeexpectancy IS NOT NULL
	GROUP BY continent
	ORDER BY avg_lifeexpectancy
