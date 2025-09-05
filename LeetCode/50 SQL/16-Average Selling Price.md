## Problem #16: Average Selling Price

## LeetCode: [Average Selling Price](https://leetcode.com/problems/Average-Selling-Price)

---

### Question  
Write a solution to find the average selling price for each product

---

### Approach 1: Using Correlated Subquery  
in the First attemps i Used Two separate Correlated Subqueries  
One for the **price * units** Then Divide By the **Total Units**  
But i realised That i can directly do this in only one correlated Subquery  
Instead of Two
```sql
SELECT P.product_id,
       ROUND(
         COALESCE(
           (
             SELECT SUM(price * units) * 1.0 / SUM(units)
             FROM Prices 
             Inner JOIN UnitsSold
               ON Prices.product_id = UnitsSold.product_id
              AND purchase_date BETWEEN start_date AND end_date
             WHERE Prices.product_id = P.product_id
           ), 
           0
         ), 2
       ) AS average_price
FROM Prices P
GROUP BY P.product_id;
```

### Approach 2: Without correlated Subquery (Recommended)  
Only one pass: the query scans Prices and joins with UnitsSold just once   
Instead of running a subquery for every row   
 
```sql
SELECT Prices.product_id,
       COALESCE(
         ROUND(SUM(price * units) * 1.0 / SUM(units), 2),
         0
       ) AS average_price
FROM Prices
Left JOIN UnitsSold
  ON Prices.product_id = UnitsSold.product_id
  AND purchase_date BETWEEN start_date AND end_date
GROUP BY Prices.product_id;
```

### Approach 3: Using CTE (Common Table Expression)
just cleaner and more Readable
 
```sql
WITH Revenue AS (
    SELECT 
        P.product_id,
        SUM(P.price * U.units) AS total_revenue,
        SUM(U.units) AS total_units
    FROM Prices P
    LEFT JOIN UnitsSold U
      ON P.product_id = U.product_id
     AND U.purchase_date BETWEEN P.start_date AND P.end_date
    GROUP BY P.product_id
)
SELECT 
    product_id,
    COALESCE(ROUND(total_revenue * 1.0 / total_units, 2), 0) AS average_price
FROM Revenue;

```





