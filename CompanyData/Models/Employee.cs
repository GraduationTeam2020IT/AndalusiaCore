using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyData.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}