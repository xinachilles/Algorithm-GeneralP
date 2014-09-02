using Algorithm_GeneralP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for GeneralPTest and is intended
    ///to contain all GeneralPTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GeneralPTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }





        /// <summary>
        ///A test for IsPalindrome
        ///</summary>
        [TestMethod()]
        public void IsPalindromeTest()
        {
            GeneralP target = new GeneralP(); // TODO: Initialize to an appropriate value
            string s = "A man, a plan, a canal: Panama";// TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsPalindrome(s);
           
        }

        /// <summary>
        ///A test for IsInterleave
        ///</summary>
        [TestMethod()]
        public void IsInterleaveTest()
        {
            GeneralP target = new GeneralP(); // TODO: Initialize to an appropriate value
            string s1 = "aabcc"; // TODO: Initialize to an appropriate value
            string s2 = "dbbca"; // TODO: Initialize to an appropriate value
            string s3 = "aadbbcbcac"; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsInterleave(s1, s2, s3);
           
        }
    }
}
