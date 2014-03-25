using System;
using System.Collections.Generic;
using System.IO;
/*
Problem:
Calvin was driving his favorite vehicle on the 101 freeway. He noticed the check engine light was on and wants 
to service it immediately to avoid any risks. Luckily, a service lane runs parallel to the highway. The length 
of the highway and service lane is N units. The service lane constitutes of N segments of unit length, 
where each segment can have different widths. Calvin can enter into and exit from any segment. 
Let’s call the entry segment as index i and the exit segment as index j. Assume that the exit 
segment lies after the enter segment(j>i) and i ≥ 0.

Calvin has three types of vehicles - bike, car and truck, represented by 1, 2 and 3 respectively, 
also implying the width of the vehicle. We are given an array width[] of length N, where width[k] 
represents the width of kth segment of our service lane. It is guaranteed that while servicing he can pass 
through at most 1000 segments, including entry and exit segments.

    If width[k] is 1, only the bike can pass through kth segment.
    If width[k] is 2, the bike and car can pass through kth segment.
    If width[k] is 3, any of the bike, car or truck can pass through kth segment.

Given the entry and exit point of the Calvin’s vehicle in service lane, output the type of 
largest vehicle which can pass through the service lane (including the entry & exit segment)

STDIN:
The first line of input contains two integers - N & T, where N is the length of the freeway and T is the number 
of test cases. The next line has N space separated integers which represents the width array.

T test cases follow. Each test case containts two integers - i & j, where i is the index of segment through 
which Calvin enters the service lane and j is the index of the lane segment where he exits.

Author's Note: Been coding in C all semester, so my C# has gotten a little rusty, and am using these
challenges to work on my algorithms, and start using more C#.  I've found that languages get fuzzy
after you have used them for awhile.  Will probably revisit this one at a later date and see
if I can improve upon its implementation.

Written on March 24th, 2014 by Ryan Bakken

Source:
https://www.hackerrank.com/challenges/service-lane
*/

class Solution 
{
    static void Main(String[] args) 
    {
        //grabs first line from STDIN, splits, and put into varibales.
        string[] firstArg = new string[2];
        firstArg = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(firstArg[0]);
        int t = Convert.ToInt32(firstArg[1]);
        
        //grabs second line from STDIN, splits, and puts into array.
        string[] secondArg = new string[n];
        int[] highway = new int[n];
        secondArg = Console.ReadLine().Split(' ');
        for(int i = 0; i < n; i++)
        {
          highway[i] = Convert.ToInt32(secondArg[i]);
        }
        
        //grabs subsequent T lines, and puts into a temporary array.
        string[][] thirdArg = new string[t][];
        int[,] ijArray = new int[t,2];
        int temp = 0;
        int temp2 = 0;
        //converts to proper data type, and stores into multi-dim array for each line of input
        for(int k = 0; k < t; k++)
        {
          thirdArg[k] = Console.ReadLine().Split(' ');
          temp = Convert.ToInt32(thirdArg[k][0]);
          temp2 = Convert.ToInt32(thirdArg[k][1]);
          ijArray[k, 0] = temp;
          ijArray[k, 1] = temp2;
        }
      
        int minVal = 3;
        int indexOfI = 0;
        int indexOfJ = 0;
        //iterates through each testcase, assigning values of I and J (indices for hwy array).
        for(int l = 0; l < t; l++)
        {
          indexOfI = ijArray[l,0];
          indexOfJ = ijArray[l,1];
          minVal = 3;
          //finds min value between indices in highway array specified by argument from STDIN, prints minVal    
          for(int p = indexOfI, q = indexOfJ; p <= q; p++)
          {
            if(minVal > highway[p])
                minVal = highway[p];                
          } 
          Console.WriteLine(minVal);
        }
    }
}