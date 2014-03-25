using System;
using System.Collections.Generic;
using System.IO;
/*
Practing algorithms, and trying to make them more efficient doing challenges on hackerrank.com.
Will revisit at a later date to improve upon this iteration, likely using C, or another language that I
want to get better at.

Written on March 23, 2014 by Ryan Bakken. 

Receives input from STDIN:
The first line of the input contains an integer T, the number of testcases.
T lines follow each line containing the integer N, indicating the number of cycles.

Algorithm takes a sapling of height 1m at the onset of the monsoon season, that grows in 2 cycles per yer; doubles 
in height during the monsoon season, and grows by 1 meter in the summer. Algorithm finds the height of the saplind
after N cycles.

For more info on the problem, visit:
https://www.hackerrank.com/challenges/utopian-tree
*/
class Solution 
{
    static void Main(String[] args) 
    {	
      	//List collects each line of input, converts, and puts into array
     	List<int> input = new List<int>();
      	string line;
      	int sapling = 1;
      	while(!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
        	input.Add(int.Parse(line));  
        }


        //First array index is T, rest are N's; Capitalized variables to be consistent with instructions.
      	int T = input[0];
      	int[] N = new int[T];
      	for(int i = 0; i < T; i++)
        {
           N[i] = input[i + 1];
        }
      	//Outer loop runs T times, prints result of inner loop, and resets sapling
      	for(int i = 0; i < T; i++)
        {
          sapling = 1;
          //Inner loop doubles sapling on even "j's", and adds one on odd "j's".
          for(int j = 0; j < N[i]; j++)
          {
            if(j % 2 == 0)
              sapling = sapling + sapling;
            else
              sapling = sapling + 1;
          }
          Console.WriteLine(sapling);
        }
    }