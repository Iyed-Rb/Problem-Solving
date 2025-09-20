## Problem #17: Project Employees I

## LeetCode: [Average Selling Price](https://leetcode.com/problems/project-employees-i)

---

### Question  
Write an SQL query that reports the average experience years of all the employees for each project, rounded to 2 digits.

---

### Approach 1: Just a Simple Solution for this Problem 
```sql
select project_id, 
       ROUND(AVG(CAST(experience_years AS DECIMAL(10,2))), 2) as average_years
from Project P 
inner join Employee E On P.employee_id = E.employee_id
group by project_id
order by project_id;

```

