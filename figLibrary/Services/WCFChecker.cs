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
    public class WCFChecker:HTTPChecker
    {
        public WCFChecker(IUnityContainer c)
            : base(c)
        {

        }
        public override Result Status(string url)
        {
            return base.Status(url+"?wsdl");
        }

    }
}
