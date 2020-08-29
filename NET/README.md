7 tasks from C#:

* Reverse Array   
    Write a program that takes an array of size N as input and gives the output as an array in the reverse order. The format of the input is as follow:

    > N    
    > a1 a2 a3 a4 a5 … an

    'N' is the size of the array and a1, a2, a3, … an, are its elements. Your program should give output (on the same line and separated by a space) as follows:

    > an an-1 an-2 … a1

* Palindrome   
    Write a program that takes a string as input and prints whether this string is a true palindrome or not. A true palindrome is a string such that if you remove all characters except for letters (uppercase and lowercase), the string is equal if read from left to right and from right to left. If the inputted string is a true palindrome, the message YES (uppercase required) is displayed else NO is displayed.

    Notice that lowercase letters are equal to uppercase letters and vice-versa.

* Permutation   
    Write a program that takes two 11 integer array elements (one input per line) and gives output YES, if there's a permutation of the first array that is equal to the second array or gives output NO, if there's no such permutation.

    Example #1:
    > For input provided as follows:   
    > 1 2 5 3 7 0 7 3 5 2 1   
    > 7 3 1 2 5 0 5 2 1 3 7   
    >
    > Output of the program will be:   
    > YES

    Example #2:
    > For the input provided as follows:   
    > 1 2 3 4 5 6 7 8 9 10 11   
    > 6 5 4 3 2 0 11 10 9 8 7   
    >
    > Output of the program will be:   
    > NO

* Existing powers of 2   
    You will be given a variable list of unknown length, containing 32-bits unsigned integers. You are required to give as output, a comma separated list in the increasing order, showing those powers of 2 that appear at least once, in the powers of 2 decomposition of the integers from the list. If no powers of 2 are present, you should give as output "NA", without quotes. For example, if the list is 1, 3, 4, you are expected to give as output 1, 2 and 4. Integers in the list will be entered one per line.

    Example #1:
    > For the input provided as follows:   
    > 1   
    > 3   
    > 4   
    > 
    > Output of the program will be:   
    > 1, 2, 4

    Example #2:
    > For the input provided as follows:   
    > 3   
    > 1   
    > 2   
    >
    > Output of the program will be:   
    > 1, 2

* Finding primes   
    Given are two integers m, n (1 <= m <= n <= 10^9, n – m <= 10^5). You have to report the number of prime numbers within the interval [m, n]. First line of the input contains an integer T, denoting the test cases you have to handle. T lines follow, each one with two integers m, n as stated above. For each test case, output a single line, containing the requested report.

    Example #1:
    > For the input provided as follows:   
    > 1   
    > 1 10   
    > 
    > Output of the program will be:   
    > 4

    Example #2:
    > For the input provided as follows:   
    > 2   
    > 100 200    
    > 1 1   
    >
    > Output of the program will be:   
    > 21   
    > 0   

* Common Digit   
    Write a program that takes an integer N (N between 2 and 20 inclusive), and an array of N integers as input. Your program should output the most occurring digit that appears in the numbers of this array. If more than one digit satisfies this condition, output the bigger one.

    Note: The integer N will be given in the first line, and the array of N integers will be given in the second line. Each integer will be separated by a single space character ' '.
    
    Example #1:
    > For the input provided as follows:    
    > 4   
    > 101 20 21 3   
    > 
    > Output of the program will be:   
    > 1

    Example #2:
    > For the input provided as follows:   
    > 3   
    > 111 222 5   
    >
    > Output of the program will be:   
    > 2

* Digit Sum   
    Write a program that takes an integer N and an array of N positive integers as input. Your program should output the position (0-based) of the array in which the value in that position has the maximum digit sum possible. A digit sum of some value is the sum of its digits. If there's more than one position that satisfies this condition, print the greatest one.

    Note: The integer N will be given in the first line, and the array of N integers will be given in the second line (Each integer separated by a single space).

    Example #1:
    > For input given as:   
    > 3   
    > 2 4 3   
    > 
    > Output of the program will be:   
    > 1

    Example #2:
    > For input given as:   
    > 3   
    > 20 21 19   
    >
    > Output of the program will be:   
    > 2