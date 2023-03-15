using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Model
{
    public class ViewDetailTransaction
    {
        public int IdHeaderTransaction { get; set; }
        public int IdDetailTransaction { get; set; }
        public int? IdService { get; set; }
        public int? IdPackage { get; set;}
        public string? NameService { get; set; }
        public string? NamePackage { get; set; }
        public int? PricePackage { get; set; }
        public int? PriceUnitService { get;set; }
        public int? TotalUnitTransaction { get; set; }
        public DateTime? CompletedDatetimeDetailTransaction { get;set; }
    }
}
