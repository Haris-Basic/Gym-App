using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MyGyM
{
    public class Members
    {
        public int Id { get; set; }
        public string JMBG { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
        public override string ToString()
        {
            return $" {JMBG} | {FName} {LName}";
        }


    }
}
