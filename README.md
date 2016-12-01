# SecretRunner
SecretRunner takes one command-line argument (a number) and determines if the secret() function is additive [secret(x+y) = secret(x) + secret(y)], for all combinations x and y, where x and y are all prime numbers less than the number passed via the command-line argument.

# Description
The Secret() method is additive for all pairs of numbers whose sum is less than 1000. The program will only accept valid Int32 numbers greater than 3 and less than Int32.Max/2. All inputs greater than 3 and less than 504 have at least 2 primes less than itself for which each pair is less than 1000. Sums of primes greater than Int32.Max/2 could potentially exceed Int32.Max.

# Instructions
Build the SecretRunner project then run SecretRunner.exe from the command line with a parameter. 

Try to input values less than 4. The result will be a prompt to input a valid number.

Try values that cannot be parsed to Int32. The result will be a prompt to input a valid number.

Try values greater than 3 but less than 504. The result will be True.

Try values greater than greater than 503. The result will be False.

