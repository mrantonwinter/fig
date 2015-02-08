using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using fig.Services;

namespace figUnitTests
{
    [TestClass]
    public class WindowsServicesUnitTest : BaseUnitTest
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        //windows services local

        [TestMethod]
        [TestCategory("Windows services local")]
        public void MSMQInstalled()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().Status("MSMQ"));
        }

        [TestMethod]
        [TestCategory("Windows services local")]
        public void DTCInstalled()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().Status("MSDTC"));
        }

    }
}
