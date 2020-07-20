using System;
using Xunit;

namespace Palindrome.Testing.Test
{
    public class TestPalindrome
    {
        [Fact]
        public void TestIsPalindrome()
        {
          var sut = new Palind();
          string s = "carlos";

          Assert.False(sut.IsPalindrome(s));
        }
    }
}