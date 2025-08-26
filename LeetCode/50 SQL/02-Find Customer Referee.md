# 2. Customers Who Never Get Referred by ID = 2

LeetCode: https://leetcode.com/problems/customers-who-never-get-referred

## Question
Write an SQL query to find the names of customers who are either:
- not referred by anyone, or
- referred by someone with id ≠ 2.

## Solution

Approach 1: Using OR (My Solution)
Simple filtering for both conditions.
```sql
SELECT name
FROM Customer
WHERE referee_id != 2 OR referee_id IS NULL;
```

Approach 2: Using NOT IN
Useful when we want to exclude multiple values.
```sql
SELECT name
FROM Customer
WHERE referee_id NOT IN (2) OR referee_id IS NULL;
```