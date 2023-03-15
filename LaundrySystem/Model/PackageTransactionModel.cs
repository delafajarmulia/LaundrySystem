using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Model
{
    public class PackageTransactionModel
    {
        public int IdPackage { get; set; }
        public string? PackageName { get; set; }
        public int PackagePrice { get; set;}
        public int Quantity { get; set; }
        public int EstimationTimePerPackage { get; set; }
        public int SubTotal { get; set; }
    }
}
