using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using fig.Services;
using fig.ViewModels;
using System.Collections.Specialized;

namespace figUnitTests
{
    [TestClass]
    public class BettingAPIUnitTest : BaseUnitTest
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        // local 

        [TestMethod]
        [TestCategory("Betting API local")]
        public void Running_local()
        {
            AssertResult(_c.Resolve<HTTPChecker>().Status(Setting("REST_API/BettingAPILocal", "Running")));

        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // dev 

        [TestMethod]
        [TestCategory("Betting API dev")]
        public void Running_dev()
        {
            Assert.Fail("***** Todo *****");
        }

    }
}
