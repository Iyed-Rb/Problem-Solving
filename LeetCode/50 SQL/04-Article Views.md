# 4. Find All Authors That Viewed Their Own Articles

LeetCode: https://leetcode.com/problems/find-all-authors-that-viewed-their-own-articles

## Question
Write an SQL query to find all the authors who viewed at least one of their own articles.
Return the result table sorted by `id` in ascending order.

## Solution

Approach 1: Using DISTINCT (My Solution)
Filters only self-views (author_id = viewer_id), removes duplicates, and sorts the result.
```sql
SELECT DISTINCT author_id AS id
FROM Views
WHERE author_id = viewer_id
ORDER BY author_id ASC;
```

Approach 2: Using EXISTS
Checks if at least one self-view exists for each author. DISTINCT is not required because EXISTS returns a boolean result.
```sql
SELECT v1.author_id AS id
FROM Views v1
WHERE EXISTS (
    SELECT 1
    FROM Views v2
    WHERE v1.author_id = v2.author_id 
      AND v2.author_id = v2.viewer_id
)
ORDER BY id ASC;
```

Approach 3: Using SELF JOIN
Joins the table with itself to match authors with their own views.
```sql
SELECT DISTINCT v1.author_id AS id
FROM Views v1
JOIN Views v2 
  ON v1.author_id = v2.author_id 
 WHERE v2.author_id = v2.viewer_id
ORDER BY id ASC;
```
