using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace figUnitTests
{
    [TestClass]
    public class SQLAccessUnitTest : BaseUnitTest
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        // local 

        [TestMethod]
        [TestCategory("Database local")]
        public void ReadLocal()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("Database local")]
        public void WriteLocal()
        {
            Assert.Fail();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // dev 

        [TestMethod]
        [TestCategory("Database dev")]
        public void ReadDev()
        {
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("Database dev")]
        public void WriteDev()
        {
            Assert.Fail();
        }
    }
}
