

Query the list of CITY names starting with vowels (i.e., a, e, i, o, or u) from STATION. Your result cannot contain duplicates.



Input Format



The STATION table is described as follows:



where LAT_N is the northern latitude and LONG_W is the western longitude.

/*Wild card*/
SELECT DISTINCT CITY from STATION
where CITY LIKE '[aeiou]%';

/*
the WHERE will specify that we are asking for the CITY and the LIKE is asking for the condition matching ^ (which is the beginning of the string) and [aeiou] (which are the letters we are searching for at the beginning of the string). By using the single quotes around our regular expression, we are calling the string literals (or the values that match literally the data we want)
*/

 SELECT DISTINCT 
            CITY 
         FROM 
           STATION 
         WHERE CITY 
           REGEXP '^[aeiou]'

SELECT DISTINCT 
CITY 
FROM STATION 
WHERE lower(substr(CITY,1,1)) in ('a','e','i','o','u') ;
