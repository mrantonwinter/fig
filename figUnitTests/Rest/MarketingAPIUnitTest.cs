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
    public class MarketingAPIUnitTest : BaseUnitTest
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        // local 

        [TestMethod]
        [TestCategory("Marketing API local")]
        public void Running_local()
        {
            AssertResult(_c.Resolve<HTTPChecker>().Status(Setting("REST_API/MarketingLocal", "running")));
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // dev 

        [TestMethod]
        [TestCategory("Marketing API dev")]
        public void Running_dev()
        {
            Assert.Fail();
        }

    }
}
