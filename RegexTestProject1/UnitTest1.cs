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
    }
}
