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
    public class PhoneBetHostUnitTest : BaseUnitTest
    {
        static string machineNameDev = "";
        static string _dev = "NServiceBusHosts/PhoneBetDev";
        static string _local = "NServiceBusHosts/PhoneBetLocal";

        public PhoneBetHostUnitTest()
        {
            machineNameDev = Setting(_dev, "MachineName");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        //local

        [TestMethod]
        [TestCategory("Phonebet host local")]
        public void PhoneBetHost_Local()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().Status(Setting(_local, "PhoneBet")));
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        //phone bet host dev

        [TestMethod]
        [TestCategory("Phonebet host dev")]
        public void PhoneBetHost_Dev()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().RemoteStatus(machineNameDev,Setting(_dev, "PhoneBet")));
        }
    }
}
