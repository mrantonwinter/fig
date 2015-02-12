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
    public class HTTPChecker
    {
        protected IUnityContainer _c;
        public HTTPChecker(IUnityContainer c)
        {
            _c = c;
        } 
        public virtual Result Status(string url)
        {
            var client = new RestClient(url);
            var response = client.Execute(new RestRequest("", Method.GET));
            if (response.StatusCode==System.Net.HttpStatusCode.OK)
                return _c.Resolve<Result>().Init(true, url + " running");

            return _c.Resolve<Result>().Init(false, url + " failed");
        }
    }
}
