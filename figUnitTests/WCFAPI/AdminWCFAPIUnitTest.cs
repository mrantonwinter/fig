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
    public class AdminWCFAPIUnitTest : BaseUnitTest
    {
        protected const string _base = "WCF_API/Admin";
        protected const string _local = _base + "Local";
        protected const string _dev = _base + "Dev";
        protected const string _integration = _base + "Integration";
        protected const string _uat = _base + "UAT";
        protected const string _svt = _base + "SVT";
        protected const string _production = _base + "Production";

        ///////////////////////////////////////////////////////////////////////////////////////////
        //Admin WCF API locals

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void ClientAdminLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "client")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void EventAdminLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "event")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void RiskAdminLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "risk")));
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        //Admin WCF API dev

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void ClientAdminDev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "client")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void EventAdminDev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "event")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void RiskAdminDev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "risk")));
        }
    }
}
