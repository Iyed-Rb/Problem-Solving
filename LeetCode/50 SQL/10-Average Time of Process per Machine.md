## Problem #7: Average Time of Process per Machine

LeetCode: https://leetcode.com/problems/average-time-of-process-per-machine

Question: Write a solution to find the average time each machine takes to complete a process

Approach 1 : Using Self Join
```sql
SELECT
    A1.machine_id,
    ROUND(AVG(A2.timestamp - A1.timestamp), 3) AS processing_time
FROM Activity A1
JOIN Activity A2
    ON A1.machine_id = A2.machine_id
    AND A1.process_id = A2.process_id
    AND A1.activity_type = 'start'
    AND A2.activity_type = 'end'
GROUP BY A1.machine_id;
```

Approach 2: 
```sql
SELECT
a.machine_id,
ROUND(
AVG(CASE WHEN a.activity_type = 'end' THEN a.timestamp END) -
AVG(CASE WHEN a.activity_type = 'start' THEN a.timestamp END), 3
) AS processing_time
FROM
activity a
GROUP BY
a.machine_id;
```