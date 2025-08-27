## Problem #7: Employee Bonus

LeetCode: https://leetcode.com/problems/employee-bonus

Question: Write a solution to report the name and bonus amount of each employee with a bonus less than 1000.

Approach 1 : Just a simple Solution
```sql
select E.name, B.bonus from Employee E left join Bonus B
On E.empId = B.empId
where B.bonus < 1000 or B.bonus is null
```