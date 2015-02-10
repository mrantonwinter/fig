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
    public class RavenDBUnitTest:BaseUnitTest
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        // local 

        [TestMethod]
        [TestCategory("RavenDB local")]
        public void RavenDBInstalled_Local()
        {
            AssertResult(_c.Resolve<HTTPChecker>().Status(Setting("DATABASE/RavenDB", "Running")));
        }
    }
}
