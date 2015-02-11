using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fig
{

    public class MarketingAdminAliveMessageHandler : IHandleMessages<TBS.MarketingAdmin.Events.Alive>
    {
        public static Action<string> Callback { get; set; }

        public void Handle(TBS.MarketingAdmin.Events.Alive message)
        {
            if (Callback != null)
                Callback(message.GetType().ToString());
        }
    }

    public class ServiceBrokerAliveMessageHandler : IHandleMessages<TBS.ServiceBroker.Events.Alive>
    {
        public static Action<string> Callback { get; set; }

        public void Handle(TBS.ServiceBroker.Events.Alive message)
        {
            if (Callback != null)
                Callback(message.GetType().ToString());
        }
    }

    public class ClientAdminAliveMessageHandler : IHandleMessages<TBS.ClientAdmin.Events.Alive>
    {
        public static Action<string> Callback { get; set; }

        public void Handle(TBS.ClientAdmin.Events.Alive message)
        {
            if (Callback != null)
                Callback(message.GetType().ToString());
        }
    }

    public class AdminAliveMessageHandler : IHandleMessages<TBS.Admin.Events.Alive>
    {
        public static Action<string> Callback { get; set; }
        public void Handle(TBS.Admin.Events.Alive message)
        {
            if (Callback != null)
                Callback(message.GetType().ToString());
        }
    }
    public class ClientEmailAliveMessageHandler : IHandleMessages<TBS.ClientEmail.Events.Alive>
    {
        public static Action<string> Callback { get; set; }
        public void Handle(TBS.ClientEmail.Events.Alive message)
        {
            if (Callback != null)
                Callback(message.GetType().ToString());
        }
    }
    public class EventAdminAliveMessageHandler : IHandleMessages<TBS.EventAdmin.Events.Alive>
    {
        public static Action<string> Callback { get; set; }
        public void Handle(TBS.EventAdmin.Events.Alive message)
        {
            if (Callback != null)
                Callback(message.GetType().ToString());
        }
    }
    public class FeedAdminAliveMessageHandler : IHandleMessages<TBS.FeedAdmin.Events.Alive>
    {
        public static Action<string> Callback { get; set; }
        public void Handle(TBS.FeedAdmin.Events.Alive message)
        {
            if (Callback != null)
                Callback(message.GetType().ToString());
        }
    }
    public class FinanceAliveMessageHandler : IHandleMessages<TBS.Finance.Events.Alive>
    {
        public static Action<string> Callback { get; set; }
        public void Handle(TBS.Finance.Events.Alive message)
        {
            if (Callback != null)
                Callback(message.GetType().ToString());
        }
    }
    public class RiskManagementAliveMessageHandler : IHandleMessages<TBS.RiskManagement.Events.Alive>
    {
        public static Action<string> Callback { get; set; }
        public void Handle(TBS.RiskManagement.Events.Alive message)
        {
            if (Callback != null)
                Callback(message.GetType().ToString());
        }
    }

}
