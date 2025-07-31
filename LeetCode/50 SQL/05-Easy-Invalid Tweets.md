# 5. Invalid Tweets

LeetCode: https://leetcode.com/problems/invalid-tweets

## Question
Write a solution to find the IDs of the invalid tweets.  
A tweet is invalid if the number of characters in the content is strictly greater than 15.

## Solution
SELECT tweet_id 
FROM Tweets 
WHERE CHAR_LENGTH(content) > 15;
