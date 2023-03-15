using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Model
{
    public class ServiceTransactionModel
    {
        public int IdService { get; set; }
        public string? ServiceName { get; set; }
        public int ServicePrice { get; set; }
        public int TotalUnit { get; set; }
        public int EstimationTimePerService { get; set; }
        public int SubTotal { get; set; }
    }
}
