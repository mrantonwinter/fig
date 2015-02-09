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
        public void BetInterceptLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "BetIntercept.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void ClientAdminLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "ClientAdmin.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void MessagingLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Messaging.API")));
        }
      
        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void DomainLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Domain.API")));
        }      
      
        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void SearchLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Search.API")));
        }
      
        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void SettlerLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Settler.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void RiskManagementLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "RiskManagement.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void MarketingAdminLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "MarketingAdmin.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void ReportingLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Reporting.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void FeedAdminLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "FeedAdmin.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void FinanceLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Finance.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void CreditCardLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "CreditCard.API")));
        }
      
        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void ClientEmailSmsLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "ClientEmailSms.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void AdminLocal()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Admin.API")));
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
