using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data_models.Models.ViewModels
{
    public class TablesWithRequests
    {
        public IEnumerable<Table> Tables { get; set; }
        public List<int> WaiterRequests { get; set; }
    }
}
