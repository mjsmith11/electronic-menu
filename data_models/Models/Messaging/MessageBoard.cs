using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data_models.Models.Messaging
{
    public class MessageBoard
    {
        public static ConcurrentBag<int> waiterRequests = new ConcurrentBag<int>();
    }
}
