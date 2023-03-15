using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Model
{
    public class ViewManagePackage
    {
        public int? IdService { get; set; }
        public int IdPackage { get; set; }
        public int IdDetailPackage { get; set; }
        public int TotalUnitServiceDetailPackage { get; set; }
        public int EstimationDurationService { get; set; }
        public int PriceUnitService { get; set; }
        public string? NameService { get; set; }
    }
}
