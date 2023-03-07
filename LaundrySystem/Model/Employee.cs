using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundrySystem.Model
{
    public class Employee
    {
        public int IdEmployee { get; set; }
        public int IdJob { get; set; }
        public string? PasswordEmployee { get; set; }
        public string? NameEmployee { get; set; }
        public string? EmailEmploye { get; set; }
        public string? AddressEmployee { get; set; }
        public string? PhoneNumberEmployee { get; set; }
        public DateTime? DateOfBirthEmployee { get; set; }
        public int? SalaryEmployee { get; set; }
    }
}
