using System;
using System.Collections.Generic;

#nullable disable

namespace MVC_Asp_SQL_demo_2.Models
{
    public partial class SummaryOfSalesByYear
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
