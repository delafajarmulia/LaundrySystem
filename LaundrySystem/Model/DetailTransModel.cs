using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Model
{
    public class DetailTransModel
    {
        public int IdHeaderTrans { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int PricePerUnit { get; set; }
        public int TotalUnit { get; set; }
        public DateTime? CompleteTime { get; set; }
    }
}
