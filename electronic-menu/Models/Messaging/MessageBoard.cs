using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace electronic_menu.Models.Messaging
{
    public class MessageBoard
    {
        public static ConcurrentBag<int> waiterRequests = new ConcurrentBag<int>();
    }
}
