

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

/*
Not end  end with vowels. In this case, ^ stands for begins with, $ stands for till the end
*/
select distinct CITY FROM STATION
WHERE CITY not REGEXP '[aeiou]$'

/*
.any single character   *zero or more instance of string preceding it
*/
select distinct city from station
where city
not regexp  '^[aeiou].*[aeiouAEIOU]$'

/*
Query the list of CITY names from STATION that do not start with vowels and do not end with vowels. Your result cannot contain duplicates
*/
select distinct city from station
WHERE lower(substr(CITY,1,1)) not in ('a','e','i','o','u') 
                   and LOWER(RIGHT(city,1)) not IN ('a', 'e', 'i', 'o', 'u')

/*
Query the Name of any student in STUDENTS who scored higher than  Marks. Order your output by the last three characters of each name. If two or more students both have names ending in the same last three characters (i.e.: Bobby, Robby, etc.), secondary sort them by ascending ID.
*/
select name from students
where Marks>75
ORDER BY RIGHT(NAME,3) ASC, ID ASC

/*Advanced Select
Write a query identifying the type of each record in the TRIANGLES table using its three side lengths. Output one of the following statements for each record in the table:
•Equilateral: It's a triangle with  sides of equal length.
•Isosceles: It's a triangle with  sides of equal length.
•Scalene: It's a triangle with  sides of differing lengths.
•Not A Triangle: The given values of A, B, and C don't form a triangle

*/
SELECT
    CASE
    WHEN A+B<=C OR A+C<=B OR B+C<=A THEN "Not A Triangle"
    WHEN A = B and B = C THEN 'Equilateral'
    WHEN A = B or A = C or B = C THEN 'Isosceles'
    WHEN A <> B and B <> C THEN 'Scalene'
    end tuple
from TRIANGLES

select CONCAT(NAME,'(',SUBSTR(Occupation,1,1),')')from occupations order by name;
select CONCAT('There are a total of ',count(Occupation),' ',lower(Occupation),(if (count(Occupation)>1,'s.','.'))) from Occupations group by Occupation order by count(Occupation), Occupation;

(
  SELECT CONCAT(NAME, '(', SUBSTRING(OCCUPATION, 1, 1), ')') as THETEXT
    FROM OCCUPATIONS
)
UNION ALL 
(
  SELECT CONCAT('There are total ', COUNT(*),' ', lower(OCCUPATION), (IF (COUNT(*) > 1, 's',''))) as THETEXT
   FROM OCCUPATIONS GROUP BY OCCUPATION
)
ORDER BY THETEXT ASC;
                                                                      
     