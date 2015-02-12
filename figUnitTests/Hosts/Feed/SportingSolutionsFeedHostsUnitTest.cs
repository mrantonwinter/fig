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
    public class SportingSolutionsFeedHostsUnitTest : BaseUnitTest
    {


        static string machineNameDev = "";
        static string _dev = "NServiceBusHosts/SportingSolutionsDev";
        static string _local = "NServiceBusHosts/SportingSolutionsLocal";


        public SportingSolutionsFeedHostsUnitTest()
        {
            machineNameDev = Setting(_dev, "MachineName");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        //local

        [TestMethod]
        [TestCategory("Sporting solutions feed host local")]
        public void SportingSolutionsFeedReader_Local()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().Status(Setting(_local, "FeedReader")));
        }

        [TestMethod]
        [TestCategory("Sporting solutions feed host local")]
        public void SportingSolutionsAggregator_Local()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().Status(Setting(_local, "Aggregator")));
        }


        [TestMethod]
        [TestCategory("Sporting solutions feed host local")]
        public void SportingSolutionsWorkerInPlay_Local()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().Status(Setting(_local, "WorkerInPlay")));
        }

        [TestMethod]
        [TestCategory("Sporting solutions feed host local")]
        public void SportingSolutionsWorkerPreMatch_Local()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().Status(Setting(_local, "WorkerPreMatch")));
        }

        [TestMethod]
        [TestCategory("Sporting solutions feed host local")]
        public void SportingSolutionsFeedHandlerInPlay_Local()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().Status(Setting(_local, "FeedHandlerInPlay")));
        }

        [TestMethod]
        [TestCategory("Sporting solutions feed host local")]
        public void SportingSolutionsFeedHandlerPreMatch_Local()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().Status(Setting(_local, "FeedHandlerPreMatch")));
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        //dev

        [TestMethod]
        [TestCategory("Sporting solutions feed host dev")]
        public void SportingSolutionsFeedReader_Dev()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().RemoteStatus(machineNameDev, Setting(_dev, "FeedReader")));
        }

        [TestMethod]
        [TestCategory("Sporting solutions feed host dev")]
        public void SportingSolutionsAggregator_Dev()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().RemoteStatus(machineNameDev, Setting(_dev, "Aggregator")));
        }


        [TestMethod]
        [TestCategory("Sporting solutions feed host dev")]
        public void SportingSolutionsWorkerInPlay_Dev()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().RemoteStatus(machineNameDev, Setting(_dev,"WorkerInPlay")));
        }

        [TestMethod]
        [TestCategory("Sporting solutions feed host dev")]
        public void SportingSolutionsWorkerPreMatch_Dev()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().RemoteStatus(machineNameDev, Setting(_dev, "WorkerPreMatch")));
        }

        [TestMethod]
        [TestCategory("Sporting solutions feed host dev")]
        public void SportingSolutionsFeedHandlerInPlay_Dev()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().RemoteStatus(machineNameDev, Setting(_dev, "FeedHandlerInPlay")));
        }

        [TestMethod]
        [TestCategory("Sporting solutions feed host dev")]
        public void SportingSolutionsFeedHandlerPreMatch_Dev()
        {
            AssertResult(_c.Resolve<WindowsServiceChecker>().RemoteStatus(machineNameDev, Setting(_dev, "FeedHandlerPrematch")));
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        //integration

        ///////////////////////////////////////////////////////////////////////////////////////////
        //uat

        ///////////////////////////////////////////////////////////////////////////////////////////
        //svt

        ///////////////////////////////////////////////////////////////////////////////////////////
        //production



    }
}
