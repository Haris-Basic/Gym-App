using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGyM
{
    public class Payments
    {
        public int Id { get; set; }
        public Members Memeber { get; set; }
        public float Amount { get; set; }
        public string Currency { get; set; }
        public string Date { get; set; }
    }
}
