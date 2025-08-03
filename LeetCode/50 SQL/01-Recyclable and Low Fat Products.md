# 1. Find Products with Low Fat and Recyclable

LeetCode: https://leetcode.com/problems/find-products-with-low-fat-and-recyclable

## Question
Write an SQL query to find the ids of products that are both low fat and recyclable.

## Solution

Approach 1: Simple WHERE Filter (Recommended)
```sql
SELECT product_id
FROM Products
WHERE low_fats = 'Y' AND recyclable = 'Y';
```

Approach 2: Using CASE in WHERE Clause
Not necessary but demonstrates conditional filtering.
```sql
SELECT product_id
FROM Products
WHERE CASE WHEN low_fats = 'Y' AND recyclable = 'Y' THEN 1 ELSE 0 END = 1;
```