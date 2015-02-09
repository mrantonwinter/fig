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
        public void BetIntercept_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "BetIntercept.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void ClientAdmin_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "ClientAdmin.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void Messaging_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Messaging.API")));
        }
      
        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void Domain_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Domain.API")));
        }      
      
        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void Search_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Search.API")));
        }
      
        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void Settler_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Settler.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void RiskManagement_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "RiskManagement.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void MarketingAdmin_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "MarketingAdmin.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void Reporting_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Reporting.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void FeedAdmin_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "FeedAdmin.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void Finance_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Finance.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void CreditCard_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "CreditCard.API")));
        }
      
        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void ClientEmailSms_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "ClientEmailSms.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API local")]
        public void Admin_Local()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_local, "Admin.API")));
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        //Admin WCF API dev

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void BetIntercept_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "BetIntercept.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void ClientAdmin_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "ClientAdmin.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void Messaging_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "Messaging.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void Domain_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "Domain.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void Search_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "Search.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void Settler_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "Settler.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void RiskManagement_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "RiskManagement.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void MarketingAdmin_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "MarketingAdmin.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void Reporting_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "Reporting.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void FeedAdmin_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "FeedAdmin.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void Finance_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "Finance.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void CreditCard_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "CreditCard.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void ClientEmailSms_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "ClientEmailSms.API")));
        }

        [TestMethod]
        [TestCategory("Admin WCF API dev")]
        public void Admin_Dev()
        {
            AssertResult(_c.Resolve<WCFChecker>().Status(Setting(_dev, "Admin.API")));
        }
    }
}
