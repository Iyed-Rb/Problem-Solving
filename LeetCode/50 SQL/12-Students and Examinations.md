## Problem #12: Students and Examinations

**LeetCode:** [Students and Examinations](https://leetcode.com/problems/students-and-examinations)

---

### Question  
Write a solution to find the number of times each student attended each exam.

---

### Approach 1: Using Subquery  

We don’t need an outer table of `Examinations` here.  
We only use it inside the subquery to check if the exam is attended.  
`Students` and `Subjects` tables are enough to generate all cases via **CROSS JOIN**.  
```sql
select S.student_id, S.student_name, S1.subject_name,
 (select Count(*) from Examinations 
 where Examinations.student_id = S.student_id 
 and Examinations.subject_name = S1.subject_name ) 
 as attended_exams 
 from Students S cross join 
  Subjects S1 group by
   S.student_id, S.student_name, S1.subject_name 
   order by  S.student_id, S.student_name, S1.subject_name
```

### Approach 2: Without Subquery
Students and Subjects Tables Are Enough to generate all Cases via **Cross Join**.  
For each `(student, subject)` pair we attach matching Examinations rows.  
If there are matching exam rows, the LEFT JOIN produces `one output row` per matching exam.  
(so duplicates appear if a student has multiple exam records for the same subject).  
If there are no matches, the join produces a single row with all `e.* = NULL`.  
```sql
SELECT s.student_id, s.student_name, sub.subject_name, 
  COUNT(e.subject_name) AS attended_exams
  FROM 
    Students s CROSS JOIN 
    Subjects sub
LEFT JOIN 
    Examinations e
    ON s.student_id = e.student_id
   AND sub.subject_name = e.subject_name
GROUP BY 
    s.student_id, s.student_name, sub.subject_name
ORDER BY 
    s.student_id, sub.subject_name;
```
