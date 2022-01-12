using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Hangman;

namespace Hangman_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AddMethod()
            {
                HangmanGame bm = new HangmanGame();
                double res = bm.TotalGuesses(10, 10);
                Assert.AreEqual(res, 20);
            }
        }
    }
}


