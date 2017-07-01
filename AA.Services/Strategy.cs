using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA.Services
{
    public class Strategy
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public bool Enabled { get; set; }
        public List<Order> Orders { get; set; }
        public int AccountId { get; set; }
    }
}
