
## Problem #13: Students and Examinations

**LeetCode:** [Students and Examinations](https://leetcode.com/problems/managers-with-at-least-5-direct-reports)

---

### Question  
Write a solution to find managers with at least five direct reports.
---

### Approach 1: My Solution (Not Recommended)

```sql
Select Employee.name from Employee right join (
select M.name from Employee M inner join Employee E
On M.id = E.managerID
group by M.name
having count(*) >= 5 ) S
On Employee.name = S.name
```

### Approach 2: Using Inner join

Note: i did this the first time, but i maked a mistake which is i did only  
GROUP BY M.name without M.id  
the Submition Failed because if two managers have the same name, they’ll be merged into one row
```sql
SELECT M.name
FROM Employee E
INNER JOIN Employee M ON E.managerID = M.id
GROUP BY M.id, M.name
HAVING COUNT(*) >= 5;
```

### Approach 3: 

```sql
SELECT M.name
FROM (
    SELECT managerId
    FROM Employee
    GROUP BY managerId
    HAVING COUNT(*) >= 5
) AS S
JOIN Employee M
    ON S.managerId = M.id;
```

### Approach 4: Using In 

```sql
SELECT name 
FROM Employee 
WHERE id IN (
    SELECT managerId 
    FROM Employee 
    GROUP BY managerId 
    HAVING COUNT(*) >= 5)
```
