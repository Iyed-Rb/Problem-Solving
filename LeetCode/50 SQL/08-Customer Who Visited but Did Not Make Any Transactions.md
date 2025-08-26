# 8. Customer Who Visited but Did Not Make Any Transactions

LeetCode: https://leetcode.com/problems/customer-who-visited-but-did-not-make-any-transactions

## Question
Write a solution to find the IDs of the users who visited without making any transactions and the number of times they made these types of visits.

## Solution
```sql
-- Approach 1: Using LEFT JOIN (My Solution)
SELECT V.customer_id, COUNT(*) AS count_no_trans
FROM Visits V
LEFT JOIN Transactions T
  ON V.visit_id = T.visit_id
WHERE T.visit_id IS NULL
GROUP BY V.customer_id;
```

-- Approach 2: Using NOT IN
-- Alternative way using a subquery instead of a join.
```sql
SELECT customer_id, COUNT(*) AS count_no_trans
FROM Visits
WHERE visit_id NOT IN (SELECT visit_id FROM Transactions)
GROUP BY customer_id;
```
