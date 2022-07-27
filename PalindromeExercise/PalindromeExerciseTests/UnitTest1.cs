using System;
using Xunit;
//-----------------------------------------------------------------
// UnitTesting Exercise
//
// Name: David Zientara
// Date: 7-26-2022
// Comments: An exercise in using unit testing, part two
// Made changes per the instructions
//----------------------------------------------------------------
namespace PalindromeExercise.Tests
{
    public class UnitTest1
    {
        // Made a decent sample of palindromes (true) and non-palindromes (false)
        //[Fact]
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("Hurple", false)]
        [InlineData("Flarble",false)]
        [InlineData("NoXinNixon",true)]
        [InlineData("repaper",true)]
        [InlineData("No X In NiXon", true)]
        [InlineData("This is not a palindrome",false)]
        [InlineData("A man a plaN a CaNaL PanaMa", true)]
        [InlineData("A man a plaN a CaNaL PanaMa!!", true)]
        [InlineData("A man a plaN a CaNaL PanaMa, blah blah blah", false)]
        [InlineData("Madam, I'm Adam", true)]


        public void PalindromeTest(string str, bool expected)
        {
            // Here is where we test IsAPalindrome:
            WordSmith Word = new WordSmith();
            var actual = Word.IsAPalindrome(str);
            Assert.Equal(expected,actual);
        }
        
    }
}
