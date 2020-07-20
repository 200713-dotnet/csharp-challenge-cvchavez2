using System;
using Xunit;

namespace Palindrome.Testing.Test
{
    public class TestPalindrome
    {
        [Fact]
        public void TestIsPalindrome()
        {
          var sut = new Palindrome();
          string s = "carlos";

          Assert.False(sut.IsPalindrome(s));
        }

        /*
        Following test cases assert string passed is a palindrome
        */
        [Theory]
        [InlineData("waaw")]
        [InlineData("abba")]
        [InlineData("deed")]
        public void TestIsPalindrome2(string s)
        {
          var sut = new Palindrome();

          Assert.True(sut.IsPalindrome(s));
        }

        /*
        Following test cases assert string passed is NOT a palindrome
        */
        [Theory]
        [InlineData("this is not a palindrome")]
        [InlineData("hellow guys")]
        [InlineData("NOT A PALINDROME!")]
        public void TestIsPalindrome3(string s)
        {
          var sut = new Palindrome();

          Assert.False(sut.IsPalindrome(s));
        }

        /*
        Following test cases handle special characters
        All input are palindromes, method assert input is a palindrome (true)
        */
        [Theory]
        [InlineData("w**w")]
        [InlineData("-bb-")]
        [InlineData("?aa?")]
        public void TestIsPalindrome2(string s)
        {
          var sut = new Palindrome();

          Assert.True(sut.IsPalindrome(s));
        }
    }
}