using System;
using System.Collections.Generic;
using System.IO;
/*
Problem:
Little Bob loves chocolates and goes to the store with a $N bill with $C being the price of each chocolate. 
In addition, the store offers a discount: for every M wrappers he gives the store, he’ll get one chocolate 
for free. How many chocolates does Bob get to eat?

STDIN:
The first line contains the number of test cases T (<=1000).
Each of the next T lines contains three integers N, C and M.

Written on March 23rd, 2014 by Ryan Bakken

Source:
https://www.hackerrank.com/challenges/chocolate-feast

*/
class Solution 
{
    static void Main(String[] args) 
    {
        //First block of code receives input from STDIN
        List<string> input = new List<string>();
      	string line;
      	while(!string.IsNullOrEmpty( line = Console.ReadLine()))
        {
        	input.Add(line);  
        }
      	
      	int T = Convert.ToInt32(input[0]);
      	char[] c = new char[]{' '};
      	string[][] delimArray = new string[T][];
      	for(int i = 1; i <= T; i++)
        {
          delimArray[i - 1] = input[i].Split(c);         	
        }
      
        //Iterates through delimArray to grab N, C, M from each input line.
      	int purchased, free, total, wrapper;
      	int N, C, M;
      	for(int i = 0; i < T; i++)
        {  
          	N = Convert.ToInt32(delimArray[i][0]);
          	C = Convert.ToInt32(delimArray[i][1]);
          	M = Convert.ToInt32(delimArray[i][2]);
          //before while loop finds the initial amount of free candy, and wrappers gained from the free candy.
      		purchased = N / C;
      		free = purchased / M;
          wrapper = purchased - (free * M) + free;
      		total = purchased + free;
          //while loop keeps redeeming wrappers gained from free candy until less than M (the amount of wrappers
          //for free candy), adding them to the total as it runs.
          	while (wrapper >= M)
            {
              free = wrapper/M;
              total += free;
              wrapper = wrapper - (M * free) + free;
            }
          //Outputs the amount of candy gained for each testcase.	
      		Console.WriteLine(total);
        }
    }
}