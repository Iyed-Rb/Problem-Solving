# 3. Big Countries

LeetCode: https://leetcode.com/problems/big-countries

## Question

Write an SQL query to find the name, population, and area of countries that are considered big.  
A country is big if:
- its area is at least 3,000,000, or
- its population is at least 25,000,000.

## Solution

```sql
SELECT name, population, area
FROM World
WHERE area >= 3000000 OR population >= 25000000;
