using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGyM.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Admin()
        {
        }
        public override string ToString()
        {
            return $"{UserName}";
        }
    }
}
