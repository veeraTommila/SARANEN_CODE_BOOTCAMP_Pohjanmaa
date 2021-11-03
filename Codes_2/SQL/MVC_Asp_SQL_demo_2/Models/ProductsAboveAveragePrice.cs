using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_Asp_SQL_demo_2.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
