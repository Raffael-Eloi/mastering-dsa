question 2:

Yo're the on-call SDE for a serverless production stack. The architecture 
includes n AWS Lambda functions. and each function i currently has a reserved- 
concurrency limit of conc[i]. Because burst load on one function can starve 
others, your principal engineer asks that every function end up with a distinct 
corcurrency limit.
• In one operation you may raise function i's limit exactly 1. incurring a cost 
of price[i] (the cost reflects additional provisioned-concurrency dollars).

Examples:
n=5
conc = [5,2,5,3,3]
price = [3,7,8,6,9]
An optimal sequence:
- bumb function 0 (conc[0]) from 5 -> 6 (cost 3).
- bumb function 3 (conc[3]) from 3 -> 4 (cost 6).

The final limits [6,2,5,4,3] are all different; total cost = 3+6=9, which is minimal.