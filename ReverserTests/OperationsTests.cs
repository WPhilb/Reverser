using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reverser;

namespace ReverserTests
{
    [TestClass]
    public class OperationsTests
    {
        [TestMethod]
        public void ReverseWords_WithMoreThanOneWord_ReversesWords()
        {
            string input = "The quick brown fox";
            string expected = "fox brown quick The";

            Assert.AreEqual(expected, Operations.ReverseWords(input));
        }

        [TestMethod]
        public void ReverseLettersInEachWord_ReversesLettersInEachWord()
        {
            string input = "The quick brown fox";
            string expected = "ehT kciuq nworb xof";

            Assert.AreEqual(expected, Operations.ReverseLettersInEachWord(input));
        }
    }
}
