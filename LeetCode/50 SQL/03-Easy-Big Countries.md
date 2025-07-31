# 3. Big Countries

LeetCode: https://leetcode.com/problems/big-countries

## Question
Write an SQL query to find the name, population, and area of countries that are considered big.  
A country is big if:
- its area is at least 3,000,000, or
- its population is at least 25,000,000.

## Solution

Approach 1: Simple OR Filter (Recommended)
SELECT name, population, area
FROM World
WHERE area >= 3000000 OR population >= 25000000;

Approach 2: Using UNION
Separate both conditions and combine the results.
SELECT name, population, area
FROM World
WHERE area >= 3000000
UNION
SELECT name, population, area
FROM World
WHERE population >= 25000000;

Approach 3: Using CASE in WHERE
A less common approach but works.
SELECT name, population, area
FROM World
WHERE CASE 
          WHEN area >= 3000000 OR population >= 25000000 THEN 1 
          ELSE 0 
      END = 1;
