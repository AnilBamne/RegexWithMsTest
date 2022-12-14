using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexTestUserResistration;

namespace RegexTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("FirstName")]
        [DataRow("Anil",true)]
        [DataRow("anil",false)]
        [DataRow("xy",false)]
        public void TestFirstName(string fName,bool result)
        {
            ///AAA -> Arrange Act Assert
            Patterns p = new Patterns();
            //Act
            bool actual=p.FirstName(fName);
            //Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        [TestCategory("LastName")]
        [DataRow("Bamne", true)]
        [DataRow("anil", false)]
        [DataRow("xyz", false)]
        public void TestLastName(string fName, bool result)
        {
            ///AAA -> Arrange Act Assert
            Patterns p = new Patterns();
            //Act
            bool actual = p.LastName(fName);
            //Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        [TestCategory("Email")]
        [DataRow("abc.xyz@bl.co.in", true)]
        [DataRow("anil.12@gmail.com", false)]
        [DataRow("abc.xyz@bl.com", false)]
        public void TestEmail(string email, bool result)
        {
            ///AAA -> Arrange Act Assert
            Patterns p = new Patterns();
            //Act
            bool actual = p.Email(email);
            //Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        [TestCategory("MobileNum")]
        [DataRow("91 8152817066", true)]
        [DataRow("99999999", false)]
        [DataRow("9181528170", false)]
        public void MobileNum(string mobile, bool result)
        {
            ///AAA -> Arrange Act Assert
            Patterns p = new Patterns();
            //Act
            bool actual = p.MobileNum(mobile);
            //Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        [TestCategory("Password rule1")]    //Minimum 8 charecters
        [DataRow("AnilBamn", true)]
        [DataRow("abxu", false)]
        [DataRow("aaaaaaaaaaaaa", true)]
        public void Rule1(string password, bool result)
        {
            ///AAA -> Arrange Act Assert
            Patterns p = new Patterns();
            //Act
            bool actual = p.Password1(password);
            //Assert
            Assert.AreEqual(result, actual);
        }
    }
}
