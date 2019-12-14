using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartsWithUpper()
        {
            string[] words = { "Alphabet", "Zulu", "ABC", "Витош", "ВитошАкадемия.ком" };
            foreach (string word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result, String.Format("Expected for '{0}': true; Actual {1}",word, result));
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            string[] words = { "alphabet", "zulu", "aBC", "ш", "ком","55",".","" };
            foreach (string word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result, String.Format("Expected for '{0}': true; Actual {1}", word, result));
            }
        }

        [TestMethod]
        public void TestWithNullOrEmpty()
        {
            string[] words = {string.Empty, null};
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result, String.Format("Expected for '{0}': false; Actual {1}",
                    word == null ? "<null>" : word, result ));
            }
        }
    }
}
