using fig.ViewModels;
using Microsoft.Practices.Unity;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fig.Services
{
    public class WCFChecker
    {
        protected IUnityContainer _c;
        public WCFChecker(IUnityContainer c)
        {
            _c = c;
        }
        public Result Status(string svcURL)
        {
            var client = new RestClient(svcURL+"?wsdl");
            var response = client.Execute(new RestRequest("", Method.GET));
            if (response.StatusCode==System.Net.HttpStatusCode.OK)
                return _c.Resolve<Result>().Init(true, svcURL + " running");

            return _c.Resolve<Result>().Init(false, svcURL + " failed");
        }
    }
}
