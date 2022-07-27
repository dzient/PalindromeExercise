using System;

//-----------------------------------------------------------------
// UnitTesting Exercise
//
// Name: David Zientara
// Date: 7-26-2022
// Comments: An exercise in using unit testing, part two
// Made changes per the instructions
//-----------------------------------------------------------------

namespace PalindromeExercise
{
    public class WordSmith
    {
        // IsAPalindrome
        // Given a string, return true if it's a palindrome
        // PARAMS: str (string)
        // RETURNS: true if it's a palindrome, false otherwise
        //If string length equals two and the start is equal to the end,
        public bool IsAPalindrome(string str)
        {
            //We're using recursion to find out - inefficient, but reliable
            String strcopy = "";
            //Base cases:
            // string is null (false)
            // string length is zero (false)
            // string length is one (true)
            if (str == null) return false;
            if (str.Length == 0) return false;
            if (str.Length == 1) return true;
            //Make a copy which eliminates all but letters:
            foreach (char ch in str)
                if (char.IsLetter(ch))
                    strcopy += ch;
            //Return false if start character and end character are not equal
            if (char.ToLower(strcopy[0]) != char.ToLower(strcopy[strcopy.Length - 1])) 
                return false;
            //If string length equals two, there's nothing left; return true
            if (strcopy.Length == 2) return true;
            // Otherwise, remove the end character 
            strcopy = strcopy.Remove(strcopy.Length - 1, 1);
            //If string length equals two and the start is equal to the end,
            
            // The substring is 1 to Length - 1
            // E.g. racecar -> raceca -> substring = aceca
            // Recursively call the function
            return IsAPalindrome(strcopy.Substring(1, strcopy.Length-1));
        }
    }
}