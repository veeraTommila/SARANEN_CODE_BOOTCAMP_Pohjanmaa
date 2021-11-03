using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_Asp_SQL_demo_2.Models
{
    public partial class CustomerAndSuppliersByCity
    {
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Relationship { get; set; }
    }
}
