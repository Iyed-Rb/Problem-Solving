# 9. Rising Temperature

LeetCode: https://leetcode.com/problems/rising-temperature

## Question
Write a solution to find all dates' `id` where the temperature is higher than the previous day.

## Solution
-- Approach 1: Using INNER JOIN (Recommended for SQL Server)
```sql
select W2.id as Id from Weather W1 Inner Join Weather W2
On W2.recordDate = DATEADD(DAY, 1, W1.recordDate) 
where W2.temperature > W1.temperature
```

-- Approach 2: Using Correlated Subquery
```sql
SELECT W2.id
FROM Weather W2
WHERE W2.temperature > (
    SELECT W1.temperature
    FROM Weather W1
    WHERE W1.recordDate = DATE_SUB(W2.recordDate, INTERVAL 1 DAY)
);
```
