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

-- Approach 2: Using INNER JOIN(show this to know that wecan reverse it)
```sql
SELECT W1.id AS id
FROM Weather W2
INNER JOIN Weather W1
  ON W1.recordDate = DATEADD(DAY, 1, W2.recordDate)
WHERE W1.temperature > W2.temperature;
```

-- Approach 3: Using DATEDIFF (Alternative for SQL Server)
```sql
SELECT W2.id AS id
FROM Weather W1
INNER JOIN Weather W2
  ON DATEDIFF(DAY, W1.recordDate, W2.recordDate) = 1
WHERE W2.temperature > W1.temperature;
```

-- Approach 4: Using Correlated Subquery (Works in most databases including MySQL)
```sql
SELECT W2.id
FROM Weather W2
WHERE W2.temperature > (
    SELECT W1.temperature
    FROM Weather W1
    WHERE W1.recordDate = DATE_SUB(W2.recordDate, INTERVAL 1 DAY)
);
```
