using fig.ViewModels;
using Microsoft.Practices.Unity;
using NServiceBus;
using NServiceBus.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace fig
{
    public class NServiceBusChecker : IDisposable
    {
        IUnityContainer _c = null;
        IStartableBus _bus = null;

        public NServiceBusChecker(IUnityContainer c)
        {
            _c = c;
            StartBus();
        }

        public void Dispose()
        {
            if (_bus != null)
            {
                _bus.Dispose();
                _bus = null;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////

        protected void StartBus()
        {
            var privateQueueName = "test.queue.1";

            NServiceBus.Configure.Serialization.Xml();
            NServiceBus.Configure.Transactions.Disable();
            NServiceBus.Configure.Features.Disable<Audit>();
            NServiceBus.Configure.Features.Disable<AutoSubscribe>();

            var busConfig = NServiceBus.Configure.With();

            busConfig.DefineEndpointName(privateQueueName);
            busConfig.DefaultBuilder();
            busConfig.UseTransport<Msmq>();
            busConfig.UseInMemoryTimeoutPersister();
            busConfig.UnicastBus().LoadMessageHandlers();

            _bus = busConfig.CreateBus();

            _bus.Start(() => Configure.Instance.ForInstallationOn<NServiceBus.Installation.Environments.Windows>().Install());

        }

        ///////////////////////////////////////////////////////////////////////////////////////////

        //protected async void WaitForAlive(CancellationToken token)
        protected  void WaitForAlive(CancellationToken token)
        {
            //await Task.Delay(30 * 1000, token);  //30 seconds
            //Task.Delay(30); 
            Thread.Sleep(10 * 1000);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// marketing admin
        /// </summary>
        /// <returns></returns>
        public Result CheckTBSMarketingAdminEventsAlive()
        {
            Result result = new Result().Init(false, "Timed out");
            var token = new CancellationTokenSource();

            MarketingAdminAliveMessageHandler.Callback = msg =>
            {
                MarketingAdminAliveMessageHandler.Callback = null;
                result.Init(true, "Alive");
                token.Cancel();
            };

            _bus.Subscribe<TBS.MarketingAdmin.Events.Alive>();

            WaitForAlive(token.Token);

            _bus.Unsubscribe<TBS.MarketingAdmin.Events.Alive>();
            MarketingAdminAliveMessageHandler.Callback = null;

            return result;
        }

        /// <summary>
        /// service broker
        /// </summary>
        /// <returns></returns>
        public Result CheckTBSServiceBrokerEventsAlive()
        {
            Result result = new Result().Init(null, "Timed out");
            var token = new CancellationTokenSource();

            ServiceBrokerAliveMessageHandler.Callback = msg =>
            {
                ServiceBrokerAliveMessageHandler.Callback = null;
                result.Init(true, "Alive");
                token.Cancel();
            };

            _bus.Subscribe<TBS.ServiceBroker.Events.Alive>();

            WaitForAlive(token.Token);

            _bus.Unsubscribe<TBS.ServiceBroker.Events.Alive>();
            ServiceBrokerAliveMessageHandler.Callback = null;

            return result;
        }

        /// <summary>
        /// Client Admin
        /// </summary>
        /// <returns></returns>
        public Result CheckTBSClientAdminEventsAlive()
        {
            Result result = new Result().Init(null, "Timed out");
            var token = new CancellationTokenSource();

            ClientAdminAliveMessageHandler.Callback = msg =>
            {
                ClientAdminAliveMessageHandler.Callback = null;
                result.Init(true, "Alive");
                token.Cancel();
            };

            _bus.Subscribe<TBS.ClientAdmin.Events.Alive>();

            WaitForAlive(token.Token);

            _bus.Unsubscribe<TBS.ClientAdmin.Events.Alive>();
            ClientAdminAliveMessageHandler.Callback = null;

            return result;
        }

        public Result CheckTBSAdminEventsAlive()
        {
            Result result = new Result().Init(null, "Timed out");
            var token = new CancellationTokenSource();

            AdminAliveMessageHandler.Callback = msg =>
            {
                AdminAliveMessageHandler.Callback = null;
                result.Init(true, "Alive");
                token.Cancel();
            };

            _bus.Subscribe<TBS.Admin.Events.Alive>();

            WaitForAlive(token.Token);

            _bus.Unsubscribe<TBS.Admin.Events.Alive>();
            AdminAliveMessageHandler.Callback = null;

            return result;
        }

        public Result CheckTBSClientEmailEventsAlive()
        {
            Result result = new Result().Init(null, "Timed out");
            var token = new CancellationTokenSource();

            ClientEmailAliveMessageHandler.Callback = msg =>
            {
                ClientEmailAliveMessageHandler.Callback = null;
                result.Init(true, "Alive");
                token.Cancel();
            };

            _bus.Subscribe<TBS.ClientEmail.Events.Alive>();

            WaitForAlive(token.Token);

            _bus.Unsubscribe<TBS.ClientEmail.Events.Alive>();
            ClientEmailAliveMessageHandler.Callback = null;

            return result;
        }

        public Result CheckTBSEventAdminEventsAlive()
        {
            Result result = new Result().Init(null, "Timed out");
            var token = new CancellationTokenSource();

            ClientEmailAliveMessageHandler.Callback = msg =>
            {
                ClientEmailAliveMessageHandler.Callback = null;
                result.Init(true, "Alive");
                token.Cancel();
            };

            _bus.Subscribe<TBS.EventAdmin.Events.Alive>();

            WaitForAlive(token.Token);

            _bus.Unsubscribe<TBS.EventAdmin.Events.Alive>();
            ClientEmailAliveMessageHandler.Callback = null;

            return result;
        }

        public Result CheckTBSFeedAdminEventsAlive()
        {
            Result result = new Result().Init(null, "Timed out");
            var token = new CancellationTokenSource();

            FeedAdminAliveMessageHandler.Callback = msg =>
            {
                FeedAdminAliveMessageHandler.Callback = null;
                result.Init(true, "Alive");
                token.Cancel();
            };

            _bus.Subscribe<TBS.FeedAdmin.Events.Alive>();

            WaitForAlive(token.Token);

            _bus.Unsubscribe<TBS.FeedAdmin.Events.Alive>();
            FeedAdminAliveMessageHandler.Callback = null;

            return result;
        }

        public Result CheckTBSFinanceEventsAlive()
        {
            Result result = new Result().Init(null, "Timed out");
            var token = new CancellationTokenSource();

            FinanceAliveMessageHandler.Callback = msg =>
            {
                FinanceAliveMessageHandler.Callback = null;
                result.Init(true, "Alive");
                token.Cancel();
            };

            _bus.Subscribe<TBS.Finance.Events.Alive>();

            WaitForAlive(token.Token);

            _bus.Unsubscribe<TBS.Finance.Events.Alive>();
            FinanceAliveMessageHandler.Callback = null;

            return result;
        }

        public Result CheckTBSRiskManagementEventsAlive()
        {
            Result result = new Result().Init(null, "Timed out");
            var token = new CancellationTokenSource();

            RiskManagementAliveMessageHandler.Callback = msg =>
            {
                RiskManagementAliveMessageHandler.Callback = null;
                result.Init(true, "Alive");
                token.Cancel();
            };

            _bus.Subscribe<TBS.RiskManagement.Events.Alive>();

            WaitForAlive(token.Token);

            _bus.Unsubscribe<TBS.RiskManagement.Events.Alive>();
            RiskManagementAliveMessageHandler.Callback = null;

            return result;
        }
    }
}
