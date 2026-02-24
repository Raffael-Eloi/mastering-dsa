 Code Question 1:
 
 A new Amazon intern encountered e challergirg task. Currently, the intem has n integers. where the value of the ith element is represented by the array element values[i].
 
 The intern is curios to play with arrays and subsequences and thus asks you to join him. Given n integer, array values, and an integer k. the intem needs to find the maximum and minimum median overall subsequences length k. 
 
 Example: 
 
 Given n=3, values=[1,2,3], and k=2 
 
 subsequences of length k | median 
 [1,2] | 1 
 [1,3] | 1 
 [2, 3] | 2 
 
 Here. the maximum median present is 2 and the minimum median in the subsequence present is 1. 
 Function Description Complete the function medians in the editor below.
 medians has the following parameter(s): 
 - int values[n]: the value of integers 
- int k: the given integer 

Returns
- int[]: the maximum and minimum overall subsequences of length k in the form [maximum, median, minimum median].