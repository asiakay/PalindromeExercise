using System;
using System.Linq;

namespace PalindromeExerciseTests

//    Make sure the PalindromeExerciseTests project file has PalindromeExercise added as a reference.
//→ Right click dependencies in PalindromeExerciseTests to check and add if need be

//Create a class named WordSmith in your PalindromeExercise project file.This is where you will eventually create your IsAPalindrome() method

//In your WordSmith class, you will create a method(IsAPalindrome) that will take a parameter of type string and return a value of type bool.  If the given input is a palindrome – return true, else return false. 

//Write you test method in the UnitTest1.cs file - located in the PalindromeExerciseTests project file

//Remove the [Fact] portion and replace it with:
//[Theory]
//[InlineData()] ← you will need to put some test data and expected result here.  

//For example [InlineData(“racecar”, true)]

{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //reversing the word
            var reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }
            //comparing the original with the reversed

            if (reversed == word)
            {
                return true;
            }
            else
            {
                return false;

            }


            //return whether they are the same or not
        }
    }
    
}
