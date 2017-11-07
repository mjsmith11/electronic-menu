using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data_models.Models.Messaging;

namespace data_models.Models.ViewModels
{
    public class TablesWithRequests
    {
        public IEnumerable<Table> Tables { get; set; }
        public List<WaiterRequest> WaiterRequests { get; set; }
    }
}
