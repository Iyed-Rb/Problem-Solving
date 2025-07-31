# 1. Find Products with Low Fat and Recyclable

LeetCode: https://leetcode.com/problems/find-products-with-low-fat-and-recyclable

## Question

Write an SQL query to find the ids of products that are both low fat and recyclable.

## Solution

```sql
SELECT product_id
FROM Products
WHERE low_fats = 'Y' AND recyclable = 'Y';
