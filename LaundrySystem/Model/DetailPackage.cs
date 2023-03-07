using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Model
{
    public class DetailPackage
    {
        public int IdDetailPackage { get; set; }
        public int IdService { get; set; }
        public int IdPackage { get; set; }
        public int TotalUnitServiceDetailPackage { get; set; }
    }
}
