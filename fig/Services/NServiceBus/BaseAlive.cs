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