# 2. Customers Who Never Get Referred by ID = 2

LeetCode: https://leetcode.com/problems/customers-who-never-get-referred

## Question

Write an SQL query to find the names of customers who are either:
- not referred by anyone, or
- referred by someone with id ≠ 2.

## Solution

```sql
SELECT name
FROM Customer
WHERE referee_id != 2 OR referee_id IS NULL;
