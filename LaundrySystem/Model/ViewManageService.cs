using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Model
{
    public class ViewManageService
    {
        public string? NameCategory { get; set; }
        public int IdService { get; set; }
        public int IdCategory { get; set; }
        public int IdUnit { get; set; }
        public string? NameService { get; set; }
        public int PriceUnitService { get; set;}
        public int EstimationDurationService { get; set;}
        public string? NameUnit { get; set; }
    }
}
