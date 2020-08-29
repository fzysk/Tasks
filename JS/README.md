2 tasks from JavaScript:

* Optional Power   
    Write a function in JS optionalPow that will receive two numeric arguments. The function is required to create some confirmation logic, where if the user agrees with the question (presses OK), then the function is required to compute the result of raising the first argument to the power determined by the second argument. If the user does not agree with the question (presses Cancel), then it should compute the power of the second argument raised to the first one. In both cases, the function must return the computed value.

    For example, *optionalPow*(2, 3) should return 8 if OK is pressed, otherwise it should return 9.

    The solution should be written in the following format:
    > function optionalPow(a, b) {   
    > //your code here   
    > }

* Fix age   
    Write a function in JS fixage that receives an array of integers. The integers represent ages between 0 and 100. The function is required to join all the integers that are between 18 and 60 into a string separated with a comma and returns it. If there is no integer between 18 and 60, then the function returns "NA".

    For example:
    > fixage([5,15,25,78,59,45]) returns 25,59,45   
    > fixage([18,3,30,22,11,60]) returns 18,30,22,60   
    > fixage([1,3,3,2,11,6]) returns NA