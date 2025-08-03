# 7. Product Sales Analysis I

LeetCode: https://leetcode.com/problems/product-sales-analysis-i

## Question
Write a solution to report the product_name, year, and price for each sale_id in the Sales table.

## Solution
```sql
-- Approach 1: Using INNER JOIN (Recommended)
-- Efficient and clean because it directly joins the two tables based on product_id.
SELECT product_name, year, price
FROM Sales
INNER JOIN Product
  ON Sales.product_id = Product.product_id;
```

-- Approach 2: Using Subquery
-- Uses a correlated subquery to fetch the product name for each sale. Less efficient but valid.
```sql
SELECT 
    (SELECT product_name 
     FROM Product 
     WHERE Product.product_id = Sales.product_id) AS product_name,
    year,
    price
FROM Sales;
```
