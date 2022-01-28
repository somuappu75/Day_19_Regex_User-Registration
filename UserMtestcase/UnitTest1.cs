using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regex_User_Registration;
using System;

namespace UserMtestcase
{
    [TestClass]
    public class UnitTest1
    {


        //validation for first Name
        [TestMethod]
        [DataRow("Somanath", "Somana")]
        [DataRow("Som", "Som")]
        [DataRow("s", null)]
        [DataRow("Somu75", null)]

        public void ValidateFirstname(string a, string expected)
        {

            var actual = RegexSample.ValidatingFirstName(a);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
