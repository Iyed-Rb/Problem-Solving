## Problem #15: Not Boring Movies

## LeetCode: [Confirmation Rate](https://leetcode.com/problems/not-boring-movies)

---

### Question  
Write a solution to report the movies with an odd-numbered ID and a description that is not "boring".

---

### Approach 1: Just a simpple Problem

```sql
select * from Cinema where id % 2 != 0 and description != 'boring'
ORDER BY rating DESC;
```
