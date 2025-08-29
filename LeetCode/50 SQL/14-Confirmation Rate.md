## Problem #14: Confirmation Rate

## LeetCode: [Confirmation Rate](https://leetcode.com/problems/confirmation-rate)

---

### Question  
Write a solution to find the confirmation rate of each user.  

---

### Approach 1: My Solution  

- For each row in **Signups**, the query runs **two or three correlated subqueries** on **Confirmations**.  
- That means: if there are `n` users, each one may trigger up to **3 separate scans** on the `Confirmations` table.  
- On large datasets, this can become **costly in terms of performance**.  

```sql
SELECT 
    Signups.user_id,
    ROUND(
        CAST(
            (SELECT COUNT(*) 
             FROM Confirmations C 
             WHERE C.user_id = Signups.user_id 
               AND C.action = 'confirmed') AS DECIMAL(10,2)
        ) /
        CASE 
            WHEN (SELECT COUNT(*) 
                  FROM Confirmations C1 
                  WHERE C1.user_id = Signups.user_id) = 0
            THEN 1
            ELSE (SELECT COUNT(*) 
                  FROM Confirmations C1 
                  WHERE C1.user_id = Signups.user_id)
        END,
    2) AS confirmation_rate
FROM Signups;

```

### Approach 2  

- Only **one join**, **one aggregation**, and **no repeated subqueries**.  
- This makes it more efficient and easier to read compared to Approach 1.  

```sql
SELECT
    s.user_id,
    ROUND(
        AVG(
            CASE 
                WHEN c.action = 'confirmed' THEN 1.00
                ELSE 0
            END
        ),
        2
    ) AS confirmation_rate
FROM Signups s
LEFT JOIN Confirmations c
    ON s.user_id = c.user_id
GROUP BY s.user_id;
```

Or We Can Do it Like this 

```sql
SELECT 
    s.user_id, 
    ROUND(AVG(IF(c.action = "confirmed", 1, 0)), 2) AS confirmation_rate
FROM Signups AS s
LEFT JOIN Confirmations AS c 
    ON s.user_id = c.user_id
GROUP BY s.user_id;
```
