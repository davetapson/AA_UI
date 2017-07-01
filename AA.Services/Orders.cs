using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA.Services
{
    public class Order
    {
        public int Id { get; set; }
        public int StrategyId { get; set; }
        public string SecurityType { get; set; }
        public string SecurityName {get; set;}
        public int Quantity { get; set; }

        public string OrderType { get; set; }
    }
}
