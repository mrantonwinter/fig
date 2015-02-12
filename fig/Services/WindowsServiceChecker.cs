using fig.ViewModels;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace fig.Services
{
    public class WindowsServiceChecker
    {
        protected IUnityContainer _c;
        public WindowsServiceChecker(IUnityContainer c)
        {
            _c = c;
        }
        public Result Status(string serviceName)
        {
            ServiceController msQue = ServiceController.GetServices().ToList().Find(o => o.ServiceName == serviceName);

            if (msQue == null)
                return _c.Resolve<Result>().Init(false, serviceName + " not installed");

            if (msQue.Status != ServiceControllerStatus.Running)
                return _c.Resolve<Result>().Init(false, serviceName + " not running");

            return _c.Resolve<Result>().Init(true, serviceName + " installed and running");
        }


        public Result RemoteStatus(string machineName, string serviceName)
        {
            var sc = new ServiceController();
            sc.MachineName = machineName;
            sc.ServiceName = serviceName;

            if (sc.Status.Equals(ServiceControllerStatus.Running))
                return _c.Resolve<Result>().Init(true, serviceName + " installed and running");

            return _c.Resolve<Result>().Init(false, serviceName + " not running");
        }
    }


}
