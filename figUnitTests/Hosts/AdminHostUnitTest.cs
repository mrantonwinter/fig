using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using fig;
using Microsoft.Practices.Unity;

namespace figUnitTests
{
    [TestClass]
    public class AdminHostUnitTest : BaseUnitTest, IDisposable
    {
        static NServiceBusChecker _busDev = null;


        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
            _busDev = new NServiceBusChecker(new UnityContainer());
        }

        // Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            if (_busDev != null)
                _busDev.Dispose();        
        }


        ///////////////////////////////////////////////////////////////////////////////////////////
        //admin hosts locals

        [TestMethod]
        [TestCategory("Admin hosts local")]
        public void AdminHostLocal()
        {
            Assert.Fail("***** Todo *****");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        //admin hosts dev

        [TestMethod]
        [TestCategory("Admin hosts dev")]
        public void MarketingAdminHostAlive_Dev()
        {
            AssertResult(_busDev.CheckTBSMarketingAdminEventsAlive());
        }

        [TestMethod]
        [TestCategory("Admin hosts dev")]
        public void ServiceBrokerHostAlive_Dev()
        {
            AssertResult(_busDev.CheckTBSServiceBrokerEventsAlive());
        }

        [TestMethod]
        [TestCategory("Admin hosts dev")]
        public void AdminHostAlive_Dev()
        {
            AssertResult(_busDev.CheckTBSClientAdminEventsAlive());
        }

        [TestMethod]
        [TestCategory("Admin hosts dev")]
        public void EmailHostAlive_Dev()
        {
            AssertResult(_busDev.CheckTBSClientEmailEventsAlive());
        }

        [TestMethod]
        [TestCategory("Admin hosts dev")]
        public void EventAdminHostAlive_Dev()
        {
            AssertResult(_busDev.CheckTBSEventAdminEventsAlive());
        }

        [TestMethod]
        [TestCategory("Admin hosts dev")]
        public void FeedAdminHostAlive_Dev()
        {
            AssertResult(_busDev.CheckTBSFeedAdminEventsAlive());
        }

        [TestMethod]
        [TestCategory("Admin hosts dev")]
        public void FinanceAdminHostAlive_Dev()
        {
            AssertResult(_busDev.CheckTBSFinanceEventsAlive());
        }

        [TestMethod]
        [TestCategory("Admin hosts dev")]
        public void RiskManagementAdminHostAlive_Dev()
        {
            AssertResult(_busDev.CheckTBSRiskManagementEventsAlive());
        }
    }
}
