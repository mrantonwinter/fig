using NServiceBus;
using System;

namespace Base
{
    [Serializable]
    [Express]
    [TimeToBeReceived("00:01:00")]
    public class Alive : IEvent
    {
        public string Who { get; set; }
        public DateTime TimestampUTC { get; set; }
    }
}

namespace TBS.Admin.Events
{
    public class Alive : Base.Alive { }
}

namespace TBS.ClientAdmin.Events
{
    public class Alive : Base.Alive { }
}

//clientadminsms
namespace TBS.ClientEmail.Events
{
    public class Alive : Base.Alive { }
}

namespace TBS.EventAdmin.Events
{
    public class Alive : Base.Alive { }
}

namespace TBS.FeedAdmin.Events
{
    public class Alive : Base.Alive { }
}

namespace TBS.Finance.Events
{
    public class Alive : Base.Alive { }
}

namespace TBS.MarketingAdmin.Events
{
    public class Alive : Base.Alive { }
}

namespace TBS.RiskManagement.Events
{
    public class Alive : Base.Alive { }
}

namespace TBS.ServiceBroker.Events
{
    public class Alive : Base.Alive { }
}

namespace TBS.Domain.Events
{
    public class Alive : Base.Alive { }
}

