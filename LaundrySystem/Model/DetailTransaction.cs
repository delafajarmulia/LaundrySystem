using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Model
{
    public class DetailTransaction
    {
        public int IdDetailTransaction { get; set; }
        public int? IdService { get; set; }
        public int IdHeaderTransaction { get; set; }
        public int? IdPackage { get; set; }
        public int PriceDetailTransaction { get; set; }
        public int TotalUnitTransaction { get; set;}
        public DateTime? CompletedDatetimeDetailTransaction { get; set; }
    }
}
