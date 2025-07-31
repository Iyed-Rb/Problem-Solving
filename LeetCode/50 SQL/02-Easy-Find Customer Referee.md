# 2. Customers Who Never Get Referred by ID = 2

LeetCode: https://leetcode.com/problems/customers-who-never-get-referred

## Question
Write an SQL query to find the names of customers who are either:
- not referred by anyone, or
- referred by someone with id ≠ 2.

## Solution

Approach 1: Using OR (Recommended)
Simple filtering for both conditions.
SELECT name
FROM Customer
WHERE referee_id != 2 OR referee_id IS NULL;

Approach 2: Using NOT IN
Avoids explicit OR by excluding referee_id = 2.
SELECT name
FROM Customer
WHERE referee_id NOT IN (2) OR referee_id IS NULL;