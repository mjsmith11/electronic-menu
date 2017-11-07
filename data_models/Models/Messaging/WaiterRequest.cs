using System;
using System.Collections.Generic;
using System.Text;

namespace data_models.Models.Messaging
{
    public class WaiterRequest
    {
        public int TableNumber { get; set; }
        public string Request { get; set; }
    }
}
