using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Model
{
    public class HeaderTransaction
    {
        public int IdHeaderTransaction { get; set; }
        public int IdEmployee { get; set; }
        public int IdCostumer { get; set; }
        public DateTime TransactionDateTimeHeaderTransaction { get; set; }
        public DateTime CompleteEstimationDateTimeHeaderTransaction { get; set; }
    }
}
