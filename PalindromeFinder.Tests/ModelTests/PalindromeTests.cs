using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace PalindromeFinder.Tests
{
  [TestClass]
  public class PalindromeTestTests
  {
    [TestMethod]
    public void IsPalindrome_WordIsPal_True()
    {
      Palindrome testPalindrome = new Palindrome();
      Assert.AreEqual(true, testPalindrome.IsPalindrome());
    }
  }
}
//Go hang a salami, I’m a lasagna hog.
