using fig.ViewModels;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figUnitTests
{
    public class BaseUnitTest :IDisposable
    {
        /// <summary>
        /// unity container
        /// </summary>
        protected IUnityContainer _c;

        ///////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// constructor.  creates a reference to unity container
        /// </summary>
        public BaseUnitTest()
        {
            _c = new UnityContainer();
        }

        public virtual void Dispose()
        {
            if (_c != null)
                _c.Dispose();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // helper functions 

        /// <summary>
        /// assert helper function for Result object
        /// </summary>
        /// <param name="result">The result object to assert against</param>
        protected static void AssertResult(Result result)
        {
            bool success = result.Success != null ? (bool)result.Success : false;
            Assert.IsTrue(success, result.Message);
        }

        /// <summary>
        /// get value for a setting in app.config
        /// </summary>
        /// <param name="section">section name with an array in app.config</param>
        /// <param name="key">the key to identify the setting from the array</param>
        /// <returns></returns>
        protected static string Setting(string section, string key)
        {
            return ((NameValueCollection)ConfigurationManager.GetSection(section))[key];
        }


    }
}
