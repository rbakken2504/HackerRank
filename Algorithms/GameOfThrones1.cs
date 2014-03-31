using System;
using System.Collections.Generic;
using System.IO;
/*
Problem: 
King Robert has 7 kingdoms under his rule. He gets to know from Raven that the Dothraki are to wage a war 
against him soon. But, he knows the Dothraki need to cross the narrow river to enter his dynasty. There is 
only one bridge that connects both sides of the river which is sealed by a huge door.

The king wants to lock the door so that the Dothraki can’t enter. But, to lock the door you need a key that 
is an anagram of a certain palindrome string.

The king has a list of words. For each given word, can you help the king in figuring out if any anagram of it 
can be a palindrome or not?. 

STDIN:
A single line which will contain the input string.

Constraints:
1<= length of string <= 10^5

Coded by Ryan Bakken on March 29th, 2014

Source:
https://www.hackerrank.com/challenges/game-of-thrones
*/

class Solution 
{
    static void Main(String[] args) 
    {
        //increases 254 char limit of Console.ReadLine()
        Console.SetIn(new StreamReader(Console.OpenStandardInput(10000)));
    	string input = Console.ReadLine();
      	char[] charArray = input.ToCharArray();
    	bool check = PalinCheck(charArray);
    	if (check == true)
    		Console.WriteLine("YES");
    	else
    		Console.WriteLine("NO");
    }
    public static bool PalinCheck(char[] a)
    {
    	int matches = 0;
    	int aLen = a.Length;
      	bool allowNotFound = aLen % 2 == 1; 
    	//nested loop checks for matching letters, and removes if match is found
    	//breaks inner loop to start at new index, and counts the matches found.
        //Also breaks when no match is found for even length, or no match 2x for odd length.
    	for(int i = 0; i < aLen - 1; i++)
    	{
          	while (a[i] == ' ' && i < aLen - 1) i++;
            if ( i == aLen - 1) break;
            bool found = false;  
    		for(int k = i + 1; k < aLen; k++)
    		{
    			if(a[i] == a[k] && a[i] != ' ' && a[k] != ' ')
    			{
                    found = true;
    				matches++;
    				a[k] = ' ';
    				break;
    			}
    		}
            if (!found)
            {
                if(allowNotFound)
                    allowNotFound = false;
                else
                    return false;
            }
              
    	}
    	/*if a string is of even number length, then it must have the "length" number of matches
		to be a palindrome.  If the string is odd, it must have "length - 1" matches.
    	*/
    	if ( matches == aLen / 2 )
    		return true;
    	else
    		return false;
    }

}