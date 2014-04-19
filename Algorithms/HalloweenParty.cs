using System;
using System.Collections.Generic;
using System.IO;
/*
Problem:
Alex is attending a Halloween party with his girlfriend Silvia. 
At the party, Silvia spots a giant chocolate bar. If the chocolate 
can be served as only 1 x 1 sized pieces and Alex can cut the chocolate 
bar exactly K times, what is the maximum number of chocolate pieces 
Alex can cut and give Silvia?

Input Format
The first line contains an integer T denoting the number of testcases. 
T lines follow. Each line contains an integer K.

Output Format
T lines. Each containing the output corresponding to the testcase.

Constraints
1<=T<=10
2<=K<=10^7

Author's note: Pretty simple algorithm; I did, however, fail to read the
constraints carefully enough, and upon running a test case, realized
an int wasn't going to be big enough if k got exceedingly large.

Written by Ryan Bakken on April 19th, 2014.
*/
class Solution
{
	static void Main(String[] args)
	{
		byte t = Convert.ToByte(Console.ReadLine());
		ulong k = 0;
		for(int i = 0; i < t; i++)
		{
			k = Convert.ToUInt32(Console.ReadLine());
			ulong hcuts, vcuts;
			if( k % 2 == 0)
			{
				hcuts = k / 2;
				vcuts = k / 2;
				Console.WriteLine("{0}", hcuts * vcuts);
			}
			else
			{
				hcuts = (k / 2) + 1;
				vcuts = k / 2;
				Console.WriteLine("{0}", hcuts * vcuts);
			}
		}
	}
}