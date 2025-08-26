# 6. Employees Unique ID

LeetCode: https://leetcode.com/problems/employees-unique-id

## Question
Write a solution to show the unique ID of each user.  
If a user does not have a unique ID, show null instead.

## Solution

Approach 1: Using LEFT JOIN (My Solution) / Or we can Use Right Join but Reverse
Returns all employees, and for those who don't have a unique ID, shows null.
```sql
SELECT unique_id, name 
FROM Employees 
LEFT JOIN EmployeeUNI 
  ON Employees.id = EmployeeUNI.id;
```

Approach 2: Using Subquery with SELECT
Uses a correlated subquery to fetch the unique ID for each employee.
```sql
SELECT 
    (SELECT unique_id 
     FROM EmployeeUNI 
     WHERE EmployeeUNI.id = Employees.id) AS unique_id,
    name
FROM Employees;
```
