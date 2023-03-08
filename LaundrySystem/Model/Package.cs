using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Model
{
    public class Package
    {
        public int IdPackage { get; set; }
        public string? NamePackage { get; set; }
        public int? PricePackage { get; set; }
        public string? DescriptionPackage { get; set; }
        public int? DurationPackage { get; set; }
    }
}
